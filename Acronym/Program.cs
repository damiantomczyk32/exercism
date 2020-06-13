using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acronym
{
    class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            /*
            string[] word = phrase.Split(' ');
            Regex pattern = new Regex("[;,'_/s\t\r\n]");
            var a = new StringBuilder();
            for (int i = 0; i<word.Length; i++)
            {
                
                pattern.Replace(word[i][0].ToString(), " ");
                if (word[i][0].ToString() == " ")
                  continue;
                phrase = a.Append(word[i][0].ToString()).ToString().ToUpper();
            }
            return phrase.Replace("-","");
            */
            string[] words = phrase.Split(new char[] {' ','_','-' },StringSplitOptions.RemoveEmptyEntries);
            var a = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                phrase = a.Append(words[i][0].ToString()).ToString().ToUpper();
            }
            return phrase;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Acronym.Abbreviate("Something - I made up from thin air"));
            Console.ReadKey();
        }
    }
}
