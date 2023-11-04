using CheckinManagementSystem.BLL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCNoiQUy : UserControl
    {
        NoiQuyBLL _noiQuyBLL = new NoiQuyBLL();
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
        }

        private void UCNoiQUy_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditRule ed = new EditRule(true, null);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            grdNoiQuy.DataSource = _noiQuyBLL.GetAllNoiQuy();
        }

        private void grdNoiQuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int? IdNoiQuy = (int)grdNoiQuy["ID", e.RowIndex].Value;
            if (grdNoiQuy.Columns[e.ColumnIndex].Name == "Delete")
            {
                _noiQuyBLL.DeleteNoiQuyById(IdNoiQuy);
            }

            if (grdNoiQuy.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditRule ed = new EditRule(false, _noiQuyBLL.GetNoiQuyById(IdNoiQuy));
                ed.StartPosition = FormStartPosition.CenterParent;
                ed.ShowDialog();
                LoadData();
            }
        }
    }
}
