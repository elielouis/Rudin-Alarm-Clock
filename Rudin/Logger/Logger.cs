namespace Rudin.Logger
{
    public class Logger
    {
        private Logger()
        {
        }

        private static readonly object _padlock = new object();
        private static readonly object _writingPadlock = new object();
        private static Logger _instance = null;
        private static ILogWriter _writer = null;
        private static ILoggerFormatStrategy _formatHandler = new BasicFormatHandler();

        public static Logger Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }
        

        public void SelectFormatHandler(ILoggerFormatStrategy formatHandler)
        {
            _formatHandler = formatHandler;
        }

        public void SelectWriter(ILogWriter writer)
        {
            _writer = writer;
        }

        public void LogMessage(string message)
        {
            if (_writer != null)
            {
                lock (_writingPadlock)
                {
                    _writer.WriteMessage(_formatHandler.Process(message));
                }
            }
        }
    }
}
