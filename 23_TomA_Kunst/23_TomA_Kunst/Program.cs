using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _23_TomA_Kunst
{
    internal class Program
    {
        // Tom Adriaens
        // 09/03/2026
        // Project Kunst

        // Velden
        static String[] _kunstwerken = new String[25];
        static String[] _artisten = new String[25];
        static Double[] _prijzen = new Double[25];
        static Byte _keuze = 0;

        // GUI
        static void Main(string[] args)
        {
            do
            {
                //Scherm leegmaken
                Console.Clear();

                //Toon menu: (Toevoegen, aanpassen, verwijderen, tonen, zoeken, willekeurig werk, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("   1) Toevoegen\n   2) Aanpassen");
                Console.WriteLine("   3) Verwijderen\n   4) Tonen\n   5) Zoeken ");
                Console.WriteLine("   6) Willekeurig werk\n   7) Afsluiten");
                
                try
                {

                    //Vraag keuze + opslaan
                    Console.Write("Het getal van uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //Scherm leegmaken
                    Console.Clear();

                    //Als Toevoegen
                    if (_keuze == 1)
                    {
                        //•	Zoek of er plaats is +opslaan
                        int plaats = ZoekInArray(null);

                        //•	Als plaats:
                        if (plaats != -1)
                        {
                            //o Vraag naam kustwerk, naam artist en verkoopsprijs + opslaan
                            Console.Write("Geef de naam van het kunstwerk: ");
                            String naamkunstw = Console.ReadLine().ToLower();

                            Console.Write("Geef de naam van de artist: ");
                            String naamArtist = Console.ReadLine().ToLower();

                            Console.Write("Geef de prijs van het kunstwerk: ");
                            Double prijsKw = Double.Parse(Console.ReadLine().Replace(".",","));

                            //o Sla op in array
                            Opslaan(plaats, naamkunstw, naamArtist, prijsKw);

                            // gebruiker begleiden 
                            Console.WriteLine("Dit kunstwerk werd opgeslagen.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        //•	Als geen plaats
                        else
                        {
                            //o   Foutmelding
                            Console.WriteLine("Er is geen plaats meer.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }

                    }

                    //Als Aanpassen
                    else if (_keuze == 2)
                    {
                        //•	Vraag de naam van het aan te passen kunstwerk
                        Console.Write("Geef de naam van het te zoeken kunstwerk: ");
                        String naamOudKunstw = Console.ReadLine().ToLower();

                        //•	Zoek het werk op in de array +opslaan
                        int plaats = ZoekInArray(naamOudKunstw);

                        //•	Als gevonden
                        if (plaats != -1)
                        {
                            //o Vraag nieuwe naam kustwerk, naam artist en verkoopsprijs +opslaan
                            Console.Write("Geef de nieuwe naam van het kunstwerk: ");
                            String naamkunstw = Console.ReadLine().ToLower();

                            Console.Write("Geef de nieuwe naam van de artist: ");
                            String naamArtist = Console.ReadLine().ToLower();

                            Console.Write("Geef de nieuwe prijs van het kunstwerk: ");
                            Double prijsKw = Double.Parse(Console.ReadLine().Replace(".", ","));

                            //o Sla op in array
                            Opslaan(plaats, naamkunstw, naamArtist, prijsKw);

                            // gebruiker begleiden 
                            Console.WriteLine("De gegevens van dit kunstwerk werden veranderd.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        //•	Als niet gevonden
                        else
                        {
                            //o   Foutmelding
                            Console.WriteLine("Dit kunstwerk werd niet gevonden.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        
                    }


                    //Als Verwijderen 
                    else if (_keuze == 3)
                    {
                        //•	Vraag de naam van het te verwijderen kunstwerk
                        Console.Write("Geef de naam van het te verwijderen kunstwerk: ");
                        String naamOudKunstw = Console.ReadLine().ToLower();

                        //•	Zoek het werk op in de array +opslaan
                        int plaats = ZoekInArray(naamOudKunstw);

                        //•	Als gevonden
                        if(plaats != -1)
                        {
                            //o Verwijder uit array
                            Opslaan(plaats, null, null, 0);

                            // gebruiker begleiden 
                            Console.WriteLine("Dit kunstwerk werd verwijderd.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        //•	Als niet gevonden
                        else
                        {
                            //o   Foutmelding
                            Console.WriteLine("Dit kunstwerk werd niet gevonden.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                    }

                    //Als Tonen
                    else if (_keuze == 4)
                    {
                        //•	Toon alle kunstwerken, de artist en de prijs
                        Console.WriteLine(ToonKunstwerken());
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //Als Zoeken
                    else if (_keuze == 5)
                    {
                        
                        //•	Als niet gevonden
                        //o   Toon foutmelding

                        //•	Vraag de naam van het te zoeken kunstwerk
                        Console.Write("Geef de naam van het te zoeken kunstwerk: ");
                        String naamOudKunstw = Console.ReadLine().ToLower();

                        //•	Zoek het werk op in de array +opslaan
                        int plaats = ZoekInArray(naamOudKunstw);

                        //•	Als gevonden
                        if (plaats != -1)
                        {
                            //o Toon de naam van het kunstwerken, de artist en de prijs
                            Console.WriteLine(Toon1Kunstwerk(plaats));

                            // gebruiker begleiden 
                            Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                        //•	Als niet gevonden
                        else
                        {
                            //o   Foutmelding
                            Console.WriteLine("Dit kunstwerk werd niet gevonden.");
                            Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                    }

                    //Als willekeurig werk
                    else if (_keuze == 6)
                    {
                        //o   Toon de naam van het kunstwerken, de artist en de prijs
                        int plaats = WillekeurigKunstwerk();
                        Console.WriteLine("Volgend kunstwerk wordt in de hoofdvitrine gehangen: ");
                        Console.WriteLine(Toon1Kunstwerk(plaats));

                        // gebruiker begleiden 
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //Als Afsluiten
                    else if (_keuze == 7)
                    {
                        //o Toon afsluittekst
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    
                    // in elk ander geval
                    else
                    {
                        // Toon foutmelding
                        Console.WriteLine("U gaf geen juist getal in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // scherm leegmaken
                    Console.Clear();

                    // Toon foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 7);
        }

        // Business
        // Functies
        /// <summary>
        /// Zoekt een bepaald gegeven in de array
        /// </summary>
        /// <param name="ontvNaamKw"></param>
        /// <returns></returns>
        static int ZoekInArray(String ontvNaamKw)
        {
            int antwoord = Array.IndexOf(_kunstwerken, ontvNaamKw);

            return antwoord;
        }

        /// <summary>
        /// Slaat de naam van het kustwerk, de naam van de artist en de prijs
        /// op in de array om een vooraf bepaalde plaats
        /// </summary>
        /// <param name="plaats"></param>
        /// <param name="ontvNaamKw"></param>
        /// <param name="ontvNaamArt"></param>
        /// <param name="ontvPrijs"></param>
        static void Opslaan(int plaats, String ontvNaamKw, String ontvNaamArt, Double ontvPrijs)
        {
            _kunstwerken[plaats] = ontvNaamKw;
            _artisten[plaats] = ontvNaamArt;
            _prijzen[plaats] = ontvPrijs;
        }

        /// <summary>
        /// Toont alle gegevens
        /// </summary>
        /// <returns></returns>
        static String ToonKunstwerken()
        {
            string antwoord = null;
            // Overloop de array
            for (int i = 0;i<_kunstwerken.Count() ;i++)
            {
                // Kijk of de waarde op de plaats met index i
                // in de array leeg is
                if (_kunstwerken[i]== null)
                {
                    // voeg iets toe aan je antwoord variabele
                    antwoord += $"{(i + 1).ToString()}) leeg \n";
                }
                // Als de plaats in de array niet leeg is 
                else
                {
                    // voeg iets toe aan je antwoord variabele
                    antwoord += $"{(i + 1).ToString()}) kunstwerk: {_kunstwerken[i]} \n     artist: {_artisten[i]}\n     prijs: {_prijzen[i]} EUR\n";
                }
            }

            return antwoord;

        }

        /// <summary>
        /// Toont de gegevens van 1 bepaald kunstwerk
        /// </summary>
        /// <param name="plaats"></param>
        /// <returns></returns>
        static String Toon1Kunstwerk(int plaats)
        {
            string antwoord = null;

            // voeg iets toe aan je antwoord variabele
            antwoord += $"kunstwerk: {_kunstwerken[plaats]} \n     artist: {_artisten[plaats]}\n     prijs: {_prijzen[plaats]} EUR";


            return antwoord;

        }

        /// <summary>
        /// Maakt een willekeurig index aan. 
        /// </summary>
        /// <returns></returns>
        static int WillekeurigKunstwerk()
        {
            int antwoord = -1;

            Random rdm = new Random();
            while(true)
            {
                antwoord = rdm.Next(_kunstwerken.Count());

                if (_kunstwerken[antwoord] != null)
                {
                    break;
                }
            }

            return antwoord;

        }
    }
}
