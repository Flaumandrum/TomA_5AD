using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomA_Proj_Prikklok
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

        // Velden
        static List<String> _voornamen = new List<string>();
        static List<String> _achternamen = new List<string>();
        static List<int> _wnsGetallen = new List<int>();
        static List<DateTime> _aankomsttijden = new List<DateTime>();
        static List<DateTime> _vertrektijden = new List<DateTime>();

        // Functies

        static public bool CheckCode(int ontvCode)
        {
            bool antwoord = false;

            return antwoord;
        }

        static public void RegistreerTijd(int ontvCode)
        {

        }

        static public String ToonWerktijd(int ontvCode)
        {
            string antwoord = "";

            return antwoord;
        }
        /// <summary>
        /// Kijkt of het wachtwoord juist is
        /// </summary>
        /// <param name="ontvWw"></param>
        /// <returns>boolean</returns>
        static public bool CheckWw (string ontvWw)
        {
            bool antwoord = false;

            // kijk of het wachtwoord juist is
            if(ontvWw == "admin")
            {

                // als dit zou is, verander de boolean in true 
                antwoord = true;
            }

            return antwoord;
        }
        /// <summary>
        /// Kijkt of het aantal werknemers kleiner is dan 20
        /// </summary>
        /// <returns>boolean</returns>
        static public bool CheckAantalWn ()
        {
            bool antwoord = false;

            // kijk of het aantal werknemers kleiner in dan 20
            if (_voornamen.Count() < 20)
            {
                antwoord = true; // Als dat zo is, zet de boolean op true
            }
            // stuur het antwoord terug 
            return antwoord;
        }

        /// <summary>
        /// ontvangt een voornaam en een achternaam, maakt een unieke 5cijfercode aan, 
        /// voegt al een plaats toe aan de list met start en stoptijden 
        /// en voegt alles toe aan de juiste list.
        /// </summary>
        /// <param name="ontvVn"></param>
        /// <param name="ontvAn"></param>
        static public void OpslaanWn (String ontvVn, string ontvAn)
        {
            // voeg de voornaam toe aan de juiste lijst 
            _voornamen.Add(ontvVn);

            //voeg de achternaam toe aan de juiste lijst
            _achternamen.Add(ontvAn);

            bool herhalen = true;
            int ontvCode = 0;

            while (herhalen)
            {
                // vraag de willekeurige code van 5 cijfers op 
                ontvCode = MaakWillekeurigeCode();

                // code moet uniek zijn dus kijk of ze bestaat. 
                herhalen = _wnsGetallen.Contains(ontvCode);
            }

            // voeg de code van de werknemer toe aan de lijst
            _wnsGetallen.Add(ontvCode);

            // voegt een statdatum (1 jan 0001 00:00:00) toe aan beide lijsten
            DateTime blanco = new DateTime();
            _aankomsttijden.Add(blanco);
            _vertrektijden.Add(blanco);

        }
        /// <summary>
        /// maakt een willekeurig getal aan van 5 cijfers 
        /// </summary>
        /// <returns>int</returns>
        static private int MaakWillekeurigeCode ()
        {
            int antwoord = 0;
            // Maak een random aan 
            Random rdm = new Random();

            // eerste getal met 5 cijfers is 10000 (ondergrens is inbegrepen)
            // eerste getal met geen 5 cijfers is 100000 (bovengrens is niet inbegrepen)
            antwoord = rdm.Next(10000,100000);

            return antwoord;
        }

        static public void Aanpassen (int ontvIndex, String ontvVn, String OntvAn)
        {

        }

        static public void Verwijderen (int ontvIndex)
        {

        }

        static public String ToonCode (int ontvIndex)
        {
            String antwoord = "";

            return antwoord;
        }

        static public List<string> StuurLijstDoor()
        {
            List<string> antwoord = new List<string>();

            return antwoord;
        }

    }
}
