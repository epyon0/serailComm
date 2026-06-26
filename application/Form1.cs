using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace application
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // click and drag form

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION;
            }

            // resize form with mouse
            if (m.Msg == 0x84) // WM_NCHITTEST
            {
                Point cursorPos = PointToClient(Cursor.Position);
                int borderSize = 10; // Adjust sensitivity

                if (cursorPos.X < borderSize && cursorPos.Y < borderSize)
                    m.Result = (IntPtr)16; // HTTOPLEFT
                else if (cursorPos.X > Width - borderSize && cursorPos.Y < borderSize)
                    m.Result = (IntPtr)17; // HTTOPRIGHT
                else if (cursorPos.X < borderSize && cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)15; // HTBOTTOMLEFT
                else if (cursorPos.X > Width - borderSize && cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)13; // HTBOTTOMRIGHT
                else if (cursorPos.X < borderSize)
                    m.Result = (IntPtr)10; // HTLEFT
                else if (cursorPos.X > Width - borderSize)
                    m.Result = (IntPtr)11; // HTRIGHT
                else if (cursorPos.Y < borderSize)
                    m.Result = (IntPtr)12; // HTTOP
                else if (cursorPos.Y > Height - borderSize)
                    m.Result = (IntPtr)14; // HTBOTTOM
            }
        }

        private void output(string text)
        {
            outputRichtextbox.Invoke(new Action(() =>
            {
                outputRichtextbox.AppendText(text);
                this.Refresh();
            }));
        }

        private void debug(string text, [CallerMemberName] string caller = "", [CallerLineNumber] int line = 0)
        {
            DateTime now = DateTime.Now;
            output(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{line} | " + text + Environment.NewLine);
        }

        private void getSerialDevices()
        {
            commCombobox.Items.Clear();
            debug("Getting COMM devices");
            List<string> commDevices = SerialPort.GetPortNames().ToList<string>();
            foreach (string commDevice in commDevices)
            {
                commCombobox.Items.Add(commDevice);
            }

            if (commCombobox.Items.Count > 0)
            {
                commCombobox.SelectedIndex = 0;
            }
        }

        private async Task DataReceivedAsyncHandler()
        {
            List<byte> buffer = new List<byte>();
            byte[] readBuffer = new byte[4096];

            while (sp.IsOpen)
            {
                try
                {
                    int bytesRead = await sp.BaseStream.ReadAsync(readBuffer, 0, readBuffer.Length);
                    if (bytesRead > 0)
                    {
                        for (int i = 0; i < bytesRead; i++)
                        {
                            buffer.Add(readBuffer[i]);

                            while (buffer.Contains((byte)'\n'))
                            {
                                int index = buffer.IndexOf((byte)'\n');
                                byte[] messageBytes = buffer.Take(index).ToArray();
                                buffer.RemoveRange(0, index + 1);

                                Task.Run(() =>
                                {
                                    rxRichtextbox.Invoke(new Action(() => rxRichtextbox.AppendText(BitConverter.ToString(messageBytes).Replace('-', ' ') + " ")));
                                    output(System.Text.Encoding.UTF8.GetString(messageBytes));
                                });
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    debug($"EXCEPTION: IO Exception, port closed or error");
                    break;
                }
            }
        }

        private void updateStats()
        {
            if (sp.IsOpen)
            {
                readbuffersize.Invoke(new Action(() => readbuffersize.Text = $"Buffer Size: {sp.ReadBufferSize}"));
                readtimeout.Invoke(new Action(() => readtimeout.Text = $"Timeout: {sp.ReadTimeout} ms"));
                bytestoread.Invoke(new Action(() => bytestoread.Text = $"Bytes: {sp.BytesToRead}"));

                writebuffersize.Invoke(new Action(() => writebuffersize.Text = $"Buffer Size: {sp.WriteBufferSize}"));
                writetimeout.Invoke(new Action(() => writetimeout.Text = $"Timeout: {sp.WriteTimeout} ms"));
                bytestowrite.Invoke(new Action(() => bytestowrite.Text = $"Bytes: {sp.BytesToWrite}"));

                cts.Invoke(new Action(() => cts.Text = $"CTS: {sp.CtsHolding}"));
                breakstate.Invoke(new Action(() => breakstate.Text = $"Break: {sp.BreakState}"));
                cdline.Invoke(new Action(() => cdline.Text = $"CD Line: {sp.CDHolding}"));
                rts.Invoke(new Action(() => rts.Text = $"RTS: {sp.RtsEnable}"));
                dsr.Invoke(new Action(() => dsr.Text = $"DSR: {sp.DsrHolding}"));
                dtr.Invoke(new Action(() => dtr.Text = $"DTR: {sp.DtrEnable}"));
                encoding.Invoke(new Action(() => encoding.Text = $"Encoding: {sp.Encoding.EncodingName}"));
                handshake.Invoke(new Action(() => handshake.Text = $"Handshake: {sp.Handshake.ToString()}"));
                open.Invoke(new Action(() => open.Text = $"Open: {sp.IsOpen}"));
                newline.Invoke(new Action(() =>
                {
                    switch (sp.NewLine)
                    {
                        case "\n":
                            newline.Text = $"Newline: \\n";
                            break;
                        case "\r":
                            newline.Text = $"Newline: \\r";
                            break;
                        default:
                            newline.Text = $"Newline: {sp.NewLine}";
                            break;
                    }
                }));

                this.Invoke(new Action(() => this.Refresh()));
            }
        }

        private string getDeviceName(string portName)
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort"))
            {
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var device = ports.FirstOrDefault(p => p["DeviceID"].ToString() == portName);

                if (device != null)
                {
                    return device["Caption"]?.ToString();
                }
            }
            return null;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            debug("Form loaded");
            getSerialDevices();
            if (speedCombobox.Items.Count > 11) { speedCombobox.SelectedIndex = 12; }
            if (parityCombobox.Items.Count > 0) { parityCombobox.SelectedIndex = 0; }
            if (flowcontrolCombobox.Items.Count > 1) { flowcontrolCombobox.SelectedIndex = 1; };
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (maxButton.Text == "⧠")
            {
                debug("Maximize form");
                this.WindowState = FormWindowState.Maximized;
                maxButton.Text = "⧉";
                return;
            }

            if (maxButton.Text == "⧉")
            {
                debug("Restore form");
                this.WindowState = FormWindowState.Normal;
                maxButton.Text = "⧠";
                return;
            }
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maxButton_Click(sender, e);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.LinkText,
                UseShellExecute = true
            });
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            debug("Minimize form");
            this.WindowState = FormWindowState.Minimized;
        }

        private void commCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            debug($"Port selected: [{commCombobox.Text}] {getDeviceName(commCombobox.Text)}");
            updateStats();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (connectButton.Text == "Connect")
            {
                string device = commCombobox.Text;
                int baudRate = 9600;
                Parity parity = Parity.None;
                int dataBits = 8;
                StopBits stopBits = StopBits.None;

                commCombobox.Enabled = false;
                speedCombobox.Enabled = false;
                databitsNumericUpDown.Enabled = false;
                stopbitsNumericUpDown.Enabled = false;
                parityCombobox.Enabled = false;
                flowcontrolCombobox.Enabled = false;
                outputRichtextbox.ReadOnly = false;
                refreshButton.Enabled = false;

                try { baudRate = int.Parse(speedCombobox.Text); } catch (Exception ex) { debug($"EXCEPTION: [SPEED/BAUD RATE]: {ex.Message}"); }
                try
                {
                    switch (parityCombobox.Text)
                    {
                        case "None":
                            parity = Parity.None; break;
                        case "Odd":
                            parity = Parity.Odd; break;
                        case "Even":
                            parity = Parity.Even; break;
                        case "Mark":
                            parity = Parity.Mark; break;
                        case "Space":
                            parity = Parity.Space; break;
                    }
                }
                catch (Exception ex) { debug($"EXCEPTION: [PARITY]: {ex.Message}"); }
                try { dataBits = int.Parse(databitsNumericUpDown.Value.ToString()); } catch (Exception ex) { debug($"EXCEPTION: [DATA BITS]: {ex.Message}"); }
                try
                {
                    switch (stopbitsNumericUpDown.Value)
                    {
                        case 0M:
                            stopBits = StopBits.None; break;
                        case 1M:
                            stopBits = StopBits.One; break;
                        case 1.5M:
                            stopBits = StopBits.OnePointFive; break;
                        case 2M:
                            stopBits = StopBits.Two; break;
                    }
                }
                catch (Exception ex) { debug($"EXCEPTION: [STOP BITS]: {ex.Message}"); }

                sp = new SerialPort(device, baudRate, parity, dataBits, stopBits);
                debug($"Opening serial interface: {device}");
                connectButton.Text = "Disconnect";
                if (sp.IsOpen)
                {
                    debug($"Serial port [{device}] is already open");
                    return;
                }

                sp.Open();
                _ = DataReceivedAsyncHandler();
                updateStats();
                return;
            }

            if (connectButton.Text == "Disconnect")
            {
                commCombobox.Enabled = true;
                speedCombobox.Enabled = true;
                databitsNumericUpDown.Enabled = true;
                stopbitsNumericUpDown.Enabled = true;
                parityCombobox.Enabled = true;
                flowcontrolCombobox.Enabled = true;
                outputRichtextbox.ReadOnly = true;
                refreshButton.Enabled = true;

                debug($"Closing serial interface: {commCombobox.Text}");
                if (sp.IsOpen)
                {
                    sp.Close();
                }
                else
                {
                    debug($"Serial interface [{commCombobox.Text}] is not open");
                }

                connectButton.Text = "Connect";
                updateStats();
                return;
            }
        }

        private void outputRichtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sp.IsOpen)
            {
                txRichtextbox.AppendText(((int)e.KeyChar).ToString("X2") + " ");
                sp.Write(e.KeyChar.ToString());
                updateStats();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            getSerialDevices();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Invoke(new Action(() => timeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")));
        }

        private void outputRichtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.Left || e.KeyData == Keys.Right || e.KeyData == Keys.Home)
            {
                outputRichtextbox.Invoke(new Action(() =>
                {
                    outputRichtextbox.Select(outputRichtextbox.TextLength, 0);
                    outputRichtextbox.ScrollToCaret();
                    e.Handled = true;
                }));
            }
        }

        private void outputRichtextbox_Click(object sender, EventArgs e)
        {
            outputRichtextbox.Invoke(new Action(() =>
            {
                outputRichtextbox.Select(outputRichtextbox.TextLength, 0);
                outputRichtextbox.ScrollToCaret();
            }));
        }
    }
}
