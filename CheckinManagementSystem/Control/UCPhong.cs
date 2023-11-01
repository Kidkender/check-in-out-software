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
    public partial class UCPhong : UserControl
    {
        private static UCPhong _instance;
        public static UCPhong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCPhong();
                return _instance;
            }
        }
        public UCPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditP ed = new EditP(0);
            ed.ShowDialog(this);
        }
    }
}
