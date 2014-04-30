using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Bll.GroupsBll groupsBll = new Bll.GroupsBll();
                Response.Write(groupsBll.Save(Request.Form["nome"], Request.Form["type"]));
            }
        }
    }
}