using System;
using System.Collections.Generic;

namespace Lesson04_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            List<int> equalNumber = new List<int>();
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {   
                randomNumbers.Add(random.Next(0, 100));
                if (randomNumbers[i] % 2 == 0)
                {
                    equalNumber.Add(randomNumbers[i]);

                }
            }

            foreach (int item in randomNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (int item in equalNumber)
            {
                Console.Write(item + " ");
            }

        }
    }
}
