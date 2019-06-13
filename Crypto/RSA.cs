using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*
числа e и n – это открытый ключ, а числа d и n – это закрытый ключ;
открытым ключом зашифровывают сообщение, а закрытым – расшифровывают;
разбить шифруемый текст на блоки,
каждый из которых может быть представлен в виде числа M(i);
*/
namespace Crypto
{
    class RSA
    {
        long E, N, D;

        public long getE
        {
            get
            {
                return E;
            }
        }
        public long getN
        {
            get
            {
                return N;
            }
        }
        public long getD
        {
            get
            {
                return D;
            }
        }
        public void SetKeys(long p, long q)
        {
            if (IsTheNumberSimple(Math.Abs(p)) && IsTheNumberSimple(Math.Abs(q)))
            {
                N = p * q;
                long fn = (p - 1) * (q - 1);
                E = Calculate_e(fn);
                D = Calculate_d(fn, E);   
            }
            else
            {
                throw new Exception("Числа не простые!");
            }
        }

        public long Encrypt(long m)
        {
            return ((long)Math.Pow(m, E) % N);
        }

        public long Decrypt(long c)
        {
            return ((long)Math.Pow(c, D) % N);
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
                if(r>1 && r<fn && Gcd(r, fn, out x, out y)==1)
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
        bool FastSimple(long a)
        {   
            long i1, i2, i3, i4, i5, i6, i7, i8, bound;
            if (a == 0 || a == 1)
                return false;
            if (a == 2 || a == 3 || a == 5 || a == 7 || a == 11 || a == 13 || a == 17 || a == 19 || a == 23 || a == 29)
                return true;
            if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0 || a % 11 == 0 || a % 13 == 0 || a % 17 == 0 || a % 19 == 0 || a % 23 == 0 || a % 29 == 0)
                return false;
            bound = (long)Math.Sqrt(a);
            i1 = 31; i2 = 37; i3 = 41; i4 = 43; i5 = 47; i6 = 49; i7 = 53; i8 = 59;
            while ((i8 <= bound) && a % i1 !=0 && a % i2!=0 && a % i3!=0 && a % i4!=0
                && a % i5!=0 && a % i6!=0 && a % i7!=0 && a % i8!=0)
            {
                i1 += 30; i2 += 30; i3 += 30; i4 += 30; i5 += 30; i6 += 30; i7 += 30; i8 += 30;
            }
            if (i8 <= bound ||
               i1 <= bound && a % i1 == 0 ||
               i2 <= bound && a % i2 == 0 ||
               i3 <= bound && a % i3 == 0 ||
               i4 <= bound && a % i4 == 0 ||
               i5 <= bound && a % i5 == 0 ||
               i6 <= bound && a % i6 == 0 ||
               i7 <= bound && a % i7 == 0)
                return false;
            return true;
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

        int gcd(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            int x1, y1;
            int d = gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }
    }
}
