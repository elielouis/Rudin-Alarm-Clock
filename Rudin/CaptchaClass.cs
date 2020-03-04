using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaptchaPluginsFramework;

namespace Rudin
{
    public struct CaptchaTask
    {
        public CaptchaPluginBase captcha;
        public int difficulty;

        public CaptchaTask(CaptchaPluginBase c, int d)
        {
            captcha = c;
            difficulty = d;
        }
    }

}
