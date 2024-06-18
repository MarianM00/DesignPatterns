namespace Decorator
{
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _notifier;

        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public abstract void Send(string message);
    }
}
