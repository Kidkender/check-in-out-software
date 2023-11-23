namespace CheckinManagementSystem
{
    partial class EditRule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRule));
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbNoiDung = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboLoaiNoiQuy = new System.Windows.Forms.ComboBox();
			this.tbMoTa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(12, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(358, 37);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "THÔNG TIN NỘI QUY";
			// 
			// tbNoiDung
			// 
			this.tbNoiDung.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNoiDung.Location = new System.Drawing.Point(21, 329);
			this.tbNoiDung.Name = "tbNoiDung";
			this.tbNoiDung.Size = new System.Drawing.Size(912, 45);
			this.tbNoiDung.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 303);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "扣分";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Firebrick;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(780, 496);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(153, 57);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cboLoaiNoiQuy);
			this.panel1.Controls.Add(this.tbMoTa);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tbNoiDung);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(12, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 568);
			this.panel1.TabIndex = 4;
			// 
			// cboLoaiNoiQuy
			// 
			this.cboLoaiNoiQuy.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboLoaiNoiQuy.FormattingEnabled = true;
			this.cboLoaiNoiQuy.Location = new System.Drawing.Point(21, 439);
			this.cboLoaiNoiQuy.Name = "cboLoaiNoiQuy";
			this.cboLoaiNoiQuy.Size = new System.Drawing.Size(911, 47);
			this.cboLoaiNoiQuy.TabIndex = 2;
			this.cboLoaiNoiQuy.Click += new System.EventHandler(this.cboLoaiNoiQuy_Click);
			// 
			// tbMoTa
			// 
			this.tbMoTa.AcceptsReturn = true;
			this.tbMoTa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMoTa.Location = new System.Drawing.Point(20, 39);
			this.tbMoTa.Multiline = true;
			this.tbMoTa.Name = "tbMoTa";
			this.tbMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbMoTa.Size = new System.Drawing.Size(912, 236);
			this.tbMoTa.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 404);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "类型";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "规定";
			// 
			// EditRule
			// 
			this.ClientSize = new System.Drawing.Size(984, 654);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbTitle);
			this.ForeColor = System.Drawing.Color.Firebrick;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditRule";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.ComboBox cboLoaiNoiQuy;
        private System.Windows.Forms.Label label4;
    }
}