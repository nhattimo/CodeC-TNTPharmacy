using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillOfflineBusinessLogic
    {
        private readonly BillOfflineDataAccess _objectDataAccess;

        public BillOfflineBusinessLogic(BillOfflineDataAccess objectDataAccess)
        {
            _objectDataAccess = objectDataAccess;
        }

        public void AddBillOffline(BillOffline obj)
        {
            // Thực hiện kiểm tra logic kinh doanh nếu cần
            // ...

            _objectDataAccess.InsertDataAccess(obj);
        }

        public void UpdateBillOffline(int objectId, BillOffline obj)
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

        public BillOffline GetBillOfflineById(int objectId)
        {
            // Thực hiện kiểm tra logic kinh doanh trước khi lấy thông tin đối tượng
            // ...

            return _objectDataAccess.GetProductById(objectId);
        }

        public List<BillOffline> GetAllBillOfflines()
        {
            // Thực hiện kiểm tra logic kinh doanh trước khi lấy danh sách đối tượng
            // ...

            return _objectDataAccess.GetList();
        }
    }
}