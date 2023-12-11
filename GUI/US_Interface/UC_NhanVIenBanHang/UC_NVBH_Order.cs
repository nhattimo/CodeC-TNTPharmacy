using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_NVBH_Order : UserControl
    {
        private readonly SalesOrderBusinessLogic _SalesOrder = new SalesOrderBusinessLogic();
  

        List<SalesOrder> _ListObjSalesOrder;



        public UC_NVBH_Order()
        {
            InitializeComponent();
            _ListObjSalesOrder = _SalesOrder.GetAllObject();
            LoadData();
        }

        private void UC_NVBH_Order_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUC(flowLayoutPanel1, _ListObjSalesOrder);
        }


    }
}
