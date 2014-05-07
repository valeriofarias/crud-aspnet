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
    public partial class Index : System.Web.UI.Page
    {
        public List<Groups> listGroups = new List<Groups>();
        public string msg = "teste";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                listGroups = (new GroupsBll()).FindAll();
            }
            catch (ApplicationException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}