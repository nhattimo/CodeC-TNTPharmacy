using BLL;
using DTO;
using GUI.US_;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.US_Interface.From_CRUD
{
    public partial class Form_KH_Bill : Form
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        private readonly SalesOrderBusinessLogic _SalesOrder = new SalesOrderBusinessLogic();
        private readonly SalesOrderDetailBusinessLogic _SalesOrderDetail = new SalesOrderDetailBusinessLogic();
        private readonly ShippingBusinessLogic _Shipping = new ShippingBusinessLogic();
        private readonly PayMentMethondBusinessLogic _PayMentMethond = new PayMentMethondBusinessLogic();
        private readonly PayMentBusinessLogic _PayMentMet = new PayMentBusinessLogic();


        int sl = 0;

        string[] _dataComboBoxShiping;
        string[] _dataComboBoxPayMentMethond;

        List<Shipping> _listObjShipping;
        List<PayMentMethond> _listObjPayMentMethond;

        Label[] _laberError;

        Users _ObjUsers;
        SalesOrder _ObjSalesOrder;
        PayMent _ObjPayMent;
        SalesOrderDetail _ObjPayMentDetail;
        Products _ObjProducts;
        bool _trangThai;

        int _ID_ShipingChoose;
        int _ID_PayMentMethondChoose;

        float _TotalPrice;
        public Form_KH_Bill()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form_KH_Bill_Load(object sender, EventArgs e)
        {
            _ObjUsers = _Users.GetObjectByIdtk(Management.GetIDAccount());
            _listObjShipping = _Shipping.GetAllObject();
            _listObjPayMentMethond = _PayMentMethond.GetAllObject();
            _laberError = new Label[] { errorPayMethond, errorShiping };
            Management.ErrorHide(_laberError);

            //AddItemProducts();
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(flowLayoutPanelIteamProduct, VScrollBar);
            PushCustomerInformation();
            LoadItemChooseProducts();

            LoadDataComboBoxShiping();
            LoadDataComboBoxPayMethod();
            LoadPanlePay();
           
        }

        private void LoadPanlePay()
        {
            _TotalPrice = 0;
            sl = 0;
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                var obj = _Product.GetObjectById(item[0]);
                sl += item[1];
                _TotalPrice += (float)(Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0)) * item[1];
            }
            txtQuantity.Text = sl + "";
            txtTotal.Text = _TotalPrice + ".000";

        }

        private void LoadDataComboBoxShiping()
        {
            int leng = _listObjShipping.Count;

            _dataComboBoxShiping = new string[leng];
            for (int i = 0; i < leng; i++)
            {
                _dataComboBoxShiping[i] = _listObjShipping[i].Name;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxShiping.Items.Clear();
            if (_dataComboBoxShiping.Length > 0)
            {
                ComboBoxShiping.Items.AddRange(_dataComboBoxShiping);
            }

        }

        private void LoadDataComboBoxPayMethod()
        {
            int leng = _listObjPayMentMethond.Count;

            _dataComboBoxPayMentMethond = new string[leng];
            for (int i = 0; i < leng; i++)
            {
                _dataComboBoxPayMentMethond[i] = _listObjPayMentMethond[i].NameMethod;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxPayMethod.Items.Clear();
            if (_dataComboBoxPayMentMethond.Length > 0)
            {
                ComboBoxPayMethod.Items.AddRange(_dataComboBoxPayMentMethond);
            }

        }
        #region Event

        // btn đặt hàng
        private void btnBuyNow_Click_1(object sender, EventArgs e)
        {
            Management.Check(ComboBoxShiping,errorShiping);
            Management.Check(ComboBoxPayMethod, errorPayMethond);

            foreach (var item in _laberError)
            {
                if (item.Visible == true)
                {
                    _trangThai = false;
                    break;
                }
                else
                    _trangThai = true;
            }

            if (_trangThai)
            {
                //
                _ObjPayMent = new PayMent();
                _ObjPayMent.TotalPrice = _TotalPrice;
                _ObjPayMent.IDMethod = _ID_PayMentMethondChoose;
                _ObjPayMent.IDCustomer = _ObjUsers.ID;

                _PayMentMet.Add(_ObjPayMent);
                //


                //
                DateTime date = DateTime.Now;
                _ObjSalesOrder = new SalesOrder();
                _ObjSalesOrder.OrderDate = date;
                _ObjSalesOrder.Status = "Đang chờ xác nhận";
                _ObjSalesOrder.TotalAmount = _TotalPrice;
                _ObjSalesOrder.IDShipping = _ID_ShipingChoose;
                _ObjSalesOrder.IDPayment = _ObjPayMent.ID;

                _SalesOrder.Add(_ObjSalesOrder);

                //

                foreach (var item in Management.GetIDItemChooseProducts())
                {
                    _ObjProducts = _Product.GetObjectById(item[0]);
                    _ObjPayMentDetail = new SalesOrderDetail();
                    _ObjPayMentDetail.Quantity = item[1]; // số lượng
                    _ObjPayMentDetail.SoldPrice = (float)(Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0)); // giá bán
                    _ObjPayMentDetail.TotalAmount = (float)(Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0)) * item[1]; // tồng giá bán
                    _ObjPayMentDetail.IDPruduct = _ObjProducts.ID; // id sản phẩm
                    _ObjPayMentDetail.IDSalesOrder = _ObjSalesOrder.ID;  // 

                    _SalesOrderDetail.Add(_ObjPayMentDetail);
                }


                MessageBox.Show("Đặt hàng thành công");
                Management.SetIDItemChooseProductsNew();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            // làm mới dữ liệu
        }
        #endregion


        #region Function

        // đẩy thông tin khách hàng
        void PushCustomerInformation()
        {
            txtNameCustomer.Text = _ObjUsers.Name;
            txtPhone.Text = _ObjUsers.Phone;
            txtAddress.Text = _ObjUsers.Address;

        }
        // Add dữ liệu thông tin thanh toán

        private void LoadItemChooseProducts()
        {
            List<UC_ItemChooseProducts> listObj = new List<UC_ItemChooseProducts> { };
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                UC_ItemChooseProducts itemUC = new UC_ItemChooseProducts(item[0], item[1]);
                listObj.Add(itemUC);
            }
            flowLayoutPanelIteamProduct.Controls.Clear();
            Management.AddItemsUC(flowLayoutPanelIteamProduct, listObj);
        }
        #endregion

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxShiping_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in _listObjShipping)
            {
                if (item.Name == ComboBoxShiping.SelectedItem.ToString())
                {
                    _ID_ShipingChoose = item.ID;
                    MessageBox.Show("chọn = " + _ID_ShipingChoose);
                    break;
                }
            }
        }

        private void ComboBoxPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in _listObjPayMentMethond)
            {
                if (item.NameMethod == ComboBoxPayMethod.SelectedItem.ToString())
                {
                    _ID_PayMentMethondChoose = item.ID;
                    MessageBox.Show("chọn = " + _ID_PayMentMethondChoose);
                    break;
                }
            }
        }
    }
}
