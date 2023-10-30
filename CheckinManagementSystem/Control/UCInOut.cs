using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class UCInOut : UserControl
    {
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        List<NhanSu> _data = null;
        private static UCInOut _instance;
        public static UCInOut Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCInOut();
                return _instance;
            }
        }

        public UCInOut()
        {
            InitializeComponent();

            #region Init control

            RefreshDataNhanSu();

            #endregion
        }

        private void RefreshDataNhanSu()
        {
            _data = _nhanSuBLL.GetAllNhanSu();
            cboNhanSu.DataSource = _data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
        }

        #region Event

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            if (nhanSu == null)
            {
                MessageBox.Show("Vui lòng chọn nhân sự điểm danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (_nhanSuBLL.AddRecord(nhanSu.ID))
                    MessageBox.Show("Điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Điểm danh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private void cboNhanSu_TextUpdate(object sender, EventArgs e)
        {
            if (cboNhanSu.Text == string.Empty)
            {
                RefreshDataNhanSu();
            }
            else
            {
                string tempStr = cboNhanSu.Text;
                List<NhanSu> data = _data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower())).ToList();

                cboNhanSu.DataSource = null;
                cboNhanSu.Items.Clear();
                cboNhanSu.ValueMember = "ID";
                cboNhanSu.DisplayMember = "HoTen";

                foreach (var temp in data)
                {
                    cboNhanSu.Items.Add(temp);
                }
                cboNhanSu.DroppedDown = true;
                Cursor.Current = Cursors.Default;
                cboNhanSu.SelectedIndex = -1;
              
                cboNhanSu.Text = tempStr;
                cboNhanSu.Select(cboNhanSu.Text.Length, 0);
            }
        }
    }
}
