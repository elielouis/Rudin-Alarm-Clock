using System;

namespace Rudin.Logger
{
    public class DateFormatHandler : ILoggerFormatStrategy
    {
        private ILoggerFormatStrategy _format_handler;

        public DateFormatHandler(ILoggerFormatStrategy format_handler)
        {
            _format_handler = format_handler;
        }

        string ILoggerFormatStrategy.Process(string data)
        {
            return String.Format("[{0}] - ", DateTime.Today.ToString("dd-MM-yyyy")) + _format_handler.Process(data);
        }
    }
}
