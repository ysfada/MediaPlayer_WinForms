using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsAppMediaPlayer
{
    public partial class MediaPlayerForm : Form
    {
        /// <summary>
        /// Theme names
        /// </summary>
        public enum Themes
        {
            DarkTheme,
            LightTheme
        }

        /// <summary>
        /// Current theme
        /// </summary>
        public Themes Theme { get; set; } = Themes.DarkTheme;

        /// <summary>
        /// Colors
        /// </summary>
        private readonly Color BackColorDark = Color.FromArgb(33, 33, 33); // 212121
        private readonly Color BackColorLight = Color.FromArgb(238, 238, 238); // eeeeee
        private readonly Color ForeColorDark = Color.FromArgb(233, 30, 99); // e91e63
        private readonly Color ForeColorLight = Color.FromArgb(136, 14, 79); // 880e4f

        /// <summary>
        /// Icons
        /// </summary>
        private readonly Bitmap PlayBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/play.png"));
        private readonly Bitmap PlayBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/play.png"));
        private readonly Bitmap PauseBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/pause.png"));
        private readonly Bitmap PauseBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/pause.png"));
        private readonly Bitmap StopBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/stop.png"));
        private readonly Bitmap StopBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/stop.png"));
        private readonly Bitmap PreviousBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/previous.png"));
        private readonly Bitmap PreviousBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/previous.png"));
        private readonly Bitmap NextBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/next.png"));
        private readonly Bitmap NextBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/next.png"));
        private readonly Bitmap ForwardBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/forward.png"));
        private readonly Bitmap ForwardBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/forward.png"));
        private readonly Bitmap BackwardBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/backward.png"));
        private readonly Bitmap BackwardBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/backward.png"));
        private readonly Bitmap MuteUnmuteHighBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/volume-high.png"));
        private readonly Bitmap MuteUnmuteHighBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/volume-high.png"));
        private readonly Bitmap MuteUnmuteLowBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/volume-low.png"));
        private readonly Bitmap MuteUnmuteLowBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/volume-low.png"));
        private readonly Bitmap MuteUnmuteMuteBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/volume-mute.png"));
        private readonly Bitmap MuteUnmuteMuteBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/volume-mute.png"));
        private readonly Bitmap PlaylistToggleBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/playlist.png"));
        private readonly Bitmap PlaylistToggleBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/playlist.png"));
        private readonly Bitmap LoopBtnBackgroundImageDark = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/dark/loop.png"));
        private readonly Bitmap LoopBtnBackgroundImageLight = new Bitmap(Utils.GetAbsolutePath(@"../../assets/icons/light/loop.png"));

        /// <summary>
        /// Media Player instance
        /// </summary>
        private readonly MediaPlayer MP;

        /// <summary>
        /// Playlist Form instance
        /// </summary>
        private readonly PlaylistForm PlaylistForm;

        /// <summary>
        /// Jump forward or backward in seconds
        /// </summary>
        private readonly int JumpBackwardForwardSeconds = 5;

        /// <summary>
        /// Is MediaPlayerForm and PlaylistForm is side by side
        /// </summary>
        //private bool IsSideBySide = true;

        public MediaPlayerForm()
        {
            InitializeComponent();

            // Initialize MediaPlayer
            MP = new MediaPlayer();
            // Initialize PlaylistForm
            PlaylistForm = new PlaylistForm(ref MP);

            // Add tooltip to buttons
            ToolTip PlayPauseBtnToolTip = new ToolTip();
            PlayPauseBtnToolTip.SetToolTip(PlayPauseBtn, "Play/Pause");
            ToolTip PreviousBtnToolTip = new ToolTip();
            PreviousBtnToolTip.SetToolTip(PreviousBtn, "Previous");
            ToolTip NextBtnToolTip = new ToolTip();
            NextBtnToolTip.SetToolTip(NextBtn, "Next");
            ToolTip StopBtnToolTip = new ToolTip();
            StopBtnToolTip.SetToolTip(StopBtn, "Stop");
            ToolTip BackwardBtnToolTip = new ToolTip();
            BackwardBtnToolTip.SetToolTip(BackwardBtn, "Jump Backward");
            ToolTip ForwardBtnToolTip = new ToolTip();
            ForwardBtnToolTip.SetToolTip(ForwardBtn, "Jump Forward");
            ToolTip LoopBtnToolTip = new ToolTip();
            LoopBtnToolTip.SetToolTip(LoopBtn, "Toggle Loop");
            ToolTip PlaylistToggleBtnToolTip = new ToolTip();
            PlaylistToggleBtnToolTip.SetToolTip(PlaylistToggleBtn, "Toggle Playlist Window");
            ToolTip MuteUnmuteBtnToolTip = new ToolTip();
            MuteUnmuteBtnToolTip.SetToolTip(MuteUnmuteBtn, "Mute/Unmute");

            // Set Windows Media Player state change event handler
            MP.SetPlayStateChangeEventHandler(new _WMPOCXEvents_PlayStateChangeEventHandler(MediaPlayerStatusChangedEvent));
            // Set Windows Media Player error event handler
            MP.SetMediaErrorEventHandler(MediaPlayerErrorEventHandler);

            FixButtonBorderColor();

            // Display Playlist Form
            PlaylistForm.Show();

            // This event handler used for moving both MediaPlayerForm and PlaylistForm together
            // the PlaylistForm instance will use the same EventHandlers that the MediaPlayerForm instance (Main Form) uses
            PlaylistForm.LocationChanged += MediaPlayerForm_SizeAndLocationChanged;
            PlaylistForm.SizeChanged += MediaPlayerForm_SizeAndLocationChanged;
            // need to adjust the position on Application start
            // note: you can call this with both arguments being 'null
            MediaPlayerForm_SizeAndLocationChanged(null, null);
        }

        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);
        //    BringFormToFront();
        //    IsSideBySide = true;
        //}

        //protected override void OnDeactivate(EventArgs e)
        //{
        //    base.OnDeactivate(e);
        //    IsSideBySide = false;
        //}

        //private void BringFormToFront()
        //{
        //    if (!IsSideBySide)
        //    {
        //        PlaylistForm.Activate();
        //        PlaylistForm.TopMost = true;
        //        PlaylistForm.TopMost = false;
        //        PlaylistForm.Focus();
        //        PlaylistForm.BringToFront();
        //        //PlaylistForm.Hide();
        //        //PlaylistForm.Show();
        //    }
        //}

        /// <summary>
        /// Sets PlaylistForm location
        /// </summary>
        /// <param name="fLeft"></param>
        /// <param name="fTop"></param>
        private void PositionPlaylistForm(int fLeft, int fTop)
        {
            PlaylistForm.Location = new Point(fLeft, fTop);
        }

        /// <summary>
        /// Both the MediaPlayerForm instance LocationChanged, and SizeChanged Events use this EventHandler to position forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaPlayerForm_SizeAndLocationChanged(object sender, EventArgs e)
        {
            PositionPlaylistForm(Right, Top);
        }

        /// <summary>
        /// PositionTrackbarTimer event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationTimerEventHandler(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(MP.Position());
            PositionTrackbar.Minimum = 0;
            PositionTrackbar.Maximum = MP.Duration();

            // Workaround for mouse click jump forward/backward bug
            // If bug occurs than just play the next song
            try
            {
                PositionTrackbar.Value = MP.Position();

                // This line fixes wrong duration bug. This is a quick fix. Needs a better fix. 
                TimeSpan duration = TimeSpan.FromSeconds(MP.Duration());
                DurationLabel.Text = duration.ToString(@"hh\:mm\:ss");
            } catch
            {
                MP.Stop();
                MP.Next();
            }

            PositionLabel.Text = time.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Reset position, duration and trackbar values
        /// </summary>
        private void ResetTrackerValues()
        {
            PositionTrackbar.Minimum = 0;
            PositionTrackbar.Maximum = 0;
            PositionTrackbar.Value = 0;

            PositionLabel.Text = "00:00:00";
            DurationLabel.Text = "00:00:00";
        }

        /// <summary>
        /// Windows Media Player error event handler
        /// </summary>
        /// <param name="pMediaObject"></param>
        private void MediaPlayerErrorEventHandler(object pMediaObject)
        {
            DialogResult confirmResult = MessageBox.Show(
                $"Cannot play {MP.Name()} media file.",
                "Confirm to exit!",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MP.Stop();
            }
        }

        /// <summary>
        /// Windows Media Player status change event handler
        /// </summary>
        /// <param name="NewState"></param>
        private void MediaPlayerStatusChangedEvent(int NewState)
        {
            switch ((WMPPlayState)NewState)
            {
                case WMPPlayState.wmppsPlaying:
                    SetPlayPauseBtnIcon(true);
                    TimeSpan time = TimeSpan.FromSeconds(MP.Duration());
                    DurationLabel.Text = time.ToString(@"hh\:mm\:ss");
                    DurationTimer.Start();
                    // Focus on currently playing media on playlist if looping is not active
                    if (!MP.IsLoopActive())
                    {
                        PlaylistForm.FocusCurrentItem();
                    }
                    break;

                case WMPPlayState.wmppsPaused:
                    SetPlayPauseBtnIcon(false);
                    DurationTimer.Stop();
                    break;

                case WMPPlayState.wmppsStopped:
                    SetPlayPauseBtnIcon(false);
                    DurationTimer.Dispose();
                    ResetTrackerValues();
                    break;

                case WMPPlayState.wmppsMediaEnded:
                    SetPlayPauseBtnIcon(false);
                    DurationTimer.Stop();
                    ResetTrackerValues();
                    // This is a workaround for looping in WMP
                    if (MP.IsLoopActive())
                    {
                        MP.Previous();
                    }
                    break;

                default:
                    if (MP.IsPlaying())
                    {
                        SetPlayPauseBtnIcon(true);
                    } else
                    {
                        SetPlayPauseBtnIcon(false);
                        // This is a workaround for looping in WMP when there is only one item in playlist
                        if (MP.IsLoopActive())
                        {
                            MP.Previous();
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Add your buttons in here to fix ugly borders
        /// </summary>
        private void FixButtonBorderColor()
        {
            PlayPauseBtn.FlatAppearance.BorderColor = BackColor;
            PreviousBtn.FlatAppearance.BorderColor = BackColor;
            BackwardBtn.FlatAppearance.BorderColor = BackColor;
            StopBtn.FlatAppearance.BorderColor = BackColor;
            ForwardBtn.FlatAppearance.BorderColor = BackColor;
            NextBtn.FlatAppearance.BorderColor = BackColor;
            MuteUnmuteBtn.FlatAppearance.BorderColor = BackColor;
            PlaylistToggleBtn.FlatAppearance.BorderColor = BackColor;
            LoopBtn.FlatAppearance.BorderColor = BackColor;
        }

        /// <summary>
        /// Applies the dark theme
        /// </summary>
        private void DarkTheme()
        {
            // Set theme name
            Theme = Themes.DarkTheme;

            // Set dark theme default colors
            BackColor = BackColorDark;
            ForeColor = ForeColorDark;

            FixButtonBorderColor();

            // Set Dark Theme icons
            StopBtn.BackgroundImage = StopBtnBackgroundImageDark;
            PreviousBtn.BackgroundImage = PreviousBtnBackgroundImageDark;
            NextBtn.BackgroundImage = NextBtnBackgroundImageDark;
            BackwardBtn.BackgroundImage = BackwardBtnBackgroundImageDark;
            ForwardBtn.BackgroundImage = ForwardBtnBackgroundImageDark;
            PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageDark;
            LoopBtn.BackgroundImage = LoopBtnBackgroundImageDark;
            // Change background image of PlayPauseBtn according to play state
            SetPlayPauseBtnIcon(MP.IsPlaying());
            // Change background image of MuteUnmuteBtn according to mute state
            SetMuteUnmuteBtnIcon(MP.IsMute());
            // Change background image of LoopBtn according to loop state
            SetLoopBtnIcon(MP.IsLoopActive());
            // Change background image of PlaylistToggleBtn according to playlist state
            PlaylistToggleBtnIcon(PlaylistForm.Visible);

            // Set PlaylistFrom Theme
            PlaylistForm.Theme(true, BackColorDark, ForeColorDark);
        }

        /// <summary>
        /// Applies the light theme
        /// </summary>
        private void LightTheme()
        {
            // Set theme name
            Theme = Themes.LightTheme;

            // Set dark theme default colors
            BackColor = BackColorLight;
            ForeColor = ForeColorLight;

            FixButtonBorderColor();

            // Set Light Theme icons
            StopBtn.BackgroundImage = StopBtnBackgroundImageLight;
            PreviousBtn.BackgroundImage = PreviousBtnBackgroundImageLight;
            NextBtn.BackgroundImage = NextBtnBackgroundImageLight;
            BackwardBtn.BackgroundImage = BackwardBtnBackgroundImageLight;
            ForwardBtn.BackgroundImage = ForwardBtnBackgroundImageLight;
            PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageLight;
            LoopBtn.BackgroundImage = LoopBtnBackgroundImageLight;
            // Change background image of PlayPauseBtn according to play state
            SetPlayPauseBtnIcon(MP.IsPlaying());
            // Change background image of MuteUnmuteBtn according to mute state
            SetMuteUnmuteBtnIcon(MP.IsMute());
            // Change background image of LoopBtn according to loop state
            SetLoopBtnIcon(MP.IsLoopActive());
            // Change background image of PlaylistToggleBtn according to playlist state
            PlaylistToggleBtnIcon(PlaylistForm.Visible);

            // Set PlaylistFrom Theme
            PlaylistForm.Theme(false, BackColorLight, ForeColorLight);
        }

        /// <summary>
        /// Set PlayPauseBtn icon according to theme and play state
        /// </summary>
        private void SetPlayPauseBtnIcon(bool isPlaying)
        {
            if (isPlaying)
            {
                // Change icon from play to pause according to theme
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        PlayPauseBtn.BackgroundImage = PauseBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        PlayPauseBtn.BackgroundImage = PauseBtnBackgroundImageLight;
                        break;

                    default:
                        PlayPauseBtn.BackgroundImage = PauseBtnBackgroundImageDark;
                        break;
                }
            } else
            {
                // Change icon from pause to play according to theme
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        PlayPauseBtn.BackgroundImage = PlayBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        PlayPauseBtn.BackgroundImage = PlayBtnBackgroundImageLight;
                        break;

                    default:
                        PlayPauseBtn.BackgroundImage = PlayBtnBackgroundImageDark;
                        break;
                }
            }
        }

        /// <summary>
        /// Set MuteUnmuteBtn icon according to theme and mute state
        /// </summary>
        /// <param name="isPlaying"></param>
        private void SetMuteUnmuteBtnIcon(bool isMute)
        {
            if (isMute)
            {
                // Change icon from high or low to mute according to theme
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        MuteUnmuteBtn.BackgroundImage = MuteUnmuteMuteBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        MuteUnmuteBtn.BackgroundImage = MuteUnmuteMuteBtnBackgroundImageLight;
                        break;

                    default:
                        MuteUnmuteBtn.BackgroundImage = MuteUnmuteMuteBtnBackgroundImageDark;
                        break;
                }
            }
            else
            {
                // Change icon from mute to low or high according to volume and theme
                bool isVolumeLow = VolumeTrackBar.Value < 50;
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        MuteUnmuteBtn.BackgroundImage = isVolumeLow ? MuteUnmuteLowBtnBackgroundImageDark : MuteUnmuteHighBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        MuteUnmuteBtn.BackgroundImage = isVolumeLow ? MuteUnmuteLowBtnBackgroundImageLight : MuteUnmuteHighBtnBackgroundImageLight;
                        break;

                    default:
                        MuteUnmuteBtn.BackgroundImage = isVolumeLow ? MuteUnmuteLowBtnBackgroundImageDark : MuteUnmuteHighBtnBackgroundImageDark;
                        break;
                }
            }
        }

        /// <summary>
        /// Set LoopBtn icon according to theme and loop state
        /// </summary>
        private void SetLoopBtnIcon(bool loop)
        {
            if (loop)
            {
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageLight;
                        break;

                    case Themes.LightTheme:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageDark;
                        break;

                    default:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageLight;
                        break;
                }
            }
            else
            {
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageLight;
                        break;

                    default:
                        LoopBtn.BackgroundImage = LoopBtnBackgroundImageDark;
                        break;
                }
            }
        }

        /// <summary>
        /// Set PlaylistToggleBtn icon according to theme and loop state
        /// </summary>
        private void PlaylistToggleBtnIcon(bool open)
        {
            if (open)
            {
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageLight;
                        break;

                    case Themes.LightTheme:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageDark;
                        break;

                    default:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageLight;
                        break;
                }
            }
            else
            {
                switch (Theme)
                {
                    case Themes.DarkTheme:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageDark;
                        break;

                    case Themes.LightTheme:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageLight;
                        break;

                    default:
                        PlaylistToggleBtn.BackgroundImage = PlaylistToggleBtnBackgroundImageDark;
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler for dark theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DarkThemeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Run only when not already dark
            if (Theme != Themes.DarkTheme)
            {
                DarkTheme();
            }
        }

        /// <summary>
        /// Event handler for light theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LightThemeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Run only when not already light
            if (Theme != Themes.LightTheme)
            {
                LightTheme();
            }
        }

        /// <summary>
        /// Event handler for media play/pause actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayPauseBtn_Click(object sender, EventArgs e)
        {
            // if media player currently playing then pause
            if (MP.IsPlaying())
            {
                MP.Pause();
                // Set new icon according to theme and play state
                SetPlayPauseBtnIcon(false);
              // if media player currently not playing but can play then play
            } else if (MP.CanPlay())
            {
                MP.Play();
                // Set new icon according to theme and play state
                SetPlayPauseBtnIcon(true);
            }

        }

        /// <summary>
        /// Event handler for media stop action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopBtn_Click(object sender, EventArgs e)
        {
            // if media player currently playing or paused then stop
            if (MP.IsPlaying() || MP.IsPaused())
            {
                MP.Stop();

                // Set new icon according to theme and play state
                SetPlayPauseBtnIcon(false);
            }
        }

        /// <summary>
        /// Event handler for media previous action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (MP.IsPlaying() || MP.IsPaused())
            {
                MP.Previous();
                PlaylistForm.FocusCurrentItem();
            }
        }

        /// <summary>
        /// Event handler for media next action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (MP.IsPlaying() || MP.IsPaused())
            { 
                MP.Next();
                PlaylistForm.FocusCurrentItem();
            }
        }

        /// <summary>
        /// Event handler for media jump backward action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackwardBtn_Click(object sender, EventArgs e)
        {
            if (MP.IsPlaying())
            {
                MP.JumpBackward(JumpBackwardForwardSeconds);
            }
        }

        /// <summary>
        /// Event handler for media jump forward action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            if (MP.IsPlaying())
            {
                MP.JumpForward(JumpBackwardForwardSeconds);
            }
        }

        /// <summary>
        /// Event handler for media position change scroll action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositionTrackbar_Scroll(object sender, EventArgs e)
        {
            if (MP.IsPlaying() || MP.IsPaused())
            {
                MP.JumpTo(PositionTrackbar.Value);
            }
        }

        /// <summary>
        /// Event handler for media position change mouse down action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositionTrackbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (MP.IsPlaying() || MP.IsPaused())
            {
                // Workaround for mouse click jump forward/backward bug
                // If bug occurs than just play the next song
                try
                {
                    PositionTrackbar.Value = e.X / (double)PositionTrackbar.Width * (PositionTrackbar.Maximum - PositionTrackbar.Minimum);
                    MP.JumpTo(PositionTrackbar.Value);
                } catch {
                    MP.Stop();
                    MP.Next();
                }
            }
        }

        /// <summary>
        /// Event handler for media volume change action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Set new the new valume
            MP.SetVolume(VolumeTrackBar.Value);
            // Set new icon according to theme and mute state
            if (VolumeTrackBar.Value == 0)
            {
                SetMuteUnmuteBtnIcon(true);
            }
            else
            {
                SetMuteUnmuteBtnIcon(false);
            }
        }

        /// <summary>
        /// Event handler for media mute/unmute action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MuteUnmuteBtn_Click(object sender, EventArgs e)
        {
            // Toggle the mute state
            bool isMute = MP.ToggleMute();
            // Set new icon according to theme and mute state
            SetMuteUnmuteBtnIcon(isMute);
        }

        /// <summary>
        /// Event handler for playlist toggle action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistToggleBtn_Click(object sender, EventArgs e)
        {
            if (PlaylistForm.Visible)
            {
                PlaylistForm.Hide();
                PlaylistToggleBtnIcon(false);
            } else
            {
                PlaylistForm.Show();
                PlaylistToggleBtnIcon(true);
            }
        }

        /// <summary>
        /// Loop the current media or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoopBtn_Click(object sender, EventArgs e)
        {
            if (MP.IsLoopActive())
            {
                MP.DeactivateLoop();
                SetLoopBtnIcon(false);
            } else
            {
                MP.ActivetaLoop();
                SetLoopBtnIcon(true);
            }
        }

        private void MuteUnmuteBtn_MouseEnter(object sender, EventArgs e)
        {
            MuteUnmuteBtn.Size = new Size(25, 25);
        }

        private void MuteUnmuteBtn_MouseLeave(object sender, EventArgs e)
        {
            MuteUnmuteBtn.Size = new Size(28, 28);
        }

        private void LoopBtn_MouseEnter(object sender, EventArgs e)
        {
            LoopBtn.Size = new Size(35, 25);
        }

        private void LoopBtn_MouseLeave(object sender, EventArgs e)
        {
            LoopBtn.Size = new Size(38, 28);
        }

        private void PlaylistToggleBtn_MouseEnter(object sender, EventArgs e)
        {
            PlaylistToggleBtn.Size = new Size(35, 25);
        }

        private void PlaylistToggleBtn_MouseLeave(object sender, EventArgs e)
        {
            PlaylistToggleBtn.Size = new Size(38, 28);
        }
    }
}
