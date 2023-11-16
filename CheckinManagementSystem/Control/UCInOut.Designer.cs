namespace CheckinManagementSystem
{
	partial class UCInOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdNoiQuy = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdCheckOut = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoaiRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiRecord = new System.Windows.Forms.ComboBox();
            this.cboNhanSu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPGetAllDangKyResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.grdNoiQuy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1725, 923);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdNoiQuy
            // 
            this.grdNoiQuy.AllowUserToAddRows = false;
            this.grdNoiQuy.AllowUserToDeleteRows = false;
            this.grdNoiQuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNoiQuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdNoiQuy.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNoiQuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdNoiQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNoiQuy.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdNoiQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNoiQuy.EnableHeadersVisualStyles = false;
            this.grdNoiQuy.Location = new System.Drawing.Point(1296, 2);
            this.grdNoiQuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdNoiQuy.Name = "grdNoiQuy";
            this.grdNoiQuy.ReadOnly = true;
            this.grdNoiQuy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNoiQuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdNoiQuy.RowHeadersWidth = 51;
            this.grdNoiQuy.RowTemplate.Height = 24;
            this.grdNoiQuy.Size = new System.Drawing.Size(426, 919);
            this.grdNoiQuy.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grdCheckOut, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.652126F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.07961F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46892F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.79935F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1287, 919);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grdCheckOut
            // 
            this.grdCheckOut.AllowUserToAddRows = false;
            this.grdCheckOut.AllowUserToDeleteRows = false;
            this.grdCheckOut.AutoGenerateColumns = false;
            this.grdCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCheckOut.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdNhanSu,
            this.IdLoaiRecord,
            this.MaNhanSu,
            this.hoTenDataGridViewTextBoxColumn,
            this.tenLoaiRecordDataGridViewTextBoxColumn,
            this.ThoiGianVao,
            this.CheckIn});
            this.grdCheckOut.DataSource = this.sPGetAllDangKyResultBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCheckOut.DefaultCellStyle = dataGridViewCellStyle13;
            this.grdCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCheckOut.EnableHeadersVisualStyles = false;
            this.grdCheckOut.Location = new System.Drawing.Point(3, 444);
            this.grdCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCheckOut.Name = "grdCheckOut";
            this.grdCheckOut.ReadOnly = true;
            this.grdCheckOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdCheckOut.RowHeadersWidth = 51;
            this.grdCheckOut.RowTemplate.Height = 24;
            this.grdCheckOut.Size = new System.Drawing.Size(1281, 473);
            this.grdCheckOut.TabIndex = 6;
            this.grdCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCheckOut_CellContentClick);
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
            this.MaNhanSu.HeaderText = "Mã nhân sự";
            this.MaNhanSu.MinimumWidth = 6;
            this.MaNhanSu.Name = "MaNhanSu";
            this.MaNhanSu.ReadOnly = true;
            // 
            // ThoiGianVao
            // 
            this.ThoiGianVao.DataPropertyName = "ThoiGianVao";
            this.ThoiGianVao.HeaderText = "Thời gian";
            this.ThoiGianVao.MinimumWidth = 6;
            this.ThoiGianVao.Name = "ThoiGianVao";
            this.ThoiGianVao.ReadOnly = true;
            // 
            // CheckIn
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckIn.DefaultCellStyle = dataGridViewCellStyle12;
            this.CheckIn.HeaderText = "CheckIn";
            this.CheckIn.MinimumWidth = 6;
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Text = "CheckIn";
            this.CheckIn.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLamMoi);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Location = new System.Drawing.Point(4, 350);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 88);
            this.panel3.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLamMoi.Location = new System.Drawing.Point(754, 14);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(259, 58);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(341, 14);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(259, 58);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cboLoaiRecord);
            this.panel4.Controls.Add(this.cboNhanSu);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(4, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(1279, 277);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã NV + Họ và tên";
            // 
            // cboLoaiRecord
            // 
            this.cboLoaiRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiRecord.FormattingEnabled = true;
            this.cboLoaiRecord.Location = new System.Drawing.Point(101, 194);
            this.cboLoaiRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiRecord.Name = "cboLoaiRecord";
            this.cboLoaiRecord.Size = new System.Drawing.Size(1075, 47);
            this.cboLoaiRecord.TabIndex = 3;
            this.cboLoaiRecord.TextUpdate += new System.EventHandler(this.cboLoaiRecord_TextUpdate);
            this.cboLoaiRecord.Click += new System.EventHandler(this.cboLoaiRecord_Click);
            // 
            // cboNhanSu
            // 
            this.cboNhanSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhanSu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanSu.FormattingEnabled = true;
            this.cboNhanSu.Location = new System.Drawing.Point(101, 66);
            this.cboNhanSu.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhanSu.Name = "cboNhanSu";
            this.cboNhanSu.Size = new System.Drawing.Size(1075, 47);
            this.cboNhanSu.TabIndex = 2;
            this.cboNhanSu.TextUpdate += new System.EventHandler(this.cboNhanSu_TextUpdate);
            this.cboNhanSu.Click += new System.EventHandler(this.cboNhanSu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1279, 61);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHECK IN/OUT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
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
            // 
            // sPGetAllDangKyResultBindingSource
            // 
            this.sPGetAllDangKyResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllDangKy_Result);
            // 
            // UCInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCInOut";
            this.Size = new System.Drawing.Size(1725, 923);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoiQuy)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiRecord;
        private System.Windows.Forms.ComboBox cboNhanSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView grdCheckOut;
        private System.Windows.Forms.BindingSource sPGetAllDangKyResultBindingSource;
        private System.Windows.Forms.DataGridView grdNoiQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiRecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianVao;
        private System.Windows.Forms.DataGridViewButtonColumn CheckIn;
    }
}
