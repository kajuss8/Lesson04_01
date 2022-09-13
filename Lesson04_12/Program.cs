using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson04_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);
            }
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Array.Sort(array);
            int maxValue = array.Max();
            int minValue = array.Min();
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"max value = {maxValue}, min value = {minValue}");




        }
    }
}
