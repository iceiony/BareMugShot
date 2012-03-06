using BareMugShot.Core.Eventing;
using BareMugShot.Core.Eventing.Events;
using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.LogProcessing
{
    public class SqlLogDetailsProcessor : ILogDetailsProcessor
    {
        public void ProcessLogDetails(LogDetails details)
        {
            EventDispatcher.Raise(new SqlExecuted());
        }
    }
}