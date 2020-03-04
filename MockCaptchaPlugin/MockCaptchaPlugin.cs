using CaptchaPluginsFramework;

namespace MockCaptchaPlugin
{
    public class MockCaptchaPlugin : CaptchaPluginBase
    {
        public MockCaptchaPlugin() : base()
        {}

        public override CaptchaChallenge GetChallenge()
        {
            return new CaptchaChallenge("test?", "test");
        }

        public override string GetName()
        {
            return "MockPlugin";
        }
    }
}
