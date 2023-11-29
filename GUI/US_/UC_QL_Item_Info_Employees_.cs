using BLL;
using DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_Item_Info_Employees_ : UserControl
    {
        public readonly EmployeesBusinessLogic _EmployeesBusinesLogiccs = new EmployeesBusinessLogic();

        private int ID { get; set; }
        public UC_QL_Item_Info_Employees_(int id)
        {
            ID = id;
            InitializeComponent();
            LoadEmmployess();
        }
        private void LoadEmmployess()
        {
            Employees obj = _EmployeesBusinesLogiccs.GetObjectById(ID);
            txtNameStaff.Text = obj.Name;
            txtPosition.Text = Management.GetNameRole(obj.ID);
            txtCCCD.Text = obj.CCCD;
            txtPhoneNumber.Text = obj.Phone;
            txtDateOfbirth.Text = obj.DateOfBirth + "";
            txtStartDate.Text = obj.StartedDay + "";
            txtSex.Text = obj.Sex;
            txtAddress.Text = obj.Address;
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

        private void PicAnh_MouseClick(object sender, MouseEventArgs e)
        {
            Management.SetIDEmployess(ID);
        }
    }
}
