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
                MessageBox.Show("Chọn phòng để thiết lập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Properties.Settings.Default.IDPhong = p.ID.ToString();
                Properties.Settings.Default.Save();
                MessageBox.Show("Thiết lập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
