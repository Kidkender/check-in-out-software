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
                lbTitle.Text = "添加员工";
            }
            else
            {
                lbTitle.Text = "更新员工";
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
                new FromThongBao("请输入ID号，姓名，办公室！", "通知", MessageBoxIcon.Exclamation).ShowDialog();
            }
            else if (ten == null)
            {
                new FromThongBao("请输入姓名 ！", "通知", MessageBoxIcon.Exclamation).ShowDialog();
            }
            else if (phong == null)
            {
                new FromThongBao("请选择办公室 ！", "通知", MessageBoxIcon.Exclamation).ShowDialog();
            }
            else
            {
                string result = _nhanSuBLL.AddEditNhanSu(ten, maNhanSu, phong.TenPhong, _ns?.ID);
                if (!string.IsNullOrEmpty(result))
                {
                    new FromThongBao($"ID号 {result} 已存在!", "通知", MessageBoxIcon.Information).ShowDialog();
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
