using FormApp;
using FormApp.Views;

namespace FormApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new ViewTransactions());
=======
           Application.Run(new homePageAdmin());

>>>>>>> 045711317590bf1154c69489b4643faa6f765324
        }
    }
}