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
    public partial class UCNhanSu : UserControl
    {
        private static UCNhanSu _instance;
        public static UCNhanSu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNhanSu();
                return _instance;
            }
        }
        public UCNhanSu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditNS ed = new EditNS(0);
            ed.ShowDialog();
        }
    }
}
