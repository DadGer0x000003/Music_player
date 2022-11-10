using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using Un4seen.BassWasapi;

namespace AudioPlayer
{
    public partial class MainPlayerForm : Form
    {
        private int _stream { get; set; }

        private IList<OutputDevice> _outputDevices { get; set; }

        private Song _currentSong { get; set; }

        private bool _isExclusiveModeActive { get; set; }

        private BindingList<Song> _songs { get; set; } = new BindingList<Song>() { new Song() { Title = "Lose Yourself", Artist = "Eminem",
            Path = @"C:\Users\User\Desktop\ProductionProjects\AudioSamples\Eminem - Lose Yourself.mp3" } };


        public MainPlayerForm()
        {
            InitializeOutputDevices();
            InitializeComponent();

            this.songsListBox.DataSource = _songs;
            this.songsListBox.DisplayMember = "Title";

            this.outputDevicesComboBox.DataSource = this._outputDevices;
            this.outputDevicesComboBox.DisplayMember = "DeviceName";
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
                return;
            }

            if (ChannelState() is BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_ChannelPlay(_stream, false);
                this.playBtn.Text = "PAUSE";
                return;
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

            var state = ChannelState();
            if (state is BASSActive.BASS_ACTIVE_STOPPED && _currentSong != null)
            {
                PlayNextTrack();
            }
        }

        private void PlayNextTrack()
        {
            var currentSongIndex = 0;

            if (this._songs == null || !this._songs.Any())
            {
                return;
            }

            try
            {
                currentSongIndex = _songs.IndexOf(this._currentSong);
            }
            catch
            (Exception ex)
            {

            }

            if (currentSongIndex >= this._songs.Count - 1)
            {
                this._currentSong = this._songs.First();
            }

            if (currentSongIndex < this._songs.Count - 1)
            {
                currentSongIndex++;
                this._currentSong = this._songs[currentSongIndex];
            }

            this.songsListBox.SelectedIndex = _songs.IndexOf(_currentSong);
            this.PlaySong(this._currentSong);


        }

        private void PlayPreviousTrack()
        {
            var currentSongIndex = 0;

            if (this._songs == null || !this._songs.Any())
            {
                return;
            }

            try
            {
                currentSongIndex = _songs.IndexOf(this._currentSong);
            }
            catch
            (Exception ex)
            {

            }

            switch (currentSongIndex)
            {
                case 0:
                    break;
                default:
                    currentSongIndex--;
                    break;
            }
            this._currentSong = this._songs[currentSongIndex];
            this.songsListBox.SelectedIndex = currentSongIndex;
            this.PlaySong(this._currentSong);
        }

        private void DeviceSelected(object sender, EventArgs e)
        {
            var selectedDevice = (OutputDevice)this.outputDevicesComboBox.SelectedItem;
            var deviceIsInit = Bass.BASS_Init(selectedDevice.DeviceId, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            var deviceIsSetted = Bass.BASS_SetDevice(selectedDevice.DeviceId);
            if (ChannelState() is BASSActive.BASS_ACTIVE_PLAYING || ChannelState() is BASSActive.BASS_ACTIVE_PAUSED)
                Bass.BASS_ChannelSetDevice(_stream, selectedDevice.DeviceId);
        }

        private void SongBtnDoubleClick(object sender, MouseEventArgs e)
        {
            _currentSong = (Song)this.songsListBox.SelectedValue;
            this.PlaySong(_currentSong);
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

        private void PlaySong(Song song)
        {
            this.playBtn.Text = "PAUSE";
            Bass.BASS_StreamFree(_stream);
            _stream = Bass.BASS_StreamCreateFile(song.Path, 0, 0, BASSFlag.BASS_DEFAULT);
            trackBar.RangeMax = (int)(Bass.BASS_ChannelGetLength(_stream) / 1000);
            if (_stream != 0 && Bass.BASS_ChannelPlay(_stream, false))
            {
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


            var tagInfo = new TAG_INFO(filePath);
            var song = new Song()
            {
                Artist = tagInfo.artist,
                Album = tagInfo.album,
                Title = tagInfo.title,
                Path = filePath
            };


            this.AddSongToPlayList(song);
        }

        private void AddSongToPlayList(Song song)
        {
            this._songs.Add(song);
        }

        private void AddSongButtonClick(object sender, EventArgs e)
        {

        }

        private void RemoveSongButtonClick(object sender, EventArgs e)
        {
            var curentSong = (Song)this.songsListBox.SelectedItem;
            this._songs.Remove(curentSong);
        }

        private void NextTrackBtnClick(object sender, EventArgs e)
        {
            this.PlayNextTrack();
        }

        private void PreviousTrackBtnClick(object sender, EventArgs e)
        {
            this.PlayPreviousTrack();
        }

        private void WasapiCheckboxCheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExclusiveModeCheckboxCheckedChanged(object sender, EventArgs e)
        {
            this.ActivateExclusiveMode();
        }


        private void ActivateExclusiveMode()
        {
            if (!_isExclusiveModeActive)
            {
                BASS_WASAPI_INFO info = new BASS_WASAPI_INFO();
                BassWasapi.BASS_WASAPI_GetInfo(info);
                
                //var result = BassWasapi.BASS_WASAPI_Init(-1, 44100, 2, BASSWASAPIInit.BASS_WASAPI_EXCLUSIVE, test., 0, null, this.Handle);
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
            }
        }
    }
}







