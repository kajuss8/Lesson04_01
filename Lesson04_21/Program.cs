using System;
using System.Collections.Generic;

namespace Lesson04_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Tomas");
            names.Add("Adomas");
            names.Add("Paulius");
            names.Add("Ignas");
            names.Add("Simonas");
            string name1 = "Napoleonas";
            string name2 = "Asterisas";
            names.Add(name1);
            names.Add(name2);
            
            foreach (string item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            names.Remove(names[2]);
            int index = names.FindIndex(s => s == "Napoleonas");
            names[index] = "Kleopatra";
            foreach (string item in names)
            {
                Console.Write(item + " ");
            }
        }
    }
}
