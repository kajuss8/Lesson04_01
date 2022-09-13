using System;

namespace Lesson04_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] array = new int[100000];
            Random random = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10000);


            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Array.Sort(array);
            /*
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            */
            watch.Start();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs.ToString());
        }
    }
}
