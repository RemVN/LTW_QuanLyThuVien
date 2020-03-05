using QuanLyThuVien.IDObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Muon
{
    class PhieuMuonManager : Manager
    {

        const string phieuMuonFileName = "phieu-muon.xml";
        IDList<PhieuMuon> listPhieuMuon;

        public IDList<PhieuMuon> ListPhieuMuon { get => listPhieuMuon; set => listPhieuMuon = value; }

        public PhieuMuonManager()
        {
            ListPhieuMuon = new IDList<PhieuMuon>();
        }

        public PhieuMuon getByBookID(string bookId)
        {
            foreach(PhieuMuon phieuMuon in listPhieuMuon)
            {
                if (phieuMuon.MaSach.Equals(bookId)) return phieuMuon;
            }
            return null;
        }

        public void removePhieuMuon(PhieuMuon phieuMuon)
        {
            listPhieuMuon.removeById(phieuMuon.Id);
            refreshDataGridView();
        }

        public void addPhieuMuon(PhieuMuon phieuMuon)
        {
            listPhieuMuon.Add(phieuMuon);
            refreshDataGridView();
        }

        public Filter<PhieuMuon> getFilter()
        {
            MainForm mainForm = Program.MainForm;
            Filter<PhieuMuon> filter = new Filter<PhieuMuon>();
            if (mainForm.CheckMaPhieu.Checked)
                filter.withField("Id", mainForm.FilterMaPhieu.Text);
            if (mainForm.CheckMaSachPhieuMuon.Checked)
                filter.withField("MaSach", mainForm.FilterMaSachPhieuMuon.Text);
            if (mainForm.CheckMaSinhVienPhieuMuon.Checked)
                filter.withField("MaSinhVien", mainForm.FilterMaSVPhieuMuon.Text);
            if (mainForm.CheckTenSachPhieuMuon.Checked)
                filter.withField("TenSach", mainForm.FilterTenSachPhieuMuon.Text);
            if (mainForm.CheckTenSVPhieuMuon.Checked)
                filter.withField("TenSinhVien", mainForm.FilterTenSVPhieuMuon.Text);
            return filter;
        }

        public void filterListPhieuMuon()
        {
            Filter<PhieuMuon> filter = getFilter();
            IDList<PhieuMuon> newList = new IDList<PhieuMuon>(filter.getFilteredList(ListPhieuMuon));
            Program.MainForm.PhieuMuonBindingSource.DataSource = newList;
            refreshDataGridView();
        }

        public void clearFilter()
        {
            Program.MainForm.PhieuMuonBindingSource.DataSource = ListPhieuMuon;
            refreshDataGridView();
        }

        public override void initForm()
        {
            MainForm mainForm = Program.MainForm;
            Program.MainForm.PhieuMuonBindingSource.DataSource = ListPhieuMuon;
            refreshDataGridView();
        }

        public override void load()
        {
            if (!isFileExist(phieuMuonFileName)) return;
            ListPhieuMuon.Clear();
            ListPhieuMuon.AddRange((IDList<PhieuMuon>)loadObject(phieuMuonFileName, typeof(IDList<PhieuMuon>)));
        }

        public override void refreshDataGridView()
        {
            Program.MainForm.PhieuMuonBindingSource.ResetBindings(false);
        }

        public override void save()
        {
            saveObject(ListPhieuMuon, phieuMuonFileName, typeof(IDList<PhieuMuon>));
        }

        public bool isPhieuMuonExist(string id)
        {
            return ListPhieuMuon.getByID(id) != null;
        }

    }
}
