namespace CheckinManagementSystem.Control
{
    partial class UCHistoryCheck
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.grdCheckOut = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdLoaiRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGianVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGianRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGianLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPGetAllDiemDanhResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cboPhong = new System.Windows.Forms.ComboBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cboNhanSu = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sPGetAllDiemDanhResultBindingSource)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Firebrick;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1433, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "上下班记录";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.950311F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.78261F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.26708F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1439, 902);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.884857F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.34682F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.698534F));
			this.tableLayoutPanel2.Controls.Add(this.grdCheckOut, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 207);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1433, 692);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// grdCheckOut
			// 
			this.grdCheckOut.AllowUserToAddRows = false;
			this.grdCheckOut.AllowUserToDeleteRows = false;
			this.grdCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdCheckOut.AutoGenerateColumns = false;
			this.grdCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdCheckOut.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdNhanSu,
            this.IdLoaiRecord,
            this.MaNhanSu,
            this.hoTenDataGridViewTextBoxColumn,
            this.tenLoaiRecordDataGridViewTextBoxColumn,
            this.ThoiGianVao,
            this.ThoiGianRa,
            this.ThoiGianLamViec});
			this.grdCheckOut.DataSource = this.sPGetAllDiemDanhResultBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdCheckOut.DefaultCellStyle = dataGridViewCellStyle5;
			this.grdCheckOut.EnableHeadersVisualStyles = false;
			this.grdCheckOut.Location = new System.Drawing.Point(73, 3);
			this.grdCheckOut.Name = "grdCheckOut";
			this.grdCheckOut.ReadOnly = true;
			this.grdCheckOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.grdCheckOut.RowHeadersWidth = 51;
			this.grdCheckOut.RowTemplate.Height = 24;
			this.grdCheckOut.Size = new System.Drawing.Size(1303, 686);
			this.grdCheckOut.TabIndex = 7;
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
			// IdNhanSu
			// 
			this.IdNhanSu.DataPropertyName = "IdNhanSu";
			this.IdNhanSu.HeaderText = "IdNhanSu";
			this.IdNhanSu.MinimumWidth = 6;
			this.IdNhanSu.Name = "IdNhanSu";
			this.IdNhanSu.ReadOnly = true;
			this.IdNhanSu.Visible = false;
			// 
			// IdLoaiRecord
			// 
			this.IdLoaiRecord.DataPropertyName = "IdLoaiRecord";
			this.IdLoaiRecord.HeaderText = "IdLoaiRecord";
			this.IdLoaiRecord.MinimumWidth = 6;
			this.IdLoaiRecord.Name = "IdLoaiRecord";
			this.IdLoaiRecord.ReadOnly = true;
			this.IdLoaiRecord.Visible = false;
			// 
			// MaNhanSu
			// 
			this.MaNhanSu.DataPropertyName = "MaNhanSu";
			this.MaNhanSu.HeaderText = "ID号";
			this.MaNhanSu.MinimumWidth = 6;
			this.MaNhanSu.Name = "MaNhanSu";
			this.MaNhanSu.ReadOnly = true;
			// 
			// hoTenDataGridViewTextBoxColumn
			// 
			this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
			this.hoTenDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
			this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tenLoaiRecordDataGridViewTextBoxColumn
			// 
			this.tenLoaiRecordDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiRecord";
			this.tenLoaiRecordDataGridViewTextBoxColumn.HeaderText = "Loại";
			this.tenLoaiRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenLoaiRecordDataGridViewTextBoxColumn.Name = "tenLoaiRecordDataGridViewTextBoxColumn";
			this.tenLoaiRecordDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenLoaiRecordDataGridViewTextBoxColumn.Visible = false;
			// 
			// ThoiGianVao
			// 
			this.ThoiGianVao.DataPropertyName = "ThoiGianVao";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ThoiGianVao.DefaultCellStyle = dataGridViewCellStyle2;
			this.ThoiGianVao.HeaderText = "上班时间";
			this.ThoiGianVao.MinimumWidth = 6;
			this.ThoiGianVao.Name = "ThoiGianVao";
			this.ThoiGianVao.ReadOnly = true;
			// 
			// ThoiGianRa
			// 
			this.ThoiGianRa.DataPropertyName = "ThoiGianRa";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ThoiGianRa.DefaultCellStyle = dataGridViewCellStyle3;
			this.ThoiGianRa.HeaderText = "下班时间";
			this.ThoiGianRa.MinimumWidth = 6;
			this.ThoiGianRa.Name = "ThoiGianRa";
			this.ThoiGianRa.ReadOnly = true;
			// 
			// ThoiGianLamViec
			// 
			this.ThoiGianLamViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ThoiGianLamViec.DataPropertyName = "ThoiGianLamViec";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ThoiGianLamViec.DefaultCellStyle = dataGridViewCellStyle4;
			this.ThoiGianLamViec.HeaderText = "总时间";
			this.ThoiGianLamViec.MinimumWidth = 6;
			this.ThoiGianLamViec.Name = "ThoiGianLamViec";
			this.ThoiGianLamViec.ReadOnly = true;
			this.ThoiGianLamViec.Width = 178;
			// 
			// sPGetAllDiemDanhResultBindingSource
			// 
			this.sPGetAllDiemDanhResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllDiemDanh_Result);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.884857F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.48639F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.628751F));
			this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 74);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1433, 127);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cboPhong);
			this.panel1.Controls.Add(this.btnLamMoi);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cboNhanSu);
			this.panel1.Location = new System.Drawing.Point(73, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1305, 107);
			this.panel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Firebrick;
			this.label3.Location = new System.Drawing.Point(384, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "办公室";
			// 
			// cboPhong
			// 
			this.cboPhong.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPhong.FormattingEnabled = true;
			this.cboPhong.Location = new System.Drawing.Point(389, 47);
			this.cboPhong.Name = "cboPhong";
			this.cboPhong.Size = new System.Drawing.Size(302, 39);
			this.cboPhong.TabIndex = 7;
			this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
			this.cboPhong.TextUpdate += new System.EventHandler(this.cboPhong_TextUpdate);
			this.cboPhong.DropDownClosed += new System.EventHandler(this.cboPhong_DropDownClosed);
			this.cboPhong.Click += new System.EventHandler(this.cboPhong_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(861, 40);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(126, 46);
			this.btnLamMoi.TabIndex = 6;
			this.btnLamMoi.Text = "刷新";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
			this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(715, 40);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(126, 46);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Firebrick;
			this.label2.Location = new System.Drawing.Point(58, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "员工";
			// 
			// cboNhanSu
			// 
			this.cboNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboNhanSu.FormattingEnabled = true;
			this.cboNhanSu.Location = new System.Drawing.Point(63, 47);
			this.cboNhanSu.Name = "cboNhanSu";
			this.cboNhanSu.Size = new System.Drawing.Size(302, 39);
			this.cboNhanSu.TabIndex = 0;
			this.cboNhanSu.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
			this.cboNhanSu.TextUpdate += new System.EventHandler(this.cboNhanSu_TextUpdate);
			this.cboNhanSu.DropDownClosed += new System.EventHandler(this.cboNhanSu_DropDownClosed);
			this.cboNhanSu.Click += new System.EventHandler(this.cboNhanSu_Click);
			// 
			// UCHistoryCheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UCHistoryCheck";
			this.Size = new System.Drawing.Size(1439, 902);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sPGetAllDiemDanhResultBindingSource)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanSu;
        private System.Windows.Forms.BindingSource sPGetAllDiemDanhResultBindingSource;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView grdCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhong;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanSu;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiRecord;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanSu;
		private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiRecordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianVao;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianRa;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianLamViec;
	}
}
