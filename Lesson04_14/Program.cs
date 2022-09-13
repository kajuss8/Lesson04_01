using System;

namespace Lesson04_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if( i == array[j])
                    {
                        ++suma;
                    }
                    
                }
                if (suma > 1)
                {
                    Console.WriteLine($"number {i} repeating {suma-1} time ");
                }    
                
                suma = 0;
            }
            
        }
    }
}
