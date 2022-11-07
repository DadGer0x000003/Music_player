

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
            this.previousBtn = new MaterialSkin.Controls.MaterialButton();
            this.nextBtn = new MaterialSkin.Controls.MaterialButton();
            this.trackBar = new MaterialSkin.Controls.MaterialSlider();
            this.tmrUpdateControls = new System.Windows.Forms.Timer(this.components);
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
            this.playBtn.Location = new System.Drawing.Point(295, 437);
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
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stopBtn.Depth = 0;
            this.stopBtn.HighEmphasis = true;
            this.stopBtn.Icon = null;
            this.stopBtn.Location = new System.Drawing.Point(365, 437);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousBtn.Depth = 0;
            this.previousBtn.HighEmphasis = true;
            this.previousBtn.Icon = null;
            this.previousBtn.Location = new System.Drawing.Point(225, 437);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previousBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.previousBtn.Size = new System.Drawing.Size(64, 36);
            this.previousBtn.TabIndex = 2;
            this.previousBtn.Text = "<<";
            this.previousBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousBtn.UseAccentColor = false;
            this.previousBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextBtn.Depth = 0;
            this.nextBtn.HighEmphasis = true;
            this.nextBtn.Icon = null;
            this.nextBtn.Location = new System.Drawing.Point(435, 437);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextBtn.Size = new System.Drawing.Size(64, 36);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = ">>";
            this.nextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextBtn.UseAccentColor = false;
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Depth = 0;
            this.trackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBar.Location = new System.Drawing.Point(65, 390);
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
            // tmrUpdateControls
            // 
            this.tmrUpdateControls.Interval = 1000;
            this.tmrUpdateControls.Tick += new System.EventHandler(this.TimerUpdateTick);
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
            this.outputDevicesComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.outputDevicesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputDevicesComboBox.FormattingEnabled = true;
            this.outputDevicesComboBox.IntegralHeight = false;
            this.outputDevicesComboBox.ItemHeight = 43;
            this.outputDevicesComboBox.Location = new System.Drawing.Point(196, 21);
            this.outputDevicesComboBox.MaxDropDownItems = 4;
            this.outputDevicesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.outputDevicesComboBox.Name = "outputDevicesComboBox";
            this.outputDevicesComboBox.Size = new System.Drawing.Size(303, 49);
            this.outputDevicesComboBox.StartIndex = 0;
            this.outputDevicesComboBox.TabIndex = 5;
            // 
            // MainPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 548);
            this.Controls.Add(this.outputDevicesComboBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPlayerForm";
            this.Text = "Player";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1Closing);
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrUpdateControls;
        private MaterialSkin.Controls.MaterialButton playBtn;
        private MaterialSkin.Controls.MaterialButton stopBtn;
        private MaterialSkin.Controls.MaterialButton previousBtn;
        private MaterialSkin.Controls.MaterialButton nextBtn;
        private MaterialSkin.Controls.MaterialSlider trackBar;
        private MaterialSkin.Controls.MaterialComboBox outputDevicesComboBox;
    }
}

