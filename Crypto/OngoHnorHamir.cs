using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class OngoHnorHamir
    {
        long N, K, H, S1, S2;

        public long myN
        {
            get
            {
                return N;
            }
        }
        public long myK
        {
            get
            {
                return K;
            }
        }
        public long myH
        {
            get
            {
                return H;
            }
        }
        public long myS1
        {
            get
            {
                return S1;
            }
        }
        public long myS2
        {
            get
            {
                return S2;
            }
        }
        public void SetKeys(long p, long q, int max)
        {
            if (Utils.IsTheNumberSimple(p) && Utils.IsTheNumberSimple(q))
            {
                N = p * q;
                long fn = (p - 1) * (q - 1);

                Random rnd = new Random();
                long x = 0, y = 0;
                long k = rnd.Next(2, max);
                while (Utils.gcd(k, N, out x, out y) != 1)
                {
                    k = rnd.Next(2, max);
                }
                K = k;

                H = -Utils.getMulObr(N, K*K);
            }
            else
            {
                throw new Exception("Числа не простые!");
            }
        }

        private bool proverka(long x, long y)
        {
            long x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            return Utils.gcd(x, y, out x1, out y1) == 1 && Utils.gcd(y, N, out x2, out y2) == 1;
        }

        public void setS(long x, long y)
        {
            if(!proverka(x, y))
            {
                throw new Exception("сообщения не взаимнопростые");
            }
            else
            {
                S1 = Utils.Mod(Utils.getMulObr(N, 2)*(x * Utils.getMulObr(N, y)+ y), N);
                S2 = Utils.Mod(Utils.getMulObr(N, 2) * K * (x * Utils.getMulObr(N, y) + y), N);
            }
        }


        public bool isTrue(long x)
        {
            return x == S1*S1 + S2*S2*H;
        }

        public long getY(long x)
        {
            return Utils.Mod(x* Utils.getMulObr(N, S1+S2*Utils.getMulObr(N, K)  ), N);
        }
    }
}
