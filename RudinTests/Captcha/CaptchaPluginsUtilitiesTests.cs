using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rudin.Captcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.Captcha.Tests
{
    [TestClass()]
    public class CaptchaPluginsUtilitiesTests
    {
        [TestMethod()]
        public void AnalyzeAssemblyTest()
        {
            CaptchaPluginsUtilities.AnalyzeAssembly("MockCaptchaPlugin.dll");
        }

        [TestMethod()]
        public void ListAllPluginsTest()
        {
            CaptchaPluginsUtilities.ListAllPlugins();
        }
    }
}