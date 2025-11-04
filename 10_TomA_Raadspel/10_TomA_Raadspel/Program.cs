using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _10_TomA_Raadspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adraens
            // 04/11/2025
            // Raadspel

            // Velden
            byte _keuze = 0;

            // Programma
            // Stap 1: Intro
            Console.WriteLine("Welkom bij het raadspel!");
            Console.WriteLine("druk op een toets om te beginnen...");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken
                Console.Clear();

                //  Stap 2: Toon keuzemenu(speel spel, afsluiten)
                Console.WriteLine("Kies een optie:");
                Console.WriteLine("   1. Speel spel");
                Console.WriteLine("   2. Afsluiten");

                try
                {

                    // Vraag keuze van de gebruiker
                    Console.Write("Uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //  Stap 3: behandel keuze
                    //	Als 1: Speel spel
                    if (_keuze == 1)
                    {
                        //  Stap 4: maak een geheim getal
                        Random rnd = new Random();
                        int geheimGetal = rnd.Next(1, 101); // Getal tussen 1 en 100

                        // Stap 5: geef de gebruiker 5 kansen om het getal te raden
                        for(int i = 5;i > 0; i--)
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            // Vraag het raadgetal van de gebruiker
                            Console.Write("Raad het geheime getal (1-100): ");
                            Byte raadGetal = Byte.Parse(Console.ReadLine());

                            // Als 1: het raadgetal van de gebruiker is hoger dan het geheime getal
                            
                            if(raadGetal > geheimGetal)
                            {
                                // Toon tekst: getal is lager
                                Console.WriteLine("Jouw getal is te hoog!");
                                Console.WriteLine("Je hebt nog " + (i - 1).ToString() + " kansen over.");
                                Console.WriteLine("Druk op een toets om verder te gaan...");
                                Console.ReadKey();
                            }

                            // Als 2: het raadgetal van de gebruiker is lager dan het geheime getal
                            else if(raadGetal < geheimGetal)
                            {
                                // Toon tekst: getal is hoger
                                Console.WriteLine("Jouw getal is te laag!");
                                Console.WriteLine("Je hebt nog " + (i - 1).ToString() + " kansen over.");
                                Console.WriteLine("Druk op een toets om verder te gaan...");
                                Console.ReadKey();
                            }

                            //  Als 3: de gebruiker raad het getal
                            else if(raadGetal == geheimGetal)
                            {
                                // Toon: proficiat en het aantal raadkansen + stop de lus
                                Console.WriteLine("Proficiat! Je hebt het getal geraden: " + geheimGetal.ToString());
                                Console.WriteLine("Je had nog " + (i - 1).ToString() + " kansen over.");
                                Console.WriteLine("Druk op een toets om verder te gaan...");
                                Console.ReadKey();
                                break;
                            }


                            //  Als 4: de stappen zijn op en het getal is niet geraden
                            if(i - 1 == 0)
                            {
                                //  Toon: jammer! Jouw kansen zijn op . het getal was X
                                Console.WriteLine("Jammer! Je kansen zijn op.");
                                Console.WriteLine("Het geheime getal was: " + geheimGetal.ToString());
                                Console.WriteLine("Druk op een toets om verder te gaan...");
                                Console.ReadKey();
                            }
                            
                        }


                    }

                    //    Als 2: Afsluiten: 
                    else if (_keuze == 2)
                    {
                       // Toon afsluittekst
                        Console.WriteLine("Bedankt voor het spelen! Tot ziens.");
                        Console.WriteLine("Druk op een toets om af te sluiten...");
                        Console.ReadKey();
                    }

                    // elk ander geval
                    else 
                    {                         
                        // scherm leegmaken
                        Console.Clear();

                        // foutmelding tonen
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw...");
                        Console.WriteLine("Druk op een toets om verder te gaan...");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // scherm leegmaken
                    Console.Clear();

                    // foutmelding tonen
                    Console.WriteLine("Ongeldige invoer, probeer opnieuw...");
                    Console.WriteLine("Druk op een toets om verder te gaan...");
                    Console.ReadKey();
                }
                // Stap: indien keuze niet 2, ga terug naar stap 2
            }
            while (_keuze != 2);
            

        }
    }
}
