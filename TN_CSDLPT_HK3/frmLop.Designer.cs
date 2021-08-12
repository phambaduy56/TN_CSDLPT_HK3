namespace TN_CSDLPT_HK3
{
    partial class frmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
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
            this.bds_Lop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.KHOATableAdapter();
            this.gc_Lop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbLop = new System.Windows.Forms.GroupBox();
            this.cmbMAKH = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMLOP = new DevExpress.XtraEditors.TextEdit();
            this.bds_SinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.SINHVIENTableAdapter();
            this.bds_gvdk = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_gvdk)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(10, 49);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(100, 23);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MÃ LỚP: ";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(426, 50);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(108, 23);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TÊN LỚP: ";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(857, 50);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(118, 23);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MÃ KHOA: ";
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
            this.btnThoat,
            this.btnReload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(341, 165);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.add_16x162;
            this.btnThem.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.add_32x322;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.remove_16x162;
            this.btnSua.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.remove_32x322;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.save_16x161;
            this.btnGhi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.save_32x321;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.clear_16x162;
            this.btnXoa.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.clear_32x322;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.reset2_16x162;
            this.btnPhucHoi.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.reset2_32x322;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "RELOAD";
            this.btnReload.Id = 7;
            this.btnReload.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.refresh_16x163;
            this.btnReload.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.refresh_32x323;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.cancel_16x163;
            this.btnHuy.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.cancel_32x323;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::TN_CSDLPT_HK3.Properties.Resources.close_16x161;
            this.btnThoat.ImageOptions.LargeImage = global::TN_CSDLPT_HK3.Properties.Resources.close_32x321;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1266, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1266, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1266, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 76);
            this.panel1.TabIndex = 5;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(228, 23);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(403, 33);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ: ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_Lop
            // 
            this.bds_Lop.DataMember = "LOP";
            this.bds_Lop.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gc_Lop
            // 
            this.gc_Lop.DataSource = this.bds_Lop;
            this.gc_Lop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Lop.Location = new System.Drawing.Point(0, 106);
            this.gc_Lop.MainView = this.gridView1;
            this.gc_Lop.MenuManager = this.barManager1;
            this.gc_Lop.Name = "gc_Lop";
            this.gc_Lop.Size = new System.Drawing.Size(1266, 259);
            this.gc_Lop.TabIndex = 6;
            this.gc_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gc_Lop;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // gbLop
            // 
            this.gbLop.Controls.Add(mAKHLabel);
            this.gbLop.Controls.Add(this.cmbMAKH);
            this.gbLop.Controls.Add(tENLOPLabel);
            this.gbLop.Controls.Add(this.txtTENLOP);
            this.gbLop.Controls.Add(mALOPLabel);
            this.gbLop.Controls.Add(this.txtMLOP);
            this.gbLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLop.Location = new System.Drawing.Point(0, 365);
            this.gbLop.Name = "gbLop";
            this.gbLop.Size = new System.Drawing.Size(1266, 229);
            this.gbLop.TabIndex = 7;
            this.gbLop.TabStop = false;
            this.gbLop.Text = "Nhập thông tin lớp";
            // 
            // cmbMAKH
            // 
            this.cmbMAKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_Lop, "MAKH", true));
            this.cmbMAKH.DataSource = this.kHOABindingSource;
            this.cmbMAKH.DisplayMember = "TENKH";
            this.cmbMAKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKH.FormattingEnabled = true;
            this.cmbMAKH.Location = new System.Drawing.Point(991, 45);
            this.cmbMAKH.Name = "cmbMAKH";
            this.cmbMAKH.Size = new System.Drawing.Size(234, 31);
            this.cmbMAKH.TabIndex = 5;
            this.cmbMAKH.ValueMember = "MAKH";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Lop, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(559, 51);
            this.txtTENLOP.MenuManager = this.barManager1;
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(277, 22);
            this.txtTENLOP.TabIndex = 3;
            // 
            // txtMLOP
            // 
            this.txtMLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Lop, "MALOP", true));
            this.txtMLOP.Location = new System.Drawing.Point(125, 50);
            this.txtMLOP.MenuManager = this.barManager1;
            this.txtMLOP.Name = "txtMLOP";
            this.txtMLOP.Size = new System.Drawing.Size(263, 22);
            this.txtMLOP.TabIndex = 1;
            // 
            // bds_SinhVien
            // 
            this.bds_SinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bds_SinhVien.DataSource = this.bds_Lop;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bds_gvdk
            // 
            this.bds_gvdk.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bds_gvdk.DataSource = this.bds_Lop;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 594);
            this.Controls.Add(this.gbLop);
            this.Controls.Add(this.gc_Lop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbLop.ResumeLayout(false);
            this.gbLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_gvdk)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_Lop;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbLop;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private System.Windows.Forms.ComboBox cmbMAKH;
        private System.Windows.Forms.BindingSource bds_SinhVien;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bds_gvdk;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnReload;
    }
}