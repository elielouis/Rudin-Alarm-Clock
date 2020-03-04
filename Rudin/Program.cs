using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CaptchaPluginsFramework;
using Rudin.MusicMethods;
using Rudin.Logger;

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
            // Load plugins and initialize
            Dictionary<string, CaptchaPluginBase> plugins = Captcha.CaptchaPluginsUtilities.LoadPlugins();
            MusicHandler.MusicPlayer = new SystemMediaPlayer();

            Logger.Logger logger = Logger.Logger.Instance;
            ILogWriter writer = new LogToFile("errors.log.txt");
            ILoggerFormatStrategy formatHandler = new UsernameFormatHandler(new DateFormatHandler(new TimeFormatHandler(new BasicFormatHandler())));
            logger.SelectFormatHandler(formatHandler);
            logger.SelectWriter(writer);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(plugins));
        }
    }
}
