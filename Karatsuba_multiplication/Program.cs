using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5678, 123));
        }
        static BigInteger Multiply(BigInteger x, BigInteger y)//karatsuba multiplication
        {
            int lengthX = x.ToString().Length;
            int lengthY = y.ToString().Length;

            BigInteger split = (BigInteger)Math.Max(Math.Pow(10, lengthX / 2), Math.Pow(10, lengthY / 2));

            if (split == 1)
            {
                return x * y;
            }
            BigInteger a = x / split;
            BigInteger b = x % split;
            BigInteger c = y / split;
            BigInteger d = y % split;
            //BigInteger ac = Multiply(a, c);
            //BigInteger bd = Multiply(b, d);
            //BigInteger compute_abcd = Multiply(a + b, c + d);
            //BigInteger subtracting = compute_abcd - ac - bd;
            //return split * split * ac + split * adPlusbc + bd;
            return a * c * split * split + (a * d + b * c) * split + b * d;
        }
    }
}
