using CheckinManagementSystem.BLL;
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
        NhanSuBLL nhansuBLL = new NhanSuBLL();

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

            LoadData();
        }

        public void LoadData()
        {
            grdHistory.DataSource = recordBLL.GetAllHistory(null, null, null, null);
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
                var data = recordBLL.GetAllHistory(null, null, null, null);
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
                        SetValueCell(worksheet.Cells[startRow, 1], startRow - 3);
                        SetValueCell(worksheet.Cells[startRow, 2], rowData.HoTen);
                        SetValueCell(worksheet.Cells[startRow, 3], rowData.TenPhong);
                        SetValueCell(worksheet.Cells[startRow, 4], rowData.Re_DaiTien + rowData.Re_TieuTien + rowData.Re_HutThuoc + rowData.Re_DiKhac + rowData.Re_AnSang + rowData.Re_AnTrua + rowData.Re_AnToi);
                        SetValueCell(worksheet.Cells[startRow, 5], rowData.Re_DaiTien);
                        SetValueCell(worksheet.Cells[startRow, 6], rowData.Re_TieuTien);
                        SetValueCell(worksheet.Cells[startRow, 7], rowData.Re_HutThuoc);
                        SetValueCell(worksheet.Cells[startRow, 8], rowData.Re_DiKhac);
                        SetValueCell(worksheet.Cells[startRow, 9], rowData.Re_AnSang + rowData.Re_AnToi + rowData.Re_AnTrua);
                        SetValueCell(worksheet.Cells[startRow, 10], rowData.Re_SoLanDiQua);
                        SetValueCell(worksheet.Cells[startRow, 11], rowData.Re_SoPhutDiQua);
                        SetValueCell(worksheet.Cells[startRow, 12], rowData.Re_TongThoiGianSuDung);
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
                        Process process = new Process();
                        process.StartInfo.FileName = filePath; // Đường dẫn đến tệp thực thi
                        process.Start();
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

        public void SetValueCell(dynamic cell, dynamic value)
        {
            cell.Value = value;

            cell.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            cell.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
