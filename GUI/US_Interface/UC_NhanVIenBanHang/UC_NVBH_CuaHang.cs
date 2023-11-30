using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_NVBH_CuaHang : UserControl
    {

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();
        
        public UC_NVBH_CuaHang()
        {
            InitializeComponent();
        }

        private void UC_NVBH_CuaHang_Load(object sender, EventArgs e)
        {
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelOrderProduct, VScrollBar);
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelProducts, guna2VScrollBar1);
            uC_Bill1.Visible = false;
            LoadData();
            RunContinuousFunction();
        }

        public void LoadData()
        {
            flowLayoutPanelProducts.Controls.Clear();
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            List<Products> listObj = _Product.GetAllObject();
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUC(flowLayoutPanelProducts, listObj);
        }
        
        private void LoadItemChooseProducts()
        {
            List<UC_ItemChooseProducts> listObj = new List<UC_ItemChooseProducts> { };
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                UC_ItemChooseProducts itemUC = new UC_ItemChooseProducts(item[0], item[1]);
                listObj.Add(itemUC);
            }
            flowLayoutPanelOrderProduct.Controls.Clear();
            Management.AddItemsUC(flowLayoutPanelOrderProduct, listObj);
        }
        
        async Task RunContinuousFunction()
        {
            int leng = Management.GetIDItemChooseProducts().Count;
            while (true)
            {
                if (this.Visible != false)
                {
                    // nếu độ dài thay đổi có nghĩa là có sự thay đổi 
                    if (Management.GetIDItemChooseProducts().Count > leng || Management.GetIDItemChooseProducts().Count < leng)
                    {
                        leng = Management.GetIDItemChooseProducts().Count;
                        LoadItemChooseProducts();
                        Console.WriteLine("Tăng 1" + "Số lượng hiện tại: " + leng);

                    }
                    else if(Management.GetIDItemChooseProducts().Count < leng)
                    {
                        leng = Management.GetIDItemChooseProducts().Count;
                        Console.WriteLine("Giảm 1" + "Số lượng hiện tại: " + leng);
                    } 
                }
                await Task.Delay(100);
            }
        }
        
        // btn thanh toán
        private void btnPay_Click(object sender, EventArgs e)
        {
            uC_Bill1.Visible = true;
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                Console.WriteLine("Sản phẩm ID = " + item[0] + " Số lượng: " + item[1] );
            }
            
        }

        // btn tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
