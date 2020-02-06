using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Podaci
{
    public class Zaposleni
    {
        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Jmbg { get; set; }
        public String Zvanje { get; set; }
        public String DatumZaposlenja { get; set; }
        public MongoDBRef VremenskaStanica { get; set; }

        public Zaposleni(ObjectId id, String ime, String prezime, String username, String password, String jmbg, String zvanje, MongoDBRef stanica)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.Jmbg = jmbg;
            this.Zvanje = zvanje;
            this.VremenskaStanica = stanica;
            
        }

        public Zaposleni(String ime, String prezime, String username, String password, String jmbg, String zvanje, MongoDBRef stanica)
        {

            this.Ime = ime;
            this.Prezime = prezime;
            this.Username = username;
            this.Password = password;
            this.Jmbg = jmbg;
            this.Zvanje = zvanje;
            this.VremenskaStanica = stanica;
        }

    }
}
