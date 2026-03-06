using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_InleidingFuncties
{
    internal class Program
    {
        // Tom Adriaens
        // 09/02/2026
        // Inleiding functies 

        // Velden 
       
        // GUI
        static void Main(string[] args)
        {
            
            // Vraag de naam van de gebruiker 
            Console.Write("Geef uw voornaam: ");
            string vNaam = Console.ReadLine();
            Console.Write("Geef uw achternaam: ");
            string aNaam = Console.ReadLine();

            // Scherm leegmalen 
            Console.Clear();

            // Zeg tekst van de functie
            Console.WriteLine(Hallo(vNaam, aNaam));
            
            Console.ReadKey();

        }
        //--------------------------------------------------------//
        // Business
        // Functies

        /// <summary>
        /// Ontvangt de voornaam en de achternaam en zegt hallo
        /// </summary>
        /// <param name="ontvVNaam">de voornaam</param>
        /// <param name="ontvANaam">de achternaam</param>
        /// <returns>hallo voornaam achternaam</returns>
        static private string Hallo(string ontvVNaam, string ontvANaam)
        {

            string antwoord = null;

            antwoord = $"Hallo {ontvVNaam} {ontvANaam}.";

            return antwoord;
        }

    }
}
