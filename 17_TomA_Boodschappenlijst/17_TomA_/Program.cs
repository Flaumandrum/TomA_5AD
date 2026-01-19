using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17_TomA_Boodschappenlijst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 15/01/2026
            // Project Boodschappenlijst

            // Velden 
            Byte _keuze = 0, _nummer = 0;
            String[] _boodschappenlijst = new String[100];


            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 1: Toon keuzemenu(Toevoegen, aanpassen, verwijderen, tonen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("  1) Toevoegen\n  2) Aanpassen\n  3) Verwijderen\n" +
                    "  4) Toon\n  5) Afsluiten");

                try {
                    // Stap 2: Vraag keuze +opslaan
                    Console.Write("\nGeef het getal van uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    // Stap 3: 
                    //	Als keuze 1: Toevoegen
                    if (_keuze == 1)
                    {
                        int index = -1;

                        // Stap 4: overloop de array en zoek de eerste lege plaats + opslaan
                        for(int i = 0; i < _boodschappenlijst.Count(); i++)
                        {
                            if (_boodschappenlijst[i] == null)
                            {
                                index = i;
                                break;
                            }
                        }
                        // Stap 5: kijk of er een lege plaats is gevonden
                        if(index != -1)
                        {
                            // Als ja:
                            // Vraag de naam van het product +opslaan in vrije plaats van array           Als nee:
                            Console.Write("Geef de naam van het nieuwe product: ");
                            String naam = Console.ReadLine().ToLower();

                            _boodschappenlijst[index] = naam;

                            // Scherm leegmaken
                            Console.Clear();

                            // Gebruiker begeleiden
                            Console.WriteLine("Dit item werd toegevoegd.");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        else
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // Toon foutcode
                            Console.WriteLine("Er is geen lege plaats meer beschikbaar.");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }


                    }

                    //    Als keuze 2: 
                    else if(_keuze == 2)
                    {
                        
                        int index = -1;


                        // Stap 6: Vraag de naam van het product dat hij wilt veranderen +opslaan
                        Console.Write("Geef de naam van het product dat u wilt veranderen: ");
                        String product = Console.ReadLine().ToLower();
                        // Stap 7: Overloop de array en zoek de index van het product
                        for(int i = 0; i < _boodschappenlijst.Count();i++)
                        {
                            if (_boodschappenlijst[i] == product)
                            {
                                index = i;
                                break;
                            }
                        }
                        //        Stap 8: 
                        // Als het product is gevonden
                        if( index != -1)
                        {

                            // Vraag de naam van het product + opslaan op de juiste plaats
                            Console.Write("Geef de naam van het nieuwe product: ");
                            String naam = Console.ReadLine().ToLower();

                            _boodschappenlijst[index] = naam;

                            // Scherm leegmaken
                            Console.Clear();

                            // Gebruiker begeleiden
                            Console.WriteLine("Dit item werd aangepast.");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        //  Als het product niet wordt gevonden
                        else
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // Toon foutcode
                            Console.WriteLine("Dit item werd niet gevonden.");
                            Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                    }


                    // Als keuze 3:
                    else if (_keuze == 3)
                    {
                        
                        //	Stap 9: toon de array
                        Console.WriteLine("Hier zijn de items van uw boodschappenlijst:\n");

                        for(int i = 0; i<_boodschappenlijst.Count(); i++)
                        {
                            if (_boodschappenlijst[i] != null)
                            {
                                Console.WriteLine($"{(i+1).ToString()}:{_boodschappenlijst[i]}");
                            }
                        }

                        //  Stap 10: Vraag het nummer van het product dat hij wil verwijderen
                        Console.Write("\nGeef het nummer van het product dat u wilt verwijderen: ");
                        _nummer = (Byte)(Byte.Parse(Console.ReadLine())-1);

                        //  Stap 11 : verwijder het product
                        _boodschappenlijst[_nummer] = null;

                        //Scherm leegmaken 
                        Console.Clear();

                        // Begeleiden gebruiker
                        Console.WriteLine("Dit item werd gewist.");
                        Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                        Console.ReadKey();
                    }


                    //    Als keuze 4:
                    else if (_keuze == 4)
                    {
                       
                        //		Stap 12: Toon de array
                        Console.WriteLine("Hier zijn uw boodschappen:\n");
                        foreach(String s in _boodschappenlijst)
                        {
                            if(s != null)
                            {
                                Console.WriteLine(s);
                            }
                            
                        }
                        Console.WriteLine("\nDruk op enter om naar het hoofdmenu te gaan.");
                        Console.ReadKey();
                    }

                    //    Als keuze 5: 
                    else if (_keuze == 5)
                    {
                        //	Stap 13: toon de afsluittekst
                        Console.WriteLine("tot een volgende keer. ");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }

                    // in elk ander geval
                    else
                    {
                        // Toon foutcode
                        Console.WriteLine("U gaf geen juiste keuze in. ");
                        Console.WriteLine("\nDruk op enter om opnieuw te proberen.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // Toon foutcode
                    Console.WriteLine("U gaf geen juist getal in. ");
                    Console.WriteLine("\nDruk op enter om opnieuw te proberen.");
                    Console.ReadKey();
                }

            } while (_keuze != 5);

        }
    }
}
