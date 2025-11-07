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
            String _voornaam = "";
            String _achternaam = "";


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
                    Console.Write("Geef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());


                    // Scherm leegmaken
                    Console.Clear();

                    // Stap 3:
                    // Als 1: Naam veranderen
                    if (_keuze == 1)
                    {
                        // Stap 4: Vraag de voornaam + opslaan
                        Console.Write("Geef uw voornaam: ");
                        _voornaam = Console.ReadLine();

                        // Stap 5: Vraag de achternaam + opslaan
                        Console.Write("Geef uw achternaam: ");
                        _achternaam = Console.ReadLine();

                        // Scherm leegmaken
                        Console.Clear();

                        // Stap 6: Verander de letter e, o en i in 3, 0 en 1 + Toon het resultaat
                        Console.WriteLine ($"De voornaam met de letteres e, o en i veranderd: {_voornaam.Replace('e', '3').Replace('o', '0').Replace('i', '1')}");
                        Console.WriteLine($"De achternaam met de letteres e, o en i veranderd: {_achternaam.Replace('e', '3').Replace('o', '0').Replace('i', '1')}");

                        // Stap 7: Verander de eerste letter in een kleine letter en maar van de andere letters hoofdletters +toon het resultaat
                        Console.WriteLine($"Resultaat van de volledige naam met de eerste letter klein en de andere hoofdletters: \n" +
                            $"{_voornaam.Substring(0,1).ToLower() + _voornaam.Substring(1).ToUpper()} " +
                            $"{_achternaam.Substring(0,1).ToLower() + _achternaam.Substring(1).ToUpper()}");

                        Console.WriteLine("\n\nDruk op een toets om verder te gaan...");
                        Console.ReadKey();

                    }
                    // Als 2: Afsluiten:
                    else if (_keuze == 2)
                    {
                        // Stap 8: Toon afsluittekst
                        Console.WriteLine("Bedankt om het programma te gebruiken, tot ziens!");
                        Console.WriteLine("Druk op een toets om af te sluiten...");
                        Console.ReadKey();
                    }
                    else
                    {
                        // foutmelding bij ongeldige keuze
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw...");
                        Console.WriteLine("Druk op een toets om verder te gaan...");
                        Console.ReadKey();
                    }

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
