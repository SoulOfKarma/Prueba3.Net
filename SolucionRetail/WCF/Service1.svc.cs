using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CapaNegocio;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceProductos : ServiceProducto
    {
        public bool AgregarProducto(int idpro,string nombrepro,string marcapro,int preciopro,int stockpro,DateTime fechapro,int idretail)
        {
            CapaNegocio.Producto pro = new CapaNegocio.Producto();
            pro.Idproducto = idpro;
            pro.Nombreproducto = nombrepro;
            pro.Marcaproducto = marcapro;
            pro.Precioproducto = preciopro;
            pro.Stockproducto = stockpro;
            pro.Fechaterminosubasta = fechapro;
            pro.Idretail = idretail;
            

            return pro.agregarProducto();
        }

        public bool LoginWSCliente(int id,string pass)
        {
            CapaNegocio.Cliente cli = new CapaNegocio.Cliente();
            cli.Idcliente = id;
            cli.Nombre = pass;

            return cli.LoginWSCliente();
        }

        public bool LoginWSUsuario(int id, string pass)
        {
            CapaNegocio.Usuario cli = new CapaNegocio.Usuario();
            cli.Idusuario = id;
            cli.Passusuario = pass;

            return cli.LoginWSUsuario();
        }

        public List<CapaNegocio.Producto> ListadoProductos()
        {
            CapaNegocio.CollecionProducto col = new CollecionProducto();
            return col.readAll();
        }

        public bool AgregarProducto2(int idpro, string nombrepro, string marcapro, int preciopro, int stockpro, DateTime fechapro, int idretail)
        {
            CapaNegocio.Producto pro = new CapaNegocio.Producto();
            pro.Idproducto = idpro;
            pro.Nombreproducto = nombrepro;
            pro.Marcaproducto = marcapro;
            pro.Precioproducto = preciopro;
            pro.Stockproducto = stockpro;
            pro.Fechaterminosubasta = fechapro;
            pro.Idretail = idretail;


            return pro.agregarProducto();
        }
    }
}
