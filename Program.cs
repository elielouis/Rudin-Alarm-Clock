using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CaptchaPluginsFramework;
using MusicMethods;

namespace Rudin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load plugins
            Dictionary<string, CaptchaPluginBase> plugins = Captcha.CaptchaPluginsUtilities.LoadPlugins();
            Music music
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(plugins));
        }
    }
}
