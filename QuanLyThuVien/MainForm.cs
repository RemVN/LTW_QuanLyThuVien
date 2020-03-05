using QuanLyThuVien.Forms;
using QuanLyThuVien.IDObject;
using QuanLyThuVien.Muon;
using QuanLyThuVien.Sach;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SinhVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TabPageSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFilterSinhVien_Click(object sender, EventArgs e)
        {
            SinhVienManager sinhVienManager = Program.MainClass.SinhVienManager;
            sinhVienManager.filterListSinhVien();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = Program.MainClass;
            main.saveData();
            Program.close();
        }

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            SinhVienManager sinhVienManager = Program.MainClass.SinhVienManager;
            sinhVienManager.clearFilter();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new FormAddSinhVien().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Main main = Program.MainClass;
            main.initForm();
            main.loadData();
        }

        private void ButtonFilterSach_Click(object sender, EventArgs e)
        {
            BookManager bookManager = Program.MainClass.BookManager;
            bookManager.filterListBook();
        }

        private void ButtonClearFilterSach_Click(object sender, EventArgs e)
        {
            BookManager bookManager = Program.MainClass.BookManager;
            bookManager.clearFilter();
        }

        private void ButtonAddSach_Click(object sender, EventArgs e)
        {
            new FormAddBook().ShowDialog();
        }

        private void DataGridViewSinhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DataGridViewSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FormEditSinhVien formEditSinhVien = new FormEditSinhVien(getSinhVienFromGridview(e.RowIndex));
                formEditSinhVien.ShowDialog();
            }
        }

        private void ButtonClearFilterPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            phieuMuonManager.clearFilter();
        }

        private void ButtonFilterPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            phieuMuonManager.filterListPhieuMuon();
        }

        private void ButtonAddPhieuMuon_Click(object sender, EventArgs e)
        {
            new FormAddPhieuMuon().ShowDialog();
        }

        private void ButtonDeleteSinhVien_Click(object sender, EventArgs e)
        {
            if(textMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên");
                return;
            }
            SinhVienManager sinhVienManager = Program.MainClass.SinhVienManager;
            string id = textMaSV.Text;
            SinhVien sinhVien = sinhVienManager.ListSinhVien.getByID(id);
            if(sinhVien == null)
            {
                MessageBox.Show("Sinh viên không tồn tại");
                return;
            }
            sinhVienManager.removeSinhVien(sinhVien);
            MessageBox.Show("Đã xoá sinh viên");
        }

        private void ButtonXoaSach_Click(object sender, EventArgs e)
        {
            if (textMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách");
                return;
            }
            BookManager bookManager = Program.MainClass.BookManager;
            string id = textMaSach.Text;
            Book book = bookManager.ListBook.getByID(id);
            if (book == null)
            {
                MessageBox.Show("Sách không tồn tại");
                return;
            }
            bookManager.removeBook(book);
            MessageBox.Show("Đã xoá sách");
        }

        private void ButtonDeletePhieuMuon_Click(object sender, EventArgs e)
        {
            if (textMaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu");
                return;
            }
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            string id = textMaPhieu.Text;
            PhieuMuon phieuMuon = phieuMuonManager.ListPhieuMuon.getByID(id);
            if (phieuMuon == null)
            {
                MessageBox.Show("Phiếu mượn không tồn tại");
                return;
            }
            phieuMuonManager.removePhieuMuon(phieuMuon);
            MessageBox.Show("Đã xoá phiếu mượn");
        }

        public Book getBookFromGridview(int index)
        {
            IDList<Book> list = (IDList <Book>) Program.MainForm.BookBindingSource.DataSource;
            return list[index];
        }

        public PhieuMuon getPhieuMuonFromGridview(int index)
        {
            IDList<PhieuMuon> list = (IDList<PhieuMuon>)Program.MainForm.PhieuMuonBindingSource.DataSource;
            return list[index];
        }

        public SinhVien getSinhVienFromGridview(int index)
        {
            IDList<SinhVien> list = (IDList<SinhVien>)Program.MainForm.SinhVienBindingSource.DataSource;
            return list[index];
        }

        private void DataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FormEditBook formEditBook = new FormEditBook(getBookFromGridview(e.RowIndex).Id);
                formEditBook.ShowDialog();
            }
        }

        private void MãNguồnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
