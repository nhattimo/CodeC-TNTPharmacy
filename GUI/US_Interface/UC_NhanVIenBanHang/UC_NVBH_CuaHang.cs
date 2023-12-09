using BLL;
using DTO;
using GUI.US_Interface.From_CRUD;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_NVBH_CuaHang : UserControl
    {

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();

        double total = 0;
        int sl = 0;

        public UC_NVBH_CuaHang()
        {
            InitializeComponent();
        }

        private void UC_NVBH_CuaHang_Load(object sender, EventArgs e)
        {
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelOrderProduct, VScrollBar);
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelProducts, guna2VScrollBar1);
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
        
        private void LoadPanlePay()
        {
            total = 0;
            sl = 0;
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                var obj = _Product.GetObjectById(item[0]);
                sl += item[1];
                total += (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0)) * item[1];
            }
            txtQuantity.Text = sl + "";
            ltxtTotal.Text = total + ".000";

        }
        async Task RunContinuousFunction()
        {
            int ItemLeng = Management.GetIDItemChooseProducts().Count;
            while (true)
            {
                if(Management.GetIDItemChooseProducts() == null)
                {
                    flowLayoutPanelOrderProduct.Controls.Clear();
                    panelPay.Visible = false;
                }
                else
                {
                    if (this.Visible != false)
                    {
                        // điều kiện btn pay
                        if (ItemLeng > 0)
                        {
                            if (panelPay.Visible != true)
                                panelPay.Visible = true;
                        }
                        else
                        {
                            if (panelPay.Visible != false)
                                panelPay.Visible = false;
                        }

                        // nếu độ dài thay đổi có nghĩa là có sự thay đổi 
                        if (Management.GetIDItemChooseProducts().Count > ItemLeng || Management.GetIDItemChooseProducts().Count < ItemLeng)
                        {
                            ItemLeng = Management.GetIDItemChooseProducts().Count;
                            LoadItemChooseProducts();
                            // tính tiền tổng sản phẩm đã chọn
                            LoadPanlePay();
                        }
                        else
                        {
                            LoadPanlePay();
                        }
                        /*else if(Management.GetIDItemChooseProducts().Count < leng)
                        {
                            leng = Management.GetIDItemChooseProducts().Count;
                            Console.WriteLine("Giảm 1" + "Số lượng hiện tại: " + leng);
                        }*/
                    }

                }
                await Task.Delay(100);
            }
        }
        
        // btn thanh toán
        private void btnPay_Click(object sender, EventArgs e)
        {
            Form_NVBH_Bill form_NVBH_Bill = new Form_NVBH_Bill(total, sl);
            form_NVBH_Bill.ShowDialog();
        }

        // btn tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
