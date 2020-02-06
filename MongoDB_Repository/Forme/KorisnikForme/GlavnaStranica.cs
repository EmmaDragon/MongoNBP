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
using MongoNBP.Forme.KorisnikForme;

namespace MongoDB_Repository.Forme.KorisnikForme
{
    public partial class GlavnaStranica : Form
    {
        private Korisnik korisnik;
        public GlavnaStranica()
        {
            InitializeComponent();

        }
        public GlavnaStranica(Korisnik k)
        {
            this.korisnik = k;
            InitializeComponent();
            OsveziStranicu(k);
        }
        public void OsveziStranicu(Korisnik k)
        { 
            this.korisnik = k;
            this.lblIme.Text = k.Ime.ToUpper();
            this.lblPrezime.Text = k.Prezime.ToUpper();
            this.lblUsername.Text = k.Username;



        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void unesiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GlavnaStranica_Load(object sender, EventArgs e)
        {
            //korisnik
        }

        private void IzmeniLicnePodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new IzmenaPodataka(this.korisnik);
            forma.ShowDialog();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Korisnik>("korisnik");
            var query = Query.EQ("_id", ObjectId.Parse(this.korisnik.Id.ToString()));
            var result = collection.Find(query).ToList<Korisnik>();
            OsveziStranicu(result[0]);

        }

        private void TemperaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //korisnik
            Form forma = new GrafickiPrikaz("temperatura", korisnik);
            forma.MdiParent = this;
            forma.Show();
        }

        private void StatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Statistika(this.korisnik);
            forma.ShowDialog();
        }

        private void PadavineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form forma = new GrafickiPrikaz("padavine", korisnik);
            forma.MdiParent = this;
            forma.Show();
        }

        private void VlaznostVazduhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form forma = new GrafickiPrikaz("vlaznost_vazduha", korisnik);//kao argument string
            forma.MdiParent = this;
            forma.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EksportujVrednostiMerenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EksportujMerenjaVremenskihStanicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Eksportovanje();
            forma.ShowDialog();
        }

        private void dodatneNapomeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new DodatneNapomene();
            forma.MdiParent = this;
            forma.Show();

        }
    }
}
