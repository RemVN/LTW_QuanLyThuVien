using QuanLyThuVien.Sach;
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
    public partial class FormEditBook : Form
    {

        public string id;
        public Book book;

        public FormEditBook(string id)
        {
            this.id = id;
            book = Program.MainClass.BookManager.getBookByID(id);
            InitializeComponent();
            loadForm();
        }

        public bool isFill()
        {
            if (textTenSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sách");
                return false;
            }
            if (comboTinhTrang.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn tình trạng sách");
                return false;
            }
            return true;
        }

        public void editBook()
        {
            book.TenSach = textTenSach.Text;
            book.TacGia = textTacGia.Text;
            book.Nxb = textNXB.Text;
            book.NamXuatBan = (int) numNamXB.Value;
            book.TinhTrang = comboTinhTrang.SelectedItem.ToString();
            book.GiaSach = (double) numGiaSach.Value;
        }

        public void loadForm()
        {
            textMaSo.Text = book.Id;
            textTenSach.Text = book.TenSach;
            textTacGia.Text = book.TacGia;
            textNXB.Text = book.Nxb;
            numNamXB.Value = book.NamXuatBan;
            comboTinhTrang.SelectedItem = book.TinhTrang;
            numGiaSach.Value = (int) book.GiaSach;
        }

        private void TextMaSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(isFill())
            {
                editBook();
                Program.MainClass.BookManager.refreshDataGridView();
                this.Close();
            }
        }
    }
}
