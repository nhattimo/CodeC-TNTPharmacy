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
        public readonly AccountBusinesLogiccs _objectBusinesLogiccs = new AccountBusinesLogiccs();

        Users _ObjUsers;

        public UC_ItemInfoCustomer()
        {
            InitializeComponent();
        }
        public UC_ItemInfoCustomer(int ID)
        {
            InitializeComponent();
            _ObjUsers = _Users.GetObjectById(ID);
            txtID.Text = _ObjUsers.ID + "";
            txtName.Text = _ObjUsers.Name;
            txtPhone.Text = _ObjUsers.Phone;
            txtSex.Text = _ObjUsers.Sex;
            txtpoint.Text = _ObjUsers.Point;
            txtAddress.Text = _ObjUsers.Address;
            txtDateOfbirth.Text = _ObjUsers.DateOfBirth.ToString();

            // kiểm tra ảnh
            if (File.Exists(_ObjUsers.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    PicAnh.Image = Image.FromFile(_ObjUsers.Image);
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
            // Nếu là vai trò quản lý
            if (_objectBusinesLogiccs.GetRole(Management.GetIDAccount()) == 1)
            {
                Management.SetIDCustomer(_ObjUsers.ID);
            }
            //truyen();
        }
    }
}
