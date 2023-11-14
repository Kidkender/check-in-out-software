
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
            grdLoaiCICO.RowTemplate.Height = 40;
        }

        private void LoadData()
        {
            grdLoaiCICO.DataSource = loai.GetAllLoaiRecord_Grid();
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
