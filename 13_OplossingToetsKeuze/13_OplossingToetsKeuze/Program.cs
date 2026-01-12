using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _13_OplossingToetsKeuze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 04/12/2025
            // Toets keuzestructuur

            // Velden 
            String _naam = "";
            Byte _keuze = 0;
            Byte _getal1 = 0;
            Byte _getal2 = 0;
            Byte _uitkomst = 0;
            const Byte _dertig = 30;
            const Byte _tien = 10;

            // Programma

            //  Stap 1: Intro
            Console.WriteLine("Welkom bij het wiskunde oefenprogramma!");
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();

            do 
            { 
                // scherm wissen
                Console.Clear();

                // Stap 2: Toon menu(Oplossen wiskundige oefening, Afsluiten)
                Console.WriteLine("Kies een optie:");
                Console.WriteLine("1. Oplossen wiskundige oefening");
                Console.WriteLine("2. Afsluiten");

                try
                {

                    // Stap 3: Vraag keuze +opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // scherm wissen
                    Console.Clear();

                    // Stap 4: 
                    //	Als 1: (oefeningen maken)

                    if (_keuze == 1) 
                    {
                        //	Stap 5: Vraag naam +opslaan
                        Console.Write("Voer uw naam in: ");
                        _naam = Console.ReadLine();

                        //        Stap 6 : Vraag eerste getal + opslaan
                        Console.Write("Voer het eerste getal in (kleiner dan 10): ");
                        _getal1 = Byte.Parse(Console.ReadLine());


                        // Stap 7: is het getal kleiner dan 10
                        //  Als JA :  
                        if (_getal1 < 10)
                        {
                            
                            // Stap 8 : Vraag tweede getal + opslaan
                            Console.Write("Voer het tweede getal in (kleiner dan 10): ");
                            _getal2 = Byte.Parse(Console.ReadLine());

                            // Stap 7: is het getal kleiner dan 10

                            //  Als Ja:
                            if (_getal2 < 10)
                            {
                                //	Stap 8 : maak de berekening + opslaan
                                _uitkomst = (Byte)((_getal1 * _getal2) + _dertig -_tien);

                                // scherm wissen
                                Console.Clear();

                                Console.WriteLine($"Dag {_naam}!");
                                Console.WriteLine($" Het uiteindelijke resultaat is: {_uitkomst.ToString()}");


                                //  Stap 9: bekijk het resultaat en geef de juiste tekst
                                if (_uitkomst >= 100)
                                {
                                    Console.WriteLine("Dit is groter of gelijk aan 100.");

                                }
                                else if (_uitkomst >= 50)
                                {
                                    Console.WriteLine("Dit is groter of gelijk aan 50 maar kleiner dan 100.");
                                }
                                else
                                {
                                    Console.WriteLine("Dit is kleiner dan 50.");

                                }

                                Console.WriteLine("Druk op een toets om terug te keren naar het menu...");
                                Console.ReadKey();
                            }
                            //  Als nee:
                            else
                            {
                                // scherm wissen
                                Console.Clear();

                                // Stap 10: Toon foutmelding +ga naar menu
                                Console.WriteLine("Foutmelding: Het eerste getal moet kleiner zijn dan 10.");
                                Console.WriteLine("Druk op een toets om terug te keren naar het menu...");
                                Console.ReadKey();
                            }

                        }

                        // Als Nee: 
                        else
                        {
                            // scherm wissen
                            Console.Clear();

                            // Stap 10: Toon foutmelding +ga naar menu
                            Console.WriteLine("Foutmelding: Het eerste getal moet kleiner zijn dan 10.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het menu...");
                            Console.ReadKey();
                        }

                    }

                    //    Als 2: Afsluiten
                    else if (_keuze == 2)
                    {
                        // scherm wissen
                        Console.Clear();

                        // Stap 12: Toon afsluittekst
                        Console.WriteLine("Bedankt voor het gebruiken van het wiskunde oefenprogramma. Tot ziens!");
                        Console.WriteLine("Druk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }
                    else
                    {
                        // scherm wissen
                        Console.Clear();
                        // foutmelding bij verkeerde invoer
                        Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
                        Console.WriteLine("Druk op een toets om terug te keren naar het menu...");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // scherm wissen
                    Console.Clear();

                    // foutmelding bij verkeerde invoer
                    Console.WriteLine("Ongeldige invoer. Probeer het opnieuw.");
                    Console.WriteLine("Druk op een toets om terug te keren naar het menu...");
                    Console.ReadKey();
                }
                //Stap 13: als keuze niet 2 is, ga naar hoofdmenu

            } while (_keuze != 2);


        }
    }
}
