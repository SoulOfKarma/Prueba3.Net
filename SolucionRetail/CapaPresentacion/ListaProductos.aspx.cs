using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                ServicioListadoProducto.ServiceProductoClient servicio = new ServicioListadoProducto.ServiceProductoClient();
                gvLista.DataSource = servicio.ListadoProductos();
                gvLista.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void gvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ServicioListadoProducto.ServiceProductoClient servicio = new ServicioListadoProducto.ServiceProductoClient();
            gvLista.DataSource = servicio.ListadoProductos();
            gvLista.DataBind();
            gvLista.PageIndex = e.NewPageIndex;
            
        }
    }
}