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
    public partial class LogIn_Zaposleni : Form
    {
        public LogIn_Zaposleni()
        {
            InitializeComponent();
        }

        private void onPasswordTextChanged(object sender, MouseEventArgs e)
        {
            txbPassword.Text = "";
        }

        private void onUsernameTextChanged(object sender, MouseEventArgs e)
        {
            txbUsername.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<Zaposleni>("zaposleni");

            var query = Query.And(
                           Query.EQ("Username", txbUsername.Text),
                           Query.EQ("Password", txbPassword.Text)
                           );

            var result = collection.Find(query);

            if (result.Count<Zaposleni>() == 0)
            {
                MessageBox.Show("Pogresno uneto korisnicko ime ili sifra!","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                foreach (Zaposleni z in result)
                {
                    Zaposleni zaposleni = new Zaposleni(z.Id, z.Ime, z.Prezime, z.Username, z.Password, z.Jmbg, z.Zvanje, z.VremenskaStanica);
                    Form forma = new GlavnaStranica(zaposleni);
                    forma.ShowDialog();
                }
            }
        }
    }
}
