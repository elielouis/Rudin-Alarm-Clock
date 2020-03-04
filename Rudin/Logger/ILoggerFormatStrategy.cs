namespace Rudin.Logger
{
    public interface ILoggerFormatStrategy
    {
        string Process(string data);
    }
}
