using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram
{
    public class Isogram
    {
        public static bool CheckIsogram(string word)
        {
            char[] arr = word.ToLower().ToArray();
            Array.Sort(arr);
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (arr[i].ToString() == " " || arr[i].ToString() == "-")
                    continue;
                if (arr[i] == arr[i + 1])
                    return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Isogram.CheckIsogram("Emily Jung Schwartzkopf"));
            Console.ReadKey();
        }
    }
}
