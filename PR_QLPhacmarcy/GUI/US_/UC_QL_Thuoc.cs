using BLL;
using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_Thuoc : UserControl
    {
        //  sử dụng để tương tác với BLL (BusinessLogic)
        private readonly ProductBusinessLogic _objectBusinessLogic;

        public UC_QL_Thuoc()
        {
            InitializeComponent();

            //_productBLL = new ProductBusinessLogic();

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị trên giao diện
            LoadData();
        }
        private void UC_QL_Thuoc_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            var productList = _objectBusinessLogic.GetAllObject();

            // Hiển thị danh sách sản phẩm trên giao diện
            //dataGridViewProducts.DataSource = productList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Thêm
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
    }
}
