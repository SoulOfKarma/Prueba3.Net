using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        private int idcliente;
        private string nombre;


        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }


        public Cliente(int idcliente, string nombre)
        {
            this.idcliente = idcliente;
            this.nombre = nombre;
        }

        private void Init()
        {
            idcliente = 0;
            nombre = string.Empty;
        }

        public Cliente() { Init(); }


        public bool agregarCliente()
        {
            try
            {
                CapaDatos.Cliente cap = new CapaDatos.Cliente();

                cap.Id_Cliente = this.Idcliente;
                cap.Nombre_Cliente = this.Nombre;

                CommonBC.ModeloRetail.Cliente.Add(cap);
                CommonBC.ModeloRetail.SaveChanges();

               


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
                return false;
            }
        }

        public bool LoginWSCliente()
        {
            try
            {
                CapaDatos.Cliente user = CommonBC.ModeloRetail.Cliente.First
                    (
                       usu => usu.Id_Cliente == this.Idcliente
                    );

                if (user.Id_Cliente == this.Idcliente && user.Nombre_Cliente == this.Nombre)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return false;

            }
        }
    }
}
