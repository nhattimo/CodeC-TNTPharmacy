using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShippingDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public ShippingDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(Shipping obj)
        {
            _db.SHIPPING.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Shipping obj)
        {
            var objItem = _db.SHIPPING.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.SHIPPING.SingleOrDefault(item => item.ID == objId);
            _db.SHIPPING.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.SHIPPING.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public Shipping GetProductById(int objId)
        {
            var objItem = _db.SHIPPING.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Shipping> GetList()
        {
            List<Shipping> list = _db.SHIPPING.ToList();
            return list;
        }
    }
}
