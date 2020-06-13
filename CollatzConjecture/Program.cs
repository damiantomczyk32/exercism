using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number < 0) throw new ArgumentException();
            if (number == 1) return 0;
            if (number % 2 == 0) return 1 + Steps(number / 2);
            return 1 + Steps(number * 3 + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CollatzConjecture.Steps(16));
            Console.ReadKey();
        }
    }
}
