using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCCheck : UserControl
    {
        #region Variable

        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        CheckInOutBLL _checkInOutBLL = new CheckInOutBLL();
        RecordBLL _recordBLL = new RecordBLL();
        NoiQuyBLL _noiQuyBLL = new NoiQuyBLL();

        private static UCCheck _instance;
        public static UCCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCCheck();
                return _instance;
            }
        }

        #endregion

        #region Contructor

        public UCCheck()
        {
            InitializeComponent();

            #region Init control

            RefreshAll();
            RefreshDataNoiQuy();
            grdCheckOut.RowTemplate.Height = 40;
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)grdCheckOut.Columns["Checkin"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.Red;
            c.Width = 300;

            #endregion
        }

        #endregion

        #region Private

        private void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataDiemDanh();
        }

        private void RefreshDataNoiQuy()
        {
            grdNoiQuy.Columns.Add("NoiDung", "Nội Dung");
            grdNoiQuy.Columns.Add("XuPhat", "Xử Phạt");
            grdNoiQuy.Columns["XuPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdNoiQuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdNoiQuy.RowTemplate.MinimumHeight = 50;
            foreach (NoiQuy noiQuy in _noiQuyBLL.GetAllNoiQuy().ToList())
            {
                grdNoiQuy.Rows.Add(noiQuy.NoiDung, noiQuy.XuPhat);
            }
        }

        private void RefreshDataNhanSu()
        {
            var data = _nhanSuBLL.GetAllNhanSu();
            data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
            cboNhanSu.DataSource = data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
        }

        private void RefreshDataDiemDanh()
        {
            var data = _recordBLL.GetAllDiemDanh().Where(t => /*t.ThoiGianVao.Value.Date == DateTime.Now.Date &&*/ t.ThoiGianRa == null).ToList();
            grdCheckOut.DataSource = data;
        }

        #endregion

        #region Event

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            if (_recordBLL.GetAllDiemDanh().Where(t => /*t.ThoiGianVao.Value.Date == DateTime.Now.Date &&*/ t.IdNhanSu == nhanSu?.ID && t.ThoiGianRa == null).Any())
            {
                MessageBox.Show("Nhân sự đã được điểm danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (_checkInOutBLL.AddRecord(nhanSu.ID, 0))
                {
                    MessageBox.Show("Điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAll();
                }
                else
                    MessageBox.Show("Check thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshAll();
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
                var data = _nhanSuBLL.GetAllNhanSu();
                data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower())).ToList();

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

        private void grdCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (grdCheckOut.Columns[e.ColumnIndex].Name == "CheckIn")
                {
                    int IDRecord = (int)grdCheckOut["ID", e.RowIndex].Value;

                    if (_checkInOutBLL.AddRecord(null, null, 1, IDRecord))
                    {
                        MessageBox.Show("Check thành công");
                        RefreshAll();
                    }
                }
            }
        }

        #endregion
    }
}
