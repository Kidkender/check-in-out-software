using CheckinManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCPhong : UserControl
    {
        PhongBLL _phongBLL = new PhongBLL();
        private static UCPhong _instance;
        public static UCPhong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCPhong();
                return _instance;
            }
        }
        public UCPhong()
        {
            InitializeComponent();
            LoadData();
            grdPhong.RowTemplate.Height = 40;
            foreach (DataGridViewColumn col in grdPhong.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditP ed = new EditP(true);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog(this);
            LoadData();
        }

        public void LoadData()
        {
            grdPhong.DataSource = _phongBLL.GetAllPhong_Grid();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grdPhong.DataSource = _phongBLL.GetAllPhong_Grid(tbTimKiem.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            grdPhong.DataSource = _phongBLL.GetAllPhong_Grid("");
        }

        private void grdPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int? IdPhong = (int)grdPhong["ID", e.RowIndex].Value;
                if (grdPhong.Columns[e.ColumnIndex].Name == "Delete")
                {
                    _phongBLL.DeletePhongById(IdPhong);
                    LoadData();
                }

                if (grdPhong.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditP ed = new EditP(false, _phongBLL.GetPhongById(IdPhong));
                    ed.StartPosition = FormStartPosition.CenterParent;
                    ed.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
