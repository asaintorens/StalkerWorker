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
                user = this.GetUserToCrawl();// retourne stalkerUsers

                user =  this.CrawlTwitter (user); // ta logique de connexion et compagnie 
                this.InsertOrUpdateInMongo(user );
                this.NotifyUserCrawled(user,this.typeSocialNetwork);
            }
        }

        private Users CrawlTwitter(Users user)
        {
            TwitterCredentials.SetCredentials("Access_Token", "Access_Token_Secret", "Consumer_Key", "Consumer_Secret");
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
