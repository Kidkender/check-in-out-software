
using System.Windows.Forms;

namespace CheckinManagementSystem.Control
{
    public partial class UCLoaiCICO : UserControl
    {
        private static UCLoaiCICO _instance;
        public static UCLoaiCICO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLoaiCICO();
                return _instance;
            }
        }
        public UCLoaiCICO()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            EditloaiCICO ed = new EditloaiCICO(0);
            ed.StartPosition = FormStartPosition.CenterParent;
            ed.ShowDialog();
        }
    }
}
