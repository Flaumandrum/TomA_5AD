using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _22_TomA_Brandveiligheid
{
    internal class Program
    {
        // Tom Adriaens
        // 26/02/2026
        // Project Brandveiligheid

        // Velden 
        static Byte _keuze = 0;
        static String[] _namen = new string[15];

        // GUI
        static void Main(string[] args)
        {
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                try
                {
                    // Toon keuzemenu
                    Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                    Console.WriteLine("   1) Inschrijven\n   2) Uitschrijven" +
                        "\n   3) Toon Lijst\n   4) Zoek op naam\n   5) Afsluiten");
                    
                    // Vraag keuze + opslaan
                    Console.Write("\n\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    // Als 1: Inschrijven 
                    if (_keuze == 1)
                    {
                        // zoek legeplaats + opslaan
                        int plaats = ZoekLegePlaats();

                        // Als legeplaats gevonden 
                        if(plaats != -1)
                        {

                            // Vraag volledige naam + opslaan
                            Console.Write("Geef uw volledige naam: ");
                            string naam = Console.ReadLine();

                            // Voeg naam toe
                            Opslaan(plaats, naam);

                            // Begeleiden gebruiker 
                            Console.WriteLine("Deze naam werd opgeslagen.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                        // Als niet gevonden
                        else
                        {
                            // Toon foutmelding
                            Console.WriteLine("Er is geen lege plaats meer.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();

                        }
                    }
                    // Als 2: Uitschrijven.
                    else if (_keuze == 2)
                    {
                        // Vraag volledige naam + opslaan
                        Console.Write("Geef de volledige naam van de persoon die u wilt uitschrijven: ");
                        string naam = Console.ReadLine();

                        // zoek legeplaats + opslaan
                        int plaats = ZoekInArray(naam);

                        // Als legeplaats gevonden 
                        if (plaats != -1)
                        {
                            // Voeg naam toe
                            Verwijder(plaats);

                            // Begeleiden gebruiker 
                            Console.WriteLine("Deze naam werd verwijderd.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                        // Als niet gevonden
                        else
                        {
                            // Toon foutmelding
                            Console.WriteLine("Deze naam werk niet gevonden.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();

                        }
                    }
                    // Als 3: Toon lijst
                    else if (_keuze == 3)
                    {
                        // toon de namen op het scherm
                        Console.WriteLine(GeefNamenDoor());

                        // Begeleid de gebruiker
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                    // Als 4: Zoek op naam 
                    else if (_keuze == 4)
                    {
                        // Vraag volledige naam + opslaan
                        Console.Write("Geef de volledige naam van de persoon die u wilt zoeken: ");
                        string naam = Console.ReadLine();

                        // zoek legeplaats + opslaan
                        int plaats = ZoekInArray(naam);

                        // Als legeplaats gevonden 
                        if (plaats != -1)
                        {
                            // Begeleiden gebruiker 
                            Console.WriteLine("Deze persoon is aanwezig.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                        // Als niet gevonden
                        else
                        {
                            // Toon foutmelding
                            Console.WriteLine("Deze naam werd niet gevonden.");
                            Console.WriteLine("Deze persoon is afwezig.");
                            Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();

                        }
                    }
                    // Als 5: Afsluiten 
                    else if (_keuze == 5)
                    {
                        // afsluittekst 
                        Console.WriteLine("Tot de volgende keer.");
                        Console.WriteLine("Druk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }
                    // In elk ander geval
                    else
                    {
                        // foutmelding 
                        Console.WriteLine("U gaf geen geldige keuze in.");
                        Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding 
                    Console.WriteLine("U gaf geen geldig getal in.");
                    Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }
            }
            while (_keuze != 5);
        }

        // Business - Functies
        /// <summary>
        /// Zoekt een legen plaats in de array
        /// </summary>
        /// <returns></returns>
        static int ZoekLegePlaats()
        {
            // maak een controle variabele aan
            int antwoord = -1;

            // Overloop de array
            for(int i = 0; i< _namen.Count();i++)
            {
                // vergelijk of de plaats leeg is
                if (_namen[i] == null)
                {
                    // Als de plaats leeg is, sla de nummer (index) van de plaats
                    // op in de controle variabele
                    antwoord = i;

                    // Als je een lege plaats hebt gevonden mag de lus stoppen
                    break;
                }
            }

            return antwoord;
        }

        static void Opslaan(int index, String naam)
        {
            // neem in de array de lege plaats die werd gevonden 
            // sla er de naam in op
            _namen[index] = naam;
        }

        static int ZoekInArray(String naam)
        {
            // maak een controle variabele aan
            int antwoord = -1;

            // Overloop de array
            for (int i = 0; i < _namen.Count(); i++)
            {
                // vergelijk of de plaats leeg is
                if (_namen[i] == naam)
                {
                    // Als de plaats leeg is, sla de nummer (index) van de plaats
                    // op in de controle variabele
                    antwoord = i;

                    // Als je een lege plaats hebt gevonden mag de lus stoppen
                    break;
                }
            }

            return antwoord;
        }

        static void Verwijder(int index)
        {
            // neem in de array de plaats waar de naam werd gevonden 
            // sla er niets in op 
            _namen[index] = null;
        }

        static String GeefNamenDoor()
        {
            string antwoord = "";

            for(int i = 0; i < _namen.Count(); i ++)
            {
                //antwoord += _namen[i]+"\n";
                antwoord += _namen[i]+Environment.NewLine;
            }

            return antwoord;
        }
    }
}
