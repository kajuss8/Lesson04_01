using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lesson04_26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "C:\\Users\\37067\\OneDrive\\Desktop\\C sharp basic\\Lesson04_01\\Lesson04_26\\countries.txt";
            string writeFile = "C:\\Users\\37067\\OneDrive\\Desktop\\C sharp basic\\Lesson04_01\\Lesson04_26\\countries_sorted.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);    
            }

            File.WriteAllLines(writeFile, lines);

            Console.ReadLine();
        }   
    }
}
