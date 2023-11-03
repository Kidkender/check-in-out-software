using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditloaiCICO : Form
	{
        static EditloaiCICO _obj;
        public static EditloaiCICO Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditloaiCICO(lbl);
                }
                return _obj;
            }
        }
        public EditloaiCICO(int lbl)
		{
			InitializeComponent();
            if(lbl <= 0)
            {
                lbTitle.Text = "THÊM LOẠI CHECKIN/CHECKOUT";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT LOẠI CHECKIN/CHECKOUT";
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
