using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
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

namespace CheckinManagementSystem
{
    public partial class UCInOut : UserControl
    {
        #region Variable

        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        CheckInOutBLL _checkInOutBLL = new CheckInOutBLL();
        RecordBLL _recordBLL = new RecordBLL();
        NoiQuyBLL _noiQuyBLL = new NoiQuyBLL();

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

        #endregion

        #region Contructor

        public UCInOut()
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

            foreach (DataGridViewColumn col in grdCheckOut.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn col in grdNoiQuy.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            #endregion
        }

        #endregion

        #region Private

        private void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataLoaiRecord();
            RefreshDataCheckOut();
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

        private void RefreshDataLoaiRecord()
        {
            cboLoaiRecord.DataSource = _recordBLL.GetAllLoaiRecord();
            cboLoaiRecord.ValueMember = "ID";
            cboLoaiRecord.DisplayMember = "TenLoaiRecord";
            cboLoaiRecord.SelectedIndex = -1;
        }

        private void RefreshDataCheckOut()
        {
            grdCheckOut.DataSource = _recordBLL.GetAllDangKy().Where(t =>/* t.ThoiGianVao.Value.Date == DateTime.Now.Date*/ true).ToList();
        }

        private void RefreshDataNoiQuy()
        {
            grdNoiQuy.Columns.Add("NoiDung", "Xử phạt");
            grdNoiQuy.Columns.Add("XuPhat", "Nội dung");
            grdNoiQuy.Columns["XuPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdNoiQuy.RowTemplate.MinimumHeight = 50;
            foreach (NoiQuy noiQuy in _noiQuyBLL.GetAllNoiQuy().Where(t => t.LoaiNoiQuy == 1).ToList())
            {
                grdNoiQuy.Rows.Add(noiQuy.NoiDung, noiQuy.XuPhat);
            }
        }

        #endregion

        #region Event

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
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower()) || t.MaNhanSu.ToLower().Contains(tempStr.ToLower())).ToList();

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

        private void cboLoaiRecord_TextUpdate(object sender, EventArgs e)
        {
            if (cboLoaiRecord.Text == string.Empty)
            {
                RefreshDataLoaiRecord();
            }
            else
            {
                string tempStr = cboLoaiRecord.Text;
                List<LoaiRecord> data = _recordBLL.GetAllLoaiRecord().Where(t => t.TenLoaiRecord.ToLower().Contains(tempStr.ToLower())).ToList();

                cboLoaiRecord.DataSource = null;
                cboLoaiRecord.Items.Clear();
                cboLoaiRecord.ValueMember = "ID";
                cboLoaiRecord.DisplayMember = "TenLoaiRecord";

                foreach (var temp in data)
                {
                    cboLoaiRecord.Items.Add(temp);
                }
                cboLoaiRecord.DroppedDown = true;
                Cursor.Current = Cursors.Default;
                cboLoaiRecord.SelectedIndex = -1;

                cboLoaiRecord.Text = tempStr;
                cboLoaiRecord.Select(cboLoaiRecord.Text.Length, 0);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            LoaiRecord loaiRecord = (LoaiRecord)cboLoaiRecord.SelectedItem;
            if (nhanSu == null)
            {
                MessageBox.Show("Vui lòng chọn nhân sự check!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (loaiRecord == null)
            {
                MessageBox.Show("Vui lòng chọn loại check!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!_recordBLL.GetAllDiemDanh().Where(t => t.IdNhanSu == nhanSu.ID && t.ThoiGianRa == null).Any())
            {
                MessageBox.Show("Nhân sự chưa được điểm danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (_checkInOutBLL.checkIsOut(nhanSu.ID, loaiRecord.ID))
            {
                MessageBox.Show("Nhân sự đã đăng ký checkout, vui lòng checkin vào trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (_checkInOutBLL.AddRecord(nhanSu.ID, loaiRecord?.ID))
                {
                    MessageBox.Show("Check thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
