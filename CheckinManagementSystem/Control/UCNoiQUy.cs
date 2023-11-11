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
        }

        private void UCNoiQUy_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            grdNoiQuy.DataSource = _bll.GetAllNoiQuy_Grid();
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
}
