

using System.Windows.Forms;

namespace AudioPlayer
{
    partial class MainPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playBtn = new MaterialSkin.Controls.MaterialButton();
            this.previousTrackBtn = new MaterialSkin.Controls.MaterialButton();
            this.nextTrackBtn = new MaterialSkin.Controls.MaterialButton();
            this.trackBar = new MaterialSkin.Controls.MaterialSlider();
            this.timerUpdateControls = new System.Windows.Forms.Timer(this.components);
            this.outputDevicesComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.trackTimeDurationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.trackElapsedTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.AddSongMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.EditSongMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.exclusiveModeMaterialCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.volumeSlider = new MaterialSkin.Controls.MaterialSlider();
            this.artistLabel = new MaterialSkin.Controls.MaterialLabel();
            this.albumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.playBtn.Depth = 0;
            this.playBtn.HighEmphasis = true;
            this.playBtn.Icon = null;
            this.playBtn.Location = new System.Drawing.Point(324, 470);
            this.playBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.playBtn.Name = "playBtn";
            this.playBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.playBtn.Size = new System.Drawing.Size(64, 36);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "PLAY";
            this.playBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.playBtn.UseAccentColor = false;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtnClick);
            // 
            // previousTrackBtn
            // 
            this.previousTrackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousTrackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousTrackBtn.Depth = 0;
            this.previousTrackBtn.HighEmphasis = true;
            this.previousTrackBtn.Icon = null;
            this.previousTrackBtn.Location = new System.Drawing.Point(223, 470);
            this.previousTrackBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previousTrackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousTrackBtn.Name = "previousTrackBtn";
            this.previousTrackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.previousTrackBtn.Size = new System.Drawing.Size(64, 36);
            this.previousTrackBtn.TabIndex = 2;
            this.previousTrackBtn.Text = "<<";
            this.previousTrackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousTrackBtn.UseAccentColor = false;
            this.previousTrackBtn.UseVisualStyleBackColor = true;
            this.previousTrackBtn.Click += new System.EventHandler(this.PreviousTrackBtnClick);
            // 
            // nextTrackBtn
            // 
            this.nextTrackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextTrackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextTrackBtn.Depth = 0;
            this.nextTrackBtn.HighEmphasis = true;
            this.nextTrackBtn.Icon = null;
            this.nextTrackBtn.Location = new System.Drawing.Point(433, 470);
            this.nextTrackBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextTrackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextTrackBtn.Name = "nextTrackBtn";
            this.nextTrackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextTrackBtn.Size = new System.Drawing.Size(64, 36);
            this.nextTrackBtn.TabIndex = 3;
            this.nextTrackBtn.Text = ">>";
            this.nextTrackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextTrackBtn.UseAccentColor = false;
            this.nextTrackBtn.UseVisualStyleBackColor = true;
            this.nextTrackBtn.Click += new System.EventHandler(this.NextTrackBtnClick);
            // 
            // trackBar
            // 
            this.trackBar.Depth = 0;
            this.trackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBar.Location = new System.Drawing.Point(82, 423);
            this.trackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackBar.Name = "trackBar";
            this.trackBar.ShowText = false;
            this.trackBar.ShowValue = false;
            this.trackBar.Size = new System.Drawing.Size(600, 40);
            this.trackBar.TabIndex = 4;
            this.trackBar.Text = "";
            this.trackBar.Value = 0;
            this.trackBar.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.TrackBarPositionValueChanged);
            // 
            // timerUpdateControls
            // 
            this.timerUpdateControls.Enabled = true;
            this.timerUpdateControls.Interval = 500;
            this.timerUpdateControls.Tick += new System.EventHandler(this.TimerUpdateTick);
            // 
            // outputDevicesComboBox
            // 
            this.outputDevicesComboBox.AutoResize = false;
            this.outputDevicesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.outputDevicesComboBox.Depth = 0;
            this.outputDevicesComboBox.DisplayMember = "DeviceName";
            this.outputDevicesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputDevicesComboBox.DropDownHeight = 174;
            this.outputDevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDevicesComboBox.DropDownWidth = 121;
            this.outputDevicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.outputDevicesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputDevicesComboBox.FormattingEnabled = true;
            this.outputDevicesComboBox.IntegralHeight = false;
            this.outputDevicesComboBox.ItemHeight = 43;
            this.outputDevicesComboBox.Location = new System.Drawing.Point(433, 10);
            this.outputDevicesComboBox.MaxDropDownItems = 4;
            this.outputDevicesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.outputDevicesComboBox.Name = "outputDevicesComboBox";
            this.outputDevicesComboBox.Size = new System.Drawing.Size(285, 49);
            this.outputDevicesComboBox.StartIndex = 0;
            this.outputDevicesComboBox.TabIndex = 5;
            this.outputDevicesComboBox.SelectionChangeCommitted += new System.EventHandler(this.DeviceSelected);
            // 
            // trackTimeDurationLabel
            // 
            this.trackTimeDurationLabel.AutoSize = true;
            this.trackTimeDurationLabel.Depth = 0;
            this.trackTimeDurationLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.trackTimeDurationLabel.Location = new System.Drawing.Point(687, 423);
            this.trackTimeDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackTimeDurationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackTimeDurationLabel.Name = "trackTimeDurationLabel";
            this.trackTimeDurationLabel.Size = new System.Drawing.Size(41, 19);
            this.trackTimeDurationLabel.TabIndex = 6;
            this.trackTimeDurationLabel.Text = "00:00";
            // 
            // trackElapsedTimeLabel
            // 
            this.trackElapsedTimeLabel.AutoSize = true;
            this.trackElapsedTimeLabel.Depth = 0;
            this.trackElapsedTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.trackElapsedTimeLabel.Location = new System.Drawing.Point(38, 423);
            this.trackElapsedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackElapsedTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackElapsedTimeLabel.Name = "trackElapsedTimeLabel";
            this.trackElapsedTimeLabel.Size = new System.Drawing.Size(41, 19);
            this.trackElapsedTimeLabel.TabIndex = 7;
            this.trackElapsedTimeLabel.Text = "00:00";
            // 
            // songsListBox
            // 
            this.songsListBox.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 18;
            this.songsListBox.Location = new System.Drawing.Point(9, 10);
            this.songsListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(410, 166);
            this.songsListBox.TabIndex = 8;
            this.songsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SongBtnDoubleClick);
            // 
            // AddSongMaterialButton
            // 
            this.AddSongMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddSongMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddSongMaterialButton.Depth = 0;
            this.AddSongMaterialButton.HighEmphasis = true;
            this.AddSongMaterialButton.Icon = null;
            this.AddSongMaterialButton.Location = new System.Drawing.Point(355, 194);
            this.AddSongMaterialButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddSongMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddSongMaterialButton.Name = "AddSongMaterialButton";
            this.AddSongMaterialButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddSongMaterialButton.Size = new System.Drawing.Size(64, 36);
            this.AddSongMaterialButton.TabIndex = 9;
            this.AddSongMaterialButton.Text = "Add";
            this.AddSongMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddSongMaterialButton.UseAccentColor = false;
            this.AddSongMaterialButton.UseVisualStyleBackColor = true;
            this.AddSongMaterialButton.Click += new System.EventHandler(this.AddSongButtonClick);
            // 
            // EditSongMaterialButton
            // 
            this.EditSongMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditSongMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditSongMaterialButton.Depth = 0;
            this.EditSongMaterialButton.HighEmphasis = true;
            this.EditSongMaterialButton.Icon = null;
            this.EditSongMaterialButton.Location = new System.Drawing.Point(270, 195);
            this.EditSongMaterialButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EditSongMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditSongMaterialButton.Name = "EditSongMaterialButton";
            this.EditSongMaterialButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditSongMaterialButton.Size = new System.Drawing.Size(80, 36);
            this.EditSongMaterialButton.TabIndex = 10;
            this.EditSongMaterialButton.Text = "Remove";
            this.EditSongMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditSongMaterialButton.UseAccentColor = false;
            this.EditSongMaterialButton.UseVisualStyleBackColor = true;
            this.EditSongMaterialButton.Click += new System.EventHandler(this.RemoveSongButtonClick);
            // 
            // titleLabel
            // 
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(299, 283);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 20);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Visible = false;
            // 
            // exclusiveModeMaterialCheckbox
            // 
            this.exclusiveModeMaterialCheckbox.AutoSize = true;
            this.exclusiveModeMaterialCheckbox.Depth = 0;
            this.exclusiveModeMaterialCheckbox.Location = new System.Drawing.Point(433, 64);
            this.exclusiveModeMaterialCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.exclusiveModeMaterialCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.exclusiveModeMaterialCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.exclusiveModeMaterialCheckbox.Name = "exclusiveModeMaterialCheckbox";
            this.exclusiveModeMaterialCheckbox.ReadOnly = false;
            this.exclusiveModeMaterialCheckbox.Ripple = true;
            this.exclusiveModeMaterialCheckbox.Size = new System.Drawing.Size(155, 37);
            this.exclusiveModeMaterialCheckbox.TabIndex = 13;
            this.exclusiveModeMaterialCheckbox.Text = "\"Exclusive\" Mode";
            this.exclusiveModeMaterialCheckbox.UseVisualStyleBackColor = true;
            // 
            // volumeSlider
            // 
            this.volumeSlider.Depth = 0;
            this.volumeSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volumeSlider.Location = new System.Drawing.Point(433, 122);
            this.volumeSlider.Margin = new System.Windows.Forms.Padding(2);
            this.volumeSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(236, 40);
            this.volumeSlider.TabIndex = 14;
            this.volumeSlider.Text = "Volume";
            this.volumeSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.SliderVolumeValueChanged);
            // 
            // artistLabel
            // 
            this.artistLabel.Depth = 0;
            this.artistLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.artistLabel.Location = new System.Drawing.Point(341, 314);
            this.artistLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(38, 19);
            this.artistLabel.TabIndex = 15;
            this.artistLabel.Text = "Artist";
            this.artistLabel.Visible = false;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Depth = 0;
            this.albumLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.albumLabel.Location = new System.Drawing.Point(341, 348);
            this.albumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(47, 19);
            this.albumLabel.TabIndex = 16;
            this.albumLabel.Text = "Album";
            this.albumLabel.Visible = false;
            // 
            // MainPlayerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 547);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.exclusiveModeMaterialCheckbox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.EditSongMaterialButton);
            this.Controls.Add(this.AddSongMaterialButton);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.trackElapsedTimeLabel);
            this.Controls.Add(this.trackTimeDurationLabel);
            this.Controls.Add(this.outputDevicesComboBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.nextTrackBtn);
            this.Controls.Add(this.previousTrackBtn);
            this.Controls.Add(this.playBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainPlayerForm";
            this.Text = "Player";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainPlayerFormClosing);
            this.Load += new System.EventHandler(this.MainPlayerFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainPlayerFormDrag);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainPlayerFormEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerUpdateControls;
        private MaterialSkin.Controls.MaterialButton playBtn;
        private MaterialSkin.Controls.MaterialButton previousTrackBtn;
        private MaterialSkin.Controls.MaterialButton nextTrackBtn;
        private MaterialSkin.Controls.MaterialSlider trackBar;
        private MaterialSkin.Controls.MaterialComboBox outputDevicesComboBox;
        private MaterialSkin.Controls.MaterialLabel trackTimeDurationLabel;
        private MaterialSkin.Controls.MaterialLabel trackElapsedTimeLabel;
        private ListBox songsListBox;
        private MaterialSkin.Controls.MaterialButton AddSongMaterialButton;
        private MaterialSkin.Controls.MaterialButton EditSongMaterialButton;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialCheckbox exclusiveModeMaterialCheckbox;
        private MaterialSkin.Controls.MaterialSlider volumeSlider;
        private MaterialSkin.Controls.MaterialLabel artistLabel;
        private MaterialSkin.Controls.MaterialLabel albumLabel;
    }
}

