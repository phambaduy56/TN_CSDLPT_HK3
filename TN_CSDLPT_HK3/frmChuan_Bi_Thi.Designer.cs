namespace TN_CSDLPT_HK3
{
    partial class frmChuan_Bi_Thi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new TN_CSDLPT_HK3.DS();
            this.bds_GVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager();
            this.gc_giaoviendk = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gb_DangKy = new System.Windows.Forms.GroupBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.bds_MonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.spin_TimeThi = new DevExpress.XtraEditors.SpinEdit();
            this.spin_CauThi = new DevExpress.XtraEditors.SpinEdit();
            this.spin_lan = new DevExpress.XtraEditors.SpinEdit();
            this.date_NgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.txt_MAGV = new DevExpress.XtraEditors.TextEdit();
            this.mONHOCTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.LOPTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_giaoviendk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gb_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_TimeThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_CauThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_lan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(39, 41);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(82, 23);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MÃ GV:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(461, 43);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(116, 23);
            tRINHDOLabel.TabIndex = 8;
            tRINHDOLabel.Text = "TRÌNH ĐỘ:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTHILabel.Location = new System.Drawing.Point(460, 110);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(118, 23);
            nGAYTHILabel.TabIndex = 10;
            nGAYTHILabel.Text = "NGÀY THI: ";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(513, 173);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(58, 23);
            lANLabel.TabIndex = 12;
            lANLabel.Text = "LẦN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOCAUTHILabel.Location = new System.Drawing.Point(821, 30);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(136, 23);
            sOCAUTHILabel.TabIndex = 14;
            sOCAUTHILabel.Text = "SỐ CÂU THI: ";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIGIANLabel.Location = new System.Drawing.Point(828, 103);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(129, 23);
            tHOIGIANLabel.TabIndex = 16;
            tHOIGIANLabel.Text = "THỜI GIAN: ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(6, 110);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(115, 23);
            mAMHLabel.TabIndex = 19;
            mAMHLabel.Text = "MÔN HỌC:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(21, 179);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(100, 23);
            mALOPLabel.TabIndex = 20;
            mALOPLabel.Text = "MÃ LỚP: ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.add_16x167;
            this.btnThem.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.add_32x327;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.remove_16x167;
            this.btnSua.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.remove_32x327;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.save_16x165;
            this.btnGhi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.save_32x325;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.clear_16x167;
            this.btnXoa.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.clear_32x327;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.reset2_16x167;
            this.btnPhucHoi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.reset2_32x327;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.cancel_16x169;
            this.btnHuy.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.cancel_32x329;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.close_16x166;
            this.btnThoat.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.close_32x326;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1305, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 614);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1305, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 584);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1305, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 584);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 64);
            this.panel1.TabIndex = 7;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(221, 18);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(345, 33);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ: ";
            this.label1.Visible = false;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_GVDK
            // 
            this.bds_GVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bds_GVDK.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gc_giaoviendk
            // 
            this.gc_giaoviendk.DataSource = this.bds_GVDK;
            this.gc_giaoviendk.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_giaoviendk.Location = new System.Drawing.Point(0, 94);
            this.gc_giaoviendk.MainView = this.gridView1;
            this.gc_giaoviendk.MenuManager = this.barManager1;
            this.gc_giaoviendk.Name = "gc_giaoviendk";
            this.gc_giaoviendk.Size = new System.Drawing.Size(1305, 220);
            this.gc_giaoviendk.TabIndex = 8;
            this.gc_giaoviendk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gc_giaoviendk;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.OptionsColumn.ReadOnly = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 94;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 25;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.OptionsColumn.ReadOnly = true;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 94;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 25;
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.OptionsColumn.ReadOnly = true;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 94;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 25;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.OptionsColumn.ReadOnly = true;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 94;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 25;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.OptionsColumn.ReadOnly = true;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 94;
            // 
            // gb_DangKy
            // 
            this.gb_DangKy.Controls.Add(mALOPLabel);
            this.gb_DangKy.Controls.Add(this.cmbMaLop);
            this.gb_DangKy.Controls.Add(mAMHLabel);
            this.gb_DangKy.Controls.Add(this.cmbMonHoc);
            this.gb_DangKy.Controls.Add(this.label2);
            this.gb_DangKy.Controls.Add(tHOIGIANLabel);
            this.gb_DangKy.Controls.Add(this.spin_TimeThi);
            this.gb_DangKy.Controls.Add(sOCAUTHILabel);
            this.gb_DangKy.Controls.Add(this.spin_CauThi);
            this.gb_DangKy.Controls.Add(lANLabel);
            this.gb_DangKy.Controls.Add(this.spin_lan);
            this.gb_DangKy.Controls.Add(nGAYTHILabel);
            this.gb_DangKy.Controls.Add(this.date_NgayThi);
            this.gb_DangKy.Controls.Add(tRINHDOLabel);
            this.gb_DangKy.Controls.Add(this.cmbTrinhDo);
            this.gb_DangKy.Controls.Add(mAGVLabel);
            this.gb_DangKy.Controls.Add(this.txt_MAGV);
            this.gb_DangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_DangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DangKy.Location = new System.Drawing.Point(0, 314);
            this.gb_DangKy.Name = "gb_DangKy";
            this.gb_DangKy.Size = new System.Drawing.Size(1305, 300);
            this.gb_DangKy.TabIndex = 9;
            this.gb_DangKy.TabStop = false;
            this.gb_DangKy.Text = "groupBox1";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_GVDK, "MALOP", true));
            this.cmbMaLop.DataSource = this.bds_LOP;
            this.cmbMaLop.DisplayMember = "TENLOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(139, 176);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(249, 31);
            this.cmbMaLop.TabIndex = 21;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // bds_LOP
            // 
            this.bds_LOP.DataMember = "LOP";
            this.bds_LOP.DataSource = this.dS;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_GVDK, "MAMH", true));
            this.cmbMonHoc.DataSource = this.bds_MonHoc;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(139, 107);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(249, 31);
            this.cmbMonHoc.TabIndex = 20;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // bds_MonHoc
            // 
            this.bds_MonHoc.DataMember = "MONHOC";
            this.bds_MonHoc.DataSource = this.dS;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1124, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "PHÚT";
            // 
            // spin_TimeThi
            // 
            this.spin_TimeThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GVDK, "THOIGIAN", true));
            this.spin_TimeThi.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spin_TimeThi.Location = new System.Drawing.Point(981, 103);
            this.spin_TimeThi.MenuManager = this.barManager1;
            this.spin_TimeThi.Name = "spin_TimeThi";
            this.spin_TimeThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_TimeThi.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spin_TimeThi.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spin_TimeThi.Size = new System.Drawing.Size(125, 24);
            this.spin_TimeThi.TabIndex = 17;
            // 
            // spin_CauThi
            // 
            this.spin_CauThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GVDK, "SOCAUTHI", true));
            this.spin_CauThi.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spin_CauThi.Location = new System.Drawing.Point(981, 29);
            this.spin_CauThi.MenuManager = this.barManager1;
            this.spin_CauThi.Name = "spin_CauThi";
            this.spin_CauThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_CauThi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spin_CauThi.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spin_CauThi.Size = new System.Drawing.Size(125, 24);
            this.spin_CauThi.TabIndex = 15;
            // 
            // spin_lan
            // 
            this.spin_lan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GVDK, "LAN", true));
            this.spin_lan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_lan.Location = new System.Drawing.Point(601, 169);
            this.spin_lan.MenuManager = this.barManager1;
            this.spin_lan.Name = "spin_lan";
            this.spin_lan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_lan.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spin_lan.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_lan.Size = new System.Drawing.Size(125, 24);
            this.spin_lan.TabIndex = 13;
            // 
            // date_NgayThi
            // 
            this.date_NgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GVDK, "NGAYTHI", true));
            this.date_NgayThi.EditValue = new System.DateTime(2021, 8, 12, 14, 11, 56, 0);
            this.date_NgayThi.Location = new System.Drawing.Point(605, 105);
            this.date_NgayThi.MenuManager = this.barManager1;
            this.date_NgayThi.Name = "date_NgayThi";
            this.date_NgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Size = new System.Drawing.Size(125, 22);
            this.date_NgayThi.TabIndex = 11;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GVDK, "TRINHDO", true));
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTrinhDo.Location = new System.Drawing.Point(605, 39);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(121, 31);
            this.cmbTrinhDo.TabIndex = 9;
            // 
            // txt_MAGV
            // 
            this.txt_MAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GVDK, "MAGV", true));
            this.txt_MAGV.Enabled = false;
            this.txt_MAGV.Location = new System.Drawing.Point(139, 43);
            this.txt_MAGV.MenuManager = this.barManager1;
            this.txt_MAGV.Name = "txt_MAGV";
            this.txt_MAGV.Size = new System.Drawing.Size(249, 22);
            this.txt_MAGV.TabIndex = 1;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuan_Bi_Thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 614);
            this.Controls.Add(this.gb_DangKy);
            this.Controls.Add(this.gc_giaoviendk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChuan_Bi_Thi";
            this.Text = "frmChuan_Bi_Thi";
            this.Load += new System.EventHandler(this.frmChuan_Bi_Thi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_giaoviendk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gb_DangKy.ResumeLayout(false);
            this.gb_DangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_TimeThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_CauThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_lan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bds_GVDK;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gb_DangKy;
        private DevExpress.XtraEditors.SpinEdit spin_lan;
        private DevExpress.XtraEditors.DateEdit date_NgayThi;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.TextEdit txt_MAGV;
        private DevExpress.XtraGrid.GridControl gc_giaoviendk;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit spin_TimeThi;
        private DevExpress.XtraEditors.SpinEdit spin_CauThi;
        private System.Windows.Forms.BindingSource bds_MonHoc;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ComboBox cmbMaLop;
    }
}