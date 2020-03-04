namespace Rudin.MusicMethods
{
    class SystemMediaPlayer : IMusicPlayer
    {
        private System.Media.SoundPlayer _player;

        public SystemMediaPlayer()
        {
            _player = new System.Media.SoundPlayer();
        }

        public void Play(string song_location)
        {
            this.Stop();
            _player.SoundLocation = song_location;
            _player.Load();
            _player.Play();
        }

        public void Stop()
        {
            _player.Stop();
        }

        ~SystemMediaPlayer()
        {
            this.Stop();
        }
    }
}
