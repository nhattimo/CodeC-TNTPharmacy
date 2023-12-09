using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class RolesDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db =  new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public RolesDataAccess()
        {
        }

        public void InsertDataAccess(Roles obj)
        {
            _db.ROLES.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Roles obj)
        {
            var objItem = _db.ROLES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.ROLES.SingleOrDefault(item => item.ID == objId);
            _db.ROLES.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.ROLES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public Roles GetProductById(int objId)
        {
            var objItem = _db.ROLES.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }
        

        public List<Roles> GetList()
        {
            List<Roles> list = _db.ROLES.ToList();
            return list;
        }
    }
}
