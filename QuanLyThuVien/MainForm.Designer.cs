using System.Windows.Forms;
using QuanLyThuVien.Sach;
using QuanLyThuVien.Muon;

namespace QuanLyThuVien
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLibrary = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageSinhVien = new System.Windows.Forms.TabPage();
            this.groupBoxSinhVienFilter = new System.Windows.Forms.GroupBox();
            this.filterGioiTinhSinhVien = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSinhVien = new System.Windows.Forms.DateTimePicker();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonFilterSinhVien = new System.Windows.Forms.Button();
            this.filterSDTSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxSdtSinhVien = new System.Windows.Forms.CheckBox();
            this.filterEmailSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxEmailSinhVien = new System.Windows.Forms.CheckBox();
            this.filterDiaChiSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxDiaChiSinhVien = new System.Windows.Forms.CheckBox();
            this.filterKhoaSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxKhoaSinhVien = new System.Windows.Forms.CheckBox();
            this.filterLopSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxLopSinhVien = new System.Windows.Forms.CheckBox();
            this.checkBoxGioiTinhSinhVien = new System.Windows.Forms.CheckBox();
            this.filterTenSinhVien = new System.Windows.Forms.TextBox();
            this.filterMaSoSinhVien = new System.Windows.Forms.TextBox();
            this.checkBoxNgaySinhSinhVien = new System.Windows.Forms.CheckBox();
            this.checkBoxHoTenSinhVien = new System.Windows.Forms.CheckBox();
            this.checkBoxMaSoSinhVien = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteSinhVien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboKhaDung = new System.Windows.Forms.ComboBox();
            this.filterTinhTrangSach = new System.Windows.Forms.ComboBox();
            this.filterGiaSach = new System.Windows.Forms.NumericUpDown();
            this.filterNamXB = new System.Windows.Forms.NumericUpDown();
            this.buttonClearFilterSach = new System.Windows.Forms.Button();
            this.buttonFilterSach = new System.Windows.Forms.Button();
            this.checkGiaSach = new System.Windows.Forms.CheckBox();
            this.checkKhaDung = new System.Windows.Forms.CheckBox();
            this.checkTinhTrangSach = new System.Windows.Forms.CheckBox();
            this.checkNamXB = new System.Windows.Forms.CheckBox();
            this.filterNXB = new System.Windows.Forms.TextBox();
            this.checkNXB = new System.Windows.Forms.CheckBox();
            this.filterTacGia = new System.Windows.Forms.TextBox();
            this.checkTacGia = new System.Windows.Forms.CheckBox();
            this.filterTenSach = new System.Windows.Forms.TextBox();
            this.filterMaSach = new System.Windows.Forms.TextBox();
            this.checkTenSach = new System.Windows.Forms.CheckBox();
            this.checkMaSach = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonXoaSach = new System.Windows.Forms.Button();
            this.buttonEditSach = new System.Windows.Forms.Button();
            this.buttonAddSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textMaSach = new System.Windows.Forms.TextBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPagePhieuMuon = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.filterTenSVPhieuMuon = new System.Windows.Forms.TextBox();
            this.buttonClearFilterPhieuMuon = new System.Windows.Forms.Button();
            this.buttonFilterPhieuMuon = new System.Windows.Forms.Button();
            this.checkTenSVPhieuMuon = new System.Windows.Forms.CheckBox();
            this.filterTenSachPhieuMuon = new System.Windows.Forms.TextBox();
            this.checkTenSachPhieuMuon = new System.Windows.Forms.CheckBox();
            this.filterMaSVPhieuMuon = new System.Windows.Forms.TextBox();
            this.checkMaSinhVienPhieuMuon = new System.Windows.Forms.CheckBox();
            this.filterMaSachPhieuMuon = new System.Windows.Forms.TextBox();
            this.filterMaPhieu = new System.Windows.Forms.TextBox();
            this.checkMaSachPhieuMuon = new System.Windows.Forms.CheckBox();
            this.checkMaPhieu = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeletePhieuMuon = new System.Windows.Forms.Button();
            this.buttonAddPhieuMuon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaPhieu = new System.Windows.Forms.TextBox();
            this.dataGridViewPhieuMuon = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mãNguồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThànhViênNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageLibrary.SuspendLayout();
            this.tabPageSinhVien.SuspendLayout();
            this.groupBoxSinhVienFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.tabPageBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGiaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterNamXB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.tabPagePhieuMuon.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuMuon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLibrary);
            this.tabControl.Controls.Add(this.tabPageSinhVien);
            this.tabControl.Controls.Add(this.tabPageBook);
            this.tabControl.Controls.Add(this.tabPagePhieuMuon);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1206, 629);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageLibrary
            // 
            this.tabPageLibrary.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageLibrary.Controls.Add(this.pictureBox1);
            this.tabPageLibrary.Controls.Add(this.label5);
            this.tabPageLibrary.Controls.Add(this.label4);
            this.tabPageLibrary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageLibrary.Location = new System.Drawing.Point(4, 27);
            this.tabPageLibrary.Name = "tabPageLibrary";
            this.tabPageLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLibrary.Size = new System.Drawing.Size(1198, 598);
            this.tabPageLibrary.TabIndex = 0;
            this.tabPageLibrary.Text = "Thư viện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(509, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đồ án cuối kỳ - LTW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(505, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản Lý Thư Viện";
            // 
            // tabPageSinhVien
            // 
            this.tabPageSinhVien.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSinhVien.Controls.Add(this.groupBoxSinhVienFilter);
            this.tabPageSinhVien.Controls.Add(this.groupBox1);
            this.tabPageSinhVien.Controls.Add(this.dataGridViewSinhVien);
            this.tabPageSinhVien.Location = new System.Drawing.Point(4, 27);
            this.tabPageSinhVien.Name = "tabPageSinhVien";
            this.tabPageSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinhVien.Size = new System.Drawing.Size(1198, 598);
            this.tabPageSinhVien.TabIndex = 1;
            this.tabPageSinhVien.Text = "Sinh viên";
            this.tabPageSinhVien.Click += new System.EventHandler(this.TabPageSinhVien_Click);
            // 
            // groupBoxSinhVienFilter
            // 
            this.groupBoxSinhVienFilter.Controls.Add(this.filterGioiTinhSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.dateTimePickerSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.buttonClearFilter);
            this.groupBoxSinhVienFilter.Controls.Add(this.buttonFilterSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterSDTSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxSdtSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterEmailSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxEmailSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterDiaChiSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxDiaChiSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterKhoaSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxKhoaSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterLopSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxLopSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxGioiTinhSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterTenSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.filterMaSoSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxNgaySinhSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxHoTenSinhVien);
            this.groupBoxSinhVienFilter.Controls.Add(this.checkBoxMaSoSinhVien);
            this.groupBoxSinhVienFilter.Location = new System.Drawing.Point(10, 198);
            this.groupBoxSinhVienFilter.Name = "groupBoxSinhVienFilter";
            this.groupBoxSinhVienFilter.Size = new System.Drawing.Size(290, 375);
            this.groupBoxSinhVienFilter.TabIndex = 2;
            this.groupBoxSinhVienFilter.TabStop = false;
            this.groupBoxSinhVienFilter.Text = "Lọc";
            // 
            // filterGioiTinhSinhVien
            // 
            this.filterGioiTinhSinhVien.FormattingEnabled = true;
            this.filterGioiTinhSinhVien.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.filterGioiTinhSinhVien.Location = new System.Drawing.Point(113, 129);
            this.filterGioiTinhSinhVien.Name = "filterGioiTinhSinhVien";
            this.filterGioiTinhSinhVien.Size = new System.Drawing.Size(158, 26);
            this.filterGioiTinhSinhVien.TabIndex = 21;
            this.filterGioiTinhSinhVien.Text = "-Chọn giới tính-";
            // 
            // dateTimePickerSinhVien
            // 
            this.dateTimePickerSinhVien.Location = new System.Drawing.Point(113, 100);
            this.dateTimePickerSinhVien.Name = "dateTimePickerSinhVien";
            this.dateTimePickerSinhVien.Size = new System.Drawing.Size(158, 25);
            this.dateTimePickerSinhVien.TabIndex = 20;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(10, 326);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(120, 39);
            this.buttonClearFilter.TabIndex = 19;
            this.buttonClearFilter.Text = "Xoá kết quả";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.ButtonClearFilter_Click);
            // 
            // buttonFilterSinhVien
            // 
            this.buttonFilterSinhVien.Location = new System.Drawing.Point(151, 326);
            this.buttonFilterSinhVien.Name = "buttonFilterSinhVien";
            this.buttonFilterSinhVien.Size = new System.Drawing.Size(120, 39);
            this.buttonFilterSinhVien.TabIndex = 18;
            this.buttonFilterSinhVien.Text = "Lọc";
            this.buttonFilterSinhVien.UseVisualStyleBackColor = true;
            this.buttonFilterSinhVien.Click += new System.EventHandler(this.ButtonFilterSinhVien_Click);
            // 
            // filterSDTSinhVien
            // 
            this.filterSDTSinhVien.Location = new System.Drawing.Point(113, 285);
            this.filterSDTSinhVien.Name = "filterSDTSinhVien";
            this.filterSDTSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterSDTSinhVien.TabIndex = 17;
            // 
            // checkBoxSdtSinhVien
            // 
            this.checkBoxSdtSinhVien.AutoSize = true;
            this.checkBoxSdtSinhVien.Location = new System.Drawing.Point(10, 286);
            this.checkBoxSdtSinhVien.Name = "checkBoxSdtSinhVien";
            this.checkBoxSdtSinhVien.Size = new System.Drawing.Size(59, 22);
            this.checkBoxSdtSinhVien.TabIndex = 16;
            this.checkBoxSdtSinhVien.Text = "Sdt:";
            this.checkBoxSdtSinhVien.UseVisualStyleBackColor = true;
            // 
            // filterEmailSinhVien
            // 
            this.filterEmailSinhVien.Location = new System.Drawing.Point(113, 254);
            this.filterEmailSinhVien.Name = "filterEmailSinhVien";
            this.filterEmailSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterEmailSinhVien.TabIndex = 15;
            // 
            // checkBoxEmailSinhVien
            // 
            this.checkBoxEmailSinhVien.AutoSize = true;
            this.checkBoxEmailSinhVien.Location = new System.Drawing.Point(10, 255);
            this.checkBoxEmailSinhVien.Name = "checkBoxEmailSinhVien";
            this.checkBoxEmailSinhVien.Size = new System.Drawing.Size(75, 22);
            this.checkBoxEmailSinhVien.TabIndex = 14;
            this.checkBoxEmailSinhVien.Text = "Email:";
            this.checkBoxEmailSinhVien.UseVisualStyleBackColor = true;
            // 
            // filterDiaChiSinhVien
            // 
            this.filterDiaChiSinhVien.Location = new System.Drawing.Point(113, 223);
            this.filterDiaChiSinhVien.Name = "filterDiaChiSinhVien";
            this.filterDiaChiSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterDiaChiSinhVien.TabIndex = 13;
            // 
            // checkBoxDiaChiSinhVien
            // 
            this.checkBoxDiaChiSinhVien.AutoSize = true;
            this.checkBoxDiaChiSinhVien.Location = new System.Drawing.Point(10, 224);
            this.checkBoxDiaChiSinhVien.Name = "checkBoxDiaChiSinhVien";
            this.checkBoxDiaChiSinhVien.Size = new System.Drawing.Size(91, 22);
            this.checkBoxDiaChiSinhVien.TabIndex = 12;
            this.checkBoxDiaChiSinhVien.Text = "Địa chỉ:";
            this.checkBoxDiaChiSinhVien.UseVisualStyleBackColor = true;
            // 
            // filterKhoaSinhVien
            // 
            this.filterKhoaSinhVien.Location = new System.Drawing.Point(113, 192);
            this.filterKhoaSinhVien.Name = "filterKhoaSinhVien";
            this.filterKhoaSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterKhoaSinhVien.TabIndex = 11;
            // 
            // checkBoxKhoaSinhVien
            // 
            this.checkBoxKhoaSinhVien.AutoSize = true;
            this.checkBoxKhoaSinhVien.Location = new System.Drawing.Point(10, 193);
            this.checkBoxKhoaSinhVien.Name = "checkBoxKhoaSinhVien";
            this.checkBoxKhoaSinhVien.Size = new System.Drawing.Size(67, 22);
            this.checkBoxKhoaSinhVien.TabIndex = 10;
            this.checkBoxKhoaSinhVien.Text = "Khoa:";
            this.checkBoxKhoaSinhVien.UseVisualStyleBackColor = true;
            // 
            // filterLopSinhVien
            // 
            this.filterLopSinhVien.Location = new System.Drawing.Point(113, 161);
            this.filterLopSinhVien.Name = "filterLopSinhVien";
            this.filterLopSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterLopSinhVien.TabIndex = 9;
            // 
            // checkBoxLopSinhVien
            // 
            this.checkBoxLopSinhVien.AutoSize = true;
            this.checkBoxLopSinhVien.Location = new System.Drawing.Point(10, 162);
            this.checkBoxLopSinhVien.Name = "checkBoxLopSinhVien";
            this.checkBoxLopSinhVien.Size = new System.Drawing.Size(59, 22);
            this.checkBoxLopSinhVien.TabIndex = 8;
            this.checkBoxLopSinhVien.Text = "Lớp:";
            this.checkBoxLopSinhVien.UseVisualStyleBackColor = true;
            // 
            // checkBoxGioiTinhSinhVien
            // 
            this.checkBoxGioiTinhSinhVien.AutoSize = true;
            this.checkBoxGioiTinhSinhVien.Location = new System.Drawing.Point(10, 131);
            this.checkBoxGioiTinhSinhVien.Name = "checkBoxGioiTinhSinhVien";
            this.checkBoxGioiTinhSinhVien.Size = new System.Drawing.Size(107, 22);
            this.checkBoxGioiTinhSinhVien.TabIndex = 6;
            this.checkBoxGioiTinhSinhVien.Text = "Giới tính:";
            this.checkBoxGioiTinhSinhVien.UseVisualStyleBackColor = true;
            // 
            // filterTenSinhVien
            // 
            this.filterTenSinhVien.Location = new System.Drawing.Point(113, 68);
            this.filterTenSinhVien.Name = "filterTenSinhVien";
            this.filterTenSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterTenSinhVien.TabIndex = 4;
            // 
            // filterMaSoSinhVien
            // 
            this.filterMaSoSinhVien.Location = new System.Drawing.Point(113, 37);
            this.filterMaSoSinhVien.Name = "filterMaSoSinhVien";
            this.filterMaSoSinhVien.Size = new System.Drawing.Size(158, 25);
            this.filterMaSoSinhVien.TabIndex = 3;
            // 
            // checkBoxNgaySinhSinhVien
            // 
            this.checkBoxNgaySinhSinhVien.AutoSize = true;
            this.checkBoxNgaySinhSinhVien.Location = new System.Drawing.Point(10, 100);
            this.checkBoxNgaySinhSinhVien.Name = "checkBoxNgaySinhSinhVien";
            this.checkBoxNgaySinhSinhVien.Size = new System.Drawing.Size(107, 22);
            this.checkBoxNgaySinhSinhVien.TabIndex = 2;
            this.checkBoxNgaySinhSinhVien.Tag = "NgaySinh";
            this.checkBoxNgaySinhSinhVien.Text = "Ngày sinh:";
            this.checkBoxNgaySinhSinhVien.UseVisualStyleBackColor = true;
            // 
            // checkBoxHoTenSinhVien
            // 
            this.checkBoxHoTenSinhVien.AutoSize = true;
            this.checkBoxHoTenSinhVien.Location = new System.Drawing.Point(10, 69);
            this.checkBoxHoTenSinhVien.Name = "checkBoxHoTenSinhVien";
            this.checkBoxHoTenSinhVien.Size = new System.Drawing.Size(59, 22);
            this.checkBoxHoTenSinhVien.TabIndex = 1;
            this.checkBoxHoTenSinhVien.Tag = "TenSinhVien";
            this.checkBoxHoTenSinhVien.Text = "Tên:";
            this.checkBoxHoTenSinhVien.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaSoSinhVien
            // 
            this.checkBoxMaSoSinhVien.AutoSize = true;
            this.checkBoxMaSoSinhVien.Location = new System.Drawing.Point(10, 38);
            this.checkBoxMaSoSinhVien.Name = "checkBoxMaSoSinhVien";
            this.checkBoxMaSoSinhVien.Size = new System.Drawing.Size(75, 22);
            this.checkBoxMaSoSinhVien.TabIndex = 0;
            this.checkBoxMaSoSinhVien.Tag = "Id";
            this.checkBoxMaSoSinhVien.Text = "Mã số:";
            this.checkBoxMaSoSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteSinhVien);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textMaSV);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // buttonDeleteSinhVien
            // 
            this.buttonDeleteSinhVien.Location = new System.Drawing.Point(10, 137);
            this.buttonDeleteSinhVien.Name = "buttonDeleteSinhVien";
            this.buttonDeleteSinhVien.Size = new System.Drawing.Size(261, 35);
            this.buttonDeleteSinhVien.TabIndex = 4;
            this.buttonDeleteSinhVien.Text = "Xoá Sinh Viên";
            this.buttonDeleteSinhVien.UseVisualStyleBackColor = true;
            this.buttonDeleteSinhVien.Click += new System.EventHandler(this.ButtonDeleteSinhVien_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(10, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa Sinh Viên";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Sinh Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(78, 24);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(193, 25);
            this.textMaSV.TabIndex = 0;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AllowUserToAddRows = false;
            this.dataGridViewSinhVien.AllowUserToDeleteRows = false;
            this.dataGridViewSinhVien.AutoGenerateColumns = false;
            this.dataGridViewSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenSinhVienDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridViewSinhVien.DataSource = this.sinhVienBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSinhVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(304, 10);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.ReadOnly = true;
            this.dataGridViewSinhVien.RowHeadersVisible = false;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(890, 584);
            this.dataGridViewSinhVien.TabIndex = 0;
            this.dataGridViewSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSinhVien_CellContentClick);
            this.dataGridViewSinhVien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewSinhVien_DataError);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Sửa";
            this.Edit.Width = 40;
            // 
            // tabPageBook
            // 
            this.tabPageBook.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageBook.Controls.Add(this.groupBox2);
            this.tabPageBook.Controls.Add(this.groupBox3);
            this.tabPageBook.Controls.Add(this.dataGridViewBook);
            this.tabPageBook.Location = new System.Drawing.Point(4, 27);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1198, 598);
            this.tabPageBook.TabIndex = 2;
            this.tabPageBook.Text = "Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboKhaDung);
            this.groupBox2.Controls.Add(this.filterTinhTrangSach);
            this.groupBox2.Controls.Add(this.filterGiaSach);
            this.groupBox2.Controls.Add(this.filterNamXB);
            this.groupBox2.Controls.Add(this.buttonClearFilterSach);
            this.groupBox2.Controls.Add(this.buttonFilterSach);
            this.groupBox2.Controls.Add(this.checkGiaSach);
            this.groupBox2.Controls.Add(this.checkKhaDung);
            this.groupBox2.Controls.Add(this.checkTinhTrangSach);
            this.groupBox2.Controls.Add(this.checkNamXB);
            this.groupBox2.Controls.Add(this.filterNXB);
            this.groupBox2.Controls.Add(this.checkNXB);
            this.groupBox2.Controls.Add(this.filterTacGia);
            this.groupBox2.Controls.Add(this.checkTacGia);
            this.groupBox2.Controls.Add(this.filterTenSach);
            this.groupBox2.Controls.Add(this.filterMaSach);
            this.groupBox2.Controls.Add(this.checkTenSach);
            this.groupBox2.Controls.Add(this.checkMaSach);
            this.groupBox2.Location = new System.Drawing.Point(10, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 334);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // comboKhaDung
            // 
            this.comboKhaDung.FormattingEnabled = true;
            this.comboKhaDung.Items.AddRange(new object[] {
            "có",
            "không"});
            this.comboKhaDung.Location = new System.Drawing.Point(113, 222);
            this.comboKhaDung.Name = "comboKhaDung";
            this.comboKhaDung.Size = new System.Drawing.Size(158, 26);
            this.comboKhaDung.TabIndex = 23;
            this.comboKhaDung.Text = "-Chọn khả dụng-";
            // 
            // filterTinhTrangSach
            // 
            this.filterTinhTrangSach.FormattingEnabled = true;
            this.filterTinhTrangSach.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.filterTinhTrangSach.Location = new System.Drawing.Point(113, 191);
            this.filterTinhTrangSach.Name = "filterTinhTrangSach";
            this.filterTinhTrangSach.Size = new System.Drawing.Size(158, 26);
            this.filterTinhTrangSach.TabIndex = 22;
            this.filterTinhTrangSach.Text = "-Chọn tình trạng-";
            // 
            // filterGiaSach
            // 
            this.filterGiaSach.Location = new System.Drawing.Point(113, 254);
            this.filterGiaSach.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.filterGiaSach.Name = "filterGiaSach";
            this.filterGiaSach.Size = new System.Drawing.Size(158, 25);
            this.filterGiaSach.TabIndex = 21;
            this.filterGiaSach.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // filterNamXB
            // 
            this.filterNamXB.Location = new System.Drawing.Point(113, 161);
            this.filterNamXB.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterNamXB.Name = "filterNamXB";
            this.filterNamXB.Size = new System.Drawing.Size(158, 25);
            this.filterNamXB.TabIndex = 20;
            this.filterNamXB.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // buttonClearFilterSach
            // 
            this.buttonClearFilterSach.Location = new System.Drawing.Point(10, 285);
            this.buttonClearFilterSach.Name = "buttonClearFilterSach";
            this.buttonClearFilterSach.Size = new System.Drawing.Size(120, 39);
            this.buttonClearFilterSach.TabIndex = 19;
            this.buttonClearFilterSach.Text = "Xoá kết quả";
            this.buttonClearFilterSach.UseVisualStyleBackColor = true;
            this.buttonClearFilterSach.Click += new System.EventHandler(this.ButtonClearFilterSach_Click);
            // 
            // buttonFilterSach
            // 
            this.buttonFilterSach.Location = new System.Drawing.Point(151, 285);
            this.buttonFilterSach.Name = "buttonFilterSach";
            this.buttonFilterSach.Size = new System.Drawing.Size(120, 39);
            this.buttonFilterSach.TabIndex = 18;
            this.buttonFilterSach.Text = "Lọc";
            this.buttonFilterSach.UseVisualStyleBackColor = true;
            this.buttonFilterSach.Click += new System.EventHandler(this.ButtonFilterSach_Click);
            // 
            // checkGiaSach
            // 
            this.checkGiaSach.AutoSize = true;
            this.checkGiaSach.Location = new System.Drawing.Point(10, 255);
            this.checkGiaSach.Name = "checkGiaSach";
            this.checkGiaSach.Size = new System.Drawing.Size(99, 22);
            this.checkGiaSach.TabIndex = 16;
            this.checkGiaSach.Text = "Giá sách:";
            this.checkGiaSach.UseVisualStyleBackColor = true;
            // 
            // checkKhaDung
            // 
            this.checkKhaDung.AutoSize = true;
            this.checkKhaDung.Location = new System.Drawing.Point(10, 224);
            this.checkKhaDung.Name = "checkKhaDung";
            this.checkKhaDung.Size = new System.Drawing.Size(99, 22);
            this.checkKhaDung.TabIndex = 14;
            this.checkKhaDung.Text = "Khả dụng:";
            this.checkKhaDung.UseVisualStyleBackColor = true;
            // 
            // checkTinhTrangSach
            // 
            this.checkTinhTrangSach.AutoSize = true;
            this.checkTinhTrangSach.Location = new System.Drawing.Point(10, 193);
            this.checkTinhTrangSach.Name = "checkTinhTrangSach";
            this.checkTinhTrangSach.Size = new System.Drawing.Size(115, 22);
            this.checkTinhTrangSach.TabIndex = 12;
            this.checkTinhTrangSach.Text = "Tình trạng:";
            this.checkTinhTrangSach.UseVisualStyleBackColor = true;
            // 
            // checkNamXB
            // 
            this.checkNamXB.AutoSize = true;
            this.checkNamXB.Location = new System.Drawing.Point(10, 162);
            this.checkNamXB.Name = "checkNamXB";
            this.checkNamXB.Size = new System.Drawing.Size(91, 22);
            this.checkNamXB.TabIndex = 10;
            this.checkNamXB.Text = "Năm XB: ";
            this.checkNamXB.UseVisualStyleBackColor = true;
            // 
            // filterNXB
            // 
            this.filterNXB.Location = new System.Drawing.Point(113, 130);
            this.filterNXB.Name = "filterNXB";
            this.filterNXB.Size = new System.Drawing.Size(158, 25);
            this.filterNXB.TabIndex = 9;
            // 
            // checkNXB
            // 
            this.checkNXB.AutoSize = true;
            this.checkNXB.Location = new System.Drawing.Point(10, 131);
            this.checkNXB.Name = "checkNXB";
            this.checkNXB.Size = new System.Drawing.Size(59, 22);
            this.checkNXB.TabIndex = 8;
            this.checkNXB.Text = "NXB:";
            this.checkNXB.UseVisualStyleBackColor = true;
            // 
            // filterTacGia
            // 
            this.filterTacGia.Location = new System.Drawing.Point(113, 99);
            this.filterTacGia.Name = "filterTacGia";
            this.filterTacGia.Size = new System.Drawing.Size(158, 25);
            this.filterTacGia.TabIndex = 7;
            // 
            // checkTacGia
            // 
            this.checkTacGia.AutoSize = true;
            this.checkTacGia.Location = new System.Drawing.Point(10, 100);
            this.checkTacGia.Name = "checkTacGia";
            this.checkTacGia.Size = new System.Drawing.Size(91, 22);
            this.checkTacGia.TabIndex = 6;
            this.checkTacGia.Text = "Tác giả:";
            this.checkTacGia.UseVisualStyleBackColor = true;
            // 
            // filterTenSach
            // 
            this.filterTenSach.Location = new System.Drawing.Point(113, 68);
            this.filterTenSach.Name = "filterTenSach";
            this.filterTenSach.Size = new System.Drawing.Size(158, 25);
            this.filterTenSach.TabIndex = 4;
            // 
            // filterMaSach
            // 
            this.filterMaSach.Location = new System.Drawing.Point(113, 37);
            this.filterMaSach.Name = "filterMaSach";
            this.filterMaSach.Size = new System.Drawing.Size(158, 25);
            this.filterMaSach.TabIndex = 3;
            // 
            // checkTenSach
            // 
            this.checkTenSach.AutoSize = true;
            this.checkTenSach.Location = new System.Drawing.Point(10, 69);
            this.checkTenSach.Name = "checkTenSach";
            this.checkTenSach.Size = new System.Drawing.Size(99, 22);
            this.checkTenSach.TabIndex = 1;
            this.checkTenSach.Tag = "TenSinhVien";
            this.checkTenSach.Text = "Tên sách:";
            this.checkTenSach.UseVisualStyleBackColor = true;
            // 
            // checkMaSach
            // 
            this.checkMaSach.AutoSize = true;
            this.checkMaSach.Location = new System.Drawing.Point(10, 38);
            this.checkMaSach.Name = "checkMaSach";
            this.checkMaSach.Size = new System.Drawing.Size(91, 22);
            this.checkMaSach.TabIndex = 0;
            this.checkMaSach.Tag = "Id";
            this.checkMaSach.Text = "Mã sách:";
            this.checkMaSach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonXoaSach);
            this.groupBox3.Controls.Add(this.buttonEditSach);
            this.groupBox3.Controls.Add(this.buttonAddSach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textMaSach);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // buttonXoaSach
            // 
            this.buttonXoaSach.Location = new System.Drawing.Point(10, 137);
            this.buttonXoaSach.Name = "buttonXoaSach";
            this.buttonXoaSach.Size = new System.Drawing.Size(261, 35);
            this.buttonXoaSach.TabIndex = 4;
            this.buttonXoaSach.Text = "Xoá sách";
            this.buttonXoaSach.UseVisualStyleBackColor = true;
            this.buttonXoaSach.Click += new System.EventHandler(this.ButtonXoaSach_Click);
            // 
            // buttonEditSach
            // 
            this.buttonEditSach.Enabled = false;
            this.buttonEditSach.Location = new System.Drawing.Point(10, 96);
            this.buttonEditSach.Name = "buttonEditSach";
            this.buttonEditSach.Size = new System.Drawing.Size(261, 35);
            this.buttonEditSach.TabIndex = 3;
            this.buttonEditSach.Text = "Sửa sách";
            this.buttonEditSach.UseVisualStyleBackColor = true;
            // 
            // buttonAddSach
            // 
            this.buttonAddSach.Location = new System.Drawing.Point(10, 55);
            this.buttonAddSach.Name = "buttonAddSach";
            this.buttonAddSach.Size = new System.Drawing.Size(261, 35);
            this.buttonAddSach.TabIndex = 2;
            this.buttonAddSach.Text = "Thêm sách";
            this.buttonAddSach.UseVisualStyleBackColor = true;
            this.buttonAddSach.Click += new System.EventHandler(this.ButtonAddSach_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMaSach
            // 
            this.textMaSach.Location = new System.Drawing.Point(88, 24);
            this.textMaSach.Name = "textMaSach";
            this.textMaSach.Size = new System.Drawing.Size(183, 25);
            this.textMaSach.TabIndex = 0;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AllowUserToAddRows = false;
            this.dataGridViewBook.AllowUserToDeleteRows = false;
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tenSachDataGridViewTextBoxColumn,
            this.tacGiaDataGridViewTextBoxColumn,
            this.nxbDataGridViewTextBoxColumn,
            this.namXuatBanDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.Available,
            this.giaSachDataGridViewTextBoxColumn,
            this.dataGridViewButtonColumn4});
            this.dataGridViewBook.DataSource = this.bookBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(304, 10);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.ReadOnly = true;
            this.dataGridViewBook.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBook.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBook.Size = new System.Drawing.Size(890, 584);
            this.dataGridViewBook.TabIndex = 3;
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBook_CellContentClick);
            // 
            // Available
            // 
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Khả dụng";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            this.Available.Width = 50;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.DataPropertyName = "Edit";
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.ReadOnly = true;
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn4.Width = 40;
            // 
            // tabPagePhieuMuon
            // 
            this.tabPagePhieuMuon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePhieuMuon.Controls.Add(this.groupBox4);
            this.tabPagePhieuMuon.Controls.Add(this.groupBox5);
            this.tabPagePhieuMuon.Controls.Add(this.dataGridViewPhieuMuon);
            this.tabPagePhieuMuon.Location = new System.Drawing.Point(4, 27);
            this.tabPagePhieuMuon.Name = "tabPagePhieuMuon";
            this.tabPagePhieuMuon.Size = new System.Drawing.Size(1198, 598);
            this.tabPagePhieuMuon.TabIndex = 3;
            this.tabPagePhieuMuon.Text = "Phiếu mượn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filterTenSVPhieuMuon);
            this.groupBox4.Controls.Add(this.buttonClearFilterPhieuMuon);
            this.groupBox4.Controls.Add(this.buttonFilterPhieuMuon);
            this.groupBox4.Controls.Add(this.checkTenSVPhieuMuon);
            this.groupBox4.Controls.Add(this.filterTenSachPhieuMuon);
            this.groupBox4.Controls.Add(this.checkTenSachPhieuMuon);
            this.groupBox4.Controls.Add(this.filterMaSVPhieuMuon);
            this.groupBox4.Controls.Add(this.checkMaSinhVienPhieuMuon);
            this.groupBox4.Controls.Add(this.filterMaSachPhieuMuon);
            this.groupBox4.Controls.Add(this.filterMaPhieu);
            this.groupBox4.Controls.Add(this.checkMaSachPhieuMuon);
            this.groupBox4.Controls.Add(this.checkMaPhieu);
            this.groupBox4.Location = new System.Drawing.Point(9, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 260);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lọc";
            // 
            // filterTenSVPhieuMuon
            // 
            this.filterTenSVPhieuMuon.Location = new System.Drawing.Point(113, 160);
            this.filterTenSVPhieuMuon.Name = "filterTenSVPhieuMuon";
            this.filterTenSVPhieuMuon.Size = new System.Drawing.Size(158, 25);
            this.filterTenSVPhieuMuon.TabIndex = 20;
            // 
            // buttonClearFilterPhieuMuon
            // 
            this.buttonClearFilterPhieuMuon.Location = new System.Drawing.Point(10, 200);
            this.buttonClearFilterPhieuMuon.Name = "buttonClearFilterPhieuMuon";
            this.buttonClearFilterPhieuMuon.Size = new System.Drawing.Size(120, 39);
            this.buttonClearFilterPhieuMuon.TabIndex = 19;
            this.buttonClearFilterPhieuMuon.Text = "Xoá kết quả";
            this.buttonClearFilterPhieuMuon.UseVisualStyleBackColor = true;
            this.buttonClearFilterPhieuMuon.Click += new System.EventHandler(this.ButtonClearFilterPhieuMuon_Click);
            // 
            // buttonFilterPhieuMuon
            // 
            this.buttonFilterPhieuMuon.Location = new System.Drawing.Point(151, 200);
            this.buttonFilterPhieuMuon.Name = "buttonFilterPhieuMuon";
            this.buttonFilterPhieuMuon.Size = new System.Drawing.Size(120, 39);
            this.buttonFilterPhieuMuon.TabIndex = 18;
            this.buttonFilterPhieuMuon.Text = "Lọc";
            this.buttonFilterPhieuMuon.UseVisualStyleBackColor = true;
            this.buttonFilterPhieuMuon.Click += new System.EventHandler(this.ButtonFilterPhieuMuon_Click);
            // 
            // checkTenSVPhieuMuon
            // 
            this.checkTenSVPhieuMuon.AutoSize = true;
            this.checkTenSVPhieuMuon.Location = new System.Drawing.Point(10, 162);
            this.checkTenSVPhieuMuon.Name = "checkTenSVPhieuMuon";
            this.checkTenSVPhieuMuon.Size = new System.Drawing.Size(83, 22);
            this.checkTenSVPhieuMuon.TabIndex = 10;
            this.checkTenSVPhieuMuon.Text = "Tên SV:";
            this.checkTenSVPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // filterTenSachPhieuMuon
            // 
            this.filterTenSachPhieuMuon.Location = new System.Drawing.Point(113, 130);
            this.filterTenSachPhieuMuon.Name = "filterTenSachPhieuMuon";
            this.filterTenSachPhieuMuon.Size = new System.Drawing.Size(158, 25);
            this.filterTenSachPhieuMuon.TabIndex = 9;
            // 
            // checkTenSachPhieuMuon
            // 
            this.checkTenSachPhieuMuon.AutoSize = true;
            this.checkTenSachPhieuMuon.Location = new System.Drawing.Point(10, 131);
            this.checkTenSachPhieuMuon.Name = "checkTenSachPhieuMuon";
            this.checkTenSachPhieuMuon.Size = new System.Drawing.Size(99, 22);
            this.checkTenSachPhieuMuon.TabIndex = 8;
            this.checkTenSachPhieuMuon.Text = "Tên sách:";
            this.checkTenSachPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // filterMaSVPhieuMuon
            // 
            this.filterMaSVPhieuMuon.Location = new System.Drawing.Point(113, 99);
            this.filterMaSVPhieuMuon.Name = "filterMaSVPhieuMuon";
            this.filterMaSVPhieuMuon.Size = new System.Drawing.Size(158, 25);
            this.filterMaSVPhieuMuon.TabIndex = 7;
            // 
            // checkMaSinhVienPhieuMuon
            // 
            this.checkMaSinhVienPhieuMuon.AutoSize = true;
            this.checkMaSinhVienPhieuMuon.Location = new System.Drawing.Point(10, 100);
            this.checkMaSinhVienPhieuMuon.Name = "checkMaSinhVienPhieuMuon";
            this.checkMaSinhVienPhieuMuon.Size = new System.Drawing.Size(75, 22);
            this.checkMaSinhVienPhieuMuon.TabIndex = 6;
            this.checkMaSinhVienPhieuMuon.Text = "Mã SV:";
            this.checkMaSinhVienPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // filterMaSachPhieuMuon
            // 
            this.filterMaSachPhieuMuon.Location = new System.Drawing.Point(113, 68);
            this.filterMaSachPhieuMuon.Name = "filterMaSachPhieuMuon";
            this.filterMaSachPhieuMuon.Size = new System.Drawing.Size(158, 25);
            this.filterMaSachPhieuMuon.TabIndex = 4;
            // 
            // filterMaPhieu
            // 
            this.filterMaPhieu.Location = new System.Drawing.Point(113, 37);
            this.filterMaPhieu.Name = "filterMaPhieu";
            this.filterMaPhieu.Size = new System.Drawing.Size(158, 25);
            this.filterMaPhieu.TabIndex = 3;
            // 
            // checkMaSachPhieuMuon
            // 
            this.checkMaSachPhieuMuon.AutoSize = true;
            this.checkMaSachPhieuMuon.Location = new System.Drawing.Point(10, 69);
            this.checkMaSachPhieuMuon.Name = "checkMaSachPhieuMuon";
            this.checkMaSachPhieuMuon.Size = new System.Drawing.Size(91, 22);
            this.checkMaSachPhieuMuon.TabIndex = 1;
            this.checkMaSachPhieuMuon.Tag = "TenSinhVien";
            this.checkMaSachPhieuMuon.Text = "Mã sách:";
            this.checkMaSachPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // checkMaPhieu
            // 
            this.checkMaPhieu.AutoSize = true;
            this.checkMaPhieu.Location = new System.Drawing.Point(10, 38);
            this.checkMaPhieu.Name = "checkMaPhieu";
            this.checkMaPhieu.Size = new System.Drawing.Size(99, 22);
            this.checkMaPhieu.TabIndex = 0;
            this.checkMaPhieu.Tag = "Id";
            this.checkMaPhieu.Text = "Mã phiếu:";
            this.checkMaPhieu.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeletePhieuMuon);
            this.groupBox5.Controls.Add(this.buttonAddPhieuMuon);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textMaPhieu);
            this.groupBox5.Location = new System.Drawing.Point(9, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 182);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tác vụ";
            // 
            // buttonDeletePhieuMuon
            // 
            this.buttonDeletePhieuMuon.Location = new System.Drawing.Point(10, 96);
            this.buttonDeletePhieuMuon.Name = "buttonDeletePhieuMuon";
            this.buttonDeletePhieuMuon.Size = new System.Drawing.Size(261, 35);
            this.buttonDeletePhieuMuon.TabIndex = 4;
            this.buttonDeletePhieuMuon.Text = "Xoá phiếu mượn";
            this.buttonDeletePhieuMuon.UseVisualStyleBackColor = true;
            this.buttonDeletePhieuMuon.Click += new System.EventHandler(this.ButtonDeletePhieuMuon_Click);
            // 
            // buttonAddPhieuMuon
            // 
            this.buttonAddPhieuMuon.Location = new System.Drawing.Point(10, 55);
            this.buttonAddPhieuMuon.Name = "buttonAddPhieuMuon";
            this.buttonAddPhieuMuon.Size = new System.Drawing.Size(261, 35);
            this.buttonAddPhieuMuon.TabIndex = 2;
            this.buttonAddPhieuMuon.Text = "Thêm phiếu mượn";
            this.buttonAddPhieuMuon.UseVisualStyleBackColor = true;
            this.buttonAddPhieuMuon.Click += new System.EventHandler(this.ButtonAddPhieuMuon_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMaPhieu
            // 
            this.textMaPhieu.Location = new System.Drawing.Point(113, 24);
            this.textMaPhieu.Name = "textMaPhieu";
            this.textMaPhieu.Size = new System.Drawing.Size(158, 25);
            this.textMaPhieu.TabIndex = 0;
            // 
            // dataGridViewPhieuMuon
            // 
            this.dataGridViewPhieuMuon.AllowUserToAddRows = false;
            this.dataGridViewPhieuMuon.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuMuon.AutoGenerateColumns = false;
            this.dataGridViewPhieuMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.TenSinhVien,
            this.MaSinhVien,
            this.MaSach,
            this.NgayMuon,
            this.NgayTra});
            this.dataGridViewPhieuMuon.DataSource = this.phieuMuonBindingSource;
            this.dataGridViewPhieuMuon.Location = new System.Drawing.Point(303, 10);
            this.dataGridViewPhieuMuon.Name = "dataGridViewPhieuMuon";
            this.dataGridViewPhieuMuon.ReadOnly = true;
            this.dataGridViewPhieuMuon.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPhieuMuon.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPhieuMuon.Size = new System.Drawing.Size(890, 584);
            this.dataGridViewPhieuMuon.TabIndex = 6;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Edit";
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.DataPropertyName = "Edit";
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Sửa";
            this.dataGridViewButtonColumn2.Width = 50;
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.DataPropertyName = "TenSinhVien";
            this.TenSinhVien.HeaderText = "Tên sinh viên";
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.ReadOnly = true;
            this.TenSinhVien.Width = 185;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "Mã sinh viên";
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mãNguồnToolStripMenuItem,
            this.danhSáchThànhViênNhómToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // mãNguồnToolStripMenuItem
            // 
            this.mãNguồnToolStripMenuItem.Name = "mãNguồnToolStripMenuItem";
            this.mãNguồnToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mãNguồnToolStripMenuItem.Text = "Mã nguồn";
            this.mãNguồnToolStripMenuItem.Click += new System.EventHandler(this.MãNguồnToolStripMenuItem_Click);
            // 
            // danhSáchThànhViênNhómToolStripMenuItem
            // 
            this.danhSáchThànhViênNhómToolStripMenuItem.Name = "danhSáchThànhViênNhómToolStripMenuItem";
            this.danhSáchThànhViênNhómToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.danhSáchThànhViênNhómToolStripMenuItem.Text = "Danh sách thành viên nhóm";
            this.danhSáchThànhViênNhómToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchThànhViênNhómToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 53;
            // 
            // tenSinhVienDataGridViewTextBoxColumn
            // 
            this.tenSinhVienDataGridViewTextBoxColumn.DataPropertyName = "TenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.HeaderText = "Tên sinh viên";
            this.tenSinhVienDataGridViewTextBoxColumn.Name = "tenSinhVienDataGridViewTextBoxColumn";
            this.tenSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 90;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 50;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.ReadOnly = true;
            this.lopDataGridViewTextBoxColumn.Width = 80;
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "Khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            this.khoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.khoaDataGridViewTextBoxColumn.Width = 80;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 140;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 110;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Sdt";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyThuVien.SinhVien);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Mã sách";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSachDataGridViewTextBoxColumn.Width = 180;
            // 
            // tacGiaDataGridViewTextBoxColumn
            // 
            this.tacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.HeaderText = "Tác giả";
            this.tacGiaDataGridViewTextBoxColumn.Name = "tacGiaDataGridViewTextBoxColumn";
            this.tacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tacGiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nxbDataGridViewTextBoxColumn
            // 
            this.nxbDataGridViewTextBoxColumn.DataPropertyName = "Nxb";
            this.nxbDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.nxbDataGridViewTextBoxColumn.Name = "nxbDataGridViewTextBoxColumn";
            this.nxbDataGridViewTextBoxColumn.ReadOnly = true;
            this.nxbDataGridViewTextBoxColumn.Width = 150;
            // 
            // namXuatBanDataGridViewTextBoxColumn
            // 
            this.namXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NamXuatBan";
            this.namXuatBanDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản";
            this.namXuatBanDataGridViewTextBoxColumn.Name = "namXuatBanDataGridViewTextBoxColumn";
            this.namXuatBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tinhTrangDataGridViewTextBoxColumn.Width = 50;
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "Giá sách";
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            this.giaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaSachDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(QuanLyThuVien.Sach.Book);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã phiếu";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn1.FillWeight = 140F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataSource = typeof(QuanLyThuVien.Muon.PhieuMuon);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 662);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPageLibrary.ResumeLayout(false);
            this.tabPageLibrary.PerformLayout();
            this.tabPageSinhVien.ResumeLayout(false);
            this.groupBoxSinhVienFilter.ResumeLayout(false);
            this.groupBoxSinhVienFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.tabPageBook.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGiaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterNamXB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.tabPagePhieuMuon.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuMuon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLibrary;
        private System.Windows.Forms.TabPage tabPageSinhVien;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPagePhieuMuon;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private GroupBox groupBox1;
        private TextBox textMaSV;
        private Label label1;
        private Button button1;
        private Button buttonDeleteSinhVien;
        private Button button2;
        private GroupBox groupBoxSinhVienFilter;
        private CheckBox checkBoxNgaySinhSinhVien;
        private CheckBox checkBoxHoTenSinhVien;
        private CheckBox checkBoxMaSoSinhVien;
        private TextBox filterMaSoSinhVien;
        private TextBox filterTenSinhVien;
        private CheckBox checkBoxGioiTinhSinhVien;
        private TextBox filterLopSinhVien;
        private CheckBox checkBoxLopSinhVien;
        private TextBox filterKhoaSinhVien;
        private CheckBox checkBoxKhoaSinhVien;
        private TextBox filterDiaChiSinhVien;
        private CheckBox checkBoxDiaChiSinhVien;
        private TextBox filterEmailSinhVien;
        private CheckBox checkBoxEmailSinhVien;
        private TextBox filterSDTSinhVien;
        private CheckBox checkBoxSdtSinhVien;
        private Button buttonFilterSinhVien;
        private Button buttonClearFilter;
        private DateTimePicker dateTimePickerSinhVien;
        private GroupBox groupBox2;
        private Button buttonClearFilterSach;
        private Button buttonFilterSach;
        private CheckBox checkGiaSach;
        private CheckBox checkKhaDung;
        private CheckBox checkTinhTrangSach;
        private CheckBox checkNamXB;
        private TextBox filterNXB;
        private CheckBox checkNXB;
        private TextBox filterTacGia;
        private CheckBox checkTacGia;
        private TextBox filterTenSach;
        private TextBox filterMaSach;
        private CheckBox checkTenSach;
        private CheckBox checkMaSach;
        private GroupBox groupBox3;
        private Button buttonXoaSach;
        private Button buttonEditSach;
        private Button buttonAddSach;
        private Label label2;
        private TextBox textMaSach;
        private DataGridView dataGridViewBook;
        private NumericUpDown filterGiaSach;
        private NumericUpDown filterNamXB;
        private BindingSource bookBindingSource;
        private ComboBox filterTinhTrangSach;
        private GroupBox groupBox4;
        private Button buttonClearFilterPhieuMuon;
        private Button buttonFilterPhieuMuon;
        private CheckBox checkTenSVPhieuMuon;
        private TextBox filterTenSachPhieuMuon;
        private CheckBox checkTenSachPhieuMuon;
        private TextBox filterMaSVPhieuMuon;
        private CheckBox checkMaSinhVienPhieuMuon;
        private TextBox filterMaSachPhieuMuon;
        private TextBox filterMaPhieu;
        private CheckBox checkMaSachPhieuMuon;
        private CheckBox checkMaPhieu;
        private GroupBox groupBox5;
        private Button buttonDeletePhieuMuon;
        private Button buttonAddPhieuMuon;
        private Label label3;
        private TextBox textMaPhieu;
        private DataGridView dataGridViewPhieuMuon;
        private TextBox filterTenSVPhieuMuon;
        private BindingSource phieuMuonBindingSource;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSinhVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private ComboBox comboKhaDung;
        private ComboBox filterGioiTinhSinhVien;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nxbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namXuatBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TenSinhVien;
        private DataGridViewTextBoxColumn MaSinhVien;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayTra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem mãNguồnToolStripMenuItem;
        private ToolStripMenuItem danhSáchThànhViênNhómToolStripMenuItem;
        private PictureBox pictureBox1;

        public TabControl TabControl { get => tabControl; set => tabControl = value; }
        public TabPage TabPageLibrary { get => tabPageLibrary; set => tabPageLibrary = value; }
        public TabPage TabPageSinhVien { get => tabPageSinhVien; set => tabPageSinhVien = value; }
        public TabPage TabPageBook { get => tabPageBook; set => tabPageBook = value; }
        public TabPage TabPageThuThu { get => tabPagePhieuMuon; set => tabPagePhieuMuon = value; }
        public DataGridView DataGridViewSinhVien { get => dataGridViewSinhVien; set => dataGridViewSinhVien = value; }
        public BindingSource SinhVienBindingSource { get => sinhVienBindingSource; set => sinhVienBindingSource = value; }
        public DataGridViewTextBoxColumn TenSinhVienDataGridViewTextBoxColumn { get => TenSinhVienDataGridViewTextBoxColumn1; set => TenSinhVienDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn NgaySinhDataGridViewTextBoxColumn { get => NgaySinhDataGridViewTextBoxColumn1; set => NgaySinhDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn GioiTinhDataGridViewTextBoxColumn { get => GioiTinhDataGridViewTextBoxColumn1; set => GioiTinhDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn LopDataGridViewTextBoxColumn { get => LopDataGridViewTextBoxColumn1; set => LopDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn KhoaDataGridViewTextBoxColumn { get => KhoaDataGridViewTextBoxColumn1; set => KhoaDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn DiaChiDataGridViewTextBoxColumn { get => DiaChiDataGridViewTextBoxColumn1; set => DiaChiDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn { get => EmailDataGridViewTextBoxColumn1; set => EmailDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn SdtDataGridViewTextBoxColumn { get => SdtDataGridViewTextBoxColumn1; set => SdtDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn { get => IdDataGridViewTextBoxColumn1; set => IdDataGridViewTextBoxColumn1 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TextBox1 { get => textMaSV; set => textMaSV = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public Button Button3 { get => buttonDeleteSinhVien; set => buttonDeleteSinhVien = value; }
        public Button Button2 { get => button2; set => button2 = value; }
        public GroupBox GroupBoxSinhVienFilter { get => groupBoxSinhVienFilter; set => groupBoxSinhVienFilter = value; }
        public CheckBox CheckBoxNgaySinhSinhVien { get => checkBoxNgaySinhSinhVien; set => checkBoxNgaySinhSinhVien = value; }
        public CheckBox CheckBoxHoTenSinhVien { get => checkBoxHoTenSinhVien; set => checkBoxHoTenSinhVien = value; }
        public CheckBox CheckBoxMaSoSinhVien { get => checkBoxMaSoSinhVien; set => checkBoxMaSoSinhVien = value; }
        public TextBox FilterMaSoSinhVien { get => filterMaSoSinhVien; set => filterMaSoSinhVien = value; }
        public TextBox FilterTenSinhVien { get => filterTenSinhVien; set => filterTenSinhVien = value; }
        public ComboBox FilterGioiTinhSinhVien { get => filterGioiTinhSinhVien; set => filterGioiTinhSinhVien = value; }
        public CheckBox CheckBoxGioiTinhSinhVien { get => checkBoxGioiTinhSinhVien; set => checkBoxGioiTinhSinhVien = value; }
        public TextBox FilterLopSinhVien { get => filterLopSinhVien; set => filterLopSinhVien = value; }
        public CheckBox CheckBoxLopSinhVien { get => checkBoxLopSinhVien; set => checkBoxLopSinhVien = value; }
        public TextBox FilterKhoaSinhVien { get => filterKhoaSinhVien; set => filterKhoaSinhVien = value; }
        public CheckBox CheckBoxKhoaSinhVien { get => checkBoxKhoaSinhVien; set => checkBoxKhoaSinhVien = value; }
        public TextBox FilterDiaChiSinhVien { get => filterDiaChiSinhVien; set => filterDiaChiSinhVien = value; }
        public CheckBox CheckBoxDiaChiSinhVien { get => checkBoxDiaChiSinhVien; set => checkBoxDiaChiSinhVien = value; }
        public TextBox FilterEmailSinhVien { get => filterEmailSinhVien; set => filterEmailSinhVien = value; }
        public CheckBox CheckBoxEmailSinhVien { get => checkBoxEmailSinhVien; set => checkBoxEmailSinhVien = value; }
        public TextBox FilterSDTSinhVien { get => filterSDTSinhVien; set => filterSDTSinhVien = value; }
        public CheckBox CheckBoxSdtSinhVien { get => checkBoxSdtSinhVien; set => checkBoxSdtSinhVien = value; }
        public Button Button4 { get => ButtonFilterSinhVien; set => ButtonFilterSinhVien = value; }
        public Button ButtonFilterSinhVien { get => buttonFilterSinhVien; set => buttonFilterSinhVien = value; }
        public Button ButtonClearFilter { get => buttonClearFilter; set => buttonClearFilter = value; }
        public DateTimePicker DateTimePickerSinhVien { get => dateTimePickerSinhVien; set => dateTimePickerSinhVien = value; }
        public DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn1 { get => idDataGridViewTextBoxColumn; set => idDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn TenSinhVienDataGridViewTextBoxColumn1 { get => tenSinhVienDataGridViewTextBoxColumn; set => tenSinhVienDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn NgaySinhDataGridViewTextBoxColumn1 { get => ngaySinhDataGridViewTextBoxColumn; set => ngaySinhDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn GioiTinhDataGridViewTextBoxColumn1 { get => gioiTinhDataGridViewTextBoxColumn; set => gioiTinhDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn LopDataGridViewTextBoxColumn1 { get => lopDataGridViewTextBoxColumn; set => lopDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn KhoaDataGridViewTextBoxColumn1 { get => khoaDataGridViewTextBoxColumn; set => khoaDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn DiaChiDataGridViewTextBoxColumn1 { get => diaChiDataGridViewTextBoxColumn; set => diaChiDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn1 { get => emailDataGridViewTextBoxColumn; set => emailDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn SdtDataGridViewTextBoxColumn1 { get => sdtDataGridViewTextBoxColumn; set => sdtDataGridViewTextBoxColumn = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public Button ButtonClearFilterSach { get => buttonClearFilterSach; set => buttonClearFilterSach = value; }
        public Button ButtonFilterSach { get => buttonFilterSach; set => buttonFilterSach = value; }
        public CheckBox CheckGiaSach { get => checkGiaSach; set => checkGiaSach = value; }
        public CheckBox CheckKhaDung { get => checkKhaDung; set => checkKhaDung = value; }
        public ComboBox FilterTinhTrangSach { get => filterTinhTrangSach; set => filterTinhTrangSach = value; }
        public CheckBox CheckTinhTrangSach { get => checkTinhTrangSach; set => checkTinhTrangSach = value; }
        public CheckBox CheckNamXB { get => checkNamXB; set => checkNamXB = value; }
        public TextBox FilterNXB { get => filterNXB; set => filterNXB = value; }
        public CheckBox CheckNXB { get => checkNXB; set => checkNXB = value; }
        public TextBox FilterTacGia { get => filterTacGia; set => filterTacGia = value; }
        public CheckBox CheckTacGia { get => checkTacGia; set => checkTacGia = value; }
        public TextBox FilterTenSach { get => filterTenSach; set => filterTenSach = value; }
        public TextBox FilterMaSach { get => filterMaSach; set => filterMaSach = value; }
        public CheckBox CheckTenSach { get => checkTenSach; set => checkTenSach = value; }
        public CheckBox CheckMaSach { get => checkMaSach; set => checkMaSach = value; }
        public GroupBox GroupBox3 { get => groupBox3; set => groupBox3 = value; }
        public Button ButtonXoaSach { get => buttonXoaSach; set => buttonXoaSach = value; }
        public Button ButtonEditSach { get => buttonEditSach; set => buttonEditSach = value; }
        public Button ButtonAddSach { get => buttonAddSach; set => buttonAddSach = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TextMaSach { get => textMaSach; set => textMaSach = value; }
        public DataGridView DataGridViewBook { get => dataGridViewBook; set => dataGridViewBook = value; }
        public NumericUpDown FilterGiaSach { get => filterGiaSach; set => filterGiaSach = value; }
        public NumericUpDown FilterNamXB { get => filterNamXB; set => filterNamXB = value; }
        public BindingSource BookBindingSource { get => bookBindingSource; set => bookBindingSource = value; }
        public BindingSource PhieuMuonBindingSource { get => phieuMuonBindingSource; set => phieuMuonBindingSource = value; }
        public ComboBox ComboKhaDung { get => comboKhaDung; set => comboKhaDung = value; }
        public Button ButtonClearFilterPhieuMuon { get => buttonClearFilterPhieuMuon; set => buttonClearFilterPhieuMuon = value; }
        public Button ButtonFilterPhieuMuon { get => buttonFilterPhieuMuon; set => buttonFilterPhieuMuon = value; }
        public CheckBox CheckTenSVPhieuMuon { get => checkTenSVPhieuMuon; set => checkTenSVPhieuMuon = value; }
        public TextBox FilterTenSachPhieuMuon { get => filterTenSachPhieuMuon; set => filterTenSachPhieuMuon = value; }
        public CheckBox CheckTenSachPhieuMuon { get => checkTenSachPhieuMuon; set => checkTenSachPhieuMuon = value; }
        public TextBox FilterMaSVPhieuMuon { get => filterMaSVPhieuMuon; set => filterMaSVPhieuMuon = value; }
        public CheckBox CheckMaSinhVienPhieuMuon { get => checkMaSinhVienPhieuMuon; set => checkMaSinhVienPhieuMuon = value; }
        public TextBox FilterMaSachPhieuMuon { get => filterMaSachPhieuMuon; set => filterMaSachPhieuMuon = value; }
        public TextBox FilterMaPhieu { get => filterMaPhieu; set => filterMaPhieu = value; }
        public CheckBox CheckMaSachPhieuMuon { get => checkMaSachPhieuMuon; set => checkMaSachPhieuMuon = value; }
        public CheckBox CheckMaPhieu { get => checkMaPhieu; set => checkMaPhieu = value; }
        public GroupBox GroupBox5 { get => groupBox5; set => groupBox5 = value; }
        public Button ButtonDeletePhieuMuon { get => buttonDeletePhieuMuon; set => buttonDeletePhieuMuon = value; }
        public Button ButtonAddPhieuMuon { get => buttonAddPhieuMuon; set => buttonAddPhieuMuon = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TextMaPhieu { get => textMaPhieu; set => textMaPhieu = value; }
        public DataGridView DataGridViewPhieuMuon { get => dataGridViewPhieuMuon; set => dataGridViewPhieuMuon = value; }
        public TextBox FilterTenSVPhieuMuon { get => filterTenSVPhieuMuon; set => filterTenSVPhieuMuon = value; }
    }
}

