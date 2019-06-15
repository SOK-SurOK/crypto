using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Fiat_Hamir
    {
        long P, Q, N;
        public void setKey(long p, long q)
        {
            if(FastSimple(p) && FastSimple(q))
            {
                P = p;
                Q = q;
                N = p * q;
            }
            else
            {
                throw new Exception("Числа не простые");
            }
        }

        public bool doo(int s)
        {
            A1 a = new A1(s);
            a.do1(N);
            long x = a.do2(N);
            B1 b = new B1(s, x);
            bool[] bb = b.do1(N);
            long y = a.do3(N, bb);
            bool flag = b.do2(N, y, a.getV());
            return flag;
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
            while ((i8 <= bound) && a % i1 != 0 && a % i2 != 0 && a % i3 != 0 && a % i4 != 0
                && a % i5 != 0 && a % i6 != 0 && a % i7 != 0 && a % i8 != 0)
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
    }


    class A1
    {
        long[] V;
        long[] S;
        long R;
        int size;
        Random rnd;

        public A1(int s)
        {
            size = s;
            rnd = new Random();
            S = new long[size];
            V = new long[size];
        }

        public long[] getV()
        {
            return V;
        }
        public void do1(long n)
        {
            for (int i = 0; i < size; i++)
            {
                S[i] = rnd.Next();
                V[i] = (1 / (S[i] * S[i])) % n;
            }

        }

        public long do2(long n)//передать x
        {
            R = rnd.Next(1, (int)n);
            return (R * R) % n;//x
        }

        public long do3(long n, bool[] b)//передать y
        {
            long ss = 1;
            for (int i = 0; i < size; i++)
            {
               if(b[i])
                {
                    ss *= S[i];
                }
            }
            return (R * ss) % n;//y
        }


    }


    class B1
    {
        bool[] B;
        int size;
        long X;
        Random rnd;

        public B1(int s, long x)
        {
            size = s;
            rnd = new Random();
            B = new bool[size];
            X = x;
        }

        public bool[] do1(long n)//передать b
        {
            for (int i = 0; i < size; i++)
            {
                B[i] = Convert.ToBoolean(rnd.Next(0,2));
            }
            return B;
        }

        public bool do2(long n, long y, long[] v)
        {
            long vv = 1;
            for (int i = 0; i < size; i++)
            {
                if (B[i])
                {
                    vv *= v[i];
                }
            }
            long x = (y * y * vv) % n;
            return x == X;
        }
    }
}
