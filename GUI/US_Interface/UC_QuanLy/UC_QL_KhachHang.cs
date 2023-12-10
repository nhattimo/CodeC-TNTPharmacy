using BLL;
using DTO;
using GUI.US_Interface.From_CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_KhachHang : UserControl
    {
        private readonly UsersBusinessLogic _User = new UsersBusinessLogic();

        List<Users> _ListObjUsere;

        Users _ObjUsere;

        Label[] _laberError;

        bool _trangThai;
        public UC_QL_KhachHang()
        {
            InitializeComponent();
            _trangThai = true;
            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorName, errorSex, errorSex, errorEmail, errorAddress, errorDateOfBirth };
            Management.ErrorHide(_laberError);
        }

        private void UC_QL_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataIteamUses();
            RunContinuousFunction();
        }

        async Task RunContinuousFunction()
        {
            int IDProduct = Management.GetIDCustomer();
            while (true)
            {
                if (this.Visible != false)
                {
                    // nếu mã = 0 có nghĩa là vừa sảy ra sự kiện cập nhật hoặc xóa 
                    if (Management.GetIDCustomer() == 0)
                    {
                        Management.SetIDCustomer(-1);
                        LoadDataIteamUses();
                    }
                    // nếu mã đã có sự thay đổi thì có nghĩa là đã chọn 
                    else if (Management.GetIDCustomer() != IDProduct && Management.GetIDCustomer() > 0)
                    {
                        IDProduct = Management.GetIDCustomer();
                        LoadInfoOfIteam();
                    }
                }
                await Task.Delay(100);
            }
        }

        public void LoadInfoOfIteam()
        {
            _ObjUsere = _User.GetObjectById(Management.GetIDCustomer());
            
            txtName.Text = _ObjUsere.Name;
            if (_ObjUsere.Sex == "Nam" || _ObjUsere.Sex == "nam")
                radioButtonMale.Checked = true;
            else
                radioButtonFemale.Checked = true;
            txtDateOfBirth.Value = _ObjUsere.DateOfBirth;
            txtPhone.Text = _ObjUsere.Phone;
            txtEmail.Text = _ObjUsere.Email;
            txtAddress.Text = _ObjUsere.Address;
            try
            {
                picAnh.Image = System.Drawing.Image.FromFile(_ObjUsere.Image);
            }
            catch (Exception)
            {
                picAnh.Image = null;
            }
        }


        public void LoadDataIteamUses()
        {
            _ListObjUsere = _User.GetAllObject();
           

            flowLayoutPanelCustomers.Controls.Clear();

            // Load tất cả 
            if (flowLayoutPanelCustomers.Text == "Tất cả")
            {
                // Hiển thị danh sách sản phẩm trên giao diện
                Management.AddItemsUC(flowLayoutPanelCustomers, _ListObjUsere);
            } // load theo _ID_CategorySearch
            else
            {
                List<Users> itemListObj = new List<Users>();
                foreach (var item in _ListObjUsere)
                {
                    itemListObj.Add(item);
                }

                Management.AddItemsUC(flowLayoutPanelCustomers, itemListObj);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_QL_KhachHang_CRUD form_QL_KhachHang_CRUD = new Form_QL_KhachHang_CRUD();
            form_QL_KhachHang_CRUD.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_ObjUsere == null)
            {
                MessageBox.Show("hãy chọn nhân viên muốn sửa");
            }
            else
            {
                // check ko để trống
                Management.Check(txtName, errorName);
                Management.Check(radioButtonMale, radioButtonFemale, errorSex);
                Management.Check(txtDateOfBirth, errorDateOfBirth);
                Management.Check(txtEmail, errorEmail);
                Management.Check(txtAddress, errorAddress);
                // Xử lý sự kiện khi người dùng nhấn nút Thêm
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

                //
                if (_trangThai)
                {
                    _ObjUsere = _User.GetObjectById(Management.GetIDCustomer());
                    if (_ObjUsere == null)
                    {
                        MessageBox.Show("người dùng không tồn tại");
                    }
                    else
                    {
                        _ObjUsere.Name = txtName.Text;                               // Tên 
                        _ObjUsere.Sex = "Nam";                                      // Giới tính
                        _ObjUsere.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());  // Ngày sinh
                        _ObjUsere.Phone = txtPhone.Text;                             // SĐT
                        _ObjUsere.Address = txtAddress.Text;                           // Địa chỉ
                        _ObjUsere.Email = txtEmail.Text;                              // Email
                        _ObjUsere.Image = Management.SaveImage(picAnh, txtName.Text + txtPhone).ToString();                        
                        if (radioButtonFemale.Checked == true)
                            _ObjUsere.Sex = "Nữ";
                        // 
                        _User.Update(_ObjUsere.ID, _ObjUsere);
                        MessageBox.Show("Sửa thành công");
                        LoadDataIteamUses();
                    }

                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            if (string.IsNullOrEmpty(txtSearch.Text) != true)
            {
                List<Users> _iteamListObjProducts = FindUserssByKey(txtSearch.Text);
                Management.AddItemsUC(flowLayoutPanelCustomers, _iteamListObjProducts);
            }
            else
            {
                LoadDataIteamUses();
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Management.SetImage(picAnh, sender);
        }
        private List<Users> FindUserssByKey(string key)
        {
            List<Users> foundUsers = new List<Users>();
            _ListObjUsere = _User.GetAllObject();

            foreach (var item in _ListObjUsere)
            {
                // Kiểm tra xem tên sản phẩm có chứa từ khóa hay không (không phân biệt chữ hoa/chữ thường)
                if (item.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundUsers.Add(item);
                }
            }

            return foundUsers;
        }
    }
}
