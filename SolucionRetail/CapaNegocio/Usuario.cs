using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuario
    {
        private int idusuario;
        private string passusuario;

        

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public string Passusuario
        {
            get
            {
                return passusuario;
            }

            set
            {
                passusuario = value;
            }
        }

        public Usuario(int idusuario, string passusuario)
        {
            this.idusuario = idusuario;
            this.passusuario = passusuario;
        }

        private void Init()
        {
            idusuario = 0;
            passusuario = string.Empty;


        }

        public Usuario()
        {
            Init();
        }

        public bool LoginWSUsuario()
        {
            try
            {
                CapaDatos.Usuario user = CommonBC.ModeloRetail.Usuario.First
                    (
                       usu => usu.Id_usuario == this.Idusuario
                    );

                if (user.Id_usuario == this.Idusuario && user.Pass_usuario == this.Passusuario)
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
                Console.WriteLine("Error :"+ex.Message);
                return false;
                
            }
        }

    }
}
