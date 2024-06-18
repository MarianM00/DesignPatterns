// ConcreteBuilder class
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.PartA = "PartA";
    }

    public void BuildPartB()
    {
        _product.PartB = "PartB";
    }

    public Product GetResult()
    {
        return _product;
    }
}
