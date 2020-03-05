using QuanLyThuVien.IDObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{ 
    class SinhVienManager : Manager
    {
        const string sinhVienFileName = "sinhvien.xml";

        IDList<SinhVien> listSinhVien;

        public SinhVienManager()
        {
            listSinhVien = new IDList<SinhVien>();
        }

        public void addSinhVien(SinhVien sinhVien)
        {
            listSinhVien.Add(sinhVien);
            refreshDataGridView();
        }

        public void removeSinhVien(SinhVien sinhVien)
        {
            listSinhVien.removeById(sinhVien.Id);
            refreshDataGridView();
        }

        public void clearFilter()
        {
            Program.MainForm.SinhVienBindingSource.DataSource = listSinhVien;
            refreshDataGridView();
        }

        public void filterListSinhVien()
        {
            Filter<SinhVien> filter = getFilter();
            IDList<SinhVien> newList = new IDList<SinhVien>(filter.getFilteredList(listSinhVien));
            Program.MainForm.SinhVienBindingSource.DataSource = newList;
            refreshDataGridView();
        }

        public Filter<SinhVien> getFilter()
        {
            MainForm mainForm = Program.MainForm;
            Filter<SinhVien> filter = new Filter<SinhVien>();
            if(mainForm.CheckBoxMaSoSinhVien.Checked)
                filter.withField("Id", mainForm.FilterMaSoSinhVien.Text);
            if (mainForm.CheckBoxHoTenSinhVien.Checked)
                filter.withField("TenSinhVien", mainForm.FilterTenSinhVien.Text);
            if (mainForm.CheckBoxGioiTinhSinhVien.Checked && mainForm.FilterGioiTinhSinhVien.SelectedItem != null)
                filter.withField("GioiTinh", mainForm.FilterGioiTinhSinhVien.SelectedItem.ToString());
            if (mainForm.CheckBoxNgaySinhSinhVien.Checked)
                filter.withField("NgaySinh", mainForm.DateTimePickerSinhVien.Value.ToString("dd/MM/yyyy"));
            if (mainForm.CheckBoxLopSinhVien.Checked)
                filter.withField("Lop", mainForm.FilterLopSinhVien.Text);
            if (mainForm.CheckBoxKhoaSinhVien.Checked)
                filter.withField("Khoa", mainForm.FilterKhoaSinhVien.Text);
            if (mainForm.CheckBoxDiaChiSinhVien.Checked)
                filter.withField("DiaChi", mainForm.FilterDiaChiSinhVien.Text);
            if (mainForm.CheckBoxEmailSinhVien.Checked)
                filter.withField("Email", mainForm.FilterEmailSinhVien.Text);
            if (mainForm.CheckBoxSdtSinhVien.Checked)
                filter.withField("Sdt", mainForm.FilterSDTSinhVien.Text);
            return filter;
        }

        public override void refreshDataGridView()
        {
            Program.MainForm.SinhVienBindingSource.ResetBindings(false);
        }

        public override void initForm()
        {
            MainForm mainForm = Program.MainForm;
            Program.MainForm.SinhVienBindingSource.DataSource = ListSinhVien;
            refreshDataGridView();
        }

        public void reloadList()
        {
            Program.MainForm.SinhVienBindingSource.ResetBindings(false);
        }

        public override void load()
        {
            if (!isFileExist(sinhVienFileName)) return;
            listSinhVien.Clear();
            listSinhVien.AddRange((IDList<SinhVien>)loadObject(sinhVienFileName, typeof(IDList<SinhVien>)));
        }

        public override void save()
        {
            saveObject(listSinhVien, sinhVienFileName, typeof(IDList<SinhVien>));
        }

        public bool isSinhVienExist(string id)
        {
            return listSinhVien.getByID(id) != null;
        }

        internal IDList<SinhVien> ListSinhVien { get => listSinhVien; set => listSinhVien = value; }
    }
}
