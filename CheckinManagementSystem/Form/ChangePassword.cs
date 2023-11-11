using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class ChangePassword : Form
    {
        LoaiRecordBLL recordBLL = new LoaiRecordBLL();
        NhanSuBLL nhanSuBLL = new NhanSuBLL();
        static ChangePassword _obj;
        public static ChangePassword Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ChangePassword();
                }
                return _obj;
            }
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private int Id;
        private bool lbl;
        public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbMKM.Text != tbNLMK.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                nhanSuBLL.SetPassWordAdmin(tbMKM.Text);
                this.Close();
            }
        }
    }
}