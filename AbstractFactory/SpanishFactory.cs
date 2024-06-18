using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SpanishFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}
