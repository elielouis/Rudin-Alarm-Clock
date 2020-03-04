using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.Logger
{
    public class UsernameFormatHandler : ILoggerFormatStrategy
    {
        private ILoggerFormatStrategy _format_handler;

        public UsernameFormatHandler(ILoggerFormatStrategy format_handler)
        {
            _format_handler = format_handler;
        }

        string ILoggerFormatStrategy.Process(string data)
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name + " : " + _format_handler.Process(data);
        }

    }
}
