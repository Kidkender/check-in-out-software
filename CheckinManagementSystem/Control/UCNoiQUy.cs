using System;
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCNoiQUy : UserControl
    {

        private static UCNoiQUy _instance;
        public static UCNoiQUy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNoiQUy();
                return _instance;
            }
        }

        public UCNoiQUy()
        {
            InitializeComponent();
        }

        private void UCNoiQUy_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
