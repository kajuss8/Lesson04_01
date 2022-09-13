using System;
using System.Collections.Generic;

namespace Lesson04_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> student1 = new List<string>();
            student1.Add("Tomas");
            student1.Add("Adomas");
            student1.Add("Ignas");
            student1.Add("Paulius");
            student1.Add("Simonas");
            List<string> student2 = new List<string>();
            student2.Add("Povilas");
            student2.Add("Marius");
            student2.Add("Alina");
            student2.Add("Daniela");
            student2.Add("Vakaris");
            List<string> allStudent = new List<string>();
            for (int i = 0; i < student1.Count; i++)
            {
                allStudent.Add(student1[i]);
                allStudent.Add(student2[i]);
            }
            allStudent.Sort();
            foreach (string item in allStudent)
            {
                Console.WriteLine(item);
            }



        }
    }
}
