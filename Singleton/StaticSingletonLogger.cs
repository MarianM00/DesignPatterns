using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class StaticSingletonLogger : BaseSignletonLogger
    {
        private static readonly StaticSingletonLogger instance = new();

        private StaticSingletonLogger() { }

        public static StaticSingletonLogger GetInstance()
        {
            return instance;
        }
    }
}
