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
    public partial class UCHistoryCheck : UserControl
    {
        private static UCHistoryCheck _instance;
        public static UCHistoryCheck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHistoryCheck();
                return _instance;
            }
        }
        public UCHistoryCheck()
        {
            InitializeComponent();
        }
    }
}
