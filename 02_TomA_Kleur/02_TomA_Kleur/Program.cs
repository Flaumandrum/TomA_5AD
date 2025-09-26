using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_TomA_Kleur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 26/09/2025
            // Oef 16: Project Kleur

            // Velden 
            Byte _keuze = 0;

            // Programma 
            // Stap 1: Intro
            Console.WriteLine("Welkom bij het kleurprogramma!");
            Console.WriteLine("\nDruk op een toets om verder te gaan...");
            Console.ReadKey();

            // Scherm leegmaken
            Console.Clear();

            // Stap 2: Toon keuzemenu(Rood, groen, blauw)
            Console.WriteLine("Kies een kleur uit het menu:");
            Console.WriteLine("  1. Rood \n  2. Groen \n  3. Blauw");

            // Foutafhandeling
            try
            {

                // Stap 3: vraag keuze +opslaan
                Console.Write("\nUw keuze: ");
                _keuze = Byte.Parse(Console.ReadLine());


                // Scherm leegmaken
                Console.Clear();

                // Stap 4: 
                // •	Als keuze Rood
                if (_keuze == 1)
                {
                    // o   Toon Tekst
                    Console.WriteLine("U koos voor de kleur rood!");
                }

                // •	Als keuze groen
                else if (_keuze == 2)
                {
                    // o   Toon Tekst
                    Console.WriteLine("U koos voor de kleur groen!");
                }

                // •	Als keuze blauw
                else if (_keuze == 3)
                {
                    // o   Toon Tekst
                    Console.WriteLine("U koos voor de kleur blauw!");

                }
                else
                {
                    // o   foutmelding
                    Console.WriteLine("U gaf geen geldige keuze in!");

                }
                Console.WriteLine("\nDruk op een toets om verder te gaan...");
                Console.ReadKey();
            }
            catch
            {   
                // Scherm leegmaken
                Console.Clear();

                // Foutmelding
                Console.WriteLine("U gaf geen juist getal in!");
                Console.WriteLine("\nDruk op een toets om verder te gaan...");
                Console.ReadKey();

                
            }

        }
    }
}
