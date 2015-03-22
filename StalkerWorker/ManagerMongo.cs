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
        public static string connectionString = Config.URI_MONGO;
        MongoCollection<Users> collection;
        public ManagerMongo()
        {
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("projetstalker");

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
            try
            {
                return collection.Count();
            }
            catch (Exception e)
            {

                throw new Exception("Impossible d'atteindre la base de donnée.", e);
            }

        }

        public IEnumerable<Users> GetUsersByKeyWord(string text)
        {
            List<Users> returnList = new List<Users>();

            try
            {

           
            returnList.AddRange(collection.FindAll().AsQueryable().Where(p => p.last_name.ToLower().Contains(text.ToLower()))
                            .Take(10).ToList());
            }
            catch (Exception)
            {

               
            }
            try
            {

            }
            catch (Exception)
            {
                
            
            
            returnList.AddRange(collection.FindAll().AsQueryable().Where(p => p.first_name.ToLower().Contains(text.ToLower()))
                     .Take(10).ToList());

            }
            return returnList;
        }

        internal void InsertOrUpdate(Users userToSave)
        {
            throw new NotImplementedException();
        }
    }
}