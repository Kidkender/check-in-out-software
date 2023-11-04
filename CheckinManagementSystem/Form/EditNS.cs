using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class EditNS : Form
    {
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        static EditNS _obj;
        public static EditNS Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditNS(lbl, ns);
                }
                return _obj;
            }
        }
        public EditNS(bool lbl, NhanSu ns = null)
        {
            InitializeComponent();
            RefreshDataPhong();
            if (lbl)
            {
                lbTitle.Text = "THÊM NHÂN SỰ";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT NHÂN SỰ";
                if (ns != null)
                {
                    txtTen.Text = ns.HoTen;
                    txtMa.Text = ns.MaNhanSu;
                    cboPhong.SelectedValue = ns.IdPhong;
                }
            }
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = _nhanSuBLL.GetAlPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
        }

        private static bool lbl;
        private static NhanSu ns;
        public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maNhanSu = txtMa.Text;
            string ten = txtTen.Text;
            Phong phong = (Phong)cboPhong.SelectedItem;

            if (maNhanSu == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ten == null)
            {
                MessageBox.Show("Vui lòng nhập tên nhân nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (phong == null)
            {
                MessageBox.Show("Chọn loại phòng nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _nhanSuBLL.AddEditNhanSu(ten, maNhanSu, phong.TenPhong, ns?.ID);
            }
            this.Close();
        }
    }
}
