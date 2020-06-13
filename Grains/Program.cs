using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public static class Grains
    {
        public static ulong Square(int i)
        {
            if ((i <= 0) || (i > 64))
            {
                throw new ArgumentOutOfRangeException("pass a value between 1 and 64");
            }
            ulong result = (ulong)Math.Pow(2, i - 1);
            return result;
        }

        //public static double Total() => Enumerable.Range(1, 64).Select(Square).Sum();
        public static ulong Total()
        {
            ulong total = 0;
            for (int i = 1; i <= 64; i++)
            {
                total += Square(i);
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Grains.Square(65));
            Console.ReadKey();
        }
    }
}
