using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class AdminSetPhong : Form
    {
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();

        public AdminSetPhong()
        {
            InitializeComponent();
            string idPhong = Properties.Settings.Default.IDPhong;
            RefreshDataPhong(idPhong);
        }

        private void RefreshDataPhong(string IDPhong)
        {
            var data = _nhanSuBLL.GetAllPhong();
            int index = -1;
            var Phong = data.FirstOrDefault(t => t.ID == int.Parse(IDPhong));
            if(Phong != null) 
            {
                index = data.IndexOf(Phong);
            }
            cboPhong.DataSource = data;
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = index;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Phong p = (Phong)cboPhong.SelectedItem;
            if (p == null)
            {
                new FromThongBao("选择要设置的办公室!", "通知", MessageBoxIcon.Exclamation).ShowDialog();
            }
            else
            {
                Properties.Settings.Default.IDPhong = p.ID.ToString();
                Properties.Settings.Default.Save();
                new FromThongBao("设置成功 ！", "通知", MessageBoxIcon.Information).ShowDialog();
                UCCheck.Instance.RefreshAll();
                UCInOut.Instance.RefreshAll();
                UCHistory.Instance.RefreshAll();
                UCHistoryCheck.Instance.RefreshAll();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }
    }
}
