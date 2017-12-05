using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class LoginAdministrativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            }
        }

        protected void LogAdministrativo_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string iduser = LogAdministrativo.UserName;
            int idusuario = Convert.ToInt32(iduser);
            string pass = LogAdministrativo.Password;

            ServicioLoginUsuarios.ServiceProductoClient servicio = new ServicioLoginUsuarios.ServiceProductoClient();

            if (servicio.LoginWSUsuario(idusuario,pass))
            {
                Response.Redirect("Administrativo.aspx");
            }
            else
            {
                lblMensaje.Text = "Error al loguearse";
            }
        }
    }
}