using System;
using System.Windows.Forms;

namespace CheckinManagementSystem
{
	public partial class UCHistory : UserControl
    {
        private Label label1;
        private ListView listView1;
        private static UCHistory _instance;
		public static UCHistory Instance
		{
			get
			{
				if (_instance == null)
					_instance = new UCHistory();
				return _instance;
			}
		}
		public UCHistory()
		{
			InitializeComponent();
		}

		private void UCHistory_Load(object sender, EventArgs e)
		{

		}

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ CHCKIN/CHECKOUT";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(65, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1402, 613);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UCHistory
            // 
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(1527, 805);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
