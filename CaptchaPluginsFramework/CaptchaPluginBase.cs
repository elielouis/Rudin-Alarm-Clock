namespace CaptchaPluginsFramework
{
    public abstract class CaptchaPluginBase
    {
        protected int _difficulty;

        public CaptchaPluginBase()
        {
            _difficulty = 1;
        }

        public abstract CaptchaChallenge GetChallenge();

        public void SetDifficulty(int difficulty)
        {
            if (difficulty > 4)
            {
                difficulty = 4;
            }
            _difficulty = difficulty;
        }
        public abstract string GetName();
    }
}
