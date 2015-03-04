using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StalkerWorker
{
    public class StalkerFacebook
    {

        public string currentPrenom;
        int indexPrenom;
        List<Users> listUsersFinal = new List<Users>();
        public int progression;
       public int ProgressionDetailPrenom;
        ManagerPrenom managerPrenom;

        private int numberThread;
        public int indexThread;

        public void LunchWorker()
        {
          
           int numberElementToWalk = (int)Math.Round((double) managerPrenom.numberFirstName/(double)this.numberThread);
           int totalToWalk = numberElementToWalk;
           int startIndexWalk = numberElementToWalk * indexThread + 1;
           this.InsertAllInMongo(startIndexWalk,startIndexWalk+numberElementToWalk);
        }
        public StalkerFacebook(int numberThread,int indexThread)
        {
            // TODO: Complete member initialization
        
            this.indexPrenom = 0;
            this.progression = 0;
            this.managerPrenom = new ManagerPrenom();
            this.currentPrenom = "";
            this.numberThread = numberThread;
            this.indexThread = indexThread;
        }
        public string GetNextPrenom()
        {
            this.indexPrenom++;
            string prenom = managerPrenom.GetPrenomAtIndex(this.indexPrenom);
            this.currentPrenom = prenom;
            return prenom;
        }
        public string GetActualPrenom()
        {

            string prenom;
            if (indexPrenom == -1)
            { prenom = ""; }
            else
            {
                prenom = managerPrenom.GetPrenomAtIndex(indexPrenom);
            }

            return prenom;
        }

        public void InsertAllInMongo(int indexStart, int indexEnd)
        {
            List<string> listPrenom = new List<string>();
            for (int indexForPrenom = 0; indexForPrenom < indexEnd-indexStart; indexForPrenom++)
            {
                listPrenom.Add(managerPrenom.GetPrenomAtIndex(indexStart+indexForPrenom));
            }
            LoadUsers(listPrenom);
      //      InsertInMongo();
        }

        private void LoadUsers(List<string> listPrenom)
        {
            FacebookClient fbClt = new FacebookClient("CAACEdEose0cBALYzR8n1ZA5RABrfHoSVeUNIdT2P9pcUIIDmI44IuYuHyZAOrmWqCzUVJbOzNpP88VZAJsuVyTVuTQQLa7S4JFYzEBZAHzc389QTV8fiePkZAe04ZAey5QjABO33XAAiBjVtUlc3MF9tnseQ2PUFWCNEssOZCY3d9pksa6CTDq6CeilU49ZALSWohEt6dK9rplV1XvonE8hi0G6WvXDP5dwZD");
            this.progression = 0;
            ManagerMongo manager = new ManagerMongo();


            foreach (string prenom in listPrenom)
            {
                this.currentPrenom = prenom;
                this.SetProgression(indexPrenom, managerPrenom.numberFirstName);
                try
                {

                    this.ProgressionDetailPrenom = 0;
                    dynamic mark = fbClt.Get("search?q=" + prenom + "&type=user&&locale=fr_FR");
                    dynamic data = mark["data"];
                    JsonArray dataJson = data;

                    List<Users> listUsers = new List<Users>();
                    foreach (dynamic oneUserJson in dataJson)
                    {
                        Users oneUser = new Users();
                        oneUser.id = oneUserJson.id;

                        var userExist = (from x in this.listUsersFinal where x.id == oneUser.id select x).FirstOrDefault();
                        if (userExist == null)
                        {
                            listUsers.Add(oneUser);
                        }
                    }

                    int indexPrenomCurrent = 0;
                    foreach (Users oneUser in listUsers)
                    {
                        dynamic userJson = fbClt.Get(oneUser.id);
                        oneUser.link = userJson.link;
                        oneUser.name = userJson.name;
                        oneUser.first_name = userJson.first_name;
                        oneUser.last_name = userJson.last_name;
                        manager.Insert(oneUser);
                        indexPrenomCurrent++;
                        this.SetProgressionPrenom(indexPrenomCurrent, listUsers.Count);

                    
                    }
                    listUsersFinal.AddRange(listUsers);
                    this.ProgressionDetailPrenom = 0;
                 
                   // manager.InsertRange(listUsers);

                }
                catch (Exception)
                {
                    break;
                }
            }


        }

        public void SetProgression(int indexPrenom, int totalPrenom)
        {
            float res = (indexPrenom * 100) / totalPrenom;
            this.ProgressionDetailPrenom = (int)Math.Round(res);

        }
        public void InsertInMongo()
        {
          
           
         //  long nbInput = manager.CountEntryInMongo();
        }

        public void SetProgressionPrenom(int indexData,int totalData)
        {
            float res = (indexData * 100) / totalData;
            this.ProgressionDetailPrenom = (int)Math.Round(res);
        }
    }
}
