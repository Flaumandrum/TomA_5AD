using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TomA_ProjFrigo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmKeuzemenu());
        }

        // Tom Adriaens
        // 01/06/2026
        // Project Frigo

        // Velden 
        static List<Product> _producten = new List<Product>();


        // Functies 
        /// <summary>
        /// Ontvang een naam en een datum , maakt er een product van, voegt dit toe aan de lijst
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvVervD"></param>
        static public void ToevProd(String ontvNaam, DateTime ontvVervD) 
        {
            // Maak een nieuw product aan met de ontvangen gegevens 
            Product nieuweProd = new Product(ontvNaam, ontvVervD);

            // voeg dit toe aan de lijst
            _producten.Add(nieuweProd);
            
        }

        /// <summary>
        /// Neemt de prodcuten uit de lijst, en zet ze in een string om door te sturen
        /// </summary>
        /// <returns></returns>
        static public String ToonProd()
        {
            String antwoord = null;

            // overloop lijst
            foreach (Product p in _producten)
            {
                // Sla de gegevens van het product op in mijn antwoord zonder te overschrijven
                antwoord += p.AlleGegevens();

                
            }
            /*
             for (int i = 0; i < _producten.Count(); i++)
            {
                 antwoord += _producten[i].AlleGegevens();
            }
             */
            if (antwoord == null)
            {
                antwoord = "Er zijn geen producten in de frigo.";
            }

            return antwoord;
            
        }

        /// <summary>
        /// stuurt een lijst door met vervallen producten
        /// </summary>
        /// <returns></returns>
        static public String ToonVervProd()
        {
            string antwoord = null;

            // Overloop de lijst met producten 
            foreach(Product p in _producten)
            {
                // Kijk of het product vervalle nis
                if(p.IsVervallen())
                {
                    // Sla de gegevens van het product op in mijn antwoord zonder te overschrijven
                    antwoord += p.AlleGegevens();
                }
                
            }

            // kijk of het antwoord toevallig leeg is
            // Als het na het overlopen van de lus toch nog leeg is, 
            // Dan waren er geen producten vervallen
            if(antwoord == null)
            {
                antwoord = "Er zijn geen vervallen producten.";
            }

            return antwoord;
        }

        /// <summary>
        /// Ontvangt een naam van een product, kijkt of het in de frigo zit en stuurt een antwoord 
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <returns>true(product zit in de frigo) anders false</returns>
        static public bool NakijkenProd(String ontvNaam)
        {
            bool antwoord = false;

            // overloop de lijst 
            foreach(Product p in _producten)
            {
                antwoord = p.BenJijDit(ontvNaam);
                
                if (antwoord)
                {
                    break;
                }
            }

            return antwoord;
        }

        /// <summary>
        /// maakt een lijst met de naam van alle producten
        /// </summary>
        /// <returns></returns>
        static public List<String> LijstProd()
        {
            List<String> antwoord = new List<String>();

            // Overloop de lijst
            foreach(Product p in _producten)
            {
                antwoord.Add(p._naam);
            }

            return antwoord;
        }

        /// <summary>
        /// ontvant een index met de plaats van het product dat moet aangepast worden, 
        /// met een nieuwe naam en nieuwe vervaldatum en past dit specifieke object aan
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvVervD"></param>
        static public void AanpProd(int ontvIndex, String ontvNaam, DateTime ontvVervD)
        {
            // Maak een nieuw product aan met de ontvangen gegevens
            Product nieuwProduct = new Product(ontvNaam, ontvVervD);

            // Overschrijg het oude product om de plaats van de indes
            // Met het nieuw aangemaakte product.
            _producten[ontvIndex] = nieuwProduct;

        }

        /// <summary>
        /// Ontvangt een index met plaats van het product dat verwijderd moet worden.
        /// </summary>
        /// <param name="ontvIndex"></param>
        static public void VerwProd(int ontvIndex)
        {
            _producten.RemoveAt(ontvIndex);
        }


    }
}
