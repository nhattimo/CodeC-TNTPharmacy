using GUI.US_;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using Image = System.Drawing.Image;



namespace GUI
{
    public static class Management
    {

        // chuyển màu Backcolor una2GradientTileButton
        public static void BtnColerClick(Guna2GradientTileButton btn, Color colorBtn)
        {
            btn.BackColor = colorBtn;
        }

        // Trả array btn.BackColor về màu trong suốt
        public static void BtnRefreshColerTransparentClick(Guna2GradientTileButton[] btnArray, Color colorBtnArray)
        {
            foreach (var item in btnArray)
            {
                item.BackColor = colorBtnArray;
            }
        }

        // 
        public static void BtnTasbalClick(Guna2GradientTileButton[] btnArray, Color colorbtnArray, Guna2GradientTileButton btn, Color colorBtn)
        {

            // Trả array btn.BackColor về màu trong suốt
            BtnRefreshColerTransparentClick(btnArray, colorbtnArray);
            
            // chuyển màu Backcolor
            BtnColerClick(btn,colorBtn);
        }


        
        
        // chuyển màu Backcolor Guna2GradientButton
        public static void BtnColerClick(Guna2GradientButton btn, Color colorBtn)
        {
            btn.BackColor = colorBtn;
        }

        // Trả array btn.BackColor về màu trong suốt
        public static void BtnRefreshColerTransparentClick(Guna2GradientButton[] btnArray, Color colorBtnArray)
        {
            foreach (var item in btnArray)
            {
                item.BackColor = colorBtnArray;
            }
        }
        //
        public static void BtnTasbalClick(Guna2GradientButton[] btnArray, Color colorbtnArray, Guna2GradientButton btn, Color colorBtn)
        {

            // Trả array btn.BackColor về màu trong suốt
            BtnRefreshColerTransparentClick(btnArray, colorbtnArray);

            // chuyển màu Backcolor
            BtnColerClick(btn, colorBtn);
        }

        
        
        // UC
        public static void UCArrayVisible(System.Windows.Forms.UserControl[] uCArrray, System.Windows.Forms.UserControl uC)
        {
            uC.Visible = true;
            
            foreach (var item in uCArrray)
            {
                if(item != uC) 
                    item.Visible = false;
            }
        }

        public static void AddItemsUC(FlowLayoutPanel flowLayoutPanel, System.Windows.Forms.UserControl[] uC)
        {
            foreach (var item in uC)
            {
                flowLayoutPanel.Controls.Add(item);
            }
        }

       

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
        public static bool ISNull(Guna2TextBox txt)
        {
            if(string.IsNullOrEmpty(txt.Text))
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
            if(string.IsNullOrEmpty(time.Text))
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
        public static string SaveImage(PictureBox pictureBox, string txt)
        {
            string fname = null;
            // Đường dẫn đầy đủ đến thư mục mới
            string folderPath = @"E:\FolderImgProduct";
            try
            {
                // Kiểm tra xem thư mục đã tồn tại hay chưa
                if (!Directory.Exists(folderPath))
                {
                    // Nếu chưa tồn tại, tạo thư mục mới
                    Directory.CreateDirectory(folderPath);
                }
                else
                {
                    string folderPath1 = folderPath + @"\" + txt;
                    fname = txt + ".jpg";
                    string folderPathfname = folderPath + fname;
                    string pathstring = System.IO.Path.Combine(folderPath1, fname); pictureBox.Image.Save(pathstring);
                    return fname;
                }
                return fname;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        public static bool ExistImg(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return false;
            return true;
        }

        public static void SetIDAccount(int maTK)
        {
            using (FileStream fs = new FileStream("data", FileMode.Create, FileAccess.ReadWrite))
            {

            }
            using (FileStream fs = new FileStream("data", FileMode.Truncate, FileAccess.ReadWrite))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(maTK);
                bw.Flush();
            }
        }
        public static int GetIDAccount()
        {
            int a = 0;
            using (FileStream fs = new FileStream("data", FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                a = br.ReadInt32();
            }
            return a;
        }

        public static void ScrollBarFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, Guna2VScrollBar vScrollBar)
        {
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(flowLayoutPanel, vScrollBar);
        }
    }
}
