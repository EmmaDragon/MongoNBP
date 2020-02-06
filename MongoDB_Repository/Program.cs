using MongoDB_Repository.Forme;
using MongoDB_Repository.Forme.AdminForme;
using MongoDB_Repository.Forme.KorisnikForme;
using MongoDB_Repository.Forme.ZaposleniForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn_Admin());
            //Application.Run(new LogIn_Zaposleni());
            //Application.Run(new LogIn_Korisnik());
        }
    }
}
