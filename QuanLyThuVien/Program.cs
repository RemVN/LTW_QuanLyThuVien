using QuanLyThuVien.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    static class Program
    {
        static string dateFormat = "dd/MM/yyyy";
        static MainForm mainForm;
        static Main main;
        private static bool init = false;

        public static MainForm MainForm { get => mainForm; set => mainForm = value; }
        public static bool Init { get => init; set => init = value; }
        public static string DateFormat { get => dateFormat; set => dateFormat = value; }
        internal static Main MainClass { get => main; set => main = value; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            main = new Main();
            FormLogin loginForm = new FormLogin();
            Application.Run(loginForm);
        }

        public static void close()
        {
            Application.Exit();
        }
    }
}
