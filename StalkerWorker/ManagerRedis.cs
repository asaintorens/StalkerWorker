using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker
{
    public class ManagerRedis
    {
        public RedisClient redis;


        public ManagerRedis()
        {
            this.redis = new RedisClient(new Uri(Config.URI_REDIS));

        }


        /// <summary>
        /// return The user with his ID, exception if error
        /// </summary>
        /// <param name="oneUser"></param>
        /// <returns></returns>
        public UserRedis AddUser(UserRedis oneUser)
        {
            try
            {
                var redisCollection = this.redis.As<UserRedis>();
                oneUser.Id = redisCollection.GetNextSequence();
                if (this.GetAll().Where(x => x.email == oneUser.email).FirstOrDefault() != null)
                {

                }
                else
                {
                    redisCollection.Store(oneUser);
                }
            }
            catch { throw; }

            return oneUser;
        }

        public void UpdateUsers(long idRedis, TypeSocialNetwork type)
        {
            var redisCollection = this.redis.As<UserRedis>();
            UserRedis user = redisCollection.GetById(idRedis);

            switch (type)
            {
                case TypeSocialNetwork.Twitter:
                    user.Twitter = true;
                    break;
                case TypeSocialNetwork.Facebook:
                    user.Facebook = true;
                    break;
                case TypeSocialNetwork.Google:
                    user.Google = true;
                    break;

            }
            redisCollection.Store(user);
        }


        public UserRedis GetUser(long id)
        {
            var redisCollection = this.redis.As<UserRedis>();

            UserRedis user = new UserRedis();
            user.Id = id;
            user = redisCollection.GetById(id);

            return user;


        }

        public List<UserRedis> GetAll()
        {
            var redisCollection = this.redis.As<UserRedis>();
            List<UserRedis> list = redisCollection.GetAll().ToList();
            return list;
        }

        public void Flush()
        {
            var redisCollection = this.redis.As<UserRedis>();
            redisCollection.SetSequence(0);
            redis.FlushAll();
        }

        internal Users GetUserToCrawl(TypeSocialNetwork typeSocialNetwork)
        {
            Users oneUser = new Users();
            UserRedis redis = new UserRedis();
            switch (typeSocialNetwork)
            {
                case TypeSocialNetwork.Twitter:
                    redis = this.GetAll().Where(x => x.Twitter = false).First();
                    break;
                case TypeSocialNetwork.Facebook:
                    redis = this.GetAll().Where(x => x.Facebook = false).First();
                    break;
                case TypeSocialNetwork.Google:
                    redis = this.GetAll().Where(x => x.Google = false).First();
                    break;
            }
            oneUser.name = redis.username;
            oneUser.email = redis.email;

            return oneUser;
        }

        internal void UserCrawled(Users user, TypeSocialNetwork typeSocialNetwork)
        {
            throw new NotImplementedException();
        }

        public void ThreadAddUserToQuery()
        {
            while (true)
            {
                if (this.GetAll().Count() < 100)
                {
                    ManagerGitHubArchive manager = new ManagerGitHubArchive();
                    UserRedis user = manager.GetOneUser();
                    this.AddUser(user);
                }
                System.Threading.Thread.Sleep(50);
            }
        }

    }
}
