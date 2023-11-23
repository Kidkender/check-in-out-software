namespace CheckinManagementSystem
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.navbar = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolSBtnHistory = new System.Windows.Forms.ToolStripButton();
			this.BtnLogin = new System.Windows.Forms.ToolStripButton();
			this.panelContainer = new System.Windows.Forms.Panel();
			this.navbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// navbar
			// 
			this.navbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.navbar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolSBtnHistory,
            this.BtnLogin});
			this.navbar.Location = new System.Drawing.Point(3, 2);
			this.navbar.Name = "navbar";
			this.navbar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
			this.navbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.navbar.Size = new System.Drawing.Size(1676, 76);
			this.navbar.TabIndex = 0;
			this.navbar.Text = "navbar";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Padding = new System.Windows.Forms.Padding(1);
			this.toolStripButton1.Size = new System.Drawing.Size(146, 67);
			this.toolStripButton1.Text = "上下班";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.AutoSize = false;
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Padding = new System.Windows.Forms.Padding(1);
			this.toolStripButton2.Size = new System.Drawing.Size(133, 67);
			this.toolStripButton2.Text = "打卡";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Padding = new System.Windows.Forms.Padding(1);
			this.toolStripButton3.Size = new System.Drawing.Size(226, 67);
			this.toolStripButton3.Text = "上下班记录";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolSBtnHistory
			// 
			this.toolSBtnHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolSBtnHistory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolSBtnHistory.ForeColor = System.Drawing.SystemColors.Highlight;
			this.toolSBtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolSBtnHistory.Image")));
			this.toolSBtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSBtnHistory.Margin = new System.Windows.Forms.Padding(4);
			this.toolSBtnHistory.Name = "toolSBtnHistory";
			this.toolSBtnHistory.Padding = new System.Windows.Forms.Padding(1);
			this.toolSBtnHistory.Size = new System.Drawing.Size(186, 67);
			this.toolSBtnHistory.Text = "打卡记录";
			this.toolSBtnHistory.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// BtnLogin
			// 
			this.BtnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
			this.BtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Image")));
			this.BtnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(104, 67);
			this.BtnLogin.Text = "后台";
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// panelContainer
			// 
			this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
			this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContainer.Location = new System.Drawing.Point(3, 78);
			this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(1676, 826);
			this.panelContainer.TabIndex = 1;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1682, 906);
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.navbar);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(1697, 944);
			this.Name = "Home";
			this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.navbar.ResumeLayout(false);
			this.navbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip navbar;
		private System.Windows.Forms.ToolStripButton toolSBtnHistory;
		private System.Windows.Forms.ToolStripButton BtnLogin;
		private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

