using System;

namespace Lesson04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zodi");
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            string reverse = "";
            for (int i = array.Length-1; i >= 0; i--)
            {
                reverse += array[i];
                
            }
            Console.Write(reverse);
        }
    }
}
