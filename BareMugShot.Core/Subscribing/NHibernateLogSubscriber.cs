using BareMugShot.Core.Eventing;
using BareMugShot.Core.LogProcessing;
using NHibernate.ZMQLogPublisher;

namespace BareMugShot.Core.Subscribing
{
    public class NHibernateLogSubscriber : INHibernateLogSubscriber
    {
        private readonly IMessageReceiver _messageReceiver;
        private readonly ILogDetailsProcessorProvider _processorProvider;

        protected NHibernateLogSubscriber(IMessageReceiver messageReceiver, ILogDetailsProcessorProvider processorProvider)
        {
            _messageReceiver = messageReceiver;
            _processorProvider = processorProvider;
        }

        public void Start()
        {
            _messageReceiver.StartListening(ProcessLogDetails);
        }

        public void ProcessLogDetails(LogDetails logDetails)
        {
            if (!_processorProvider.IsLoggerKeySupported(logDetails.LoggerKey))
                return;

            _processorProvider.Get(logDetails.LoggerKey).ProcessLogDetails(logDetails);
            
        }
    }
}