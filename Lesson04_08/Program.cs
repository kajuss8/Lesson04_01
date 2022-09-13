using System;

namespace Lesson04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Iveskite pirmaji skaiciu");
                double pirmasSkaicius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite matematini simboli [+,-,/,*]");
                char simbolis = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Iveskite antraji skaiciu");
                double antrasSkaicius = Convert.ToDouble(Console.ReadLine());
                if(simbolis == '+')
                {
                    Console.WriteLine($"{pirmasSkaicius} + {antrasSkaicius} = {pirmasSkaicius + antrasSkaicius}");
                    
                }
                else if (simbolis == '-')
                {
                    Console.WriteLine($"{pirmasSkaicius} - {antrasSkaicius} = {pirmasSkaicius - antrasSkaicius}");
                   
                }
                else if (simbolis == '/')
                {
                    Console.WriteLine($"{pirmasSkaicius} / {antrasSkaicius} = {pirmasSkaicius / antrasSkaicius}");
                    
                }
                else if (simbolis == '*')
                {
                    Console.WriteLine($"{pirmasSkaicius} * {antrasSkaicius} = {pirmasSkaicius * antrasSkaicius}");
                    
                }
                Console.WriteLine("ar norite testi programa? [y/n]");
                char pasirinkimas = Convert.ToChar(Console.ReadLine());
                if(pasirinkimas == 'y')
                {
                    continue;
                }
                else if(pasirinkimas == 'n')
                {
                    Console.WriteLine("programa pabaigiama, viso gero");
                    break;
                }
                else
                {
                    Console.WriteLine("Ivyko klaida programa issijungia");
                    break;
                }

            }

        }
    }
}
