using BLL;
using DTO;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_ItemInfoCustomer : UserControl
    {
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        public UC_ItemInfoCustomer()
        {
            InitializeComponent();
        }
        public UC_ItemInfoCustomer(int ID)
        {
            InitializeComponent();
            Users obj = _Users.GetObjectById(ID);
            txtID.Text = obj.ID + "";
            txtName.Text = obj.Name;
            txtPhone.Text = obj.Phone;
            txtSex.Text = obj.Sex;
            txtpoint.Text = obj.Point;
            txtAddress.Text = obj.Address;
            txtDateOfbirth.Text = obj.DateOfBirth.ToString();

            // kiểm tra ảnh
            if (File.Exists(obj.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    PicAnh.Image = Image.FromFile(obj.Image);
                }
                catch
                {
                    PicAnh.Image = null;
                }
            }
            else
            {
                // ảnh không tồn tại
                PicAnh.Image = null;
            }


        }

        private void PicAnh_Click(object sender, System.EventArgs e)
        {

        }
    }
}
