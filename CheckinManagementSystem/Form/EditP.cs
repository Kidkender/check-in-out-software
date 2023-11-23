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
                lbTitle.Text = "添加办公室";
            }
            else
            {
                lbTitle.Text = "更新办公室";
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
                    MessageBox.Show("请输入办公室！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (_phongBLL.checkExists(tbTenPhong.Text))
                {
                    MessageBox.Show("办公室已存在 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() == "" || tbPV.Text.Trim() == "" || tbHR.Text.Trim() == "" || tbPR.Text.Trim() == "")
                {
                    MessageBox.Show("请输入出入时间 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            MessageBox.Show("小时必须大于或等于 0 且小于或等于 23", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (pv < 0 || pv > 59 || pr < 0 || pr > 59)
                        {
                            MessageBox.Show("分钟必须大于或等于 0 且小于或等于 59", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (gv * 60 + pv >= hr * 60 + pr)
                        {
                            MessageBox.Show("进入时间必须小于出去时间", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("时间格式不正确，一定是数字 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            //Chỉnh sửa --------------------------------------------------------------------------------------------------------------------------------------------
            else
            {
                var check = _phongBLL.GetPhongById(Id);
                if (tbTenPhong.Text.Trim() == "")
                {
                    MessageBox.Show("请输入办公室 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbTenPhong.Text.Trim().ToLower() != check.TenPhong.Trim().ToLower() && _phongBLL.checkExists(tbTenPhong.Text))
                {
                    MessageBox.Show("办公室已存在 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tbGV.Text.Trim() == "" || tbPV.Text.Trim() == "" || tbHR.Text.Trim() == "" || tbPR.Text.Trim() == "")
                {
                    MessageBox.Show("请输入出入时间 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            MessageBox.Show("小时必须大于或等于 0 且小于或等于 23", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (pv < 0 || pv > 59 || pr < 0 || pr > 59)
                        {
                            MessageBox.Show("分钟必须大于或等于 0 且小于或等于 59", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (gv * 60 + pv >= hr * 60 + pr)
                        {
                            MessageBox.Show("进入时间必须小于出去时间", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("时间格式不正确，一定是数字 ！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
