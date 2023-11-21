using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBusinesLogiccs
    {
        private readonly AccountDataAccess _objectDataAccess = new AccountDataAccess();

        public AccountBusinesLogiccs()
        {
           
        }

        public void AddBillOffline(Account obj)
        {
            // Thực hiện kiểm tra logic kinh doanh nếu cần
            // ...

            _objectDataAccess.Insert(obj);
        }

        public void UpdateBillOffline(int objectId, Account obj)
        {
            // Thực hiện kiểm tra logic kinh doanh nếu cần
            // ...

            _objectDataAccess.Update(objectId, obj);
        }

        public void DeleteBillOffline(int objectId)
        {
            // Thực hiện kiểm tra logic kinh doanh nếu cần
            // ...

            _objectDataAccess.Delete(objectId);
        }

        public bool BillOfflineExists(int objectId)
        {
            // Thực hiện kiểm tra logic để kiểm tra sự tồn tại của đối tượng
            // ...

            return _objectDataAccess.IsMa(objectId);
        }

        public Account GetBillOfflineById(int objectId)
        {
            // Thực hiện kiểm tra logic kinh doanh trước khi lấy thông tin đối tượng
            // ...

            return _objectDataAccess.GetProductById(objectId);
        }

        public List<Account> GetAllBillOfflines()
        {
            // Thực hiện kiểm tra logic kinh doanh trước khi lấy danh sách đối tượng
            // ...

            return _objectDataAccess.GetList();
        }

        public bool Exists(string objAccountName)
        {
            return _objectDataAccess.IsAccountName(objAccountName);
        }

        public bool IsLoggin(string objAccountName, string objPasswword)
        {
            return _objectDataAccess.IsLogin(objAccountName, objPasswword);
        }
        
        public int GetID(string objAccountName)
        {
            return _objectDataAccess.GetID(objAccountName);
        }
        public int GetRole(string objAccountName)
        {
            return _objectDataAccess.GetRole(objAccountName);
        }


    }
}
