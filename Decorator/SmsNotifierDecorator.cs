namespace Decorator
{
    public class SmsNotifierDecorator : NotifierDecorator
    {
        public SmsNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            _notifier.Send(message);
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
