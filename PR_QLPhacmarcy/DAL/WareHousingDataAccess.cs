using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WareHousingDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public WareHousingDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(WareHousing obj)
        {
            _db.WARE_HOUSING.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, WareHousing obj)
        {
            var objItem = _db.WARE_HOUSING.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.WARE_HOUSING.SingleOrDefault(item => item.ID == objId);
            _db.WARE_HOUSING.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.WARE_HOUSING.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public WareHousing GetProductById(int objId)
        {
            var objItem = _db.WARE_HOUSING.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<WareHousing> GetList()
        {
            List<WareHousing> list = _db.WARE_HOUSING.ToList();
            return list;
        }
    }
}
