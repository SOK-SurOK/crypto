using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class XehMagma
    {
        public string Encrypt(string key, string text)
        {
            if(key.Length != 64)
            {
                throw new Exception("Ключ не верного размера!");
            }
            if(text.Length % 16 != 0)
            {
                while(text.Length%16 != 0)
                {
                    text += "0";
                }
            }

            int kol = text.Length / 16;
            string[] str = new string[kol];
            string k = text;
            for (int i = 0; i < kol; i++)
            {
                k = text.Substring(16 * i, 16);
                //if(text.Length >= 16 * (i + 1) + 1)
                //    k = text.Remove(16*(i+1)+1);
                //k = k.Remove(0, );
                str[i] = k;
            }

            Magma m = new Magma();
            string ret = key;
            for (int i = 0; i < kol; i++)
            {
                m.SetKey(Utils.StringToByteArray(ret+ret+ret+ret));
                ret = Utils.ByteArrayToString(m.Encrypt(Utils.StringToByteArray(str[i])));
            }
            return ret;
        }

        public string Decrypt(string key, string text)
        {
            if (key.Length != 64)
            {
                throw new Exception("Ключ неверного размера!");
            }
            if (text.Length != 16)
            {
                throw new Exception("Значение неверного размера!");
            }
            var kol = 3;
            string[] str = new string[kol];
            for (int i = 0; i < kol; i++)
            {
                //str[kol-i-1] = 
            }
            return "";
        }
    }
}
