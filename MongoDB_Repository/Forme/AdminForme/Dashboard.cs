using MongoDB_Repository.Entiteti;
using Podaci;
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
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MongoDB_Repository.Forme.AdminForme
{
    public partial class Dashboard : Form
    {
        private Admin admin;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            lblIme.Text = admin.Ime.ToUpper();
            lblPrezime.Text = admin.Prezime.ToUpper();
            lblOkrug.Text = admin.Okrug.ToUpper() + " OKRUG";
            txbOkrug.Text = admin.Okrug;
            txbOkrug.ReadOnly = true;
            PribaviStanice();

        }

        public void PribaviStanice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var query = Query.EQ("Okrug", admin.Okrug);
            var result = collection.Find(query).ToList<VremenskaStanica>();
            foreach(VremenskaStanica v in result)
            {
                cmbStanice.Items.Add(v);
            }
        }

        public bool ValidacijaVremenskeStanice()
        {
            bool ind = true;
            if (txbNaziv.Text == "")
            {
                MessageBox.Show("Naziv stanice nije validan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbMesto.Text == "")
            {
                MessageBox.Show("Naziv mesta nije validan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            return ind;
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            if (!ValidacijaVremenskeStanice())
                return;
            VremenskaStanica stanica =
                new VremenskaStanica(txbNaziv.Text, "Srbija", txbOkrug.Text, txbMesto.Text);
            stanica.minTemperatura = (double)minTemp.Value;
            stanica.maxTemperatura = (double)maxTemp.Value;
            stanica.minPadavine = (double)minPadavine.Value;
            stanica.maxPadavine = (double)maxPadavine.Value;
            stanica.minVlaznost = (double)minVlaznost.Value;
            stanica.maxVlaznost = (double)maxVlaznost.Value;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var query = Query.EQ("Naziv", stanica.Naziv);
            var result = collection.Find(query);

            if (result.Count<VremenskaStanica>() != 0)
            {
                MessageBox.Show("Data vremenska stanica vec postoji u bazi podataka!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                collection.Insert(stanica);
                MessageBox.Show("Uspesno ste dodali novu vremensku stanicu!", "Obavestenje", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnIzmeniStanicu_Click(object sender, EventArgs e)
        {
            Form forma = new VremenskeStanice(admin.Okrug);
            forma.ShowDialog();
        }

        public bool Validacija()
        {
            bool ind = true;
            if(txbIme.Text=="")
            {
                MessageBox.Show("Ime nije validno!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbPrezime.Text == "")
            {
                MessageBox.Show("Prezime nije validno!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbJmbg.Text == "")
            {
                MessageBox.Show("Jmbg nije validan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbZvanje.Text == "")
            {
                MessageBox.Show("Zvanje nije validno!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbUsername.Text == "")
            {
                MessageBox.Show("Korisnicko ime nije validno!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (txbPassword.Text == "")
            {
                MessageBox.Show("Sifra nije validna!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if (cmbStanice.SelectedItem==null)
            {
                MessageBox.Show("Vremenska stanica nije selektovana!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            return ind;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            VremenskaStanica v = (VremenskaStanica)cmbStanice.SelectedItem;
            Zaposleni zaposleni = new Zaposleni(txbIme.Text, txbPrezime.Text,
                txbUsername.Text, txbPassword.Text, txbJmbg.Text, txbZvanje.Text,
                new MongoDBRef("vremenske_stanice",v.Id));
            if(datumZaposlenja.Text!= "")
            {
                zaposleni.DatumZaposlenja = datumZaposlenja.Text;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<Zaposleni>("zaposleni");
            var query = Query.EQ("Jmbg", zaposleni.Jmbg);
            var result = collection.Find(query);
            if (result.Count<Zaposleni>() != 0)
            {
                MessageBox.Show("Zaposleni sa zadatim jmbg-om vec postoji!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                query = Query.EQ("Username", zaposleni.Username);
                result = collection.Find(query);
                if (result.Count<Zaposleni>() != 0)
                {
                    MessageBox.Show("Zaposleni sa zadatim korisnickim imenom vec postoji!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    collection.Insert(zaposleni);
                    query = Query.EQ("Username", zaposleni.Username);
                    result = collection.Find(query);
                    var collectionVremenskaStanica = db.GetCollection<VremenskaStanica>("vremenske_stanice");
                    foreach (Zaposleni r in result)
                    {
                        v.Odgovorni.Add(new MongoDBRef("zaposleni", r.Id));
                    }
                    collectionVremenskaStanica.Save(v);
                    MessageBox.Show("Uspesno ste dodali novog zaposlenog!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUsernameGenerator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txbUsername.Text = txbIme.Text + txbPrezime.Text + rnd.Next(10, 2000);
        }

        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txbPassword.Text = txbIme.Text + txbPrezime.Text + rnd.Next(10, 2000);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Form forma = new ZaposleniIzmene(admin.Okrug);
            forma.ShowDialog();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            this.cmbStanice.Items.Clear();
            this.PribaviStanice();
        }
    }
}
