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

        public ObjectId Id;
        public string id;
        public string name;
        public string first_name;
        public string last_name;
        public string link;

        public string image;
        public string location;
        public string timezone;
        public string language;
        public string pseudonym;

    }
}