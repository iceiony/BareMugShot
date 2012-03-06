using System;
using BareMugShot.Core.LogProcessing;
using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.Subscribing.Zmq
{
    public class ZmqLogReceiver : IMessageReceiver
    {
        public void StartListening(Action<LogDetails> messageReceived)
        {
        }
    }
}