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
            this.buttonSerial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(114, 30);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 0;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(114, 37);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(121, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.Text = "192.168.4.87";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(207, 252);
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
            this.label3.Location = new System.Drawing.Point(79, 70);
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
            this.backgroundWorkerSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSync_DoWork);
            this.backgroundWorkerSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSync_ProgressChanged);
            this.backgroundWorkerSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSync_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(316, 22);
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
            this.numericUpDownPort.Location = new System.Drawing.Point(114, 68);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            66000,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownPort.TabIndex = 6;
            this.numericUpDownPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // buttonSerial
            // 
            this.buttonSerial.Location = new System.Drawing.Point(165, 57);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(70, 23);
            this.buttonSerial.TabIndex = 7;
            this.buttonSerial.Text = "Open (test)";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxPort);
            this.groupBox2.Controls.Add(this.buttonSerial);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

