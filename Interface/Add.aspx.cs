using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace Interface
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    (new GroupsBll()).Save(Request.Form["name"], Convert.ToInt32(Request.Form["type"]));
                    Response.Write("Salvo com sucesso!");
                }
                catch (ApplicationException ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}