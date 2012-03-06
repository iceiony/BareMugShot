namespace BareMugShot.Core.Eventing.Events
{
    public class SessionOpened : IEvent
    {
        public string SessionId { get; set; }
    }
}