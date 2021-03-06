﻿using System;
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
    public partial class Statistika : Form
    {
        private Korisnik korisnik;
        private VremenskaStanica vs;
        private int brojac = 0;

        private List<Merenje> nizMerenja = new List<Merenje>();
        private List<Temperatura> nizTemperatura = new List<Temperatura>();
        private List<Padavine> nizPadavine = new List<Padavine>();
        private List<VlaznostVazduha> nizVlaznostVazduha = new List<VlaznostVazduha>();
        public Statistika(Korisnik korisnik)
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
                    comboBoxVremenskaS.Items.Add(vstanica.ToString());
                }
                //comboBoxVremenskaS.SelectedItem = comboBoxVremenskaS.Items.Count - 1;
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
            string[] pom = comboBoxVremenskaS.SelectedItem.ToString().Split(' ');

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
                   vs = new VremenskaStanica(vrs.Id,vrs.Naziv,vrs.Drzava,vrs.Okrug,vrs.Mesto,vrs.IzmereneVrednosti);
                }
            }
        }
        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            //logika ista kao kod zaposlenog
            if (comboBoxVremenskaS.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednu stanicu! Molimo Vas izaberite stanicu.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PribaviPodatkeZaVremenskuStanicu();
            brojac = 0;

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
                nizMerenja.Add(m);

                Temperatura t = db.FetchDBRefAs<Temperatura>(m.TempData);
                Padavine p = db.FetchDBRefAs<Padavine>(m.PadavineData);
                VlaznostVazduha vv = db.FetchDBRefAs<VlaznostVazduha>(m.VlaznostData);

                nizTemperatura.Add(t);
                nizPadavine.Add(p);
                nizVlaznostVazduha.Add(vv);

                brojac++;
            }

            //Gleda se u odnosu na zadnjih n merenja
            nizTemperatura.Reverse();
            nizPadavine.Reverse();
            nizVlaznostVazduha.Reverse();

            if (numBrMerenja.Value > brojac)
            {
                MessageBox.Show("Uneli ste veci broj merenja od postojecih u bazi podataka (Trenutno postoji: " + brojac + " merenja!)", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double zbirT = 0, zbirP = 0, zbirVV = 0;

            for (int i = 0; i < numBrMerenja.Value; i++)
            {
                zbirT += nizTemperatura[i].Vrednost;
                zbirP += nizPadavine[i].Vrednost;
                zbirVV += nizVlaznostVazduha[i].Vrednost;
            }

            txbTemperatura.Text = (zbirT / (double)numBrMerenja.Value).ToString();
            txbPadavine.Text = (zbirP / (double)numBrMerenja.Value).ToString();
            txbVlaznost.Text = (zbirVV / (double)numBrMerenja.Value).ToString();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxVremenskaS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
