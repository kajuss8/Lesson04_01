using System;

namespace Lesson04_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            int temp = int.MinValue;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }


        }
    }
}
