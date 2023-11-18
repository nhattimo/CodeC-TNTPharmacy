using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_TK_NhapKho : UserControl
    {
        public UC_TK_NhapKho()
        {
            InitializeComponent();
        }

        private void UC_TK_NhapKho_Load(object sender, EventArgs e)
        {
            // Load dữ liệu vào giao diện khi UserControl được tải
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Thêm
            // Hiển thị giao diện thêm thông tin nhập kho, thực hiện các logic kinh doanh cần thiết, và cập nhật cơ sở dữ liệu
            // ...

            // Sau khi thêm thông tin nhập kho, cập nhật lại danh sách và hiển thị trên giao diện
            LoadData();
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
            // Gọi phương thức hoặc logic cần thiết để load dữ liệu vào giao diện
            // Ví dụ: dataGridViewNhapKho.DataSource = GetData();
        }
    }
}