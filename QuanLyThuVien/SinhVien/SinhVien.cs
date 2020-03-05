using QuanLyThuVien.IDObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien
{
    public class SinhVien : ID
    {
        string tenSinhVien;
        string ngaySinh;
        string gioiTinh;
        string lop;
        string khoa;
        string diaChi;
        string email;
        string sdt;

        public SinhVien()
        {
        }

        public DateTime getNgaySinhDateTime()
        {
            return DateTime.Parse(NgaySinh);
        }

        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
