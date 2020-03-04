using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.Logger
{
    public interface ILogWriter
    {
        void WriteMessage(string message);
    }
}
