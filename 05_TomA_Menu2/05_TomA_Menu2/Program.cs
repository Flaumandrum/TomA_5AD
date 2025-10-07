using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tom Adriaens
// 07/10/2025
// Oefening 23: Project Menu2
namespace _05_TomA_Menu2
{
     

    internal class Program
    {
        static void Main(string[] args)
        {
            // Velden 
            int _getal1 = 0, _getal2 = 0, _resultaat = 0;
            byte _keuze = 0;

            // Programma
            // Stap 1: Intro
            Console.WriteLine("Welkom bij deze rekenoefening!");
            Console.WriteLine("\nDruk op een toets om te starten...");
            Console.ReadKey();

            
            do
            {

                // Scherm leegmaken
                Console.Clear();
                try 
                { 
                    // Stap 2: vraag getal 1 + opslaan
                    Console.Write("Geef een eerste getal: ");
                    _getal1 = int.Parse(Console.ReadLine());

                    // Stap 3: vraag getal 2 + opslaan
                    Console.Write("Geef een tweede getal: ");
                    _getal2 = int.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    // Stap 4: Toon het keuzemenu(optellen, verminderen, vermenigvuldigen, afsluiten)
                    Console.WriteLine("\nKies een bewerking:");
                    Console.WriteLine("\n   1. Optellen\n   2. Verminderen\n   3. Vermenigvuldigen\n   4. Afsluiten");

                    // Stap 5: Vraag de keuze + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    // Stap 6: 
                    //	Als optellen:
                    if (_keuze == 1)
                    {
                        //		Tel getal 1 en 2 op
                        _resultaat = _getal1 + _getal2;
                    }

                    //    Als verminderen:
                    else if (_keuze == 2)
                    {
                        //        Verminder getal 2 van getal 1
                        _resultaat = _getal1 - _getal2;
                    }

                    //    Als vermenigvuldigen
                    else if (_keuze == 3)
                    {
                        //        Vermenigvuldig getal 1 met getal 2
                        _resultaat = _getal1 * _getal2;
                    }

                    //    Als afsluiten
                    else if (_keuze == 4)
                    {
                        //        Stop het programma
                        Console.WriteLine("Bedankt om dit programma te gebruiken! \n\nDruk op een toets om af te sluiten...");
                        Console.ReadKey();
                    }

                    else 
                    {
                        //        Foutmelding
                        Console.WriteLine("Ongeldige keuze! \n\nDruk op een toets en probeer opnieuw.");
                        Console.ReadKey();
                    }
                    // Stap 7: Toon resultaat
                    if(_keuze<4)
                    {
                        // Toon resultaat
                        Console.WriteLine($" Uw uitkomst : {_resultaat}");
                        Console.WriteLine("\n\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                     
                    // Scherm leegmaken
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Foutieve invoer! \n\nDruk op een toets en probeer opnieuw.");
                    Console.ReadKey();
                }
                // Stap 8: indien keuze niet 4 is: ga naar stap 2
            } while (_keuze != 4);
        }
    }
}
