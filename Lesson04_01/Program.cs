using System;

namespace Lesson04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < skaicius; i++)
            {
                Console.WriteLine(i + 1);
            }    

        }
    }
}
