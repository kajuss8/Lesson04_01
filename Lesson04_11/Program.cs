using System;

namespace Lesson04_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 skaicius, issaugosime naujame masyve");
            double[] array = new double[5];
            double[] array2 = new double[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                array2[i] += array[i];

            }
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
