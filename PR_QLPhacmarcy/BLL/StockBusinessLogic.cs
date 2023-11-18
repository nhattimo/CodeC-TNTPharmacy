using DTO;
using System;
using System.Collections;
using System.Collections.Generic;


namespace DAL
{
	public class StockBusinessLogic
	{
		private readonly StockDataAccess _objectDataAccess;

		public StockBusinessLogic(StockDataAccess objectDataAccess)
		{
			_objectDataAccess = objectDataAccess;
		}

		public void AddObject(Stocks obj)
		{
			// Kiểm tra logic trước khi thêm đối tượng
			// ...

			_objectDataAccess.InsertDataAccess(obj);
		}

		public void UpdateObject(int objectId, Stocks obj)
		{
			// Kiểm tra logic trước khi cập nhật đối tượng
			// ...

			_objectDataAccess.Update(objectId, obj);
		}

		public void DeleteObject(int objectId)
		{
			// Kiểm tra logic trước khi xóa đối tượng
			// ...

			_objectDataAccess.Delete(objectId);
		}

		public bool ObjectExistsById(int objectId)
		{
			// Kiểm tra logic để kiểm tra sự tồn tại của đối tượng
			// ...

			return _objectDataAccess.IsMa(objectId);
		}

		public bool ObjectExistsByDate(DateTime objectDate)
		{
			// Kiểm tra logic để kiểm tra sự tồn tại của đối tượng theo ngày
			// ...

			return _objectDataAccess.IsMa(objectDate);
		}

		public Stocks GetObjectById(int objectId)
		{
			// Kiểm tra logic kinh doanh trước khi lấy thông tin đối tượng
			// ...

			return _objectDataAccess.GetObjectById(objectId);
		}

		public List<Stocks> GetAllObjects()
		{
			// Kiểm tra logic kinh doanh trước khi lấy danh sách đối tượng
			// ...

			return _objectDataAccess.GetList();
		}
	}
}