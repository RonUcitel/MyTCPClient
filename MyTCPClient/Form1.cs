using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MyTCPClient
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void Startb_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port;
            try
            {
                ip = IPAddress.Parse(IPText.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            try
            {
                port = int.Parse(PortText.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
            Text = "Wait!";
            SetEnable(false);
            if (IsServerUp(ip, port))
            {
                ChatForm cf = new ChatForm(ip, port, NameText.Text);
                cf.Show();
                Hide();
            }
            else
            {
                SetEnable(true);
                MessageBox.Show("The server on port " + ip.ToString() + "is not available", "Error", MessageBoxButtons.OK);
                IPText.Focus();
                IPText.SelectAll();
            }
        }

        private void SetEnable(bool isEnable)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = isEnable;
            }
        }
        private bool IsServerUp(IPAddress host, int port)
        {
            using (TcpClient client = new TcpClient())
            {
                try
                {
                    client.Connect(host, port);
                }
                catch (SocketException)
                {
                    client.Close();
                    return false;
                }
                client.Close();
                return true;
            }
        }
    }
}