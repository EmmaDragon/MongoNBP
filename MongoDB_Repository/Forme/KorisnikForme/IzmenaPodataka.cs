using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Podaci;

namespace MongoDB_Repository.Forme.KorisnikForme
{
    public partial class IzmenaPodataka : Form
    {
        private Korisnik korisnik;

        public IzmenaPodataka()
        {
            InitializeComponent();
        }

        public IzmenaPodataka(Korisnik k)
        {
            this.korisnik = k;
            InitializeComponent();

            OsveziStranicu(k);
        }
        public void OsveziStranicu(Korisnik k)
        {
            
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<Korisnik>("korisnik");

            var query = Query.And(
                           Query.EQ("Username", k.Username),
                           Query.EQ("Password", k.Password)
                           );

            var result = collection.Find(query);

            foreach (Korisnik ko in result)
            {
                Korisnik KKorisnik = new Korisnik(ko.Id, ko.Ime, ko.Prezime, ko.Username, ko.Password, ko.Zvanje, ko.Jmbg, ko.DatumRodjenja);
                k = KKorisnik;
            }
            this.korisnik = k;
            this.txbIme.Text = k.Ime;
            this.txbPrezime.Text = k.Prezime;
            if (k.Zvanje != null)
                this.txbZvanje.Text = k.Zvanje;
            if (k.Jmbg != null)
                this.txbJmbg.Text = k.Jmbg;
            this.maskedTextBox1.Text = k.DatumRodjenja;
            this.txbPassword.Text = k.Password;
            this.txbUsername.Text = k.Username;

        }

        private void IzmenaPodataka_Load(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izmene?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collection = db.GetCollection<Korisnik>("korisnik");
                var query = Query.EQ("Username", korisnik.Username);

                var update = Update<Korisnik>.Set(k => k.Ime, txbIme.Text).
                                                      Set(k => k.Prezime, txbPrezime.Text).
                                                      Set(k => k.Zvanje, txbZvanje.Text).
                                                      Set(k => k.DatumRodjenja, maskedTextBox1.Text).
                                                      Set(k => k.Jmbg, txbJmbg.Text).
                                                      Set(k => k.Password, txbPassword.Text);

                collection.Update(query, update);

                
                MessageBox.Show("Uspesno ste izvrsili izmene!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void TxbIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
