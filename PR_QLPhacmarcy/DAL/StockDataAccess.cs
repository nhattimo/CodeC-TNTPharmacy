
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StockDataAccess
    {
        //  sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db;
        //  Phương thức tạo (constructor)
        public StockDataAccess(AppPharmacyContext context)
        {
            _db = context;
        }

        public void InsertDataAccess(Stocks obj)
        {
            _db.STOCKS.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Stocks obj)
        {
            var objItem = _db.STOCKS.SingleOrDefault(item => item.IDPruduct == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.STOCKS.SingleOrDefault(item => item.IDPruduct == objId);
            _db.STOCKS.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.STOCKS.SingleOrDefault(item => item.IDPruduct == objId);
            if (objItem != null)
                return true;
            return false;

        }

        public bool IsMa(DateTime objId)
        {
            var objItem = _db.STOCKS.SingleOrDefault(item => item.MonthYear == objId);
            if (objItem != null)
                return true;
            return false;

        }

        public Stocks GetObjectById(int objId)
        {
            var objItem = _db.STOCKS.SingleOrDefault(item => item.IDPruduct == objId);
            return objItem;
        }

        public List<Stocks> GetList()
        {
            List<Stocks> list = _db.STOCKS.ToList();
            return list;
        }
    }
}
