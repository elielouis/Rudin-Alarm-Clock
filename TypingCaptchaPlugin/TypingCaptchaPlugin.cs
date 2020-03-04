using System;
using System.Linq;
using CaptchaPluginsFramework;

namespace TypingCaptchaPlugin
{
    public class TypingCaptchaPlugin : CaptchaPluginBase
    {
        
        public TypingCaptchaPlugin() : base()
        { }

        public override CaptchaChallenge GetChallenge()
        {
            Random random = new Random();

            int length = 24 * _difficulty - 16;
            string chars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
            string answer = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return new CaptchaChallenge(answer, answer);
        }

        public override string GetName()
        {
            return "Typing";
        }
    }
}
