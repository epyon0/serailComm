namespace application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            outputRichtextbox = new RichTextBox();
            minButton = new Button();
            maxButton = new Button();
            closeButton = new Button();
            commCombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            speedCombobox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            databitsNumericUpDown = new NumericUpDown();
            stopbitsNumericUpDown = new NumericUpDown();
            parityCombobox = new ComboBox();
            flowcontrolCombobox = new ComboBox();
            connectButton = new Button();
            bytestoread = new Label();
            readbuffersize = new Label();
            label8 = new Label();
            readtimeout = new Label();
            writetimeout = new Label();
            label9 = new Label();
            writebuffersize = new Label();
            bytestowrite = new Label();
            cts = new Label();
            breakstate = new Label();
            cdline = new Label();
            rts = new Label();
            dsr = new Label();
            dtr = new Label();
            encoding = new Label();
            handshake = new Label();
            open = new Label();
            newline = new Label();
            refreshButton = new Button();
            timeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txRichtextbox = new RichTextBox();
            label7 = new Label();
            rxRichtextbox = new RichTextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)databitsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stopbitsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // outputRichtextbox
            // 
            outputRichtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputRichtextbox.BackColor = Color.Black;
            outputRichtextbox.BorderStyle = BorderStyle.None;
            outputRichtextbox.ForeColor = Color.Lime;
            outputRichtextbox.HideSelection = false;
            outputRichtextbox.Location = new Point(12, 154);
            outputRichtextbox.Name = "outputRichtextbox";
            outputRichtextbox.ReadOnly = true;
            outputRichtextbox.Size = new Size(1173, 514);
            outputRichtextbox.TabIndex = 0;
            outputRichtextbox.Text = "";
            outputRichtextbox.LinkClicked += richTextBox1_LinkClicked;
            outputRichtextbox.Click += outputRichtextbox_Click;
            outputRichtextbox.KeyDown += outputRichtextbox_KeyDown;
            outputRichtextbox.KeyPress += outputRichtextbox_KeyPress;
            // 
            // minButton
            // 
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minButton.BackColor = Color.Black;
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minButton.ForeColor = Color.Lime;
            minButton.Location = new Point(1122, 0);
            minButton.Name = "minButton";
            minButton.Size = new Size(25, 25);
            minButton.TabIndex = 1;
            minButton.Text = "—";
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // maxButton
            // 
            maxButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxButton.BackColor = Color.Black;
            maxButton.FlatStyle = FlatStyle.Flat;
            maxButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maxButton.ForeColor = Color.Lime;
            maxButton.Location = new Point(1147, 0);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(25, 25);
            maxButton.TabIndex = 2;
            maxButton.Text = "⧠";
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.Black;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Lime;
            closeButton.Location = new Point(1172, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 3;
            closeButton.Text = "╳";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // commCombobox
            // 
            commCombobox.BackColor = Color.Black;
            commCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            commCombobox.FlatStyle = FlatStyle.Flat;
            commCombobox.ForeColor = Color.Lime;
            commCombobox.FormattingEnabled = true;
            commCombobox.Location = new Point(114, 4);
            commCombobox.Name = "commCombobox";
            commCombobox.Size = new Size(71, 19);
            commCombobox.TabIndex = 4;
            commCombobox.SelectedIndexChanged += commCombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 11);
            label1.TabIndex = 5;
            label1.Text = "Device:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(47, 11);
            label2.TabIndex = 6;
            label2.Text = "Speed:";
            // 
            // speedCombobox
            // 
            speedCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            speedCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            speedCombobox.BackColor = Color.Black;
            speedCombobox.FlatStyle = FlatStyle.Flat;
            speedCombobox.ForeColor = Color.Lime;
            speedCombobox.FormattingEnabled = true;
            speedCombobox.Items.AddRange(new object[] { "50", "75", "110", "134", "150", "200", "300", "600", "1200", "1800", "2400", "4800", "9600", "19200", "28800", "38400", "57600", "76800", "115200", "230400", "460800", "576000", "921600" });
            speedCombobox.Location = new Point(114, 29);
            speedCombobox.Name = "speedCombobox";
            speedCombobox.Size = new Size(71, 19);
            speedCombobox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(75, 11);
            label3.TabIndex = 8;
            label3.Text = "Data Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(75, 11);
            label4.TabIndex = 9;
            label4.Text = "Stop Bits:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(54, 11);
            label5.TabIndex = 10;
            label5.Text = "Parity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(96, 11);
            label6.TabIndex = 11;
            label6.Text = "Flow Control:";
            // 
            // databitsNumericUpDown
            // 
            databitsNumericUpDown.BackColor = Color.Black;
            databitsNumericUpDown.BorderStyle = BorderStyle.None;
            databitsNumericUpDown.ForeColor = Color.Lime;
            databitsNumericUpDown.Location = new Point(114, 58);
            databitsNumericUpDown.Name = "databitsNumericUpDown";
            databitsNumericUpDown.Size = new Size(71, 14);
            databitsNumericUpDown.TabIndex = 12;
            databitsNumericUpDown.TextAlign = HorizontalAlignment.Right;
            databitsNumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // stopbitsNumericUpDown
            // 
            stopbitsNumericUpDown.BackColor = Color.Black;
            stopbitsNumericUpDown.BorderStyle = BorderStyle.None;
            stopbitsNumericUpDown.DecimalPlaces = 1;
            stopbitsNumericUpDown.ForeColor = Color.Lime;
            stopbitsNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            stopbitsNumericUpDown.Location = new Point(114, 79);
            stopbitsNumericUpDown.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            stopbitsNumericUpDown.Name = "stopbitsNumericUpDown";
            stopbitsNumericUpDown.Size = new Size(71, 14);
            stopbitsNumericUpDown.TabIndex = 13;
            stopbitsNumericUpDown.TextAlign = HorizontalAlignment.Right;
            stopbitsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // parityCombobox
            // 
            parityCombobox.BackColor = Color.Black;
            parityCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            parityCombobox.FlatStyle = FlatStyle.Flat;
            parityCombobox.ForeColor = Color.Lime;
            parityCombobox.FormattingEnabled = true;
            parityCombobox.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            parityCombobox.Location = new Point(114, 104);
            parityCombobox.Name = "parityCombobox";
            parityCombobox.Size = new Size(71, 19);
            parityCombobox.TabIndex = 14;
            // 
            // flowcontrolCombobox
            // 
            flowcontrolCombobox.BackColor = Color.Black;
            flowcontrolCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            flowcontrolCombobox.FlatStyle = FlatStyle.Flat;
            flowcontrolCombobox.ForeColor = Color.Lime;
            flowcontrolCombobox.FormattingEnabled = true;
            flowcontrolCombobox.Items.AddRange(new object[] { "None", "XON/XOFF", "RTS/CTS", "DSR/DTR" });
            flowcontrolCombobox.Location = new Point(114, 129);
            flowcontrolCombobox.Name = "flowcontrolCombobox";
            flowcontrolCombobox.Size = new Size(71, 19);
            flowcontrolCombobox.TabIndex = 15;
            // 
            // connectButton
            // 
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Location = new Point(191, 100);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(85, 23);
            connectButton.TabIndex = 16;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // bytestoread
            // 
            bytestoread.AutoSize = true;
            bytestoread.Location = new Point(465, 19);
            bytestoread.Name = "bytestoread";
            bytestoread.Size = new Size(47, 11);
            bytestoread.TabIndex = 17;
            bytestoread.Text = "Bytes:";
            // 
            // readbuffersize
            // 
            readbuffersize.AutoSize = true;
            readbuffersize.Location = new Point(465, 37);
            readbuffersize.Name = "readbuffersize";
            readbuffersize.Size = new Size(89, 11);
            readbuffersize.TabIndex = 18;
            readbuffersize.Text = "Buffer Size:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(465, 0);
            label8.Name = "label8";
            label8.Size = new Size(37, 11);
            label8.TabIndex = 19;
            label8.Text = "READ";
            // 
            // readtimeout
            // 
            readtimeout.AutoSize = true;
            readtimeout.Location = new Point(465, 57);
            readtimeout.Name = "readtimeout";
            readtimeout.Size = new Size(61, 11);
            readtimeout.TabIndex = 20;
            readtimeout.Text = "Timeout:";
            // 
            // writetimeout
            // 
            writetimeout.AutoSize = true;
            writetimeout.Location = new Point(593, 57);
            writetimeout.Name = "writetimeout";
            writetimeout.Size = new Size(61, 11);
            writetimeout.TabIndex = 24;
            writetimeout.Text = "Timeout:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(593, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 11);
            label9.TabIndex = 23;
            label9.Text = "WRITE";
            // 
            // writebuffersize
            // 
            writebuffersize.AutoSize = true;
            writebuffersize.Location = new Point(593, 37);
            writebuffersize.Name = "writebuffersize";
            writebuffersize.Size = new Size(89, 11);
            writebuffersize.TabIndex = 22;
            writebuffersize.Text = "Buffer Size:";
            // 
            // bytestowrite
            // 
            bytestowrite.AutoSize = true;
            bytestowrite.Location = new Point(593, 19);
            bytestowrite.Name = "bytestowrite";
            bytestowrite.Size = new Size(47, 11);
            bytestowrite.TabIndex = 21;
            bytestowrite.Text = "Bytes:";
            // 
            // cts
            // 
            cts.AutoSize = true;
            cts.Location = new Point(191, 76);
            cts.Name = "cts";
            cts.Size = new Size(33, 11);
            cts.TabIndex = 25;
            cts.Text = "CTS:";
            // 
            // breakstate
            // 
            breakstate.AutoSize = true;
            breakstate.Location = new Point(342, 0);
            breakstate.Name = "breakstate";
            breakstate.Size = new Size(47, 11);
            breakstate.TabIndex = 26;
            breakstate.Text = "Break:";
            // 
            // cdline
            // 
            cdline.AutoSize = true;
            cdline.Location = new Point(342, 19);
            cdline.Name = "cdline";
            cdline.Size = new Size(61, 11);
            cdline.TabIndex = 27;
            cdline.Text = "CD Line:";
            // 
            // rts
            // 
            rts.AutoSize = true;
            rts.Location = new Point(342, 38);
            rts.Name = "rts";
            rts.Size = new Size(33, 11);
            rts.TabIndex = 28;
            rts.Text = "RTS:";
            // 
            // dsr
            // 
            dsr.AutoSize = true;
            dsr.Location = new Point(342, 57);
            dsr.Name = "dsr";
            dsr.Size = new Size(33, 11);
            dsr.TabIndex = 29;
            dsr.Text = "DSR:";
            // 
            // dtr
            // 
            dtr.AutoSize = true;
            dtr.Location = new Point(342, 76);
            dtr.Name = "dtr";
            dtr.Size = new Size(33, 11);
            dtr.TabIndex = 30;
            dtr.Text = "DTR:";
            // 
            // encoding
            // 
            encoding.AutoSize = true;
            encoding.Location = new Point(191, 0);
            encoding.Name = "encoding";
            encoding.Size = new Size(68, 11);
            encoding.TabIndex = 31;
            encoding.Text = "Encoding:";
            // 
            // handshake
            // 
            handshake.AutoSize = true;
            handshake.Location = new Point(191, 19);
            handshake.Name = "handshake";
            handshake.Size = new Size(75, 11);
            handshake.TabIndex = 32;
            handshake.Text = "Handshake:";
            // 
            // open
            // 
            open.AutoSize = true;
            open.Location = new Point(191, 38);
            open.Name = "open";
            open.Size = new Size(40, 11);
            open.TabIndex = 33;
            open.Text = "Open:";
            // 
            // newline
            // 
            newline.AutoSize = true;
            newline.Location = new Point(191, 57);
            newline.Name = "newline";
            newline.Size = new Size(61, 11);
            newline.TabIndex = 34;
            newline.Text = "Newline:";
            // 
            // refreshButton
            // 
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Location = new Point(191, 125);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(85, 23);
            refreshButton.TabIndex = 39;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(911, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(37, 11);
            timeLabel.TabIndex = 40;
            timeLabel.Text = "TIME";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txRichtextbox
            // 
            txRichtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txRichtextbox.BackColor = Color.Black;
            txRichtextbox.BorderStyle = BorderStyle.None;
            txRichtextbox.ForeColor = Color.Lime;
            txRichtextbox.HideSelection = false;
            txRichtextbox.Location = new Point(717, 38);
            txRichtextbox.Name = "txRichtextbox";
            txRichtextbox.ReadOnly = true;
            txRichtextbox.Size = new Size(231, 110);
            txRichtextbox.TabIndex = 41;
            txRichtextbox.Text = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(717, 24);
            label7.Name = "label7";
            label7.Size = new Size(29, 11);
            label7.TabIndex = 42;
            label7.Text = "TX:";
            // 
            // rxRichtextbox
            // 
            rxRichtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rxRichtextbox.BackColor = Color.Black;
            rxRichtextbox.BorderStyle = BorderStyle.None;
            rxRichtextbox.ForeColor = Color.Lime;
            rxRichtextbox.HideSelection = false;
            rxRichtextbox.Location = new Point(954, 38);
            rxRichtextbox.Name = "rxRichtextbox";
            rxRichtextbox.ReadOnly = true;
            rxRichtextbox.Size = new Size(231, 110);
            rxRichtextbox.TabIndex = 43;
            rxRichtextbox.Text = "";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(954, 24);
            label10.Name = "label10";
            label10.Size = new Size(29, 11);
            label10.TabIndex = 44;
            label10.Text = "RX:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1197, 680);
            Controls.Add(label10);
            Controls.Add(rxRichtextbox);
            Controls.Add(label7);
            Controls.Add(txRichtextbox);
            Controls.Add(timeLabel);
            Controls.Add(refreshButton);
            Controls.Add(newline);
            Controls.Add(open);
            Controls.Add(handshake);
            Controls.Add(encoding);
            Controls.Add(dtr);
            Controls.Add(dsr);
            Controls.Add(rts);
            Controls.Add(cdline);
            Controls.Add(breakstate);
            Controls.Add(cts);
            Controls.Add(writetimeout);
            Controls.Add(label9);
            Controls.Add(writebuffersize);
            Controls.Add(bytestowrite);
            Controls.Add(readtimeout);
            Controls.Add(label8);
            Controls.Add(readbuffersize);
            Controls.Add(bytestoread);
            Controls.Add(connectButton);
            Controls.Add(flowcontrolCombobox);
            Controls.Add(parityCombobox);
            Controls.Add(stopbitsNumericUpDown);
            Controls.Add(databitsNumericUpDown);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(speedCombobox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(commCombobox);
            Controls.Add(closeButton);
            Controls.Add(maxButton);
            Controls.Add(minButton);
            Controls.Add(outputRichtextbox);
            Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Form1_Shown;
            MouseDoubleClick += Form1_MouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)databitsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stopbitsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox outputRichtextbox;
        private Button minButton;
        private Button maxButton;
        private Button closeButton;
        private ComboBox commCombobox;
        private Label label1;
        private Label label2;
        private ComboBox speedCombobox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown databitsNumericUpDown;
        private NumericUpDown stopbitsNumericUpDown;
        private ComboBox parityCombobox;
        private ComboBox flowcontrolCombobox;
        private Button connectButton;
        private Label bytestoread;
        private Label readbuffersize;
        private Label label8;
        private Label readtimeout;
        private Label writetimeout;
        private Label label9;
        private Label writebuffersize;
        private Label bytestowrite;
        private Label cts;
        private Label breakstate;
        private Label cdline;
        private Label rts;
        private Label dsr;
        private Label dtr;
        private Label encoding;
        private Label handshake;
        private Label open;
        private Label newline;
        private Button refreshButton;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox txRichtextbox;
        private Label label7;
        private RichTextBox rxRichtextbox;
        private Label label10;
    }
}
