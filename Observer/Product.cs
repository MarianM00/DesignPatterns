public class Product
{
    private List<IObserver> _observers = new List<IObserver>();
    private string? _availability;

    public string Availability
    {
        get { return _availability; }
        set
        {
            _availability = value;
            NotifyObservers();
        }
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_availability);
        }
    }
}
