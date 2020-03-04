using System;

namespace Rudin.MusicMethods
{
    public class DefaultMusicPlayer : IMusicPlayer
    {
        public Boolean Playing { get; private set; }

        public DefaultMusicPlayer()
        {
            Playing = false;
        }

        void IMusicPlayer.Play(string song_location)
        {
            Playing = true;
        }

        void IMusicPlayer.Stop()
        {
            Playing = false;
        }
    }
}
