using System;
using System.Windows.Forms;

namespace _24_TomA_FormsStart
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
            Application.Run(new StartForm());
        }

        // Tom Adriaens
        // 16/03/2026
        // Start Forms

        // Velden 

        // Functies
        /// <summary>
        /// Ontvangt een gegeven uit de GUI
        /// Zegt hallo + naam wanneer dit niet leeg is
        /// Zegt Hallo wereld wanneer dit leeg is.
        /// </summary>
        /// <param name="ontvNaam">De naam van de gebruiker</param>
        /// <returns></returns>
        static public String ZegHallo(String ontvNaam)
        {
            String antwoord = null;

            if (ontvNaam != "")
            {
                antwoord = $"Hallo {ontvNaam}"; 
            }
            else
            {
                antwoord = "Hallo wereld!";
            }

            return antwoord;
        }
    }
}
