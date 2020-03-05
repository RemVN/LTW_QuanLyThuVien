using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class FormEditSinhVien : Form
    {

        public SinhVien sinhVien;

        public FormEditSinhVien(SinhVien sinhVien)
        {
            this.sinhVien = sinhVien;
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            textMaSo.Text = sinhVien.Id;
            textTenSinhVien.Text = sinhVien.TenSinhVien;
            dateTimePickerNgaySinh.Value = sinhVien.getNgaySinhDateTime();
            comboGioiTinh.SelectedItem = sinhVien.GioiTinh;
            textBoxLop.Text = sinhVien.Lop;
            textBoxKhoa.Text = sinhVien.Khoa;
            textBoxDiaChi.Text = sinhVien.DiaChi;
            textBoxEmail.Text = sinhVien.Email;
            textBoxSoDienThoai.Text = sinhVien.Sdt;
        }

        public void editSinhVien()
        {
            sinhVien.TenSinhVien = textTenSinhVien.Text;
            sinhVien.NgaySinh = dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy");
            sinhVien.GioiTinh = comboGioiTinh.SelectedItem.ToString();
            sinhVien.Lop = textBoxLop.Text;
            sinhVien.Khoa = textBoxKhoa.Text;
            sinhVien.DiaChi = textBoxDiaChi.Text;
            sinhVien.Email = textBoxEmail.Text;
            sinhVien.Sdt = textBoxSoDienThoai.Text;
        }

        public bool isFill()
        {
            if (comboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn giới tính sinh viên");
                return false;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(isFill())
            {
                editSinhVien();
                Program.MainClass.SinhVienManager.refreshDataGridView();
                this.Close();
            }
        }
    }
}
