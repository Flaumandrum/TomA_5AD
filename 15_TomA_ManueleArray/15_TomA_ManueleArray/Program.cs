using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_TomA_ManueleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 12/01/2026
            // Manuele array

            // Velden
            String[] _namen =new String[]{ "Jan", "Piet", "Joris", "Corneel" };

            // Programma
            for(int i = 0; i < _namen.Count(); i++)
            {
                if(i < (_namen.Count() - 2))
                {
                    Console.Write($"{_namen[i]}, ");
                }
                else if(i < (_namen.Count() - 1))
                {
                    Console.Write($"{_namen[i]} en ");
                }
                else
                {
                    Console.Write($"{_namen[i]}. Die hebben baarden ");
                }

                
            }
            Console.WriteLine("die hebben baarden!");

            Console.WriteLine("\nDruk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
