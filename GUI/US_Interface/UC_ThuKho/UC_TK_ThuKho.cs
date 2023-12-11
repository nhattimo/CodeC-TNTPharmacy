using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.US_
{
    public partial class UC_TK_ThuKho : UserControl
    {
        //  sử dụng để tương tác với BLL (BusinessLogic)
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly WareHousingBusinessLogic _WareHousing = new WareHousingBusinessLogic();
        private readonly WareHousingDetailsBusinessLogic _WareHousingDetails = new WareHousingDetailsBusinessLogic();

        List<Products> _ListObjProduct;
        List<WareHousing> _ListObjWareHousing;
        List<WareHousingDetails> _ListObjWareHousingDetails;

        public UC_TK_ThuKho()
        {
            InitializeComponent();
            _ListObjWareHousingDetails = _WareHousingDetails.GetAllObject();
            int sltk = 0;
            foreach (var item in _ListObjWareHousingDetails)
            {
                sltk += item.Quantity;
            }

            _ListObjProduct = _Product.GetAllObject();

            int sldb = 0;
            foreach (var item in _ListObjProduct)
            {
                sldb += item.Quantity;
            }

            UserControl6[] control = { new UserControl6(sltk, "Tổng số lượng tồn kho"), new UserControl6(sldb, "Số lượng đang bán"), new UserControl6(4, "Sản phẩm trong kho") }; ;
            Management.AddItemsUC(flowLayoutPanelItem, control);

            LoadDataChart();
        }

        private void UC_TK_ThuKho_Load(object sender, EventArgs e)
        { 
        }
        private void LoadData()
        {
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            var productList = _Product.GetAllObject();

            // Hiển thị danh sách sản phẩm trên giao diện
            //dataGridViewProducts.DataSource = productList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            // Hiển thị giao diện tìm kiếm sản phẩm, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi tìm kiếm sản phẩm, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
        }



        private void LoadDataChart()
        {
            // Mô phỏng dữ liệu (thay thế bằng dữ liệu thực tế của bạn)
            List<int> data = new List<int> { 10, 20, 15, 30, 25 };

            if (data.Count > 0)
            {
                // Thêm dữ liệu vào loại biểu đồ đã tạo
                for (int i = 0; i < data.Count; i++)
                {
                    if (chartEnterTtheWarehouse.Series.IsUniqueName("Nhập kho"))
                    {
                        // Tạo và thêm series vào Chart
                        Series series = new Series("Nhập kho");
                        chartEnterTtheWarehouse.Series.Add(series);
                    }
                    chartEnterTtheWarehouse.Series[1].Points.AddXY(i + 1, data[i]);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong biểu đồ.");
            }

            List<int> data1 = new List<int> { 5, 3, 15, 5, 6 };

            if (data.Count > 0)
            {
                // Thêm dữ liệu vào loại biểu đồ đã tạo
                for (int i = 0; i < data1.Count; i++)
                {
                    if (chartDischarge.Series.IsUniqueName("Xuất kho"))
                    {
                        // Tạo và thêm series vào Chart
                        Series series = new Series("Xuất kho");
                        chartDischarge.Series.Add(series);
                    }
                    chartDischarge.Series[1].Points.AddXY(i + 1, data1[i]);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong biểu đồ.");
            }

            _ListObjProduct = _Product.GetAllObject();
            _ListObjWareHousing = _WareHousing.GetAllObject();
            _ListObjWareHousingDetails = _WareHousingDetails.GetAllObject();
            guna2DataGridView.Rows.Clear();
            guna2DataGridView.ColumnCount = 4;
            guna2DataGridView.Columns[0].Name = "ID";
            guna2DataGridView.Columns[1].Name = "Tên sản phẩm";
            guna2DataGridView.Columns[2].Name = "Số lượng trên sàn";
            guna2DataGridView.Columns[3].Name = "Đơn giá";
            foreach (var item in _ListObjProduct)
            {
                string[] row = { item.ID + "", item.Name + "", item.Quantity + "", item.Price + "" };
                guna2DataGridView.Rows.Add(row);

            }
        }
    }
}
