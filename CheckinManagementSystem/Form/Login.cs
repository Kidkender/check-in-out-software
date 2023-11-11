using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class Login : Form
    {
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        static Login _obj;
        public static Login Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Login();
                }
                return _obj;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAdmin();
        }

        public bool check = false;

        private void tbTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAdmin();
            }
        }

        private void LoginAdmin()
        {
            if (_nhanSuBLL.LoginAdmin(tbTaiKhoan.Text, tbMatKhau.Text))
            {
                this.Close();
                this.check = true;
                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAdmin();
            }
        }
    }
}
