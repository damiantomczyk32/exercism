using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class HelloWord
    {
        public static string SayHello(string x="you")
        {
            return $"One for { x }, one for me.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWord.SayHello("BICZ"));
            Console.ReadKey();
        }
    }
}
