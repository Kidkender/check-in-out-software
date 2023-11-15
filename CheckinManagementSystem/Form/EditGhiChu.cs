using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class EditGhiChu : Form
	{
        RecordBLL _recordBLL = new RecordBLL();
        int? _ID;
        public EditGhiChu()
        {
            InitializeComponent();

        }

        public EditGhiChu(int? Id, string GhiChu = "")
        {
            InitializeComponent();
            _ID = Id;
            txtGhiChu.Text = GhiChu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _recordBLL.UpdateGhiChu(_ID, txtGhiChu.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
