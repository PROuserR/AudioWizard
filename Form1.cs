using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.MediaFoundation;
using WaveFormRendererLib;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace AudioWizard
{
    public partial class Form1 : Form
    {
        WaveOutEvent outputDevice;
        MediaFoundationReader foundationReader;
        SignalGenerator generator = new SignalGenerator() { Gain = 0.2, Frequency = 500, Type = SignalGeneratorType.Pink };
        WasapiLoopbackCapture capture = new WasapiLoopbackCapture();
        WaveFileWriter writer;
        WaveInEvent waveInEvent = new WaveInEvent();
        SaveFileDialog SFD = new SaveFileDialog();
        OpenFileDialog OFD = new OpenFileDialog();
        ColorDialog CD = new ColorDialog();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer loopTimer = new System.Windows.Forms.Timer();
        bool AB = false;
        bool loop_bool = false;
        bool IsRecording = false;
        int A;
        int B;
        int playlist = 0;
        double currentTime;
        double totalTime;
        string currentTime_string;
        string totalTime_string;

        public Form1()
        {
            InitializeComponent();
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            playBox.BackColor = this.BackColor;
            playBox.ForeColor = this.ForeColor;
            if (this.Size.Height == 419)
            {
                playBox.Visible = true;
                this.Size = new Size(588, 624);
                showPlayBoxToolStripMenuItem.Text = "Hide playBox";
            }
            else
            {
                playBox.Visible = false;
                this.Size = new Size(588, 419);
                showPlayBoxToolStripMenuItem.Text = "Show playBox";
            }
        }

        void setCoverArt()
        {
            try
            {
                TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                TagLib.IPicture pic = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                coverArt.Image = Image.FromStream(ms);
                coverArt.Refresh();
            }
            catch { }
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
            catch { }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (foundationReader.Position > 0)
                {
                    currentTime = foundationReader.CurrentTime.TotalSeconds;
                    currentTime = Math.Round(foundationReader.CurrentTime.TotalSeconds);
                    totalTime = foundationReader.TotalTime.TotalSeconds;
                    totalTime = Math.Round(foundationReader.TotalTime.TotalSeconds);
                    currentTime_string = foundationReader.CurrentTime.ToString();
                    currentTime_string = currentTime_string.Remove(8, 8);
                    totalTime_string = foundationReader.TotalTime.ToString();
                    totalTime_string = totalTime_string.Remove(8, 8);
                    totalTimeLabel.Text = totalTime_string;
                    currentTime_label.Text = currentTime_string;
                    positionTrackBar.Maximum = Convert.ToInt32(totalTime);
                    positionTrackBar.Value = Convert.ToInt32(currentTime);
                    outputDevice.Volume = volumeSlider.Volume;

                    if (currentTime >= totalTime && loop_bool)
                    {
                        outputDevice.Stop();
                        playlist++;
                        foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                        outputDevice.Init(foundationReader);
                        outputDevice.Play();
                        this.Text = OFD.SafeFileNames[playlist];
                        playBox.SelectedIndex = playlist;
                    }
                }
            }
            catch { }
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            try
            {
                AB = false;
                OFD.Multiselect = true;
                if(foundationReader==null)
                {
                    if (OFD.ShowDialog() == DialogResult.OK)
                    {
                        outputDevice = new WaveOutEvent();
                        foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                        outputDevice.Init(foundationReader);
                        Play_button.Text = "►";
                        this.Text = "♫♫ " + OFD.SafeFileNames[playlist];
                        foreach (var filename in OFD.SafeFileNames)
                            playBox.Items.Add(filename);
                        timer.Interval = 1000;
                        timer.Enabled = true;
                        timer.Tick += Timer_Tick;
                    }
                }

                switch (Play_button.Text)
                {
                    case "||":
                        outputDevice.Stop();
                        Play_button.Text = "►";
                        break;
                    case "►":
                        outputDevice.Play();
                        Play_button.Text = "||";
                        break;
                }
            }

            catch { }
            finally
            {
                OFD.Dispose();
                setCoverArt();
            }
        }


        private void Stop_button_Click(object sender, EventArgs e)
        {
            try
            {
                coverArt.ImageLocation = Environment.CurrentDirectory+"\\AudioWizard.png";
                playBox.Items.Clear();
                if (IsRecording == false)
                {
                    currentTime_label.Text = "00:00:00";
                    outputDevice.Dispose();
                    foundationReader.Dispose();
                    foundationReader = null;
                    GC.Collect();
                    Play_button.Text = "►";
                }
                else
                {
                    capture.StopRecording();
                    capture.RecordingStopped += (s, o) =>
                    {
                        writer.Dispose();
                        writer = null;
                        capture.Dispose();
                    };
                    IsRecording = false;
                    SFD.Filter = "WAV|*wav";
                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        File.Move(Environment.CurrentDirectory + "\\recording.wav", SFD.FileName + ".wav");
                    }
                }
            }
            catch { }
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
            catch { }
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
            catch { }
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
            catch { }

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
            catch { }
        }

        private void backTrack_button_Click(object sender, EventArgs e)
        {
            try
            {
                playlist--;
                setCoverArt();
                if (playlist <= 0)
                {
                    outputDevice.Stop();
                    playlist = OFD.FileNames.Length;
                    outputDevice = new WaveOutEvent();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                }
                else
                {
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                }
                GC.Collect();
                this.Text = "♫♫ " + OFD.SafeFileNames[playlist];
                if (coverArt == null) coverArt.ImageLocation = Environment.CurrentDirectory + "\\AudioWizard.png";
            }
            catch { }
        }

        private void ForwardTrack_button_Click(object sender, EventArgs e)
        {
            try
            {
                playlist++;
                setCoverArt();
                if (playlist >= OFD.FileNames.Length)
                {
                    outputDevice.Stop();
                    playlist = 0;
                    outputDevice = new WaveOutEvent();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                }
                else
                {
                    outputDevice.Stop();
                    foundationReader = new MediaFoundationReader(OFD.FileNames[playlist]);
                    outputDevice.Init(foundationReader);
                    outputDevice.Play();
                }
                this.Text = "♫♫ " + OFD.SafeFileNames[playlist];
                if (coverArt == null) coverArt.ImageLocation = Environment.CurrentDirectory + "\\AudioWizard.png";
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

                URL_label.Visible = true;
                textbox.Visible = true;
                textbox.Focus();
            }

            catch { MessageBox.Show("Enter a valid URL!"); }

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

        private void stopRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {


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
                TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
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
            catch { MessageBox.Show("None"); }

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
                TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
                TagLib.IPicture pic = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                coverArt.Image = null;
                coverArt.Refresh();
                coverArt.Image = Image.FromStream(ms);
            }
            catch { MessageBox.Show("There is no cover to set!", "Cover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            switch (coverArt.Visible)
            {
                case false:
                    coverArt.Visible = true;
                    coverArtToolStripMenuItem.Text = "Hide cover art";
                    break;
                default:
                    coverArt.Visible = false;
                    coverArtToolStripMenuItem.Text = "Show cover art";
                    break;
            }
        }
        private void loopAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loop_bool==false)
            {
                loop_bool = true;
            }
            else
            {
                loop_bool = false;
            }

        }

        private void audioInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TagLib.File f = TagLib.File.Create(OFD.FileNames[playlist]);
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
            switch (textbox.Visible)
            {
                case false:
                    textbox.Visible = true;
                    URL_label.Visible = true;
                    showURLTextboxToolStripMenuItem.Text = "Hide URL textbox";
                    break;
                default:
                    textbox.Visible = false;
                    URL_label.Visible = false;
                    showURLTextboxToolStripMenuItem.Text = "Show URL textbox";
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
            if (AB == false)
            {
                A = (int)foundationReader.CurrentTime.TotalSeconds;
            }
            else
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
            if (outputDevice != null)
                outputDevice.Volume = volumeSlider.Volume;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Record_button_Click(object sender, EventArgs e)
        {
            try
            {
                IsRecording = true;
                writer = new WaveFileWriter(Environment.CurrentDirectory + "\\recording.wav", capture.WaveFormat);

                capture.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };
                capture.StartRecording();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void showPlayBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Size.Height==419)
            {
                playBox.Visible = true;
                this.Size = new Size(588, 624);
                showPlayBoxToolStripMenuItem.Text = "Hide playBox";
            }
            else
            {
                playBox.Visible = false;
                this.Size = new Size(588, 419);
                showPlayBoxToolStripMenuItem.Text = "Show playBox";
            }

        }

        private void playBox_Click(object sender, EventArgs e)
        {
            try
            {
                outputDevice.Stop();
                foundationReader = new MediaFoundationReader(OFD.FileNames[playBox.SelectedIndex]);
                outputDevice.Init(foundationReader);
                Play_button.Text = "►";
                timer.Tick += Timer_Tick;

                switch (Play_button.Text)
                {
                    case "||":
                        outputDevice.Stop();
                        Play_button.Text = "►";


                        break;
                    case "►":
                        outputDevice.Play();
                        Play_button.Text = "||";
                        break;
                }
                this.Focus();
                this.Text = "♫♫ " + OFD.SafeFileNames[playBox.SelectedIndex];

                TagLib.File f = TagLib.File.Create(OFD.FileNames[playBox.SelectedIndex]);
                TagLib.IPicture pic = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                coverArt.Refresh();
                coverArt.Image = Image.FromStream(ms);
                Lyrics_richtextbox.Text = f.Tag.Lyrics;
                playlist = playBox.SelectedIndex;
            }
            catch { }
        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private async void downloadYoutubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(textbox.Text);

            // ...or highest bitrate audio-only stream
            var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();

            // Get the actual stream
            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

            SFD.Filter = "MP3";
            SFD.ShowDialog();
            // Download the stream to file
            await youtube.Videos.Streams.DownloadAsync(streamInfo, SFD.FileName);

            MessageBox.Show("Download complete");
        }
    }
}

