using CheckinManagementSystem.BLL;
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
        }

        public void LoadData()
        {
            grdNhanSu.DataSource = _nhansuBLL.GetAllNhanSu_Grid();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditNS ed = new EditNS(true);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Đặt tiêu đề của hộp thoại
            openFileDialog.Title = "Chọn tệp";

            // Thiết lập bộ lọc tệp (ví dụ: chỉ cho phép chọn tệp Excel)
            openFileDialog.Filter = "Tệp Excel|*.xlsx;*.xls";

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
                    int result = 0;
                    while (true)
                    {
                        // Đọc dữ liệu từ cột A (STT)
                        double? STT = ((Excel.Range)worksheet.Cells[currentRow, 1]).Value;
                        if (STT == null) break;

                        // Đọc dữ liệu từ cột B (họ tên)
                        string hoTen = ((Excel.Range)worksheet.Cells[currentRow, 2]).Value;

                        // Đọc dữ liệu từ cột C (mã nhân sự)
                        string maNhanSu = ((Excel.Range)worksheet.Cells[currentRow, 3]).Value;

                        // Đọc dữ liệu từ cột D (tên phòng)
                        string tenPhong = ((Excel.Range)worksheet.Cells[currentRow, 4]).Value;

                        
                        result = result + _nhansuBLL.AddEditNhanSu(hoTen, maNhanSu, tenPhong, null);
                        currentRow++;
                    }
                    if (result > 0)
                    {
                        MessageBox.Show("Import thành công");
                    }
                    else
                    {
                        MessageBox.Show("Import thất bại");
                    }

                    // Đóng tệp Excel
                    workbook.Close(false);

                    // Giải phóng tài nguyên
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int? IdNhanSu = (int)grdNhanSu["ID", e.RowIndex].Value;
            if (grdNhanSu.Columns[e.ColumnIndex].Name == "Delete")
            {
                _nhansuBLL.DeleteNhanSuById(IdNhanSu);
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
}
