using System;

namespace Lesson04_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Flag", "Nest", "Cup", "Burg", "Yatch", "Next" };

            for (int i = 0; i < names.Length; i++)
            {
                var x = names[i];
                var j = i;
                while (j > 0 && names[j - 1].CompareTo(x) > 0)
                {
                    names[j] = names[j - 1];
                    j = j - 1;
                }
                names[j] = x;
                
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
