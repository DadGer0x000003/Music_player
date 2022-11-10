using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace AudioPlayer
{
    public partial class MainPlayerForm : Form
    {
        private int _stream { get; set; }
        private IList<OutputDevice> _outputDevices { get; set; }


        public MainPlayerForm()
        {
            InitializeOutputDevices();
            InitializeComponent();

            this.outputDevicesComboBox.DataSource = this._outputDevices;
            this.outputDevicesComboBox.DisplayMember= "DeviceName";
        }

        private void StopBtnClick(object sender, EventArgs e)
        {

        }

        private void InitializeOutputDevices()
        {
            var devices = Bass.BASS_GetDeviceInfos();
            this._outputDevices = devices.Where(x => x.name != "No sound")
                .Select(x => new OutputDevice() { DeviceId = Array.IndexOf(devices, x), DeviceName = x.name }).ToList();
        }

        private void MainPlayerFormLoad(object sender, System.EventArgs e)
        {
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle))
            {
                // all fine, download add-ons
                var currentDirectory = Directory.GetCurrentDirectory();
                Dictionary<int, string> loadedPlugIns = Bass.BASS_PluginLoadDirectory(currentDirectory);
            }
            else
            {
                MessageBox.Show(this, "Bass_Init error!");
            }
            TimerUpdateTick(null, null);
        }

        private void MainPlayerFormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // unload all loaded add-ons...
            Bass.BASS_PluginFree(0);
            // close bass
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }

        private void PlayBtnClick(object sender, EventArgs e)
        {
            if (ChannelState() is BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(_stream);
                this.playBtn.Text = "PLAY";
            }

            if (ChannelState() is BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_ChannelPlay(_stream, false);
                this.playBtn.Text = "PAUSE";
            }
        }

        private void TimerUpdateTick(object sender, EventArgs e)
        {
            if (_stream == -1) return;
            try
            {
                long currentTrackPositin = 0;
                long trackLength = 0;
                trackLength = Bass.BASS_ChannelGetLength(_stream);
                currentTrackPositin = Bass.BASS_ChannelGetPosition(_stream);

                double timeElapsed = 0;
                double timeRemain = 0;
                double trackDuration = 0;
                trackDuration = Bass.BASS_ChannelBytes2Seconds(_stream, trackLength);
                timeElapsed = Bass.BASS_ChannelBytes2Seconds(_stream, currentTrackPositin);
                timeRemain = trackDuration - timeElapsed;
                if (trackDuration > 0 && timeElapsed > 0)
                {
                    var trackDurationTime = Utils.FixTimespan(trackDuration, "MMSS");
                    var trackElapsedTime = Utils.FixTimespan(timeElapsed, "MMSS");
                    this.trackElapsedTimeLabel.Text = trackElapsedTime;
                    this.trackTimeDurationLabel.Text = trackDurationTime;
                }
                trackBar.ValueMax = (int)(Bass.BASS_ChannelGetLength(_stream) / 1000);
                trackBar.Value = (int)(Bass.BASS_ChannelGetPosition(_stream) / 1000);
                InitializeOutputDevices();
            }
            catch (Exception ex) { }
        }

        private void DeviceSelected(object sender, EventArgs e)
        {
            var selectedDevice = (OutputDevice)this.outputDevicesComboBox.SelectedItem;
            var deviceIsInit = Bass.BASS_Init(selectedDevice.DeviceId, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            var deviceIsSetted = Bass.BASS_SetDevice(selectedDevice.DeviceId);
            
            if (ChannelState() is BASSActive.BASS_ACTIVE_PLAYING || ChannelState() is BASSActive.BASS_ACTIVE_PAUSED)
                Bass.BASS_ChannelSetDevice(_stream, selectedDevice.DeviceId);
            if (!deviceIsInit || !deviceIsSetted)
            {
                MessageBox.Show(this, $"Error {Bass.BASS_ErrorGetCode()}");
            }
        }

        private BASSActive ChannelState()
        {
            return Bass.BASS_ChannelIsActive(_stream);           
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

        private void MainPlayerFormEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainPlayerFormDrag(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = files.First();
            this.PlaySong(filePath);
        }
    }
}







