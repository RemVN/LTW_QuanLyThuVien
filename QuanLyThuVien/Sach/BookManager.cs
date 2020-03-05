using QuanLyThuVien.IDObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Sach
{
    class BookManager : Manager
    {
        const string bookFileName = "book.xml";
        IDList<Book> listBook;

        public IDList<Book> ListBook { get => listBook; set => listBook = value; }

        public BookManager()
        {
            ListBook = new IDList<Book>();
        }

        public void addBook(Book book)
        {
            ListBook.Add(book);
            refreshDataGridView();
        }

        public void removeBook(Book book)
        {
            ListBook.removeById(book.Id);
            refreshDataGridView();
        }

        public Filter<Book> getFilter()
        {
            MainForm mainForm = Program.MainForm;
            Filter<Book> filter = new Filter<Book>();
            if (mainForm.CheckMaSach.Checked)
                filter.withField("Id", mainForm.FilterMaSach.Text);
            if (mainForm.CheckTenSach.Checked)
                filter.withField("TenSach", mainForm.FilterTenSach.Text);
            if (mainForm.CheckTacGia.Checked)
                filter.withField("TacGia", mainForm.FilterTacGia.Text);
            if (mainForm.CheckNXB.Checked)
                filter.withField("Nxb", mainForm.FilterNXB.Text);
            if (mainForm.CheckNamXB.Checked)
                filter.withField("NamXuatBan", mainForm.FilterNamXB.Value);
            if (mainForm.CheckTinhTrangSach.Checked)
                filter.withField("TinhTrang", mainForm.FilterTinhTrangSach.Text);
            if (mainForm.CheckGiaSach.Checked)
                filter.withField("Nxb", mainForm.FilterGiaSach.Text);
            if (mainForm.CheckKhaDung.Checked && mainForm.ComboKhaDung.SelectedItem != null)
                filter.withField("Available", mainForm.ComboKhaDung.SelectedItem.ToString());
            return filter;
        }

        public void filterListBook()
        {
            Filter<Book> filter = getFilter();
            IDList<Book> newList = new IDList<Book>(filter.getFilteredList(ListBook));
            Program.MainForm.BookBindingSource.DataSource = newList;
            refreshDataGridView();
        }

        public void clearFilter()
        {
            Program.MainForm.BookBindingSource.DataSource = ListBook;
            refreshDataGridView();
        }

        public override void initForm()
        {
            MainForm mainForm = Program.MainForm;
            Program.MainForm.BookBindingSource.DataSource = ListBook;
            refreshDataGridView();
        }

        public override void load()
        {
            if (!isFileExist(bookFileName)) return;
            ListBook.Clear();
            ListBook.AddRange((IDList<Book>)loadObject(bookFileName, typeof(IDList<Book>)));
        }

        public override void refreshDataGridView()
        {
            Program.MainForm.BookBindingSource.ResetBindings(false);
        }

        public override void save()
        {
            saveObject(ListBook, bookFileName, typeof(IDList<Book>));
        }

        public bool isBookExist(string id)
        {
            return ListBook.getByID(id) != null;
        }

        public Book getBookByID(string id)
        {
            return listBook.getByID(id);
        }
    }
}
