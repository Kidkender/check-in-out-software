using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditP : Form
	{
        static EditP _obj;
        public static EditP Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditP(lbl);
                }
                return _obj;
            }
        }
        public EditP(int lbl)
		{
			InitializeComponent();
            if(lbl <= 0)
            {
                lbTitle.Text = "THÊM PHÒNG";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT PHÒNG";
            }
        }

        private static int lbl;
		public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
