using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        private int idproducto;
        private string nombreproducto;
        private string marcaproducto;
        private int precioproducto;
        private int stockproducto;
        private DateTime fechaterminosubasta;
        private int idretail;

      

        public int Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public string Nombreproducto
        {
            get
            {
                return nombreproducto;
            }

            set
            {
                nombreproducto = value;
            }
        }

        public string Marcaproducto
        {
            get
            {
                return marcaproducto;
            }

            set
            {
                marcaproducto = value;
            }
        }

        public int Precioproducto
        {
            get
            {
                return precioproducto;
            }

            set
            {
                precioproducto = value;
            }
        }

        public int Stockproducto
        {
            get
            {
                return stockproducto;
            }

            set
            {
                stockproducto = value;
            }
        }

        public DateTime Fechaterminosubasta
        {
            get
            {
                return fechaterminosubasta;
            }

            set
            {
                fechaterminosubasta = value;
            }
        }

        public int Idretail
        {
            get
            {
                return idretail;
            }

            set
            {
                idretail = value;
            }
        }

        public Producto(int idproducto, string nombreproducto, string marcaproducto, int precioproducto, int stockproducto, DateTime fechaterminosubasta, int idretail)
        {
            this.idproducto = idproducto;
            this.nombreproducto = nombreproducto;
            this.marcaproducto = marcaproducto;
            this.precioproducto = precioproducto;
            this.stockproducto = stockproducto;
            this.fechaterminosubasta = fechaterminosubasta;
            this.idretail = idretail;
        }

        private void Init()
        {
            idproducto = 0;
            nombreproducto = string.Empty;
            marcaproducto = string.Empty;
            precioproducto = 0;
            stockproducto = 0;
            fechaterminosubasta = DateTime.Now;
            idretail = 0;
        }

        public Producto()
        {
            Init();
        }

        public bool agregarProducto()
        {
            try
            {
                CapaDatos.Producto pro = new CapaDatos.Producto();
                pro.Id_producto = this.Idproducto;
                pro.Nombre_producto = this.Nombreproducto;
                pro.Marca_producto = this.Marcaproducto;
                pro.Precio_producto = this.Precioproducto;
                pro.Stock_producto = this.Stockproducto;
                pro.Fecha_Termino_Subasta = this.Fechaterminosubasta;
                pro.Id_Retail = this.Idretail;

                CommonBC.ModeloRetail.Producto.Add(pro);
                CommonBC.ModeloRetail.SaveChanges();
                    
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
                return false;
            }

        }



    }
}
