using DTO;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class BillOfflineDataAccess
    {
        //  sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        //  Phương thức tạo (constructor)
        public BillOfflineDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(BillOffline obj)
        {
            _db.BILL_OFFLINES.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, BillOffline obj)
        {
            var objItem = _db.BILL_OFFLINES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.BILL_OFFLINES.SingleOrDefault(item => item.ID == objId);
            _db.BILL_OFFLINES.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.BILL_OFFLINES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;

        }

        public BillOffline GetProductById(int objId)
        {
            var objItem = _db.BILL_OFFLINES.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<BillOffline> GetList()
        {
            List<BillOffline> list = _db.BILL_OFFLINES.ToList();
            return list;
        }
    }
}
