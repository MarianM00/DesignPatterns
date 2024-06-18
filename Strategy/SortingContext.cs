
public class SortingContext
{
    private ISortingStrategy _strategy;

    public void SetStrategy(ISortingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Sort(List<int> list)
    {
        _strategy.Sort(list);
    }
}

