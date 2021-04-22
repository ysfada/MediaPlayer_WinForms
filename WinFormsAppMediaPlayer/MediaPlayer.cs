using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsAppMediaPlayer
{
    public class MediaPlayer
    {
        /// <summary>
        /// Windows Media Player
        /// </summary>
        private readonly WindowsMediaPlayer WMP;

        /// <summary>
        /// Windows Media Player Playlist
        /// </summary>
        private readonly IWMPPlaylist Playlist;

        /// <summary>
        /// Source folder for initial media files
        /// </summary>
        private readonly string SrcFolder = Utils.GetAbsolutePath(@"../../assets/tracks");

        public MediaPlayer()
        {
            // Create a new instance of WindowsMediaPlayer
            WMP = new WindowsMediaPlayer();
            // Create a new Playlist
            Playlist = WMP.newPlaylist("Playlist", "");
            // Set new playlist as current playlist
            WMP.currentPlaylist = Playlist;
            // Disable autoplay on startup
            WMP.settings.autoStart = false;

            // Load mp3 and wav files from "ScrFolder" directory
            LoadFromFolder(SrcFolder);
        }

        /// <summary>
        /// Set event handler for error event
        /// </summary>
        /// <param name="handler"></param>
        public void SetMediaErrorEventHandler(_WMPOCXEvents_MediaErrorEventHandler handler)
        {
            WMP.MediaError += handler;
        }

        /// <summary>
        /// Set event handler for play state change event
        /// </summary>
        /// <param name="handler"></param>
        public void SetPlayStateChangeEventHandler(_WMPOCXEvents_PlayStateChangeEventHandler handler)
        {
            WMP.PlayStateChange += handler;
        }

        /// <summary>
        /// Clear everything from current playlist
        /// </summary>
        public void ClearPlaylist()
        {
            WMP.currentPlaylist.clear();
        }

        /// <summary>
        /// Remove from playlist by given index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveFromPlaylistByIndex(int index)
        {
            WMP.currentPlaylist.removeItem(WMP.currentPlaylist.Item[index]);
        }

        /// <summary>
        /// Add file to playlist
        /// </summary>
        /// <param name="url"></param>
        public IWMPMedia AddToPlaylist(string url)
        {
            // Create a new media
            IWMPMedia media = WMP.newMedia(url);

            // This calls is needed for later use. Without this calls first item in playlist wont read duration
            //_ = media.name;
            _ = media.duration;

            // Add new media to playlist
            Playlist.appendItem(media);
            return media;
        }

        /// <summary>
        /// Load all media files from given path but only .mp3 and .wav extentions
        /// </summary>
        /// <param name="path"></param>
        private void LoadFromFolder(string path)
        {
            try
            {
                // Load mp3 files
                IEnumerable<string> mp3Files = Directory.EnumerateFiles(path, "*.mp3", SearchOption.AllDirectories);
                // Load wav files
                IEnumerable<string> wavFiles = Directory.EnumerateFiles(path, "*.wav", SearchOption.AllDirectories);
                // Concat mp3 and wav files
                var files = Utils.ConcatEnumerable(mp3Files, wavFiles);

                // Check if there is any files
                if (files.Count() > 0)
                {
                    // Add files to playlist
                    foreach (string file in files)
                    {
                        AddToPlaylist(file);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Check if media player is currently playing a media file
        /// </summary>
        /// <returns></returns>
        public bool IsPlaying()
        {
            return WMP.playState == WMPPlayState.wmppsPlaying;
        }

        /// <summary>
        /// Check if media player is currently paused playing a media file
        /// </summary>
        /// <returns></returns>
        public bool IsPaused()
        {
            return WMP.playState == WMPPlayState.wmppsPaused;
        }

        /// <summary>
        /// Check if current media is present
        /// </summary>
        /// <returns></returns>
        public bool CanPlay()
        {
            return WMP.currentMedia != null;
        }

        /// <summary>
        /// Get current media files name
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return WMP.currentMedia.name;
        }

        /// <summary>
        /// Get current media files duration
        /// </summary>
        /// <returns></returns>
        public double Duration()
        {
            return WMP.currentMedia.duration;
        }

        /// <summary>
        /// Get current media files position
        /// </summary>
        /// <returns></returns>
        public double Position()
        {
            return WMP.controls.currentPosition;
        }

        /// <summary>
        /// Play current media file
        /// </summary>
        public void Play()
        {
            WMP.controls.play();
        }

        /// <summary>
        /// Pause current media file
        /// </summary>
        public void Pause()
        {
            WMP.controls.pause();
        }

        /// <summary>
        /// Stop current media file
        /// </summary>
        public void Stop()
        {
            WMP.controls.stop();
        }

        /// <summary>
        /// Sets valume
        /// </summary>
        /// <param name="volume"></param>
        public void SetVolume(int volume)
        {
            WMP.settings.volume = volume;

            if (IsMute())
            {
                ToggleMute();
            }
        }

        /// <summary>
        /// Check if media is muted
        /// </summary>
        /// <returns></returns>
        public bool IsMute()
        {
            return WMP.settings.mute;
        }

        /// <summary>
        /// Toggle mute and return if muted or not
        /// </summary>
        /// <returns></returns>
        public bool ToggleMute()
        {
            WMP.settings.mute = !WMP.settings.mute;
            return WMP.settings.mute;
        }

        /// <summary>
        /// Play the previous media in playlist
        /// </summary>
        public void Previous()
        {
            WMP.controls.previous();
            // Start playing the media file
            PlayByPlaylistIndex((int)GetCurrentMediaPlaylistIndex());
        }

        /// <summary>
        /// Play the next media in playlist
        /// </summary>
        public void Next()
        {
            WMP.controls.next();
            // Start playing the media file
            PlayByPlaylistIndex((int)GetCurrentMediaPlaylistIndex());
        }

        /// <summary>
        /// Jump backward in seconds
        /// </summary>
        /// <param name="sec"></param>
        public void JumpBackward(int sec)
        {
            WMP.controls.currentPosition -= sec;
        }

        /// <summary>
        /// Jump forward in seconds
        /// </summary>
        /// <param name="sec"></param>
        public void JumpForward(int sec)
        {
            WMP.controls.currentPosition += sec;
        }

        /// <summary>
        /// Jump to specific position
        /// </summary>
        /// <param name="value"></param>
        public void JumpTo(double value)
        {
            WMP.controls.currentPosition = value;
        }

        /// <summary>
        /// Count of playlist items
        /// </summary>
        /// <returns></returns>
        public int PlaylistCount()
        {
            return WMP.currentPlaylist.count;
        }

        /// <summary>
        /// Get all the items from playlist
        /// </summary>
        /// <returns></returns>
        public IWMPMedia[] PlaylistItems()
        {
            int length = PlaylistCount();
            IWMPMedia[] items = new IWMPMedia[length];

            for (int i = 0; i < length; i++)
            {
                items[i] = WMP.currentPlaylist.Item[i];
            }

            return items;
        }

        /// <summary>
        /// Play the media from playlist by given index
        /// </summary>
        /// <param name="index"></param>
        public void PlayByPlaylistIndex(int index)
        {
            // When an item deleted from playlist index becomes -1.
            // If index is -1 then stop/play current media to fix jump bug on playlist
            if (index < 0)
            {
                Stop();
                Play();
            } else
            {
                WMP.controls.playItem(WMP.currentPlaylist.Item[index]);
            }
        }

        /// <summary>
        /// Get the playlist index of the current media
        /// </summary>
        /// <returns></returns>
        public int? GetCurrentMediaPlaylistIndex()
        {
            int? index = null;
            for (int i = 0; i < PlaylistCount(); i++)
            {
                if (WMP.currentMedia.isIdentical[WMP.currentPlaylist.Item[i]])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Checks if currently playing media file is identical with media from playlist by givin index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool IsIdenticalToCurrentMedia(int index)
        {
            bool isSame = false;
            IWMPMedia media = WMP.currentPlaylist.Item[index];
            if (WMP.currentMedia.isIdentical[media])
            {
                isSame = true;
            }
            return isSame;
        }

        /// <summary>
        /// Checks if loop is activated
        /// </summary>
        /// <returns></returns>
        public bool IsLoopActive()
        {
            return WMP.settings.getMode("loop");
        }

        /// <summary>
        /// Activetes looping
        /// </summary>
        public void ActivetaLoop()
        {
            WMP.settings.setMode("loop", true);
        }

        /// <summary>
        /// Deactivetes looping
        /// </summary>
        public void DeactivateLoop()
        {
            WMP.settings.setMode("loop", false);
        }
    }
}
