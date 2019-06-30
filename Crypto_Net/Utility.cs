using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Net
{
    class Utility
    {
        static public long getZahifr(long pas, long key)
        {
            return pas ^ key;
        }

        static public long getRashifr(long pas, long key)
        {
            return pas ^ key;
        }

        static public long simHifr(long a, long key)
        {
            return a ^ key;
        }
    }
}
