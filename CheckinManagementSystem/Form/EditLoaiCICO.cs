
using CheckinManagementSystem.BLL;
using CheckinManagementSystem.DAL;
using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class EditloaiCICO : Form
    {
        LoaiRecordBLL recordBLL = new LoaiRecordBLL();
        static EditloaiCICO _obj;
        public static EditloaiCICO Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditloaiCICO(false, new LoaiRecord());
                }
                return _obj;
            }
        }
        public EditloaiCICO(bool lbl, LoaiRecord loai = null)
        {
            InitializeComponent();
            if (lbl)
            {
                lbTitle.Text = "添加打卡类型";
                this.lbl = lbl;
            }
            else
            {
                Id = loai.ID;
                tbThoigian.Text = loai.ThoiGian.ToString();
                lbTitle.Text = "更新签到类型";
            }
        }

        private int Id;
        private bool lbl;
        public bool check = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            int sl = -1, tg = -1;
            if (lbl)
            {
                //if (tbSoLan.Text.Trim() == "")
                //{
                //    new FromThongBao("Vui lòng nhập số lần tối đa!", "Thông báo", MessageBoxIcon.Exclamation).ShowDialog();
                //}
                if (tbThoigian.Text.Trim() == "")
                {
                    new FromThongBao("请输入可用时间!", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                }
                else
                {
                    try
                    {
                        tg = int.Parse(tbThoigian.Text.Trim());

                        if (sl <= 0 || tg <= 0)
                        {
                            new FromThongBao("时间和次数必须大于0!", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                        }
                        else
                        {
                            LoaiRecord l = new LoaiRecord()
                            {
                                ID = 0,
                                MoTa = "",
                                ThoiGian = tg
                            };

                            recordBLL.AddEditLoaiRecord(l);
                            this.Close();
                        }
                    }
                    catch
                    {
                        new FromThongBao("时间格式不正确，一定是数字 ！", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                    }
                }
            }
            else
            {
                //if (tbSoLan.Text.Trim() == "")
                //{
                //    new FromThongBao("Vui lòng nhập số lần tối đa!", "Thông báo", MessageBoxIcon.Exclamation).ShowDialog();
                //}
                if (tbThoigian.Text.Trim() == "")
                {
                    new FromThongBao("请输入可用时间!", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                }
                else
                {
                    try
                    {
                        tg = int.Parse(tbThoigian.Text.Trim());

                        if (sl <= 0 || tg <= 0)
                        {
                            new FromThongBao("时间和次数必须大于0!", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                        }
                        else
                        {
                            LoaiRecord l = new LoaiRecord()
                            {
                                ID = Id,
                                MoTa = "",
                                ThoiGian = tg
                            };

                            recordBLL.AddEditLoaiRecord(l);
                            this.Close();
                        }
                    }
                    catch
                    {
                        new FromThongBao("时间格式不正确，一定是数字 ！", "通知", MessageBoxIcon.Exclamation).ShowDialog();
                    }
                }
            }
        }
    }
}
