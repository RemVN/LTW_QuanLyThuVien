namespace QuanLyThuVien.Forms
{
    partial class FormAddPhieuMuon
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textMaSinhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSoNgayMuon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgayMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(172, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 55;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(251, 181);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Số ngày mượn:";
            // 
            // textMaSinhVien
            // 
            this.textMaSinhVien.Location = new System.Drawing.Point(148, 108);
            this.textMaSinhVien.Name = "textMaSinhVien";
            this.textMaSinhVien.Size = new System.Drawing.Size(178, 20);
            this.textMaSinhVien.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã sinh viên:";
            // 
            // textMaSach
            // 
            this.textMaSach.Location = new System.Drawing.Point(148, 75);
            this.textMaSach.Name = "textMaSach";
            this.textMaSach.Size = new System.Drawing.Size(178, 20);
            this.textMaSach.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã sách:";
            // 
            // textMaPhieu
            // 
            this.textMaPhieu.Location = new System.Drawing.Point(148, 39);
            this.textMaPhieu.Name = "textMaPhieu";
            this.textMaPhieu.Size = new System.Drawing.Size(178, 20);
            this.textMaPhieu.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã phiếu:";
            // 
            // numSoNgayMuon
            // 
            this.numSoNgayMuon.Location = new System.Drawing.Point(148, 143);
            this.numSoNgayMuon.Name = "numSoNgayMuon";
            this.numSoNgayMuon.Size = new System.Drawing.Size(178, 20);
            this.numSoNgayMuon.TabIndex = 56;
            // 
            // FormAddPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 235);
            this.Controls.Add(this.numSoNgayMuon);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMaSinhVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMaPhieu);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phiếu mượn";
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgayMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMaSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoNgayMuon;
    }
}