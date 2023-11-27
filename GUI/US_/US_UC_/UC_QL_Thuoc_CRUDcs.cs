using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.US_.US_UC_
{
    public partial class UC_QL_Thuoc_CRUDcs : UserControl
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();

        Label[] _laberError;
        string[] _dataComboBox;
        int _ID_Suppliers = 0; // ID nhà cung cấp
        int _ID_Category = 1; // ID loại sản phẩm
        int _ID_Created = Management.GetIDAccount(); // ID người tạo
        public UC_QL_Thuoc_CRUDcs()
        {
            InitializeComponent();
            _dataComboBox = new string[] { };
            _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe, errorProductionDate, errorExpiryDate, errorPic };
            Management.ErrorHide(_laberError);
            LoaditemsComboBox();
            AddThongTinSanPham();
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

        public void AddThongTinSanPham()
        {
            string filePath = @"E:\CodeC - TNTPharmacy\PR_QLPhacmarcy\Icon\087349.png";
            Products obj = _Product.GetObjectById(Management.GetIDProduct());
            Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
            ComboBoxSupplier.Text = suppliers.Name;
            txtProductName.Text = obj.Name;
            txtCost.Text = obj.Price + "";
            txtDiscount.Text = obj.Discount + "";
            txtProductionDate.Value = obj.ProductionDate;
            txtExpiryDate.Value = obj.ExpiryDate;
            txtDescribe.Text = obj.Description;

            if (picAnh.ImageLocation == null)
                picAnh.ImageLocation = filePath;
            else
                picAnh.ImageLocation = obj.Image;
        }

        // TXT

        private void txtSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            _ID_Suppliers = _Suppliers.GetID(ComboBoxSupplier.SelectedItem.ToString());
        }

        private void ComboBoxSupplier_Leave(object sender, EventArgs e)
        {
            Check(ComboBoxSupplier, errorSupplier);
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            Check(txtProductName, errorProductName);
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            Check(txtCost, errorCost);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            Check(txtDiscount, errorDiscount);
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            Management.SetImage(picAnh, sender);
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
        
        // 
    }
}
