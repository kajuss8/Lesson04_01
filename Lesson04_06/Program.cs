using System;

namespace Lesson04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite eiluciu skaiciu");
            int val = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");  
                }
                Console.WriteLine();
            }
            


        }
    }
}
