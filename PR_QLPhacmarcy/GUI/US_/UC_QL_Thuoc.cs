using BLL;
using System;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.US_
{
    public partial class UC_QL_Thuoc : UserControl
    {
        //  sử dụng để tương tác với BLL (BusinessLogic)
        private readonly ProductBusinessLogic _Product;
        private readonly SuppliersBusinessLogic _Suppliers;
        UC_ItemProduct[] _UCItemProduct;
        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        int _ID_Suppliers;
        public UC_QL_Thuoc()
        {
            InitializeComponent();
            _Product = new ProductBusinessLogic();
            _Suppliers = new SuppliersBusinessLogic();

            _dataComboBox = new string[] { };
            _trangThai = false;
            txtDiscount.Text = "0";

            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe };
            Management.ErrorHide(_laberError);

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị trên giao diện
            LoaditemsComboBox();
            LoadData();
        }
        private void UC_QL_Thuoc_Load(object sender, EventArgs e)
        {
            
        }
        
        private void LoadData()
        {
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            List<Products> listObj = _Product.GetAllObject();
            _UCItemProduct = new UC_ItemProduct[listObj.Count];
            for (int i = 0; i < listObj.Count; i++)
            {
                _UCItemProduct[i] = new UC_ItemProduct(listObj[i].ID, listObj[i].Price, listObj[i].Discount, listObj[i].Name, listObj[i].Image);
            }
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUC(flowLayoutPanelProducts, _UCItemProduct);
            
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

        // BTN
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Thêm
            _trangThai = false;
            foreach (var item in _laberError)
            {
                if (item.Visible == true)
                {
                    _trangThai = false;
                    break;
                }else
                    _trangThai = true;
            }
            if(_trangThai == true)
            {
                MessageBox.Show("ok");
            }
            else {
                MessageBox.Show("no");
            }





            // Hiển thị giao diện thêm sản phẩm, thực hiện các logic cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi thêm sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Cập nhật
            // Hiển thị giao diện cập nhật sản phẩm, thực hiện các logic cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi cập nhật sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Xóa
            // Hiển thị giao diện xóa sản phẩm, thực hiện các logic cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi xóa sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            // Hiển thị giao diện tìm kiếm sản phẩm, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi tìm kiếm sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        
        // TXT

        private void txtSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            _ID_Suppliers = _Suppliers.GetID(ComboBoxSupplier.SelectedItem.ToString());
            MessageBox.Show("" + _ID_Suppliers);
        }
        
        private void ComboBoxSupplier_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(ComboBoxSupplier))
                Management.Errorshow(errorSupplier, "Không để trống");
            else
                Management.ErrorHide(errorSupplier);
        }
        
        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(txtProductName))
            {
                Management.Errorshow(errorProductName, "Không để trống");
            }else
                Management.ErrorHide(errorProductName);
        }
        
        private void txtCost_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(txtCost))
            {
                Management.Errorshow(errorCost, "Không để trống");
            }
            else
                Management.ErrorHide(errorCost);
        }
        
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(txtDiscount))
            {
                Management.Errorshow(errorDiscount, "Không để trống");
            }
            else
                Management.ErrorHide(errorDiscount);
        }

        

        private void picAnh_Click(object sender, EventArgs e)
        {
            Management.SetImage(picAnh, sender);
        }
    }
}
