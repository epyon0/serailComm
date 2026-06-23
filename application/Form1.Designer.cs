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
            outputRichtextbox.Location = new Point(200, 31);
            outputRichtextbox.Name = "outputRichtextbox";
            outputRichtextbox.ReadOnly = true;
            outputRichtextbox.Size = new Size(743, 397);
            outputRichtextbox.TabIndex = 0;
            outputRichtextbox.Text = "";
            outputRichtextbox.LinkClicked += richTextBox1_LinkClicked;
            outputRichtextbox.KeyPress += outputRichtextbox_KeyPress;
            // 
            // minButton
            // 
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minButton.BackColor = Color.Black;
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minButton.ForeColor = Color.Lime;
            minButton.Location = new Point(880, 0);
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
            maxButton.Location = new Point(905, 0);
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
            closeButton.Location = new Point(930, 0);
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
            commCombobox.Size = new Size(80, 19);
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
            speedCombobox.Size = new Size(80, 19);
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
            databitsNumericUpDown.Size = new Size(80, 14);
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
            stopbitsNumericUpDown.Size = new Size(80, 14);
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
            parityCombobox.Size = new Size(80, 19);
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
            flowcontrolCombobox.Size = new Size(80, 19);
            flowcontrolCombobox.TabIndex = 15;
            // 
            // connectButton
            // 
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Location = new Point(12, 154);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(182, 23);
            connectButton.TabIndex = 16;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(955, 440);
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
    }
}
