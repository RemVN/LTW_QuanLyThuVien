using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormAddSinhVien : Form
    {
        public FormAddSinhVien()
        {
            InitializeComponent();
        }

        private void FormAddSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public SinhVien getSinhVienFromInputForm()
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Id = textMaSo.Text;
            sinhVien.TenSinhVien = textTenSinhVien.Text;
            sinhVien.GioiTinh = comboGioiTinh.SelectedItem.ToString();
            sinhVien.Lop = textBoxLop.Text;
            sinhVien.Khoa = textBoxKhoa.Text;
            sinhVien.DiaChi = textBoxDiaChi.Text;
            sinhVien.Email = textBoxEmail.Text;
            sinhVien.Sdt = textBoxSoDienThoai.Text;
            sinhVien.NgaySinh = dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy");
            return sinhVien;
        }

        public bool isFill()
        {
            if(textMaSo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên");
                return false;
            }
            if(comboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn giới tính sinh viên");
                return false;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!isFill()) return;
            SinhVienManager sinhVienManager = Program.MainClass.SinhVienManager;
            SinhVien sinhVien = getSinhVienFromInputForm();
            if(sinhVienManager.isSinhVienExist(sinhVien.Id))
            {
                MessageBox.Show("Mã số sinh viên này đã tồn tại");
                return;
            }
            sinhVienManager.addSinhVien(sinhVien);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
