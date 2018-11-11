using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AudioWizard
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OpenFileDialog OFD;
        TagLib.File f;
        private void button1_Click(object sender, EventArgs e)
        {
            OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = TagLib.File.Create(OFD.FileName);
            f.Tag.Album = textBox1.Text;
            f.Tag.Title = textBox2.Text;
            f.Tag.Year = Convert.ToUInt32(textBox3.Text);
            f.Save();
        }
    }
}
