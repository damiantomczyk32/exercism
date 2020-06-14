using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    public enum Classification
    {
        Perfect,
        Abundant,
        Deficient
    }

    public static class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            int sum = 0;
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("wrong value");
            }
            for (int i = 1; i<number;i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number) { return Classification.Perfect; }
            if (sum > number) { return Classification.Abundant; }
            if (sum < number) { return Classification.Deficient; }
            return (Classification)number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = (Classification)1;

            //Console.WriteLine(a);
            Console.WriteLine(PerfectNumbers.Classify(12));
            Console.ReadKey();
        }
    }
}
