using BLL;
using System;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using System.Threading.Tasks;

namespace GUI.US_
{
    public partial class UC_QL_Thuoc : UserControl
    {
        // Biến static Instance
        private static UC_QL_Thuoc _instance;

        // Để đảm bảo chỉ tạo một instance duy nhất, sử dụng một biến kiểm soát
        private static readonly object _lockObject = new object();

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();
        private readonly CategorysBusinessLogic _Categorys = new CategorysBusinessLogic();
        
        List<Categorys> _ListObjCategorys;
        List<Products> _ListObjProducts;
        List<Suppliers> _ListObjSuppliers;
        Suppliers _ObjSuppliers;
        Products _ObjProducts;
        int _ID_CategorySearch = 0; // ID loại sản phẩm

        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        int _ID_Suppliers; // ID nhà cung cấp
        int _ID_Category; // ID loại sản phẩm
        int _ID_Created; // ID người tạo
        public UC_QL_Thuoc()
        {
            InitializeComponent();
            _ListObjCategorys = _Categorys.GetAllObject();
            _ListObjProducts = _Product.GetAllObject();
            _ListObjSuppliers = _Suppliers.GetAllObject();
            _trangThai = false;
            txtDiscount.Text = "0";
            _ID_Created = Management.GetIDAccount();

            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorProductName, errorSupplier, errorCost, errorDiscount, errorDescribe, errorProductionDate, errorExpiryDate, errorPic, errorCategory };
            Management.ErrorHide(_laberError);
            Management.SetIDProduct(-1);

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị trên giao diện
            LoadDataComboBoxSupplier();
            LoadDataComboBoxCategoryChoose();
            LoadDataComboBoxCategoryTxt();
            ComboBoxCategoryChoose.Text = "Tất cả";
            LoadDataIteamProduct();

            

        }


        #region Demo Delegate
        /* public void AddInfoProduct(int ID)
         {

             try
             {
                 Products obj = _Product.GetObjectById(ID);
                 Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
                 ComboBoxSupplier.Text = suppliers.Name;
                 txtProductName.Text = obj.Name;
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
                 MessageBox.Show("Add item delegate");
             }
             catch (Exception)
             {

                 throw;
             }

         }
        public void SomeMethod(int id)
         {
             try
             {
                 Products obj = _Product.GetObjectById(id);
                 Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
                 ComboBoxSupplier.Text = suppliers.Name;
                 txtProductName.Text = obj.Name;
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
             catch (Exception)
             {

                 throw;
             }
         }
         */
        #endregion

        public void UC_QL_Thuoc_Load(object sender, EventArgs e)
        {
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelProducts, VScrollBar);
            RunContinuousFunction();
        }
       
        async Task RunContinuousFunction()
        {
            int IDProduct = Management.GetIDProduct();
            while (true)
            {
                if (this.Visible != false)
                {
                    // nếu mã = 0 có nghĩa là vừa sảy ra sự kiện cập nhật hoặc xóa 
                    if (Management.GetIDProduct() == 0)
                    {
                        Management.SetIDProduct(-1);
                        LoadDataIteamProduct();
                    }
                    // nếu mã đã có sự thay đổi thì có nghĩa là đã chọn vào sản phẩm đó
                    else if (Management.GetIDProduct() != IDProduct && Management.GetIDProduct() > 0)
                    {
                        IDProduct = Management.GetIDProduct();
                        LoadInfoProduct();
                    }
                }
                await Task.Delay(100);
            }
        }

        public void LoadDataIteamProduct()
        {
            flowLayoutPanelProducts.Controls.Clear();
            // Load tất cả 
            if (ComboBoxCategoryChoose.Text == "Tất cả")
            {
                // Hiển thị danh sách sản phẩm trên giao diện
                Management.AddItemsUC(flowLayoutPanelProducts, _ListObjProducts);
            } // load theo _ID_CategorySearch
            else
            {
                List<Products> itemListObj = new List<Products>() ;
                foreach (var item in _ListObjProducts)
                {
                    if(item.CategoryId == _ID_CategorySearch)
                        itemListObj.Add(item); 
                }

                Management.AddItemsUC(flowLayoutPanelProducts, itemListObj);
            }
        }

        private void LoadDataComboBoxSupplier()
        {
            _dataComboBox = new string[_ListObjSuppliers.Count];
            for (int i = 0; i < _ListObjSuppliers.Count; i++)
            {
                _dataComboBox[i] = _ListObjSuppliers[i].Name;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxSupplier.Items.Clear();
            if (_dataComboBox.Length > 0)
            {
                ComboBoxSupplier.Items.AddRange(_dataComboBox);
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

        private void LoadDataComboBoxCategoryChoose()
        {
            _dataComboBox = new string[_ListObjCategorys.Count];
            for (int i = 0; i < _ListObjCategorys.Count; i++)
            {
                _dataComboBox[i] = _ListObjCategorys[i].Name;
            }
            ComboBoxCategoryChoose.Items.Clear();
            ComboBoxCategoryChoose.Items.Add("Tất cả");
            // Gán mảng dữ liệu cho ComboBox
            if (_dataComboBox.Length > 0)
            {
                ComboBoxCategoryChoose.Items.AddRange(_dataComboBox);
            }

        }

        public void LoadInfoProduct()
        {
            try
            {
                _ObjProducts = _Product.GetObjectById(Management.GetIDProduct());
                _ObjSuppliers = _Suppliers.GetObjectById(_ObjProducts.SupplierId);
                ComboBoxSupplier.Text = _ObjSuppliers.Name;
                txtProductName.Text = _ObjProducts.Name;
                txtCost.Text = _ObjProducts.Price + "";
                txtDiscount.Text = _ObjProducts.Discount + "";
                txtProductionDate.Value = _ObjProducts.ProductionDate;
                txtExpiryDate.Value = _ObjProducts.ExpiryDate;
                txtDescribe.Text = _ObjProducts.Description;
                foreach (var item in _ListObjCategorys)
                {
                    if(item.ID == _ObjProducts.CategoryId)
                        ComboBoxCategoryTxt.Text = item.Name;
                }
                try
                {
                    picAnh.Image = System.Drawing.Image.FromFile(_ObjProducts.Image);
                }
                catch (Exception)
                {
                    picAnh.Image = null;
                }
            }
            catch (Exception)
            {

                throw;
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
            Check(ComboBoxCategoryTxt, errorCategory);
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
            _ListObjCategorys = _Categorys.GetAllObject();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            // Hiển thị giao diện tìm kiếm sản phẩm, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi tìm kiếm sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadDataIteamProduct();
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

        private void ComboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in _ListObjCategorys)
            {
                if(item.Name == ComboBoxCategoryChoose.Text)
                {
                    _ID_CategorySearch = item.ID;
                    Console.WriteLine(_ID_CategorySearch);
                    break;
                }
            }
            LoadDataIteamProduct();
        }
        
        private void ComboBoxCategoryTxt_Leave(object sender, EventArgs e)
        {
            Check(ComboBoxCategoryTxt, errorCategory);
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

        #region  check
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

        #endregion

        public static UC_QL_Thuoc Instance
        {
            get
            {
                // Kiểm tra xem instance đã được tạo chưa
                if (_instance == null)
                {
                    // Sử dụng lock để đảm bảo chỉ có một thread có thể tạo instance
                    lock (_lockObject)
                    {
                        // Kiểm tra lại xem instance đã được tạo trong trường hợp nhiều thread
                        if (_instance == null)
                        {
                            _instance = new UC_QL_Thuoc();
                        }
                    }
                }
                return _instance;
            }

        }

       




        // 

    }
    
}
