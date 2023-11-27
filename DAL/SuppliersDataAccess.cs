using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db = new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public SuppliersDataAccess()
        {
            
        }

        public void InsertDataAccess(Suppliers obj)
        {
            _db.SUPPLIERS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Suppliers obj)
        {
            var objItem = _db.SUPPLIERS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.SUPPLIERS.SingleOrDefault(item => item.ID == objId);
            _db.SUPPLIERS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.SUPPLIERS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public int GetID(string name)
        {
            var objItem = _db.SUPPLIERS.SingleOrDefault(item => item.Name == name);
            if (objItem != null)
                return objItem.ID;
            return 0;
        }
        public Suppliers GetProductById(int objId)
        {
            var objItem = _db.SUPPLIERS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Suppliers> GetList()
        {
            List<Suppliers> list = _db.SUPPLIERS.ToList();
            return list;
        }
    }
}
