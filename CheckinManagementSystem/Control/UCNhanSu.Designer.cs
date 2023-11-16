namespace CheckinManagementSystem.Control
{
    partial class UCNhanSu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grdNhanSu = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanSuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sPGetAllNhanSuResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sPGetAllNhanSuResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllNhanSuResultBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllNhanSuResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.512761F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.82599F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1549, 862);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.212435F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.67661F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.147764F));
            this.tableLayoutPanel4.Controls.Add(this.grdNhanSu, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 219);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1543, 640);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // grdNhanSu
            // 
            this.grdNhanSu.AllowUserToAddRows = false;
            this.grdNhanSu.AllowUserToDeleteRows = false;
            this.grdNhanSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNhanSu.AutoGenerateColumns = false;
            this.grdNhanSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNhanSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNhanSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.maNhanSuDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.idPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.grdNhanSu.DataSource = this.sPGetAllNhanSuResultBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNhanSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdNhanSu.EnableHeadersVisualStyles = false;
            this.grdNhanSu.Location = new System.Drawing.Point(52, 3);
            this.grdNhanSu.Name = "grdNhanSu";
            this.grdNhanSu.ReadOnly = true;
            this.grdNhanSu.RowHeadersWidth = 51;
            this.grdNhanSu.RowTemplate.Height = 24;
            this.grdNhanSu.Size = new System.Drawing.Size(1423, 634);
            this.grdNhanSu.TabIndex = 1;
            this.grdNhanSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNhanSu_CellContentClick);
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
            // maNhanSuDataGridViewTextBoxColumn
            // 
            this.maNhanSuDataGridViewTextBoxColumn.DataPropertyName = "MaNhanSu";
            this.maNhanSuDataGridViewTextBoxColumn.HeaderText = "Mã nhân sự";
            this.maNhanSuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanSuDataGridViewTextBoxColumn.Name = "maNhanSuDataGridViewTextBoxColumn";
            this.maNhanSuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Visible = false;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPhongDataGridViewTextBoxColumn
            // 
            this.idPhongDataGridViewTextBoxColumn.DataPropertyName = "IdPhong";
            this.idPhongDataGridViewTextBoxColumn.HeaderText = "IdPhong";
            this.idPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPhongDataGridViewTextBoxColumn.Name = "idPhongDataGridViewTextBoxColumn";
            this.idPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPhongDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Sửa";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // sPGetAllNhanSuResultBindingSource
            // 
            this.sPGetAllNhanSuResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllNhanSu_Result);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.212435F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.80622F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.018147F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1543, 128);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblLabel);
            this.panel1.Controls.Add(this.cboPhong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTuKhoa);
            this.panel1.Location = new System.Drawing.Point(52, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 122);
            this.panel1.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(822, 53);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 47);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.BackgroundImage = global::CheckinManagementSystem.Properties.Resources.excel_import;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Location = new System.Drawing.Point(1166, 57);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(55, 47);
            this.btnImport.TabIndex = 7;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(370, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thuộc Phòng";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Brown;
            this.lblLabel.Location = new System.Drawing.Point(31, 23);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(81, 23);
            this.lblLabel.TabIndex = 5;
            this.lblLabel.Text = "Từ khóa";
            // 
            // cboPhong
            // 
            this.cboPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(374, 53);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(270, 45);
            this.cboPhong.TabIndex = 4;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            this.cboPhong.TextUpdate += new System.EventHandler(this.cboPhong_TextUpdate);
            this.cboPhong.Click += new System.EventHandler(this.cboPhong_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(1237, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 47);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(672, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 47);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(35, 53);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(303, 45);
            this.txtTuKhoa.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.212435F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.1658F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.62176F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1543, 76);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1169, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sPGetAllNhanSuResultBindingSource1
            // 
            this.sPGetAllNhanSuResultBindingSource1.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllNhanSu_Result);
            // 
            // nhanSuBindingSource
            // 
            this.nhanSuBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.NhanSu);
            // 
            // UCNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCNhanSu";
            this.Size = new System.Drawing.Size(1549, 862);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllNhanSuResultBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllNhanSuResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nhanSuBindingSource;
        private System.Windows.Forms.BindingSource sPGetAllNhanSuResultBindingSource;
        private System.Windows.Forms.BindingSource sPGetAllNhanSuResultBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView grdNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanSuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
