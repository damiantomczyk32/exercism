using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    public static class Pangram
    {
        static char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static bool IsPangram(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            return false;

            var smallInput = input.ToLower();
            return alphabet.All(c=> smallInput.Contains(c)  );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pangram.IsPangram("abcdefghijklmnopqrstuvwxyz"));
            Console.ReadKey();
        }
    }
}
