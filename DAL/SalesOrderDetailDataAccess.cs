using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SalesOrderDetailDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db =  new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public SalesOrderDetailDataAccess()
        {
        }

        public void InsertDataAccess(SalesOrderDetail obj)
        {
            _db.SALES_ORDER_DETAIL.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, SalesOrderDetail obj)
        {
            var objItem = _db.SALES_ORDER_DETAIL.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.SALES_ORDER_DETAIL.SingleOrDefault(item => item.ID == objId);
            _db.SALES_ORDER_DETAIL.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.SALES_ORDER_DETAIL.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public SalesOrderDetail GetProductById(int objId)
        {
            var objItem = _db.SALES_ORDER_DETAIL.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<SalesOrderDetail> GetList()
        {
            List<SalesOrderDetail> list = _db.SALES_ORDER_DETAIL.ToList();
            return list;
        }
    }
}
