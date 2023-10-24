using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class UCInOutCA : UserControl
	{
		private static UCInOutCA _instance;
		public static UCInOutCA Instance
		{
			get
			{
				if (_instance == null)
					_instance = new UCInOutCA();
				return _instance;
			}
		}
		public UCInOutCA()
		{
			InitializeComponent();
		}

		private void UCInOutCA_Load(object sender, EventArgs e)
		{

		}
	}
}
