namespace BareMugShot.Core.Eventing.Events
{
    public class SqlExecuted : IEvent
    {
        public string SessionId { get; set; }
    }
}