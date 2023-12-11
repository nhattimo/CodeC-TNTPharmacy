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
using System.Xml.Linq;

namespace GUI.US_Interface.UC_Item
{
    public partial class UC_KH_ItemOnlineOrder : UserControl
    {

        private readonly SalesOrderBusinessLogic _SalesOrder = new SalesOrderBusinessLogic();
        private readonly SalesOrderDetailBusinessLogic _SalesOrderDetail = new SalesOrderDetailBusinessLogic();
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly PayMentBusinessLogic _PayMent = new PayMentBusinessLogic();
        private readonly ShippingBusinessLogic _Shipping = new ShippingBusinessLogic();


        SalesOrder _ObjSalesOrder;
        Products _ObjProducts;
        Users _ObjUsers;
        PayMent _ObjPayMent;
        Shipping _ObjShipping;
        List<SalesOrderDetail> _ListObjSalesOrderDetail;


        public UC_KH_ItemOnlineOrder(int idSalesOrder)
        {
            InitializeComponent();
            btnAccept.Visible = true;
            _ObjSalesOrder = _SalesOrder.GetObjectById(idSalesOrder);
        }

        private void UC_KH_ItemOnlineOrder_Load(object sender, EventArgs e)
        {
            LoadDataItem();
        }


        private void LoadDataItem()
        {
            if (_ObjSalesOrder.Status == "Hoàn thành")
            {
                this.Hide();
            }
            else
            {

                txtTotal.Text = _ObjSalesOrder.TotalAmount + ".000";    // tổng số lượng tiền đơn hàng

                _ObjPayMent = _PayMent.GetObjectById(_ObjSalesOrder.IDPayment);


                _ObjShipping = _Shipping.GetObjectById(_ObjSalesOrder.IDShipping);


                _ObjUsers = _Users.GetObjectById(_ObjPayMent.IDCustomer);



                _ListObjSalesOrderDetail = _SalesOrderDetail.GetAllObjectByID(_ObjSalesOrder.ID);

                // load data sản phẩm
                DataGridViewProducts.Rows.Clear();
                DataGridViewProducts.ColumnCount = 5;
                DataGridViewProducts.Columns[0].Name = "Tên sản phẩm";
                DataGridViewProducts.Columns[1].Name = "Số lượng";
                DataGridViewProducts.Columns[2].Name = "Đơn giá";
                DataGridViewProducts.Columns[3].Name = "Giá giảm";
                DataGridViewProducts.Columns[4].Name = "Tổng giá";

                int SlTong = 0;
                foreach (var item in _ListObjSalesOrderDetail)
                {
                    _ObjProducts = _Product.GetObjectById(item.IDPruduct);
                    int sl = item.Quantity;
                    SlTong += sl;
                    string[] row = { _ObjProducts.Name, sl + "", _ObjProducts.Price + ".000 VND", (_ObjProducts.Price - (Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0))) * sl + ".000 VND", Math.Round((_ObjProducts.Price - (_ObjProducts.Price / 100) * _ObjProducts.Discount), 0) * sl + ".000 VND" };
                    DataGridViewProducts.Rows.Add(row);

                }

                txtCountQuanaty.Text = SlTong.ToString();
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Management.SetStatusOrder(0);
            _ObjSalesOrder.Status = "Đã nhận được hàng";
            _SalesOrder.Update(_ObjSalesOrder.ID, _ObjSalesOrder);
            this.Hide();
        }
    }
}
