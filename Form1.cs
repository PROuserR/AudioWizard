using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.MediaFoundation;
using WaveFormRendererLib;
using System.Threading;

namespace MyRadio
{
    public partial class Form1 : Form
    {
        WaveOutEvent outputDevice;
        MediaFoundationReader foundationReader;
        SignalGenerator generator = new SignalGenerator() { Gain = 0.2, Frequency = 500, Type = SignalGeneratorType.Pink };
        WasapiLoopbackCapture capture = new WasapiLoopbackCapture();
        WaveFileWriter writer;

        SaveFileDialog SFD = new SaveFileDialog();
        OpenFileDialog OFD = new OpenFileDialog();
        ColorDialog CD = new ColorDialog();

        Size[] size = new Size[7];
        Random random = new Random();

        public TagLib.File f ;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer loopTimer = new System.Windows.Forms.Timer();
        bool AB = false;
        bool loop_bool = false;
        int soundV = 1;
        int A;
        int B;
        int coverArt_int = 0;
        int loop_int = 0;
        int play = 1;
        int playlist = 0;
        int URL_int = 0;

        public Form1()
        {
            InitializeComponent();
            coverArt.ImageLocation = Environment.CurrentDirectory + @"\AudioWizard.png";
            OFD.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            
        }

        WaveInEvent waveInEvent = new WaveInEvent();

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader.Position > 0)
                {
                    double currentTime = foundationReader.CurrentTime.TotalSeconds;
                    currentTime = Math.Round(foundationReader.CurrentTime.TotalSeconds);
                    double totalTime = foundationReader.TotalTime.TotalSeconds;
                    totalTime = Math.Round(foundationReader.TotalTime.TotalSeconds);
                    string currentTime_string = foundationReader.CurrentTime.ToString();
                    currentTime_string = currentTime_string.Remove(8, 8);
                    string totalTime_string = foundationReader.TotalTime.ToString();
                    totalTime_string = totalTime_string.Remove(8, 8);
                    currentTime_label.Text = currentTime_string;
                    totalTimeLabel.Text = totalTime_string;
                    positionTrackBar.Maximum = Convert.ToInt32(totalTime);
                    positionTrackBar.Value = Convert.ToInt32(currentTime);
                    this.Text = "AudioWizard>>" + OFD.SafeFileNames[playlist];
                    outputDevice.Volume = volumeSlider.Volume;

                    if (currentTime >= totalTime && loop_bool)
                    {
                        outputDevice.Stop();
                        foundationReader.Position = 0;
                        outputDevice.Init(foundationReader);
                        outputDevice.Play();
                        this.Text = "AudioMaster>>" + OFD.FileNames[playlist];
                        if (OFD.FileNames.Length > 1)
                        {
                            outputDevice.Stop();
                            playlist++;
                            foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                            outputDevice.Init(foundationReader);
                            outputDevice.Play();

                            TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                            TagLib.IPicture pic = f.Tag.Pictures[0];
                            MemoryStream ms = new MemoryStream(pic.Data.Data);
                            ms.Seek(0, SeekOrigin.Begin);
                            coverArt.Image = Image.FromStream(ms);
                            Lyrics_richtextbox.Text = f.Tag.Lyrics;
                        }

                    }
                }

            }
            catch { }

        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader == null)
                {
                    AB = false;
                    if (!(outputDevice == null)) outputDevice.Stop();
                    OFD.Multiselect = true;
                    if (OFD.ShowDialog() == DialogResult.OK)
                    {
                        outputDevice = new WaveOutEvent();
                        foundationReader = new MediaFoundationReader(OFD.FileName);
                        outputDevice.Init(foundationReader);
                        outputDevice.Play();
                        FileInfo info = new FileInfo(OFD.FileName);
                        long info_long = info.Length / 1024 / 1024;
                        notifyIcon1.BalloonTipText = info_long.ToString()+ " Mb";
                        notifyIcon1.ShowBalloonTip(5000);
                        Play_button.Text = "||";
                        this.Text = "AudioWizard>>" + OFD.SafeFileName;
                        coverArt.ImageLocation = Environment.CurrentDirectory + @"\AudioWizard.png";

                        timer.Interval = 1000;
                        timer.Enabled = true;
                        timer.Tick += Timer_Tick;
                    }
                }

                switch (play)
                {
                    case 0:
                        outputDevice.Stop();
                        Play_button.Text = "|>";


                        break;
                    case 1:
                        outputDevice.Play();
                        Play_button.Text = "||";
                        break;
                    default:
                        play = 0;
                        goto case 0;
                }
                play++;
                this.Focus();
            }

            catch { }
            finally
            {
                OFD.Dispose();
                notifyIcon1.Dispose();
            }
        }



        private void Stop_button_Click(object sender, EventArgs e)
        {
            this.Refresh();
            try
            {
                currentTime_label.Text = "00:00:00";
                outputDevice.Stop();
                foundationReader.Dispose();
                foundationReader = null;
                Play_button.Text="|>";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void URL_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foundationReader = new MediaFoundationReader(textbox.Text);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(foundationReader);
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CD.Color = this.BackColor;
                this.BackColor = CD.Color;
                CD.ShowDialog();
                this.BackColor = CD.Color;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void backWard_button_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                foundationReader.Skip(-10);
                outputDevice.Init(foundationReader);
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void forWard_button_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                foundationReader.Skip(10);
                outputDevice.Init(foundationReader);
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void Combine(string[] inputFiles, Stream output)
        {
            try
            {
                foreach (string file in inputFiles)
                {
                    Mp3FileReader reader = new Mp3FileReader(file);
                    if ((output.Position == 0) && (reader.Id3v2Tag != null))
                    {
                        output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                    }
                    Mp3Frame frame;
                    while ((frame = reader.ReadNextFrame()) != null)
                    {
                        output.Write(frame.RawData, 0, frame.RawData.Length);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void backTrack_button_Click(object sender, EventArgs e)
        {
            try
            {
                playlist--;
                if (playlist<=0)
                {
                    playlist=OFD.FileNames.Length;
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                    TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                    if (f.Tag.Lyrics == null) Lyrics_richtextbox.Visible = false;
                    if (f.Tag.Pictures == null) coverArt.Visible = false;
                    TagLib.IPicture pic = f.Tag.Pictures[0];
                    MemoryStream ms = new MemoryStream(pic.Data.Data);
                    ms.Seek(0, SeekOrigin.Begin);
                    coverArt.Image = Image.FromStream(ms);
                    Lyrics_richtextbox.Text = f.Tag.Title + ":" + "\n" + f.Tag.Lyrics;
                }
                else
                { 
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                    TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                    if (f.Tag.Lyrics == null) Lyrics_richtextbox.Visible = false;
                    if (f.Tag.Pictures == null) coverArt.Visible = false;
                    TagLib.IPicture pic = f.Tag.Pictures[0];
                    MemoryStream ms = new MemoryStream(pic.Data.Data);
                    ms.Seek(0, SeekOrigin.Begin);
                    coverArt.Image = Image.FromStream(ms);
                    Lyrics_richtextbox.Text = f.Tag.Title + ":" + "\n" + f.Tag.Lyrics;
                }

            }
            catch { }
        }

        private void ForwardTrack_button_Click(object sender, EventArgs e)
        {
            try
            {
                playlist++;
                if (playlist>=OFD.FileNames.Length)
                {
                    playlist = 0;
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                    TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                    if (f.Tag.Lyrics == null) Lyrics_richtextbox.Visible = false;
                    if (f.Tag.Pictures == null) coverArt.Visible = false;
                    TagLib.IPicture pic = f.Tag.Pictures[0];
                    MemoryStream ms = new MemoryStream(pic.Data.Data);
                    ms.Seek(0, SeekOrigin.Begin);
                    coverArt.Image = Image.FromStream(ms);
                    Lyrics_richtextbox.Text = f.Tag.Title + ":" + "\n" + f.Tag.Lyrics;
                }
                else
                {
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                    TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                    if (f.Tag.Lyrics == null) Lyrics_richtextbox.Visible = false;
                    if (f.Tag.Pictures == null) coverArt.Visible = false;
                    TagLib.IPicture pic = f.Tag.Pictures[0];
                    MemoryStream ms = new MemoryStream(pic.Data.Data);
                    ms.Seek(0, SeekOrigin.Begin);
                    coverArt.Image = Image.FromStream(ms);
                    Lyrics_richtextbox.Text = f.Tag.Title + ":" + "\n" + f.Tag.Lyrics;
                }
            }
            catch { }
        }

        private void signalMixerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void audioFromURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(outputDevice == null)) outputDevice.Stop();
                outputDevice = new WaveOutEvent();
                foundationReader = new MediaFoundationReader(textbox.Text);
                outputDevice.Init(foundationReader);
                outputDevice.Play();
                string totalTime = foundationReader.TotalTime.ToString();
                totalTime = totalTime.Remove(8, 8);

                this.Text = "AudioMaster" + ">>" + textbox.Text;

                timer.Interval = 1000;
                timer.Enabled = true;
                timer.Tick += Timer_Tick;

                notifyIcon1.BalloonTipText = foundationReader.Length.ToString();
                notifyIcon1.ShowBalloonTip(5000);
                URL_label.Visible = true;
                textbox.Visible = true;
                textbox.Focus();
            }

            catch
            {
            }

        }

        private void metaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.azlyrics.com/");
        }

        private void makeAWaveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WaveFormRendererLib.WaveFormRenderer waveFormRenderer = new WaveFormRenderer();
                StandardWaveFormRendererSettings settings = new StandardWaveFormRendererSettings();
                settings.DecibelScale = true;
                settings.Width = 600;
                settings.TopHeight = 40;
                settings.BottomHeight = 40;
                var image = waveFormRenderer.Render(OFD.FileName, settings);
                SFD.Filter = "PNG|*.png";
                SFD.ShowDialog();
                image.Save(SFD.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveCoverArtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "PNG|*.png";
            SFD.ShowDialog();
            coverArt.Image.Save(SFD.FileName);
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CD.ShowDialog();
            this.ForeColor = CD.Color;
            Lyrics_richtextbox.ForeColor = CD.Color;
        }

        private void audioToMp3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SFD.Filter = "Wav|*.wav";
                SFD.ShowDialog();
                writer = new WaveFileWriter(SFD.FileName, capture.WaveFormat);

                capture.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };
                capture.StartRecording();
                stopRecordingToolStripMenuItem.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stopRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordToolStripMenuItem.Text = "Record";
            capture.StopRecording();
            capture.RecordingStopped += (s, o) =>
            {
                writer.Dispose();
                writer = null;
                capture.Dispose();
            };

        }

        private void mergeMp3FilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OFD.Multiselect = true;
                OFD.ShowDialog();
                SFD.Filter = "Mp3|*.mp3";
                SFD.ShowDialog();
                FileStream stream = new FileStream(SFD.FileName, FileMode.OpenOrCreate);
                Combine(OFD.FileNames, stream);
                MessageBox.Show("Complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void saveLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFD.FileName != null)
            {
                foundationReader.Dispose();
                foundationReader.Flush();
                foundationReader.Close();
                TagLib.File f = TagLib.File.Create(OFD.FileName);
                f.Tag.Lyrics = Lyrics_richtextbox.Text.Remove(0, f.Tag.Title.Length);
                f.Save();
                foundationReader = new MediaFoundationReader(OFD.FileName);
            }

        }
        int i = 0;
        private void hideLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f = TagLib.File.Create(OFD.FileNames[playlist]);
                Lyrics_richtextbox.Text = f.Tag.Lyrics;
                i++;
                switch (i)
                {
                    case 1:
                        Lyrics_richtextbox.Visible = true;
                        coverArt.Left += 140;
                        hideLyricsToolStripMenuItem.Text = "Hide lyrics";
                        break;
                    default:
                        i = 0;
                        Lyrics_richtextbox.Visible = false;
                        coverArt.Left -= 140;
                        hideLyricsToolStripMenuItem.Text = "Show lyrics";
                        break;
                }
            }
            catch { }

            }

            private void senderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you a sender", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AudioWizard.Form4 form4 = new AudioWizard.Form4();
                form4.Show();
            }
        }

        private void recevierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you a receiver", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AudioWizard.Form5 form5 = new AudioWizard.Form5();
                form5.Show();
            }
        }

        private void positionTrackBar_Scroll(object sender, EventArgs e)
        {
            if (foundationReader != null)
                foundationReader.Position = (positionTrackBar.Value * foundationReader.Length) / positionTrackBar.Maximum;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                SmbPitchShiftingSampleProvider provider = new SmbPitchShiftingSampleProvider(foundationReader.ToSampleProvider());
                provider.PitchFactor = 0.5f;
                if (provider.PitchFactor == 0) provider.PitchFactor = 0.5f;
                outputDevice.Init(provider);
                outputDevice.Play();
            }
            catch { }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                SmbPitchShiftingSampleProvider provider = new SmbPitchShiftingSampleProvider(foundationReader.ToSampleProvider());
                provider.PitchFactor = 1f;
                if (provider.PitchFactor == 0) provider.PitchFactor = 0.5f;
                outputDevice.Init(provider);
                outputDevice.Play();
            }
            catch { }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                SmbPitchShiftingSampleProvider provider = new SmbPitchShiftingSampleProvider(foundationReader.ToSampleProvider());
                provider.PitchFactor = 2f;
                if (provider.PitchFactor == 0) provider.PitchFactor = 0.5f;
                outputDevice.Init(provider);
                outputDevice.Play();
            }
            catch { }
        }

        private void leftVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader != null)
                {
                    StereoToMonoSampleProvider toMono = new StereoToMonoSampleProvider(foundationReader.ToSampleProvider());
                    toMono.LeftVolume = 1.0f;
                    toMono.RightVolume = 0;
                    outputDevice.Stop();
                    outputDevice.Init(toMono);
                    outputDevice.Play();
                }
            }
            catch { }

        }

        private void rightVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader != null)
                {
                    StereoToMonoSampleProvider toMono = new StereoToMonoSampleProvider(foundationReader.ToSampleProvider());
                    toMono.LeftVolume = 0;
                    toMono.RightVolume = 1.0f;
                    outputDevice.Stop();
                    outputDevice.Init(toMono);
                    outputDevice.Play();
                }
            }
            catch { }

        }

        private void coverArtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f = TagLib.File.Create(OFD.FileName);
                TagLib.IPicture pic = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                coverArt.Image = null;
                coverArt.Refresh();
                coverArt.SizeMode = PictureBoxSizeMode.StretchImage;
                coverArt.Image = Image.FromStream(ms);
                coverArt_int++;
                switch (coverArt_int)
                {
                    case 1:
                        coverArt.Visible = true;
                        coverArtToolStripMenuItem.Text = "Hide cover art";
                        break;
                    default:
                        coverArt.Visible = false;
                        coverArtToolStripMenuItem.Text = "Show cover art";
                        coverArt_int = 0;
                        break;
                }
            }
            catch { MessageBox.Show("None"); }
        }
        private void loopAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loop_int == 0)
            {
                loop_bool = true;
            }
            if (loop_int == 1)
            {
                loop_bool = false;
            }
            loop_int++;
            if (loop_int > 1) loop_int = 0;

        }

        private void audioInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f = TagLib.File.Create(OFD.FileNames[playlist]);
                string info = "Title:" + f.Tag.Title + "\n" + "Album:" + f.Tag.Album + "\n" + "Artist:" + f.Tag.Artists[0] + "\n" + "Year:" + f.Tag.Year;

                MessageBox.Show(info, "Audio info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("None"); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }
     
        private void showURLTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URL_int++;
            switch(URL_int)
            {
                case 1:
                    textbox.Visible = true;
                    URL_label.Visible = true;
                    showURLTextboxToolStripMenuItem.Text = "Hide URL textbox";
                    break;
                default:
                    textbox.Visible = false;
                    URL_label.Visible = false;
                    showURLTextboxToolStripMenuItem.Text = "Show URL textbox";
                    URL_int = 0;
                    break;
            }
            textbox.Focus();
        }

        private void editAudioInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioWizard.Form3 form3 = new AudioWizard.Form3();
            form3.Show();
        }

        private void aToBLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AB==false)
            {
                A = (int)foundationReader.CurrentTime.TotalSeconds;
            }
            if(AB==true)
            {
                B = (int)foundationReader.CurrentTime.TotalSeconds;
                loopTimer.Interval = 100;
                loopTimer.Enabled = true;
                loopTimer.Tick += LoopTimer_Tick;
                loopTimer.Start();
            }
            AB = true;

        }

        private void LoopTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader.CurrentTime.TotalSeconds > B && foundationReader != null && AB)
                {
                    foundationReader.Position = A * foundationReader.Length / positionTrackBar.Maximum;
                }
            }
            catch { }

        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            if(outputDevice!=null)
            outputDevice.Volume = volumeSlider.Volume;
        }

        private void soundVisualizer_Tick(object sender, EventArgs e)
        {
            if(foundationReader!=null)
            {
                size[0].Width = random.Next(15, 500);
                size[0].Height = volumeMeter1.Height;
                volumeMeter1.Size = size[0];

                size[1].Width = random.Next(15, 500);
                size[1].Height = volumeMeter1.Height;
                volumeMeter2.Size = size[1];

                size[2].Width = random.Next(15, 500);
                size[2].Height = volumeMeter1.Height;
                volumeMeter3.Size = size[2];

                size[3].Width = random.Next(15, 500);
                size[3].Height = volumeMeter1.Height;
                volumeMeter4.Size = size[3];

                size[4].Width = random.Next(15, 500);
                size[4].Height = volumeMeter1.Height;
                volumeMeter5.Size = size[4];

                size[5].Width = random.Next(15, 500);
                size[5].Height = volumeMeter1.Height;
                volumeMeter6.Size = size[5];

                size[6].Width = random.Next(15, 500);
                size[6].Height = volumeMeter1.Height;
                volumeMeter7.Size = size[6];

                visualPanel.BackColor = Color.FromArgb(random.Next(0, 255),random.Next(0,255),random.Next(0,200),random.Next(0,255));
            }
 
        }

        private void showViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundV++;
            switch (soundV)
            {
                case 1:
                    showViToolStripMenuItem.Text = "Show audio visualization";
                    this.Size = new Size(584, 420);
                    visualPanel.Visible = false;
                    visualPanel.Dispose();
                    break;
                default:
                    showViToolStripMenuItem.Text = "Hide audio visualization";
                    this.Size = new Size(584, 575);
                    visualPanel.Visible = true;
                    soundV = 0;
                    visualPanel = new Panel();
                    visualPanel.Update();
                    break;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mediaToMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    MediaFoundationApi.Startup();
                    foundationReader = new MediaFoundationReader(OFD.FileName);
                    SFD.Filter = "Mp3|*.mp3";
                    SFD.ShowDialog();
                    MessageBox.Show("Just wait until the file finish encoding.Thank u!");
                    MediaFoundationEncoder.EncodeToMp3(foundationReader, SFD.FileName);
                }


            }
            catch { }
        }

        private void mediaToAACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    MediaFoundationApi.Startup();
                    foundationReader = new MediaFoundationReader(OFD.FileName);
                    SFD.Filter = "AAC|*.aac";
                    SFD.ShowDialog();
                    MessageBox.Show("Just wait until the file finish encoding.Thank u!");
                    MediaFoundationEncoder.EncodeToAac(foundationReader, SFD.FileName);
                }


            }
            catch { }
        }

        private void mediaToWMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    MediaFoundationApi.Startup();
                    foundationReader = new MediaFoundationReader(OFD.FileName);
                    SFD.Filter = "WMA|*.wma";
                    SFD.ShowDialog();
                    MessageBox.Show("Just wait until the file finish encoding.Thank u!");
                    MediaFoundationEncoder.EncodeToWma(foundationReader, SFD.FileName);
                }


            }
            catch { }
        }
    }
}

