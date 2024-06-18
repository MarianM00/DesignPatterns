using Singleton;

//Singleton is useful for shared resources such as a logger or database connection.

BaseSignletonLogger singleton1 = SingletonLogger.GetIstance();
BaseSignletonLogger singleton2 = SingletonLogger.GetIstance();

//I have implemented all the possibilities of implementing a singleton, 4 in total


if (singleton1 == singleton2)
{
    Console.WriteLine("Same instance, singleton pattern correctly implemented");
}

singleton1.Log("This message is logged usign a singleton logging system");
