using CheckinManagementSystem.BLL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCNoiQUy : UserControl
    {
        NoiQuyBLL _bll = new NoiQuyBLL();
        private static UCNoiQUy _instance;
        public static UCNoiQUy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNoiQUy();
                return _instance;
            }
        }

        public UCNoiQUy()
        {
            InitializeComponent();
            LoadData();
            grdNoiQuy.RowTemplate.Height = 40;
            grdNoiQuy.CellFormatting += grdNoiQuy_CellFormatting;

            grdNoiQuy.RowPrePaint += grdNoiQuy_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdNoiQuy.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdNoiQuy.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void UCNoiQUy_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            grdNoiQuy.DataSource = _bll.GetAllNoiQuy_Grid();
        }

        private void grdNoiQuy_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdNoiQuy.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditRule ed = new EditRule(true);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grdNoiQuy.DataSource = _bll.GetAllNoiQuy_Grid(tbTimKiem.Text);
        }

        private void grdNoiQuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int? Id = (int)grdNoiQuy["ID", e.RowIndex].Value;
                if (grdNoiQuy.Columns[e.ColumnIndex].Name == "Delete")
                {
                    _bll.DeleteNoiQuyById(Id);
                    LoadData();
                }

                if (grdNoiQuy.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditRule ed = new EditRule(false, _bll.GetNoiQuyById(Id));
                    ed.StartPosition = FormStartPosition.CenterParent;
                    ed.ShowDialog();
                    LoadData();
                }
            }
        }

        private void grdNoiQuy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdNoiQuy.Columns[e.ColumnIndex].Name == "LoaiNoiQuy" && e.Value != null)
            {
                int loaiNoiQuyValue = (int)e.Value;

                // Chuyển đổi giá trị thành văn bản tương ứng
                switch (loaiNoiQuyValue)
                {
                    case 0:
                        e.Value = "上班";
                        break;
                    case 1:
                        e.Value = "打卡";
                        break;
                        // Thêm các trường hợp khác nếu cần thiết
                }

                // Đặt lại định dạng để hiển thị văn bản thay vì giá trị số
                e.FormattingApplied = true;
            }
        }
    }
}
