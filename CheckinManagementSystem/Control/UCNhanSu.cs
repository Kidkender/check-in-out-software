using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
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
            grdNhanSu.RowTemplate.Height = 40;
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
                    List<string> result = new List<string>();
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


                        result.Add(_nhansuBLL.AddEditNhanSu(hoTen, maNhanSu, tenPhong, null));
                        currentRow++;
                    }
                    result = result.Where(t => !string.IsNullOrEmpty(t)).ToList();
                    if (result.Count > 0)
                    {
                        MessageBox.Show($"Import thất bại!\nMã nhân sự {string.Join(", ", result)} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Import thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtTuKhoa.Text = "";
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text;
            grdNhanSu.DataSource = _nhansuBLL.GetAllNhanSu_Grid().Where(t => t.HoTen.ToLower().Contains(tuKhoa.ToLower()) || t.MaNhanSu.ToLower().Contains(tuKhoa.ToLower())).ToList();
        }
    }
}
