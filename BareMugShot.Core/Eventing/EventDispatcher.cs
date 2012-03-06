using System;
using System.Collections.Generic;
using Autofac;

namespace BareMugShot.Core.Eventing
{
    /// <summary>
    /// From Udi Dahan
    /// http://www.udidahan.com/2009/06/14/domain-events-salvation/
    /// </summary>
    public static class EventDispatcher
    {
        [ThreadStatic] //so that each thread has its own callbacks
        private static List<Delegate> _actions;

        public static IContainer Container { get; set; } //as before

        //Registers a callback for the given domain event
        public static void Register<T>(Action<T> callback) where T : IEvent
        {
            if (_actions == null)
                _actions = new List<Delegate>();

            _actions.Add(callback);
        }

        //Clears callbacks passed to Register on the current thread
        public static void ClearCallbacks()
        {
            _actions = null;
        }

        //Raises the given domain event
        public static void Raise<T>(T args) where T : IEvent
        {
            if (Container != null)
            {
                //Process specific handlers.
                foreach (var handler in Container.Resolve<IEnumerable<IHandles<T>>>())
                    handler.Handle(args);
            }

            if (_actions != null)
                foreach (var action in _actions)
                    if (action is Action<T>)
                        ((Action<T>) action)(args);
        }
    }
}
