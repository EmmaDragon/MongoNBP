using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Podaci
{
    public class VremenskiParametar
    {
        public ObjectId Id { get; set; }
        public MongoDBRef Odgovorni { get; set; }
        public double Vrednost { get; set; }
        public DateTime VremeEvidentiranja { get; set; }
        public Double DonjaGranica { get; set; }
        public Double GornjaGranica { get; set; }
        public String Jedinica { get; set; }
    }

    public class Temperatura : VremenskiParametar
    {
        public String Napomena;
        public Temperatura()
        {
            this.Vrednost = -9999;
        }

        public Temperatura(double min, double max, double vrednost, MongoDBRef odgovorni)
        {
            this.DonjaGranica = min;
            this.GornjaGranica = max;
            this.Vrednost = vrednost;
            this.Jedinica = "C";
            this.Odgovorni = odgovorni;
            this.VremeEvidentiranja = DateTime.Now;
            
            
        }
        public override String ToString()
        {
            return this.VremeEvidentiranja.ToString() + " :: " + this.Napomena;
        }
        
    }

    public class VlaznostVazduha : VremenskiParametar
    {
        public float Procentualno;
        public VlaznostVazduha()
        {
            this.Vrednost = -9999;
        }

        public VlaznostVazduha(double min, double max, double vrednost, MongoDBRef odgovorni)
        {
            this.DonjaGranica = min;
            this.GornjaGranica = max;
            this.Vrednost = vrednost;
            this.Jedinica = "mm Hg";
            this.Odgovorni = odgovorni;
            this.VremeEvidentiranja = DateTime.Now;
        }
        public override String ToString()
        {
            return this.VremeEvidentiranja.ToString() + " :: " + this.Procentualno+" %";
        }
    }

    public class Padavine : VremenskiParametar
    {
        public bool opasnostOdPoplava;
        public Padavine()
        {
            this.Vrednost = -9999;
        }

        public Padavine(double min, double max, double vrednost, MongoDBRef odgovorni)
        {
            this.DonjaGranica = min;
            this.GornjaGranica = max;
            this.Vrednost = vrednost;
            this.Jedinica = "l/m2";
            this.Odgovorni = odgovorni;
            this.VremeEvidentiranja = DateTime.Now;
            
        }
        public override String ToString()
        {
            if (this.opasnostOdPoplava == true)
                return this.VremeEvidentiranja.ToString() + " :: " + "opasnost od poplava.";
            else
            {
                return this.VremeEvidentiranja.ToString() + " :: " + "nema opasnosti od poplava.";
            }
        }
    }
}
