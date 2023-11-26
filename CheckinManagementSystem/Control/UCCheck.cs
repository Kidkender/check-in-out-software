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
            RefreshDataDiemDanh();
            RefreshDataNoiQuy();
        }

        private void RefreshDataNoiQuy()
        {
            grdNoiQuy.Rows.Clear();
            grdNoiQuy.Columns.Clear();
            grdNoiQuy.Columns.Add("XuPhat", "规定");
            grdNoiQuy.Columns.Add("NoiDung", "扣分");
            grdNoiQuy.Columns["XuPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdNoiQuy.Columns["NoiDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdNoiQuy.RowTemplate.MinimumHeight = 50;
            foreach (NoiQuy noiQuy in _noiQuyBLL.GetAllNoiQuy().Where(t => t.LoaiNoiQuy == 0).ToList())
            {
                grdNoiQuy.Rows.Add(noiQuy.XuPhat, noiQuy.NoiDung);
            }
            string idPhong = Properties.Settings.Default.IDPhong;
            lblTenPhong.Text = _nhanSuBLL.GetAllPhong().FirstOrDefault(t => t.ID.ToString() == idPhong)?.TenPhong;
        }

        private void RefreshDataNhanSu()
        {
            var data = getDataNhanSu();
            data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
            cboNhanSu.DataSource = data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.Text = "";
            cboNhanSu.SelectedIndex = -1;
        }

        private void RefreshDataDiemDanh()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            var data = _recordBLL.GetAllDiemDanh().Where(t => /*t.ThoiGianVao.Value.Date == DateTime.Now.Date &&*/ t.ThoiGianRa == null && t.IdPhong == int.Parse(idPhong)).ToList();
            grdCheckOut.DataSource = data;
        }

        private List<NhanSu> getDataNhanSu()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllNhanSu().Where(t => t.IdPhong == int.Parse(idPhong)).ToList();
        }

        #endregion

        #region Event

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            if (nhanSu == null)
            {
                MessageBox.Show("请选择员工 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_recordBLL.GetAllDiemDanh().Where(t => t.IdNhanSu == nhanSu?.ID && t.ThoiGianRa == null).Any())
            {
                MessageBox.Show("员工已上班！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (_recordBLL.checkNhanSuGanNhat(nhanSu.ID))
            {
                MessageBox.Show("- 员工已经下班 ！\n\n- 必须要用自己的ID和姓名来打卡 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (_checkInOutBLL.AddRecord(nhanSu.ID, 0))
                {
                    MessageBox.Show("操作成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAll();
                }
                else
                    MessageBox.Show("操作失败!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var data = getDataNhanSu();
                data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower()) || t.MaNhanSu.ToLower().Contains(tempStr.ToLower())).ToList();

                cboNhanSu.DataSource = data;
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
                    int IdNhanSu = (int)grdCheckOut["IdNhanSu", e.RowIndex].Value;

                    if (_recordBLL.GetAllDangKy().Where(t => t.IdNhanSu == IdNhanSu && t.ThoiGianRa == null).Any())
                    {
                        MessageBox.Show("员工出去还没进入. 请先打进入 !", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (_checkInOutBLL.AddRecord(null, null, 1, IDRecord))
                    {
                        MessageBox.Show("操作成功！");
                        RefreshAll();
                    }
                }
            }
        }

        private void grdCheckOut_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdCheckOut.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void cboNhanSu_Click(object sender, EventArgs e)
        {
            cboNhanSu.DroppedDown = true;
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

        #endregion
    }
}
