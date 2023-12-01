using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CheckinManagementSystem.Control
{
    public partial class UCCICO : UserControl
    {
        RecordBLL recordBLL = new RecordBLL();
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();

        private static UCCICO _instance;
        public static UCCICO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCCICO();
                return _instance;
            }
        }
        public UCCICO()
        {
            InitializeComponent();
            this.Load += UCCICO_Load;
        }
        private void UCCICO_Load(object sender, EventArgs e)
        {
            grdHistory.RowTemplate.Height = 40;
            grdHistory.RowPrePaint += grdHistory_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdHistory.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdHistory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            RefreshAll();
        }

        #region Method

        public void LoadData()
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            Phong p = (Phong)cboPhong.SelectedItem;
            grdHistory.DataSource = recordBLL.GetAllHistory(txtTuKhoa.Text, nhanSu?.ID, p?.ID, txtTuNgay.Value.Date, txtDenNgay.Value.Date);
        }

        #endregion

        #region Event

        private void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataPhong();
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

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = _nhanSuBLL.GetAllPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "";
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
                Phong p = (Phong)cboPhong.SelectedItem;
                var data = recordBLL.GetAllHistory(txtTuKhoa.Text, nhanSu?.ID, p?.ID, txtTuNgay.Value, txtDenNgay.Value);
                string filePath = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    // Mở tệp Excel
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    workbook = excelApp.Workbooks.Open(directory + "\\Report\\签到表.xlsx");

                    // Chọn trang tính cụ thể (thay "Sheet1" bằng tên trang tính bạn muốn)
                    worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];

                    int startRow = 4;
                    foreach (var rowData in data)
                    {
                        int col = 1;
                        SetValueCell(worksheet.Cells[startRow, col++], startRow - 3, XlHAlign.xlHAlignCenter, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.MaNhanSu, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.HoTen, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.TenPhong, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_DaiTien, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_TieuTien, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_HutThuoc, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_DiKhac, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_AnSang + rowData.Re_AnToi + rowData.Re_AnTrua, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_TongThoiGianSuDung, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_SoPhutDiQua, XlHAlign.xlHAlignRight, rowData.Re_SoPhutDiQua > 0);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_TongSoLanDi, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_SoLanDiQua, XlHAlign.xlHAlignRight, rowData.Re_SoLanDiQua > 0);
                        //SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_QuenCheckOut, XlHAlign.xlHAlignRight, rowData.Re_QuenCheckOut > 0);
                        SetValueCell(worksheet.Cells[startRow, col++], rowData.Re_SoLanGhiChu, XlHAlign.xlHAlignRight, rowData.Re_SoLanGhiChu > 0);
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
                    Console.WriteLine("故障: " + ex.Message);
                }
                finally
                {
                    // Đóng ứng dụng Excel và giải phóng tài nguyên
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

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
            else
            {
                cell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
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
                cboNhanSu.DroppedDown = true;
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
                List<Phong> data = _nhanSuBLL.GetAllPhong().Where(t => t.TenPhong.ToLower().Contains(tempStr.ToLower())).ToList();

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

        private void grdHistory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdHistory.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        public void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox.SelectedIndex == -1)
                return;
        }

        #endregion

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }

        private void cboNhanSu_Click(object sender, EventArgs e)
        {
            cboNhanSu.DroppedDown = true;
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
    }
}
