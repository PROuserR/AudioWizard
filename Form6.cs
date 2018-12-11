using System;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace AudioWizard
{
    public partial class Form6 : Form
    {
        char[] notes;
        SoundPlayer soundPlayer;

        public Form6()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            notes = new char[textBox.Text.Length];
            notes = textBox.Text.ToCharArray();
            foreach (char note in notes)
            {
                switch (note)
                {
                    case 'A':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\A.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'B':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\A_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'C':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\B.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'D':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\B_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'E':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Bb.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'F':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Bb_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'G':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'H':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'I':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C_s.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'J':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C_s1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'K':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'L':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\C1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'M':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Cq_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'N':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Cq1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'O':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'P':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'Q':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D_s.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'R':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D_s1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'S':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'T':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\D1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'U':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Dq_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'V':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Dq1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'W':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\E.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'X':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\E_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'Y':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\E1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case 'Z':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\E1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '0':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\F.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '1':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\F_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '2':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\F_s.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '3':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\F1.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '4':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\F1_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '5':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Fq_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '6':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\G.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '7':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\G_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '8':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\G_s.wav");
                        soundPlayer.PlaySync();
                        break;
                    case '9':
                        soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\Music_Note\Gq_Drum.wav");
                        soundPlayer.PlaySync();
                        break;
                }
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}
