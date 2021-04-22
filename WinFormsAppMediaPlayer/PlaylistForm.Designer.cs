namespace WinFormsAppMediaPlayer
{
    partial class PlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            this.PlaylistListBox = new System.Windows.Forms.ListBox();
            this.PlaylistTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveFileBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.SelectFileBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.ClearPlaylistBtn = new WinFormsAppMediaPlayer.RoundButton();
            this.PlaylistTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaylistListBox
            // 
            this.PlaylistListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PlaylistListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaylistListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.PlaylistListBox.FormattingEnabled = true;
            this.PlaylistListBox.Location = new System.Drawing.Point(10, 10);
            this.PlaylistListBox.Margin = new System.Windows.Forms.Padding(0);
            this.PlaylistListBox.Name = "PlaylistListBox";
            this.PlaylistListBox.Size = new System.Drawing.Size(330, 13);
            this.PlaylistListBox.TabIndex = 0;
            this.PlaylistListBox.DoubleClick += new System.EventHandler(this.PlaylistListBox_DoubleClick);
            // 
            // PlaylistTableLayoutPanel
            // 
            this.PlaylistTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistTableLayoutPanel.ColumnCount = 3;
            this.PlaylistTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PlaylistTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlaylistTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PlaylistTableLayoutPanel.Controls.Add(this.PlaylistListBox, 1, 1);
            this.PlaylistTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PlaylistTableLayoutPanel.Name = "PlaylistTableLayoutPanel";
            this.PlaylistTableLayoutPanel.RowCount = 3;
            this.PlaylistTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PlaylistTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlaylistTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PlaylistTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PlaylistTableLayoutPanel.Size = new System.Drawing.Size(350, 436);
            this.PlaylistTableLayoutPanel.TabIndex = 1;
            // 
            // SelectFileDialog
            // 
            this.SelectFileDialog.Filter = "Audio Files|*.mp3;*.wav";
            this.SelectFileDialog.Multiselect = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RemoveFileBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectFileBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearPlaylistBtn, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 454);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 48);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // RemoveFileBtn
            // 
            this.RemoveFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveFileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveFileBtn.BackgroundImage")));
            this.RemoveFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RemoveFileBtn.FlatAppearance.BorderSize = 0;
            this.RemoveFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveFileBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RemoveFileBtn.Location = new System.Drawing.Point(154, 3);
            this.RemoveFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveFileBtn.Name = "RemoveFileBtn";
            this.RemoveFileBtn.Size = new System.Drawing.Size(42, 42);
            this.RemoveFileBtn.TabIndex = 5;
            this.RemoveFileBtn.UseVisualStyleBackColor = false;
            this.RemoveFileBtn.Click += new System.EventHandler(this.RemoveFileBtn_Click);
            this.RemoveFileBtn.MouseEnter += new System.EventHandler(this.RemoveFileBtn_MouseEnter);
            this.RemoveFileBtn.MouseLeave += new System.EventHandler(this.RemoveFileBtn_MouseLeave);
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectFileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectFileBtn.BackgroundImage")));
            this.SelectFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SelectFileBtn.FlatAppearance.BorderSize = 0;
            this.SelectFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SelectFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SelectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFileBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SelectFileBtn.Location = new System.Drawing.Point(104, 3);
            this.SelectFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(42, 42);
            this.SelectFileBtn.TabIndex = 4;
            this.SelectFileBtn.UseVisualStyleBackColor = false;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            this.SelectFileBtn.MouseEnter += new System.EventHandler(this.SelectFileBtn_MouseEnter);
            this.SelectFileBtn.MouseLeave += new System.EventHandler(this.SelectFileBtn_MouseLeave);
            // 
            // ClearPlaylistBtn
            // 
            this.ClearPlaylistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearPlaylistBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearPlaylistBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearPlaylistBtn.BackgroundImage")));
            this.ClearPlaylistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearPlaylistBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClearPlaylistBtn.FlatAppearance.BorderSize = 0;
            this.ClearPlaylistBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearPlaylistBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearPlaylistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearPlaylistBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearPlaylistBtn.Location = new System.Drawing.Point(204, 3);
            this.ClearPlaylistBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ClearPlaylistBtn.Name = "ClearPlaylistBtn";
            this.ClearPlaylistBtn.Size = new System.Drawing.Size(42, 42);
            this.ClearPlaylistBtn.TabIndex = 6;
            this.ClearPlaylistBtn.UseVisualStyleBackColor = false;
            this.ClearPlaylistBtn.Click += new System.EventHandler(this.ClearPlaylistBtn_Click);
            this.ClearPlaylistBtn.MouseEnter += new System.EventHandler(this.ClearPlaylistBtn_MouseEnter);
            this.ClearPlaylistBtn.MouseLeave += new System.EventHandler(this.ClearPlaylistBtn_MouseLeave);
            // 
            // PlaylistForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(350, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PlaylistTableLayoutPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "PlaylistForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Playlist";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlaylistForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlaylistForm_DragEnter);
            this.PlaylistTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlaylistListBox;
        private System.Windows.Forms.TableLayoutPanel PlaylistTableLayoutPanel;
        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private RoundButton SelectFileBtn;
        private RoundButton RemoveFileBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundButton ClearPlaylistBtn;
    }
}