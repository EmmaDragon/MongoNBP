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
    public partial class VremenskeStanice : Form
    {
        private String okrug;

        public VremenskeStanice()
        {
            InitializeComponent();
        }

        public VremenskeStanice(String okrug)
        {
            InitializeComponent();
            this.okrug = okrug;
            this.Text = "VREMENSKE STANICE - " + okrug.ToUpper()+" OKRUG";
            this.lblUputstvo.Text += okrug + " okrug.";
            this.PopuniTabelu();
        }

        public void PopuniTabelu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            var query = Query.EQ("Okrug", okrug);
            var result = collection.Find(query).ToList<VremenskaStanica>();

            listaStanica.Items.Clear();

            foreach (VremenskaStanica v in result)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Id.ToString(),v.Naziv,v.Mesto,
                v.minTemperatura.ToString()+" C",v.maxTemperatura.ToString()+" C",
                v.minPadavine.ToString()+" l/m2",v.maxPadavine.ToString()+" l/m2",
                v.minVlaznost.ToString()+" mm Hg",v.maxVlaznost.ToString()+" mm Hg"});
                listaStanica.Items.Add(item);
            }

            listaStanica.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vremensku stanicu cije podatke zelite da izmenite!","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            String naziv = listaStanica.SelectedItems[0].SubItems[1].Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");

            var query = Query.And(
                Query.EQ("Okrug", this.okrug),
                Query.EQ("Naziv", naziv));

            var result = collection.Find(query).ToList<VremenskaStanica>();
            Form forma = new VremenskaStanicaIzmene(result[0]);
            forma.ShowDialog();
            this.PopuniTabelu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vrmensku stanicu koju zelite da obrisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da izvrsite brisanje?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgResult == DialogResult.Yes)
            {
                String naziv = listaStanica.SelectedItems[0].SubItems[1].Text;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
                var collectionZaposleni = db.GetCollection<Zaposleni>("zaposleni");
                var collectionMerenja = db.GetCollection<Merenje>("merenja");

                var query = Query.And(
                   Query.EQ("Okrug", this.okrug),
                   Query.EQ("Naziv", naziv));
                var result = collection.Find(query).ToList<VremenskaStanica>();
                VremenskaStanica s = result[0];
                foreach (MongoDBRef zaposleniRef in s.Odgovorni.ToList())
                {
                    Zaposleni z = db.FetchDBRefAs<Zaposleni>(zaposleniRef);
                    var queryZaposleni = Query.EQ("Jmbg", z.Jmbg);
                    collectionZaposleni.Remove(queryZaposleni);
                }
                foreach (MongoDBRef merenjeRef in s.IzmereneVrednosti.ToList())
                {
                    Merenje m = db.FetchDBRefAs<Merenje>(merenjeRef);
                    var queryMerenje = Query.EQ("_id", new ObjectId(m.Id.ToString()));
                    collectionMerenja.Remove(queryMerenje);
                }
                collection.Remove(query);
                MessageBox.Show("Uspesno ste obrisali vremensku stanicu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PopuniTabelu();
            }
            else
            {
                return;
            }
        }

        private void VremenskeStanice_Load(object sender, EventArgs e)
        {

        }
    }
}
