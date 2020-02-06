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
    public partial class KreiranjeNaloga : Form
    {
        public KreiranjeNaloga()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");

            var collection = db.GetCollection<Korisnik>("korisnik");
            if (Validacija())
            {
                
                    Korisnik kor;// = new Korisnik(1, txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text);
                    if (txbZvanje.Text != "" && txbJmbg.Text != "" && maskedTextBox1.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, txbZvanje.Text, txbJmbg.Text, maskedTextBox1.Text);
                    else if (txbZvanje.Text != "" && txbJmbg.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, txbZvanje.Text, txbJmbg.Text, null);
                    else if (txbZvanje.Text != "" && maskedTextBox1.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, txbZvanje.Text, null, maskedTextBox1.Text);
                    else if (txbJmbg.Text != "" && maskedTextBox1.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, null, txbJmbg.Text, maskedTextBox1.Text);
                    else if (txbZvanje.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, txbZvanje.Text, null, null);
                    else if (txbJmbg.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, null, txbJmbg.Text, null);
                    else if (maskedTextBox1.Text != "")
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, null, null, maskedTextBox1.Text);
                    else
                        kor = new Korisnik(txbIme.Text, txbPrezime.Text, txbUsername.Text, txbPassword.Text, null, null, null);


                if (ValidacijaUsername(txbUsername.Text))
                {

                    DialogResult msgResult = MessageBox.Show("Da li ste sigurni da zelite da sacuvate podatke?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msgResult == DialogResult.Yes)
                    {
                        collection.Insert(kor);

                        MessageBox.Show("Uspesno ste izvrsili kreiranje naloga!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }

            }

        }
        public bool Validacija()
        {
            bool ind = true;

            if (txbIme.Text == "")
            {
                MessageBox.Show("Niste uneli Ime korisnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
                return ind;
            }
            if (txbPrezime.Text == "")
            {
                MessageBox.Show("Niste uneli Prezime korisnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
                return ind;
            }
            if (txbUsername.Text == "")
            {
                MessageBox.Show("Niste uneli Username korisnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
                return ind;
            }
            if (txbPassword.Text == "")
            {
                MessageBox.Show("Niste uneli Password korisnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ind = false;
                return ind;
            }
            return ind;
        }
        public bool ValidacijaUsername(String username)
        {
            bool ind = true;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("MongoNBP");
            var collection = db.GetCollection<Korisnik>("korisnik");

            var query = Query.EQ("Username", username);
            var result = collection.Find(query);

            if (result.Count<Korisnik>() != 0)
            {
                MessageBox.Show("Username koji zelite da koristite vec postoji! Pokusajte sa drugin username-om.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return !ind;
            }
            else

                return ind;
        }
    }

}
