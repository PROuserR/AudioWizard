using System;
using System.Windows.Forms;
using System.Net;
using NSpeex;
using DarrenLee.LiveStream;

namespace AudioWizard
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            DarrenLee.LiveStream.Audio.Sender S = new DarrenLee.LiveStream.Audio.Sender();
            S.Send(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }

        private void GetIP_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(IPAddress iP in System.Net.Dns.GetHostAddresses(Dns.GetHostName()))
            {
                i++;
                if(i==4)
                MessageBox.Show("Your IP is:" + iP.ToString(), "?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
