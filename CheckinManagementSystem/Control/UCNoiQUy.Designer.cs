﻿namespace CheckinManagementSystem.Control
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.grdNoiQuy = new System.Windows.Forms.DataGridView();
			this.noiQuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.tbTimKiem = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xuPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiNoiQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.noiQuyBindingSource)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.207459F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73427F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.05827F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1611, 858);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.743142F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.202F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.054863F));
			this.tableLayoutPanel4.Controls.Add(this.grdNoiQuy, 1, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 216);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1605, 640);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// grdNoiQuy
			// 
			this.grdNoiQuy.AllowUserToAddRows = false;
			this.grdNoiQuy.AllowUserToDeleteRows = false;
			this.grdNoiQuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdNoiQuy.AutoGenerateColumns = false;
			this.grdNoiQuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdNoiQuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdNoiQuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.grdNoiQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdNoiQuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.noiDungDataGridViewTextBoxColumn,
            this.xuPhatDataGridViewTextBoxColumn,
            this.LoaiNoiQuy,
            this.Edit,
            this.Delete});
			this.grdNoiQuy.DataSource = this.noiQuyBindingSource;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdNoiQuy.DefaultCellStyle = dataGridViewCellStyle8;
			this.grdNoiQuy.EnableHeadersVisualStyles = false;
			this.grdNoiQuy.Location = new System.Drawing.Point(47, 2);
			this.grdNoiQuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grdNoiQuy.Name = "grdNoiQuy";
			this.grdNoiQuy.ReadOnly = true;
			this.grdNoiQuy.RowHeadersWidth = 51;
			this.grdNoiQuy.RowTemplate.Height = 30;
			this.grdNoiQuy.Size = new System.Drawing.Size(1505, 636);
			this.grdNoiQuy.TabIndex = 14;
			this.grdNoiQuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNoiQuy_CellContentClick);
			// 
			// noiQuyBindingSource
			// 
			this.noiQuyBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.NoiQuy);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.743142F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.202F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.054863F));
			this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 81);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1605, 131);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.btnTimKiem);
			this.panel1.Controls.Add(this.tbTimKiem);
			this.panel1.Location = new System.Drawing.Point(47, 14);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1505, 103);
			this.panel1.TabIndex = 13;
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnThem.BackColor = System.Drawing.Color.Green;
			this.btnThem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnThem.Location = new System.Drawing.Point(456, 28);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(124, 46);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTimKiem.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnTimKiem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTimKiem.Location = new System.Drawing.Point(326, 28);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(124, 46);
			this.btnTimKiem.TabIndex = 1;
			this.btnTimKiem.Text = "搜索";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// tbTimKiem
			// 
			this.tbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tbTimKiem.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTimKiem.Location = new System.Drawing.Point(17, 30);
			this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbTimKiem.Name = "tbTimKiem";
			this.tbTimKiem.Size = new System.Drawing.Size(303, 45);
			this.tbTimKiem.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.743142F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.202F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.054863F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1605, 75);
			this.tableLayoutPanel2.TabIndex = 0;
			this.tableLayoutPanel2.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SimSun", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Brown;
			this.label1.Location = new System.Drawing.Point(47, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 94);
			this.label1.TabIndex = 12;
			this.label1.Text = "规定管理";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// noiDungDataGridViewTextBoxColumn
			// 
			this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "XuPhat";
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.noiDungDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.noiDungDataGridViewTextBoxColumn.HeaderText = "规定";
			this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
			this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// xuPhatDataGridViewTextBoxColumn
			// 
			this.xuPhatDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.xuPhatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.xuPhatDataGridViewTextBoxColumn.HeaderText = "扣分";
			this.xuPhatDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.xuPhatDataGridViewTextBoxColumn.Name = "xuPhatDataGridViewTextBoxColumn";
			this.xuPhatDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// LoaiNoiQuy
			// 
			this.LoaiNoiQuy.DataPropertyName = "LoaiNoiQuy";
			this.LoaiNoiQuy.HeaderText = "类型";
			this.LoaiNoiQuy.MinimumWidth = 6;
			this.LoaiNoiQuy.Name = "LoaiNoiQuy";
			this.LoaiNoiQuy.ReadOnly = true;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "";
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			this.Edit.ReadOnly = true;
			this.Edit.Text = "修改";
			this.Edit.UseColumnTextForButtonValue = true;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "";
			this.Delete.MinimumWidth = 6;
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Text = "删除";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// UCNoiQUy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UCNoiQUy";
			this.Size = new System.Drawing.Size(1611, 858);
			this.Load += new System.EventHandler(this.UCNoiQUy_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.noiQuyBindingSource)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.DataGridView grdNoiQuy;
        private System.Windows.Forms.BindingSource noiQuyBindingSource;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn xuPhatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNoiQuy;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}
