public class Customer : IObserver
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public void Update(string availability)
    {
        Console.WriteLine($"Hello {_name}, the product is now {availability}");
    }
}
