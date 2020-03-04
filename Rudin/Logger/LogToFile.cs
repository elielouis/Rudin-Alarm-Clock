using System;
using System.IO;

namespace Rudin.Logger
{
    public class LogToFile :ILogWriter
    {
        private string _file_name;

        public string FileName {
            set
            {
                if (value.IndexOfAny(Path.GetInvalidPathChars()) == -1)
                {
                    _file_name = value;
                }
            }
            get
            {
                return _file_name;
            }
        }

        public LogToFile(string file_name)
        {
            FileName = file_name;
        }

        void ILogWriter.WriteMessage(string message)
        {
            if (FileName != null)
            {
                using (StreamWriter sw = File.AppendText(FileName))
                {
                    sw.WriteLine(message);
                }
            }
        }
    }
}
