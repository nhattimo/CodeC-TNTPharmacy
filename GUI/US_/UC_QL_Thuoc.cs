using BLL;
using System;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace GUI.US_
{
    public partial class UC_QL_Thuoc : UserControl
    {
        private static UC_QL_Thuoc _instance;
        private static readonly object _lock = new object();

        //  sử dụng để tương tác với BLL (BusinessLogic)
        private readonly ProductBusinessLogic _Product  = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();

        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        int _ID_Suppliers; // ID nhà cung cấp
        int _ID_Category = 1; // ID loại sản phẩm
        int _ID_Created; // ID người tạo
        public UC_QL_Thuoc()
        {
            InitializeComponent();
            _dataComboBox = new string[] { };
            _trangThai = false;
            txtDiscount.Text = "0";
            _ID_Created = Management.GetIDAccount();
            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe, errorProductionDate, errorExpiryDate, errorPic };
            Management.ErrorHide(_laberError);

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị trên giao diện
            LoaditemsComboBox();
            LoadData();
            btnLoad.Visible = false;
        }


        public void UC_QL_Thuoc_Load(object sender, EventArgs e)
        {
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelProducts, VScrollBar);
        }

        public  void LoadData()
        {
            //flowLayoutPanelProducts.Controls.Clear();
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            List<Products> listObj = _Product.GetAllObject();
            // Hiển thị danh sách sản phẩm trên giao diện
            Management.AddItemsUC(flowLayoutPanelProducts, listObj);

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
                } else
                    _trangThai = true;
            }
            // Hiển thị giao diện thêm sản phẩm, thực hiện các logic cần thiết, và cập nhật cơ sở dữ liệu
            if (_trangThai == true)
            {
                var time = DateTime.Now;
                // Điều kiện để add
                // - Trùng nhà cung cấp nhưng khác tên 
                // - Trùng tên nhưng khác nhà cung cấp 
                Products products = new Products(
                    txtProductName.Text,            // Tên sản phẩm
                    float.Parse(txtCost.Text),      // Giá tiền
                    float.Parse(txtDiscount.Text),  // Phần trăm giảm giá
                    0,                              // Số lượng
                    time,                           // Thời gian nhập sản phẩm
                    Management.SaveImage(picAnh, txtProductName.Text + _ID_Suppliers + _ID_Category + _ID_Created),   // Đường dẫn ảnh
                    txtDescribe.Text,               // Mô tả sản phẩm
                    DateTime.Parse("10/10/2003"),   // Ngày sản xuất
                    DateTime.Parse("10/10/2003"),   // Ngày hết hạn
                    _ID_Suppliers,                  // ID nhà cung cấp
                    _ID_Category,                   // ID loại sản phẩm
                    _ID_Created                     // ID người tạo
                );
                MessageBox.Show("" + products);
                _Product.Add(products);
                Management.AddItemsUC(flowLayoutPanelProducts, products);
            }
            else {
                MessageBox.Show("Add thất bại");
            }
            // Sau khi thêm sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
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

        public void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdfsdfsdfsdf");
            AddInfoProduct();
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
            } else
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

        public void AddInfoProduct()
        {
            Products obj = _Product.GetObjectById(Management.GetIDProduct());
            Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
            ComboBoxSupplier.Text = suppliers.Name;
            txtProductName.Text = "Nhaatj timo";
            txtCost.Text = obj.Price + "";
            txtDiscount.Text = obj.Discount + "";
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

        public void Hien()
        {
            btnLoad.Visible = true;
        }

        public static UC_QL_Thuoc Instance
        {
            get
            {
                // Kiểm tra xem thể hiện đã được tạo chưa
                if (_instance == null)
                {
                    // Sử dụng khóa để đảm bảo chỉ có một luồng có thể tạo thể hiện
                    lock (_lock)
                    {
                        // Kiểm tra lại sau khi có khóa để đảm bảo không tạo thêm thể hiện
                        if (_instance == null)
                        {
                            _instance = new UC_QL_Thuoc();
                        }
                    }
                }
                return _instance;
            }
        }

        
    }
    
}
