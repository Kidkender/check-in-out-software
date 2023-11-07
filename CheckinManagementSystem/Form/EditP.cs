using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditP : Form
	{
		PhongBLL _phongBLL = new PhongBLL();
		static EditP _obj;
        public static EditP Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditP(lbl,p);
                }
                return _obj;
            }
        }
        public EditP(bool lbl, Phong phong = null)
		{
			InitializeComponent();
            if(lbl)
            {
                lbTitle.Text = "THÊM PHÒNG";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT PHÒNG";
            }
        }

        private static bool lbl;
		private static Phong p;
		public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
