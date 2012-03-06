using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.Subscribing
{
    public interface INHibernateLogSubscriber
    {
        void Start();
    }
}