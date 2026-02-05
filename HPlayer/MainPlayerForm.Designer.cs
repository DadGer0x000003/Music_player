

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPlayerForm));
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
            this.exclusiveModeMaterialCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.volumeSlider = new MaterialSkin.Controls.MaterialSlider();
            this.artistLabel = new MaterialSkin.Controls.MaterialLabel();
            this.albumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.playBtn.Depth = 0;
            this.playBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.playBtn.HighEmphasis = true;
            this.playBtn.Icon = null;
            this.playBtn.Location = new System.Drawing.Point(274, 64);
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
            this.previousTrackBtn.Location = new System.Drawing.Point(204, 64);
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
            this.nextTrackBtn.Location = new System.Drawing.Point(344, 64);
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
            this.trackBar.Location = new System.Drawing.Point(94, 17);
            this.trackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackBar.Name = "trackBar";
            this.trackBar.ShowText = false;
            this.trackBar.ShowValue = false;
            this.trackBar.Size = new System.Drawing.Size(575, 40);
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
            this.outputDevicesComboBox.Location = new System.Drawing.Point(0, 3);
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
            this.trackTimeDurationLabel.Location = new System.Drawing.Point(674, 38);
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
            this.trackElapsedTimeLabel.Location = new System.Drawing.Point(48, 38);
            this.trackElapsedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackElapsedTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackElapsedTimeLabel.Name = "trackElapsedTimeLabel";
            this.trackElapsedTimeLabel.Size = new System.Drawing.Size(41, 19);
            this.trackElapsedTimeLabel.TabIndex = 7;
            this.trackElapsedTimeLabel.Text = "00:00";
            // 
            // songsListBox
            // 
            this.songsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 20;
            this.songsListBox.Location = new System.Drawing.Point(68, 13);
            this.songsListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(491, 304);
            this.songsListBox.TabIndex = 8;
            this.songsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SongBtnDoubleClick);
            // 
            // AddSongMaterialButton
            // 
            this.AddSongMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddSongMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddSongMaterialButton.Depth = 0;
            this.AddSongMaterialButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddSongMaterialButton.HighEmphasis = true;
            this.AddSongMaterialButton.Icon = null;
            this.AddSongMaterialButton.Location = new System.Drawing.Point(564, 224);
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
            this.EditSongMaterialButton.Location = new System.Drawing.Point(564, 270);
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
            // exclusiveModeMaterialCheckbox
            // 
            this.exclusiveModeMaterialCheckbox.AutoSize = true;
            this.exclusiveModeMaterialCheckbox.Depth = 0;
            this.exclusiveModeMaterialCheckbox.Location = new System.Drawing.Point(0, 55);
            this.exclusiveModeMaterialCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.exclusiveModeMaterialCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.exclusiveModeMaterialCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.exclusiveModeMaterialCheckbox.Name = "exclusiveModeMaterialCheckbox";
            this.exclusiveModeMaterialCheckbox.ReadOnly = false;
            this.exclusiveModeMaterialCheckbox.Ripple = true;
            this.exclusiveModeMaterialCheckbox.Size = new System.Drawing.Size(462, 37);
            this.exclusiveModeMaterialCheckbox.TabIndex = 13;
            this.exclusiveModeMaterialCheckbox.Text = "\"Exclusive\" Mode - Тестова функція, тимчасово вимкнуто.";
            this.exclusiveModeMaterialCheckbox.UseVisualStyleBackColor = true;
            // 
            // volumeSlider
            // 
            this.volumeSlider.Depth = 0;
            this.volumeSlider.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.volumeSlider.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.volumeSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volumeSlider.Location = new System.Drawing.Point(424, 62);
            this.volumeSlider.Margin = new System.Windows.Forms.Padding(2);
            this.volumeSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(245, 40);
            this.volumeSlider.TabIndex = 14;
            this.volumeSlider.Text = "Volume";
            this.volumeSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.SliderVolumeValueChanged);
            // 
            // artistLabel
            // 
            this.artistLabel.Depth = 0;
            this.artistLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.artistLabel.Location = new System.Drawing.Point(515, 81);
            this.artistLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(308, 20);
            this.artistLabel.TabIndex = 15;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // albumLabel
            // 
            this.albumLabel.Depth = 0;
            this.albumLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.albumLabel.Location = new System.Drawing.Point(515, 117);
            this.albumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(308, 20);
            this.albumLabel.TabIndex = 16;
            this.albumLabel.Text = "Album";
            this.albumLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(515, 41);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 20);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(172, 9);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(337, 338);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 18;
            this.coverPictureBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-add-album-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-playlist-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-smart-playlist-32.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialScrollBar1);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.trackElapsedTimeLabel);
            this.panel1.Controls.Add(this.trackTimeDurationLabel);
            this.panel1.Controls.Add(this.nextTrackBtn);
            this.panel1.Controls.Add(this.previousTrackBtn);
            this.panel1.Controls.Add(this.volumeSlider);
            this.panel1.Location = new System.Drawing.Point(73, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 107);
            this.panel1.TabIndex = 19;
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialScrollBar1.Location = new System.Drawing.Point(513, 53);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Horizontal;
            this.materialScrollBar1.ScrollbarSize = 13;
            this.materialScrollBar1.Size = new System.Drawing.Size(95, 13);
            this.materialScrollBar1.TabIndex = 15;
            this.materialScrollBar1.Text = "materialScrollBar1";
            this.materialScrollBar1.UseBarColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(848, 393);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditSongMaterialButton);
            this.tabPage1.Controls.Add(this.AddSongMaterialButton);
            this.tabPage1.Controls.Add(this.songsListBox);
            this.tabPage1.ImageKey = "icons8-add-album-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PlayList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.titleLabel);
            this.tabPage2.Controls.Add(this.artistLabel);
            this.tabPage2.Controls.Add(this.coverPictureBox);
            this.tabPage2.Controls.Add(this.albumLabel);
            this.tabPage2.ImageKey = "icons8-playlist-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Now playing ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialTabControl2);
            this.tabPage3.Controls.Add(this.materialTabSelector1);
            this.tabPage3.ImageKey = "icons8-smart-playlist-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Preferences";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(68, 46);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(769, 298);
            this.materialTabControl2.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.outputDevicesComboBox);
            this.tabPage4.Controls.Add(this.exclusiveModeMaterialCheckbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 272);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Device selection";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(761, 272);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Other";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(68, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(769, 37);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // MainPlayerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 549);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "MainPlayerForm";
            this.Text = "HPlayer beta 3.1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainPlayerFormClosing);
            this.Load += new System.EventHandler(this.MainPlayerFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainPlayerFormDrag);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainPlayerFormEnter);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

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
        private MaterialSkin.Controls.MaterialCheckbox exclusiveModeMaterialCheckbox;
        private MaterialSkin.Controls.MaterialSlider volumeSlider;
        private MaterialSkin.Controls.MaterialLabel artistLabel;
        private MaterialSkin.Controls.MaterialLabel albumLabel;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private PictureBox coverPictureBox;
        private ImageList imageList1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}

