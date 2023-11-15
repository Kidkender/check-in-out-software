using CheckinManagementSystem.BLL;
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
    public partial class UCAdminCheck : UserControl
    {
        RecordBLL recordBLL = new RecordBLL();
        NhanSuBLL _nhanSuBLL = new NhanSuBLL();

        private static UCAdminCheck _instance;
        public static UCAdminCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCAdminCheck();
                return _instance;
            }
        }
        public UCAdminCheck()
        {
            InitializeComponent();
        }
    }
}
