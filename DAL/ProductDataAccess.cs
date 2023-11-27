using DTO;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class ProductDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db = new AppPharmacyContext();

        // Phương thức tạo (constructor)
        public ProductDataAccess()
        {
            
        }

        public void InsertDataAccess(Products obj)
        {
            _db.PRODUCTS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Products obj)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.ID == objId);
            _db.PRODUCTS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool Exists(int objId)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;
        }
        
        public bool Exists(string name)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.Name == name);
            if (objItem != null)
                return true;
            return false;
        }
        public bool IsSupplierId(int id)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.SupplierId == id);
            if (objItem != null)
                return true;
            return false;
        }
        public Products GetProductById(int objId)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Products> GetList()
        {
            List<Products> list = _db.PRODUCTS.ToList();
            return list;
        }
    }
}
