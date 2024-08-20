using System.ComponentModel;
using System.Media;
using System.Numerics;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;



namespace dyzurnyruchu
{
    public partial class Form1 : Form
    {
       
        string musicPath = "";
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        bool isPaused = true;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //opens openfiledialog

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                musicPath = openFileDialog.FileName;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPaused == true) ;
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    //outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {
                    if (musicPath != "")
                    {
                        audioFile = new AudioFileReader(musicPath);
                        outputDevice.Init(audioFile);
                    }
                    else if (musicPath == "")
                    {
                        MessageBox.Show("Nothing was selected", "Nothing was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                outputDevice.Play();
            }

        }

     
        
        
    }
};
