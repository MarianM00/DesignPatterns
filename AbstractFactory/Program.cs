using AbstractFactory;

Country country = Country.England;
ILanguage language = InternationalProvider.CreateLanguage(country);
ICapitalCity capital = InternationalProvider.CreateCapital(country);

language.Greet();
Console.WriteLine("Total Population: " + capital.GetPopulation());
Console.WriteLine("Top Attractions: " + string.Join(",", capital.ListTopAttractions()));

