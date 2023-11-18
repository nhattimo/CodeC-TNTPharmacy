using DTO;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class ProductDataAccess
    {
        // Sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;

        // Phương thức tạo (constructor)
        public ProductDataAccess(AppPharmacyContext context)
        {
            _db = context;
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

        public bool IsMa(int objId)
        {
            var objItem = _db.PRODUCTS.SingleOrDefault(item => item.ID == objId);
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
