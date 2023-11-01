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
    public partial class UCCICO : UserControl
    {
        private static UCCICO _instance;
        public static UCCICO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCCICO();
                return _instance;
            }
        }
        public UCCICO()
        {
            InitializeComponent();
        }
    }
}
