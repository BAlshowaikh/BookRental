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
           Application.Run(new ManageAuthors());
=======
           Application.Run(new homePageStaff());
>>>>>>> d29c47c7958b11e21c4f52a36ba4d444af84a882
        }
    }
}