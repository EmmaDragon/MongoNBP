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
    public partial class ZaposleniPodaciIzmena : Form
    {
        private Zaposleni zaposleni;
        private String okrug;

        public ZaposleniPodaciIzmena()
        {
            InitializeComponent();
        }

        public ZaposleniPodaciIzmena(Zaposleni z,String okrug)
        {
            InitializeComponent();
            this.zaposleni = z;
            this.okrug = okrug;
            this.Text += "- " + z.Ime + " " + z.Prezime;
            this.txbIme.Text = z.Ime;
            this.txbPrezime.Text = z.Prezime;
            this.txbZvanje.Text = z.Zvanje;
            this.txbJmbg.Text = z.Jmbg;
            this.PribaviStanice();

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            VremenskaStanica s = db.FetchDBRefAs<VremenskaStanica>(z.VremenskaStanica);
            this.listaStanica.Text = s.ToString();
        }
        public void PribaviStanice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var query = Query.EQ("Okrug", this.okrug);
            var result = collection.Find(query).ToList<VremenskaStanica>();

            foreach (VremenskaStanica v in result)
            {
                listaStanica.Items.Add(v);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izmene?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collection = db.GetCollection<Zaposleni>("zaposleni");
                var query = Query.EQ("Jmbg", zaposleni.Jmbg);

                var update = Update<Zaposleni>.Set(z => z.Ime, txbIme.Text).
                                                      Set(z => z.Prezime, txbPrezime.Text).
                                                      Set(z => z.Zvanje, txbZvanje.Text);

                collection.Update(query, update);
                VremenskaStanica s = db.FetchDBRefAs<VremenskaStanica>(zaposleni.VremenskaStanica);
                VremenskaStanica selected = (VremenskaStanica)listaStanica.SelectedItem;
                if (s.Naziv != selected.Naziv)
                {
                    update = Update<Zaposleni>.
                        Set(z => z.VremenskaStanica, new MongoDBRef("vremenske_stanice", selected.Id));
                    collection.Update(query, update);
                    var collectionStanice = db.GetCollection<VremenskaStanica>("vremenske_stanice");
                   
                    foreach (MongoDBRef zaposleniRef in s.Odgovorni.ToList())
                    {
                        Zaposleni tmp = db.FetchDBRefAs<Zaposleni>(zaposleniRef);
                        if (zaposleni.Jmbg == tmp.Jmbg)
                        {
                            s.Odgovorni.Remove(zaposleniRef);
                            selected.Odgovorni.Add(zaposleniRef);
                        }
                    }
                    
                    collectionStanice.Save(s);
                    collectionStanice.Save(selected);
                }
                MessageBox.Show("Uspesno ste izvrsili izmene!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
