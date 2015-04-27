using System.Runtime.Serialization;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using StalkerWorker.JsonGitHubClass;

namespace StalkerWorker
{
    public class ManagerGitHubArchive
    {
        string pathToDataGit = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DataGitHub");
        string pathToCurrentFile;
        public ManagerGitHubArchive()
        {
            try
            {
                this.pathToCurrentFile = Directory.GetFiles(pathToDataGit).First();

            }
            catch (Exception e)
            {

                throw new Exception("Error when loading github file " + e);
            }
        }

        public UserRedis GetOneUser()
        {
            UserRedis user = new UserRedis();

            System.IO.StreamReader myFile = new System.IO.StreamReader(this.pathToCurrentFile);

           

            ObjectGitHub items = new ObjectGitHub();
            bool continueLoop =true;
            do
            {
                myFile.DiscardBufferedData();
                int i = this.GetIndexLine();
                string json ="";
                for (int indexLineInJson = 0; indexLineInJson < i; indexLineInJson++)
                {
                     json = myFile.ReadLine();
                }
                
                items = Newtonsoft.Json.JsonConvert.DeserializeObject<ObjectGitHub>(json);
                if (items != null)
                    if (items.payload != null)
                        if (items.payload.commits != null)
                            continueLoop = false;
            } while (continueLoop);
            myFile.Dispose();

            user.email = items.payload.commits.FirstOrDefault().author.email;
            user.username = items.payload.commits.FirstOrDefault().author.name;

            return user;
        }

        private int GetIndexLine()
        {
            int i = 0;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            i = int.Parse(config.AppSettings.Settings["indexLine"].Value);
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["indexLine"].Value = (i+1).ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            return i;
        }
    }
}


