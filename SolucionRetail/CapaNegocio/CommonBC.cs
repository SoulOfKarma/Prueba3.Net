using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CommonBC
    {
        private static BaseDatosRetailEntities _modeloRetail;

        public static BaseDatosRetailEntities ModeloRetail
        { 
            get
            {
                if (_modeloRetail == null)
                {
                    _modeloRetail = new BaseDatosRetailEntities();
                }
                return _modeloRetail;
            }
        }

        public CommonBC() { }

    }
}
