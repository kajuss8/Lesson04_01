using System;

namespace Lesson04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[] { 1, 2, 4, 8, 16};
            int[] array2 = new int[] { 2, 5, 8};
            int counter = 0;
            foreach (int item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write(array2[i] + " ");
                        counter++;
                    }

                }
                if (counter == array2.Length)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Taip, s2 yra s1 dalimi");
                    break;
                }
                else if (counter != i+1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ne, s2 nera s1 dalimi");
                    break;
                }    
                
                
            }
            
            

        }
    }
}
