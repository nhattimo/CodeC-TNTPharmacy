using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillOfflineDetailDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public BillOfflineDetailDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(BillOfflineDetail obj)
        {
            _db.BILL_OFFLINE_DETAILS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, BillOfflineDetail obj)
        {
            var objItem = _db.BILL_OFFLINE_DETAILS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.BILL_OFFLINE_DETAILS.SingleOrDefault(item => item.ID == objId);
            _db.BILL_OFFLINE_DETAILS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.BILL_OFFLINE_DETAILS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public BillOfflineDetail GetProductById(int objId)
        {
            var objItem = _db.BILL_OFFLINE_DETAILS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<BillOfflineDetail> GetList()
        {
            List<BillOfflineDetail> list = _db.BILL_OFFLINE_DETAILS.ToList();
            return list;
        }
    }
}
