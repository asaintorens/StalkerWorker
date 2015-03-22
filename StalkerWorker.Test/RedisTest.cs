using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

namespace StalkerWorker.Test
{
    [TestClass]
    public class RedisTest
    {
        [TestMethod]
        public void TestConnection()
        {


        }

        [TestMethod]
        public void testInsert()
        {
            ManagerRedis redis = new ManagerRedis();
            UserRedis user = new UserRedis();

            redis.Flush();
            user.email="mailsansGetSet";
            user.username = "mailsansGetSet";
            user = redis.AddUser(user);

            UserRedis userInDb = redis.GetUser(user.Id);

            Assert.AreEqual(userInDb.email, user.email);
         
        }

        [TestMethod]
        public void TestFlush()
        {
            ManagerRedis redis = new ManagerRedis();
            redis.Flush();

            List<UserRedis> list = redis.GetAll();

            Assert.AreEqual(0, list.Count());

        }
        [TestMethod]
        public void GetAll()
        {
          

            
        }
    }
}
