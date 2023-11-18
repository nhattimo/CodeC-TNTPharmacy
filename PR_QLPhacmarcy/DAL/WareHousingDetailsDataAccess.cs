using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WareHousingDetailsDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public WareHousingDetailsDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(WareHousingDetails obj)
        {
            _db.WARE_HOUSING_DETAILS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, WareHousingDetails obj)
        {
            var objItem = _db.WARE_HOUSING_DETAILS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.WARE_HOUSING_DETAILS.SingleOrDefault(item => item.ID == objId);
            _db.WARE_HOUSING_DETAILS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.WARE_HOUSING_DETAILS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public WareHousingDetails GetProductById(int objId)
        {
            var objItem = _db.WARE_HOUSING_DETAILS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<WareHousingDetails> GetList()
        {
            List<WareHousingDetails> list = _db.WARE_HOUSING_DETAILS.ToList();
            return list;
        }
    }
}
