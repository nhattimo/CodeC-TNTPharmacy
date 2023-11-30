using BLL;
using DTO;
using GUI.US_;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;



namespace GUI
{
    public static class Management
    {

        private static readonly EmployeesBusinessLogic _Employee = new EmployeesBusinessLogic();
        private static readonly UsersBusinessLogic _User = new UsersBusinessLogic();

        private static readonly RolesBusinessLogic _Role = new RolesBusinessLogic();
        private static readonly AccountBusinesLogiccs _Account = new AccountBusinesLogiccs();

        private static int IdIteamProduct;
        private static int IdIteamEmployess;
        private static int IdIteamEmployess1;


        // 1 số điều khiể giao diện
        public static void ScrollBarFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, Guna2VScrollBar vScrollBar)
        {
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(flowLayoutPanel, vScrollBar);
        }
        public static void BtnColerClick(Guna2GradientTileButton btn, Color colorBtn)
        {
            btn.BackColor = colorBtn;
        }
        public static void BtnRefreshColerTransparentClick(Guna2GradientTileButton[] btnArray, Color colorBtnArray)
        {
            foreach (var item in btnArray)
            {
                item.BackColor = colorBtnArray;
            }
        }
        public static void BtnTasbalClick(Guna2GradientTileButton[] btnArray, Color colorbtnArray, Guna2GradientTileButton btn, Color colorBtn)
        {

            // Trả array btn.BackColor về màu trong suốt
            BtnRefreshColerTransparentClick(btnArray, colorbtnArray);

            // chuyển màu Backcolor
            BtnColerClick(btn, colorBtn);
        }
        public static void BtnColerClick(Guna2GradientButton btn, Color colorBtn)
        {
            btn.BackColor = colorBtn;
        }
        public static void BtnRefreshColerTransparentClick(Guna2GradientButton[] btnArray, Color colorBtnArray)
        {
            foreach (var item in btnArray)
            {
                item.BackColor = colorBtnArray;
            }
        }
        public static void BtnTasbalClick(Guna2GradientButton[] btnArray, Color colorbtnArray, Guna2GradientButton btn, Color colorBtn)
        {

            // Trả array btn.BackColor về màu trong suốt
            BtnRefreshColerTransparentClick(btnArray, colorbtnArray);

            // chuyển màu Backcolor
            BtnColerClick(btn, colorBtn);
        }

