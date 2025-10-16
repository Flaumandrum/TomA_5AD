using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TomA_WillekeurigGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 10/10/2025
            // Willekeurig getal

            // Velden 
            Random _rdm1 = new Random();
            

            int _getal1 = 0;
            int _getal2 = 0;

            // Programma
            _getal1 = _rdm1.Next(5,11);
            _getal2 = _rdm1.Next(1,20);

            Console.WriteLine($"Eerste getal:  {_getal1.ToString()}");
            Console.WriteLine($"Tweede getal:  {_getal2.ToString()}");
        }
    }
}
