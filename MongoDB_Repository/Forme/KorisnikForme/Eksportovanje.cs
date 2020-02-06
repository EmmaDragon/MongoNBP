using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository.Forme.KorisnikForme
{
    public partial class Eksportovanje : Form
    {
        private VremenskaStanica vs;
        public Eksportovanje()
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
                    comboBox1.Items.Add(vstanica.ToString());
                }
                //comboBoxVremenskaS.SelectedItem = comboBoxVremenskaS.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Nema dostupnih vremenskih stanica!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExportTxt_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem==null)
            {
                MessageBox.Show("Niste izabrali ni jednu stanicu! Molimo Vas izaberite stanicu.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                PribaviPodatkeZaVremenskuStanicu();
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                // KOLEKCIJE "vremenski_parametri" i "merenja"
                var collectionParametri = db.GetCollection<VremenskiParametar>("vremenski_parametri");
                var collectionMerenja = db.GetCollection<Merenje>("merenja");
                if (vs.IzmereneVrednosti.ToList().Count != 0)
                {
                    foreach (MongoDBRef merenjaRef in vs.IzmereneVrednosti.ToList())
                    {

                        Merenje m = db.FetchDBRefAs<Merenje>(merenjaRef);

                        Temperatura t = db.FetchDBRefAs<Temperatura>(m.TempData);
                        Padavine p = db.FetchDBRefAs<Padavine>(m.PadavineData);
                        VlaznostVazduha vv = db.FetchDBRefAs<VlaznostVazduha>(m.VlaznostData);
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFile.FileName+".txt", true))
                        {

                            file.WriteLine("Merenje ID: " + m.Id + " Vreme merenja: " + m.Log);
                            file.WriteLine("");
                            file.WriteLine("Temeratura:       " + t.Vrednost);
                            file.WriteLine("Padavine:         " + p.Vrednost);
                            file.WriteLine("Vlaznost Vazduha: " + vv.Vrednost);
                            file.WriteLine("");

                        }
                    }
                    MessageBox.Show("Uspesno je kreiran fajl i ekportovane vrednosti!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vremenska stanica " + vs.ToString() + " nema izmerenih vrednosti! Pokusajte sa drugom stanicom.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           
           
        }
        public void PribaviPodatkeZaVremenskuStanicu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            // string pom = comboBox1.SelectedItem.ToString();
            string[] pom = comboBox1.SelectedItem.ToString().Split(' ');

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
    }
}
