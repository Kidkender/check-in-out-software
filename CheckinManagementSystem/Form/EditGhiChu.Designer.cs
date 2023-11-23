namespace CheckinManagementSystem
{
    partial class EditGhiChu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGhiChu));
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(733, 50);
			this.label7.TabIndex = 0;
			this.label7.Text = "更新备注";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
			this.panel2.Controls.Add(this.txtGhiChu);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(733, 251);
			this.panel2.TabIndex = 1;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGhiChu.Location = new System.Drawing.Point(0, 0);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGhiChu.Size = new System.Drawing.Size(731, 249);
			this.txtGhiChu.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 367);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Firebrick;
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnOK.Location = new System.Drawing.Point(199, 310);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(167, 54);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "出去";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancel.Location = new System.Drawing.Point(372, 310);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(156, 54);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// EditGhiChu
			// 
			this.ClientSize = new System.Drawing.Size(739, 367);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditGhiChu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}