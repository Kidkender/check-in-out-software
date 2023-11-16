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
                    _ns = ns;
                }
            }
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = _nhanSuBLL.GetAllPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
        }

        private static bool lbl;
        private static NhanSu ns;
        private NhanSu _ns;
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
                string result = _nhanSuBLL.AddEditNhanSu(ten, maNhanSu, phong.TenPhong, _ns?.ID);
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show($"Mã nhân sự {result} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }
    }
}
