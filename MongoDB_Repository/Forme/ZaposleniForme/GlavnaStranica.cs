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
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB_Repository.Entiteti;
using Podaci;


namespace MongoDB_Repository.Forme.ZaposleniForme
{
    public partial class GlavnaStranica : Form
    {
        private Zaposleni zaposleni;

        public GlavnaStranica()
        {
            InitializeComponent();
        }

        public GlavnaStranica(Zaposleni z)
        {
            InitializeComponent();
            OsveziStranicu(z);
        }

        public void OsveziStranicu(Zaposleni z)
        {
            this.zaposleni = z;
            this.lblIme.Text = z.Ime.ToUpper();
            this.lblPrezime.Text = z.Prezime.ToUpper();
            this.lblJmbg.Text = z.Jmbg.ToUpper();
            this.lblZvanje.Text = z.Zvanje.ToUpper();
            this.PribaviPodatkeZaVremenskuStanicu();
        }
        

        public void PribaviPodatkeZaVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Zaposleni>("zaposleni");
            VremenskaStanica s = db.FetchDBRefAs<VremenskaStanica>(zaposleni.VremenskaStanica);
            this.lblNazivStanice.Text = s.Naziv.ToUpper();
            this.lblOkrug.Text = s.Okrug.ToUpper();
        }
        public VremenskaStanica vratiVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Zaposleni>("zaposleni");
            VremenskaStanica s = db.FetchDBRefAs<VremenskaStanica>(zaposleni.VremenskaStanica);
            return s;


        }

        private void formeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izmeniLicnePodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new ZaposleniProfil(this.zaposleni);
            //forma.MdiParent = this; za sve ostale forme kod zaposlenog ovo mora da se setuje
            forma.ShowDialog();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Zaposleni>("zaposleni");
            var query = Query.EQ("Jmbg", zaposleni.Jmbg);
            var result = collection.Find(query).ToList<Zaposleni>();
            OsveziStranicu(result[0]);
        }

        private void unesiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new FormaZaUnosPodataka(zaposleni);
            forma.MdiParent = this;
            forma.Show();
        }

        private void grafiskiPrikazPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new GrafickiPrikaz("temperatura", zaposleni);
            forma.MdiParent = this;
            forma.Show();
        }

        private void padavineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new GrafickiPrikaz("padavine", zaposleni);
            forma.MdiParent = this;
            forma.Show();
        }

        private void vlaznostVazduhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new GrafickiPrikaz("vlaznost_vazduha", zaposleni);//kao argument string
            forma.MdiParent = this;
            forma.Show();
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Statistika(zaposleni);
            forma.MdiParent = this;
            forma.Show();
        }

        private void GlavnaStranica_Load(object sender, EventArgs e)
        {
            //zaposleni
        }
    }
}
