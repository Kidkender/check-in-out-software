﻿namespace CheckinManagementSystem
{
    partial class ChangePassword
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMKM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNLMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMKHT = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(271, 37);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbMKM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbNLMK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbMKHT);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(19, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 388);
            this.panel1.TabIndex = 5;
            // 
            // tbMKM
            // 
            this.tbMKM.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMKM.Location = new System.Drawing.Point(22, 139);
            this.tbMKM.Name = "tbMKM";
            this.tbMKM.Size = new System.Drawing.Size(435, 45);
            this.tbMKM.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu mới";
            // 
            // tbNLMK
            // 
            this.tbNLMK.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNLMK.Location = new System.Drawing.Point(21, 240);
            this.tbNLMK.Name = "tbNLMK";
            this.tbNLMK.Size = new System.Drawing.Size(435, 45);
            this.tbNLMK.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // tbMKHT
            // 
            this.tbMKHT.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMKHT.Location = new System.Drawing.Point(21, 39);
            this.tbMKHT.Name = "tbMKHT";
            this.tbMKHT.Size = new System.Drawing.Size(435, 45);
            this.tbMKHT.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(303, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu hiện tại";
            // 
            // ChangePassword
            // 
            this.ClientSize = new System.Drawing.Size(521, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Name = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMKM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNLMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMKHT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
    }
}