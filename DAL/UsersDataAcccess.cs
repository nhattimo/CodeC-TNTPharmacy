using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDataAcccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db =  new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public UsersDataAcccess()
        {
        }

        public void InsertDataAccess(Users obj)
        {
            _db.USERS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Users obj)
        {
            var objItem = _db.USERS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.USERS.SingleOrDefault(item => item.ID == objId);
            _db.USERS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.USERS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public Users GetProductById(int objId)
        {
            var objItem = _db.USERS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Users> GetList()
        {
            List<Users> list = _db.USERS.ToList();
            return list;
        }
    }
}
