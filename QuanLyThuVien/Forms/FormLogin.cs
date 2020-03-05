using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class FormLogin : Form
    {

        public static readonly string username = "admin";
        public static readonly string password = "123456";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public string getPassword()
        {
            return textPassword.Text;
        }

        public string getUsername()
        {
            return textUsername.Text;
        }

        public bool checkAuth()
        {
            if(getPassword().Equals(password) && getUsername().Equals(username)) return true;
            return false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(checkAuth())
            {
                this.Hide();
                Program.MainForm.Show();
            } else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
