namespace Rudin.MusicMethods
{
    public class MusicPlayerCreator : MusicPlayerCreatorBase
    {
        public MusicPlayerCreator() { }
        public override IMusicPlayer FactoryMethod(string type)
        {
            switch(type)
            {
                case ".mp3":
                    {
                        return new NAudioPlayer();
                    }
                case ".wav":
                    {
                        return new SystemMediaPlayer();
                    }
                default:
                    return new DefaultMusicPlayer();
            }
        }
    }
}
