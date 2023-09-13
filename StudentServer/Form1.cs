using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSimpleTcp;
using System.Windows.Forms;

namespace StudentServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void historyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(serverIP.Text);
            server.Events.DataReceived += Events_DataReceived;
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                historyBox.Text += $"{e.IpPort} diconnected.{Environment.NewLine}";
                lstClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                byte[] dataBytes = e.Data.ToArray();
                string dataString = Encoding.UTF8.GetString(dataBytes);
                historyBox.Text += $"{e.IpPort}: {Environment.NewLine}{dataString}{Environment.NewLine}";
                try
                {
                    string clientIP = lstClientIP.Items[lstClientIP.Items.Count - 1].ToString();
                    server.Send(clientIP, "ACK");
                    historyBox.Text += $"Acknowledgement sent to client.{Environment.NewLine}";

                }
                catch (Exception ex)
                {
                    historyBox.Text += $"Error sending acknowlwdgement: {ex.Message}{Environment.NewLine}";
                }
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                historyBox.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lstClientIP.Items.Add(e.IpPort);
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                historyBox.Text += $"Starting...{Environment.NewLine}";
                buttonStart.Enabled = false;
            }
            catch (Exception ex)
            {
                historyBox.Text += $"Error in starting server...{Environment.NewLine}";
            }
        }
    }
}
