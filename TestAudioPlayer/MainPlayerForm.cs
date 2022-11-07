using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace TestAudioPlayer
{
    public partial class MainPlayerForm : Form
    {
        private int _stream { get; set; }
        private bool _isPlaying { get; set; }
        public MainPlayerForm()
        {
            InitializeComponent();
            InitializeOutputDevices();
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            this.DragEnter += new DragEventHandler(Form1DragEnter);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeOutputDevices()
        {
            var devices = new List<OutputDevice>();
            var test = Bass.BASS_GetDeviceInfos();

           
        }

        private void Form1Load(object sender, System.EventArgs e)
        {
            if (Bass.BASS_Init(4, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle))
            {
                // all fine
            }
            else
                MessageBox.Show(this, "Bass_Init error!");
            var currentDirectory = Directory.GetCurrentDirectory();
            Dictionary<int, string> loadedPlugIns = Bass.BASS_PluginLoadDirectory(currentDirectory);
            TimerUpdateTick(null, null);
        }


        private void Form1Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // unload all loaded add-ons...
            Bass.BASS_PluginFree(0);
            // close bass
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                Bass.BASS_ChannelPause(_stream);
                this.playBtn.Text = "PLAY";
                _isPlaying = false;
            }
            else
            {
                Bass.BASS_ChannelPlay(_stream,false);
                this.playBtn.Text = "PAUSE";
                _isPlaying = true;
            }
            /*var tempPath = @"C:\Users\rosty\Desktop\Samples\B1.Fly Me To The Moon (In Other Words).dsf";
            this.PlaySong(tempPath);*/
        }



        private void TimerUpdateTick(object sender, EventArgs e)
        {
            if (_stream == -1) return;
            try
            {
                long pos = 0;
                long len = 0;
                len = Bass.BASS_ChannelGetLength(_stream);
                pos = Bass.BASS_ChannelGetPosition(_stream);

                double tElapsed = 0;
                double tRemain = 0;
                double tLength = 0;
                tLength = Bass.BASS_ChannelBytes2Seconds(_stream, len);
                tElapsed = Bass.BASS_ChannelBytes2Seconds(_stream, pos);
                tRemain = tLength - tElapsed;
                /*lblTime2.Text = Un4seen.Bass.Utils.FixTimespan(tLength, "MMSS");
                lblTime1.Text = Un4seen.Bass.Utils.FixTimespan(tElapsed, "MMSS");*/

                trackBar.ValueMax = (int)(Bass.BASS_ChannelGetLength(_stream) / 1000);

                //TaskbarManager.Instance.SetProgressValue((int)(Bass.BASS_ChannelGetPosition(stream) / 1000), (int)(Bass.BASS_ChannelGetLength(stream) / 1000), this.Handle);





            }
            catch (Exception ex) { }
        }
        private void TrackBarPositionValueChanged(object sender, int newValue)
        {
            if (true)
            {
                Bass.BASS_ChannelSetPosition(_stream, this.trackBar.Value * 1000);
                TimerUpdateTick(sender, new EventArgs());
            }
        }


        private void PlaySong(string path)
        {
            this.trackBar.Value = 0;
            var tagInfo = new TAG_INFO(path);
            var song = new Song()
            {
                Artist = tagInfo.artist,
                Album = tagInfo.album,
                Title = tagInfo.title,
                Path = path
            };
            this.playBtn.Text = "PAUSE";
            Bass.BASS_StreamFree(_stream);
            _stream = Bass.BASS_StreamCreateFile(song.Path, 0, 0, BASSFlag.BASS_DEFAULT);
            trackBar.RangeMax = (int)(Bass.BASS_ChannelGetLength(_stream) / 1000);
            if (_stream != 0 && Bass.BASS_ChannelPlay(_stream, false))
            {
                _isPlaying = true;
                BASS_CHANNELINFO info = new BASS_CHANNELINFO();
                if (Bass.BASS_ChannelGetInfo(_stream, info))
                {
                }
            }
            else
            {
                MessageBox.Show(this, "Error: " + Enum.GetName(typeof(BASSError), Bass.BASS_ErrorGetCode()));
            }
        }

        private void Form1DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = files.First();
            this.PlaySong(filePath);
        }



    }
}







