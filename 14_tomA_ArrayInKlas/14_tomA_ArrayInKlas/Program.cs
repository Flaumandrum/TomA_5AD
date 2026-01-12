using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_tomA_ArrayInKlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 12/01/2026
            // Array in klas

            // Velden 
            String[] _voornamen = new string[0];
            String[] _achternamen = new string[0];


            // Programma

            Console.WriteLine("Hoeveel leerlingen zitten er in uw klas?");
            Console.Write("\nAantal leerlingen: ");

            Byte aantal = Convert.ToByte(Console.ReadLine());
            _voornamen = new string[aantal];
            _achternamen = new string[aantal];

            for (int i= 0; i<_voornamen.Length; i++)
            {
                Console.Write($"Geef de voornaam van leerling {i+1}: ");
                _voornamen[i]  = Console.ReadLine();
                Console.Write($"Geef de achternaam van leerling {i + 1}: ");
                _achternamen[i] = Console.ReadLine();
            }

            //Console.WriteLine(_voornamen[0]);
            //Console.WriteLine(_voornamen[1]);
            //Console.WriteLine(_voornamen[2]);
            //Console.WriteLine(_voornamen[3]);
            //Console.WriteLine(_voornamen[4]);
            Console.WriteLine("Druk op enter om de namen te bekijken");
            Console.ReadKey();

            Console.Clear();

            for(int i =0;i<_voornamen.Count(); i++)
            {
                if (_voornamen[i] != null)
                {
                    Console.WriteLine($"{_voornamen[i]} {_achternamen[i]}");
                }
                                
            }

            Console.ReadKey();

        }
    }
}
