using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _11_TomA_StrFunc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaes 
            // 06/11/2025
            // String Functions 2

            // Velden 
            Byte _keuze = 0;

            // Programma 

            // Stap 1: Intro
            Console.WriteLine("|===========================================|");
            Console.WriteLine("| Welkom bij het programma Naam Veranderen! |");
            Console.WriteLine("|===========================================|");
            Console.WriteLine();
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();

            do 
            { 
                // Scherm leegmaken 
                Console.Clear();

                // Stap 2: Toon keuzemenu(Naam veranderen, afsluiten)
                Console.WriteLine("Kies een optie:");
                Console.WriteLine("   1. Naam veranderen");
                Console.WriteLine("   2. Afsluiten");

                try
                {

                    // Vraag keuze en opslaan 

                    // Stap 3:
                    // Als 1: Naam veranderen

                    // Stap 4: Vraag de voornaam + opslaan

                    // Stap 5: Vraag de achternaam + opslaan

                    // Stap 6: Verander de letter e, o en i in 3, 0 en 1 + Toon het resultaat
                    // Stap 7: Verander de eerste letter in een kleine letter en maar van de andere letters hoofdletters +toon het resultaat


                    // Als 2: Afsluiten:
                    // Stap 8: Toon afsluittekst

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Fout code 
                    Console.WriteLine("U gaf geen getal in, probeer opnieuw...");
                    Console.WriteLine("Druk op een toets om verder te gaan...");
                    Console.ReadKey();
                }
                // Stap 9 : indien keuze niet 2, ga terug naar stap 2
            } while(_keuze != 2);


    }
    }
}
