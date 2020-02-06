using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB_Repository.Entiteti;

namespace MongoDB_Repository.Forme.AdminForme
{
    public partial class LogIn_Admin : Form
    {
        public LogIn_Admin()
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

            var collection = db.GetCollection<Admin>("admin");

            var query = Query.And(
                           Query.EQ("Username", txbUsername.Text),
                           Query.EQ("Password", txbPassword.Text)
                           );

            var result = collection.Find(query);
            if (result.Count<Admin>()==0)
            {
                MessageBox.Show("Pogresno uneto korisnicko ime ili sifra!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Admin a in result)
                {
                    Admin admin = new Admin(a.Id, a.Ime, a.Prezime, a.Username, a.Password, a.Okrug);
                    Form forma = new Dashboard(admin);
                    forma.ShowDialog();
                }
            }
        }
    }
}
