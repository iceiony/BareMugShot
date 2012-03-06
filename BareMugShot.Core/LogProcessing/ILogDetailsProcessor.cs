using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.LogProcessing
{
    public interface ILogDetailsProcessor
    {
        void ProcessLogDetails(LogDetails details);
    }
}