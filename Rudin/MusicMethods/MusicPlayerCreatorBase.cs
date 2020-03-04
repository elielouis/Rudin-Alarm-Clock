namespace Rudin.MusicMethods
{
    public abstract class MusicPlayerCreatorBase
    {
        public abstract IMusicPlayer FactoryMethod(string type);
    }
}
