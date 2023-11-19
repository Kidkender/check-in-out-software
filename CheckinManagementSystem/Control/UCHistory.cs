using CheckinManagementSystem.BLL;
using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace CheckinManagementSystem
{
    public partial class UCHistory : UserControl
    {
        #region Variable

        NhanSuBLL _nhanSuBLL = new NhanSuBLL();
        CheckInOutBLL _checkInOutBLL = new CheckInOutBLL();
        RecordBLL _recordBLL = new RecordBLL();

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Label label3;
        private ComboBox cboLoaiRecord;
        private Label label2;
        private ComboBox cboNhanSu;
        private Button btnLamMoi;
        private Button btnSearch;
        private System.ComponentModel.IContainer components;
        private DataGridView grdCheckOut;
        private BindingSource sPGetAllDangKyResultBindingSource;
        private Label label4;
        private ComboBox cboPhong;
        private Label label5;
        private DateTimePicker txtDenNgay;
        private DateTimePicker txtTuNgay;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IdNhanSu;
        private DataGridViewTextBoxColumn IdLoaiRecord;
        private DataGridViewTextBoxColumn MaNhanSu;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenLoaiRecord;
        private DataGridViewTextBoxColumn ThoiGianVao;
        private DataGridViewTextBoxColumn ThoiGianRa;
        private DataGridViewTextBoxColumn ThoiGianSuDung;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idNhanSuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLoaiRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianVaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianRaDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private static UCHistory _instance;
        public static UCHistory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHistory();
                return _instance;
            }
        }

        #endregion

        #region Contructor

        public UCHistory()
        {
            InitializeComponent();
            RefreshAll();

            DataGridViewButtonColumn c = (DataGridViewButtonColumn)grdCheckOut.Columns["Edit"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.Red;
            c.Width = 300;

            grdCheckOut.RowTemplate.Height = 40;
            grdCheckOut.Columns["GhiChu"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grdCheckOut.RowPrePaint += grdCheckOut_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            grdCheckOut.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 50;

            foreach (DataGridViewColumn col in grdCheckOut.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (col.ValueType == typeof(DateTime?))
                {
                    col.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                }
            }
        }

        #endregion

        #region Method

        public void SetVisibleGrid(bool isMaster)
        {
            grdCheckOut.Columns["Edit"].Visible = isMaster;
        }

        #endregion

        #region Private

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdCheckOut = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboLoaiRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanSu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.sPGetAllDangKyResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoaiRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanSuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianVaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianRaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1521, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ CHECKIN/CHECKOUT";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.198758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.27329F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1527, 805);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.090072F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.63642F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.339251F));
            this.tableLayoutPanel2.Controls.Add(this.grdCheckOut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 194);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1521, 608);
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
            this.grdCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCheckOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.HoTen,
            this.TenLoaiRecord,
            this.ThoiGianVao,
            this.ThoiGianRa,
            this.ThoiGianSuDung,
            this.GhiChu,
            this.iDDataGridViewTextBoxColumn,
            this.idNhanSuDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.idLoaiRecordDataGridViewTextBoxColumn,
            this.tenLoaiRecordDataGridViewTextBoxColumn,
            this.thoiGianVaoDataGridViewTextBoxColumn,
            this.thoiGianRaDataGridViewTextBoxColumn,
            this.Edit});
            this.grdCheckOut.DataSource = this.sPGetAllDangKyResultBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCheckOut.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdCheckOut.EnableHeadersVisualStyles = false;
            this.grdCheckOut.Location = new System.Drawing.Point(49, 3);
            this.grdCheckOut.Name = "grdCheckOut";
            this.grdCheckOut.ReadOnly = true;
            this.grdCheckOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdCheckOut.RowHeadersWidth = 51;
            this.grdCheckOut.RowTemplate.Height = 24;
            this.grdCheckOut.Size = new System.Drawing.Size(1402, 602);
            this.grdCheckOut.TabIndex = 7;
            this.grdCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCheckOut_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.024326F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.57068F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.339251F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1521, 119);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDenNgay);
            this.panel1.Controls.Add(this.txtTuNgay);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboPhong);
            this.panel1.Controls.Add(this.cboLoaiRecord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboNhanSu);
            this.panel1.Location = new System.Drawing.Point(49, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 107);
            this.panel1.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1271, 47);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 45);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1139, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(539, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(265, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại Checkin/Checkout";
            // 
            // cboPhong
            // 
            this.cboPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(544, 50);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(211, 39);
            this.cboPhong.TabIndex = 2;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboPhong.TextUpdate += new System.EventHandler(this.cboPhong_TextUpdate);
            this.cboPhong.DropDownClosed += new System.EventHandler(this.cboPhong_DropDownClosed);
            this.cboPhong.Click += new System.EventHandler(this.cboPhong_Click);
            // 
            // cboLoaiRecord
            // 
            this.cboLoaiRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiRecord.FormattingEnabled = true;
            this.cboLoaiRecord.Location = new System.Drawing.Point(270, 50);
            this.cboLoaiRecord.Name = "cboLoaiRecord";
            this.cboLoaiRecord.Size = new System.Drawing.Size(258, 39);
            this.cboLoaiRecord.TabIndex = 2;
            this.cboLoaiRecord.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboLoaiRecord.TextUpdate += new System.EventHandler(this.cboLoaiRecord_TextUpdate);
            this.cboLoaiRecord.DropDownClosed += new System.EventHandler(this.cboLoaiRecord_DropDownClosed);
            this.cboLoaiRecord.Click += new System.EventHandler(this.cboLoaiRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // cboNhanSu
            // 
            this.cboNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanSu.FormattingEnabled = true;
            this.cboNhanSu.Location = new System.Drawing.Point(22, 50);
            this.cboNhanSu.Name = "cboNhanSu";
            this.cboNhanSu.Size = new System.Drawing.Size(233, 39);
            this.cboNhanSu.TabIndex = 0;
            this.cboNhanSu.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboNhanSu.TextUpdate += new System.EventHandler(this.cboNhanSu_TextUpdate);
            this.cboNhanSu.DropDownClosed += new System.EventHandler(this.cboNhanSu_DropDownClosed);
            this.cboNhanSu.Click += new System.EventHandler(this.cboNhanSu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(771, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày";
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenNgay.CustomFormat = "";
            this.txtDenNgay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(946, 50);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(177, 42);
            this.txtDenNgay.TabIndex = 11;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.CustomFormat = "";
            this.txtTuNgay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(771, 50);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(169, 42);
            this.txtTuNgay.TabIndex = 12;
            // 
            // sPGetAllDangKyResultBindingSource
            // 
            this.sPGetAllDangKyResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllDangKy_Result);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 70;
            // 
            // IdNhanSu
            // 
            this.IdNhanSu.DataPropertyName = "IdNhanSu";
            this.IdNhanSu.HeaderText = "IdNhanSu";
            this.IdNhanSu.MinimumWidth = 6;
            this.IdNhanSu.Name = "IdNhanSu";
            this.IdNhanSu.ReadOnly = true;
            this.IdNhanSu.Visible = false;
            this.IdNhanSu.Width = 169;
            // 
            // IdLoaiRecord
            // 
            this.IdLoaiRecord.DataPropertyName = "IdLoaiRecord";
            this.IdLoaiRecord.HeaderText = "IdLoaiRecord";
            this.IdLoaiRecord.MinimumWidth = 6;
            this.IdLoaiRecord.Name = "IdLoaiRecord";
            this.IdLoaiRecord.ReadOnly = true;
            this.IdLoaiRecord.Visible = false;
            this.IdLoaiRecord.Width = 212;
            // 
            // MaNhanSu
            // 
            this.MaNhanSu.DataPropertyName = "MaNhanSu";
            this.MaNhanSu.HeaderText = "Mã nhân sự";
            this.MaNhanSu.MinimumWidth = 6;
            this.MaNhanSu.Name = "MaNhanSu";
            this.MaNhanSu.ReadOnly = true;
            this.MaNhanSu.Width = 190;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 126;
            // 
            // TenLoaiRecord
            // 
            this.TenLoaiRecord.DataPropertyName = "TenLoaiRecord";
            this.TenLoaiRecord.HeaderText = "Loại đăng ký";
            this.TenLoaiRecord.MinimumWidth = 6;
            this.TenLoaiRecord.Name = "TenLoaiRecord";
            this.TenLoaiRecord.ReadOnly = true;
            this.TenLoaiRecord.Width = 204;
            // 
            // ThoiGianVao
            // 
            this.ThoiGianVao.DataPropertyName = "ThoiGianVao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianVao.DefaultCellStyle = dataGridViewCellStyle2;
            this.ThoiGianVao.HeaderText = "Thời gian ra";
            this.ThoiGianVao.MinimumWidth = 6;
            this.ThoiGianVao.Name = "ThoiGianVao";
            this.ThoiGianVao.ReadOnly = true;
            this.ThoiGianVao.Width = 193;
            // 
            // ThoiGianRa
            // 
            this.ThoiGianRa.DataPropertyName = "ThoiGianRa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianRa.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThoiGianRa.HeaderText = "Thời gian vào";
            this.ThoiGianRa.MinimumWidth = 6;
            this.ThoiGianRa.Name = "ThoiGianRa";
            this.ThoiGianRa.ReadOnly = true;
            this.ThoiGianRa.Width = 214;
            // 
            // ThoiGianSuDung
            // 
            this.ThoiGianSuDung.DataPropertyName = "ThoiGianSuDung";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianSuDung.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThoiGianSuDung.HeaderText = "Thời gian sử dụng";
            this.ThoiGianSuDung.MinimumWidth = 6;
            this.ThoiGianSuDung.Name = "ThoiGianSuDung";
            this.ThoiGianSuDung.ReadOnly = true;
            this.ThoiGianSuDung.Width = 187;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 129;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 70;
            // 
            // idNhanSuDataGridViewTextBoxColumn
            // 
            this.idNhanSuDataGridViewTextBoxColumn.DataPropertyName = "IdNhanSu";
            this.idNhanSuDataGridViewTextBoxColumn.HeaderText = "IdNhanSu";
            this.idNhanSuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idNhanSuDataGridViewTextBoxColumn.Name = "idNhanSuDataGridViewTextBoxColumn";
            this.idNhanSuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNhanSuDataGridViewTextBoxColumn.Visible = false;
            this.idNhanSuDataGridViewTextBoxColumn.Width = 169;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Visible = false;
            this.hoTenDataGridViewTextBoxColumn.Width = 128;
            // 
            // idLoaiRecordDataGridViewTextBoxColumn
            // 
            this.idLoaiRecordDataGridViewTextBoxColumn.DataPropertyName = "IdLoaiRecord";
            this.idLoaiRecordDataGridViewTextBoxColumn.HeaderText = "IdLoaiRecord";
            this.idLoaiRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLoaiRecordDataGridViewTextBoxColumn.Name = "idLoaiRecordDataGridViewTextBoxColumn";
            this.idLoaiRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLoaiRecordDataGridViewTextBoxColumn.Visible = false;
            this.idLoaiRecordDataGridViewTextBoxColumn.Width = 212;
            // 
            // tenLoaiRecordDataGridViewTextBoxColumn
            // 
            this.tenLoaiRecordDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiRecord";
            this.tenLoaiRecordDataGridViewTextBoxColumn.HeaderText = "TenLoaiRecord";
            this.tenLoaiRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Name = "tenLoaiRecordDataGridViewTextBoxColumn";
            this.tenLoaiRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Visible = false;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Width = 238;
            // 
            // thoiGianVaoDataGridViewTextBoxColumn
            // 
            this.thoiGianVaoDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianVao";
            this.thoiGianVaoDataGridViewTextBoxColumn.HeaderText = "ThoiGianVao";
            this.thoiGianVaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianVaoDataGridViewTextBoxColumn.Name = "thoiGianVaoDataGridViewTextBoxColumn";
            this.thoiGianVaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianVaoDataGridViewTextBoxColumn.Visible = false;
            this.thoiGianVaoDataGridViewTextBoxColumn.Width = 211;
            // 
            // thoiGianRaDataGridViewTextBoxColumn
            // 
            this.thoiGianRaDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianRa";
            this.thoiGianRaDataGridViewTextBoxColumn.HeaderText = "ThoiGianRa";
            this.thoiGianRaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianRaDataGridViewTextBoxColumn.Name = "thoiGianRaDataGridViewTextBoxColumn";
            this.thoiGianRaDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianRaDataGridViewTextBoxColumn.Visible = false;
            this.thoiGianRaDataGridViewTextBoxColumn.Width = 196;
            // 
            // Edit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit ghi chú";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 6;
            // 
            // UCHistory
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(1527, 805);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        public void RefreshAll()
        {
            RefreshDataNhanSu();
            RefreshDataDiemDanh();
            RefreshDataPhong();
            RefreshDataLoaiRecord();
        }

        private void RefreshDataNhanSu()
        {
            var data = getDataNhanSu();
            data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
            cboNhanSu.DataSource = data;
            cboNhanSu.ValueMember = "ID";
            cboNhanSu.DisplayMember = "HoTen";
            cboNhanSu.SelectedIndex = -1;
            cboNhanSu.Text = "";
        }

        private void RefreshDataLoaiRecord()
        {
            cboLoaiRecord.DataSource = _recordBLL.GetAllLoaiRecord();
            cboLoaiRecord.ValueMember = "ID";
            cboLoaiRecord.DisplayMember = "TenLoaiRecord";
            cboLoaiRecord.SelectedIndex = -1;
            cboLoaiRecord.Text = "";
        }

        private void RefreshDataPhong()
        {
            cboPhong.DataSource = getDataPhong();
            cboPhong.ValueMember = "ID";
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "";
        }

        private void RefreshDataDiemDanh(int? IDNhanSu = null, int? IDLoaiRecord = null, int? IDPhong = null)
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            var data = _recordBLL.GetAllDangKy(true).Where(t => (IDNhanSu == null || IDNhanSu == t.IdNhanSu)
                                                               && (IDLoaiRecord == null || IDLoaiRecord == t.IdLoaiRecord)
                                                               && (IDPhong == null || t.IdPhong == IDPhong)
                                                               && t.ThoiGianRa.HasValue
                                                               && t.IdLoaiRecord != 0
                                                               && t.IdPhong == int.Parse(idPhong)).ToList();
            grdCheckOut.DataSource = data;
        }

        private List<NhanSu> getDataNhanSu()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllNhanSu().Where(t => t.IdPhong == int.Parse(idPhong)).ToList();
        }

        private List<Phong> getDataPhong()
        {
            string idPhong = Properties.Settings.Default.IDPhong;
            return _nhanSuBLL.GetAllPhong().Where(t => t.ID == int.Parse(idPhong)).ToList();
        }

        #endregion

        #region Event

        public void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox.SelectedIndex == -1)
                return;
        }

        private void grdCheckOut_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdCheckOut.Rows[e.RowIndex];
                row.Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanSu nhanSu = (NhanSu)cboNhanSu.SelectedItem;
            LoaiRecord loaiRecord = (LoaiRecord)cboLoaiRecord.SelectedItem;
            Phong p = (Phong)cboPhong.SelectedItem;
            RefreshDataDiemDanh(nhanSu?.ID, loaiRecord?.ID, p?.ID);
        }

        private void cboNhanSu_TextUpdate(object sender, EventArgs e)
        {
            if (cboNhanSu.Text == string.Empty)
            {
                RefreshDataNhanSu();
            }
            else
            {
                string tempStr = cboNhanSu.Text;
                var data = getDataNhanSu();
                data.ForEach(t => t.HoTen = t.MaNhanSu + " - " + t.HoTen);
                data = data.Where(t => t.HoTen.ToLower().Contains(tempStr.ToLower()) || t.MaNhanSu.ToLower().Contains(tempStr.ToLower())).ToList();

                cboNhanSu.DataSource = data;
                cboNhanSu.ValueMember = "ID";
                cboNhanSu.DisplayMember = "HoTen";
                cboNhanSu.DroppedDown = true;
                Cursor.Current = Cursors.Default;
                cboNhanSu.SelectedIndex = -1;

                cboNhanSu.Text = tempStr;
                cboNhanSu.Select(cboNhanSu.Text.Length, 0);
            }
        }

        private void cboLoaiRecord_TextUpdate(object sender, EventArgs e)
        {
            if (cboLoaiRecord.Text == string.Empty)
            {
                RefreshDataLoaiRecord();
            }
            else
            {
                string tempStr = cboLoaiRecord.Text;
                List<LoaiRecord> data = _recordBLL.GetAllLoaiRecord().Where(t => t.TenLoaiRecord.ToLower().Contains(tempStr.ToLower())).ToList();

                cboLoaiRecord.DataSource = data;
                cboLoaiRecord.ValueMember = "ID";
                cboLoaiRecord.DisplayMember = "TenLoaiRecord";
                cboLoaiRecord.DroppedDown = true;
                Cursor.Current = Cursors.Default;
                cboLoaiRecord.SelectedIndex = -1;

                cboLoaiRecord.Text = tempStr;
                cboLoaiRecord.Select(cboLoaiRecord.Text.Length, 0);
            }
        }

        private void cboPhong_TextUpdate(object sender, EventArgs e)
        {
            if (cboPhong.Text == string.Empty)
            {
                RefreshDataPhong();
            }
            else
            {
                string tempStr = cboPhong.Text;
                List<Phong> data = getDataPhong().Where(t => t.TenPhong.ToLower().Contains(tempStr.ToLower())).ToList();

                cboPhong.DataSource = data;
                cboPhong.ValueMember = "ID";
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.DroppedDown = true;
                cboPhong.MaxDropDownItems = 5;
                Cursor.Current = Cursors.Default;
                cboPhong.SelectedIndex = -1;

                cboPhong.Text = tempStr;
                cboPhong.Select(cboPhong.Text.Length, 0);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void grdCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int? Id = (int)grdCheckOut["ID", e.RowIndex].Value;
                string ghiChu = (string)grdCheckOut["GhiChu", e.RowIndex].Value;

                if (grdCheckOut.Columns[e.ColumnIndex].Name == "Edit")
                {
                    using (EditGhiChu noteDialog = new EditGhiChu(Id, ghiChu))
                    {
                        DialogResult result = noteDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            RefreshAll();
                        }
                    }
                }
            }
        }

        #endregion

        private void cboNhanSu_Click(object sender, EventArgs e)
        {
            cboNhanSu.DroppedDown = true;
        }

        private void cboLoaiRecord_Click(object sender, EventArgs e)
        {
            cboLoaiRecord.DroppedDown = true;
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            cboPhong.DroppedDown = true;
        }

        private void cboNhanSu_DropDownClosed(object sender, EventArgs e)
        {
            if (cboNhanSu.Items.Count == 0)
            {
                RefreshDataNhanSu();
            }
            else
            {
                if (cboNhanSu.Text.Length > 0)
                {
                    var lst = cboNhanSu.DataSource as List<NhanSu>;
                    cboNhanSu.Text = lst[cboNhanSu.SelectedIndex].HoTen;
                }
            }
        }

        private void cboLoaiRecord_DropDownClosed(object sender, EventArgs e)
        {
            if (cboLoaiRecord.Items.Count == 0)
            {
                RefreshDataLoaiRecord();
            }
            else
            {
                if (cboLoaiRecord.Text.Length > 0)
                {
                    var lst = cboLoaiRecord.DataSource as List<LoaiRecord>;
                    cboLoaiRecord.Text = lst[cboLoaiRecord.SelectedIndex].TenLoaiRecord;
                }
            }
        }

        private void cboPhong_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPhong.Items.Count == 0)
            {
                RefreshDataPhong();
            }
            else
            {
                if (cboPhong.Text.Length > 0)
                {
                    var lst = cboPhong.DataSource as List<Phong>;
                    cboPhong.Text = lst[cboPhong.SelectedIndex].TenPhong;
                }
            }
        }
    }
}
