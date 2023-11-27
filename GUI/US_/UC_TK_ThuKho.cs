using BLL;
using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_TK_ThuKho : UserControl
    {
        //  sử dụng để tương tác với BLL (BusinessLogic)
        private readonly ProductBusinessLogic _objectBusinessLogic = new ProductBusinessLogic();
        public UC_TK_ThuKho()
        {
            InitializeComponent();
            UserControl6[] control = { new UserControl6(18, "Hế lô ae"), new UserControl6(18, "Hế lô ae"), new UserControl6(18, "Hế lô ae") }; ;
            Management.AddItemsUC(flowLayoutPanelItem, control);
        }

        private void UC_TK_ThuKho_Load(object sender, EventArgs e)
        { 
        }
        private void LoadData()
        {
            // Gọi phương thức GetAllProducts từ lớp BLL để lấy danh sách sản phẩm
            var productList = _objectBusinessLogic.GetAllObject();

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
       

    }
}
