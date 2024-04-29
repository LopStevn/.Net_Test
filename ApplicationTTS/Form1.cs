using System;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using NAudio.Wave;

namespace ApplicationTTS
{
    public partial class Form1 : Form
    {
        private readonly SpeechSynthesizer synth;
        private readonly IWavePlayer waveOutDevice;
        private OpenFileDialog openFileDialog1, openFileDialog2, openFileDialog3;
        private string texto;
        private string file1, file2, file3;

        public Form1()
        {
            InitializeComponent();

            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0,
                new System.Globalization.CultureInfo("es-ES"));

            waveOutDevice = new WaveOut();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "MP3 Files|*.mp3";

            openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "MP3 Files|*.mp3";

            openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "MP3 Files|*.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file1 = openFileDialog1.FileName;
                txt_file1.Text = Path.GetFileName(file1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                file2 = openFileDialog2.FileName;
                txt_file2.Text = Path.GetFileName(file2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                file3 = openFileDialog3.FileName;
                txt_file3.Text = Path.GetFileName(file3);
            }
        }

        private Task PlayAudio(string fileName)
        {
            return Task.Run(() =>
            {
                using (var reader = new Mp3FileReader(fileName))
                using (var waveStream = WaveFormatConversionStream.CreatePcmStream(reader))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(waveStream);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(100);
                    }
                }
            });
        }

        private void PlaySynthesizedTextAsync(string text)
        {
            synth.Speak(text);
        }

        private async void btn_Play_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(file1) || string.IsNullOrWhiteSpace(file2) || string.IsNullOrWhiteSpace(file3))
                {
                    MessageBox.Show("Please make sure to select MP3 files in all set fields before playing.", "Empty file fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                texto = txt_word.Text;

                await PlayAudio(file1);
                PlaySynthesizedTextAsync(texto);
                await PlayAudio(file2);
                await PlayAudio(file3);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred." + ex.Message);
            }
            
        }
    }
}
