namespace CheckinManagementSystem.Control
{
    partial class UCNoiQUy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdNoiQuy = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.danhMucRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucRoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.grdNoiQuy);
            this.panel2.Location = new System.Drawing.Point(56, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 653);
            this.panel2.TabIndex = 8;
            // 
            // grdNoiQuy
            // 
            this.grdNoiQuy.AllowUserToAddRows = false;
            this.grdNoiQuy.AllowUserToDeleteRows = false;
            this.grdNoiQuy.AutoGenerateColumns = false;
            this.grdNoiQuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNoiQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNoiQuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenRoleDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.grdNoiQuy.DataSource = this.danhMucRoleBindingSource;
            this.grdNoiQuy.Location = new System.Drawing.Point(35, 23);
            this.grdNoiQuy.Name = "grdNoiQuy";
            this.grdNoiQuy.ReadOnly = true;
            this.grdNoiQuy.RowHeadersWidth = 51;
            this.grdNoiQuy.RowTemplate.Height = 24;
            this.grdNoiQuy.Size = new System.Drawing.Size(1297, 609);
            this.grdNoiQuy.TabIndex = 0;
            this.grdNoiQuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNoiQuy_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(56, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 100);
            this.panel1.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(1237, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 47);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Image = global::CheckinManagementSystem.Properties.Resources.excel__2_;
            this.btnXuat.Location = new System.Drawing.Point(1156, 27);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(55, 47);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(344, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 47);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 45);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ NỘI QUY";
            // 
            // danhMucRoleBindingSource
            // 
            this.danhMucRoleBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.DanhMucRole);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tenRoleDataGridViewTextBoxColumn
            // 
            this.tenRoleDataGridViewTextBoxColumn.DataPropertyName = "TenRole";
            this.tenRoleDataGridViewTextBoxColumn.HeaderText = "Tên nội quy";
            this.tenRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenRoleDataGridViewTextBoxColumn.Name = "tenRoleDataGridViewTextBoxColumn";
            this.tenRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // UCNoiQUy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCNoiQUy";
            this.Size = new System.Drawing.Size(1619, 858);
            this.Load += new System.EventHandler(this.UCNoiQUy_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucRoleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdNoiQuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource danhMucRoleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
