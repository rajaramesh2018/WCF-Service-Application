using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Purchase_Order_Processing_System
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        PODbEntities poDb = new PODbEntities();

        public string AddItem(ITEM Item)
        {
            string Result="Success";
            try {
                poDb.ITEMs.Add(Item);
                poDb.SaveChanges();
            }
            catch (Exception ex) {
                 Result = ex.Message;
            }
            return Result;

            
        }

        public string AddPODETAIL(PODETAIL _PODETAIL)
        {
            string Result = "Success";
            try
            {
                poDb.PODETAILs.Add(_PODETAIL);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string AddPOMASTER(POMASTER _PODETAIL)
        {
            string Result = "Success";
            try
            {
                poDb.POMASTERs.Add(_PODETAIL);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string AddSupplier(SUPPLIER Supplier)
        {
            string Result = "Success";
            try
            {
                poDb.SUPPLIERs.Add(Supplier);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string DeleteItem(string ItemCode)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.ITEM item = poDb.ITEMs.Where(x => x.ITCODE == ItemCode).ToList().FirstOrDefault();
                poDb.ITEMs.Remove(item);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string DeletePODETAIL(string PODETAILCode)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.PODETAIL _PODETAIL = poDb.PODETAILs.Where(x => x.ITCODE == PODETAILCode).ToList().FirstOrDefault();
                poDb.PODETAILs.Remove(_PODETAIL);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string DeletePOMASTER(string POMASTERCode)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.POMASTER _POMASTER = poDb.POMASTERs.Where(x => x.PONO == POMASTERCode).ToList().FirstOrDefault();
                poDb.POMASTERs.Remove(_POMASTER);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string DeleteSupplier(string SupplierCode)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.SUPPLIER _SUPPLIER = poDb.SUPPLIERs.Where(x => x.SUPLNO == SupplierCode).ToList().FirstOrDefault();
                poDb.SUPPLIERs.Remove(_SUPPLIER);
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public IEnumerable<ITEM> ReadAllItems()
        {
          return   poDb.ITEMs.ToList();
        }

        public IEnumerable<PODETAIL> ReadAllPODETAIL()
        {
            return poDb.PODETAILs.ToList();
        }

        public IEnumerable<POMASTER> ReadAllPOMASTER()
        {
            return poDb.POMASTERs.ToList();
        }

        public IEnumerable<SUPPLIER> ReadAllSuppliers()
        {
            return poDb.SUPPLIERs.ToList();
        }


        public string UpdateItem(ITEM Item)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.ITEM _ITEM = poDb.ITEMs.Where(x => x.ITCODE == Item.ITCODE).ToList().FirstOrDefault();
                _ITEM.ITDESC = Item.ITDESC;
                _ITEM.ITRATE  = Item.ITRATE;
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string UpdatePODETAIL(PODETAIL _PODETAIL)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.PODETAIL _podetail = poDb.PODETAILs.Where(x => x.PONO == _PODETAIL.PONO).ToList().FirstOrDefault();
                _podetail.ITCODE = _PODETAIL.ITCODE;
                _podetail.ITEM = _PODETAIL.ITEM;
                _podetail.POMASTER=  _PODETAIL.POMASTER;
                _podetail.QTY = _PODETAIL.QTY;
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string UpdatePOMASTER(POMASTER _POMASTER)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.POMASTER _pomaster = poDb.POMASTERs.Where(x => x.PONO  == _POMASTER.PONO).ToList().FirstOrDefault();
                _pomaster.PODATE = _POMASTER.PODATE;
                _pomaster.PODETAILs = _POMASTER.PODETAILs;
                _pomaster.SUPLNO  = _POMASTER.SUPLNO;
                _pomaster.SUPPLIER = _POMASTER.SUPPLIER;
               
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }

        public string UpdateSupplier(SUPPLIER Supplier)
        {
            string Result = "Success";
            try
            {
                Purchase_Order_Processing_System.SUPPLIER _supplier = poDb.SUPPLIERs.Where(x => x.SUPLNO == Supplier.SUPLNO ).ToList().FirstOrDefault();
                _supplier.SUPLADDR = Supplier.SUPLADDR;
                _supplier.SUPLNAME  = Supplier.SUPLNAME;
                poDb.SaveChanges();
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
            return Result;
        }
    }
}
