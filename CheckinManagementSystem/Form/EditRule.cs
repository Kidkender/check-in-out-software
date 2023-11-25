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
            cboLoaiNoiQuy.Items.Add(new KeyValuePair<int, string>(0, "上下班"));
            cboLoaiNoiQuy.Items.Add(new KeyValuePair<int, string>(1, "打卡"));
            cboLoaiNoiQuy.DisplayMember = "Value";
            cboLoaiNoiQuy.SelectedIndex = 0;
            if (lbl)
            {
                this.lbl = lbl;
                lbTitle.Text = "添加规定";
            }
            else
            {
                Id = noi.ID;
                tbNoiDung.Text = noi.NoiDung;
                tbMoTa.Text = noi.XuPhat;
                lbTitle.Text = "更新规定";
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
                    MessageBox.Show("请输入规定 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(tbMoTa.Text == "")
                {
                    MessageBox.Show("请输入扣分 ！", "T通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cboLoaiNoiQuy.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择规定类型 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("请输入规定 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbMoTa.Text == "")
                {
                    MessageBox.Show("请输入扣分 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cboLoaiNoiQuy.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择规定类型 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
