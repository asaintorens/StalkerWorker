using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkerWorker.Test
{
    [TestClass]
    public class GitHubTest
    {
        [TestMethod]
        public void ReadUser()
        {
            ManagerGitHubArchive manager = new ManagerGitHubArchive();
            UserRedis use = manager.GetOneUser();
        }
    }
}
