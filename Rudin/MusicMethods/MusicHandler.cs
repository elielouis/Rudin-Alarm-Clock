using System;


//TODO: Go for NAudio library!!!

namespace Rudin.MusicMethods
{
    public sealed class MusicHandler
    {
        MusicHandler()
        {
        }

        private static bool _is_playing = false;
        private static readonly object _padlock = new object();
        private static IMusicPlayer _music_player = new DefaultMusicPlayer();

        public static IMusicPlayer MusicPlayer
        {
            get
            {
                return _music_player;
            }
            set
            {
                _music_player = value;
            }
        }

        private static MusicHandler _instance = null;
        public static MusicHandler Instance
        {
            get
            {
                lock(_padlock)
                {
                    if(_instance == null)
                    {
                        _instance = new MusicHandler();
                    }
                    return _instance;
                }
            }
        }

        public void PlaySong(string song_location)
        {
            try
            {
                _music_player.Play(song_location);
                _is_playing = true;
            }
            catch (Exception ex)
            {
                Logger.Logger logger = Logger.Logger.Instance;
                logger.LogMessage(ex.Message);
                // Add a logger here.
            }
        }

        public void StopSong()
        {
            if (_is_playing)
            {
                _music_player.Stop();
                _is_playing = false;
            }
        }
        ~MusicHandler()
        {
            _music_player.Stop();
        }
    }
}
