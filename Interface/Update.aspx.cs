using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace Interface
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    GroupsBll groupsBll = new GroupsBll();
                    groupsBll.Update(Convert.ToInt32(Request.Form["id"]), Request.Form["name"], Request.Form["type"]);
                    Response.Write("Atualizado com sucesso!");
                }
                catch (ApplicationException ex)
                {
                    Response.Write(ex.Message);
                }

            }
        }
    }
}