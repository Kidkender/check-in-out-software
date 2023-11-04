namespace CheckinManagementSystem.Control
{
    partial class UCCICO
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
            this.grdHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnXuat = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanSuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reAnSangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reAnTruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reAnToiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reTieuTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDaiTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reHutThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDiKhacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reSoLanDiQuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reSoPhutDiQuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPQuanLyCheckInResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPQuanLyCheckInResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.grdHistory);
            this.panel2.Location = new System.Drawing.Point(65, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1654, 653);
            this.panel2.TabIndex = 8;
            // 
            // grdHistory
            // 
            this.grdHistory.AllowUserToAddRows = false;
            this.grdHistory.AllowUserToDeleteRows = false;
            this.grdHistory.AutoGenerateColumns = false;
            this.grdHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.maNhanSuDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.reAnSangDataGridViewTextBoxColumn,
            this.reAnTruaDataGridViewTextBoxColumn,
            this.reAnToiDataGridViewTextBoxColumn,
            this.reTieuTienDataGridViewTextBoxColumn,
            this.reDaiTienDataGridViewTextBoxColumn,
            this.reHutThuocDataGridViewTextBoxColumn,
            this.reDiKhacDataGridViewTextBoxColumn,
            this.reSoLanDiQuaDataGridViewTextBoxColumn,
            this.reSoPhutDiQuaDataGridViewTextBoxColumn});
            this.grdHistory.DataSource = this.sPQuanLyCheckInResultBindingSource;
            this.grdHistory.Location = new System.Drawing.Point(35, 23);
            this.grdHistory.Name = "grdHistory";
            this.grdHistory.ReadOnly = true;
            this.grdHistory.RowHeadersWidth = 51;
            this.grdHistory.RowTemplate.Height = 24;
            this.grdHistory.Size = new System.Drawing.Size(1591, 609);
            this.grdHistory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(65, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1654, 124);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(686, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(690, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 42);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(476, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhân viên";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(480, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 45);
            this.comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(268, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thuộc Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(34, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ khóa";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 45);
            this.comboBox1.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(1158, 50);
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
            this.textBox1.Location = new System.Drawing.Point(38, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 45);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ CHECKIN/CHECKOUT";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(919, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 42);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Image = global::CheckinManagementSystem.Properties.Resources.excel__2_;
            this.btnXuat.Location = new System.Drawing.Point(1571, 50);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(55, 47);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNhanSuDataGridViewTextBoxColumn
            // 
            this.maNhanSuDataGridViewTextBoxColumn.DataPropertyName = "MaNhanSu";
            this.maNhanSuDataGridViewTextBoxColumn.HeaderText = "Mã nhân sự";
            this.maNhanSuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanSuDataGridViewTextBoxColumn.Name = "maNhanSuDataGridViewTextBoxColumn";
            this.maNhanSuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reAnSangDataGridViewTextBoxColumn
            // 
            this.reAnSangDataGridViewTextBoxColumn.DataPropertyName = "Re_AnSang";
            this.reAnSangDataGridViewTextBoxColumn.HeaderText = "Ăn sáng";
            this.reAnSangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reAnSangDataGridViewTextBoxColumn.Name = "reAnSangDataGridViewTextBoxColumn";
            this.reAnSangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reAnTruaDataGridViewTextBoxColumn
            // 
            this.reAnTruaDataGridViewTextBoxColumn.DataPropertyName = "Re_AnTrua";
            this.reAnTruaDataGridViewTextBoxColumn.HeaderText = "Ăn trưa";
            this.reAnTruaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reAnTruaDataGridViewTextBoxColumn.Name = "reAnTruaDataGridViewTextBoxColumn";
            this.reAnTruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reAnToiDataGridViewTextBoxColumn
            // 
            this.reAnToiDataGridViewTextBoxColumn.DataPropertyName = "Re_AnToi";
            this.reAnToiDataGridViewTextBoxColumn.HeaderText = "Ăn tối";
            this.reAnToiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reAnToiDataGridViewTextBoxColumn.Name = "reAnToiDataGridViewTextBoxColumn";
            this.reAnToiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reTieuTienDataGridViewTextBoxColumn
            // 
            this.reTieuTienDataGridViewTextBoxColumn.DataPropertyName = "Re_TieuTien";
            this.reTieuTienDataGridViewTextBoxColumn.HeaderText = "Tiểu tiện";
            this.reTieuTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reTieuTienDataGridViewTextBoxColumn.Name = "reTieuTienDataGridViewTextBoxColumn";
            this.reTieuTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reDaiTienDataGridViewTextBoxColumn
            // 
            this.reDaiTienDataGridViewTextBoxColumn.DataPropertyName = "Re_DaiTien";
            this.reDaiTienDataGridViewTextBoxColumn.HeaderText = "Đại tiện";
            this.reDaiTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reDaiTienDataGridViewTextBoxColumn.Name = "reDaiTienDataGridViewTextBoxColumn";
            this.reDaiTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reHutThuocDataGridViewTextBoxColumn
            // 
            this.reHutThuocDataGridViewTextBoxColumn.DataPropertyName = "Re_HutThuoc";
            this.reHutThuocDataGridViewTextBoxColumn.HeaderText = "Hút thuốc";
            this.reHutThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reHutThuocDataGridViewTextBoxColumn.Name = "reHutThuocDataGridViewTextBoxColumn";
            this.reHutThuocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reDiKhacDataGridViewTextBoxColumn
            // 
            this.reDiKhacDataGridViewTextBoxColumn.DataPropertyName = "Re_DiKhac";
            this.reDiKhacDataGridViewTextBoxColumn.HeaderText = "Khác";
            this.reDiKhacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reDiKhacDataGridViewTextBoxColumn.Name = "reDiKhacDataGridViewTextBoxColumn";
            this.reDiKhacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reSoLanDiQuaDataGridViewTextBoxColumn
            // 
            this.reSoLanDiQuaDataGridViewTextBoxColumn.DataPropertyName = "Re_SoLanDiQua";
            this.reSoLanDiQuaDataGridViewTextBoxColumn.HeaderText = "Số lần đi quá quy định";
            this.reSoLanDiQuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reSoLanDiQuaDataGridViewTextBoxColumn.Name = "reSoLanDiQuaDataGridViewTextBoxColumn";
            this.reSoLanDiQuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reSoPhutDiQuaDataGridViewTextBoxColumn
            // 
            this.reSoPhutDiQuaDataGridViewTextBoxColumn.DataPropertyName = "Re_SoPhutDiQua";
            this.reSoPhutDiQuaDataGridViewTextBoxColumn.HeaderText = "Số phút đi quá quy định";
            this.reSoPhutDiQuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reSoPhutDiQuaDataGridViewTextBoxColumn.Name = "reSoPhutDiQuaDataGridViewTextBoxColumn";
            this.reSoPhutDiQuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPQuanLyCheckInResultBindingSource
            // 
            this.sPQuanLyCheckInResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_QuanLyCheckIn_Result);
            // 
            // UCCICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCCICO";
            this.Size = new System.Drawing.Size(1776, 970);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPQuanLyCheckInResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanSuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reAnSangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reAnTruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reAnToiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reTieuTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDaiTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reHutThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDiKhacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reSoLanDiQuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reSoPhutDiQuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPQuanLyCheckInResultBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
