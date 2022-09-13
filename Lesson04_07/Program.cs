using System;
using System.Linq;

namespace Lesson04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("parasykite sakini");
            string sakinys = Console.ReadLine();
            string[] keitimas = sakinys.Split(' ');
            for (int i = keitimas.Length-1; i >= 0; i--)
            {
                
                Console.Write(keitimas[i] + " ");
                
            }
            
        }
    }
}
