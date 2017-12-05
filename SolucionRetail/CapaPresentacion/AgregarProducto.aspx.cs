using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string idpro = txtidproducto.Text;
            int id = Convert.ToInt32(idpro);
            string nombrepro = txtNombre.Text;
            string marcapro = txtMarca.Text;
            string preciopro = txtPrecioProducto.Text;
            int precio = Convert.ToInt32(preciopro);
            string stockpro = txtStock.Text;
            int stock = Convert.ToInt32(stockpro);
            DateTime fecha = Calendario.SelectedDate;
            int idretail = 1;
            ServiceAgregarProducto.ServiceProductoClient servicio = new ServiceAgregarProducto.ServiceProductoClient();

            

            if (servicio.AgregarProducto2(id, nombrepro, marcapro, precio, stock, fecha,idretail))
            {
                lblMensaje.Text = "Agregado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al agregar producto";
            }

        }
    }
}