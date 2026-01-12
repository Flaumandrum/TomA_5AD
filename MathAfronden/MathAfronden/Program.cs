using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathAfronden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double _number = 2.6789123;
            int _deeltal = 6;


            Console.WriteLine("deling: " + (60/_deeltal).ToString());

            double _result = 33 / Convert.ToDouble(_deeltal);

            Console.WriteLine("deling met double: " + _result.ToString());

            /// Uitleg van Math.Round
            /*Console.WriteLine("Original number: " + _number);

            Console.WriteLine("Rounded to 2 decimal places: " + Math.Round(_number, 2));

            _number = _number * 100;
            Console.WriteLine("nummer * 100: " + _number);
            _number = Math.Ceiling(_number);
            Console.WriteLine ("nummer: " + _number );
            _number = _number/100;

            Console.WriteLine("Rounded down to 2 decimal places: " + _number);
            */
        }
    }
}
