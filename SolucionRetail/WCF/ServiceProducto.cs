using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ServiceProducto
    {

        [OperationContract]
        bool AgregarProducto(int idpro, string nombrepro, string marcapro, int preciopro, int stockpro, DateTime fechapro,int idretail);

        [OperationContract]

        bool LoginWSCliente(int id,string pass);

        [OperationContract]
        bool LoginWSUsuario(int id, string pass);

        [OperationContract]
        List<CapaNegocio.Producto> ListadoProductos();
        [OperationContract]
        bool AgregarProducto2(int idpro, string nombrepro, string marcapro, int preciopro, int stockpro, DateTime fechapro, int idretail);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    
}
