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
                Dtb.Text += ("\nArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Dtb.Text += ("\nSocketException: {0}", e);
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
                Dtb.Text += dm.ToString();
            }
            catch (ArgumentNullException e)
            {
                Dtb.Text += ("\nArgumentNullException: {0}", e);
                return false;
            }
            catch (SocketException e)
            {
                Dtb.Text += ("\nSocketException: {0}", e);
                return false;
            }
            return true;
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
                        Dtb.Text += responseData.Split('-')[1];
                    }
                    else if (responseData.First() == '?')
                    {
                        Send("~" + name);
                    }
                }
                catch (ArgumentNullException e)
                {
                    Dtb.Text += ("\nArgumentNullException: {0}", e);
                }
                catch (SocketException e)
                {
                    Dtb.Text += ("\nSocketException: {0}", e);
                }
            }
        }
    }
}