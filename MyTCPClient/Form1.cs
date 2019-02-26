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
            IPAddress ip = null;
            int port = 0;
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
            ChatForm cf = new ChatForm(ip, port, NameText.Text);
            cf.Show();
            Hide();
        }
    }
}
