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
        private BindingSource sPGetAllDangKyResultBindingSource;
        private Label label4;
        private ComboBox cboPhong;
        private Label label5;
        private DateTimePicker txtDenNgay;
        private DateTimePicker txtTuNgay;
        private DataGridView grdCheckOut;
        private ComboBox cboSL;
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
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idNhanSuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLoaiRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianVaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianRaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPhongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNhanSuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thoiGianSuDungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
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

            string[] dataSource = { "100", "200", "500", "1000", "ALL" };
            cboSL.DataSource = dataSource;
            cboSL.SelectedIndex = 0;

            RefreshAll();

            DataGridViewButtonColumn c = (DataGridViewButtonColumn)grdCheckOut.Columns["Edit"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.Red;
            c.Width = 300;
            c.DefaultCellStyle.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            grdCheckOut.RowTemplate.Height = 40;
            grdCheckOut.Columns["GhiChu"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdCheckOut.RowPrePaint += grdCheckOut_RowPrePaint;
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "序号";
            sttColumn.HeaderText = "序号";
            grdCheckOut.Columns.Insert(0, sttColumn);
            sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sttColumn.Width = 100;

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
            this.cboSL = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdCheckOut = new System.Windows.Forms.DataGridView();
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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanSuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianVaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianRaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanSuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPGetAllDangKyResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboLoaiRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanSu = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1521, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "打卡记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboSL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.198758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.27329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1527, 805);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cboSL
            // 
            this.cboSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSL.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSL.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSL.FormattingEnabled = true;
            this.cboSL.Location = new System.Drawing.Point(1395, 766);
            this.cboSL.Name = "cboSL";
            this.cboSL.Size = new System.Drawing.Size(129, 35);
            this.cboSL.TabIndex = 8;
            this.cboSL.SelectedIndexChanged += new System.EventHandler(this.cboSL_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.090072F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.63642F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.339251F));
            this.tableLayoutPanel2.Controls.Add(this.grdCheckOut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1521, 577);
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
            this.grdCheckOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCheckOut.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Edit,
            this.iDDataGridViewTextBoxColumn,
            this.idNhanSuDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.idLoaiRecordDataGridViewTextBoxColumn,
            this.tenLoaiRecordDataGridViewTextBoxColumn,
            this.thoiGianVaoDataGridViewTextBoxColumn,
            this.thoiGianRaDataGridViewTextBoxColumn,
            this.idPhongDataGridViewTextBoxColumn,
            this.maNhanSuDataGridViewTextBoxColumn,
            this.thoiGianSuDungDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.grdCheckOut.DataSource = this.sPGetAllDangKyResultBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdCheckOut.RowHeadersWidth = 51;
            this.grdCheckOut.RowTemplate.Height = 24;
            this.grdCheckOut.Size = new System.Drawing.Size(1402, 571);
            this.grdCheckOut.TabIndex = 8;
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
            this.ID.Width = 69;
            // 
            // IdNhanSu
            // 
            this.IdNhanSu.DataPropertyName = "IdNhanSu";
            this.IdNhanSu.HeaderText = "IdNhanSu";
            this.IdNhanSu.MinimumWidth = 6;
            this.IdNhanSu.Name = "IdNhanSu";
            this.IdNhanSu.ReadOnly = true;
            this.IdNhanSu.Visible = false;
            this.IdNhanSu.Width = 153;
            // 
            // IdLoaiRecord
            // 
            this.IdLoaiRecord.DataPropertyName = "IdLoaiRecord";
            this.IdLoaiRecord.HeaderText = "IdLoaiRecord";
            this.IdLoaiRecord.MinimumWidth = 6;
            this.IdLoaiRecord.Name = "IdLoaiRecord";
            this.IdLoaiRecord.ReadOnly = true;
            this.IdLoaiRecord.Visible = false;
            this.IdLoaiRecord.Width = 209;
            // 
            // MaNhanSu
            // 
            this.MaNhanSu.DataPropertyName = "MaNhanSu";
            this.MaNhanSu.HeaderText = "ID号";
            this.MaNhanSu.MinimumWidth = 6;
            this.MaNhanSu.Name = "MaNhanSu";
            this.MaNhanSu.ReadOnly = true;
            this.MaNhanSu.Width = 97;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "姓名";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 97;
            // 
            // TenLoaiRecord
            // 
            this.TenLoaiRecord.DataPropertyName = "TenLoaiRecord";
            this.TenLoaiRecord.HeaderText = "打卡";
            this.TenLoaiRecord.MinimumWidth = 6;
            this.TenLoaiRecord.Name = "TenLoaiRecord";
            this.TenLoaiRecord.ReadOnly = true;
            this.TenLoaiRecord.Width = 97;
            // 
            // ThoiGianVao
            // 
            this.ThoiGianVao.DataPropertyName = "ThoiGianVao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianVao.DefaultCellStyle = dataGridViewCellStyle2;
            this.ThoiGianVao.HeaderText = "出去时间";
            this.ThoiGianVao.MinimumWidth = 6;
            this.ThoiGianVao.Name = "ThoiGianVao";
            this.ThoiGianVao.ReadOnly = true;
            this.ThoiGianVao.Width = 153;
            // 
            // ThoiGianRa
            // 
            this.ThoiGianRa.DataPropertyName = "ThoiGianRa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianRa.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThoiGianRa.HeaderText = "进入时间";
            this.ThoiGianRa.MinimumWidth = 6;
            this.ThoiGianRa.Name = "ThoiGianRa";
            this.ThoiGianRa.ReadOnly = true;
            this.ThoiGianRa.Width = 153;
            // 
            // ThoiGianSuDung
            // 
            this.ThoiGianSuDung.DataPropertyName = "ThoiGianSuDung";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianSuDung.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThoiGianSuDung.HeaderText = "超时";
            this.ThoiGianSuDung.MinimumWidth = 6;
            this.ThoiGianSuDung.Name = "ThoiGianSuDung";
            this.ThoiGianSuDung.ReadOnly = true;
            this.ThoiGianSuDung.Width = 97;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "备注";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 97;
            // 
            // Edit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "备 注";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 69;
            // 
            // idNhanSuDataGridViewTextBoxColumn
            // 
            this.idNhanSuDataGridViewTextBoxColumn.DataPropertyName = "IdNhanSu";
            this.idNhanSuDataGridViewTextBoxColumn.HeaderText = "IdNhanSu";
            this.idNhanSuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idNhanSuDataGridViewTextBoxColumn.Name = "idNhanSuDataGridViewTextBoxColumn";
            this.idNhanSuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNhanSuDataGridViewTextBoxColumn.Visible = false;
            this.idNhanSuDataGridViewTextBoxColumn.Width = 153;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Visible = false;
            this.hoTenDataGridViewTextBoxColumn.Width = 111;
            // 
            // idLoaiRecordDataGridViewTextBoxColumn
            // 
            this.idLoaiRecordDataGridViewTextBoxColumn.DataPropertyName = "IdLoaiRecord";
            this.idLoaiRecordDataGridViewTextBoxColumn.HeaderText = "IdLoaiRecord";
            this.idLoaiRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLoaiRecordDataGridViewTextBoxColumn.Name = "idLoaiRecordDataGridViewTextBoxColumn";
            this.idLoaiRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLoaiRecordDataGridViewTextBoxColumn.Visible = false;
            this.idLoaiRecordDataGridViewTextBoxColumn.Width = 209;
            // 
            // tenLoaiRecordDataGridViewTextBoxColumn
            // 
            this.tenLoaiRecordDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiRecord";
            this.tenLoaiRecordDataGridViewTextBoxColumn.HeaderText = "TenLoaiRecord";
            this.tenLoaiRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Name = "tenLoaiRecordDataGridViewTextBoxColumn";
            this.tenLoaiRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Visible = false;
            this.tenLoaiRecordDataGridViewTextBoxColumn.Width = 223;
            // 
            // thoiGianVaoDataGridViewTextBoxColumn
            // 
            this.thoiGianVaoDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianVao";
            this.thoiGianVaoDataGridViewTextBoxColumn.HeaderText = "ThoiGianVao";
            this.thoiGianVaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianVaoDataGridViewTextBoxColumn.Name = "thoiGianVaoDataGridViewTextBoxColumn";
            this.thoiGianVaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianVaoDataGridViewTextBoxColumn.Visible = false;
            this.thoiGianVaoDataGridViewTextBoxColumn.Width = 195;
            // 
            // thoiGianRaDataGridViewTextBoxColumn
            // 
            this.thoiGianRaDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianRa";
            this.thoiGianRaDataGridViewTextBoxColumn.HeaderText = "ThoiGianRa";
            this.thoiGianRaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianRaDataGridViewTextBoxColumn.Name = "thoiGianRaDataGridViewTextBoxColumn";
            this.thoiGianRaDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianRaDataGridViewTextBoxColumn.Visible = false;
            this.thoiGianRaDataGridViewTextBoxColumn.Width = 181;
            // 
            // idPhongDataGridViewTextBoxColumn
            // 
            this.idPhongDataGridViewTextBoxColumn.DataPropertyName = "IdPhong";
            this.idPhongDataGridViewTextBoxColumn.HeaderText = "IdPhong";
            this.idPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPhongDataGridViewTextBoxColumn.Name = "idPhongDataGridViewTextBoxColumn";
            this.idPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPhongDataGridViewTextBoxColumn.Visible = false;
            this.idPhongDataGridViewTextBoxColumn.Width = 139;
            // 
            // maNhanSuDataGridViewTextBoxColumn
            // 
            this.maNhanSuDataGridViewTextBoxColumn.DataPropertyName = "MaNhanSu";
            this.maNhanSuDataGridViewTextBoxColumn.HeaderText = "MaNhanSu";
            this.maNhanSuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanSuDataGridViewTextBoxColumn.Name = "maNhanSuDataGridViewTextBoxColumn";
            this.maNhanSuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNhanSuDataGridViewTextBoxColumn.Visible = false;
            this.maNhanSuDataGridViewTextBoxColumn.Width = 153;
            // 
            // thoiGianSuDungDataGridViewTextBoxColumn
            // 
            this.thoiGianSuDungDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianSuDung";
            this.thoiGianSuDungDataGridViewTextBoxColumn.HeaderText = "ThoiGianSuDung";
            this.thoiGianSuDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianSuDungDataGridViewTextBoxColumn.Name = "thoiGianSuDungDataGridViewTextBoxColumn";
            this.thoiGianSuDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianSuDungDataGridViewTextBoxColumn.Visible = false;
            this.thoiGianSuDungDataGridViewTextBoxColumn.Width = 237;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Visible = false;
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPGetAllDangKyResultBindingSource
            // 
            this.sPGetAllDangKyResultBindingSource.DataSource = typeof(CheckinManagementSystem.DAL.SP_GetAllDangKy_Result);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.024326F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.57068F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.339251F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1521, 112);
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
            this.panel1.Size = new System.Drawing.Size(1402, 106);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(725, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "日期";
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.CalendarFont = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenNgay.CustomFormat = "";
            this.txtDenNgay.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(922, 42);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(177, 42);
            this.txtDenNgay.TabIndex = 11;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.CalendarFont = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.CustomFormat = "";
            this.txtTuNgay.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(729, 44);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(187, 42);
            this.txtTuNgay.TabIndex = 12;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1252, 39);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 45);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "刷新";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1120, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(507, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "办公室";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(265, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "打卡";
            // 
            // cboPhong
            // 
            this.cboPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPhong.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(512, 50);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(211, 35);
            this.cboPhong.TabIndex = 2;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboPhong.TextUpdate += new System.EventHandler(this.cboPhong_TextUpdate);
            this.cboPhong.DropDownClosed += new System.EventHandler(this.cboPhong_DropDownClosed);
            this.cboPhong.Click += new System.EventHandler(this.cboPhong_Click);
            // 
            // cboLoaiRecord
            // 
            this.cboLoaiRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiRecord.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiRecord.FormattingEnabled = true;
            this.cboLoaiRecord.Location = new System.Drawing.Point(270, 50);
            this.cboLoaiRecord.Name = "cboLoaiRecord";
            this.cboLoaiRecord.Size = new System.Drawing.Size(236, 35);
            this.cboLoaiRecord.TabIndex = 2;
            this.cboLoaiRecord.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboLoaiRecord.TextUpdate += new System.EventHandler(this.cboLoaiRecord_TextUpdate);
            this.cboLoaiRecord.DropDownClosed += new System.EventHandler(this.cboLoaiRecord_DropDownClosed);
            this.cboLoaiRecord.Click += new System.EventHandler(this.cboLoaiRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工";
            // 
            // cboNhanSu
            // 
            this.cboNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNhanSu.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanSu.FormattingEnabled = true;
            this.cboNhanSu.Location = new System.Drawing.Point(22, 50);
            this.cboNhanSu.Name = "cboNhanSu";
            this.cboNhanSu.Size = new System.Drawing.Size(233, 35);
            this.cboNhanSu.TabIndex = 0;
            this.cboNhanSu.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.cboNhanSu.TextUpdate += new System.EventHandler(this.cboNhanSu_TextUpdate);
            this.cboNhanSu.DropDownClosed += new System.EventHandler(this.cboNhanSu_DropDownClosed);
            this.cboNhanSu.Click += new System.EventHandler(this.cboNhanSu_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAllDangKyResultBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public void RefreshAll()
        {
            txtDenNgay.Value = DateTime.Now;
            txtTuNgay.Value = DateTime.Now.AddDays(-30);
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
            string idPhongMacDinh = Properties.Settings.Default.IDPhong;
            var data = _recordBLL.GetAllDangKy(true, Math.Max(cboSL.SelectedIndex, 0), IDNhanSu, IDLoaiRecord, IDPhong, int.Parse(idPhongMacDinh), true, txtTuNgay.Value, txtDenNgay.Value).ToList();
            grdCheckOut.DataSource = data;

            foreach (DataGridViewColumn column in grdCheckOut.Columns)
            {
                if (column.Name == "ThoiGianSuDung")
                {
                    column.Width = 100;
                }
                else if (column.Name == "ThoiGianVao" || column.Name == "ThoiGianRa")
                {
                    column.Width = 300;
                }
                else if (column.Name != "Edit" && column.Name != "序号")
                {
                    column.Width = CalculatePreferredColumnWidth(column);
                }
            }
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
                row.Cells["序号"].Value = (e.RowIndex + 1).ToString();
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

                if (grdCheckOut.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (_recordBLL.DeleteRecordDiemDanh(Id ?? 0) > 0)
                        MessageBox.Show("已删除上下班 !", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("删除上下班失败 !", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshDataDiemDanh();
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
                if (cboNhanSu.SelectedIndex >= 0)
                {
                    if (cboNhanSu.Text.Length > 0)
                    {
                        var lst = cboNhanSu.DataSource as List<NhanSu>;
                        cboNhanSu.Text = lst[cboNhanSu.SelectedIndex].HoTen;
                    }
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
                if (cboLoaiRecord.SelectedIndex >= 0)
                {
                    if (cboLoaiRecord.Text.Length > 0)
                    {
                        var lst = cboLoaiRecord.DataSource as List<LoaiRecord>;
                        cboLoaiRecord.Text = lst[cboLoaiRecord.SelectedIndex].TenLoaiRecord;
                    }
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
                if (cboPhong.SelectedIndex >= 0)
                {
                    if (cboPhong.Text.Length > 0)
                    {
                        var lst = cboPhong.DataSource as List<Phong>;
                        cboPhong.Text = lst[cboPhong.SelectedIndex].TenPhong;
                    }
                }
            }
        }

        private int CalculatePreferredColumnWidth(DataGridViewColumn column)
        {
            int maxWidth = 0;

            foreach (DataGridViewRow row in grdCheckOut.Rows)
            {
                if (row.Cells[column.Index].Value != null)
                {
                    Size cellSize = TextRenderer.MeasureText(row.Cells[column.Index].Value.ToString(), new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
                    maxWidth = Math.Max(maxWidth, cellSize.Width);
                }
            }

            return maxWidth + 10;
        }

        private void cboSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataDiemDanh();
        }
    }
}
