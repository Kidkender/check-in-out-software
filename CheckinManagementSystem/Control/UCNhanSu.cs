﻿using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CheckinManagementSystem.Control
{
    public partial class UCNhanSu : UserControl
    {
        NhanSuBLL _nhansuBLL = new NhanSuBLL();
        private static UCNhanSu _instance;
        public static UCNhanSu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNhanSu();
                return _instance;
            }
        }
        public UCNhanSu()
        {
            InitializeComponent();
            LoadData();
            grdNhanSu.RowTemplate.Height = 60;

            grdNhanSu.RowPrePaint += grdNhanSu_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdNhanSu.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdNhanSu.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void LoadData()
        {
            grdNhanSu.DataSource = _nhansuBLL.GetAllNhanSu_Grid();
            RefreshDataPhong();
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = _nhansuBLL.GetAllPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "";
        }

        private void grdNhanSu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdNhanSu.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditNS ed = new EditNS(true);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
            LoadData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "选择 Excel 文件的保存位置";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Đặt tiêu đề của hộp thoại
            openFileDialog.Title = "选择文件";

            // Thiết lập bộ lọc tệp (ví dụ: chỉ cho phép chọn tệp Excel)
            openFileDialog.Filter = "Excel 文件|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;
                try
                {
                    workbook = excelApp.Workbooks.Open(openFileDialog.FileName);

                    // Chọn trang tính cụ thể (thay "Sheet1" bằng tên trang tính bạn muốn)
                    worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];

                    int startRow = 4;
                    int currentRow = startRow;
                    string failImport = "";

                    List<string> result = new List<string>();
                    while (true)
                    {
                        // Đọc dữ liệu từ cột A (STT)
                        string STT = getStringValue(((Excel.Range)worksheet.Cells[currentRow, 1]).Value);
                        if (string.IsNullOrEmpty(STT)) break;

                        // Đọc dữ liệu từ cột B (họ tên)
                        string hoTen = getStringValue(((Excel.Range)worksheet.Cells[currentRow, 2]).Value);

                        // Đọc dữ liệu từ cột C (mã nhân sự)
                        string maNhanSu = getStringValue(((Excel.Range)worksheet.Cells[currentRow, 3]).Value);

                        // Đọc dữ liệu từ cột D (tên phòng)
                        string tenPhong = getStringValue(((Excel.Range)worksheet.Cells[currentRow, 4]).Value);

                        try
                        {
                            result.Add(_nhansuBLL.AddEditNhanSu(hoTen, maNhanSu, tenPhong, null));
                        }
                        catch (Exception) { }
                        currentRow++;
                    }
                    result = result.Where(t => !string.IsNullOrEmpty(t)).ToList();
                    if (result.Count > 0)
                    {
                        new FromThongBao($"导入失败 ！\nID号{string.Join(", ", result)}已存在!", "通知", MessageBoxIcon.Information).ShowDialog();
                    }
                    else
                    {
                        new FromThongBao($"导入成功 ！", "通知", MessageBoxIcon.Information).ShowDialog();
                    }

                    LoadData();

                    // Đóng tệp Excel
                    workbook.Close(false);

                    // Giải phóng tài nguyên
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                }
                catch (Exception ex)
                {
                    new FromThongBao($"导入时有错误 ！\n{ex}", "通知", MessageBoxIcon.Warning).ShowDialog();
                }
                finally
                {
                    // Đóng ứng dụng Excel và giải phóng tài nguyên
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private string getStringValue(object cellValue)
        {
            string result = "";
            if (cellValue != null)
            {
                result = cellValue.ToString();
            }
            return result;
        }

        private void grdNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int? IdNhanSu = (int)grdNhanSu["ID", e.RowIndex].Value;
                if (grdNhanSu.Columns[e.ColumnIndex].Name == "Delete")
                {
                    _nhansuBLL.DeleteNhanSuById(IdNhanSu);
                    LoadData();
                }

                if (grdNhanSu.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditNS ed = new EditNS(false, _nhansuBLL.GetNhanSuById(IdNhanSu));
                    ed.StartPosition = FormStartPosition.CenterParent;
                    ed.ShowDialog();
                    LoadData();
                }
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
                List<Phong> data = _nhansuBLL.GetAllPhong().Where(t => t.TenPhong.ToLower().Contains(tempStr.ToLower())).ToList();

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
            txtTuKhoa.Text = "";
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text;
            int idP = 0;

            if (cboPhong.SelectedValue != null)
                idP = int.Parse(cboPhong.SelectedValue.ToString());

            var search = _nhansuBLL.GetAllNhanSu_Grid().Where(t => t.HoTen.ToLower().Contains(tuKhoa.ToLower()) || t.MaNhanSu.ToLower().Contains(tuKhoa.ToLower())).ToList();

            if (idP != 0)
                search = search.Where(t => t.IdPhong == idP).ToList();

            grdNhanSu.DataSource = search;
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }

        public void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox.SelectedIndex == -1)
                return;
        }

        private void cboPhong_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPhong.Items.Count == 0)
            {
                RefreshDataPhong();
            }
            else
            {
                if (cboPhong.SelectedIndex >= 0)
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
}
