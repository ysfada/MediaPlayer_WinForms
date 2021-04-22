using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsAppMediaPlayer
{
    public partial class PlaylistForm : Form
    {
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        private readonly MediaPlayer MP;

        /// <summary>
        /// Icons
        /// </summary>
        private readonly Bitmap SelectFileBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/plus.png"));
        private readonly Bitmap SelectFileBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/plus.png"));
        private readonly Bitmap RemoveFileBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/minus.png"));
        private readonly Bitmap RemoveFileBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/minus.png"));
        private readonly Bitmap ClearPlaylistBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/trashcan.png"));
        private readonly Bitmap ClearPlaylistBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/trashcan.png"));

        public PlaylistForm(ref MediaPlayer mediaPlayer)
        {
            InitializeComponent();

            // Add tooltip to buttons
            ToolTip RemoveFileBtnToolTip = new ToolTip();
            RemoveFileBtnToolTip.SetToolTip(RemoveFileBtn, "Remove selected item from playlist.");
            ToolTip SelectFileBtnToolTip = new ToolTip();
            SelectFileBtnToolTip.SetToolTip(SelectFileBtn, "Add new items to playlist.");
            ToolTip ClearPlaylistBtnToolTip = new ToolTip();
            ClearPlaylistBtnToolTip.SetToolTip(ClearPlaylistBtn, "Clear playlist.");

            SetStyle(ControlStyles.ResizeRedraw, true);

            MP = mediaPlayer;

            AddItems(MP.PlaylistItems());
        }

        /// <summary>
        /// For resizeable playlist
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Set playlist theme
        /// </summary>
        /// <param name="dark"></param>
        /// <param name="backColor"></param>
        /// <param name="foreColor"></param>
        public void Theme(bool dark, Color backColor, Color foreColor)
        {
            BackColor = backColor;
            ForeColor = foreColor;

            PlaylistListBox.BackColor = backColor;
            PlaylistListBox.ForeColor = foreColor;

            SelectFileBtn.BackgroundImage = dark ? SelectFileBtnBackgroundImageDark : SelectFileBtnBackgroundImageLight;
            RemoveFileBtn.BackgroundImage = dark ? RemoveFileBtnBackgroundImageDark : RemoveFileBtnBackgroundImageLight;
            ClearPlaylistBtn.BackgroundImage = dark ? ClearPlaylistBtnBackgroundImageDark : ClearPlaylistBtnBackgroundImageLight;
        }

        /// <summary>
        /// Focus on currently playing media on playlist
        /// </summary>
        public void FocusCurrentItem()
        {
            var index = MP.GetCurrentMediaPlaylistIndex();
            if (index != null)
            {
                PlaylistListBox.Focus();
                PlaylistListBox.SelectedIndex = (int)index;
            }
        }

        /// <summary>
        /// Resize the playlist height base on item count and height
        /// </summary>
        private void ResizePlaylist()
        {
            PlaylistListBox.Height = PlaylistListBox.Items.Count * PlaylistListBox.ItemHeight;
        }

        /// <summary>
        /// Add a new media to playlist
        /// </summary>
        /// <param name="item"></param>
        private void AddItem(IWMPMedia item)
        {
            // Put duration of the song in front of its name
            //TimeSpan time = TimeSpan.FromSeconds(item.duration);
            //PlaylistListBox.Items.Add($"{time:hh\\:mm\\:ss} {item.name}");
            PlaylistListBox.Items.Add(item.name);
            // Resize the playlist height everytime an item added or removed from the playlist
            ResizePlaylist();
        }

        /// <summary>
        /// Add a list of new media to playlist
        /// </summary>
        /// <param name="items"></param>
        private void AddItems(IWMPMedia[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                AddItem(items[i]);
            }
        }

        /// <summary>
        /// Remove every item from playlist
        /// </summary>
        private void ClearPlaylist()
        {
            PlaylistListBox.Items.Clear();
            MP.ClearPlaylist();
            // Resize the playlist height everytime an item added or removed from the playlist
            ResizePlaylist();
        }

        /// <summary>
        /// Plays the selected index from playlist
        /// </summary>
        private void PlayBySelectedIndex()
        {
            MP.PlayByPlaylistIndex(PlaylistListBox.SelectedIndex);
        }

        /// <summary>
        /// Event handler for playing selected playlist media actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistListBox_DoubleClick(object sender, EventArgs e)
        {
            //MP.PlayByPlaylistIndex(PlaylistListBox.SelectedIndex);
            PlayBySelectedIndex();
        }

        /// <summary>
        /// Event handler for adding new media files to playlist actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            if (SelectFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in SelectFileDialog.FileNames)
                {
                    // Add to WMP playlist
                    IWMPMedia media = MP.AddToPlaylist(file);
                    // Add to form playlist
                    AddItem(media);
                }
            }
        }

        /// <summary>
        /// Event handler for removing media from playlist actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFileBtn_Click(object sender, EventArgs e)
        {
            bool isPlaying = MP.IsPlaying();
            int selectedIndex = PlaylistListBox.SelectedIndex;

            // Remove the item only if an item is selected from playlist. If index is less than 0 than non is selected
            if (selectedIndex < 0) return;

            bool isSame = MP.IsIdenticalToCurrentMedia(selectedIndex);
            int playlistCount = MP.PlaylistCount();
            int playlistListBoxCount = PlaylistListBox.Items.Count;
            // try to remove the item if there is atleast 1 item in both playlist and
            // total item in both playlist is equal
            bool canRemove = playlistCount > 0 && playlistListBoxCount > 0 && playlistCount == playlistListBoxCount;
            if (canRemove)
            {
                MP.RemoveFromPlaylistByIndex(selectedIndex);
                PlaylistListBox.Items.RemoveAt(selectedIndex);
                // Resize the playlist height everytime an item added or removed from the playlist
                ResizePlaylist();
                // Play by selected index
                if (isPlaying && isSame)
                {
                    PlayBySelectedIndex();
                }
                else
                {
                    // Focus current item on playlist to be able to see which item is currently gonna be played
                    FocusCurrentItem();
                }
            } else // if some reason playlist gets out of sync than clear it. You need a better way to handle this.
            {
                ClearPlaylist();
            }
        }

        /// <summary>
        /// Clear playlist actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPlaylistBtn_Click(object sender, EventArgs e)
        {
            ClearPlaylist();
        }

        /// <summary>
        /// Drag drop media files to playlist to add to playlist action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Drag drop media files to playlist to add to playlist action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                // Only add items to playlist if file extention is mp3 or wav
                if (Path.GetExtension(files[i]).Equals(".mp3") || Path.GetExtension(files[i]).Equals(".wav"))
                {
                    // Add to media player playlist
                    IWMPMedia media = MP.AddToPlaylist(files[i]);
                    // Add to playlist form
                    AddItem(media);
                }
            }
        }

        private void SelectFileBtn_MouseEnter(object sender, EventArgs e)
        {
            SelectFileBtn.Size = new Size(35, 35);
        }

        private void SelectFileBtn_MouseLeave(object sender, EventArgs e)
        {
            SelectFileBtn.Size = new Size(38, 38);
        }

        private void RemoveFileBtn_MouseEnter(object sender, EventArgs e)
        {
            RemoveFileBtn.Size = new Size(35, 35);
        }

        private void RemoveFileBtn_MouseLeave(object sender, EventArgs e)
        {
            RemoveFileBtn.Size = new Size(38, 38);
        }

        private void ClearPlaylistBtn_MouseEnter(object sender, EventArgs e)
        {
            ClearPlaylistBtn.Size = new Size(35, 35);
        }

        private void ClearPlaylistBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearPlaylistBtn.Size = new Size(38, 38);
        }
    }
}
