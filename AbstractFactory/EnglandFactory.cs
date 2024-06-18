namespace AbstractFactory
{
    public class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
