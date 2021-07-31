namespace TN_CSDLPT_HK3
{
    partial class frmNhap_Bo_De
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label cAUHOILabel;
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
            this.bds_bode = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager();
            this.gc_bode = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gb_BoDe = new System.Windows.Forms.GroupBox();
            this.txtCauHoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_DapAn = new System.Windows.Forms.ComboBox();
            this.txtTrinhDo = new System.Windows.Forms.ComboBox();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.txt_D = new DevExpress.XtraEditors.TextEdit();
            this.txt_C = new DevExpress.XtraEditors.TextEdit();
            this.txt_B = new DevExpress.XtraEditors.TextEdit();
            this.txt_A = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMAMH = new DevExpress.XtraEditors.TextEdit();
            mAMHLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_bode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gb_BoDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauHoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_D.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_C.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_B.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_A.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(23, 102);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(53, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(229, 40);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(77, 17);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(733, 43);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(21, 17);
            aLabel.TabIndex = 8;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(733, 81);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(21, 17);
            bLabel.TabIndex = 10;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(733, 123);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(21, 17);
            cLabel.TabIndex = 12;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(732, 167);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(22, 17);
            dLabel.TabIndex = 14;
            dLabel.Text = "D:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(30, 211);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(52, 17);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "MAGV:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(7, 163);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(75, 17);
            tRINHDOLabel.TabIndex = 20;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(754, 211);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(63, 17);
            dAP_ANLabel.TabIndex = 21;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(18, 43);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(64, 17);
            cAUHOILabel.TabIndex = 22;
            cAUHOILabel.Text = "CAUHOI:";
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
            this.btnThem.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.add_16x165;
            this.btnThem.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.add_32x325;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.remove_16x165;
            this.btnSua.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.remove_32x325;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.save_16x163;
            this.btnGhi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.save_32x323;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.clear_16x165;
            this.btnXoa.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.clear_32x325;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.reset2_16x165;
            this.btnPhucHoi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.reset2_32x325;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.cancel_16x167;
            this.btnHuy.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.cancel_32x327;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.close_16x164;
            this.btnThoat.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.close_32x324;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1282, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 638);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1282, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 608);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1282, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 608);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 76);
            this.panel1.TabIndex = 6;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(204, 25);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(403, 24);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ: ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_bode
            // 
            this.bds_bode.DataMember = "BODE";
            this.bds_bode.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gc_bode
            // 
            this.gc_bode.DataSource = this.bds_bode;
            this.gc_bode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_bode.Location = new System.Drawing.Point(0, 106);
            this.gc_bode.MainView = this.gridView1;
            this.gc_bode.MenuManager = this.barManager1;
            this.gc_bode.Name = "gc_bode";
            this.gc_bode.Size = new System.Drawing.Size(1282, 251);
            this.gc_bode.TabIndex = 7;
            this.gc_bode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.GridControl = this.gc_bode;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.OptionsColumn.AllowEdit = false;
            this.colCAUHOI.OptionsColumn.ReadOnly = true;
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 94;
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
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.OptionsColumn.ReadOnly = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 94;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.OptionsColumn.AllowEdit = false;
            this.colNOIDUNG.OptionsColumn.ReadOnly = true;
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 94;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.OptionsColumn.AllowEdit = false;
            this.colA.OptionsColumn.ReadOnly = true;
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 94;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.OptionsColumn.AllowEdit = false;
            this.colB.OptionsColumn.ReadOnly = true;
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 94;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.OptionsColumn.AllowEdit = false;
            this.colC.OptionsColumn.ReadOnly = true;
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 94;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.OptionsColumn.AllowEdit = false;
            this.colD.OptionsColumn.ReadOnly = true;
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 94;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.OptionsColumn.AllowEdit = false;
            this.colDAP_AN.OptionsColumn.ReadOnly = true;
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 94;
            // 
            // gb_BoDe
            // 
            this.gb_BoDe.Controls.Add(cAUHOILabel);
            this.gb_BoDe.Controls.Add(this.txtCauHoi);
            this.gb_BoDe.Controls.Add(dAP_ANLabel);
            this.gb_BoDe.Controls.Add(this.txt_DapAn);
            this.gb_BoDe.Controls.Add(tRINHDOLabel);
            this.gb_BoDe.Controls.Add(this.txtTrinhDo);
            this.gb_BoDe.Controls.Add(mAGVLabel);
            this.gb_BoDe.Controls.Add(this.txtMAGV);
            this.gb_BoDe.Controls.Add(dLabel);
            this.gb_BoDe.Controls.Add(this.txt_D);
            this.gb_BoDe.Controls.Add(cLabel);
            this.gb_BoDe.Controls.Add(this.txt_C);
            this.gb_BoDe.Controls.Add(bLabel);
            this.gb_BoDe.Controls.Add(this.txt_B);
            this.gb_BoDe.Controls.Add(aLabel);
            this.gb_BoDe.Controls.Add(this.txt_A);
            this.gb_BoDe.Controls.Add(nOIDUNGLabel);
            this.gb_BoDe.Controls.Add(this.txtNoiDung);
            this.gb_BoDe.Controls.Add(mAMHLabel);
            this.gb_BoDe.Controls.Add(this.txtMAMH);
            this.gb_BoDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_BoDe.Location = new System.Drawing.Point(0, 357);
            this.gb_BoDe.Name = "gb_BoDe";
            this.gb_BoDe.Size = new System.Drawing.Size(1282, 281);
            this.gb_BoDe.TabIndex = 8;
            this.gb_BoDe.TabStop = false;
            this.gb_BoDe.Text = "Nhập bộ đề";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_bode, "CAUHOI", true));
            this.txtCauHoi.Location = new System.Drawing.Point(88, 40);
            this.txtCauHoi.MenuManager = this.barManager1;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(125, 22);
            this.txtCauHoi.TabIndex = 23;
            // 
            // txt_DapAn
            // 
            this.txt_DapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_bode, "DAP_AN", true));
            this.txt_DapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_DapAn.FormattingEnabled = true;
            this.txt_DapAn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.txt_DapAn.Location = new System.Drawing.Point(823, 208);
            this.txt_DapAn.Name = "txt_DapAn";
            this.txt_DapAn.Size = new System.Drawing.Size(121, 24);
            this.txt_DapAn.TabIndex = 22;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_bode, "TRINHDO", true));
            this.txtTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTrinhDo.FormattingEnabled = true;
            this.txtTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.txtTrinhDo.Location = new System.Drawing.Point(88, 160);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(121, 24);
            this.txtTrinhDo.TabIndex = 21;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(88, 208);
            this.txtMAGV.MenuManager = this.barManager1;
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(125, 22);
            this.txtMAGV.TabIndex = 19;
            // 
            // txt_D
            // 
            this.txt_D.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "D", true));
            this.txt_D.Location = new System.Drawing.Point(760, 164);
            this.txt_D.MenuManager = this.barManager1;
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(502, 22);
            this.txt_D.TabIndex = 15;
            // 
            // txt_C
            // 
            this.txt_C.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "C", true));
            this.txt_C.Location = new System.Drawing.Point(760, 120);
            this.txt_C.MenuManager = this.barManager1;
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(502, 22);
            this.txt_C.TabIndex = 13;
            // 
            // txt_B
            // 
            this.txt_B.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "B", true));
            this.txt_B.Location = new System.Drawing.Point(760, 78);
            this.txt_B.MenuManager = this.barManager1;
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(502, 22);
            this.txt_B.TabIndex = 11;
            // 
            // txt_A
            // 
            this.txt_A.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "A", true));
            this.txt_A.Location = new System.Drawing.Point(760, 40);
            this.txt_A.MenuManager = this.barManager1;
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(502, 22);
            this.txt_A.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_bode, "NOIDUNG", true));
            this.txtNoiDung.Location = new System.Drawing.Point(312, 41);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(399, 187);
            this.txtNoiDung.TabIndex = 7;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_bode, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(88, 99);
            this.txtMAMH.MenuManager = this.barManager1;
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(125, 22);
            this.txtMAMH.TabIndex = 3;
            // 
            // frmNhap_Bo_De
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 638);
            this.Controls.Add(this.gb_BoDe);
            this.Controls.Add(this.gc_bode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhap_Bo_De";
            this.Text = "frmNhap_Bo_De";
            this.Load += new System.EventHandler(this.frmNhap_Bo_De_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_bode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gb_BoDe.ResumeLayout(false);
            this.gb_BoDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauHoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_D.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_C.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_B.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_A.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bds_bode;
        private DS dS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gb_BoDe;
        private DevExpress.XtraEditors.TextEdit txtMAMH;
        private DevExpress.XtraGrid.GridControl gc_bode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.TextBox txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txt_C;
        private DevExpress.XtraEditors.TextEdit txt_B;
        private DevExpress.XtraEditors.TextEdit txt_A;
        private DevExpress.XtraEditors.TextEdit txt_D;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private System.Windows.Forms.ComboBox txtTrinhDo;
        private System.Windows.Forms.ComboBox txt_DapAn;
        private DevExpress.XtraEditors.TextEdit txtCauHoi;
    }
}