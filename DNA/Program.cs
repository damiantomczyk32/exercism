using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            
            int lenght = nucleotide.Length;
            var text = new StringBuilder();

            for (int i = 0; i < lenght; i++)
            {
                string n = nucleotide[i].ToString();
                if (n == "C")
                {
                    n = "G";
                }
                else
                if (n == "G")
                {
                    n = "C";
                }
                else
                if (n == "T")
                {
                    n = "A";
                }
                else
                if (n == "A")
                {
                    n = "U";
                }
                text = text.Append(n);
            }
            
            /*
            if (nucleotide == "C")
                nucleotide = "G";
            else
            if (nucleotide == "G")
                nucleotide = "C";
            else
            if (nucleotide == "T")
                nucleotide = "A";
            else
            if (nucleotide == "A")
                nucleotide = "U";
                */



            return text.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(RnaTranscription.ToRna("ACGTGGTCTTAA")); //UGCACCAGAAUU      ACGTGGTCTTAA
            Console.ReadKey();
        }
    }
}
