using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Administrativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPro_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProducto.aspx");

        }

        protected void btnEliminaroEditarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarEditarProducto.aspx");
        }
    }
}