using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class UCInOut : UserControl
	{
		private static UCInOut _instance;
		public static UCInOut Instance
		{
			get
			{
				if (_instance == null)
					_instance = new UCInOut();
				return _instance;
			}
		}

		public UCInOut()
		{
			InitializeComponent();
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
