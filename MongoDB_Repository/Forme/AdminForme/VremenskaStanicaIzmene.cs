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
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using Podaci;

namespace MongoDB_Repository.Forme.AdminForme
{
    public partial class VremenskaStanicaIzmene : Form
    {
        private VremenskaStanica stanica;

        public VremenskaStanicaIzmene()
        {
            InitializeComponent();
        }

        public VremenskaStanicaIzmene(VremenskaStanica s)
        {
            InitializeComponent();
            this.stanica = s;
            this.Text += " " + s.Naziv.ToUpper();
            txbNaziv.Text = s.Naziv;
            txbMesto.Text = s.Mesto;
            minTemp.Value = (decimal)s.minTemperatura;
            maxTemp.Value = (decimal)s.maxTemperatura;
            minPadavine.Value = (decimal)s.minPadavine;
            maxPadavine.Value = (decimal)s.maxPadavine;
            minHumm.Value = (decimal)s.minVlaznost;
            maxHumm.Value = (decimal)s.maxVlaznost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izmene?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collection = db.GetCollection<VremenskaStanica>("vremenske_stanice");
                var query = Query.And(Query.EQ("Okrug", stanica.Okrug),
                            Query.EQ("Naziv", stanica.Naziv));
                var update = Update<VremenskaStanica>.Set(v => v.Mesto, txbMesto.Text).
                                                      Set(v => v.minTemperatura, (Double)minTemp.Value).
                                                      Set(v => v.maxTemperatura, (Double)maxTemp.Value).
                                                      Set(v => v.minPadavine, (Double)minPadavine.Value).
                                                      Set(v => v.maxPadavine, (Double)maxPadavine.Value).
                                                      Set(v => v.minVlaznost, (Double)minHumm.Value).
                                                      Set(v => v.maxVlaznost, (Double)maxHumm.Value);
                
                collection.Update(query, update);
                MessageBox.Show("Uspesno ste izvrsili izmene!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
