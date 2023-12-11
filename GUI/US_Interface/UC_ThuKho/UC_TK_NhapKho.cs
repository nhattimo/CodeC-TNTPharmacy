using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_TK_NhapKho : UserControl
    {


        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly WareHousingBusinessLogic _WareHousing = new WareHousingBusinessLogic();
        private readonly WareHousingDetailsBusinessLogic _WareHousingDetails = new WareHousingDetailsBusinessLogic();

        List<Products> _ListObjProduct;
        List<WareHousing> _ListObjWareHousing;
        List<WareHousingDetails> _ListObjWareHousingDetails;

        Products _ObjProduct;
        WareHousing _ObjWareHousing;
        WareHousingDetails _ObjWareHousingDetails;

        Label[] _laberError;
        bool _trangThai;
        public UC_TK_NhapKho()
        {
            InitializeComponent();
            _ListObjProduct = _Product.GetAllObject();
            _ListObjWareHousing = _WareHousing.GetAllObject();
            _ListObjWareHousingDetails = _WareHousingDetails.GetAllObject();
            _laberError = new Label[] { errorCost, errorDescribe, errorIDProduct };
            Management.ErrorHide(_laberError);
            _trangThai = true;
        }

        private void UC_TK_NhapKho_Load(object sender, EventArgs e)
        {
            // Load dữ liệu vào giao diện khi UserControl được tải
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Management.Check(txtIDProduct, errorIDProduct);
            Management.Check(txtCost, errorCost);


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
                // Xử lý sự kiện khi người dùng nhấn nút Thêm
                DateTime time = DateTime.Now;
                _ObjWareHousing = new WareHousing();
                _ObjWareHousing.ImportedDate = time;
                _ObjWareHousing.ImportedBy = 1;

                _WareHousing.Add(_ObjWareHousing);

                _ObjWareHousingDetails = new WareHousingDetails();
                _ObjWareHousingDetails.IDPruduct = int.Parse(txtIDProduct.Text);
                _ObjWareHousingDetails.IDWareHousing = _ObjWareHousing.ID;
                _ObjWareHousingDetails.Quantity = int.Parse(txtQuantity.Value.ToString());
                _ObjWareHousingDetails.ImportedPrice = int.Parse(txtCost.Text);
                _ObjWareHousingDetails.TotalAmount = int.Parse(txtCost.Text) * int.Parse(txtQuantity.Value.ToString());
                _WareHousingDetails.Add(_ObjWareHousingDetails);
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else {
                MessageBox.Show("Hãy kiểm tra dữ liệu và thử lại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Xử lý sự kiện khi người dùng nhấn nút Cập nhật
            // Hiển thị giao diện cập nhật thông tin nhập kho, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi cập nhật thông tin nhập kho, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Xóa
            // Hiển thị giao diện xóa thông tin nhập kho, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi xóa thông tin nhập kho, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            // Hiển thị giao diện tìm kiếm thông tin nhập kho, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi tìm kiếm thông tin nhập kho, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }

        private void LoadData()
        {
            _ListObjProduct = _Product.GetAllObject();
            _ListObjWareHousing = _WareHousing.GetAllObject();
            _ListObjWareHousingDetails = _WareHousingDetails.GetAllObject();
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.ColumnCount = 4;
            guna2DataGridView1.Columns[0].Name = "ID";
            guna2DataGridView1.Columns[1].Name = "Tên sản phẩm";
            guna2DataGridView1.Columns[2].Name = "Số lượng trên sàn";
            guna2DataGridView1.Columns[3].Name = "Đơn giá";
            foreach (var item in _ListObjProduct)
            {
                string[] row = { item.ID + "", item.Name + "", item.Quantity + "", item.Price +"" };
                guna2DataGridView1.Rows.Add(row);

            }

            _ListObjProduct = _Product.GetAllObject();
            guna2DataGridView2.Rows.Clear();
            guna2DataGridView2.ColumnCount = 4;
            guna2DataGridView2.Columns[0].Name = "Ngày nhập";
            guna2DataGridView2.Columns[1].Name = "Số lượng";
            guna2DataGridView2.Columns[2].Name = "Tên sản phẩm";
            guna2DataGridView2.Columns[3].Name = "giá nhập";
            guna2DataGridView2.Columns[3].Name = "Tổng tiền";

            foreach (var item in _ListObjWareHousing)
            {
                foreach (var item1 in _ListObjWareHousingDetails)
                {
                    if (item.ID == item1.IDWareHousing)
                    {
                        _ObjProduct = _Product.GetObjectById(item1.IDPruduct);
                        string[] row = { item.ImportedBy + "", item1.Quantity + "", _ObjProduct.Name + "", item1.ImportedPrice + ".000 VND", item1.ImportedPrice * item1.Quantity + ".000 VND" };
                        guna2DataGridView2.Rows.Add(row);
                    }
                }
            }

            
            

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                guna2DataGridView1.CurrentRow.Selected = true;
                guna2DataGridView1.ReadOnly = true;
                if (guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    txtIDProduct.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtCost.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                }
                int sl = 0;
                foreach (var item in _ListObjWareHousingDetails)
                {
                    if(item.IDPruduct == int.Parse(txtIDProduct.Text))
                    {
                        sl += item.Quantity;
                    }
                }
                flowLayoutPanel1.Controls.Clear();
                UserControl7 userControl7 = new UserControl7(int.Parse(txtIDProduct.Text), sl);
                flowLayoutPanel1.Controls.Add(userControl7);
            }
            catch (Exception)
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
}