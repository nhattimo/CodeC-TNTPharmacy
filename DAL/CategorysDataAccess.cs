using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategorysDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db = new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public CategorysDataAccess()
        {
           
        }

        public void InsertDataAccess(Categorys obj)
        {
            _db.CATEGORYS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Categorys obj)
        {
            var objItem = _db.CATEGORYS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.CATEGORYS.SingleOrDefault(item => item.ID == objId);
            _db.CATEGORYS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.CATEGORYS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public Categorys GetProductById(int objId)
        {
            var objItem = _db.CATEGORYS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Categorys> GetList()
        {
            List<Categorys> list = _db.CATEGORYS.ToList();
            return list;
        }
    }
}
