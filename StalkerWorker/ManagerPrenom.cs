using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker
{
    public  class ManagerPrenom
    {
        public static string PathFile = Path.Combine(Environment.CurrentDirectory, @"Resources\", "PRENOM.txt");
        public  int numberFirstName = 0;
        
        public ManagerPrenom()
        {
            this.numberFirstName = File.ReadLines(PathFile).Count();
        }
        public  string GetPrenomAtIndex(int index)
        {
            try
            {
                return File.ReadLines(PathFile).ElementAt(index);
            }
            catch (Exception e)
            {

                return "abc";
            }
           

        }
    }
}
