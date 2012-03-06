using System;
using BareMugShot.Core.Eventing;
using BareMugShot.Core.Eventing.Events;
using BareMugShot.Core.LogProcessing;
using BareMugShot.Core.Subscribing;
using BareMugShot.Core.Subscribing.Zmq;
using Machine.Fakes;
using Machine.Specifications;
using NHibernate.ZMQLogPublisher;

namespace BearMugShot.Core.Tests.LogProcessing
{
    public class When_log_details_with_session_opens_are_processed : WithSubject<SqlLogDetailsProcessor>
    {
        private static SessionOpened _sessionOpened;

        private Establish context = () =>
                                        {
                                            EventDispatcher.Register<SessionOpened>((e) => _sessionOpened = e);
                                        };

        private Because of = () => Subject.ProcessLogDetails(new LogDetails());

        private It should_start_listening_the_queue = () => _sessionOpened.ShouldNotBeNull();
    }
}