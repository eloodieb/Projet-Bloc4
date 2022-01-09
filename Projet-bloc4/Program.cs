using Projet_bloc4.Interfaces.InterfaceLogin;
using System;
using System.Windows.Forms;


namespace Projet_bloc4
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());

        }


    }
}
