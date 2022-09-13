using System;

namespace Lesson04_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            int largest = int.MinValue;
            int second = int.MinValue;
            int smallest = int.MaxValue;
            int secondSmall = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = random.Next(0, 100);

            }
            Array.Sort(array);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (int i in array)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if(i > second)
                {
                    second = i;
                }
                

            }
            foreach (int i in array)
            {
                if (i < smallest)
                {
                    secondSmall = smallest;
                    smallest = i;
                }
                else if (i < secondSmall)
                {
                    secondSmall = i;
                }
            }
            Console.WriteLine($"Second largest number {second}");
            Console.WriteLine($"Second smallest number {secondSmall}");
        }
    }
}
