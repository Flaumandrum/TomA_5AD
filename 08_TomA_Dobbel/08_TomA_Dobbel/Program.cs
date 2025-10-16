using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TomA_Dobbel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaes 
            // 16/10/2025
            // project: Dobbelsteen

            // Velden 
            byte _keuze = 0;
            Random _random = new Random();
            byte _dobbelsteen = 0;

            // Programma

            // Stap 1: Intro
            Console.WriteLine("Welkom bij de dobbelsteensymulator."); 
            
            do {
                // Scherm wissen
                Console.Clear();

                // Stap 2: Toon Menu(Gooi dobbelsteen, Afsluiten)
                Console.WriteLine("Kies een optie uit onderstaand menu:");
                Console.WriteLine("   1. Gooi dobbelsteen");
                Console.WriteLine("   2. Afsluiten");

                // Stap 3: Vraag keuze + opslaan 
                Console.Write("\n\nUw keuze: ");
                try
                {
                    // Stap 4: 
                    //	Als(gooi)

                    //        Bepaal willekeurig getal van 1 t.e.m 6

                    //        Toon getal

                    //    Als(Afsluiten)

                    //        Toon afsluittekst
                }
                catch
                {
                    // scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("Fout: Ongeldige invoer.");
                    Console.WriteLine("Druk op een toets om terug te keren naar het menu.");
                    Console.ReadKey();
                }
                // Stap 4: Indien keuze niet afsluiten is, ga naar stap 1
            } while (_keuze != 2);

        }
    }
}
