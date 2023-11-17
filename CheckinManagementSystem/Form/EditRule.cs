using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
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
            cboLoaiNoiQuy.Items.Add(new KeyValuePair<int, string>(0, "Điểm danh"));
            cboLoaiNoiQuy.Items.Add(new KeyValuePair<int, string>(1, "Checkin giữa giờ"));
            cboLoaiNoiQuy.DisplayMember = "Value";
            cboLoaiNoiQuy.SelectedIndex = 0;
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
                cboLoaiNoiQuy.SelectedIndex = noi.LoaiNoiQuy.GetValueOrDefault(0);
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
                else if (cboLoaiNoiQuy.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại nội quy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NoiQuy p = new NoiQuy()
                    {
                        NoiDung = tbNoiDung.Text,
                        XuPhat = tbMoTa.Text,
                        LoaiNoiQuy = cboLoaiNoiQuy.SelectedIndex
                    };

                    _bll.AddEditNoiQuy(p);
                    this.Close();
                    UCInOut.Instance.RefreshAll();
                    UCCheck.Instance.RefreshAll();
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
                else if (cboLoaiNoiQuy.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại nội quy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NoiQuy p = new NoiQuy()
                    {
                        ID = Id,
                        NoiDung = tbNoiDung.Text,
                        XuPhat = tbMoTa.Text,
                        LoaiNoiQuy = cboLoaiNoiQuy.SelectedIndex
                    };

                    _bll.AddEditNoiQuy(p);
                    this.Close();
                    UCInOut.Instance.RefreshAll();
                    UCCheck.Instance.RefreshAll();
                }
            }    
        }

        private void cboLoaiNoiQuy_Click(object sender, EventArgs e)
        {
            cboLoaiNoiQuy.DroppedDown = true;
        }
    }
}
