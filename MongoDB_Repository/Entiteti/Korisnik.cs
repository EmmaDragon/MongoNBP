using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Podaci
{
    public class Korisnik
    {
        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String DatumRodjenja { get; set; }
        public String Jmbg { get; set; }
        public String Zvanje { get; set; }
        //mozda treba dodati jos neki konstruktor

        public Korisnik(ObjectId id, String ime, String prezime, String username, String password)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
        }

        public Korisnik(String ime, String prezime, String username, String password, MongoDBRef stanica)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
        }
        public Korisnik(String ime, String prezime, String username, String password, String zvanje, String JMBG, String DatumRodj)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.DatumRodjenja = DatumRodj;
            this.Jmbg = JMBG;
            this.Zvanje = zvanje;
        }
        public Korisnik(ObjectId id, String ime, String prezime, String username, String password, String zvanje, String JMBG, String DatumRodj)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.DatumRodjenja = DatumRodj;
            this.Jmbg = JMBG;
            this.Zvanje = zvanje;
        }
    }
}
