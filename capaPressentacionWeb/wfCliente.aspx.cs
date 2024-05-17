using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPressentacionWeb
{
    public partial class wfCliente : System.Web.UI.Page
    {
        private void Listar()
        {
            clienteBL clienteBl = new clienteBL();
            GridView1.DataSource = clienteBl.Listar();
            GridView1.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();

        }
    }
}