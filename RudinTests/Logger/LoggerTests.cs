using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rudin.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.Logger.Tests
{
    [TestClass()]
    public class LoggerTests
    {
        [TestMethod()]
        public void LogToFileTest()
        {
            Logger logger = Logger.Instance;
            ILogWriter writer = new LogToFile("test.log.txt");
            ILoggerFormatStrategy formatHandler = new UsernameFormatHandler(new DateFormatHandler(new TimeFormatHandler(new BasicFormatHandler())));
            logger.SelectFormatHandler(formatHandler);
            logger.SelectWriter(writer);
            logger.LogMessage("test");
            // Make sure the message is the correct message by re-reading the file
            // Although creating a dummy logger would be a better idea.
        }
    }
}