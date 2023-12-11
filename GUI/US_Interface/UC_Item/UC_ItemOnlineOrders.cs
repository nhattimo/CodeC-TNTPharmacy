using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_ItemOnlineOrders : UserControl
    {
        private readonly SalesOrderBusinessLogic _SalesOrder = new SalesOrderBusinessLogic();
        private readonly SalesOrderDetailBusinessLogic _SalesOrderDetail = new SalesOrderDetailBusinessLogic();
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly PayMentBusinessLogic _PayMent = new PayMentBusinessLogic();
        private readonly ShippingBusinessLogic _Shipping = new ShippingBusinessLogic();

        /*
         * Đang chờ xác nhận
         * Đang chuẩn bị hàng
        Đang chờ vận chuyển nhận hàng
        Đang giao hàng
        Đã nhận được hàng
        Hoàn trả
        Hủy đơn 
        Không nhận hàng
        Hoàn thành
        */

        List<string> statust = new List<string>() { "Đang chờ xác nhận", "Đang chuẩn bị hàng", "Đang chờ vận chuyển nhận hàng", "Đang giao hàng"};
        string[] _dataComboBox;

        SalesOrder _ObjSalesOrder;
        Products _ObjProducts;
        Users _ObjUsers;
        PayMent _ObjPayMent;
        Shipping _ObjShipping;
        List<SalesOrderDetail> _ListObjSalesOrderDetail;


        int _IDSalesOrder;


        public UC_ItemOnlineOrders(int idSalesOrder)
        {
            InitializeComponent();
            _IDSalesOrder = idSalesOrder;
            txtStatustNow.Visible = false;
            _ObjSalesOrder = _SalesOrder.GetObjectById(_IDSalesOrder);
            LoadDataItem();
        }

        async Task RunContinuousFunction()
        {
            Management.SetStatusOrder(0);
            while (true)
            {
                if (Management.GetStatusOrder() == 0)
                {
                    if (_ObjSalesOrder.Status == "Đang chờ xác nhận")
                    {
                        this.BackColor = Color.FloralWhite;
                        guna2HtmlLabel9.Visible = false;
                        txtStatus.Visible = false;
                        txtStatustNow.Visible = false;
                        btnComplete.Visible = false;

                        btnAccept.Visible = true;
                    }
                    else if (_ObjSalesOrder.Status == "Đang chuẩn bị hàng" || _ObjSalesOrder.Status == "Đang chờ vận chuyển nhận hàng")
                    {

                    }
                    else if (_ObjSalesOrder.Status == "Đang giao hàng")
                    {

                        this.BackColor = Color.LightGreen;

                        guna2HtmlLabel9.Visible = false;
                        txtStatus.Visible = false;
                        txtStatustNow.Visible = false;
                        btnAccept.Visible = false;

                        btnComplete.Visible = true;
                        btnComplete.Checked = false;
                        txtStatustNow.Visible = true;
                        txtStatustNow.Text = _ObjSalesOrder.Status;

                    }
                    else if (_ObjSalesOrder.Status == "Đã nhận được hàng" || _ObjSalesOrder.Status == "Hoàn trả" || _ObjSalesOrder.Status == "Hủy đơn" || _ObjSalesOrder.Status == "Không nhận hàng")
                    {

                        this.BackColor = Color.LightGreen;
                        guna2HtmlLabel9.Visible = false;
                        txtStatus.Visible = false;
                        txtStatustNow.Visible = false;
                        btnAccept.Visible = false;

                        btnComplete.Visible = true;
                        btnComplete.Checked = true;
                        txtStatustNow.Visible = true;
                        txtStatustNow.Text = _ObjSalesOrder.Status;

                    }
                    Management.SetStatusOrder(1);
                }

                await Task.Delay(100);
            }
        }


        private void LoadDataItem()
        {
            if(_ObjSalesOrder.Status == "Hoàn thành")
            {
                this.Hide();
            }
            else
            {
                txttxtIDOrder.Text = "DHTNT" + _ObjSalesOrder.ID ;      // ID đơn hàng
                txtDateOrder.Text = _ObjSalesOrder.OrderDate + "";      // Ngày đặt hàng
                txtTotal.Text = _ObjSalesOrder.TotalAmount + ".000";    // tổng số lượng tiền đơn hàng
            
                _ObjPayMent = _PayMent.GetObjectById(_ObjSalesOrder.IDPayment);


                _ObjShipping = _Shipping.GetObjectById(_ObjSalesOrder.IDShipping);
                txtShipping.Text = _ObjShipping.Name; // Đơn vị vận chuyển
            

                _ObjUsers = _Users.GetObjectById(_ObjPayMent.IDCustomer);
                txtName.Text = _ObjUsers.Name;
                txtAddress.Text = _ObjUsers.Address;
                txtPhone.Text = _ObjUsers.Phone;


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
                RunContinuousFunction();
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            btnAccept.Text = "Nhận đơn";
            btnComplete.Visible = false;
            LoadDataComboBoxStatust();

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnAccept.Text = "Đã nhận đơn";
            btnAccept.Checked = false; 
            btnAccept.Enabled = false;
            this.BackColor = Color.LemonChiffon;

            guna2HtmlLabel9.Visible = true;
            txtStatus.Visible = true;
        }
        private void LoadDataComboBoxStatust()
        {
            _dataComboBox = new string[statust.Count];
            for (int i = 0; i < statust.Count; i++)
            {
                _dataComboBox[i] = statust[i];
            }


            // Gán mảng dữ liệu cho ComboBox
            txtStatus.Items.Clear();
            if (_dataComboBox.Length > 0)
            {
                txtStatus.Items.AddRange(_dataComboBox);
            }

        }

        private void txtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statust = txtStatus.SelectedItem.ToString();
            if (statust == "Đang giao hàng")
            {
                Management.SetStatusOrder(0);
                this.BackColor = Color.LightGreen;
                _ObjSalesOrder.Status = statust;
                _SalesOrder.Update(_ObjSalesOrder.ID, _ObjSalesOrder);
                txtStatustNow.Text = statust;
            }
            else
            {
                Management.SetStatusOrder(0);
                _ObjSalesOrder.Status = statust;
                _SalesOrder.Update(_ObjSalesOrder.ID, _ObjSalesOrder);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Management.SetStatusOrder(0);
            _ObjSalesOrder.Status = "Hoàn thành";
            _SalesOrder.Update(_ObjSalesOrder.ID, _ObjSalesOrder);
            this.Hide();
        }
    }
}
                
