namespace QuanLyThuVien
{
    partial class FormAddSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.textMaSo = new System.Windows.Forms.TextBox();
            this.textTenSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboGioiTinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textMaSo
            // 
            this.textMaSo.Location = new System.Drawing.Point(136, 23);
            this.textMaSo.Name = "textMaSo";
            this.textMaSo.Size = new System.Drawing.Size(178, 20);
            this.textMaSo.TabIndex = 1;
            this.textMaSo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textTenSinhVien
            // 
            this.textTenSinhVien.Location = new System.Drawing.Point(136, 59);
            this.textTenSinhVien.Name = "textTenSinhVien";
            this.textTenSinhVien.Size = new System.Drawing.Size(178, 20);
            this.textTenSinhVien.TabIndex = 3;
            this.textTenSinhVien.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sinh viên:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "";
            this.dateTimePickerNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(136, 95);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // textBoxLop
            // 
            this.textBoxLop.Location = new System.Drawing.Point(136, 164);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(178, 20);
            this.textBoxLop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp:";
            // 
            // textBoxKhoa
            // 
            this.textBoxKhoa.Location = new System.Drawing.Point(136, 200);
            this.textBoxKhoa.Name = "textBoxKhoa";
            this.textBoxKhoa.Size = new System.Drawing.Size(178, 20);
            this.textBoxKhoa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Khoa:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(136, 235);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(178, 20);
            this.textBoxDiaChi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(136, 273);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(178, 20);
            this.textBoxEmail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email:";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(136, 310);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(178, 20);
            this.textBoxSoDienThoai.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số điện thoại:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(239, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(157, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // comboGioiTinh
            // 
            this.comboGioiTinh.FormattingEnabled = true;
            this.comboGioiTinh.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.comboGioiTinh.Location = new System.Drawing.Point(136, 129);
            this.comboGioiTinh.Name = "comboGioiTinh";
            this.comboGioiTinh.Size = new System.Drawing.Size(178, 21);
            this.comboGioiTinh.TabIndex = 20;
            this.comboGioiTinh.Text = "-Chọn giới tính-";
            // 
            // FormAddSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 375);
            this.Controls.Add(this.comboGioiTinh);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTenSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMaSo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Sinh Viên";
            this.Load += new System.EventHandler(this.FormAddSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaSo;
        private System.Windows.Forms.TextBox textTenSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboGioiTinh;
    }
}