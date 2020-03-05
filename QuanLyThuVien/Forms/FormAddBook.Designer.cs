namespace QuanLyThuVien.Forms
{
    partial class FormAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBook));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMaSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTinhTrang = new System.Windows.Forms.ComboBox();
            this.numNamXB = new System.Windows.Forms.NumericUpDown();
            this.numGiaSach = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(167, 299);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(246, 299);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Giá sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Năm XB:";
            // 
            // textNXB
            // 
            this.textNXB.Location = new System.Drawing.Point(143, 153);
            this.textNXB.Name = "textNXB";
            this.textNXB.Size = new System.Drawing.Size(178, 20);
            this.textNXB.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "NXB:";
            // 
            // textTacGia
            // 
            this.textTacGia.Location = new System.Drawing.Point(143, 118);
            this.textTacGia.Name = "textTacGia";
            this.textTacGia.Size = new System.Drawing.Size(178, 20);
            this.textTacGia.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tác giả:";
            // 
            // textTenSach
            // 
            this.textTenSach.Location = new System.Drawing.Point(143, 85);
            this.textTenSach.Name = "textTenSach";
            this.textTenSach.Size = new System.Drawing.Size(178, 20);
            this.textTenSach.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sách:";
            // 
            // textMaSo
            // 
            this.textMaSo.Location = new System.Drawing.Point(143, 49);
            this.textMaSo.Name = "textMaSo";
            this.textMaSo.Size = new System.Drawing.Size(178, 20);
            this.textMaSo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã sách:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboTinhTrang
            // 
            this.comboTinhTrang.FormattingEnabled = true;
            this.comboTinhTrang.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.comboTinhTrang.Location = new System.Drawing.Point(143, 224);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(178, 21);
            this.comboTinhTrang.TabIndex = 40;
            this.comboTinhTrang.Text = "-Chọn tình trạng-";
            // 
            // numNamXB
            // 
            this.numNamXB.Location = new System.Drawing.Point(143, 189);
            this.numNamXB.Name = "numNamXB";
            this.numNamXB.Size = new System.Drawing.Size(178, 20);
            this.numNamXB.TabIndex = 41;
            // 
            // numGiaSach
            // 
            this.numGiaSach.Location = new System.Drawing.Point(143, 262);
            this.numGiaSach.Name = "numGiaSach";
            this.numGiaSach.Size = new System.Drawing.Size(178, 20);
            this.numGiaSach.TabIndex = 42;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 384);
            this.Controls.Add(this.numGiaSach);
            this.Controls.Add(this.numNamXB);
            this.Controls.Add(this.comboTinhTrang);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMaSo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sách";
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTinhTrang;
        private System.Windows.Forms.NumericUpDown numNamXB;
        private System.Windows.Forms.NumericUpDown numGiaSach;
    }
}