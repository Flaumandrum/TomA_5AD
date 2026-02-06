using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _19_TomA_Proj_Reisorganisatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 26/01/2026
            // Project reisorganisatie

            // Velden 
            Byte _keuze = 0;
            String[] _voornamen = new string[20], _achternamen = new string[20];
            TextInfo _info = CultureInfo.CurrentCulture.TextInfo;

            // Programma
            //Stap 1: Intro
            Console.WriteLine("Welkom in dit programma waarmee je de inschrijvingen van een reis kan bijhouden.");
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon keuzemenu(Inschrijven, inloggen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Inschrijven \n   2) Inloggen als werknemer\n   3) Afsluiten");


                try
                {

                    //Stap 3: Vraag keuze +opslaan.
                    Console.Write("\nGeef het getal van uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 4:
                    //	Als 1: Inschrijven
                    if (_keuze ==  1)
                    {
                        // Maak een controle getal 
                        int legePlaats = -1;

                        // Stap 5: Zoek een lege plaats +opslaan
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            if (_voornamen[i] == null)
                            {
                                legePlaats = i;
                                break;
                            }
                        }

                        // Als lege plaats gevonden
                        if(legePlaats != -1)
                        {
                            // Stap 6: Vraag voornaam +opslaan
                            Console.Write("Geef de voornaam: ");
                            _voornamen[legePlaats] = _info.ToTitleCase((Console.ReadLine().Trim().ToLower()));
                            // Stap 7: Vraag achternaam +opslaan
                            Console.Write("Geef de achternaam: ");
                            _achternamen[legePlaats] = _info.ToTitleCase(Console.ReadLine().Trim().ToLower());

                            // Scherm leegmaken
                            Console.Clear();

                            // Foutcode:
                            Console.WriteLine("Deze persoon werd toegevoegd");
                            Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                        // Als niet gevonden
                        else
                        {
                            // Stap 8: Toon foutcode
                            Console.WriteLine("Er werd geen lege plaats gevonden");
                            Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                            Console.ReadKey();
                        }


                    }

                    //    Als 2: Toon acties werknemer
                    else if(_keuze == 2)
                    {
                        // Stap 9: Vraag wachtwoord
                        Console.Write("\nGeef het wachtwoord in: ");
                        String ontvWw = Console.ReadLine();

                        // Als correct: 
                        if(ontvWw == "test123")
                        {
                            do
                            {
                                //Scherm leegmaken 
                                Console.Clear();

                                try
                                {
                                    // toon WN menu
                                    //Stap 2: Toon keuzemenu(Inschrijven, Tonen, afsluiten)
                                    Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                                    Console.WriteLine("\n   1) Lijst tonen \n   2) Aanpassen\n   3) Verwijderen\n   4) naar hoofdmenu");


                                    //Stap 3: Vraag keuze +opslaan.
                                    Console.Write("\nGeef het getal van uw keuze: ");
                                    _keuze = Byte.Parse(Console.ReadLine());

                                    // Scherm leegmaken
                                    Console.Clear();

                                    //Stap 4:
                                    //	Als 1: Inschrijven
                                    if (_keuze == 1)
                                    {
                                       

                                        // Stap 10: Toon de lijst
                                        for (int i = 0; i < _voornamen.Count(); i++)
                                        {
                                            if (_voornamen[i] == null)
                                            {
                                                Console.WriteLine($"{(i + 1).ToString()}) leeg");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i] } {_achternamen[i]}");
                                            }


                                        }
                                        Console.WriteLine("\nDruk op een toets om verder te gaan naar het werknemersmenu.");
                                        Console.ReadKey();
                                    }

                                    // Als 2: Aanpassen
                                    else if (_keuze == 2)
                                    {
                                        // Vraag de naam om aan te passen 
                                        Console.WriteLine("Geef de voornaam van de persoon die je wil aanpassen: " );
                                        String oudeVnaam = _info.ToTitleCase((Console.ReadLine().Trim().ToLower()));
                                        Console.Write("Geef de achternaam van de persoon die je wil aanpassen: ");
                                        String oudeAnaam = _info.ToTitleCase((Console.ReadLine().Trim().ToLower())); ;


                                        // Overloop de array om de naam te zoeken
                                        int gevonden = -1;

                                        for (int i = 0; i < _voornamen.Count(); i++)
                                        {
                                            if (_voornamen[i] == oudeVnaam && _achternamen[i] == oudeAnaam)
                                            {
                                                gevonden = i;
                                                break;

                                            }
                                            
                                        }

                                        //Scherm leegmaken 
                                        Console.Clear();

                                        if (gevonden != -1)
                                        {
                                            Console.WriteLine("Geef de nieuwe voornaam: ");
                                            String nieuweVnaam = _info.ToTitleCase((Console.ReadLine().Trim().ToLower())); ;
                                            Console.Write("Geef de nieuwe achternaam: ");
                                            String nieuweAnaam = _info.ToTitleCase((Console.ReadLine().Trim().ToLower())); ;

                                            _voornamen[gevonden] = nieuweVnaam;
                                            _achternamen[gevonden] = nieuweAnaam;

                                            //Scherm leegmaken 
                                            Console.Clear();

                                            Console.WriteLine("Deze persoon werd aangepast");
                                            Console.WriteLine("Druk op enter om terug te keren naar het werknemersmenu.");
                                            Console.ReadKey();

                                        }
                                        else
                                        {
                                            // foutmelding
                                            Console.Clear();
                                            Console.WriteLine("Deze persoon werd niet gevonden ");
                                            Console.WriteLine("Druk op enter om terug te keren naar het werknemersmenu.");
                                            Console.ReadKey();
                                        }
                                    }

                                    // als 3 : Verwijderen
                                    else if (_keuze == 3)
                                    {
                                        // Stap 10: Toon de lijst
                                        for (int i = 0; i < _voornamen.Count(); i++)
                                        {
                                            if (_voornamen[i] == null)
                                            {
                                                Console.WriteLine($"{(i + 1).ToString()}) leeg");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i]} {_achternamen[i]}");
                                            }


                                        }

                                        Console.Write("Geef het nummer in van de persoon die u wilt verwijderen: ");
                                        int indexPersoon = int.Parse(Console.ReadLine()) - 1;

                                        //Scherm leegmaken 
                                        Console.Clear();

                                        _voornamen[indexPersoon] = null;
                                        _achternamen[indexPersoon] = null;

                                        Console.WriteLine("Deze persoon werd verwijderd");
                                        Console.WriteLine("Druk op enter om terug te keren naar het werknemersmenu.");
                                        Console.ReadKey();

                                    }

                                    // Als 4 Afsluiten 
                                    else if (_keuze == 4)
                                    {
                                        Console.WriteLine("\nDruk op een toets, u keer terug naar het hoofdmenu.");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        // Foutcode:
                                        Console.WriteLine("U gaf geen juiste keuze in.");
                                        Console.WriteLine("\nDruk op een toets om verder te gaan naar het werknemersmenu.");
                                        Console.ReadKey();
                                    }

                                }
                                catch
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutcode:

                                    Console.WriteLine("U gaf geen juist getal in.");
                                    Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                                    Console.ReadKey();
                                }

                            } while (_keuze != 4);
                        }

                        // Als Fout:
                        else
                        {
                            // Stap 11: toon foutcode
                            Console.WriteLine("het wachtwoord was niet juist.");
                            Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                            Console.ReadKey();
                        }


                    }

                    // Als 3: Afsluiten
                    else if (_keuze == 3)
                    {
                        // Stap 12: Toon afsluittekst
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                        Console.ReadKey();
                    }

                    // in elk ander geval
                    else
                    {
                        // Foutcode:
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                        Console.ReadKey();
                    }


                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // Foutcode:

                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("\nDruk op een toets om verder te gaan naar het hoofdmenu.");
                    Console.ReadKey();
                }



            }//Stap 13: Als de keuze niet 3 is, keer terug naar stap 2
            while (_keuze != 3);




        }
    }
}
