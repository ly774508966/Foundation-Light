// Nicholas Ventimiglia 2016-09-05

using System;

namespace Foundation.Architecture
{
    /// <summary>
    /// Implements IPropertyChanged for Non-Monobehaviours
    /// </summary>
    public class ObservableObject : IObservable<PropertyEvent>
    {
        /// <summary>
        /// Listeners
        /// </summary>
        public event Action<PropertyEvent> OnPublish = delegate { };
        
        /// <summary>
        /// Raise Change
        /// </summary>
        /// <param name="model"></param>
        public void Publish(PropertyEvent model)
        {
            OnPublish(model);
        }

        /// <summary>
        /// Raise Change on a single property
        /// </summary>
        public void RaiseChange<T>(string memberName, T value)
        {
            OnPublish(new PropertyEvent { Sender = this, Name = memberName, Value = value });
        }

        /// <summary>
        /// Raise Change All
        /// </summary>
        public void RaiseChange()
        {
            OnPublish(new PropertyEvent { Sender = this });
        }

        public void Dispose()
        {
            OnPublish = delegate { };
        }
    }
}