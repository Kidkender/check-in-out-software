namespace CheckinManagementSystem
{
    partial class EditNS
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(363, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "THÔNG TIN NHÂN SỰ";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(21, 39);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(435, 45);
            this.txtMa.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã số";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(780, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 203);
            this.panel1.TabIndex = 4;
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(21, 134);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(434, 44);
            this.cboPhong.TabIndex = 2;
            this.cboPhong.Click += new System.EventHandler(this.cboPhong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thuộc Phòng";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(498, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(435, 45);
            this.txtTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nhân Sự";
            // 
            // EditNS
            // 
            this.ClientSize = new System.Drawing.Size(984, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Name = "EditNS";
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
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPhong;
    }
}