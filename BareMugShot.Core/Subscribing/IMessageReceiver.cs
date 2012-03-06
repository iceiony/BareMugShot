using System;
using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.Subscribing
{
    public interface IMessageReceiver
    {
        void StartListening(Action<LogDetails> messageReceived);
    }

    public class QueueMessageReceiver : IMessageReceiver
    {
        public void StartListening(Action<LogDetails> messageReceived)
        {
        }
    }
}