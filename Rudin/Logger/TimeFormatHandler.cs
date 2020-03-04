using System;

namespace Rudin.Logger
{
    public class TimeFormatHandler : ILoggerFormatStrategy
    {
        private ILoggerFormatStrategy _format_handler;

        public TimeFormatHandler(ILoggerFormatStrategy format_handler)
        {
            _format_handler = format_handler;
        }

        string ILoggerFormatStrategy.Process(string data)
        {
            return string.Format("{0} - ", DateTime.Now.ToString("HH:mm:ss")) + _format_handler.Process(data);
        }

    }
}
