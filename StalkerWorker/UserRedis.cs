using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker
{
    public class UserRedis 
    {


        public long Id { get; set; }
      
        public bool Facebook {get;set;}
        public bool Twitter {get;set;}
        public bool Google {get;set;}

        public string username {get;set;}
        public string email {get;set;}
    }
}
