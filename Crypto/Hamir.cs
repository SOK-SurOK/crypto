using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Hamir
    {
        long K, M, P, N;
        long[] R;
        long[] Si;
        long[] Sr;
        public void setKey(long m, long p, int k, int n)
        {
            if(Utils.IsTheNumberSimple(m) && Utils.IsTheNumberSimple(p) && m <p && k<=n)
            {
                M = m;
                P = p;
                K = k;
                N = n;
                R = new long[n];
                Sr = new long[n];
                Si = new long[k-1];
            }
            else
            {
                throw new Exception("Неправильный ввод");
            }
        }

        public void setFunc(int maxi)
        {
            Random rnd = new Random();

            for (int i = 0; i < K-1; i++)
            {
                Si[i] = rnd.Next(1, maxi);
            }

            for (int i = 0; i < N; i++)
            {
                //R[i] = i + 1;
                R[i] = rnd.Next(1, maxi);
            }

            for (int i = 0; i < N; i++)
            {
                Sr[i] = Func(R[i]);
            }


        }

        private long Func(long r)
        {
            long res = 0;
            for (int i = 0; i < K-1; i++)
            {
                res += Si[i] * Utils.Pow(r, i+1); 
            }
            res += M;
            return Utils.Mod(res, P);
        }

        public long getM(int[] ii)
        {
            long ret = 0;
            for (int i = 0; i < ii.Length; i++)
            {
                ret += Sr[ii[i]] * getC(ii, ii[i]);
            }
            return Utils.Mod(ret, P);
            //int i = 0;
            //ret = Sr[i] * C[i];
        }

        private long getC(int[] ri, int i)
        {
            long ret = 1;
            //for (int i = 0; i < rr.Length; i++)
            //{
                for (int j = 0; j < ri.Length; j++)
                {
                    if(i != ri[j])
                    {
                        ret *= R[ri[j]] / (R[ri[j]] - R[i]);
                    }
                }
               
            //}
            return Utils.Mod(ret, P);
        }
    }
}
