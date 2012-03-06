namespace BareMugShot.Core.LogProcessing
{
    public interface ILogDetailsProcessorProvider
    {
        ILogDetailsProcessor Get(string loggerKey);
        bool IsLoggerKeySupported(string loggerKey);
    }
}