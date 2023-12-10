using DTO;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class PayMentDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db = new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public PayMentDataAccess()
        {
        }

        public void InsertDataAccess(PayMent obj)
        {
            _db.PAY_MENTS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, PayMent obj)
        {
            var objItem = _db.PAY_MENTS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.PAY_MENTS.SingleOrDefault(item => item.ID == objId);
            _db.PAY_MENTS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.PAY_MENTS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public PayMent GetProductById(int objId)
        {
            var objItem = _db.PAY_MENTS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<PayMent> GetList()
        {
            List<PayMent> list = _db.PAY_MENTS.ToList();
            return list;
        }
    }
}
