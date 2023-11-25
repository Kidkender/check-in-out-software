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

namespace CheckinManagementSystem.Control
{
    public partial class UCHistoryCheck : UserControl
    {
        #region Variable

        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        CheckInOutBLL _checkInOutBLL = new CheckInOutBLL();
        RecordBLL _recordBLL = new RecordBLL();

        private static UCHistoryCheck _instance;
        public static UCHistoryCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHistoryCheck();
                return _instance;
            }
        }

        #endregion

        #region Contructor

        public UCHistoryCheck()
        {
            InitializeComponent();
            RefreshAll();
            grdCheckOut.RowTemplate.Height = 40;

            grdCheckOut.RowPrePaint += grdCheckOut_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdCheckOut.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdCheckOut.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (col.ValueType == typeof(DateTime?))
                {
                    col.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                }
            }
        }

        #endregion

        #region Private

        public void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataDiemDanh();
            RefreshDataPhong();
        }

        private void RefreshDataNhanSu()
        {
            var data = getDataNhanSu();
            data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
            cboNhanSu.DataSource = data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
            cboNhanSu.Text = "";
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = getDataPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "";
        }

        private void RefreshDataDiemDanh(int? IDNhanSu = null, int? IDPhong = null)
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            var data = _recordBLL.GetAllDiemDanh().Where(t => (IDNhanSu == null || IDNhanSu == t.IdNhanSu)
                                                        && (IDPhong == null || t.IdPhong == IDPhong)
                                                        && t.ThoiGianRa.HasValue
                                                        && t.IdPhong == int.Parse(idPhong)).OrderByDescending(t => t.ThoiGianVao).ToList();
            grdCheckOut.DataSource = data;
        }

        private List<NhanSu> getDataNhanSu()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllNhanSu().Where(t => t.IdPhong == int.Parse(idPhong)).ToList();
        }

        private List<Phong> getDataPhong()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllPhong().Where(t => t.ID == int.Parse(idPhong)).ToList();
        }

        #endregion

        #region Event

        public void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox.SelectedIndex == -1)
                return;
        }

        private void grdCheckOut_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdCheckOut.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            Phong p = (Phong)cboPhong.SelectedItem;
            RefreshDataDiemDanh(nhanSu?.ID, p?.ID);
        }

        private void cboNhanSu_TextUpdate(object sender, EventArgs e)
        {
            if (cboNhanSu.Text == string.Empty)
            {
                RefreshDataNhanSu();
            }
            else
            {
                string tempStr = cboNhanSu.Text;
                var data = getDataNhanSu();
                data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower()) || t.MaNhanSu.ToLower().Contains(tempStr.ToLower())).ToList();

                cboNhanSu.DataSource = data;
                cboNhanSu.ValueMember = "ID";
                cboNhanSu.DisplayMember = "HoTen";
                cboNhanSu.DroppedDown = true;
                cboNhanSu.MaxDropDownItems = 5;
                Cursor.Current = Cursors.Default;
                cboNhanSu.SelectedIndex = -1;

                cboNhanSu.Text = tempStr;
                cboNhanSu.Select(cboNhanSu.Text.Length, 0);
            }
        }

        private void cboPhong_TextUpdate(object sender, EventArgs e)
        {
            if (cboPhong.Text == string.Empty)
            {
                RefreshDataPhong();
            }
            else
            {
                string tempStr = cboPhong.Text;
                List<Phong> data = getDataPhong().Where(t => t.TenPhong.ToLower().Contains(tempStr.ToLower())).ToList();

                cboPhong.DataSource = data;
                cboPhong.ValueMember = "ID";
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.DroppedDown = true;
                cboPhong.MaxDropDownItems = 5;
                Cursor.Current = Cursors.Default;
                cboPhong.SelectedIndex = -1;

                cboPhong.Text = tempStr;
                cboPhong.Select(cboPhong.Text.Length, 0);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        #endregion

        private void cboNhanSu_Click(object sender, EventArgs e)
        {
            cboNhanSu.DroppedDown = true;
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }

        private void cboNhanSu_DropDownClosed(object sender, EventArgs e)
        {
            if (cboNhanSu.Items.Count == 0)
            {
                RefreshDataNhanSu();
            }
            else
            {
                if (cboNhanSu.Text.Length > 0)
                {
                    var lst = cboNhanSu.DataSource as List<NhanSu>;
                    cboNhanSu.Text = lst[cboNhanSu.SelectedIndex].HoTen;
                }
            }
        }

        private void cboPhong_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPhong.Items.Count == 0)
            {
                RefreshDataPhong();
            }
            else
            {
                if (cboPhong.Text.Length > 0)
                {
                    var lst = cboPhong.DataSource as List<Phong>;
                    cboPhong.Text = lst[cboPhong.SelectedIndex].TenPhong;
                }
            }
        }
    }
}
