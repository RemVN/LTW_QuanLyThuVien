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
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        public Book getBookFromInputForm()
        {
            Book book = new Book();
            book.Id = textMaSo.Text;
            book.TenSach = textTenSach.Text;
            book.TacGia = textTacGia.Text;
            book.Nxb = textNXB.Text;
            book.NamXuatBan = (int)numNamXB.Value;
            book.TinhTrang = (string)comboTinhTrang.SelectedItem.ToString();
            book.GiaSach = (double)numGiaSach.Value;
            return book;
        }

        public bool isFill()
        {
            if(textMaSo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách");
                return false;
            }
            if(textTenSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sách");
                return false;
            }
            if(comboTinhTrang.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn tình trạng sách");
                return false;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!isFill()) return;
            BookManager bookManager = Program.MainClass.BookManager;
            Book book = getBookFromInputForm();
            if(bookManager.isBookExist(book.Id))
            {
                MessageBox.Show("Mã sách này đã tồn tại");
                return;
            }
            bookManager.addBook(book);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
