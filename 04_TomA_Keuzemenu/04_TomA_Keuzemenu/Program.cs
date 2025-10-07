using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TomA_Keuzemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 02/10/2025
            // Project Keuzemenu

            // Velden
            Boolean _herhalen = true;
            byte _keuze = 0;

            // Programma
            do
            {
                // scherm leegmaken
                Console.Clear();

                // toon menu
                Console.WriteLine("Maak een keuze uit het menu:");
                Console.WriteLine("\n1. zeg hallo\n2. afsluiten");
                Console.Write("\n\nGeef uw keuze in: ");

                try 
                {
                    // Vang invoer op en zet om naar Byte
                    _keuze = Convert.ToByte(Console.ReadLine());

                    // scherm leegmaken
                    Console.Clear();

                    if (_keuze == 1) 
                    {
                        // Groet de gebruiker
                        Console.WriteLine("\nHallo, gebruiker!");

                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();

                    }
                    else if (_keuze == 2) 
                    { 
                        // stopt de lus
                        _herhalen = false; 
                    }
                    else
                    {
                        // Foutmelding bij ongeldige keuze
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // scherm leegmaken
                    Console.Clear();

                    // Foutmelding bij ongeldige keuze
                    Console.WriteLine("Foutieve invoer, probeer opnieuw.");
                    Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            while (_herhalen);
        }
    }
}
