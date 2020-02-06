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
    public partial class GrafickiPrikaz : Form
    {

        private Korisnik korisnik;

      
        private VremenskaStanica vs;
        private double minTemp = 0, maxTemp = 0;
        private double minPad = 0, maxPad = 0;
        private double minVlVazd = 0, maxVlVazd = 0;
        private int brojac = 0;
        private string parametar;

        private List<Merenje> nizMerenja = new List<Merenje>();
        private List<double> nizTemperatura = new List<double>();
        private List<double> nizPadavine = new List<double>();
        private List<double> nizVlaznostVazduha = new List<double>();

        private List<double> logNizTemperatura = new List<double>();
        private List<double> logNizPadavine = new List<double>();
        private List<double> logNizVlaznostVazduha = new List<double>();

        public GrafickiPrikaz()
        {
            InitializeComponent();
            UcitajVremenskeStanice();
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
                //comboBoxVremenskaS.SelectedItem = comboBoxVremenskaS.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Nema dostupnih vremenskih stanica!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public GrafickiPrikaz(string v, Korisnik korisnik)
        {
            InitializeComponent();
            UcitajVremenskeStanice();
            this.parametar = v;
            this.korisnik = korisnik;
            this.Text = "GRAFICKI PRIKAZ - " + parametar.ToUpper();
        }

        private void GrafickiPrikaz_Load(object sender, EventArgs e)
        {
            //ista logika kao kod zaposlenog s tim sto korisnik selektuje stanicu cije podatke zeli da vidi
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (cmbStanice.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednu stanicu! Molimo Vas izaberite stanicu.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PribaviPodatkeZaVremenskuStanicu();
            PribaviPodatke();
            timerUpdate.Start();
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
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            PribaviPodatkeZaVremenskuStanicu();
            PribaviPodatke();

            if (rdbLinearni.Checked == true)
                linearniPrikaz();
            else if (rdbLogaritamski.Checked == true)
                logaritamskiPrikaz();
        }

        private void CmbStanice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PribaviPodatke()
        {
            brojac = 0;

            nizTemperatura.Clear();
            nizPadavine.Clear();
            nizVlaznostVazduha.Clear();

            logNizTemperatura.Clear();
            logNizPadavine.Clear();
            logNizVlaznostVazduha.Clear();

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            // KOLEKCIJE "vremenski_parametri" i "merenja"
            var collectionPadavine = db.GetCollection<VremenskiParametar>("vremenski_parametri");
            var collectionMerenja = db.GetCollection<Merenje>("merenja");

            // Punimo nizMerenja
            foreach (MongoDBRef merenjaRef in vs.IzmereneVrednosti.ToList())
            {
                Merenje m = db.FetchDBRefAs<Merenje>(merenjaRef);
                nizMerenja.Add(m);

                Temperatura t = db.FetchDBRefAs<Temperatura>(m.TempData);
                Padavine p = db.FetchDBRefAs<Padavine>(m.PadavineData);
                VlaznostVazduha vv = db.FetchDBRefAs<VlaznostVazduha>(m.VlaznostData);

                nizTemperatura.Add(t.Vrednost);
                nizPadavine.Add(p.Vrednost);
                nizVlaznostVazduha.Add(vv.Vrednost);

                if (Math.Log(t.Vrednost) > 0)
                {
                    logNizTemperatura.Add(Math.Log(t.Vrednost));
                }
                if (Math.Log(p.Vrednost) > 0)
                {
                    logNizPadavine.Add(Math.Log(p.Vrednost));
                }
                if (Math.Log(vv.Vrednost) > 0)
                {
                    logNizVlaznostVazduha.Add(Math.Log(vv.Vrednost));
                }

                brojac++;
            }
        }

        private void logaritamskiPrikaz()
        {
            if (parametar == "temperatura")
            {
                chart.Series["Temperatura"].IsXValueIndexed = true;
                chart.Series["Temperatura"].XValueMember = "x";
                chart.Series["Temperatura"].YValueMembers = "y";

                minTemp = vs.minTemperatura;
                maxTemp = vs.maxTemperatura;
                chart.DataSource = logNizTemperatura.ToList();



            }
            else if (parametar == "padavine")
            {
                chart.Series["Padavine"].IsXValueIndexed = true;
                chart.Series["Padavine"].XValueMember = "x";
                chart.Series["Padavine"].YValueMembers = "y";

                minPad = vs.minPadavine;
                maxPad = vs.maxPadavine;
                chart.DataSource = logNizPadavine.ToList();
            }
            else if (parametar == "vlaznost_vazduha")
            {
                chart.Series["Vlaznost vazduha"].IsXValueIndexed = true;
                chart.Series["Vlaznost vazduha"].XValueMember = "x";
                chart.Series["Vlaznost vazduha"].YValueMembers = "y";

                minVlVazd = vs.minVlaznost;
                maxVlVazd = vs.maxVlaznost;
                chart.DataSource = logNizVlaznostVazduha.ToList();
            }

            chart.DataBind();
        }

        private void linearniPrikaz()
        {
            if (parametar == "temperatura")
            {
                chart.Series["Temperatura"].IsXValueIndexed = true;
                chart.Series["Temperatura"].XValueMember = "x";
                chart.Series["Temperatura"].YValueMembers = "y";

                minTemp = vs.minTemperatura;
                maxTemp = vs.maxTemperatura;
                chart.DataSource = nizTemperatura.ToList();

            }
            else if (parametar == "padavine")
            {
                chart.Series["Padavine"].IsXValueIndexed = true;
                chart.Series["Padavine"].XValueMember = "x";
                chart.Series["Padavine"].YValueMembers = "y";

                minPad = vs.minPadavine;
                maxPad = vs.maxPadavine;
                chart.DataSource = nizPadavine.ToList();
            }
            else if (parametar == "vlaznost_vazduha")
            {
                chart.Series["Vlaznost vazduha"].IsXValueIndexed = true;
                chart.Series["Vlaznost vazduha"].XValueMember = "x";
                chart.Series["Vlaznost vazduha"].YValueMembers = "y";

                minVlVazd = vs.minVlaznost;
                maxVlVazd = vs.maxVlaznost;
                chart.DataSource = nizVlaznostVazduha.ToList();
            }

            chart.DataBind();
        }

    }
}
