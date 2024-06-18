using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazySingletonLogger : BaseSignletonLogger
    {
        private static readonly Lazy<LazySingletonLogger> instance = new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());

        private LazySingletonLogger() { }

        public static LazySingletonLogger GetIstance()
        {
            return instance.Value;
        }

    }
}
