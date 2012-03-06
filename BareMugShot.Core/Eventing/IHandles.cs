namespace BareMugShot.Core.Eventing
{
    public interface IHandles<in T> where T : IEvent
    {
        void Handle(T domainEvent);
    }
}