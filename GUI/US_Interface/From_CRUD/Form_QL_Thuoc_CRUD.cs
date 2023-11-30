using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.US_.From_CRUD
{
    public partial class Form_QL_Thuoc_CRUD : Form
    {

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();
        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        int IDProduct;
        int _ID_Suppliers = 1; // ID loại sản phẩm
        public Form_QL_Thuoc_CRUD(int ID)
        {
            InitializeComponent();
            IDProduct = ID;
            _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe, errorProductionDate, errorExpiryDate, errorPic };
            Management.ErrorHide(_laberError);
            _dataComboBox = new string[] { };
            _trangThai = false;
            LoaditemsComboBox();
            LoadInfo(ID);
        }

        //Load
        void LoadInfo(int id)
        {
            try
            {
                Products obj = _Product.GetObjectById(id);
                Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
                ComboBoxSupplier.Text = suppliers.Name;
                txtProductName.Text = obj.Name;
                txtCost.Text = obj.Price + "";
                txtDiscount.Text = obj.Discount + "";
                txtPrice.Text = Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0) + ".000 VND";
                txtProductionDate.Value = obj.ProductionDate;
                txtExpiryDate.Value = obj.ExpiryDate;
                txtDescribe.Text = obj.Description;
                try
                {
                    picAnh.Image = System.Drawing.Image.FromFile(obj.Image);
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
 
            }
        }
        private void LoaditemsComboBox()
        {
            List<Suppliers> listObj = _Suppliers.GetAllObject();
            _dataComboBox = new string[listObj.Count];
            for (int i = 0; i < listObj.Count; i++)
            {
                _dataComboBox[i] = listObj[i].Name;
            }
            ComboBoxSupplier.Items.Clear();

            // Gán mảng dữ liệu cho ComboBox
            if (_dataComboBox.Length > 0)
            {
                ComboBoxSupplier.Items.AddRange(_dataComboBox);
            }

        }
        

        // btn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Product.Delete(IDProduct);
            Management.SetIDProduct(0);
            MessageBox.Show("Xóa thành công");
            this.Close ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Check(ComboBoxSupplier, errorSupplier);
            Check(txtProductName, errorProductName);
            Check(txtCost, errorCost);
            Check(txtDiscount, errorDiscount);
            Check(picAnh, errorPic);
            Check(txtProductionDate, errorProductionDate);
            Check(txtExpiryDate, errorExpiryDate);

            // Xử lý sự kiện khi người dùng nhấn nút Thêm
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
            // Hiển thị giao diện thêm sản phẩm, thực hiện các logic cần thiết, và cập nhật cơ sở dữ liệu
            if (_trangThai == true)
            {
               // làm nhiệm vụ của nút
            }
            else
            {
                // không làm nhiệm vụ của nút
            }
        }



        // txt
        private void txtProductName_Leave(object sender, EventArgs e)
        {
            Check(txtProductName, errorProductName);
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            Check(txtCost, errorCost);
        }

        private void ComboBoxSupplier_Leave(object sender, EventArgs e)
        {
            Check(ComboBoxSupplier, errorSupplier);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            Check(txtDiscount, errorDiscount);
        }

        private void txtDescribe_Leave(object sender, EventArgs e)
        {
            Check(txtDescribe, errorDescribe);
        }



        
        // check
        private void Check(Guna2TextBox txt, Label error)
        {
            if (Management.ISNull(txt))
            {
                Management.Errorshow(error, "Không để trống");
            }
            else
                Management.ErrorHide(error);
        }

        private void Check(Guna2ComboBox txt, Label error)
        {
            if (Management.ISNull(txt))
            {
                Management.Errorshow(error, "Không để trống");
            }
            else
                Management.ErrorHide(error);
        }

        private void Check(PictureBox pic, Label error)
        {
            if (Management.ExistImg(pic))
            {
                Management.Errorshow(error, "Không để trống");
            }
            else
                Management.ErrorHide(error);
        }

        private void Check(Guna2DateTimePicker time, Label error)
        {
            if (Management.ISTime(time))
            {
                Management.Errorshow(error, "Không để trống");
            }
            else
                Management.ErrorHide(error);
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            Management.SetImage(picAnh, sender);
        }

        private void ComboBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        { 
        }
    }
}
