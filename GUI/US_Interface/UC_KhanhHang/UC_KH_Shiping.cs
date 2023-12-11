using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_Interface.UC_KhanhHang
{
    public partial class UC_KH_Shiping : UserControl
    {
        private readonly SalesOrderBusinessLogic _SalesOrder = new SalesOrderBusinessLogic();


        List<SalesOrder> _ListObjSalesOrder;
        public UC_KH_Shiping()
        {
            InitializeComponent();
            _ListObjSalesOrder = _SalesOrder.GetAllObject();
            LoadData();
        }
        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUCKH(flowLayoutPanel1, _ListObjSalesOrder);
        }
    }
}
