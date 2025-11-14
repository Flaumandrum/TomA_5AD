using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12_TomA_WiskFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 14/11/2025
            // Wiskundige functies oef 46 tot 53

            // Velden 
            byte _keuze = 0;
            int _natGetal1 = 0, _natGetal2 = 0;
            uint _posGetal = 0;
            double _kommaGetal = 0.0, _straal= 0.0, _hoogte= 0.0;
            const double macht2 = 2.0;
            const double macht3 = 3.0;
            const double macht4 = 4.0;
            const int _aantalDecimalen = 2;

            // programma

            // Stap 1: intro
            Console.WriteLine("Welkom bij ons programma waarbij je verschillende wiskundige functies kunt uitvoeren!");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken
                Console.Clear();

                // Stap 2:  Toon menu(grootste of kleinste, teken en abs, afronden, macht, Vierkantswortel, Inhoud cilinder, afsluiten)
                Console.WriteLine("Kies een van de volgende opties door het bijhorende nummer in te geven:");
                Console.WriteLine("   1: Grootste of kleinste van 2 getallen");
                Console.WriteLine("   2: Teken en absolute waarde van een getal");
                Console.WriteLine("   3: Afronden van een kommagetal");
                Console.WriteLine("   4: Berekenen van machten");
                Console.WriteLine("   5: Berekenen van de vierkantswortel");
                Console.WriteLine("   6: Berekenen van de inhoud van een cilinder");
                Console.WriteLine("   7: Afsluiten van het programma");


                // Vang een eventuele fout op 
                try
                {

                    // Stap 3: Vraag keuze +opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Stap 4
                    //    Als 1: grootste of kleinste
                    if (_keuze == 1)
                    {
                        do
                        {
                            // scherm leegmaken
                            Console.Clear();
                            try
                            {
                                //        Stap 5: Vraag 2 getallen + opslaan
                                Console.Write("Geef het eerste natuurlijke getal: ");
                                _natGetal1 = Int32.Parse(Console.ReadLine());
                                Console.Write("Geef het tweede natuurlijke getal: ");
                                _natGetal2 = Int32.Parse(Console.ReadLine());

                                //        Stap 6: toon menu(kleinst, grootste )
                                Console.WriteLine("\n\nWelke bewerking wilt u uitvoeren?");
                                Console.WriteLine("   1) Zoek het grootste getal");
                                Console.WriteLine("   2) Zoek het kleinste getal ");

                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());
                                //        Stap 7: geef het juiste antwoord
                                if(_keuze == 1)
                                {
                                    Console.WriteLine($"\nHet grootste getal is: {Math.Max(_natGetal1, _natGetal2).ToString()}");
                                }
                                else
                                {
                                    Console.WriteLine($"\nHet kleinste getal is: {Math.Min(_natGetal1, _natGetal2).ToString()}");
                                }
                                Console.ReadKey();
                               
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");

                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());

                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu
                          
                            }

                        } while(true);
                    }

                    //    Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {
                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();
                            try
                            {
                                //        Stap 8: vraag getal +opslaan
                                Console.Write("Geef een natuurlijke getal: ");
                                _natGetal1 = Int32.Parse(Console.ReadLine());

                                //        Stap 9: Toon positief of negatief
                                Console.WriteLine($"\nHet getal {_natGetal1.ToString()} is {(Math.Sign(_natGetal1) >= 0 ? "positief" : "negatief")}.");
                                //        Stap 10: Toon absolute waarde
                                Console.WriteLine($"\nDe absolute waarde van {_natGetal1.ToString()} is {Math.Abs(_natGetal1).ToString()}.");
                                Console.ReadKey();
                            }
                            catch 
                            {                                 // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");
                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());
                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu
                            }
                        }
                        while (true);
                    }
                

                    //    Als 3: afronden
                    else if (_keuze == 3)
                    {
                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();
                            try
                            {

                                // Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma
                                Console.Write("Geef een kommagetal met minstens 3 cijfers na de komma: ");
                                _kommaGetal = Double.Parse(Console.ReadLine().Replace(",","."));


                                // Stap 12: Ga na of er 3 cijfers zijn na de komma
                                if(_kommaGetal.ToString().Length - _kommaGetal.ToString().IndexOf('.') - 1 >= 3)
                                { 
                                    // Stap 13: Toon het getal afgerond na de komma
                                    Console.WriteLine($"\nHet getal {_kommaGetal.ToString()} afgerond naar 2 cijfers na de komma is: {Math.Round(_kommaGetal, _aantalDecimalen).ToString()}");
                                    // Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal

                                    // Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven

                                }
                                else
                                {
                                    Console.WriteLine("Het getal heeft niet minstens 3 cijfers na de komma.");
                                    Console.WriteLine("Wilt u opnieuw proberen");
                                    Console.WriteLine("   1) Ja");
                                    Console.WriteLine("   2) Nee, terug naar hoofdmenu");
                                    Console.Write("\nUw keuze: ");
                                    _keuze = Byte.Parse(Console.ReadLine());
                                    if (_keuze == 2)
                                        break; // Verlaat de lus en gaat terug naar hoofdmenu
                                }

                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");

                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());

                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu

                            }
                        }
                        while (true);
                    }
                    //    Als 4: 	Macht
                    else if (_keuze == 4)
                    {
                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {

                            //        Stap 16: Vraag een getal + opslaan
                            Console.Write("Geef een natuurlijk getal: ");
                            _natGetal1 = Int32.Parse(Console.ReadLine());

                            //        Stap 17: Bereken de 2de, 3de en 4de macht + Stappen 18: Toon resultaat
                            Console.WriteLine($"\nDe 2de macht van {_natGetal1.ToString()} is: {Math.Pow(_natGetal1, macht2).ToString()}");
                            Console.WriteLine($"De 3de macht van {_natGetal1.ToString()} is: {Math.Pow(_natGetal1, macht3).ToString()}");
                            Console.WriteLine($"De 4de macht van {_natGetal1.ToString()} is: {Math.Pow(_natGetal1, macht4).ToString()}");

                            Console.WriteLine("\nDruk op een toets om verder te gaan.");
                            Console.ReadKey();

                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");
                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());
                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu
                            }
                        }
                        while (true);
                    }
                    //    Als 5: Vierkantswortel
                    else if (_keuze == 5)
                    {
                        do
                        {
                            try
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                //        Stap 19: Vraag een getal + opslaan
                                Console.Write("Geef een positief natuurlijk getal: ");
                                _posGetal = UInt32.Parse(Console.ReadLine());

                                //        Stap 20: Bereken de vierkantswortel + afronden + Stap 21: Toon resultaat
                                Console.WriteLine($"\nDe vierkantswortel van {_posGetal.ToString()} is: {Math.Round(Math.Sqrt(_posGetal), _aantalDecimalen).ToString()}");

                                       
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");
                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());
                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu
                            }
                        } while (true) ;
                    }
                    //    Als 6: Inhoud cilinder
                    else if (_keuze == 6)
                    {
                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {

                                //        Stap 22: Vraag straal van het bodemvlak + opslaan
                                Console.Write("Geef de straal van het bodemvlak van de cilinder: ");
                                _straal = Double.Parse(Console.ReadLine().Replace(",", "."));

                                //        Stap 23: Vraag hoogte van de cilinder + opslaan
                                Console.Write("Geef de hoogte van de cilinder: ");
                                _hoogte = Double.Parse(Console.ReadLine().Replace(",", "."));

                                //        Stap 24: maak de berekening voor inhoud en omtrek, rond af tot 2 cijfers na de komma +toon resultaat
                                double oppCirkel = Math.PI * Math.Pow(_straal, macht2);
                                double inhoud = oppCirkel * _hoogte;
                                double omtrek = 2 * oppCirkel + 2 * _straal * Math.PI*_hoogte;
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();
                                // foutmelding 
                                Console.WriteLine("\nEr is een fout opgetreden.");
                                Console.WriteLine("Wilt u opnieuw proberen");
                                Console.WriteLine("   1) Ja");
                                Console.WriteLine("   2) Nee, terug naar hoofdmenu");
                                Console.Write("\nUw keuze: ");
                                _keuze = Byte.Parse(Console.ReadLine());
                                if (_keuze == 2)
                                    break; // Verlaat de lus en gaat terug naar hoofdmenu
                            }
                        } while (true);
                    }
                    //    Als 7 :
                    else if (_keuze == 7)
                    {
                        // Stap 25: Toon afsluittekst
                        Console.WriteLine("\nBedankt voor het gebruiken van ons programma! Tot ziens.");
                        break; // Verlaat de lus en beëindigt het programma
                    }
                    // In elk ander geval
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze. Probeer opnieuw.");
                    }

                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // foutmelding 
                    Console.WriteLine("\nEr is een fout opgetreden. Probeer opnieuw.");
                    Console.WriteLine("Druk op een toets om verder te gaan.");
                    Console.ReadKey();
                    
                }

            }
            // Stap 26: Als keuze niet 7 is: ga terug naar stap 2
            while (_keuze != 7);

        }
    }
}
