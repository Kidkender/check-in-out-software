using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditRule : Form
	{
        NoiQuyBLL _noiQuyBLL = new NoiQuyBLL();
        static EditRule _obj;
        public static EditRule Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditRule(lbl, rl);
                }
                return _obj;
            }
        }
        public EditRule(bool lbl, DanhMucRole rl)
		{
			InitializeComponent();
            this.txtMoTa.AutoSize = false;
            this.txtMoTa.Size = new System.Drawing.Size(912, 200);
            if (lbl)
            {
                lbTitle.Text = "THÊM NỘI QUY";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT NỘI QUY";
                txtTenRole.Text = rl.TenRole;
                txtMoTa.Text = rl.MoTa;
            }
        }

        private static bool lbl;
        private static DanhMucRole rl;
		public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tenRole = txtTenRole.Text;
            string moTa = txtMoTa.Text;

            if (tenRole == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (moTa == null)
            {
                MessageBox.Show("Vui lòng nhập tên nhân nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _noiQuyBLL.AddEditNoiQuy(tenRole, moTa, rl?.ID);
            }

            this.Close();
        }

        private void EditRule_Load(object sender, EventArgs e)
        {
            
        }
    }
}
