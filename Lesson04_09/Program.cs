using System;

namespace Lesson04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 skaicius ir isvesime atbuline tvarka");

            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int skaicius = Convert.ToInt32(Console.ReadLine());
                array[i] = skaicius;
                

            }
            foreach (var skaiciai in array)
            {
                Console.Write(skaiciai);
            }
            Console.WriteLine();
            int[] temp = new int[5];
            int j = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                
                temp[j++] += array[i];

            }
            foreach (var pakeista in temp)
            {
                Console.Write(pakeista);
            }



        }
    }
}
