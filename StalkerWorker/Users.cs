using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StalkerWorker
{

    public class Users
    {
        public string email { get; set; }
        public ObjectId Id { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string link { get; set; }

        public string image { get; set; }
        public string location { get; set; }
        public string timezone { get; set; }
        public string language { get; set; }
        public string pseudonym { get; set; }
     
    }
}