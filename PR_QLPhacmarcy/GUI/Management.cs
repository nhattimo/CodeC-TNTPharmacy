using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


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

        public static void SetImage(PictureBox pictureBox , object sender)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(ofd.FileName);
            }
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
        public static void GetImage(PictureBox pictureBox)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
        }

       
    }
}
