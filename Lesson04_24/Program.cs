using System;

namespace Lesson04_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rna = new string[] { "A", "A", "U", "C", "G" };
            string[] dna = new string[5];
            Console.WriteLine("RNA");
            foreach (string item in rna)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int j = 0;
            for (int i = 0; i < rna.Length; i++)
            {
                if (rna[i] == "A")
                {
                    dna[i] += "A-T";
                    //Console.Write(dna[i] + " ");
                }
                else if (rna[i] == "U")
                {
                    dna[i] += "T-A";
                    //Console.Write(dna[i] + " ");
                }
                else if (rna[i] == "C")
                {
                    dna[i] += "C-G";
                    //Console.Write(dna[i] + " ");
                }
                else if (rna[i] == "G")
                {
                    dna[i] += "G-C";
                    //Console.Write(dna[i] + " ");
                }

                
            }
            Console.WriteLine("DNA");
            foreach (string item in dna)
            {
                Console.Write(item + " ");
            }


        }
    }
}
