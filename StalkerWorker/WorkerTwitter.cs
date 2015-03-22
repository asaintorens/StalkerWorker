using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace StalkerWorker
{
    class WorkerTwitter : Worker
    {
        public WorkerTwitter(TypeSocialNetwork type): base(type)
        {
        }

        public void work()
        {
            while(!pause)
            {
                Users user = null;
                user = this.redisManager.GetUserToCrawl(this.typeSocialNetwork);// retourne stalkerUsers

                user =  this.CrawlTwitter (user); // ta logique de connexion et compagnie 
                this.mongoManager.InsertOrUpdate(user );
                this.redisManager.UserCrawled(user,this.typeSocialNetwork);
            }
        }

        private Users CrawlTwitter(Users user)
        {
            TwitterCredentials.SetCredentials("3096221031-kjXhWNPcRG0Bzl0s2jJTWzKHTdghhWdmMA6j2Hl", "hw8DTAZqZqCY1boxepAIDaKWrgiY7vyYTIwC3PXlbENfe", "yL6JO5Gbu8FYkuV66mtTJlpW3", "p0tNMQUm41VxCtC6f6cvb5TvC5Lkq2DIR63D8JOIpqIVxybwtJ");
            var TwitUser = User.GetUserFromScreenName(user.name);

            user.image = TwitUser.ProfileImageUrl;
            user.language = ""+TwitUser.Language;
            user.location = TwitUser.Location;
            user.timezone = TwitUser.TimeZone;
            user.pseudonym = TwitUser.ScreenName;

            string[] split = TwitUser.Name.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                if (i == 0)
                {
                    user.first_name = split[i];
                }
                else
                {
                    user.last_name += split[i];
                }
            }

            return user;
        }
      
    }
}
