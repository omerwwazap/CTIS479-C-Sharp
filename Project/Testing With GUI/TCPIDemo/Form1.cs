using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace TCPIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;// Used for Enter Delimtier for entered messages
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You have sent: {0}", e.MessageString));
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Server is booting up... ";
            //.Net Frameworks Builtin network controller
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text); // Get IP from txtHost
            // Need IP and Port start server
            if (server.IsStarted)
                txtStatus.Text = "Server is already open ";
            else
                server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //If server has started than stop the server
            if (server.IsStarted)
            {
                server.Stop();
                txtStatus.Text = "Server has stopped ";
            }
            else
                txtStatus.Text = "Server is not running ";
        }
    }
}