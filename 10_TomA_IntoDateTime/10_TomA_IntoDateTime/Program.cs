using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TomA_IntoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime _datum = DateTime.Now;
            DateTime _datum1 = DateTime.Today;

            DateTime _datum2 = new DateTime(2023, 12, 31);
            DateTime _datum3 = new DateTime(2023, 12, 31, 23, 59, 59);
            DateTime _datum4 = DateTime.Parse("2023-12-31 23:59:59");


            Console.WriteLine("Datum en tijd: " + _datum.ToString());
            Console.WriteLine("\nDatum en tijd: " + _datum1.ToString());
            Console.WriteLine("\nDatum en tijd: " + _datum2.ToString());
            Console.WriteLine("\nDatum en tijd: " + _datum3.ToString());
            Console.WriteLine("\nDatum en tijd: " + _datum4.ToString());

            // datum deel van datum en tijd
            Console.WriteLine("\nAlleen datum: " + _datum.Date.ToString());

            // Dag deel van een datum
            Console.WriteLine("Dag van de maand: " + _datum.Second.ToString());

            // Dag van de week
            Console.WriteLine("Dag van de week: " + _datum.DayOfWeek.ToString());
            
            // Dag van het jaar 
            Console.WriteLine("Dag van het jaar: " + _datum.DayOfYear.ToString());

            // dagen toevoegen
            _datum = _datum.AddDays(10);
            Console.WriteLine("Datum na 10 dagen: " + _datum.ToString());

            // bewerkingen met datums !! gebruik TimeSpan !!
            TimeSpan verschil = _datum1 - _datum3;
            Console.WriteLine("Verschil in totaal minuten: " + verschil.TotalMinutes.ToString());
            Console.WriteLine("Verschil het minuten deel van de timespan: " + verschil.Minutes.ToString());


        }


    }
}
