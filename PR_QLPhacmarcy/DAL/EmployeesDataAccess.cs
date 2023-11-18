using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class EmployeesDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public EmployeesDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(Employees obj)
        {
            _db.EMPLOYEES.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Employees obj)
        {
            var objItem = _db.EMPLOYEES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.EMPLOYEES.SingleOrDefault(item => item.ID == objId);
            _db.EMPLOYEES.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.EMPLOYEES.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }

        public Employees GetProductById(int objId)
        {
            var objItem = _db.EMPLOYEES.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Employees> GetList()
        {
            List<Employees> list = _db.EMPLOYEES.ToList();
            return list;
        }
    }
}
