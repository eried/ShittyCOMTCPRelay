namespace COM2TCP
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPortInput = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorkerSync = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRemote = new System.Windows.Forms.GroupBox();
            this.groupBoxLocal = new System.Windows.Forms.GroupBox();
            this.numericUpDownStopBits = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.comboBoxBauds = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDataBits = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBoxRemote.SuspendLayout();
            this.groupBoxLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(114, 30);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 0;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(114, 41);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(121, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.Text = "192.168.4.87";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(185, 412);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start &Relay";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            // 
            // serialPortInput
            // 
            this.serialPortInput.DtrEnable = true;
            this.serialPortInput.PortName = "COM12";
            this.serialPortInput.RtsEnable = true;
            // 
            // backgroundWorkerSync
            // 
            this.backgroundWorkerSync.WorkerReportsProgress = true;
            this.backgroundWorkerSync.WorkerSupportsCancellation = true;
            this.backgroundWorkerSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSync_DoWork);
            this.backgroundWorkerSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSync_ProgressChanged);
            this.backgroundWorkerSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSync_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(365, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelStatus.Text = "Ready";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(114, 70);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            66000,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPort.TabIndex = 6;
            this.numericUpDownPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // groupBoxRemote
            // 
            this.groupBoxRemote.Controls.Add(this.textBoxHost);
            this.groupBoxRemote.Controls.Add(this.label2);
            this.groupBoxRemote.Controls.Add(this.numericUpDownPort);
            this.groupBoxRemote.Controls.Add(this.label3);
            this.groupBoxRemote.Location = new System.Drawing.Point(18, 18);
            this.groupBoxRemote.Name = "groupBoxRemote";
            this.groupBoxRemote.Size = new System.Drawing.Size(291, 128);
            this.groupBoxRemote.TabIndex = 8;
            this.groupBoxRemote.TabStop = false;
            this.groupBoxRemote.Text = "Remote";
            // 
            // groupBoxLocal
            // 
            this.groupBoxLocal.Controls.Add(this.numericUpDownDataBits);
            this.groupBoxLocal.Controls.Add(this.label6);
            this.groupBoxLocal.Controls.Add(this.numericUpDownStopBits);
            this.groupBoxLocal.Controls.Add(this.checkBoxDTR);
            this.groupBoxLocal.Controls.Add(this.checkBoxRTS);
            this.groupBoxLocal.Controls.Add(this.comboBoxBauds);
            this.groupBoxLocal.Controls.Add(this.label5);
            this.groupBoxLocal.Controls.Add(this.label4);
            this.groupBoxLocal.Controls.Add(this.label1);
            this.groupBoxLocal.Controls.Add(this.comboBoxPort);
            this.groupBoxLocal.Location = new System.Drawing.Point(18, 152);
            this.groupBoxLocal.Name = "groupBoxLocal";
            this.groupBoxLocal.Size = new System.Drawing.Size(291, 196);
            this.groupBoxLocal.TabIndex = 9;
            this.groupBoxLocal.TabStop = false;
            this.groupBoxLocal.Text = "Local";
            // 
            // numericUpDownStopBits
            // 
            this.numericUpDownStopBits.Location = new System.Drawing.Point(114, 130);
            this.numericUpDownStopBits.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownStopBits.Name = "numericUpDownStopBits";
            this.numericUpDownStopBits.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownStopBits.TabIndex = 7;
            this.numericUpDownStopBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Checked = true;
            this.checkBoxDTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDTR.Location = new System.Drawing.Point(114, 84);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(49, 17);
            this.checkBoxDTR.TabIndex = 6;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Checked = true;
            this.checkBoxRTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRTS.Location = new System.Drawing.Point(114, 107);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(48, 17);
            this.checkBoxRTS.TabIndex = 6;
            this.checkBoxRTS.Text = "RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            // 
            // comboBoxBauds
            // 
            this.comboBoxBauds.FormattingEnabled = true;
            this.comboBoxBauds.Location = new System.Drawing.Point(114, 57);
            this.comboBoxBauds.Name = "comboBoxBauds";
            this.comboBoxBauds.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBauds.TabIndex = 5;
            this.comboBoxBauds.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bauds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stop bits:";
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.Location = new System.Drawing.Point(114, 156);
            this.numericUpDownDataBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDataBits.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownDataBits.TabIndex = 9;
            this.numericUpDownDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data bits:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 394);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxRemote);
            this.tabPage1.Controls.Add(this.groupBoxLocal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(287, 412);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(60, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "S&top";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(6, 6);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(319, 355);
            this.listBoxLog.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 468);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Network of the Damned! Relay";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBoxRemote.ResumeLayout(false);
            this.groupBoxRemote.PerformLayout();
            this.groupBoxLocal.ResumeLayout(false);
            this.groupBoxLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPortInput;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSync;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.GroupBox groupBoxRemote;
        private System.Windows.Forms.GroupBox groupBoxLocal;
        private System.Windows.Forms.NumericUpDown numericUpDownStopBits;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.ComboBox comboBoxBauds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

