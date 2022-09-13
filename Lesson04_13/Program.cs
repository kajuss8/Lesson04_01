using System;

namespace Lesson04_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array = new int[10];
            Random random1 = new Random();
            Random random2 = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random1.Next(1, 100);
                array2[i] = random2.Next(1, 100);

            }
            foreach (int item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (int item1 in array2)
            {
                Console.Write(item1 + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] += array1[i];
                
            }
            int j = 0;
            for (int i = array2.Length; i < array.Length; i++)
            {
                array[i] += array2[j++];

            }
            Array.Sort(array);
            foreach (int item in array)
            {
                
                Console.Write(item + " ");
            }


        }
    }
}
