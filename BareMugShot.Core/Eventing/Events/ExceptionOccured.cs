namespace BareMugShot.Core.Eventing.Events
{
    public class ExceptionOccured : IEvent
    {
        public string SessionId { get; set; }
    }
}