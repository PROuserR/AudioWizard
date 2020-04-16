using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace AudioWizard
{
    public partial class Form4 : Form
    {
        OpenFileDialog OFD;
        public Form4()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OFD = new OpenFileDialog();
            if(OFD.ShowDialog()==DialogResult.OK)
            {
                inputTextBox.Text = OFD.FileName;
                OFD.Dispose();
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            MediaFoundationReader foundationReader = new MediaFoundationReader(OFD.FileName);
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save here your file";
            if (mp3RadioButton.Checked)
            {
                SFD.Filter = "MP3|*.mp3";
                SFD.ShowDialog();
                MediaFoundationEncoder.EncodeToMp3(foundationReader, SFD.FileName);
            }
            if (aacRadioButton.Checked)
            {
                SFD.Filter = "AAC|*.aac";
                SFD.ShowDialog();
                MediaFoundationEncoder.EncodeToAac(foundationReader, SFD.FileName);
            }
            if (wmaRadioButton.Checked)
            {
                SFD.Filter = "WMA|*.wma";
                SFD.ShowDialog();
                MediaFoundationEncoder.EncodeToWma(foundationReader, SFD.FileName);
            } 

        }
    }
}
