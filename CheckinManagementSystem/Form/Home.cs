using CheckinManagementSystem.Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class Home : Form
	{
		static Home _obj; 
		public Home()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

		public static Home Instance
		{
			get { 
				if( _obj == null )
				{
					_obj = new Home();
				}
				return _obj;
			}
		}

		public Panel PnlContainer
		{
			get { return panelContainer; }
			set { panelContainer = value; }
		}

		public ToolStripButton BtnHistory
		{
			get { return toolSBtnHistory; } set { toolSBtnHistory = value; }
		}

		public ToolStripButton BtnInOutTime
		{
			get { return toolStripButton2; }
			set { toolStripButton2 = value; }
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			init();
			toolStripButton1.ForeColor = Color.White;
            toolStripButton1.BackColor = Color.IndianRed;

            UCCheck uc = new UCCheck();
			uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
		}

        public void RefreshFrom()
        {
            toolStripButton1.PerformClick();
        }

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			
		}

		private void toolStripDropDownButton1_Click(object sender, EventArgs e)
		{

		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			if (!Login.Instance.check)
			{
                Login.Instance.ShowDialog(this);
            }

			if (Login.Instance.check)
			{
                if (!panelContainer.Controls.Contains(UCAdmin.Instance))
                {
                    UCAdmin.Instance.Dock = DockStyle.Fill;
                    panelContainer.Controls.Add(UCAdmin.Instance);
                    UCAdmin.Instance.BringToFront();
                }
                else
                    UCAdmin.Instance.BringToFront();

                init();
                BtnLogin.ForeColor = Color.White;
                BtnHistory.BackColor = Color.IndianRed;
            }
        }

		private void init()
		{
            if (!Login.Instance.check)
            { 
               
            }    
            toolSBtnHistory.ForeColor = Color.DodgerBlue;
            toolSBtnHistory.BackColor = Color.White;

            toolStripButton2.ForeColor = Color.DodgerBlue;
            toolStripButton2.BackColor = Color.White;

            BtnLogin.ForeColor = Color.DodgerBlue;
            BtnHistory.BackColor = Color.White;

            toolStripButton1.ForeColor = Color.DodgerBlue;
            toolStripButton1.BackColor = Color.White;

            toolStripButton3.ForeColor = Color.DodgerBlue;
            toolStripButton3.BackColor = Color.White;
        }

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
            init();
            toolSBtnHistory.ForeColor = Color.White;
            toolSBtnHistory.BackColor = Color.IndianRed;

            if (!panelContainer.Controls.Contains(UCHistory.Instance))
            {
                UCHistory.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCHistory.Instance);
                UCHistory.Instance.BringToFront();
            }
            else
                UCHistory.Instance.BringToFront();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            init();
            toolStripButton2.ForeColor = Color.White;
            toolStripButton2.BackColor = Color.IndianRed;

            if (!panelContainer.Controls.Contains(UCInOut.Instance))
            {
                UCInOut.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCInOut.Instance);
                UCInOut.Instance.BringToFront();
            }
            else
                UCInOut.Instance.BringToFront();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            init();
            toolStripButton1.ForeColor = Color.White;
            toolStripButton1.BackColor = Color.IndianRed;

            if (!panelContainer.Controls.Contains(UCCheck.Instance))
            {
                UCCheck.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCCheck.Instance);
                UCCheck.Instance.BringToFront();
            }
            else
                UCCheck.Instance.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            init();
            toolStripButton3.ForeColor = Color.White;
            toolStripButton3.BackColor = Color.IndianRed;

            if (!panelContainer.Controls.Contains(UCHistoryCheck.Instance))
            {
                UCHistoryCheck.Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(UCHistoryCheck.Instance);
                UCHistoryCheck.Instance.BringToFront();
            }
            else
                UCHistoryCheck.Instance.BringToFront();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
