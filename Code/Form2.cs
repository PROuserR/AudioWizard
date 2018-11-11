using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using TagLib.Id3v1;

namespace AudioWizard
{
    public partial class Form2 : Form
    {
        WaveOutEvent outPutDevice;
        SignalGenerator generator;
        public Form2()
        {
            InitializeComponent();
        }

        private void One_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.Pink;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Two_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.SawTooth;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Three_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.Sin;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Four_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.Square;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Five_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500,FrequencyEnd=2000 };
            generator.Type = SignalGeneratorType.Sweep;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Six_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.Triangle;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }

        private void Seven_trackbar_Scroll(object sender, EventArgs e)
        {
            if (!(outPutDevice == null)) outPutDevice.Stop();
            outPutDevice = new WaveOutEvent();
            generator = new SignalGenerator() { Gain = 0.2, Frequency = 500 };
            generator.Type = SignalGeneratorType.White;
            outPutDevice.Volume = One_trackbar.Value / 10f;
            outPutDevice.Init(generator);
            outPutDevice.Play();
        }
    }
}
