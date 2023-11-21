using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDataAccess
    {
        //  sử dụng để tương tác với cơ sở dữ liệu
        private readonly AppPharmacyContext _db = new AppPharmacyContext();
        public AccountDataAccess()
        {

        }
        public void Insert(Account obj)
        {
            _db.ACCOUNT.Add(obj);
            _db.SaveChanges();
        }

        public void Update(int objId, Account obj)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
            {
                objItem = obj;
                _db.SaveChanges();
            }
        }

        public void Delete(int objId)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.ID == objId);
            _db.ACCOUNT.Remove(objItem);
            _db.SaveChanges();
        }

        public bool IsMa(int objId)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.ID == objId);
            if (objItem != null)
                return true;
            return false;

        }
        
        public bool IsAccountName(string objAccountName)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.AccountName == objAccountName);
            if (objItem != null)
                return true;
            return false;

        }
        
        public bool IsLogin(string objAccountName, string objPasswword)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.AccountName == objAccountName && item.Password == objPasswword);
            if (objItem != null)
                return true;
            return false;

        }
       
        public Account GetProductById(int objId)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.ID == objId);
            return objItem;
        }

        public List<Account> GetList()
        {
            List<Account> list = _db.ACCOUNT.ToList();
            return list;
        }

        public int GetID(string objAccountName)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.AccountName == objAccountName);
            if (objItem != null)
                return objItem.ID;
            return 0;
        }
        public int GetRole(string objAccountName)
        {
            var objItem = _db.ACCOUNT.SingleOrDefault(item => item.AccountName == objAccountName);
            if (objItem != null)
                return objItem.Role;
            return 0;
        }

    }
}
