using System;
using BareMugShot.Core.Subscribing;
using Machine.Fakes;
using Machine.Specifications;
using NHibernate.ZMQLogPublisher;

namespace BearMugShot.Core.Tests.Subscribing
{
    public class When_the_subscriber_is_started : WithSubject<NHibernateLogSubscriber>
    {
        private Establish context = () => { };

        private Because of = () => Subject.Start();

        private It should_start_the_receiver =
            () => The<IMessageReceiver>().WasToldTo(q => q.StartListening(Param.IsAny<Action<LogDetails>>()));
    }
}