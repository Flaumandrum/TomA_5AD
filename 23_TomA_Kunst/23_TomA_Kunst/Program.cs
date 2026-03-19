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

                //Toon menu: (Toevoegen, aanpassen, verwijderen, tonen, zoeken, willekeurig werk, afsluiten)

                //Vraag keuze + opslaan

                //Als Toevoegen
                //•	Zoek of er plaats is +opslaan
                //•	Als plaats:
                //o Vraag naam kustwerk, naam artist en verkoopsprijs + opslaan
                //o Sla op in array
                //•	Als geen plaats
                //o   Foutmelding

                //Als Aanpassen
                //•	Vraag de naam van het aan te passen kunstwerk
                //•	Zoek het werk op in de array +opslaan
                //•	Als gevonden
                //o Vraag nieuwe naam kustwerk, naam artist en verkoopsprijs +opslaan
                //o Sla op in array
                //•	Als niet gevonden
                //o   Toon foutmelding

                //Als Verwijderen 
                //•	Vraag de naam van het te verwijderen kunstwerk
                //•	Zoek het werk op in de array +opslaan
                //•	Als gevonden
                //o Verwijder uit array
                //•	Als niet gevonden
                //o   Toon foutmelding
                //Als Tonen
                //•	Toon alle kunstwerken, de artist en de prijs

                //Als Zoeken
                //•	Vraag de naam van het te zoeken kunstwerk
                //•	Zoek het werk op in de array +opslaan
                //•	Als gevonden
                //o Toon de naam van het kunstwerken, de artist en de prijs
                //•	Als niet gevonden
                //o   Toon foutmelding

                //Als willekeurig werk
                //o   Toon de naam van het kunstwerken, de artist en de prijs

                //Als Afsluiten
                //o Toon afsluittekst

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
            int antwoord = -1;

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

        }

        /// <summary>
        /// Toont alle gegevens
        /// </summary>
        /// <returns></returns>
        static String ToonKunstwerken()
        {
            string antwoord = null;

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

            return antwoord;

        }

        /// <summary>
        /// Maakt een willekeurig index aan. 
        /// </summary>
        /// <returns></returns>
        static int WillekeurigKunstwerk()
        {
            int antwoord = -1;

            return antwoord;

        }
    }
}
