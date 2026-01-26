using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TomA_Temperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 20/01/2026
            // Project temperatuur

            // Velden 
            double[] _temperaturen = new double[0];
            Byte _keuze = 0;

            // programma 
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 1:  Toon keuzemenu(start het programma, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Start ");
                Console.WriteLine("   2) Afsluiten");
                try
                {
                    // Stap 2: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    // Stap 3: 
                    //	Als  1
                    if (_keuze == 1)
                    {
                        // Stap 4: Vraag van hoeveel dagen hij de temperatuur wilt opslaan + opslaan
                        Console.Write("Voor hoeveel dagen wilt u de temperatuur opslaan?");
                        Byte aantalDagen = Byte.Parse(Console.ReadLine());

                        //  Stap 5: Pas de array aan
                        _temperaturen = new double[aantalDagen];

                        // Scherm leegmaken 
                        Console.Clear();

                        // Stap 6: vraag de gebruiker om de temperaturen in te geven
                        for (int i = 0; i < _temperaturen.Count(); i++)
                        {
                            do {
                                try 
                                { 
                                    Console.Write($"Geef de temperatuur van dag {(i + 1).ToString()}: ");
                                    _temperaturen[i] = Double.Parse(Console.ReadLine().Replace(".",","));
                                    break;
                                }
                                catch { }
                            } while (true);
                        }

                        

                        // Begeleiden van de gebruiker
                        Console.WriteLine("\nBedankt voor uw invoer.");
                        Console.WriteLine("\nDruk op enter om verder te gaan.");
                        Console.ReadKey();

                        // Scherm leegmaken 
                        Console.Clear();

                        double gemiddelde = 0;
                        // Stap 7: Bereken het gemiddelde + opslaan
                        foreach(double d in _temperaturen)
                        {
                            gemiddelde += d;
                            
                        }
                        gemiddelde = gemiddelde / Convert.ToDouble(_temperaturen.Count());

                        // Stap 8: Bereken het aantal dagen boven het gemiddelde + opslaan
                        int aantal = 0;
                        foreach (double d in _temperaturen)
                        {
                            if (d > gemiddelde)
                            {
                                aantal++;
                            }

                        }
                        // Stap 9: Bereken de warmste dag +opslaan
                        double maxTem = _temperaturen.Max();

                        double max = 0;
                        foreach (double d in _temperaturen)
                        {
                            if (d > max)
                            {
                                max = d;
                            }

                        }

                        double min = _temperaturen[0];
                        foreach (double d in _temperaturen)
                        {
                            if (d < max)
                            {
                                min = d;
                            }

                        }
                        // Stap 10: Bereken de koudste dag +opslaan
                        double minTem = _temperaturen.Min();

                        //  Stap 11:  Toon het resultaat

                        Console.WriteLine("Hier zijn de uitkomsten: ");
                        Console.WriteLine($"gemiddelde temperatuur: {gemiddelde.ToString()}");
                        Console.WriteLine($"aantal dagen boven gemiddelde: {aantal.ToString()}");
                        Console.WriteLine($"maximale temperatuur: {maxTem.ToString()}");
                        Console.WriteLine($"minimale temperatuur: {minTem.ToString()}");

                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //    Als 2
                    else if (_keuze == 2)
                    {
                        // Stap 12: Toon de afsluittekst
                        Console.WriteLine("Tot een volgende keer!");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }

                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // Foutmelding
                        Console.WriteLine("U gaf geen juste keuze in!");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
                //Stap 13: Als de keuze niet 2 is , ga terug naar stap 1
            } while (_keuze != 2);
        }
    }
}
