namespace Rudin.Logger
{
    //TODO: Add decorators for further processing the data?
    public class BasicFormatHandler : ILoggerFormatStrategy
    {
        public BasicFormatHandler()
        { }
        string ILoggerFormatStrategy.Process(string data)
        {
            return data;
        }
    }
}
