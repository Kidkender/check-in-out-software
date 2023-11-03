using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditRule : Form
	{
        static EditRule _obj;
        public static EditRule Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditRule(lbl);
                }
                return _obj;
            }
        }
        public EditRule(int lbl)
		{
			InitializeComponent();
            this.description.AutoSize = false;
            this.description.Size = new System.Drawing.Size(912, 200);
            if (lbl <= 0)
            {
                lbTitle.Text = "THÊM NỘI QUY";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT NỘI QUY";
            }
        }

        private static int lbl;
		public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void EditRule_Load(object sender, EventArgs e)
        {
            
        }
    }
}
