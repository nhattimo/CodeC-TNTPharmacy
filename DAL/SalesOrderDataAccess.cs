using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SalesOrderDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db =  new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public SalesOrderDataAccess()
        {
           
        }

        public void InsertDataAccess(SalesOrder obj)
        {
            _db.SALES_ORDER.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, SalesOrder obj)
        {
            var objItem = _db.SALES_ORDER.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.SALES_ORDER.SingleOrDefault(item => item.ID == objId);
            _db.SALES_ORDER.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.SALES_ORDER.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public SalesOrder GetProductById(int objId)
        {
            var objItem = _db.SALES_ORDER.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<SalesOrder> GetList()
        {
            List<SalesOrder> list = _db.SALES_ORDER.ToList();
            return list;
        }
    }
}
