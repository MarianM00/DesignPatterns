namespace Singleton
{
    public class SingletonLogger : BaseSignletonLogger
    {
        private static SingletonLogger? instance;

        private SingletonLogger() { }

        public static SingletonLogger GetIstance()
        {
            if (instance == null)
            {
                instance = new SingletonLogger();
            }

            return instance;
        }
    }
}
