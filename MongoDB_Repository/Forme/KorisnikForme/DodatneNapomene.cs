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

namespace MongoNBP.Forme.KorisnikForme
{
    public partial class DodatneNapomene : Form
    {
        private VremenskaStanica vs;
        private List<Temperatura> nizTemperatura;
        private List<Padavine> nizPadavina;
        private List<VlaznostVazduha> nizVlaznost;
        public DodatneNapomene()
        {
            InitializeComponent();
            UcitajVremenskeStanice();
            nizVlaznost = new List<VlaznostVazduha>();
            nizTemperatura = new List<Temperatura>();
            nizPadavina = new List<Padavine>();
        }
        public void UcitajVremenskeStanice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collectionStanice = db.GetCollection<VremenskaStanica>("vremenske_stanice");

            var result = collectionStanice.FindAll().ToList<VremenskaStanica>();

            if (result.Count<VremenskaStanica>() != 0)
            {
                foreach (VremenskaStanica vstanica in result)
                {
                    cmbStanice.Items.Add(vstanica.ToString());
                }
              
            }
            else
            {
                MessageBox.Show("Nema dostupnih vremenskih stanica!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PribaviPodatkeZaVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            string[] pom = cmbStanice.SelectedItem.ToString().Split(' ');

            var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");

            var query = Query.EQ("Naziv", pom[2]);
            var result = collection.Find(query);
            if (result.Count<VremenskaStanica>() == 0)
            {
                MessageBox.Show("Nema Vremenske stanice!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (VremenskaStanica vrs in result)
                {
                    vs = new VremenskaStanica(vrs.Id, vrs.Naziv, vrs.Drzava, vrs.Okrug, vrs.Mesto, vrs.IzmereneVrednosti);
                }
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            txbPadavine.Text = "";
            txbTemperatura.Text = "";
            txbVlaznost.Text = "";
            nizPadavina.Clear();
            nizTemperatura.Clear();
            nizVlaznost.Clear();
            if (cmbStanice.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednu stanicu! Molimo Vas izaberite stanicu.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PribaviPodatkeZaVremenskuStanicu();
           

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            // KOLEKCIJE "vremenski_parametri" i "merenja"
            var collectionParametri = db.GetCollection<VremenskiParametar>("vremenski_parametri");
            var collectionMerenja = db.GetCollection<Merenje>("merenja");

            // Punimo nizMerenja
            foreach (MongoDBRef merenjaRef in vs.IzmereneVrednosti.ToList())
            {
                Merenje m = db.FetchDBRefAs<Merenje>(merenjaRef);
                Temperatura t = db.FetchDBRefAs<Temperatura>(m.TempData);
                Padavine p = db.FetchDBRefAs<Padavine>(m.PadavineData);
                VlaznostVazduha vv = db.FetchDBRefAs<VlaznostVazduha>(m.VlaznostData);

                nizTemperatura.Add(t);
                nizPadavina.Add(p);
                nizVlaznost.Add(vv);
            }

           
            nizTemperatura.Reverse();
            nizPadavina.Reverse();
            nizVlaznost.Reverse();

            foreach (Temperatura t in nizTemperatura)
                if(t.Napomena!=null)
                    txbTemperatura.Text += t.ToString() + Environment.NewLine;

            foreach (Padavine p in nizPadavina)
                txbPadavine.Text += p.ToString() + Environment.NewLine;

            foreach (VlaznostVazduha v in nizVlaznost)
                if(v.Procentualno!=0)
                txbVlaznost.Text += v.ToString() + Environment.NewLine;


        }
    }
}
