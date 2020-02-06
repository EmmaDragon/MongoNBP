using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository.Entiteti
{
    public class Admin
    {
        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Okrug { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public Admin(String ime, String prezime, String username, String password, String okrug)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.Okrug = okrug;
        }

        public Admin(ObjectId id, String ime, String prezime, String username, String password, String okrug)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.Okrug = okrug;
        }
    }
}
