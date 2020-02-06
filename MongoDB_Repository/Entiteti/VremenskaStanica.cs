using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using Podaci;
namespace Podaci
{

    public class VremenskaStanica 
    {
        public ObjectId Id { get; set; }
        public String Naziv { get; set; }
        public String Drzava { get; set; }
        public String Okrug { get; set; }
        public String Mesto { get; set; }
        public List<MongoDBRef> Odgovorni { get; set; }
        public List<MongoDBRef> IzmereneVrednosti { get; set; }
        //admin kada kreira mora da podesi granicne vrednosti za stanicu
        public double minTemperatura { get; set; }
        public double maxTemperatura { get; set; }
        public double minVlaznost { get; set; }
        public double maxVlaznost { get; set; }
        public double minPadavine { get; set; }
        public double maxPadavine { get; set; }

        public VremenskaStanica(ObjectId id, String naziv, String drzava, String okrug, String mesto)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Drzava = drzava;
            this.Okrug = okrug;
            this.Mesto = mesto;
            this.Odgovorni = new List<MongoDBRef>();
            this.IzmereneVrednosti = new List<MongoDBRef>();
           
        }
        public VremenskaStanica(String naziv, String drzava, String okrug, String mesto)
        {
            this.Naziv = naziv;
            this.Drzava = drzava;
            this.Okrug = okrug;
            this.Mesto = mesto;
            this.Odgovorni = new List<MongoDBRef>();
            this.IzmereneVrednosti = new List<MongoDBRef>();
           
        }
        public override String ToString()
        {
            return this.Okrug + " - " +this.Naziv+" - "+this.Mesto;
        }
        public VremenskaStanica(ObjectId id,String naziv, String drzava, String okrug, String mesto, List<MongoDBRef>izmv)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Drzava = drzava;
            this.Okrug = okrug;
            this.Mesto = mesto;
            this.Odgovorni = new List<MongoDBRef>();
            this.IzmereneVrednosti = new List<MongoDBRef>();
            this.IzmereneVrednosti = izmv;

        }
    }
}

