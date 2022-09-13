using System;

namespace Lesson04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Iveskite sveikaji skaiciu");
                int skaicius;
                bool teisingas = int.TryParse(Console.ReadLine(), out skaicius);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{skaicius} * {i + 1} = {skaicius * (i + 1)}");
                    
                    
                }
                Console.WriteLine("Jeigu norite testi? [y/n]");
                char atsakymas = Convert.ToChar(Console.ReadLine());
                if (atsakymas == 'y')
                {
                    continue;
                }    
                else if(atsakymas == 'n')
                {
                    Console.WriteLine("Programa baigta");
                    break;
                }
                else
                {
                    Console.WriteLine("Programa baigta, Ivedete ne pagal prasyma");
                    break;
                }


            }
            
        }
    }
}
