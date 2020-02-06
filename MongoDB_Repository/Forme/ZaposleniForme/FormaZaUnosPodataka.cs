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
    public partial class FormaZaUnosPodataka : Form
    {
        private Zaposleni zaposleni;
        private VremenskaStanica vs;
        private int brojac = 0;

        public FormaZaUnosPodataka()
        {
            InitializeComponent();
            PribaviPodatkeZaVremenskuStanicu();
        }

        public FormaZaUnosPodataka(Zaposleni zap)
        {
            InitializeComponent();
            this.zaposleni = zap;
            PribaviPodatkeZaVremenskuStanicu();
        }

        private void btnTempGranice_Click(object sender, EventArgs e)
        {
            Form forma = new FormaZaPrikazGranicnihVrednosti("temperatura", zaposleni);
            forma.ShowDialog();
        }

        private void btnPadavineGranice_Click(object sender, EventArgs e)
        {
            Form forma = new FormaZaPrikazGranicnihVrednosti("padavine", zaposleni);
            forma.ShowDialog();
        }

        private void btnVlaznostGranice_Click(object sender, EventArgs e)
        {
            Form forma = new FormaZaPrikazGranicnihVrednosti("vlaznost", zaposleni);
            forma.ShowDialog();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if(chbGranice.Checked == false)
            {
                if (!Validacija())
                    return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            // KOLEKCIJA "vremenski_parametri"
            var collectionParametri = db.GetCollection<VremenskiParametar>("vremenski_parametri");
            
            Temperatura temp = new Temperatura(vs.minTemperatura, vs.maxTemperatura, (double)numTemperatura.Value, new MongoDBRef("zaposleni", zaposleni.Id));
            Padavine pad = new Padavine(vs.minPadavine, vs.maxPadavine, (double)numPadavine.Value, new MongoDBRef("zaposleni", zaposleni.Id));
            VlaznostVazduha VlVazd = new VlaznostVazduha(vs.minVlaznost, vs.maxVlaznost, (double)numVlaznost.Value, new MongoDBRef("zaposleni", zaposleni.Id));

            if (txbNapomena.Text != "")
                temp.Napomena = txbNapomena.Text;
            if (chbDa.Checked == true)
                pad.opasnostOdPoplava = true;
            if (chbNe.Checked == true)
                pad.opasnostOdPoplava = false;
            if (numProcenti.Value != 0)
                VlVazd.Procentualno = (float)numProcenti.Value;

            collectionParametri.Insert(temp);
            collectionParametri.Insert(pad);
            collectionParametri.Insert(VlVazd);

            // KOLEKCIJA "merenja"
            var collectionMerenja = db.GetCollection<Merenje>("merenja");

            Merenje merenje = new Merenje(new MongoDBRef("vremenski_parametri", temp.Id), new MongoDBRef("vremenski_parametri", VlVazd.Id), new MongoDBRef("vremenski_parametri", pad.Id));

            collectionMerenja.Insert(merenje);

            // KOLEKCIJA "vremenske_stanice"
            var collectionVremenskeStanice = db.GetCollection<VremenskaStanica>("vremenske_stanice");
            vs.IzmereneVrednosti.Add(new MongoDBRef("merenja", merenje.Id));
            collectionVremenskeStanice.Save(vs);

            if(chbAutomatskoGenerisanjePodataka.Checked)
            {
                brojac = 0;
                //MessageBox.Show("Automatski su uneti podaci novog merenja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Uspesno ste uneli podatke novog merenja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PribaviPodatkeZaVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Zaposleni>("zaposleni");
            vs = db.FetchDBRefAs<VremenskaStanica>(zaposleni.VremenskaStanica);
        }

        public bool Validacija()
        {
            bool ind = true;

            if ((double)numTemperatura.Value < vs.minTemperatura)
            {
                MessageBox.Show("Uneta vrednost temperature je ispod dozvoljenog minimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if ((double)numTemperatura.Value > vs.maxTemperatura)
            {
                MessageBox.Show("Uneta vrednost temperature je iznad dozvoljenog maksimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if ((double)numPadavine.Value < vs.minPadavine)
            {
                MessageBox.Show("Uneta vrednost padavina je ispod dozvoljenog minimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if ((double)numPadavine.Value > vs.maxPadavine)
            {
                MessageBox.Show("Uneta vrednost padavina je iznad dozvoljenog maksimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if ((double)numVlaznost.Value < vs.minVlaznost)
            {
                MessageBox.Show("Uneta vrednost vlaznosti vazduha je ispod dozvoljenog minimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }
            else if ((double)numVlaznost.Value > vs.maxVlaznost)
            {
                MessageBox.Show("Uneta vrednost vlaznosti vazduha je iznad dozvoljenog maksimuma", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
            }

            return ind;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (brojac == 5)
            {
                Random rnd = new Random();

                numTemperatura.Value = rnd.Next((int)vs.minTemperatura, (int)vs.maxTemperatura);
                numPadavine.Value = rnd.Next((int)vs.minPadavine, (int)vs.maxPadavine);
                numVlaznost.Value = rnd.Next((int)vs.minVlaznost, (int)vs.maxVlaznost);
                lblProsledjeno.Text = "PROSLEDJENO";
                brojac = 0;
                btnProsledi_Click(sender, e);
            }
            else
            {
                lblProsledjeno.Text = "";
                brojac++;
            }
        }

        private void FormaZaUnosPodataka_Load(object sender, EventArgs e)
        {
            lblProsledjeno.Text = "";
        }

        private void chbAutomatskoGenerisanjePodataka_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutomatskoGenerisanjePodataka.Checked == true)
            {
                brojac = 0;
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                brojac = 0;
                timer1.Stop();
            }
        }
    }
}
