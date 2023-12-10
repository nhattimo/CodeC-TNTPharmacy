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

        Employees _ObjEmployees;
        Account _ObjAccount;
        Roles _ObjRoles;
        public UC_Info_Employee()
        {
            InitializeComponent();

        }

        private void UC_QL_Info_Load(object sender, EventArgs e)
        {
           //LoadInfoEmployee();
        }

        private void LoadInfoEmployee()
        {
            _ObjEmployees = new Employees();
            _ObjAccount = new Account();
            _ObjRoles = new Roles();

            _ObjEmployees = _Employee.GetObjectByIdtk(Management.GetIDAccount());
            _ObjAccount = _Account.GetObjectById(_ObjEmployees.IDTK);
            _ObjRoles = _Role.GetObjectById(_ObjAccount.Role);
            txtName.Text = _ObjEmployees.Name;
            txtDateOfBirth.Text = _ObjEmployees.DateOfBirth + "";
            txtSex.Text = _ObjEmployees.Sex;
            txtPhone.Text = _ObjEmployees.Phone;
            txtEmail.Text = _ObjEmployees.Email;
            txtAddress.Text = _ObjEmployees.Address;
            txtCCCD.Text = _ObjEmployees.CCCD;
            txtStartedDay.Text = _ObjEmployees.StartedDay + "";
            txtRole.Text = _ObjRoles.Name;
            // kiểm tra ảnh
            if (File.Exists(_ObjEmployees.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    picAnh.Image = Image.FromFile(_ObjEmployees.Image) ;
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
