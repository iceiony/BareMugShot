using BareMugShot.Core.Eventing;
using BareMugShot.Core.Eventing.Events;
using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.LogProcessing
{
    public class SessionOpenLogDetailsProcessor : ILogDetailsProcessor
    {
        public void ProcessLogDetails(LogDetails details)
        {
            EventDispatcher.Raise(new SessionOpened());
        }
    }
}