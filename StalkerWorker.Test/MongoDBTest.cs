using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Driver.Linq;
using MongoDB.Driver;


using Microsoft.VisualStudio.TestTools.UnitTesting;
using StalkerWorker;
namespace StalkerProject.Tests
{
    [TestClass]
    public class MongoDBTest
    {
        [TestMethod]
        public void InsertIntoMongoDB()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("local");
                  
            database.DropCollection("test2");
              database.CreateCollection("test2");
            var collection = database.GetCollection<Users>("test2");
            collection.RemoveAll();

            short intValue = 1;
            byte[] intBytes = BitConverter.GetBytes(intValue);
            Array.Reverse(intBytes);
            byte[] result = intBytes;
            collection.RemoveAll();
            Users alex = new Users();
            // alex.Id = "1";
            alex.first_name = "alex";
            alex.last_name = "stOrens";
            collection.Insert(alex);

            MongoCursor<Users> listUsers = collection.FindAll();
            Assert.AreEqual(1, listUsers.Count());

        }
    }
}
