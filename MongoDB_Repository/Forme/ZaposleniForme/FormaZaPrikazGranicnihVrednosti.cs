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

namespace MongoDB_Repository.Forme.ZaposleniForme
{
    public partial class FormaZaPrikazGranicnihVrednosti : Form
    {
        private Zaposleni zaposleni;
        private VremenskaStanica vs;

        public FormaZaPrikazGranicnihVrednosti()
        {
            InitializeComponent();
            PribaviPodatkeZaVremenskuStanicu();
        }

        public FormaZaPrikazGranicnihVrednosti(string parametar, Zaposleni zap)
        {
            InitializeComponent();

            this.zaposleni = zap;
            PribaviPodatkeZaVremenskuStanicu();

            if(parametar == "temperatura")
            {
                PopuniPodatkeTemperatura();
            }
            else if(parametar == "padavine")
            {
                PopuniPodatkePadavine();
            }
            else if (parametar == "vlaznost")
            {
                PopuniPodatkeVlaznost();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PribaviPodatkeZaVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Zaposleni>("zaposleni");
            vs = db.FetchDBRefAs<VremenskaStanica>(zaposleni.VremenskaStanica);
        }

        public void PopuniPodatkeTemperatura()
        {
            lblMinVrednost.Text = vs.minTemperatura.ToString()+" C";
            lblMaxVrednost.Text = vs.maxTemperatura.ToString()+" C";
        }

        public void PopuniPodatkeVlaznost()
        {
            lblMinVrednost.Text = vs.minVlaznost.ToString() + " mm Hg";
            lblMaxVrednost.Text = vs.maxVlaznost.ToString() + " mm Hg";
        }

        public void PopuniPodatkePadavine()
        {
            lblMinVrednost.Text = vs.minPadavine.ToString() + " l/m2";
            lblMaxVrednost.Text = vs.maxPadavine.ToString() + " l/m2";
        }
    }
}
