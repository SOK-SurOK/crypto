using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class SlepHaum
    {
        long P, Q, N, K, E, D;
        public void SetKeys(long p, long q, int max)
        {
            if (IsTheNumberSimple(Math.Abs(p)) && IsTheNumberSimple(Math.Abs(q)))
            {
                N = p * q;
                P = p;
                Q = q;
                long fn = (p - 1) * (q - 1);
                E = Calculate_e(fn);
                D = Calculate_d(fn, E);

                Random rnd = new Random();
                long k = rnd.Next(max);
                while( NOD(k, N) != 1)
                {
                    k = rnd.Next(max);
                }
                K = k;
                throw new Exception("Закончил!");
            }
            else
            {
                throw new Exception("Числа не простые!");
            }
        }

        public long GetY(long x)
        {
            return ((x*Pow(K, E)) % N);
        }

        public long GetZ(long y)
        {
            return (Pow(y, D) % N);
        }

        public long GetS(long x)
        {
            return ((Pow(x, D)) % N);
        }

        public long Encrypt(long z)
        {
            return ((z/K) % N);
        }
        long Pow(long x, long step)
        {
            long xx = x;
            for (int i = 1; i < step; i++)
            {
                x *= xx;
            }
            return x;
        }
        long NOD(long v1, long v2)
        {
            if (v2 == 0)
            {
                return v1;
            }
            else
            {
                return NOD(v2, v1 % v2);
            }
        }

        bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        long Calculate_e(long fn)
        {
            long x = 0, y = 0;
            Random rnd = new Random();
            long r = rnd.Next(1, (int)fn);
            bool bad = true;
            while (bad)
            {
                r = rnd.Next(1, (int)fn);
                if (r > 1 && r < fn && Gcd(r, fn, out x, out y) == 1)
                {
                    bad = false;
                }
            }

            return r;
        }

        long Calculate_d(long fn, long e)
        {
            long x = 0, y = 0;
            long nod = Gcd(e, fn, out x, out y);
            return x;
        }

        long Gcd(long a, long b, out long x, out long y)
        {
            if (b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            long gcd = Gcd(b % a, a, out x, out y);

            long newY = x;
            long newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }
    }
}
