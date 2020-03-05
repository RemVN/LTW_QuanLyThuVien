using QuanLyThuVien.IDObject;
using QuanLyThuVien.Muon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Sach
{
    public class Book : ID
    {
        string tenSach;
        string tacGia;
        string nxb;
        int namXuatBan;
        string tinhTrang;
        double giaSach;

        public Book()
        {
        }

        public bool isAvaiable()
        {
            if (!Program.Init) return false;
            PhieuMuonManager phieuMuonManager = Program.MainClass.PhieuMuonManager;
            if(phieuMuonManager.getByBookID(Id) != null)
            {
                return false;
            }
            return true;
        }

        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string Nxb { get => nxb; set => nxb = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public double GiaSach { get => giaSach; set => giaSach = value; }

        public string Available
        {
            get
            {
                if (isAvaiable()) return "có";
                else return "không";
            }
        }
    }
}
