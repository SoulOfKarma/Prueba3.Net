using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Retail
    {
        private int idretail;
        private string nombreretail;
        private string direccionretail;



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

        public string Nombreretail
        {
            get
            {
                return nombreretail;
            }

            set
            {
                nombreretail = value;
            }
        }

        public string Direccionretail
        {
            get
            {
                return direccionretail;
            }

            set
            {
                direccionretail = value;
            }
        }

        public Retail(int idretail, string nombreretail, string direccionretail)
        {
            this.idretail = idretail;
            this.nombreretail = nombreretail;
            this.direccionretail = direccionretail;
        }

        private void Init()
        {
            idretail = 0;
            nombreretail = string.Empty;
            direccionretail = string.Empty;
        }

        public Retail()
        {
            Init();
             
        }

    }
}