        // UC
        public static void UCArrayVisible(UserControl[] uCArrray, UserControl uC)
        {
            uC.Visible = true;

            foreach (var item in uCArrray)
            {
                if (item != uC)
                    item.Visible = false;
            }
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, UserControl[] uC)
        {
            foreach (var item in uC)
            {
                flowLayoutPanel.Controls.Add(item);
            }
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, UserControl uC)
        {
             flowLayoutPanel.Controls.Add(uC); 
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, Products obj)
        {
            UC_ItemProduct itemProduct = new UC_ItemProduct(obj.ID);
            flowLayoutPanel.Controls.Add(itemProduct);
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, List<Products> listObj)
        {
            UC_ItemProduct [] itemProduct = new UC_ItemProduct[listObj.Count];
            for (int i = 0; i < listObj.Count; i++)
            {
                itemProduct[i] = new UC_ItemProduct(listObj[i].ID);
            }

            foreach (var item in itemProduct)
            {
                flowLayoutPanel.Controls.Add(item);
            }
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, Employees obj)
        {
            UC_ItemInfoEmployees_ itemProduct = new UC_ItemInfoEmployees_(obj.ID);
            flowLayoutPanel.Controls.Add(itemProduct);
        }
        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, List<Employees> listObj)
        {
            UC_ItemInfoEmployees_[] itemProduct = new UC_ItemInfoEmployees_[listObj.Count];
            for (int i = 0; i < listObj.Count; i++)
            {
                itemProduct[i] = new UC_ItemInfoEmployees_(listObj[i].ID);
            }

            foreach (var item in itemProduct)
            {
                flowLayoutPanel.Controls.Add(item);
            }
        }

        // Error
        public static void ErrorHide(System.Windows.Forms.Label[] txt)
        {
            foreach (var item in txt)
            {
                item.Text = string.Empty;
                item.Hide();
            }
        }
        public static void ErrorHide(System.Windows.Forms.Label txt)
        {
            txt.Hide();
        }
        public static void Errorshow(System.Windows.Forms.Label txt, string content)
        {

            txt.Text = content;
            txt.Show();

        }

        // Is null
        public static bool ISNull(Guna2TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
                return true;
            return false;
        }
        public static bool ISNull(Guna2ComboBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
                return true;
            return false;
        }
        public static bool ISTime(Guna2DateTimePicker time)
        {
            if (string.IsNullOrEmpty(time.Text))
                return true;
            return false;
        }
        public static bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static bool IsNumber(string SDT)
        {
            foreach (Char c in SDT)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static bool ExistImg(PictureBox pictureBox)
        {
            if (pictureBox.ImageLocation == null)
                return false;
            return true;
        }

        // Set
        public static void SetImage(PictureBox pictureBox, object sender)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                open.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;";
                open.FilterIndex = 1; // This sets the default filter to Image Files
                open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // You can change the initial directory as needed

                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
        public static void SetIDAccount(int maTK)
        {
            string filePath = "data";

            if (!File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(maTK);
                        bw.Flush();
                    }
                }
            }
            else
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(maTK);
                        bw.Flush();
                    }
                }
            }
        }
        public static string SaveImage(PictureBox pictureBox, string txt)
        {
            string fname = txt + ".jpg";
            // Đường dẫn đầy đủ đến thư mục mới
            string folderPath = @"D:\FolderImgProduct";
            string pathString = "";
            try
            {
                // Kiểm tra xem thư mục đã tồn tại hay chưa
                if (!Directory.Exists(folderPath))
                {
                    // Nếu chưa tồn tại, tạo thư mục mới
                    Directory.CreateDirectory(folderPath);

                    pathString = Path.Combine(folderPath, fname); pictureBox.Image.Save(pathString);
                }
                else
                {
                    pathString = Path.Combine(folderPath, fname); pictureBox.Image.Save(pathString);
                }
                return pathString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static void SetIDProduct(int idProduct)
        {
            IdIteamProduct = idProduct;
        }
        public static void SetIDEmployess(int idEmployess)
        {
            IdIteamEmployess = idEmployess;
        }

        // Get
        public static string GetNameRole(int IDTK)
        {
            Roles rl = _Role.GetObjectById(IDTK);
            return rl.Name;
        }
        public static int GetIDAccount()
        {
            int a = 0;
            string filePath = "data";

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        a = br.ReadInt32();
                    }
                }
            }
            return a;
        }
        public static string GetNameEmployeesAccount()
        {
            Employees obj = _Employee.GetObjectById(GetIDAccount());
            return obj.Name;
        }
        public static string GetNameCustomerAccount()
        {
            Users obj = _User.GetObjectById(GetIDAccount());
            return obj.Name;
        }
        public static int GetIDProduct()
        {
            return IdIteamProduct;
        }
        public static int GetIDEmployess()
        {
            return IdIteamEmployess;
        }

        // Load
        public static void LoadInfoEmployee(PictureBox Image, System.Windows.Forms.Label Name, System.Windows.Forms.Label DateOfBirth, System.Windows.Forms.Label Sex, System.Windows.Forms.Label Phone, System.Windows.Forms.   Label Email, System.Windows.Forms.Label Address, System.Windows.Forms.Label CCCD, System.Windows.Forms.Label StartedDay, System.Windows.Forms.Label Role)
        {
            Employees obj = _Employee.GetObjectById(GetIDAccount());
            Roles rl = _Role.GetObjectById(GetIDAccount());

            Name.Text = obj.Name;
            DateOfBirth.Text = obj.DateOfBirth + "";
            Sex.Text = obj.Sex;
            Phone.Text = obj.Phone;
            Email.Text = obj.Email;
            Address.Text = obj.Address;
            CCCD.Text = obj.CCCD;
            StartedDay.Text = obj.StartedDay + "";
            Role.Text = rl.Name;
            Image.ImageLocation = obj.Image;

        }
        public static void LoadInfoCustomer(PictureBox Image, System.Windows.Forms. Label Name, System.Windows.Forms.Label Sex, System.Windows.Forms.Label Phone, System.Windows.Forms.Label Email, System.Windows.Forms.Label Address)
        {
            if (ISCustomer())
            {
                Users obj = _User.GetObjectById(GetIDAccount());
                Name.Text = obj.Name;
                Sex.Text = obj.Sex;
                Phone.Text = obj.Phone;
                Email.Text = obj.Email;
                Address.Text = obj.Address;
                Image.ImageLocation = obj.Image;
                MessageBox.Show("Đã có tài khoản");
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }
            
        }
        public static void LogginForm(Form form, int IDTK)
        {

            switch (_Account.GetRole(IDTK)) // Lấy ID Role
            {
                // Quản Lý
                case 1:
                    form.Hide();
                    SetIDAccount(IDTK);
                    FormQuanLy formQuanLy = new FormQuanLy();
                    formQuanLy.ShowDialog();
                    form.Close();
                    break;

                // Nhân Viên Bán Hàng
                case 2:
                    form.Hide();
                    SetIDAccount(IDTK);
                    FormNhanVienBanHang formNhanVienBanHang = new FormNhanVienBanHang();
                    formNhanVienBanHang.ShowDialog();
                    form.Close();
                    break;

                // Nhân Viên Thủ Kho
                case 3:
                    form.Hide();
                    SetIDAccount(IDTK);
                    FormThuKho formThuKho = new FormThuKho();
                    formThuKho.ShowDialog();
                    form.Close();
                    break;
                // Nhân Viên Kế Toán

                case 4:
                    form.Hide();
                    SetIDAccount(IDTK);
                    form.Close();
                    break;

                // Khách hàng
                case 5:
                    form.Hide();
                    SetIDAccount(IDTK);
                    FormKhachHang formKhachHang = new FormKhachHang(true);
                    formKhachHang.ShowDialog();
                    form.Close();
                    break;

                default:

                    break;
            }
        }
        public static void LogOut(Form form)
        {
            SetIDAccount(0);
            form.Hide();
            FormDieuKhienChucVu formDieuKhienChucVu = new FormDieuKhienChucVu();
            formDieuKhienChucVu.ShowDialog();
            form.Close();
        }
        public static bool ISCustomer()
        {
            if(GetIDAccount() == 0 || _User.GetObjectById(GetIDAccount()) == null)
                return false;
            return true;
        }

        public static void Check(Guna2TextBox txt, Label error)
        {
            if (ISNull(txt))
            {
                Errorshow(error, "Không để trống");
            }
            else
                ErrorHide(error);
        }
        public static void Check(Guna2ComboBox txt, Label error)
        {
            if (ISNull(txt))
            {
                Errorshow(error, "Không để trống");
            }
            else
                ErrorHide(error);
        }

        public static void Check(PictureBox pic, Label error)
        {
            if (ExistImg(pic))
            {
                Errorshow(error, "Không để trống");
            }
            else
                ErrorHide(error);
        }

        public static void Check(Guna2DateTimePicker time, Label error)
        {
            if (ISTime(time))
            {
                Errorshow(error, "Không để trống");
            }
            else
                ErrorHide(error);
        }
        public static void Check(RadioButton radioradioButtonMale, RadioButton radioButtonFemale, Label error)
        {
            if (radioradioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                Errorshow(error, "Không để trống");
            }
            else
                ErrorHide(error);
        }


    }
}
