using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Purchase_Order_Processing_System;

namespace Purchase_Order_Processing_System
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string AddItem(Purchase_Order_Processing_System.ITEM Item);

        [OperationContract]
        string UpdateItem(Purchase_Order_Processing_System.ITEM Item);

        [OperationContract]
        IEnumerable<Purchase_Order_Processing_System.ITEM> ReadAllItems();

        [OperationContract]
        string DeleteItem(string  ItemCode);

        [OperationContract]
        string AddSupplier(Purchase_Order_Processing_System.SUPPLIER Supplier);

        [OperationContract]
        string UpdateSupplier(Purchase_Order_Processing_System.SUPPLIER Supplier);

        [OperationContract]
        IEnumerable<Purchase_Order_Processing_System.SUPPLIER> ReadAllSuppliers();

        [OperationContract]
        string DeleteSupplier(string SupplierCode);

        [OperationContract]
        string AddPODETAIL(Purchase_Order_Processing_System.PODETAIL _PODETAIL);

        [OperationContract]
        string UpdatePODETAIL(Purchase_Order_Processing_System.PODETAIL _PODETAIL);

        [OperationContract]
        IEnumerable<Purchase_Order_Processing_System.PODETAIL> ReadAllPODETAIL();

        [OperationContract]
        string DeletePODETAIL(string PODETAILCode);

        [OperationContract]
        string AddPOMASTER(Purchase_Order_Processing_System.POMASTER _PODETAIL);

        [OperationContract]
        string UpdatePOMASTER(Purchase_Order_Processing_System.POMASTER _PODETAIL);

        [OperationContract]
        IEnumerable<Purchase_Order_Processing_System.POMASTER> ReadAllPOMASTER();

        [OperationContract]
        string DeletePOMASTER(string POMASTERCode);


    }


   
}
