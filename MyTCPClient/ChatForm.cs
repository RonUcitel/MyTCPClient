using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MyTCPServer;

namespace MyTCPClient
{
    public partial class ChatForm : Form
    {
        Thread t;
        TcpClient client;
        IPAddress serverIP;
        int port;
        string name;
        NetworkStream stream;
        public ChatForm(IPAddress IP, int Port, string Name)
        {
            InitializeComponent();
            Text = Name;
            serverIP = IP;
            port = Port;
            name = Name;
            Mtb.MaxLength = 255;
            Dtb.Enabled = false;
            t = new Thread(Recive);
            Connect();
        }

        private void Sendb_Click(object sender, EventArgs e)
        {
            Send(Mtb.Text);
            Mtb.Text = "";

        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close everything.
            stream.Close();
            client.Close();
            Application.Exit();
        }

        void Connect()
        {
            try
            {
                //TcpClient client = new TcpClient(server, port);
                client = new TcpClient();
                client.Connect(serverIP, port);

                // Translate the passed name into ASCII and store it as a Byte array.
                byte[] data = Encoding.ASCII.GetBytes("~" + name);

                // Get a client stream for reading and writing.
                stream = client.GetStream();

                // Send the name to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
            }
            catch (ArgumentNullException e)
            {
                WriteToDtb("\nArgumentNullException: " + e);
            }
            catch (SocketException e)
            {
                WriteToDtb("\nSocketException: " + e);
            }
            t.Start();
        }

        public bool Send(string message)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                DetailedMessage dm = new DetailedMessage(name, message);
                byte[] data = Encoding.ASCII.GetBytes("-" + dm.ToString());

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                WriteToDtb(dm.ToString());
            }
            catch (ArgumentNullException e)
            {
                WriteToDtb("\nArgumentNullException: " + e);
                return false;
            }
            catch (SocketException e)
            {
                WriteToDtb("\nSocketException: " + e);
                return false;
            }
            return true;
        }
        private void WriteToDtb(string text)
        {
            Dtb.Text += text;
        }
        public void Recive()
        {
            while (true)
            {
                try
                {
                    // Receive the TcpServer.response.

                    // Buffer to store the response bytes.
                    byte[] data = new byte[256];

                    // String to store the response ASCII representation.
                    string responseData = string.Empty;

                    // Read the first batch of the TcpServer response bytes.
                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.ASCII.GetString(data, 0, bytes);
                    if (responseData.First() == '-')
                    {
                        WriteToDtb(responseData.Split('-')[1]);
                    }
                    else if (responseData.First() == '?')
                    {
                        Send("~" + name);
                    }
                }
                catch (ArgumentNullException e)
                {
                    WriteToDtb("\nArgumentNullException: " + e);
                }
                catch (SocketException e)
                {
                    WriteToDtb("\nSocketException: " + e);
                }
            }
        }

        private void Mtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send(Mtb.Text);
                Mtb.Text = "";
            }
        }
    }
}