using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Lesson04_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();
            marks.Add(3);
            marks.Add(4);
            marks.Add(2);
            marks.Add(1);
            marks.Add(7);
            marks.Add(5);
            marks.Add(8);
            marks.Add(10);
            
            Console.WriteLine("pazymiu lentele");
            foreach (int i in marks)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            while(true)
            {
                Console.WriteLine("0 - pildyti, 1 - istrinti, 2 - iterpti, 3 - parodyti pazimiu vidurki, 4 - iseiti is programos");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp == 0)
                {
                    Console.WriteLine("kokiu pazymiu noretumete papildyti?");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    marks.Add(grade);
                    foreach (int item in marks)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine() ;
                    
                }    
                else if (temp == 1)
                {
                    Console.WriteLine("kurioje vietoje noretumete istrinti pazymi?");
                    int place = Convert.ToInt32(Console.ReadLine());
                    marks.Remove(marks[place-1]);
                    foreach (int item in marks)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else if (temp == 2)
                {
                    Console.WriteLine("kurioje vietoje noretumete iterpti pazymi?");
                    int place = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("koki pazymi noretumete iterpti?");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    int index = marks.IndexOf(marks[place-1]);
                    marks.Insert(index, grade);
                    foreach (int item in marks)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    

                }    
                else if (temp == 3)
                {
                    double listAverage = 0;
                    for (int i = 0; i < marks.Count; i++)
                    {
                        listAverage += marks[i];
                        

                    }
                    Console.WriteLine($"pazymiu vidurkis = {listAverage / marks.Count}");
                    
                }
                else if (temp == 4)
                {
                    Console.WriteLine("programa baigiama");
                    break;
                }
                



            }

        }
    }
}
