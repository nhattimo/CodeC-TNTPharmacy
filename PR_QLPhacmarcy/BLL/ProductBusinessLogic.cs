using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ProductBusinessLogic
    {
        // Sử dụng để tương tác với DAL (DataAccess)
        private ProductDataAccess _objectDataAccess =  new ProductDataAccess();

        public ProductBusinessLogic()
        {
        }
        
        public void Add(Products obj)
        {
            // Kiểm tra logic trước khi thêm sản phẩm
            // ...

            // Gọi phương thức InsertDataAccess từ lớp DAL để thêm sản phẩm vào cơ sở dữ liệu
            _objectDataAccess.InsertDataAccess(obj);
        }

        public void Update(int idObj, Products obj)
        {
            // Kiểm tra logic trước khi cập nhật sản phẩm
            // ...

            // Gọi phương thức Update từ lớp DAL để cập nhật thông tin sản phẩm
            _objectDataAccess.Update(idObj, obj);
        }

        public void Delete(int idObj)
        {
            // Kiểm tra logic trước khi xóa sản phẩm
            // ...

            // Gọi phương thức Delete từ lớp DAL để xóa sản phẩm khỏi cơ sở dữ liệu
            _objectDataAccess.Delete(idObj);
        }

        public bool Exists(int idObj)
        {
            // Kiểm tra logic để kiểm tra sự tồn tại của sản phẩm
            // ...

            // Gọi phương thức IsMa từ lớp DAL để kiểm tra sự tồn tại của sản phẩm trong cơ sở dữ liệu
            return _objectDataAccess.Exists(idObj);
        }
        public bool Exists(string name)
        {
            // Kiểm tra logic để kiểm tra sự tồn tại của sản phẩm
            // ...

            // Gọi phương thức IsMa từ lớp DAL để kiểm tra sự tồn tại của sản phẩm trong cơ sở dữ liệu
            return _objectDataAccess.Exists(name);
        }
        public bool IsSupplierId(int idObj )
        {
            // Kiểm tra logic để kiểm tra sự tồn tại của sản phẩm
            // ...

            // Gọi phương thức IsMa từ lớp DAL để kiểm tra sự tồn tại của sản phẩm trong cơ sở dữ liệu
            return _objectDataAccess.IsSupplierId(idObj);
        }

        public Products GetObjectById(int idObj)
        {
            // Kiểm tra logic kinh doanh trước khi lấy thông tin sản phẩm
            // ...

            // Gọi phương thức GetProductById từ lớp DAL để lấy thông tin sản phẩm từ cơ sở dữ liệu
            return _objectDataAccess.GetProductById(idObj);
        }

        public List<Products> GetAllObject()
        {
            // Kiểm tra logic kinh doanh trước khi lấy danh sách sản phẩm
            // ...

            // Gọi phương thức GetList từ lớp DAL để lấy danh sách sản phẩm từ cơ sở dữ liệu
            return _objectDataAccess.GetList();
        }
    }
}
