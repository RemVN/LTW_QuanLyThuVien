using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Muon;
using QuanLyThuVien.Sach;

namespace QuanLyThuVien.Forms
{
    public partial class FormAddPhieuMuon : Form
    {
        public FormAddPhieuMuon()
        {
            InitializeComponent();
        }

        public PhieuMuon getPhieuMuonFromInputForm()
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.Id = textMaPhieu.Text;
            phieuMuon.MaSinhVien = textMaSinhVien.Text;
            phieuMuon.MaSach = textMaSach.Text;
            phieuMuon.NgayMuon = DateTime.Now.ToString(Program.DateFormat);
            phieuMuon.NgayTra = DateTime.Now.AddDays((double)numSoNgayMuon.Value).ToString(Program.DateFormat);
            return phieuMuon;
        }

        public bool isFillInput()
        {
            if(textMaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu");
                return false;
            }
            if(textMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên");
                return false;
            }
            if(textMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách");
                return false;
            }
            return true;
        }

        public bool isValid(PhieuMuon phieuMuon)
        {
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            BookManager bookManager = Program.MainClass.BookManager;
            SinhVienManager sinhVienManager = Program.MainClass.SinhVienManager;

            if (phieuMuonManager.isPhieuMuonExist(phieuMuon.Id))
            {
                MessageBox.Show("Mã phiếu này đã tồn tại");
                return false;
            }
            if(!sinhVienManager.isSinhVienExist(phieuMuon.MaSinhVien))
            {
                MessageBox.Show("Sinh viên không tồn tại");
                return false;
            }
            if(!bookManager.isBookExist(phieuMuon.MaSach))
            {
                MessageBox.Show("Sách không tồn tại");
                return false;
            }
            Book book = bookManager.getBookByID(phieuMuon.MaSach);
            if(!book.isAvaiable())
            {
                MessageBox.Show("Sách này đã được mượn");
                return false;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!isFillInput()) return;
            PhieuMuon phieuMuon = getPhieuMuonFromInputForm();
            if (!isValid(phieuMuon)) return;
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            phieuMuonManager.addPhieuMuon(phieuMuon);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
