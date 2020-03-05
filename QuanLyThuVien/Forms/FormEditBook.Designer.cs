namespace QuanLyThuVien.Forms
{
    partial class FormEditBook
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
            this.numGiaSach = new System.Windows.Forms.NumericUpDown();
            this.numNamXB = new System.Windows.Forms.NumericUpDown();
            this.comboTinhTrang = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).BeginInit();
            this.SuspendLayout();
            // 
            // numGiaSach
            // 
            this.numGiaSach.Location = new System.Drawing.Point(144, 263);
            this.numGiaSach.Name = "numGiaSach";
            this.numGiaSach.Size = new System.Drawing.Size(178, 20);
            this.numGiaSach.TabIndex = 58;
            // 
            // numNamXB
            // 
            this.numNamXB.Location = new System.Drawing.Point(144, 190);
            this.numNamXB.Name = "numNamXB";
            this.numNamXB.Size = new System.Drawing.Size(178, 20);
            this.numNamXB.TabIndex = 57;
            // 
            // comboTinhTrang
            // 
            this.comboTinhTrang.FormattingEnabled = true;
            this.comboTinhTrang.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.comboTinhTrang.Location = new System.Drawing.Point(144, 225);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(178, 21);
            this.comboTinhTrang.TabIndex = 56;
            this.comboTinhTrang.Text = "-Chọn tình trạng-";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(168, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 55;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(247, 300);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Sửa";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Giá sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Năm XB:";
            // 
            // textNXB
            // 
            this.textNXB.Location = new System.Drawing.Point(144, 154);
            this.textNXB.Name = "textNXB";
            this.textNXB.Size = new System.Drawing.Size(178, 20);
            this.textNXB.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "NXB:";
            // 
            // textTacGia
            // 
            this.textTacGia.Location = new System.Drawing.Point(144, 119);
            this.textTacGia.Name = "textTacGia";
            this.textTacGia.Size = new System.Drawing.Size(178, 20);
            this.textTacGia.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tác giả:";
            // 
            // textTenSach
            // 
            this.textTenSach.Location = new System.Drawing.Point(144, 86);
            this.textTenSach.Name = "textTenSach";
            this.textTenSach.Size = new System.Drawing.Size(178, 20);
            this.textTenSach.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên sách:";
            // 
            // textMaSo
            // 
            this.textMaSo.Location = new System.Drawing.Point(144, 50);
            this.textMaSo.Name = "textMaSo";
            this.textMaSo.ReadOnly = true;
            this.textMaSo.Size = new System.Drawing.Size(178, 20);
            this.textMaSo.TabIndex = 44;
            this.textMaSo.TextChanged += new System.EventHandler(this.TextMaSo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã sách:";
            // 
            // FormEditBook
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
            this.Name = "FormEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa sách";
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGiaSach;
        private System.Windows.Forms.NumericUpDown numNamXB;
        private System.Windows.Forms.ComboBox comboTinhTrang;
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
    }
}