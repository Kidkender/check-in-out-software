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

		public ToolStripButton BtnInOutTime
		{
			get { return toolStripButton1; } set { toolStripButton1 = value; }
		}

		public ToolStripButton BtnInOutCa
		{
			get { return toolStripButton2; }
			set { toolStripButton2 = value; }
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			init();
			toolStripButton1.ForeColor = Color.Red;

			UCInOut uc = new UCInOut();
			uc.Dock = DockStyle.Fill;
			panelContainer.Controls.Add(uc);
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			
		}

		private void toolStripDropDownButton1_Click(object sender, EventArgs e)
		{

		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.ShowDialog();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			init();
			toolStripButton2.ForeColor = Color.Red;
			if (!panelContainer.Controls.Contains(UCInOutCA.Instance))
			{
				
				UCInOutCA.Instance.Dock = DockStyle.Fill;
				panelContainer.Controls.Add(UCInOutCA.Instance);
				UCInOutCA.Instance.BringToFront();
			}
			else
				UCInOutCA.Instance.BringToFront();

		}

		private void init()
		{
			toolStripButton1.ForeColor = Color.DodgerBlue;
			toolStripButton2.ForeColor = Color.DodgerBlue;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			init();
			toolStripButton1.ForeColor = Color.Red;
			if (!panelContainer.Controls.Contains(UCInOut.Instance))
			{

				UCInOut.Instance.Dock = DockStyle.Fill;
				panelContainer.Controls.Add(UCInOut.Instance);
				UCInOut.Instance.BringToFront();
			}
			else
				UCInOut.Instance.BringToFront();
		}
	}
}
