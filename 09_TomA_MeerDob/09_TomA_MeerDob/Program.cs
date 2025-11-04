using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_TomA_MeerDob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 24/10/2025
            // Project meer dobbelstenen

            // Velden 
            Byte _keuze = 0;
            Byte _aantalOgen = 0;
            Byte _worp = 0;
            int _resultaat = 0;

            // Programma

            //  Stap 1: Intro
            Console.WriteLine("Welkom bij het meer dobbelstenen programma!");
            Console.WriteLine("Druk op een toets om te starten...");
            Console.ReadKey();
            do {
                // Scherm leegmaken
                Console.Clear();

                
                Console.WriteLine("Maak uw keuze uit volgend menu:");
                //  Stap 2: Ga na of het aantal ogen is ingevuld)
                //  •	Indien niet
                //  Stap 3: Toon menu(ogen ingeven, afsluiten
                Console.WriteLine("   1. Aantal ogen ingeven");
               
                if (_aantalOgen != 0)
                {//  •	Indien wel
                 //  Stap 4: Toon menu(ogen ingeven, werpen, resetten, afsluiten)
                    Console.WriteLine("   2. Werp de dobbelsteen");
                    Console.WriteLine("   3. Resetten");
                }
                Console.WriteLine("   4. Afsluiten");

                try
                {
                    //  Stap 5: Vraag keuze +opslaan
                    Console.Write("\n\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //Scherm leegmaken
                    Console.Clear();

                    //  Stap 6: 
                    //  •	Als 1:
                    if (_keuze==1)
                    {
                        //  Stap 7: Vraag het aantal ogen +opslaan
                        Console.Write("Geef het aantal ogen van de dobbelsteen in: ");
                        _aantalOgen = Byte.Parse(Console.ReadLine());

                        //Scherm leegmaken
                        Console.Clear();

                        // Begeleiden gebruiker
                        Console.WriteLine($"\nHet aantal ogen is ingesteld op {_aantalOgen.ToString()}.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het menu");
                        Console.ReadKey();
                    }
                    

                    //  •	Als 2:
                    else if(_keuze==2)
                    {
                        // radom getal generator aanmaken
                        Random rnd = new Random();

                        //  Stap 8: Maak een willekeurig getal aan + opslaan
                        // Gooi de dobbelsteen
                        _worp = Convert.ToByte (rnd.Next(1, _aantalOgen + 1));
                        
                        //  Stap 9: Tel het bij , bij het resultaat + opslaan + Toon

                        _resultaat += _worp;

                        // Begeleiden gebruiker
                        Console.WriteLine($"U heeft een {_worp.ToString()} gegooid met een dobbelsteen van {_aantalOgen.ToString()}.");
                        Console.WriteLine($"Uw huidige resultaat is {_resultaat.ToString()}.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het menu");
                        Console.ReadKey();


                    }
                    

                    //  •	Als 3: 
                    //  Stap 10: Reset het resultaat
                    else if(_keuze==3)
                    {
                        _resultaat = 0;
                        _aantalOgen = 0;
                        // Begeleiden gebruiker
                        Console.WriteLine("Uw resultaat en de dobbelsteen zijn gereset.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het menu");
                        Console.ReadKey();
                    }
                    //  •	Als 4
                    //  Stap 11: Toon afsluittekst
                    else if(_keuze==4)
                    {
                        Console.WriteLine("Bedankt om het meer dobbelstenen programma te gebruiken!");
                        Console.WriteLine("Druk op een toets om af te sluiten...");
                        Console.ReadKey();
                    }
                    // in elk ander geval
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();


                        // foutmelding
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het menu");
                        Console.ReadKey();
                    }
                   
                }
                catch 
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Ongeldige getal, probeer opnieuw.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het menu");
                    Console.ReadKey();
                }
            //  Stap 12: Als keuze niet 4 is , ga naar stap 2.
            } while (_keuze !=4);

        }
    }
}
