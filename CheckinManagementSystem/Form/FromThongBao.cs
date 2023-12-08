using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
    public partial class FromThongBao : Form
    {
        public FromThongBao()
        {
            InitializeComponent();
        }

        public FromThongBao(string thongBao, string tieuDe, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            InitializeComponent();

            switch (icon)
            {
                case MessageBoxIcon.Information:
                    pictureBox1.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    pictureBox1.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    pictureBox1.Image = SystemIcons.Error.ToBitmap();
                    break;
                default:
                    break;
            }

            this.Text = tieuDe;
            label1.Text = thongBao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
