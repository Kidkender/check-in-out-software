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
    public partial class UCCheck : UserControl
    {
        private static UCCheck _instance;
        public static UCCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCCheck();
                return _instance;
            }
        }
        public UCCheck()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
