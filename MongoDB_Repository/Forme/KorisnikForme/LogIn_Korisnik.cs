using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB_Repository.Entiteti;
using Podaci;

namespace MongoDB_Repository.Forme.KorisnikForme
{
    public partial class LogIn_Korisnik : Form
    {
        public LogIn_Korisnik()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Logovanje korisnika je identicno kao kod admina i zaposlenog
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<Korisnik>("korisnik");

            var query = Query.And(
                           Query.EQ("Username", txbUsername.Text),
                           Query.EQ("Password", txbPassword.Text)
                           );

            var result = collection.Find(query);

            if (result.Count<Korisnik>() == 0)
            {
                MessageBox.Show("Pogresno uneto korisnicko ime ili sifra!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Korisnik k in result)
                {
                    Korisnik korisnik = new Korisnik(k.Id, k.Ime, k.Prezime, k.Username, k.Password, k.Zvanje, k.Jmbg, k.DatumRodjenja);
                    Form forma = new GlavnaStranica(korisnik);
                    forma.ShowDialog();
                }
            }
        }

        private void LblKreirajNalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form forma = new KreiranjeNaloga();
            forma.ShowDialog();
        }
    }
}
