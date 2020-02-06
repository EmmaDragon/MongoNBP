using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Podaci
{
    public class Merenje
    {
        ObjectId id;
        MongoDBRef temperatura;
        MongoDBRef vlaznostVazduha;
        MongoDBRef padavine;
        DateTime log;

        public Merenje()
        {

        }

        public Merenje(MongoDBRef a, MongoDBRef b, MongoDBRef c)
        {
            this.temperatura = a;
            this.vlaznostVazduha = b;
            this.padavine = c;
            this.log = DateTime.Now;
        }

        public DateTime Log
        {
            set { log = value; }
            get { return log; }
        }

        public MongoDBRef TempData
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public MongoDBRef VlaznostData
        {
            get { return vlaznostVazduha; }
            set { vlaznostVazduha = value; }
        }

        public MongoDBRef PadavineData
        {
            get { return padavine; }
            set { padavine = value; }
        }

        public ObjectId Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
