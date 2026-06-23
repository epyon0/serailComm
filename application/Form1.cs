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
                outputRichtextbox.AppendText(text + Environment.NewLine);
                outputRichtextbox.SelectionStart = outputRichtextbox.TextLength;
                outputRichtextbox.ScrollToCaret();
                this.Refresh();
            }));
        }

        private void debug(string text, [CallerMemberName] string caller = "", [CallerLineNumber] int line = 0)
        {
            DateTime now = DateTime.Now;
            output(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{line} | " + text);
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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            sp = (SerialPort)sender;
            string recvData = sp.ReadExisting();
            debug($"RECV: {recvData}");
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
            debug($"Port selected: {commCombobox.Text}");
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
                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                debug($"Opening serial interface: {device}");
                connectButton.Text = "Disconnect";
                if (sp.IsOpen)
                {
                    debug($"Serial port [{device}] is already open");
                    return;
                }

                sp.Open();
                return;
            }

            if (connectButton.Text == "Disconnect")
            {
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
                return;
            }
        }

        private void outputRichtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sp.IsOpen)
            {
                if (e.KeyChar == '\r' || e.KeyChar == '\n')
                {
                    sp.Write("\r\n");
                } else
                {
                    sp.Write(e.KeyChar.ToString());
                }
            }
        }
    }
}
