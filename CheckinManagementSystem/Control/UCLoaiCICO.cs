
using CheckinManagementSystem.BLL;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCLoaiCICO : UserControl
    {
        LoaiRecordBLL loai = new LoaiRecordBLL();
        private static UCLoaiCICO _instance;
        public static UCLoaiCICO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLoaiCICO();
                return _instance;
            }
        }
        public UCLoaiCICO()
        {
            InitializeComponent();
            LoadData();
            grdLoaiCICO.RowTemplate.Height = 60;

            grdLoaiCICO.RowPrePaint += grdLoaiCICO_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdLoaiCICO.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdLoaiCICO.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadData()
        {
            grdLoaiCICO.DataSource = loai.GetAllLoaiRecord_Grid();
        }

        private void grdLoaiCICO_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdLoaiCICO.Rows[e.RowIndex];
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            EditloaiCICO ed = new EditloaiCICO(true);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
            LoadData();
        }

        private void btnXuat_Click(object sender, System.EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, System.EventArgs e)
        {
            grdLoaiCICO.DataSource = loai.GetAllLoaiRecord_Grid(tbTimKiem.Text);
        }

        private void grdLoaiCICO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int? Id = (int)grdLoaiCICO["ID", e.RowIndex].Value;
                if (grdLoaiCICO.Columns[e.ColumnIndex].Name == "Delete")
                {
                    loai.DeleteLoaiRecordById(Id);
                    LoadData();
                }

                if (grdLoaiCICO.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditloaiCICO ed = new EditloaiCICO(false, loai.GetLoaiRecordById(Id));
                    ed.StartPosition = FormStartPosition.CenterParent;
                    ed.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
