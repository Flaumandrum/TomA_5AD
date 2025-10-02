using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_TomA_Regi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 29/09/2025
            // Oefening 19: Registratie

            // Velden
            String login = null, wachtwoord = null, login2 = null, wachtwoord2 = null;

            // Programma

            // Stap 1: Intro
            Console.WriteLine("Welkom bij de registratie!");
            // Stap 2: Vraag login +opslaan
            Console.Write("Geef uw login: ");
            login = Console.ReadLine();

            // Stap 3: Vraag wachtwoord +opslaan
            Console.Write("Geef uw wachtwoord: ");
            wachtwoord = Console.ReadLine();

            // Stap 4: Vraag login opnieuw + opslaan
            Console.Write("Geef uw login opnieuw: ");
            login2 = Console.ReadLine();

            // Stap 5: Vraag wachtwoord opnieuw + opslaan
            Console.Write("Geef uw wachtwoord opnieuw: ");
            wachtwoord2 = Console.ReadLine();

            // Schermleegmaken
            Console.Clear();

            // Stap 6: 
            // •	Als beiden gelijk
            if (login == login2 && wachtwoord == wachtwoord2)
            {
                // o   Toon beiden juist
                Console.WriteLine("Beiden juist");
            }
            
            // •	Als login fout en wachtwoord juist
           
            else if (login != login2 && wachtwoord == wachtwoord2)
            {
                // o Toon login is fout
                Console.WriteLine("Login is fout");
            }
           
            // •	Als login juist en wachtwoord fout
            else if (login == login2 && wachtwoord != wachtwoord2)
            {
                // o Toon wachtwoord is fout
                Console.WriteLine("Wachtwoord is fout");
            }
            
            // •	Als beide fout
            else
            {
                // o   Toon beiden zijn fout
                Console.WriteLine("Beiden zijn fout");
            }
            


        }
    }
}
