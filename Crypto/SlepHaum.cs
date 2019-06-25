using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class SlepHaum
    {
        //long P, Q, N, K, E, D;
        long K;
        RSA rsa;

        public long myK
        {
            get
            {
                return K;
            }
        }
        public long myE
        {
            get
            {
                return rsa.myE;
            }
        }
        public long myD
        {
            get
            {
                return rsa.myD;
            }
        }
        public long myN
        {
            get
            {
                return rsa.myN;
            }
        }
        public void SetKeys(long p, long q, int max)
        {
            rsa = new RSA();
            rsa.SetKeys(p, q);

            Random rnd = new Random();
            long x = 0, y = 0;
            long k = rnd.Next(2, max);
            while( Utils.gcd(k, rsa.myN, out x, out y) != 1)
            {
                k = rnd.Next(2, max);
            }
            K = k;
            //throw new Exception("Закончил!");
        }

        public long GetY(long x)
        {
            return Utils.Mod(x*Utils.Pow(K, rsa.myE), rsa.myN); //((x*Pow(K, E)) % N);
        }

        public long GetZ(long y)
        {
            return Utils.Mod(Utils.Pow(y, rsa.myD), rsa.myN); //(Pow(y, D) % N);
        }

        public long Encrypt(long z)
        {
            return Utils.Mod(z/K, rsa.myN); //((z/K) % N);
        }


        public long GetS(long x)//проверка(то что должны получить)
        {
            return Utils.Mod(Utils.Pow(x, rsa.myD), rsa.myN); //((Pow(x, D)) % N);
        }
    }
}
