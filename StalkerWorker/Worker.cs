using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker
{
    public abstract class Worker 
    {
        private  ManagerRedis redisManager = new ManagerRedis();
        private  ManagerMongo mongoManager = new ManagerMongo();

        public string statut { get; set; }
        public string progression;
        public string error{ get; set; }
        public TypeSocialNetwork typeSocialNetwork { get; set; }
        public bool pause { get; set; }

        public Worker(TypeSocialNetwork type)
        {
            this.typeSocialNetwork = type;
            this.pause = false;
        }
        public Users GetUserToCrawl()
        {
            return redisManager.GetUserToCrawl(this.typeSocialNetwork);
        }

        public void InsertOrUpdateInMongo(Users userToSave)
        {
            mongoManager.InsertOrUpdate(userToSave);
        }

        public void NotifyUserCrawled(Users userToUpdate, TypeSocialNetwork type)
        {
            redisManager.UserCrawled(userToUpdate, type);
        }

    }
}
