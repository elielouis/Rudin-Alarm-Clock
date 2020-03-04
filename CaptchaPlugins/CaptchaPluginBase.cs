using System;
using System.Collections.Generic;
using System.Text;

namespace CaptchaPlugins
{
    public abstract class CaptchaPluginBase
    {
        private int _difficulty;

        public CaptchaPluginBase(int difficulty)
        {
            _difficulty = difficulty;
        }

    }
}
