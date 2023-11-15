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
            RefreshAll();
        }

        public void LoadData()
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            Phong p = (Phong)cboPhong.SelectedItem;
            grdHistory.DataSource = recordBLL.GetAllHistory(txtTuKhoa.Text, nhanSu?.ID, p?.ID, txtTuNgay.Value.Date, txtDenNgay.Value.Date);
            foreach (DataGridViewColumn col in grdHistory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

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
            cboNhanSu.DataSource = _nhanSuBLL.GetAllNhanSu();
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = _nhanSuBLL.GetAllPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel";

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
                    workbook = excelApp.Workbooks.Open("D:\\Code\\C#\\check-in-out-software\\CheckinManagementSystem\\Word\\formBaoCao.xlsx");

                    // Chọn trang tính cụ thể (thay "Sheet1" bằng tên trang tính bạn muốn)
                    worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];

                    int startRow = 4;
                    foreach (var rowData in data)
                    {
                        SetValueCell(worksheet.Cells[startRow, 1], startRow - 3, XlHAlign.xlHAlignCenter, false);
                        SetValueCell(worksheet.Cells[startRow, 2], rowData.HoTen, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, 3], rowData.TenPhong, XlHAlign.xlHAlignLeft, false);
                        SetValueCell(worksheet.Cells[startRow, 4], rowData.Re_DaiTien, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 5], rowData.Re_TieuTien, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 6], rowData.Re_HutThuoc, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 7], rowData.Re_DiKhac, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 8], rowData.Re_AnSang + rowData.Re_AnToi + rowData.Re_AnTrua, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 9], rowData.Re_TongThoiGianSuDung, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 10], rowData.Re_SoPhutDiQua, XlHAlign.xlHAlignRight, rowData.Re_SoPhutDiQua > 0);
                        SetValueCell(worksheet.Cells[startRow, 11], rowData.Re_TongSoLanDi, XlHAlign.xlHAlignRight, false);
                        SetValueCell(worksheet.Cells[startRow, 12], rowData.Re_SoLanDiQua, XlHAlign.xlHAlignRight, rowData.Re_SoLanDiQua > 0);
                        SetValueCell(worksheet.Cells[startRow, 13], rowData.Re_QuenCheckOut, XlHAlign.xlHAlignRight, rowData.Re_QuenCheckOut > 0);
                        startRow++;
                    }

                    // Lưu lại tệp Excel đã thay đổi
                    workbook.SaveAs(filePath);

                    // Đóng tệp Excel
                    workbook.Close(false);

                    // Giải phóng tài nguyên
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);

                    DialogResult result = MessageBox.Show("Bạn muốn mở file vừa xuất ko?", "Thông báo", MessageBoxButtons.YesNo);
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

                cboPhong.DataSource = null;
                cboPhong.Items.Clear();
                cboPhong.ValueMember = "ID";
                cboPhong.DisplayMember = "TenPhong";

                foreach (var temp in data)
                {
                    cboPhong.Items.Add(temp);
                }
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
    }
}
