using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class CollecionProducto
    {

        public List<Producto> generarListado(List<CapaDatos.Producto> pro)
        {
            List<Producto> lista = new List<Producto>();

            foreach (CapaDatos.Producto ex in pro)
            {
                Producto producto = new Producto();
                producto.Idproducto = ex.Id_producto;
                producto.Nombreproducto = ex.Nombre_producto;
                producto.Marcaproducto = ex.Marca_producto;
                producto.Precioproducto = ex.Precio_producto;
                producto.Stockproducto = ex.Stock_producto;
                producto.Fechaterminosubasta = ex.Fecha_Termino_Subasta;
                producto.Idretail = ex.Id_Retail;
                lista.Add(producto);

            }

            return lista;



        }

        public List<Producto> readAll()
        {
            var val = CommonBC.ModeloRetail.Producto;
            return generarListado(val.ToList());
        }

        public List<Producto> modificarEspeficico(int idproducto)
        {
            var val = CommonBC.ModeloRetail.Producto;

            List<CapaDatos.Producto> pro = val.ToList();
            List<CapaDatos.Producto> listado = new List<CapaDatos.Producto>();


            foreach (CapaDatos.Producto cap in pro)
            {
                if (cap.Id_producto == idproducto)
                {
                    listado.Add(cap);
                }
            }
            

            
            return generarListado(listado);
        }


    }
}
