using System;

namespace Lesson04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= skaicius; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
