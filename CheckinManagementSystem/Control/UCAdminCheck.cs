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
    public partial class UCAdminCheck : UserControl
    {
        RecordBLL _recordBLL = new RecordBLL();
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();

        private static UCAdminCheck _instance;
        public static UCAdminCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCAdminCheck();
                return _instance;
            }
        }
        public UCAdminCheck()
        {
            InitializeComponent();
            this.Load += UCAdminCheck_Load;
        }

        #region Method

        public void LoadData()
        {
            var data = getData();
            grdCheckOut.DataSource = data;
        }

        public List<SP_GetAllDiemDanh_Result> getData()
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            var data = _recordBLL.GetAllDiemDanh().Where(t => (nhanSu == null || nhanSu.ID == t.IdNhanSu)
                                                            && t.ThoiGianRa.HasValue
                                                            && t.ThoiGianVao.Value.Date >= txtTuNgay.Value.Date
                                                            && t.ThoiGianVao.Value.Date <= txtDenNgay.Value.Date).ToList();
            return data;
        }

        #endregion

        #region Event

        private void UCAdminCheck_Load(object sender, EventArgs e)
        {
            grdCheckOut.RowTemplate.Height = 60;
            RefreshAll();

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
            }

            foreach (DataGridViewColumn col in grdCheckOut.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (col.ValueType == typeof(DateTime?))
                {
                    col.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                }
            }
        }

        private void RefreshAll()
        {
            RefreshDataNhanSu();
            txtTuNgay.Text = "";
            txtDenNgay.Value = DateTime.Now;
            txtTuNgay.Value = DateTime.Now.AddDays(-30);
            LoadData();
        }

        private void RefreshDataNhanSu()
        {
            var data = _nhanSuBLL.GetAllNhanSu();
            data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
            cboNhanSu.DataSource = data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
            cboNhanSu.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "选择 Excel 文件的保存位置";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
                var data = getData();
                string filePath = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    // Mở tệp Excel
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    workbook = excelApp.Workbooks.Open(directory + "\\Report\\上下班.xlsx");

                    // Chọn trang tính cụ thể (thay "Sheet1" bằng tên trang tính bạn muốn)
                    worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];

                    int startRow = 4;
                    foreach (var rowData in data)
                    {
                        int col = 1;
                        SetValueCell(worksheet.Cells[startRow, col++], startRow - 3, XlHAlign.xlHAlignCenter, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.MaNhanSu, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.HoTen, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.ThoiGianVao.Value.ToString("dd/MM/yyyy HH:mm:ss"), XlHAlign.xlHAlignCenter, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.ThoiGianRa.Value.ToString("dd/MM/yyyy HH:mm:ss"), XlHAlign.xlHAlignCenter, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.ThoiGianLamViec.Replace(".", ","), XlHAlign.xlHAlignCenter, false);
                        startRow++;
                    }

                    // Lưu lại tệp Excel đã thay đổi
                    workbook.SaveAs(filePath);

                    // Đóng tệp Excel
                    workbook.Close(false);

                    // Giải phóng tài nguyên
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);

                    DialogResult result = MessageBox.Show("您想打开刚刚导出的文件吗？", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.FileName = filePath;
                        proc.Start();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
                finally
                {
                    // Đóng ứng dụng Excel và giải phóng tài nguyên
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        public void SetValueCell(dynamic cell, dynamic value, XlHAlign align, bool warning)
        {
            cell.Value = value;

            cell.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

            cell.HorizontalAlignment = align;
            if (warning)
            {
                cell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
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
                var data = _nhanSuBLL.GetAllNhanSu();
                data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower()) || t.MaNhanSu.ToLower().Contains(tempStr.ToLower())).ToList();

                cboNhanSu.DataSource = data;
                cboNhanSu.ValueMember = "ID";
                cboNhanSu.DisplayMember = "HoTen";
                Cursor.Current = Cursors.Default;
                cboNhanSu.SelectedIndex = -1;

                cboNhanSu.Text = tempStr;
                cboNhanSu.Select(cboNhanSu.Text.Length, 0);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void grdCheckOut_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdCheckOut.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        #endregion

        private void cboNhanSu_DropDownClosed(object sender, EventArgs e)
        {
            if (cboNhanSu.Items.Count == 0)
            {
                RefreshDataNhanSu();
            }
            else
            {
                if (cboNhanSu.SelectedIndex >= 0)
                {
                    if (cboNhanSu.Text.Length > 0)
                    {
                        var lst = cboNhanSu.DataSource as List<NhanSu>;
                        cboNhanSu.Text = lst[cboNhanSu.SelectedIndex].HoTen;
                    }
                }
            }
        }

        private void cboClick(object sender, EventArgs e)
        {
            var cbo = sender as ComboBox;
            cbo.DroppedDown = true;
        }
    }
}
