using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StalkerWorker
{
    public class ManagerMongo
    {
        public MongoClient client;
        public MongoServer server;
        public MongoDatabase database; 
        public static  string connectionString = "mongodb://localhost";
        MongoCollection<Users> collection;
        public ManagerMongo()
        {
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("local");
           
            collection = database.GetCollection<Users>("test2");
        }
        public void Insert(Users user)
        {
            collection.Insert(user);      
        }

        public void InsertRange(List<Users> listUsers)
        {
            foreach (Users user in listUsers)
            {
                this.Insert(user);
            }
        }

        public long CountEntryInMongo()
        {
            return collection.Count();
        }
    }
}