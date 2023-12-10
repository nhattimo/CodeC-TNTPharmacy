using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_Interface.From_CRUD
{

    public partial class Form_QL_KhachHang_CRUD : Form
    {
        private readonly UsersBusinessLogic _User = new UsersBusinessLogic();
        public readonly AccountBusinesLogiccs _AccountBusinesLogiccs = new AccountBusinesLogiccs();

        List<Account> _ListObjAcounts;
        Users _ObjUsere;

        Label[] _laberError;

        bool _trangThai;

        public Form_QL_KhachHang_CRUD()
        {
            InitializeComponent();
            _laberError = new Label[] { errorNameAccount, errorPassword, errorName, errorDateOfBirth, errorSex, errorEmail, errorAddress, errorPhone};
            Management.ErrorHide(_laberError);
            _ListObjAcounts = _AccountBusinesLogiccs.GetAllObject();
            LoadInfoOfIteam();
        }
        public void LoadInfoOfIteam()
        {
            _ObjUsere = _User.GetObjectById(Management.GetIDCustomer());
            if (_ObjUsere != null)
            {
                txtNameAccount.Text = "";
                txtPassword.Text = "";
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
                    PicAnh.Image = System.Drawing.Image.FromFile(_ObjUsere.Image);
                }
                catch (Exception)
                {
                    PicAnh.Image = null;
                } 
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check ko để trống
            Management.Check(txtNameAccount, errorNameAccount);
            Management.Check(txtPassword, errorPassword);
            Management.Check(txtName, errorName);
            Management.Check(txtDateOfBirth, errorDateOfBirth);
            Management.Check(txtEmail, errorEmail);
            Management.Check(txtAddress, errorAddress);
          
            // Xử lý sự kiện khi người dùng nhấn nút Thêm
            foreach (var item in _laberError){
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
                foreach (var item in _ListObjAcounts)
                {
                    if (item.AccountName == txtNameAccount.Text)
                    {
                        _trangThai = false ;
                        MessageBox.Show("Tài khoản đã được sửa dụng, bạn hãy nhập tên tài khoản khác");
                        break;
                    }
                }
                if (_trangThai)
                {
                    // tạo tài khoản
                    Account account = new Account(txtNameAccount.Text, txtPassword.Text, 5);
                    _AccountBusinesLogiccs.Add(account);

                    _ObjUsere = new Users();
                    
                    _ObjUsere.Name = txtName.Text;                               // Tên 
                    _ObjUsere.Sex = "Nam";                                      // Giới tính
                    _ObjUsere.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());  // Ngày sinh
                    _ObjUsere.Phone = txtPhone.Text;                             // SĐT
                    _ObjUsere.Address = txtAddress.Text;                           // Địa chỉ
                    _ObjUsere.Email = txtEmail.Text;                              // Email
                    _ObjUsere.Image = Management.SaveImage(PicAnh, txtName.Text + txtPhone).ToString();
                    _ObjUsere.Point = "0";
                    _ObjUsere.IDTK = account.ID;
                    if (radioButtonFemale.Checked == true)
                        _ObjUsere.Sex = "Nữ";
                    // 
                    _User.Add(_ObjUsere);
                    MessageBox.Show("Sửa thành công");
                    Management.SetIDCustomer(0);
                    this.Close();
                    
                } 
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
