using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class EditP : Form
    {
        PhongBLL _phongBLL = new PhongBLL();
        static EditP _obj;
        public static EditP Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditP(false, p);
                }
                return _obj;
            }
        }
        public EditP(bool lbl, Phong phong = null)
        {
            InitializeComponent();
            if (lbl)
            {
                lbTitle.Text = "THÊM PHÒNG";
            }
            else
            {
                lbTitle.Text = "CẬP NHẬT PHÒNG";
                Id = phong.ID;
                tbTenPhong.Text = phong.TenPhong.ToString();
                txtMoTa.Text = phong.MoTa.ToString();
                if (phong.ThoiGianVao != null)
                {
                    tbGV.Text = phong.ThoiGianVao.Split(':')[0].ToString();
                    tbPV.Text = phong.ThoiGianVao.Split(':')[1].ToString();
                }
                if (phong.ThoiGianRa != null)
                {
                    tbHR.Text = phong.ThoiGianRa.Split(':')[0].ToString();
                    tbPR.Text = phong.ThoiGianRa.Split(':')[1].ToString();
                }
            }
            this.lbl = lbl;
        }

        private int Id = 0;
        private bool lbl;
        private static Phong p;
        public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            int gv = -1, pv = -1, hr = -1, pr = -1;
            //Thêm----------------------------------------------------------------------------------------------------------------------------
            if (lbl)
            {
                if (tbTenPhong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (_phongBLL.checkExists(tbTenPhong.Text))
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() == "" || tbPV.Text.Trim() == "" || tbHR.Text.Trim() == "" || tbPR.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thời gian ra vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() != "" && tbPV.Text.Trim() != "" && tbHR.Text.Trim() != "" && tbPR.Text.Trim() != "")
                {
                    try
                    {
                        gv = int.Parse(tbGV.Text.Trim());
                        pv = int.Parse(tbPV.Text.Trim());
                        hr = int.Parse(tbHR.Text.Trim());
                        pr = int.Parse(tbPR.Text.Trim());

                        if (gv < 0 || gv > 23 || hr < 0 || hr > 23)
                        {
                            MessageBox.Show("Giờ phải lớn hơn hoặc bằng 0 và bé hơn hoặc bằng 23", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (pv < 0 || pv > 59 || pr < 0 || pr > 59)
                        {
                            MessageBox.Show("Phút phải lớn hơn hoặc bằng 0 và bé hơn hoặc bằng 59", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (gv * 60 + pv >= hr * 60 + pr)
                        {
                            MessageBox.Show("Giờ vào phải nhỏ hơn giờ ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Phong p = new Phong()
                            {
                                ID = 0,
                                MoTa = "",
                                TenPhong = tbTenPhong.Text,
                                ThoiGianRa = hr.ToString() + ":" + pr.ToString(),
                                ThoiGianVao = gv.ToString() + ":" + pv.ToString(),
                            };

                            _phongBLL.AddEditPhong(p);
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thời gian không đúng định dạng! Phải là số!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            //Chỉnh sửa --------------------------------------------------------------------------------------------------------------------------------------------
            else
            {
                var check = _phongBLL.GetPhongById(Id);
                if (tbTenPhong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbTenPhong.Text.Trim().ToLower() != check.TenPhong.Trim().ToLower() && _phongBLL.checkExists(tbTenPhong.Text))
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() == "" || tbPV.Text.Trim() == "" || tbHR.Text.Trim() == "" || tbPR.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thời gian ra vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() != "" && tbPV.Text.Trim() != "" && tbHR.Text.Trim() != "" && tbPR.Text.Trim() != "")
                {
                    try
                    {
                        gv = int.Parse(tbGV.Text.Trim());
                        pv = int.Parse(tbPV.Text.Trim());
                        hr = int.Parse(tbHR.Text.Trim());
                        pr = int.Parse(tbPR.Text.Trim());

                        if (gv < 0 || gv > 23 || hr < 0 || hr > 23)
                        {
                            MessageBox.Show("Giờ phải lớn hơn hoặc bằng 0 và bé hơn hoặc bằng 23", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (pv < 0 || pv > 59 || pr < 0 || pr > 59)
                        {
                            MessageBox.Show("Phút phải lớn hơn hoặc bằng 0 và bé hơn hoặc bằng 59", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (gv * 60 + pv >= hr * 60 + pr)
                        {
                            MessageBox.Show("Giờ vào phải nhỏ hơn giờ ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Phong p = new Phong()
                            {
                                ID = Id,
                                TenPhong = tbTenPhong.Text,
                                MoTa = txtMoTa.Text,
                                ThoiGianRa = hr.ToString() + ":" + pr.ToString(),
                                ThoiGianVao = gv.ToString() + ":" + pv.ToString(),
                            };

                            _phongBLL.AddEditPhong(p);
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thời gian không đúng định dạng! Phải là số!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
