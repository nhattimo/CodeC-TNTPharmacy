using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GUI.US_.From_CRUD
{
    public partial class Form_QL_Thuoc_CRUD : Form
    {

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();
        private readonly CategorysBusinessLogic _Categorys = new CategorysBusinessLogic();

        List<Categorys> _ListObjCategorys;
        Products _ObjProducts;
        Suppliers _ObjSuppliers;
        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        int _ID_Created = Management.GetIDAccount(); // ID người tạo
        int _ID_Suppliers; // ID nhà cung cấp
        int _ID_Category; // ID loại sản phẩm

        public Form_QL_Thuoc_CRUD(int ID)
        {
            InitializeComponent();
            _ListObjCategorys = _Categorys.GetAllObject();
            _ObjProducts = _Product.GetObjectById(ID);
            _ObjSuppliers = _Suppliers.GetObjectById(_ObjProducts.SupplierId);
             _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe, errorProductionDate, errorExpiryDate, errorPic, errorCategory };
            Management.ErrorHide(_laberError);
            _dataComboBox = new string[] { };
            _trangThai = false;
            LoaditemsComboBox();
            LoadDataComboBoxCategoryTxt();
            
            LoadInfo(ID);
        }


        private void Form_QL_Thuoc_CRUD_Load(object sender, EventArgs e)
        {
           
        }



        //Load
        void LoadInfo(int id)
        {
            try
            {
                _ObjProducts = _Product.GetObjectById(id);
                _ObjSuppliers = _Suppliers.GetObjectById(_ObjProducts.SupplierId);
                ComboBoxSupplier.Text = _ObjSuppliers.Name;
                txtProductName.Text = _ObjProducts.Name;
                txtCost.Text = _ObjProducts.Price + "";
                txtDiscount.Text = _ObjProducts.Discount + "";
                txtPrice.Text = Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0) + ".000 VND";
                txtProductionDate.Value = _ObjProducts.ProductionDate;
                txtExpiryDate.Value = _ObjProducts.ExpiryDate;
                txtDescribe.Text = _ObjProducts.Description;
                foreach (var item in _ListObjCategorys)
                {
                    if (item.ID == _ObjProducts.CategoryId)
                        ComboBoxCategoryTxt.Text = item.Name;
                }
                try
                {
                    PicAnh.Image = System.Drawing.Image.FromFile(_ObjProducts.Image);
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
 
            }
        }
        private void LoadDataComboBoxCategoryTxt()
        {
            _dataComboBox = new string[_ListObjCategorys.Count];
            for (int i = 0; i < _ListObjCategorys.Count; i++)
            {
                _dataComboBox[i] = _ListObjCategorys[i].Name;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxCategoryTxt.Items.Clear();
            if (_dataComboBox.Length > 0)
            {
                ComboBoxCategoryTxt.Items.AddRange(_dataComboBox);
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
            _Product.Delete(_ObjProducts.ID);
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
            Check(PicAnh, errorPic);
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
                _ObjProducts.Name = txtProductName.Text;                // Tên sản phẩm
                _ObjProducts.Price = float.Parse(txtCost.Text);         // Giá tiền
                _ObjProducts.Discount = float.Parse(txtDiscount.Text);  // Phần trăm giảm giá     
                _ObjProducts.Description = txtDescribe.Text;            // Mô tả sản phẩm
                _ObjProducts.ProductionDate = DateTime.Parse(txtProductionDate.Text);   // Ngày sản xuất
                _ObjProducts.ExpiryDate = DateTime.Parse(txtExpiryDate.Text);           // Ngày hết hạn
                _ObjProducts.SupplierId = _ID_Suppliers;                // ID nhà cung cấp
                _ObjProducts.CategoryId = _ID_Category;                 // ID loại sản phẩm
                _ObjProducts.Image = Management.SaveImage(PicAnh, "" + _ObjProducts.ID + _ID_Suppliers +_ID_Category + _ID_Created);   // Đường dẫn ảnh
                _Product.Update(_ObjProducts.ID, _ObjProducts);
                MessageBox.Show(_ObjProducts.Image);
                MessageBox.Show("Sửa thành công");

                Management.SetIDProduct(0);
                this.Close();
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


        private void ComboBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            _ID_Suppliers = _Suppliers.GetID(ComboBoxSupplier.SelectedItem.ToString());
        }

        private void ComboBoxCategoryTxt_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in _ListObjCategorys)
            {
                if (item.Name == ComboBoxCategoryTxt.Text)
                {
                    _ID_Category = item.ID;
                    Console.WriteLine(_ID_Category + " " + item.Name);
                    break;
                }
            }
        }

        private void PicAnh_Click(object sender, EventArgs e)
        {
            Management.SetImage(PicAnh, sender);
        }
    }
}
