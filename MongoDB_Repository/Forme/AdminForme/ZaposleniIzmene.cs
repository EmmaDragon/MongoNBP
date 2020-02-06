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
using Podaci;

namespace MongoDB_Repository.Forme.AdminForme
{
    public partial class ZaposleniIzmene : Form
    {
        private String okrug;

        public ZaposleniIzmene()
        {
            InitializeComponent();
        }

        public ZaposleniIzmene(String okrug)
        {
            InitializeComponent();
            this.okrug = okrug;
            this.PribaviStanice();
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (listaStanica.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo morate izabrati vremensku stanicu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.PopuniTabeluOdgPodacima();
        }

        public void PopuniTabeluOdgPodacima()
        {
            VremenskaStanica v = (VremenskaStanica)listaStanica.SelectedItem;
            this.Text = "ZAPOSLENI - " + v.Naziv;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var query = Query.And(Query.EQ("Naziv", v.Naziv),
                                  Query.EQ("Okrug", v.Okrug));

            var result = collection.Find(query).ToList<VremenskaStanica>();

            this.PopuniTabelu(result[0]);
        }

        public void PopuniTabelu(VremenskaStanica stanica)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            listaZaposlenih.Items.Clear();
            foreach (MongoDBRef zaposleniRef in stanica.Odgovorni.ToList())
            {
               Zaposleni z = db.FetchDBRefAs<Zaposleni>(zaposleniRef);
                ListViewItem item = new ListViewItem(new string[]
                     {z.Id.ToString(),z.Ime,z.Prezime,z.Jmbg,z.Zvanje});
                listaZaposlenih.Items.Add(item);
            }

            listaZaposlenih.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult msgResult=MessageBox.Show("Da li ste sigurni da zelite da izvrsite brisanje?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgResult == DialogResult.Yes)
            {
                String jmbg = listaZaposlenih.SelectedItems[0].SubItems[3].Text;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collectionStanice = db.GetCollection<VremenskaStanica>("vremenske_stanice");
                var collectionZaposleni = db.GetCollection<Zaposleni>("zaposleni");
                var query = Query.EQ("Jmbg", jmbg);

                var result = collectionZaposleni.Find(query).ToList<Zaposleni>();
                Zaposleni z = result[0];
                VremenskaStanica s = db.FetchDBRefAs<VremenskaStanica>(z.VremenskaStanica);
                foreach (MongoDBRef zaposleniRef in s.Odgovorni.ToList())
                {
                    Zaposleni tmp = db.FetchDBRefAs<Zaposleni>(zaposleniRef);
                    if (z.Jmbg == tmp.Jmbg)
                        s.Odgovorni.Remove(zaposleniRef);
                }
                collectionStanice.Save(s);
                collectionZaposleni.Remove(query);
                MessageBox.Show("Uspesno ste obrisali vremensku stanicu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PopuniTabeluOdgPodacima();
            }
            else
            {
                return;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog cije podatke zelite da izmenite!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String jmbg = listaZaposlenih.SelectedItems[0].SubItems[3].Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collectionStanice = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var collectionZaposleni = db.GetCollection<Zaposleni>("zaposleni");
            var query = Query.EQ("Jmbg", jmbg);

            var result = collectionZaposleni.Find(query).ToList<Zaposleni>();
            Zaposleni z = result[0];
            Form forma = new ZaposleniPodaciIzmena(z,this.okrug);
            forma.ShowDialog();
            this.PopuniTabeluOdgPodacima();
        }
    }
}
