using System;

namespace Lesson04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= skaicius-1; i++)
            {
                suma += i;
                Console.WriteLine($"{i} + {i+1} = {i + i + 1}");
                
            }
            Console.WriteLine(suma+skaicius);
        }
    }
}
