using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Utils
    {
        public static long Mod(long n, long d)
        {
            long result = n % d;
            if (Math.Sign(result) * Math.Sign(d) < 0)
                result += d;
            return result;

        }
        public static long Pow(long x, long step)
        {
            long xx = x;
            for (int i = 1; i < step; i++)
            {
                x *= xx;
            }
            return x;
        }

        /*public static long Gcd(long a, long b, out long x, out long y)
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

            long gcd = Gcd(Mod(b, a), a, out x, out y);

            long newY = x;
            long newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }*/

        public static long gcd(long a, long b, out long x, out long y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            long x1, y1;
            long d = gcd(Mod(b, a), a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        public static bool IsTheNumberSimple(long n)
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
        public static bool FastSimple(long a)
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
        public static string StringToHexString(string str)
        {
            byte[] ba = Encoding.Default.GetBytes(str);
            var hexString = BitConverter.ToString(ba);
            return hexString.Replace("-", "");
        }

        public static string HexStringToString(string str)
        {
            byte[] bb = Enumerable.Range(0, str.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(str.Substring(x, 2), 16))
                             .ToArray();

            return System.Text.Encoding.UTF8.GetString(bb);
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
