using System;
using System.Linq;

namespace Lesson04_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int temp = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,100);
                

            }
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                temp = random.Next(0, 9);

            }
            Console.WriteLine(array[temp]);
            array = array.Where(x => x != array[temp]).ToArray();
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }


        }
    }
}
