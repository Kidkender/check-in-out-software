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
    public partial class UCAdmin : UserControl
    {
        private static UCAdmin _instance;
        public static UCAdmin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCAdmin();
                return _instance;
            }
        }
        public UCAdmin()
        {
            InitializeComponent();
        }
        
        private void Init()
        {
            btnCICO.BackColor = System.Drawing.Color.MistyRose;
            btnNhanSu.BackColor = System.Drawing.Color.MistyRose;
            btnPhong.BackColor = System.Drawing.Color.MistyRose;
            BTNoiQuy.BackColor = System.Drawing.Color.MistyRose;
            btnLoaiCICO.BackColor = System.Drawing.Color.MistyRose;
            btnCheck.BackColor = System.Drawing.Color.MistyRose;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Init();
            btnPhong.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCPhong.Instance))
            {
                UCPhong.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCPhong.Instance);
                UCPhong.Instance.BringToFront();
            }
            else
                UCPhong.Instance.BringToFront();
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            Init();
            btnNhanSu.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCNhanSu.Instance))
            {
                UCNhanSu.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCNhanSu.Instance);
                UCNhanSu.Instance.BringToFront();
            }
            else
                UCNhanSu.Instance.BringToFront();
        }

        private void btnCICO_Click(object sender, EventArgs e)
        {
            Init();
            btnCICO.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCCICO.Instance))
            {
                UCCICO.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCCICO.Instance);
                UCCICO.Instance.BringToFront();
            }
            else
                UCCICO.Instance.BringToFront();
        }

        private void btnLoaiCICO_Click(object sender, EventArgs e)
        {
            Init();
            btnLoaiCICO.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCLoaiCICO.Instance))
            {
                UCLoaiCICO.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCLoaiCICO.Instance);
                UCLoaiCICO.Instance.BringToFront();
            }
            else
                UCLoaiCICO.Instance.BringToFront();
        }

        private void BTNoiQuy_Click(object sender, EventArgs e)
        {
            Init();
            BTNoiQuy.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCNoiQUy.Instance))
            {
                UCNoiQUy.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCNoiQUy.Instance);
                UCNoiQUy.Instance.BringToFront();
            }
            else
                UCNoiQUy.Instance.BringToFront();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login.Instance.check = false;
            UCAdmin.Instance.SendToBack();
            Home.Instance.RefreshFrom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword ed = new ChangePassword();
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Init();
            btnCheck.BackColor = System.Drawing.Color.LightGray;

            if (!panelContainer.Controls.Contains(UCAdminCheck.Instance))
            {
                UCAdminCheck.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCAdminCheck.Instance);
                UCAdminCheck.Instance.BringToFront();
            }
            else
                UCAdminCheck.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminSetPhong form = new AdminSetPhong();
            form.ShowDialog();
        }
    }
}
