using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_TomA_GegArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 13/01/2026
            // Project: Gegevens array 1

            // Velden 
            Byte[] _getallen = new Byte[10];
            
            // Programma 
            //Stap 1: Vul de array
            for (int i= 0; i < _getallen.Count(); i ++)
            {
                _getallen[i] = (byte)(i+1);
                
            }

            //Stap 2: laat de gegevens zien dmv een do lus
            int t = 0;
            do
            {
                if(t== (_getallen.Count()-1))
                {
                    Console.WriteLine($"{_getallen[t]} ");
                }
                else
                {
                    Console.Write($"{_getallen[t]}, ");
                }
                    

                t++;
            } while (t < _getallen.Count());

            //Stap 3: Laat de gegevens zien dmv een for lus
            for(int i = 0; i< _getallen.Count();i++)
            {
                if (i == (_getallen.Count() - 1))
                {
                    Console.WriteLine($"{_getallen[i]} ");
                }
                else
                {
                    Console.Write($"{_getallen[i]}, ");
                }
            }

        }
    }
}
