using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditNS : Form
	{
        static EditNS _obj;
        public static EditNS Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditNS(lbl);
                }
                return _obj;
            }
        }
        public EditNS(int lbl)
		{
			InitializeComponent();
            if(lbl <= 0)
            {
                lbTitle.Text = "THÊM NHÂN SỰ";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT NHÂN SỰ";
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
