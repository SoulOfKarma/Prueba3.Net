using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tarjeta
    {
        private int idtarjeta;
        private int saldotarjeta;
        private int lineacreditotarjeta;
        private int idcliente;

      

        public int Idtarjeta
        {
            get
            {
                return idtarjeta;
            }

            set
            {
                idtarjeta = value;
            }
        }

        public int Saldotarjeta
        {
            get
            {
                return saldotarjeta;
            }

            set
            {
                saldotarjeta = value;
            }
        }

        public int Lineacreditotarjeta
        {
            get
            {
                return lineacreditotarjeta;
            }

            set
            {
                lineacreditotarjeta = value;
            }
        }

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

        public Tarjeta(int idtarjeta, int saldotarjeta, int lineacreditotarjeta, int idcliente)
        {
            this.idtarjeta = idtarjeta;
            this.saldotarjeta = saldotarjeta;
            this.lineacreditotarjeta = lineacreditotarjeta;
            this.idcliente = idcliente;
        }

        private void Init()
        {
            idtarjeta = 0;
            saldotarjeta = 0;
            lineacreditotarjeta = 0;
            idcliente = 0;
        }

        public Tarjeta() { Init(); }

        public bool agregarTarjeta()
        {
            try
            {
                CapaDatos.Tarjeta tar = new CapaDatos.Tarjeta();
                tar.Id_Cliente = this.Idcliente;
                tar.Id_tarjeta = this.Idtarjeta;
                tar.linea_credito_tarjeta = this.Lineacreditotarjeta;
                tar.saldo_tarjeta = this.Saldotarjeta;

                CommonBC.ModeloRetail.Tarjeta.Add(tar);
                CommonBC.ModeloRetail.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
                return false;
            }
        }

    }
}
