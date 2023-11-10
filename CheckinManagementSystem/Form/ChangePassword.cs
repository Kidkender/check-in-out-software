using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class ChangePassword : Form
    {
        LoaiRecordBLL recordBLL = new LoaiRecordBLL();
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
        }
    }
}