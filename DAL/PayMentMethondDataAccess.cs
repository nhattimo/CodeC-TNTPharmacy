using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PayMentMethondDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db =  new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public PayMentMethondDataAccess()
        {
        }

        public void InsertDataAccess(PayMentMethond obj)
        {
            _db.PAY_MENT_METHONDS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, PayMentMethond obj)
        {
            var objItem = _db.PAY_MENT_METHONDS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.PAY_MENT_METHONDS.SingleOrDefault(item => item.ID == objId);
            _db.PAY_MENT_METHONDS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.PAY_MENT_METHONDS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public PayMentMethond GetProductById(int objId)
        {
            var objItem = _db.PAY_MENT_METHONDS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<PayMentMethond> GetList()
        {
            List<PayMentMethond> list = _db.PAY_MENT_METHONDS.ToList();
            return list;
        }
    }
}
