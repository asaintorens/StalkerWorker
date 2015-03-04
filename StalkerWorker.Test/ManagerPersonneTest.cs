using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker.Test
{
    [TestClass]
    public class ManagerPersonneTest
    {
        [TestMethod]
        public void GetPrenom()
        {
            ManagerPrenom personneManager = new ManagerPrenom();
            string personne = personneManager.GetPrenomAtIndex(50);

        }
        
    }
}
