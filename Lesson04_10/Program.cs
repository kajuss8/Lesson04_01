using System;

namespace Lesson04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 5 skaicius ir isvesime ju suma");

            double[] array = new double[5];
            double suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                suma += array[i];
            }
            Console.WriteLine(suma);


        }
    }
}
