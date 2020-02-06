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

namespace MongoDB_Repository.Forme.ZaposleniForme
{
    public partial class ZaposleniProfil : Form
    {
        private Zaposleni zaposleni;

        public ZaposleniProfil()
        {
            InitializeComponent();
        }

        public ZaposleniProfil(Zaposleni z)
        {
            InitializeComponent();
            this.zaposleni = z;
            this.zaposleni = z;
            this.txbIme.Text = z.Ime;
            this.txbPrezime.Text = z.Prezime;
            this.txbJmbg.Text = z.Jmbg;
            this.txbZvanje.Text = z.Zvanje;
            this.txbUsername.Text = z.Username;
            this.txbPassword.Text = z.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izmene?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("MongoNBP");

                var collection = db.GetCollection<Zaposleni>("zaposleni");
                
                var update = Update<Zaposleni>.Set(z => z.Ime, txbIme.Text).
                                                      Set(z => z.Prezime, txbPrezime.Text).
                                                      Set(z => z.Zvanje, txbZvanje.Text).
                                                      Set(z => z.Password, txbPassword.Text);

                var query = Query.EQ("Jmbg", zaposleni.Jmbg);
                if (txbUsername.Text!=zaposleni.Username)
                {
                    query = Query.EQ("Username", txbUsername.Text);
                    var result=collection.Find(query);
                    if(result.Count<Zaposleni>()!=0)
                    {
                        MessageBox.Show("Zeljeno korisnicko ime je zauzeto! Pokusajte sa drugim.", 
                            "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        query = Query.EQ("Jmbg", zaposleni.Jmbg);
                        collection.Update(query, update);
                        update = Update<Zaposleni>.Set(z => z.Username, txbUsername.Text);
                        collection.Update(query, update);
                    }
                }
                else
                {
                    collection.Update(query, update);
                }
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
