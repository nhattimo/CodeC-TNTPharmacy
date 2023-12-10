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

namespace GUI.US_
{
    public partial class UC_QL_NguonCung : UserControl
    {
        public readonly SuppliersBusinessLogic _SupplierBusinesLogiccs = new SuppliersBusinessLogic();

        List<Suppliers> _listObjSuppliers;

        int ID;

        Label[] _laberError;
        Suppliers _ObjSuppliers;
        bool _trangThai;

        public UC_QL_NguonCung()
        {
            InitializeComponent();

            _listObjSuppliers = _SupplierBusinesLogiccs.GetAllObject();

            _laberError = new Label[] { errorSupplierName, errorAddress };
            Management.ErrorHide(_laberError);
            _trangThai = true;

            ShowDataGridViewSupplier();
        }

        private void UC_QL_NguonCung_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Management.Check(txtSupplierName, errorSupplierName);
            Management.Check(txtAddress, errorAddress);

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

            if (_trangThai)
            {
                foreach (var item in _listObjSuppliers)
                {
                    if (item.Name == txtSupplierName.Text)
                    {
                        if ((item.Name == txtSupplierName.Text && item.Address != txtAddress.Text) || (item.Name != txtSupplierName.Text && item.Address == txtAddress.Text))
                            _trangThai = true;
                        else
                        {
                            _trangThai = false;
                            MessageBox.Show("Dữ liệu trùng lặp");
                        }
                        break;
                    }
                }
            }

            if (_trangThai)
            {
                _ObjSuppliers  = new Suppliers();
                _ObjSuppliers.Name = txtSupplierName.Text;
                _ObjSuppliers.Address = txtAddress.Text;
                _SupplierBusinesLogiccs.Add(_ObjSuppliers);
                ShowDataGridViewSupplier();
                MessageBox.Show("Add thành công");

            }else
                MessageBox.Show("Add thất bại");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Management.Check(txtSupplierName, errorSupplierName);
            Management.Check(txtAddress, errorAddress);

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

            if (_trangThai)
            {
                _ObjSuppliers = _SupplierBusinesLogiccs.GetObjectById(ID);
                try
                {
                    _ObjSuppliers.Name = txtSupplierName.Text;
                    _ObjSuppliers.Address = txtAddress.Text;
                    _SupplierBusinesLogiccs.Update(ID, _ObjSuppliers);
                    ShowDataGridViewSupplier();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhà cung cấp không còn tồn tại");
                }
                

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _SupplierBusinesLogiccs.Delete(ID);
                ShowDataGridViewSupplier();
                MessageBox.Show("Xóa thành công");

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindProductsByKey(txtSupplierName.Text);
        }

        private void DataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewSupplier.CurrentRow.Selected = true;
                DataGridViewSupplier.ReadOnly = true;
                if (DataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    txtSupplierName.Text = DataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtAddress.Text = DataGridViewSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                    foreach (var item in _listObjSuppliers)
                    {
                        if(txtSupplierName.Text == item.Name && txtAddress.Text == item.Address)
                        {
                            ID = item.ID;
                            break;
                        }

                    }
                }
            }
            catch (Exception)
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        void ShowDataGridViewSupplier()
        {
            _listObjSuppliers = _SupplierBusinesLogiccs.GetAllObject();
            DataGridViewSupplier.Rows.Clear();
            DataGridViewSupplier.ColumnCount = 2;
            DataGridViewSupplier.Columns[0].Name = "Tên";
            DataGridViewSupplier.Columns[1].Name = "Địa chỉ";
            
            foreach (var item in _listObjSuppliers)
            {
                string[] row = { item.Name, item.Address};
                DataGridViewSupplier.Rows.Add(row);
            }
        }

        private List<Suppliers> FindProductsByKey(string key)
        {
            List<Suppliers> foundSuppliers = new List<Suppliers>();

           
                foreach (var item in _listObjSuppliers)
                {
                    // Kiểm tra xem tên sản phẩm có chứa từ khóa hay không (không phân biệt chữ hoa/chữ thường)
                    if (item.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                    foundSuppliers.Add(item);
                    }
                }
            
            return foundSuppliers;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text) != true)
            {
                List<Suppliers> _iteamListObjProducts = FindProductsByKey(txtSearch.Text);
                DataGridViewSupplier.Rows.Clear();
                DataGridViewSupplier.ColumnCount = 2;
                DataGridViewSupplier.Columns[0].Name = "Tên";
                DataGridViewSupplier.Columns[1].Name = "Địa chỉ";

                foreach (var item in _iteamListObjProducts)
                {
                    string[] row = { item.Name, item.Address };
                    DataGridViewSupplier.Rows.Add(row);
                }
            }
            else
            {
                ShowDataGridViewSupplier();
            }
        }
    }
}
