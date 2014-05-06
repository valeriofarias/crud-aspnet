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
    public partial class Update : System.Web.UI.Page
    {
        public Groups groups = new Groups();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    new GroupsBll().Update(Convert.ToInt32(Request.Form["id"]), Request.Form["name"], Convert.ToInt32(Request.Form["type"]));   
                    Response.Write("Atualizado com sucesso!");
                }
                catch (ApplicationException ex)
                {
                    Response.Write(ex.Message);
                }
            }
            else
            {
                groups = new GroupsBll().FindById(Convert.ToInt32(Request.QueryString["id"]));
            }
        }
    }
}