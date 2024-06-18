namespace Singleton
{
    public class ThreadSafeSingletonLogger : BaseSignletonLogger
    {
        private static readonly object threadSafeLock = new object();

        private static ThreadSafeSingletonLogger? instance;

        private ThreadSafeSingletonLogger() { }

        public static ThreadSafeSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                lock (threadSafeLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletonLogger();
                    }
                }
            }
            return instance;
        }
    }
}
