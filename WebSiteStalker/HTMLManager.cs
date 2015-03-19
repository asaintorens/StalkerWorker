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
    public class HTMLManager
    {
        public Page page;
        public static string idDivMainTable = "mainTable";
        public static string idMainContent = "MainContent";
        public static string idTableSearch = "tableSearch";
        public HTMLManager(Page page)
        {
            this.page = page;
        }

        public void AddTable()
        {
            GenerateTable();
        }

        private void GenerateTable()
        {
            HtmlGenericControl div = new HtmlGenericControl();
            div.ID = "tableSearch";
            div.TagName = "table";
            div.Attributes["class"] = "table";

            HtmlGenericControl header = new HtmlGenericControl();
            header.TagName = "caption";
            header.InnerText = "Result of research";
            div.Controls.Add(header);

            HtmlGenericControl thead = new HtmlGenericControl();
            thead.TagName = "thead";
            div.Controls.Add(thead);

            HtmlGenericControl TR = new HtmlGenericControl();
            TR.TagName = "tr";
            thead.Controls.Add(TR);


            HtmlGenericControl THID = new HtmlGenericControl();
            THID.TagName = "th";
            THID.InnerText = "ID";
            TR.Controls.Add(THID);

            HtmlGenericControl ThFirstName = new HtmlGenericControl();
            ThFirstName.TagName = "th";
            ThFirstName.InnerText = "Name";
            TR.Controls.Add(ThFirstName);

            HtmlGenericControl ThLastName = new HtmlGenericControl();
            ThLastName.TagName = "th";
            ThLastName.InnerText = "Name";
            TR.Controls.Add(ThLastName);

            HtmlGenericControl THLink = new HtmlGenericControl();
            THLink.TagName = "th";
            THLink.InnerText = "Link";
            TR.Controls.Add(THLink);


            ContentPlaceHolder cph = GetPlaceHolder();
            Control mainDiv = GetTableDiv(cph);
            mainDiv.Controls.Add(div);
        }

        private static Control GetTableDiv(ContentPlaceHolder cph)
        {
            Control mainDiv = cph.FindControl(idDivMainTable);
            return mainDiv;
        }

        private ContentPlaceHolder GetPlaceHolder()
        {
            ContentPlaceHolder cph = (ContentPlaceHolder)this.page.Master.FindControl(idMainContent);
            return cph;
        }

        public void AddRow(Users oneUser)
        {
            Control mainDiv = GetTable();

            HtmlGenericControl row = new HtmlGenericControl();
            row.TagName = "TR";
            mainDiv.Controls.Add(row);

            HtmlGenericControl cellId = new HtmlGenericControl();
            cellId.TagName = "td";
            cellId.InnerText = oneUser.id;
            row.Controls.Add(cellId);

            HtmlGenericControl cellFirstName = new HtmlGenericControl();
            cellFirstName.TagName = "td";
            cellFirstName.InnerText = oneUser.first_name;
            row.Controls.Add(cellFirstName);

            HtmlGenericControl cellLastName = new HtmlGenericControl();
            cellLastName.TagName = "td";
            cellLastName.InnerText = oneUser.last_name;
            row.Controls.Add(cellLastName);

            HtmlGenericControl cellLink = new HtmlGenericControl();
            cellLink.TagName = "td";
            row.Controls.Add(cellLink);

            HtmlGenericControl link = new HtmlGenericControl();
            link.TagName = "a";
            link.InnerText = oneUser.link;
            cellLink.Controls.Add(link);

        }

        private Control GetTable()
        {
            ContentPlaceHolder cph = GetPlaceHolder();
            Control mainDiv = GetTableDiv(cph);
            Control Table = mainDiv.FindControl(idTableSearch);
            return Table;
        }

        public void AddRow(IEnumerable<Users> enumerable)
        {
            foreach (Users oneUser in enumerable)
            {
                this.AddRow(oneUser);
            }
        }
    }
}