using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using Core;

namespace Interface
{
    public partial class View : System.Web.UI.Page
    {
        public Groups groups = new Groups();

        protected void Page_Load(object sender, EventArgs e)
        {
            groups = new GroupsBll().FindById(Convert.ToInt32(Request.QueryString["id"]));
        }
    }
}