using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*
числа e и n – это открытый ключ, а числа d и n – это закрытый ключ;
открытым ключом зашифровывают сообщение, а закрытым – расшифровывают;
*/
namespace Crypto
{
    class RSA
    {
        long E, N, D;

        public long myE
        {
            get
            {
                return E;
            }
        }
        public long myN
        {
            get
            {
                return N;
            }
        }
        public long myD
        {
            get
            {
                return D;
            }
        }
        public void SetKeys(long p, long q)
        {
            if (Utils.IsTheNumberSimple(p) && Utils.IsTheNumberSimple(q))
            {
                N = p * q;
                long fn = (p - 1) * (q - 1);
                E = Calculate_e(fn);
                D = Utils.Mod(Calculate_d(fn, E), fn);//Так надо
            }
            else
            {
                throw new Exception("Числа не простые!");
            }
        }

        public long Encrypt(long m, long e, long n)
        {
            return Utils.Mod(Utils.Pow(m, e), n);
        }

        public long Decrypt(long c, long d, long n)
        {
            return Utils.Mod(Utils.Pow(c, d), n);
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
                if(r>1 && r<fn && Utils.gcd(r, fn, out x, out y)==1)
                {
                    bad = false;
                }
            }

            return r;
        }

        long Calculate_d(long fn, long e)
        {
            long x = 0, y = 0;
            long nod = Utils.gcd(fn, e, out x, out y);
            return y;
        }
 
    }
}
