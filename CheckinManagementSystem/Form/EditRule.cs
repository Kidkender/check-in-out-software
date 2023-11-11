using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditRule : Form
	{
        NoiQuyBLL _bll = new NoiQuyBLL();
        static EditRule _obj;
        public static EditRule Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditRule(false, new NoiQuy());
                }
                return _obj;
            }
        }
        public EditRule(bool lbl, NoiQuy noi = null)
		{
			InitializeComponent();
            this.tbMoTa.AutoSize = false;
            this.tbMoTa.Size = new System.Drawing.Size(912, 200);
            if (lbl)
            {
                this.lbl = lbl;
                lbTitle.Text = "THÊM NỘI QUY";
            }
            else
            {
                Id = noi.ID;
                tbNoiDung.Text = noi.NoiDung;
                tbMoTa.Text = noi.XuPhat;
                lbTitle.Text = "CẬP NHẬT NỘI QUY";
            }
        }

        private int Id;
        private bool lbl;
		public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbl)
            {
                if(tbNoiDung.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nội quy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(tbMoTa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập xử phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   
                else
                {
                    NoiQuy p = new NoiQuy()
                    {
                        NoiDung = tbNoiDung.Text,
                        XuPhat = tbMoTa.Text,
                    };

                    _bll.AddEditNoiQuy(p);
                    this.Close();
                }
            }
            else
            {

                if (tbNoiDung.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nội quy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbMoTa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập xử phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NoiQuy p = new NoiQuy()
                    {
                        ID = Id,
                        NoiDung = tbNoiDung.Text,
                        XuPhat = tbMoTa.Text,
                    };

                    _bll.AddEditNoiQuy(p);
                    this.Close();
                }
            }    
            this.Close();
        }

        private void EditRule_Load(object sender, EventArgs e)
        {
            
        }
    }
}
