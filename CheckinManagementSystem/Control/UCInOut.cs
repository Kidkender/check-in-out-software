﻿using CheckinManagementSystem.BLL;
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

            grdCheckOut.RowPrePaint += grdCheckOut_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
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

            foreach (DataGridViewColumn col in grdNoiQuy.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            #endregion
        }

        #endregion

        #region Private

        public void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataLoaiRecord();
            RefreshDataCheckOut();
            RefreshDataNoiQuy();
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

        private void RefreshDataLoaiRecord()
        {
            cboLoaiRecord.DataSource = _recordBLL.GetAllLoaiRecord();
            cboLoaiRecord.ValueMember = "ID";
            cboLoaiRecord.DisplayMember = "TenLoaiRecord";
            cboLoaiRecord.SelectedIndex = -1;
            cboLoaiRecord.Text = "";
        }

        private void RefreshDataCheckOut()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            grdCheckOut.DataSource = _recordBLL.GetAllDangKy().Where(t =>/* t.ThoiGianVao.Value.Date == DateTime.Now.Date*/ true && t.IdPhong == int.Parse(idPhong)).ToList();
        }

        private void RefreshDataNoiQuy()
        {
            grdNoiQuy.Rows.Clear();
            grdNoiQuy.Columns.Clear();
            grdNoiQuy.Columns.Add("XuPhat", "Nội quy");
            grdNoiQuy.Columns.Add("NoiDung", "Xử phạt");
            grdNoiQuy.Columns["XuPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdNoiQuy.Columns["NoiDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdNoiQuy.RowTemplate.MinimumHeight = 50;

            foreach (NoiQuy noiQuy in _noiQuyBLL.GetAllNoiQuy().Where(t => t.LoaiNoiQuy == 1).ToList())
            {
                grdNoiQuy.Rows.Add(noiQuy.XuPhat, noiQuy.NoiDung);
            }
        }

        private List<NhanSu> getDataNhanSu()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllNhanSu().Where(t => t.IdPhong == int.Parse(idPhong)).ToList();
        }

        #endregion

        #region Event

        private void grdCheckOut_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdCheckOut.Rows[e.RowIndex];
                row.Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
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

                cboLoaiRecord.DataSource = data;
                cboLoaiRecord.ValueMember = "ID";
                cboLoaiRecord.DisplayMember = "TenLoaiRecord";
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
            else if (_checkInOutBLL.checkIsOut(nhanSu.ID))
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

        private void cboNhanSu_Click(object sender, EventArgs e)
        {
            cboNhanSu.DroppedDown = true;
        }

        private void cboLoaiRecord_Click(object sender, EventArgs e)
        {
            cboLoaiRecord.DroppedDown = true;
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

        private void cboLoaiRecord_DropDownClosed(object sender, EventArgs e)
        {
            if (cboLoaiRecord.Items.Count == 0)
            {
                RefreshDataLoaiRecord();
            }
            else
            {
                if (cboLoaiRecord.Text.Length > 0)
                {
                    var lst = cboLoaiRecord.DataSource as List<LoaiRecord>;
                    cboLoaiRecord.Text = lst[cboLoaiRecord.SelectedIndex].TenLoaiRecord;
                }
            }
        }
    }
}
