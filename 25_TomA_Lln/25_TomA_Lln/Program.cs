using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_TomA_Lln
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
        // 23/03/2026
        // Project Leerlingen

        // Velden 
        static String[] _lln = new String[0];

        // Functies
        /// <summary>
        /// Past de grootte van de array aan
        /// </summary>
        /// <param name="ontvGrootte"></param>
        static public void PasArrayAan(int ontvGrootte)
        {

        }
        /// <summary>
        /// Zoekt een ontvangen string in de array en geeft de index weer,
        /// geeft -1 als niet gevonden
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <returns></returns>
        static public int ZoekenInArray(String ontvNaam)
        {
            int antwoord = -1;

            return antwoord;

        }

        /// <summary>
        /// ontvangt een naam en een index en voegt de naam toe in de 
        /// arry op de plaats van de index
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        static public void OpslaanInArray(int ontvIndex, string ontvNaam)
        {

        }

        /// <summary>
        /// Stuurt een lijst door met alle namen van de leerlingen
        /// </summary>
        /// <returns></returns>
        static public String ToonLln()
        {
            String antwoord = null;

            return antwoord;
        }
        /// <summary>
        /// Gaat na of de grootte van de array reeds werd veranderd
        /// </summary>
        /// <returns></returns>
        static public bool IsArrayAangepast()
        {
            bool antwoord = false;

            if(_lln.Count() != 0)
            {
                antwoord = true;
            }

            return antwoord;

        }



    }
}
