namespace AbstractFactory
{
    public class InternationalProvider
    {
        public static ILanguage CreateLanguage(Country country)
        {
            return country switch
            {
                Country.England => new English(),
                Country.Spain => new Spanish(),
                _ => throw new InvalidOperationException($"Country invalid {country} !"),
            };
        }

        public static ICapitalCity CreateCapital(Country country)
        {
            return country switch
            {
                Country.England => new London(),
                Country.Spain => new Madrid(),
                _ => throw new InvalidOperationException($"Country invalid {country} !"),
            };
        }
    }
}
