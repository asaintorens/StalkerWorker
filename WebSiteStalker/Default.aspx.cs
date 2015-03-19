using StalkerWorker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebSiteStalker
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            HTMLManager htmlManager = new HTMLManager(this);

            htmlManager.AddTable();


          

  
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            HTMLManager htmlManager = new HTMLManager(this);
            Users oneUser = new Users();
            ManagerMongo mongo = new ManagerMongo();

            htmlManager.AddRow(mongo.GetUsersByKeyWord(textBoxSearch.Text));
        }
    }
}