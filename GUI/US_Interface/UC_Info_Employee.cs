using BLL;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_Info_Employee : UserControl
    {
        private static readonly EmployeesBusinessLogic _Employee = new EmployeesBusinessLogic();
        private static readonly RolesBusinessLogic _Role = new RolesBusinessLogic();
        private static readonly AccountBusinesLogiccs _Account = new AccountBusinesLogiccs();
        public UC_Info_Employee()
        {
            InitializeComponent();
        }

        private void UC_QL_Info_Load(object sender, EventArgs e)
        {
            LoadInfoEmployee();
        }

        private void LoadInfoEmployee()
        {
            Employees obj = _Employee.GetObjectByIdtk(Management.GetIDAccount());
            Account ac = _Account.GetObjectById(obj.IDTK);
            Roles rl = _Role.GetObjectById(ac.Role);
            txtName.Text = obj.Name;
            txtDateOfBirth.Text = obj.DateOfBirth + "";
            txtSex.Text = obj.Sex;
            txtPhone.Text = obj.Phone;
            txtEmail.Text = obj.Email;
            txtAddress.Text = obj.Address;
            txtCCCD.Text = obj.CCCD;
            txtStartedDay.Text = obj.StartedDay + "";
            txtRole.Text = rl.Name;
            // kiểm tra ảnh
            if (File.Exists(obj.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    picAnh.Image = Image.FromFile(obj.Image) ;
                }
                catch
                {
                    picAnh.Image = null;
                }
            }
            else
            {
                // ảnh không tồn tại
                picAnh.Image = null;
            }
           
        }
    }
}
