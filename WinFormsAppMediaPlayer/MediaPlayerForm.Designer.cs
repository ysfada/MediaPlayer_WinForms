namespace WinFormsAppMediaPlayer
{
    partial class MediaPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerForm));
            this.ControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.BackwardBtn = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DarkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.LightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionTrackbarPanel = new System.Windows.Forms.Panel();
            this.DividerLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DurationTimer = new System.Windows.Forms.Timer(this.components);
            this.PositionTrackbar = new WinFormsAppMediaPlayer.DoubleTrackbar();
            this.StopBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.LoopBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.MuteUnmuteBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.PlaylistToggleBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.NextBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.PlayPauseBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.PreviousBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.ControlTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.MainTableLayoutPanel.SuspendLayout();
            this.PositionTrackbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTableLayoutPanel
            // 
            this.ControlTableLayoutPanel.ColumnCount = 14;
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ControlTableLayoutPanel.Controls.Add(this.StopBtn, 4, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.LoopBtn, 8, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.MuteUnmuteBtn, 11, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.PlaylistToggleBtn, 9, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.NextBtn, 6, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.ForwardBtn, 5, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.VolumeTrackBar, 12, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.PlayPauseBtn, 1, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.PreviousBtn, 2, 0);
            this.ControlTableLayoutPanel.Controls.Add(this.BackwardBtn, 3, 0);
            this.ControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlTableLayoutPanel.Location = new System.Drawing.Point(0, 261);
            this.ControlTableLayoutPanel.Name = "ControlTableLayoutPanel";
            this.ControlTableLayoutPanel.RowCount = 1;
            this.ControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableLayoutPanel.Size = new System.Drawing.Size(634, 50);
            this.ControlTableLayoutPanel.TabIndex = 5;
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.ForwardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardBtn.BackgroundImage")));
            this.ForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ForwardBtn.FlatAppearance.BorderSize = 0;
            this.ForwardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForwardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ForwardBtn.Location = new System.Drawing.Point(209, 9);
            this.ForwardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(32, 32);
            this.ForwardBtn.TabIndex = 8;
            this.ForwardBtn.UseVisualStyleBackColor = false;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VolumeTrackBar.Location = new System.Drawing.Point(527, 2);
            this.VolumeTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(94, 45);
            this.VolumeTrackBar.TabIndex = 4;
            this.VolumeTrackBar.Value = 100;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // BackwardBtn
            // 
            this.BackwardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackwardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackwardBtn.BackgroundImage")));
            this.BackwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackwardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackwardBtn.FlatAppearance.BorderSize = 0;
            this.BackwardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackwardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BackwardBtn.Location = new System.Drawing.Point(117, 9);
            this.BackwardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackwardBtn.Name = "BackwardBtn";
            this.BackwardBtn.Size = new System.Drawing.Size(32, 32);
            this.BackwardBtn.TabIndex = 7;
            this.BackwardBtn.UseVisualStyleBackColor = false;
            this.BackwardBtn.Click += new System.EventHandler(this.BackwardBtn_Click);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 5;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.Controls.Add(this.DarkThemeRadioButton, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.LightThemeRadioButton, 1, 2);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 4;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(634, 213);
            this.MainTableLayoutPanel.TabIndex = 6;
            // 
            // DarkThemeRadioButton
            // 
            this.DarkThemeRadioButton.AutoSize = true;
            this.DarkThemeRadioButton.Checked = true;
            this.DarkThemeRadioButton.FlatAppearance.BorderSize = 0;
            this.DarkThemeRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DarkThemeRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DarkThemeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkThemeRadioButton.Location = new System.Drawing.Point(10, 10);
            this.DarkThemeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.DarkThemeRadioButton.Name = "DarkThemeRadioButton";
            this.DarkThemeRadioButton.Size = new System.Drawing.Size(83, 17);
            this.DarkThemeRadioButton.TabIndex = 3;
            this.DarkThemeRadioButton.TabStop = true;
            this.DarkThemeRadioButton.Text = "Dark Theme";
            this.DarkThemeRadioButton.UseVisualStyleBackColor = true;
            this.DarkThemeRadioButton.CheckedChanged += new System.EventHandler(this.DarkThemeRadioButton_CheckedChanged);
            // 
            // LightThemeRadioButton
            // 
            this.LightThemeRadioButton.AutoSize = true;
            this.LightThemeRadioButton.FlatAppearance.BorderSize = 0;
            this.LightThemeRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LightThemeRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LightThemeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightThemeRadioButton.Location = new System.Drawing.Point(10, 38);
            this.LightThemeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.LightThemeRadioButton.Name = "LightThemeRadioButton";
            this.LightThemeRadioButton.Size = new System.Drawing.Size(83, 17);
            this.LightThemeRadioButton.TabIndex = 4;
            this.LightThemeRadioButton.Text = "Light Theme";
            this.LightThemeRadioButton.UseVisualStyleBackColor = true;
            this.LightThemeRadioButton.CheckedChanged += new System.EventHandler(this.LightThemeRadioButton_CheckedChanged);
            // 
            // PositionTrackbarPanel
            // 
            this.PositionTrackbarPanel.Controls.Add(this.DividerLabel);
            this.PositionTrackbarPanel.Controls.Add(this.DurationLabel);
            this.PositionTrackbarPanel.Controls.Add(this.PositionLabel);
            this.PositionTrackbarPanel.Controls.Add(this.PositionTrackbar);
            this.PositionTrackbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PositionTrackbarPanel.Location = new System.Drawing.Point(0, 219);
            this.PositionTrackbarPanel.Name = "PositionTrackbarPanel";
            this.PositionTrackbarPanel.Size = new System.Drawing.Size(634, 42);
            this.PositionTrackbarPanel.TabIndex = 8;
            // 
            // DividerLabel
            // 
            this.DividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DividerLabel.AutoSize = true;
            this.DividerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DividerLabel.Location = new System.Drawing.Point(563, 29);
            this.DividerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(12, 13);
            this.DividerLabel.TabIndex = 10;
            this.DividerLabel.Text = "/";
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DurationLabel.Location = new System.Drawing.Point(572, 29);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(49, 13);
            this.DurationLabel.TabIndex = 9;
            this.DurationLabel.Text = "00:00:00";
            // 
            // PositionLabel
            // 
            this.PositionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionLabel.Location = new System.Drawing.Point(517, 29);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(49, 13);
            this.PositionLabel.TabIndex = 8;
            this.PositionLabel.Text = "00:00:00";
            // 
            // DurationTimer
            // 
            this.DurationTimer.Interval = 50;
            this.DurationTimer.Tick += new System.EventHandler(this.DurationTimerEventHandler);
            // 
            // PositionTrackbar
            // 
            this.PositionTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionTrackbar.LargeChange = 0.04999999888241291D;
            this.PositionTrackbar.Location = new System.Drawing.Point(0, 0);
            this.PositionTrackbar.Maximum = 0D;
            this.PositionTrackbar.Minimum = 0D;
            this.PositionTrackbar.Name = "PositionTrackbar";
            this.PositionTrackbar.Precision = 0.0099999997764825821D;
            this.PositionTrackbar.Size = new System.Drawing.Size(634, 45);
            this.PositionTrackbar.SmallChange = 0.0099999997764825821D;
            this.PositionTrackbar.TabIndex = 7;
            this.PositionTrackbar.Value = 0D;
            this.PositionTrackbar.Scroll += new System.EventHandler(this.PositionTrackbar_Scroll);
            this.PositionTrackbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PositionTrackbar_MouseDown);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopBtn.BackgroundImage")));
            this.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.ForeColor = System.Drawing.Color.Transparent;
            this.StopBtn.Location = new System.Drawing.Point(158, 4);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(42, 42);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // LoopBtn
            // 
            this.LoopBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoopBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoopBtn.BackgroundImage")));
            this.LoopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LoopBtn.FlatAppearance.BorderSize = 0;
            this.LoopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoopBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LoopBtn.Location = new System.Drawing.Point(344, 11);
            this.LoopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LoopBtn.Name = "LoopBtn";
            this.LoopBtn.Size = new System.Drawing.Size(38, 28);
            this.LoopBtn.TabIndex = 11;
            this.LoopBtn.UseVisualStyleBackColor = false;
            this.LoopBtn.Click += new System.EventHandler(this.LoopBtn_Click);
            this.LoopBtn.MouseEnter += new System.EventHandler(this.LoopBtn_MouseEnter);
            this.LoopBtn.MouseLeave += new System.EventHandler(this.LoopBtn_MouseLeave);
            // 
            // MuteUnmuteBtn
            // 
            this.MuteUnmuteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MuteUnmuteBtn.BackColor = System.Drawing.Color.Transparent;
            this.MuteUnmuteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteUnmuteBtn.BackgroundImage")));
            this.MuteUnmuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteUnmuteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MuteUnmuteBtn.FlatAppearance.BorderSize = 0;
            this.MuteUnmuteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MuteUnmuteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MuteUnmuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteUnmuteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MuteUnmuteBtn.Location = new System.Drawing.Point(487, 11);
            this.MuteUnmuteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MuteUnmuteBtn.Name = "MuteUnmuteBtn";
            this.MuteUnmuteBtn.Size = new System.Drawing.Size(28, 28);
            this.MuteUnmuteBtn.TabIndex = 9;
            this.MuteUnmuteBtn.UseVisualStyleBackColor = false;
            this.MuteUnmuteBtn.Click += new System.EventHandler(this.MuteUnmuteBtn_Click);
            this.MuteUnmuteBtn.MouseEnter += new System.EventHandler(this.MuteUnmuteBtn_MouseEnter);
            this.MuteUnmuteBtn.MouseLeave += new System.EventHandler(this.MuteUnmuteBtn_MouseLeave);
            // 
            // PlaylistToggleBtn
            // 
            this.PlaylistToggleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlaylistToggleBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlaylistToggleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaylistToggleBtn.BackgroundImage")));
            this.PlaylistToggleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaylistToggleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PlaylistToggleBtn.FlatAppearance.BorderSize = 0;
            this.PlaylistToggleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlaylistToggleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlaylistToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistToggleBtn.ForeColor = System.Drawing.Color.Transparent;
            this.PlaylistToggleBtn.Location = new System.Drawing.Point(390, 11);
            this.PlaylistToggleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlaylistToggleBtn.Name = "PlaylistToggleBtn";
            this.PlaylistToggleBtn.Size = new System.Drawing.Size(38, 28);
            this.PlaylistToggleBtn.TabIndex = 12;
            this.PlaylistToggleBtn.UseVisualStyleBackColor = false;
            this.PlaylistToggleBtn.Click += new System.EventHandler(this.PlaylistToggleBtn_Click);
            this.PlaylistToggleBtn.MouseEnter += new System.EventHandler(this.PlaylistToggleBtn_MouseEnter);
            this.PlaylistToggleBtn.MouseLeave += new System.EventHandler(this.PlaylistToggleBtn_MouseLeave);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextBtn.BackgroundImage")));
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.ForeColor = System.Drawing.Color.Transparent;
            this.NextBtn.Location = new System.Drawing.Point(252, 6);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(38, 38);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayPauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayPauseBtn.BackgroundImage")));
            this.PlayPauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PlayPauseBtn.FlatAppearance.BorderSize = 0;
            this.PlayPauseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPauseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.Location = new System.Drawing.Point(12, 0);
            this.PlayPauseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(50, 50);
            this.PlayPauseBtn.TabIndex = 0;
            this.PlayPauseBtn.UseVisualStyleBackColor = false;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.BackgroundImage")));
            this.PreviousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PreviousBtn.FlatAppearance.BorderSize = 0;
            this.PreviousBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.ForeColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.Location = new System.Drawing.Point(68, 6);
            this.PreviousBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(38, 38);
            this.PreviousBtn.TabIndex = 5;
            this.PreviousBtn.UseVisualStyleBackColor = false;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // MediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.PositionTrackbarPanel);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.ControlTableLayoutPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "MediaPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Media Player";
            this.LocationChanged += new System.EventHandler(this.MediaPlayerForm_SizeAndLocationChanged);
            this.SizeChanged += new System.EventHandler(this.MediaPlayerForm_SizeAndLocationChanged);
            this.ControlTableLayoutPanel.ResumeLayout(false);
            this.ControlTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.PositionTrackbarPanel.ResumeLayout(false);
            this.PositionTrackbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton PlayPauseBtn;
        private RoundButton StopBtn;
        private System.Windows.Forms.TableLayoutPanel ControlTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private DoubleTrackbar PositionTrackbar;
        private System.Windows.Forms.Panel PositionTrackbarPanel;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private RoundButton PreviousBtn;
        private RoundButton NextBtn;
        private System.Windows.Forms.Button BackwardBtn;
        private System.Windows.Forms.Button ForwardBtn;
        private RoundButton MuteUnmuteBtn;
        private System.Windows.Forms.Label DividerLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.RadioButton DarkThemeRadioButton;
        private System.Windows.Forms.RadioButton LightThemeRadioButton;
        private System.Windows.Forms.Timer DurationTimer;
        private RoundButton LoopBtn;
        private RoundButton PlaylistToggleBtn;
    }
}

