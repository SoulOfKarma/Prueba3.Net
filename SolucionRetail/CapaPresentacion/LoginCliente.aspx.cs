using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class LoginCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            }
        }

        protected void logCliente_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string iduser = logCliente.UserName;
            int idcliente = Convert.ToInt32(iduser);
            string pass = logCliente.Password;

            ServicioLoginCliente.ServiceProductoClient service = new ServicioLoginCliente.ServiceProductoClient();
            service.LoginWSCliente(idcliente,pass);

            if (service.LoginWSCliente(idcliente, pass))
            {
                Response.Redirect("ListaProductos.aspx");
            }
            else
            {
                lblMensaje.Text = "Error Al Loguearse";
            }
        }
    }
}