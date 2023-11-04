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
            if(tbTaiKhoan.Text == "user" && tbMatKhau.Text == "123")
			{
                this.Close();
                this.check = true;
                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
            }
            else
            {

            }

        }

		public bool check = false;
    }
}
