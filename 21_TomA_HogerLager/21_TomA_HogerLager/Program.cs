using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_TomA_HogerLager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 10/02/2026
            // Hoger Lager

            // Velden
            Byte _keuze = 0;
            int[] _topScores = new int[5];
            Random _rdm = new Random();
            int _score = 0;
            

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 1: Toon het keuzemenu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Toon highscores\n   2) Start het spel\n   3) Afsluiten");

                try
                {

                    // Stap 2: Vraag de keuze + opslaan(topscores zien, spelspelen, afsluiten)
                    Console.Write("uw keuze:");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();
                                      
                    // Stap 3:
                    //	Als 1: 
                    if (_keuze == 1)
                    {
                        Array.Sort(_topScores);
                        Array.Reverse(_topScores);

                        // Stap 4: Toon de 5 topscores
                        for (int i = 0; i < _topScores.Count(); i++)
                        {
                            if(_topScores[i] != 0)
                            {
                                Console.WriteLine($" {(i + 1).ToString()}) {_topScores[i]} ");
                            }
                            else
                            {
                                Console.WriteLine($" {(i + 1).ToString()}) Leeg ");
                            }
                            
                        }

                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //    Als 2: 
                    else if (_keuze == 2)
                    {
                        // Score resetten 
                        _score = 0;

                        int volgendGetal = 0,  vorig = 0;
                        volgendGetal = _rdm.Next(1, 14);
                        
                        for(int i = 3; i > 0; i--)
                        {
                            do
                            {

                                // Scherm leegmaken 
                                Console.Clear();

                                // Maak een willekeurig getal
                                vorig = volgendGetal;

                                Console.WriteLine($"Huidig getal: {vorig.ToString()}");

                                do
                                {
                                    volgendGetal = _rdm.Next(1, 14);

                                } while (volgendGetal == vorig);

                                //  Stap 6: Vraag hoger of lager
                                Console.WriteLine("Wat denk je dat het volgende getal zal zijn:");
                                Console.WriteLine("\n   1) Hoger\n   2) Lager");
                                Console.Write("uw keuze:");
                                _keuze = Byte.Parse(Console.ReadLine());

                                // Vergelijk of de keuze juist was
                                //  Als juist:
                                //	Stap 7: Geef een punt + ga terug naar stap  5

                                if ((_keuze == 1 && vorig < volgendGetal) || (_keuze == 2 && vorig > volgendGetal))
                                {
                                    _score++;
                                }
                                
                                // Als fout:
                                else
                                {

                                    Console.WriteLine("Dit was fout, hopelijk heef u nog levens.");
                                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                                    Console.ReadKey();
                                    break; 
                                }

                            }
                            while (true);
                        }

                        // Scherm leegmaken 
                        Console.Clear();

                        // Als aantal fouten 4 is
                        Console.WriteLine("Blijkbaar waren uw levens op.");
                        Console.WriteLine($"uw score: {_score.ToString()}");

                        Array.Sort(_topScores);
                        Array.Reverse(_topScores);
                        
                        // Stap 10: overloop topscores om te zien of score hoger is

                        foreach(int i in _topScores)
                        {
                            //    Als hoger:
                            if (i < _score)
                            {
                                //		Stap 11: Voeg Toe in array
                                _topScores[_topScores.Last()] = _score;
                                Console.WriteLine("U heeft wel een topscore!");
                                
                                break;
                            }


                        }
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //        Als 3: 
                    //		Stap 13: Toon afsluittekst
                    else if  (_keuze == 3)
                    {
                        // afsluittekst 
                        Console.WriteLine("Tot een volgende keer .");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                
                    else
                    {
                        
                        // foutcode 
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutcode 
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }
                // Stap 14: Als de keuze niet 3 is, ga terug naar stap 1
            }
            while (_keuze != 3);
        }
    }
}
