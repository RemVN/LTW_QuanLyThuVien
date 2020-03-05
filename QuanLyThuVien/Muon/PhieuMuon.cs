using QuanLyThuVien.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyThuVien.IDObject;
namespace QuanLyThuVien.Muon
{
    public class PhieuMuon : ID
    {
        string maSinhVien;
        string maSach;
        string ngayMuon;
        string ngayTra;

        public PhieuMuon()
        {
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }

        public string TenSinhVien
        {
            get
            {
                if (!Program.Init) return "";
                SinhVien sinhVien = Program.MainClass.SinhVienManager.ListSinhVien.getByID(MaSinhVien);
                if (sinhVien == null) return "";
                return sinhVien.TenSinhVien;
            }
        }

        public string TenSach
        {
            get
            {
                if (!Program.Init) return "";
                Book book = Program.MainClass.BookManager.ListBook.getByID(maSach);
                if (book == null) return "";
                return book.TenSach;
            }
        }
    }
}
