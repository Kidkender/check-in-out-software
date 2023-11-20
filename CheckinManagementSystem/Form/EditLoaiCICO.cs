
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
                lbTitle.Text = "THÊM LOẠI CHECKIN/CHECKOUT";
                this.lbl = lbl;
            }
            else
            {
                Id = loai.ID;
                tbThoigian.Text = loai.ThoiGian.ToString();
                lbTitle.Text = "CẬP NHẬT LOẠI CHECKIN/CHECKOUT";
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
                //    MessageBox.Show("Vui lòng nhập số lần tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                if (tbThoigian.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thời gian cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        tg = int.Parse(tbThoigian.Text.Trim());

                        if (sl <= 0 || tg <= 0)
                        {
                            MessageBox.Show("Thời gian và số lần phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Thời gian và số lần phải là định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                //if (tbSoLan.Text.Trim() == "")
                //{
                //    MessageBox.Show("Vui lòng nhập số lần tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                if (tbThoigian.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thời gian cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        tg = int.Parse(tbThoigian.Text.Trim());

                        if (sl <= 0 || tg <= 0)
                        {
                            MessageBox.Show("Thời gian và số lần phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Thời gian và số lần phải là định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
