using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM2TCP
{
    public partial class FormMain : Form
    {
        private TcpClient client;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateGui(true);
        }

        private void UpdatePorts()
        {
            comboBoxPort.Items.Clear();

            foreach (var p in SerialPort.GetPortNames())
                comboBoxPort.Items.Add(p);

            if (comboBoxPort.Items.Count > 0)
                comboBoxPort.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            UpdateGui(false);
            backgroundWorkerSync.RunWorkerAsync(new TaskParams() { Host = textBoxHost.Text, ComPort = comboBoxPort.Text, Port = (int)numericUpDownPort.Value});
        }

        private void UpdateGui(bool v)
        {
            UpdatePorts();
            buttonStop.Enabled = !v;
            buttonStart.Enabled = v;
            groupBoxRemote.Enabled = v;
            groupBoxLocal.Enabled = v;
        }

        private void backgroundWorkerSync_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var t = e.Argument as TaskParams;
                backgroundWorkerSync.ReportProgress(0);

                client = new TcpClient();
                serialPortInput.PortName = t.ComPort;
                serialPortInput.Open();
                client.Connect(t.Host, t.Port);
                serialPortInput.DataReceived += SerialPortInput_DataReceived;

                while (!e.Cancel && serialPortInput.IsOpen)
                {
                    backgroundWorkerSync.ReportProgress(0);
                    var b = new byte[1];
                    client.Client.Receive(b);
                    serialPortInput.Write(b, 0, b.Length);
                }
            }catch (Exception ex)
            {
                backgroundWorkerSync.ReportProgress(-3, ex.Message);
            }

            Thread.Sleep(400); // Just to avoid making the controls "blink" on immediate errors
        }

        private void SerialPortInput_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            backgroundWorkerSync.ReportProgress(serialPortInput.BytesToRead);
            client.Client.Send(new[] { (byte)serialPortInput.ReadByte() });
        }

        private void backgroundWorkerSync_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch(e.ProgressPercentage)
            {
                case 0:
                    toolStripStatusLabelStatus.Text = "Starting";
                    break;

                case -1:
                    toolStripStatusLabelStatus.Text = "Waiting";
                    break;

                case -2:
                    toolStripStatusLabelStatus.Text = "Terminated";
                    break;

                case -3:
                    toolStripStatusLabelStatus.Text = "Error: " + e.UserState as String;
                    break;

                default:
                    toolStripStatusLabelStatus.Text = "Rem: " + e.ProgressPercentage;
                    break;
            }
        }

        private void backgroundWorkerSync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateGui(true);
        }

        private void buttonSerial_Click(object sender, EventArgs e)
        {
            serialPortInput.PortName = comboBoxPort.Text;
            serialPortInput.Open();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            backgroundWorkerSync.CancelAsync();
        }
    }

    internal class TaskParams
    {
        public TaskParams()
        {
        }

        public string Host { get; set; }
        public string ComPort { get; internal set; }
        public int Port { get; internal set; }
    }
}
