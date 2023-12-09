using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_Thuoc : UserControl
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();

        double total = 0;
        int sl = 0;


        public UC_KH_Thuoc()
        {
            InitializeComponent();
            LoadData();
        }
        private void UC_KH_Thuoc_Load(object sender, EventArgs e)
        {
            //Management.AddItemsUC(flowLayoutPanelItemProducts, UCItemProduct);
            uC_KH_OrderInformation1.Visible = false;
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelItemProducts, guna2VScrollBar1);
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelIteamProductSelected, guna2VScrollBar2);
            RunContinuousFunction();
        }

        public void LoadData()
        {
            flowLayoutPanelItemProducts.Controls.Clear();
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            List<Products> listObj = _Product.GetAllObject();
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUC(flowLayoutPanelItemProducts, listObj);
        }
        private void LoadItemChooseProducts()
        {
            List<UC_ItemChooseProducts> listObj = new List<UC_ItemChooseProducts> { };
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                UC_ItemChooseProducts itemUC = new UC_ItemChooseProducts(item[0], item[1]);
                listObj.Add(itemUC);
            }
            flowLayoutPanelIteamProductSelected.Controls.Clear();
            Management.AddItemsUC(flowLayoutPanelIteamProductSelected, listObj);
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
                if (Management.GetIDItemChooseProducts() == null)
                {
                    flowLayoutPanelItemProducts.Controls.Clear();
                    //panelPay.Visible = false;
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
       
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (Management.ISCustomer())
            {
                uC_KH_OrderInformation1.Visible = true;
                uC_KH_OrderInformation1.BringToFront();
            }
            else
            {
                FormLuaChonCuaKhachHang formLuaChonCuaKhachHang = new FormLuaChonCuaKhachHang();
                formLuaChonCuaKhachHang.Show();
                formLuaChonCuaKhachHang.SendToBack();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
        
    }
}
