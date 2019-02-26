using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyTCPClient
{
    public partial class ChatForm : Form
    {
        IPAddress serverIP;
        int port;
        string name;
        public ChatForm(IPAddress IP, int Port, string Name)
        {
            InitializeComponent();
            Text = Name;
            serverIP = IP;
            port = Port;
            name = Name;
            Connect("test");
        }

        private void Sendb_Click(object sender, EventArgs e)
        {

        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void Connect(string message)
        {
            try
            {
                //TcpClient client = new TcpClient(server, port);
                TcpClient client = new TcpClient(new IPEndPoint(serverIP, port));

                // Translate the passed message into ASCII and store it as a Byte array.
                byte[] data = Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Dtb.Text += ("\n{name}: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new byte[256];

                // String to store the response ASCII representation.
                string responseData = string.Empty;

                // Read the first batch of the TcpServer response bytes.
                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                Dtb.Text += ("\nReceived: {0}", responseData);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Dtb.Text += ("\nArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Dtb.Text += ("\nSocketException: {0}", e);
            }

            Dtb.Text += ("\n Press Enter to continue...");
        }
    }
}
