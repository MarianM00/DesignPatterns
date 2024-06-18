namespace AbstractFactory
{
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapital();
    }
}
