

using System.Windows.Forms;

namespace TestAudioPlayer
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
            this.stopBtn = new MaterialSkin.Controls.MaterialButton();
            this.previousTrackBtn = new MaterialSkin.Controls.MaterialButton();
            this.nextTrackBtn = new MaterialSkin.Controls.MaterialButton();
            this.trackBar = new MaterialSkin.Controls.MaterialSlider();
            this.timerUpdateControls = new System.Windows.Forms.Timer(this.components);
            this.outputDevicesComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.playBtn.Depth = 0;
            this.playBtn.HighEmphasis = true;
            this.playBtn.Icon = null;
            this.playBtn.Location = new System.Drawing.Point(393, 538);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            // stopBtn
            // 
            this.stopBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stopBtn.Depth = 0;
            this.stopBtn.HighEmphasis = true;
            this.stopBtn.Icon = null;
            this.stopBtn.Location = new System.Drawing.Point(487, 538);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.stopBtn.Size = new System.Drawing.Size(64, 36);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "STOP";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stopBtn.UseAccentColor = false;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtnClick);
            // 
            // previousBtn
            // 
            this.previousTrackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousTrackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousTrackBtn.Depth = 0;
            this.previousTrackBtn.HighEmphasis = true;
            this.previousTrackBtn.Icon = null;
            this.previousTrackBtn.Location = new System.Drawing.Point(300, 538);
            this.previousTrackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousTrackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousTrackBtn.Name = "previousBtn";
            this.previousTrackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.previousTrackBtn.Size = new System.Drawing.Size(64, 36);
            this.previousTrackBtn.TabIndex = 2;
            this.previousTrackBtn.Text = "<<";
            this.previousTrackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousTrackBtn.UseAccentColor = false;
            this.previousTrackBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextTrackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextTrackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextTrackBtn.Depth = 0;
            this.nextTrackBtn.HighEmphasis = true;
            this.nextTrackBtn.Icon = null;
            this.nextTrackBtn.Location = new System.Drawing.Point(580, 538);
            this.nextTrackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextTrackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextTrackBtn.Name = "nextBtn";
            this.nextTrackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextTrackBtn.Size = new System.Drawing.Size(64, 36);
            this.nextTrackBtn.TabIndex = 3;
            this.nextTrackBtn.Text = ">>";
            this.nextTrackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextTrackBtn.UseAccentColor = false;
            this.nextTrackBtn.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Depth = 0;
            this.trackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBar.Location = new System.Drawing.Point(87, 480);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackBar.Name = "trackBar";
            this.trackBar.ShowText = false;
            this.trackBar.ShowValue = false;
            this.trackBar.Size = new System.Drawing.Size(800, 40);
            this.trackBar.TabIndex = 4;
            this.trackBar.Text = "";
            this.trackBar.Value = 0;
            this.trackBar.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.TrackBarPositionValueChanged);
            // 
            // tmrUpdateControls
            // 
            this.timerUpdateControls.Interval = 1000;
            this.timerUpdateControls.Enabled = true;
            this.timerUpdateControls.Tick += new System.EventHandler(this.TimerUpdateTick);
            // 
            // outputDevicesComboBox
            // 
            this.outputDevicesComboBox.AutoResize = false;
            this.outputDevicesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.outputDevicesComboBox.Depth = 0;
            this.outputDevicesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputDevicesComboBox.DropDownHeight = 174;
            this.outputDevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDevicesComboBox.DropDownWidth = 121;
            this.outputDevicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.outputDevicesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputDevicesComboBox.FormattingEnabled = true;
            this.outputDevicesComboBox.IntegralHeight = false;
            this.outputDevicesComboBox.ItemHeight = 43;
            this.outputDevicesComboBox.Location = new System.Drawing.Point(285, 147);
            this.outputDevicesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputDevicesComboBox.MaxDropDownItems = 4;
            this.outputDevicesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.outputDevicesComboBox.Name = "outputDevicesComboBox";
            this.outputDevicesComboBox.Size = new System.Drawing.Size(403, 49);
            this.outputDevicesComboBox.StartIndex = 0;
            this.outputDevicesComboBox.TabIndex = 5;
            this.outputDevicesComboBox.DataSource = this._outputDevices;
            this.outputDevicesComboBox.DisplayMember = "DeviceName";
            // 
            // MainPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 674);
            this.Controls.Add(this.outputDevicesComboBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.nextTrackBtn);
            this.Controls.Add(this.previousTrackBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPlayerForm";
            this.Text = "Player";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainPlayerFormClosing);
            this.Load += new System.EventHandler(this.MainPlayerFormLoad);
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(MainPlayerFormDrag);
            this.DragEnter += new DragEventHandler(MainPlayerFormEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerUpdateControls;
        private MaterialSkin.Controls.MaterialButton playBtn;
        private MaterialSkin.Controls.MaterialButton stopBtn;
        private MaterialSkin.Controls.MaterialButton previousTrackBtn;
        private MaterialSkin.Controls.MaterialButton nextTrackBtn;
        private MaterialSkin.Controls.MaterialSlider trackBar;
        private MaterialSkin.Controls.MaterialComboBox outputDevicesComboBox;
    }
}

