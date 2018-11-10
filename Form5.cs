using System;
using System.Windows.Forms;
using NSpeex;
using DarrenLee.LiveStream.Audio;

namespace AudioWizard
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Receiver_button_Click(object sender, EventArgs e)
        {
            DarrenLee.LiveStream.Audio.Receiver R = new Receiver();
            R.Receive(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }
    }
}
