using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_TomA_ProjFrigo
{
    internal class Product
    {
        // Velden + properties
        public String _naam { get; set; }
        public DateTime _vervaldatum { get; set; }


        // Functies 
        /// <summary>
        /// maakt een mooie tekst van alle velden en stuurt deze door
        /// </summary>
        public String AlleGegevens()
        {
            return  $"product: {_naam}  Vervaldag: {_vervaldatum.ToShortDateString()} {Environment.NewLine}";
        }

        /// <summary>
        /// Gaat na of het product vervallen is 
        /// </summary>
        /// <returns></returns>
        public bool IsVervallen()
        {
            if(_vervaldatum < DateTime.Today  )
            { return true; }
            else 
            { return false; }
            
        }

        /// <summary>
        /// gaat na of de naam overeenkomt met een ontvangen naam 
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <returns></returns>
        public bool BenJijDit (String ontvNaam)
        {
            bool antwoord = false;

            if(ontvNaam == _naam)
            {
                antwoord = true;
            }

            return antwoord;
        }

        // Constructors
        public Product() { }

        public Product(string ontvNaam) 
        {
            _naam = ontvNaam;
        }

        public Product(string ontvNaam, DateTime ontvVervaldag) 
        {
            _naam = ontvNaam;
            _vervaldatum = ontvVervaldag;
        }

    }
}
