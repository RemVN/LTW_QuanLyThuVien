using QuanLyThuVien.Muon;
using QuanLyThuVien.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    class Main
    {

        SinhVienManager sinhVienManager;
        BookManager bookManager;
        PhieuMuonManager phieuMuonManager;
        List<Manager> managers;

        internal SinhVienManager SinhVienManager { get => sinhVienManager; set => sinhVienManager = value; }
        internal BookManager BookManager { get => bookManager; set => bookManager = value; }
        internal PhieuMuonManager PhieuMuonManager { get => phieuMuonManager; set => phieuMuonManager = value; }

        public Main()
        {
            managers = new List<Manager>();
            Console.WriteLine("Init main");
            initMain();
        }

        public void initForm()
        {
            Program.MainForm.BeginInvoke(new MethodInvoker(() =>
            {
                foreach (Manager manager in managers)
                {
                    manager.initForm();
                }
                refreshGridView();
            }));
        }

        public void refreshGridView()
        {
            foreach(Manager manager in managers)
            {
                manager.refreshDataGridView();
            }
        }

        public void loadData()
        {
            foreach(Manager manager in managers)
            {
                manager.load();
            }
        }

        public void saveData()
        {
            foreach(Manager manager in managers)
            {
                manager.save();
            }
        }

        public void initMain()
        {
            sinhVienManager = new SinhVienManager();
            bookManager = new BookManager();
            phieuMuonManager = new PhieuMuonManager();
            managers.Add(sinhVienManager);
            managers.Add(bookManager);
            managers.Add(phieuMuonManager);
            Program.Init = true;
        }

    }
}
