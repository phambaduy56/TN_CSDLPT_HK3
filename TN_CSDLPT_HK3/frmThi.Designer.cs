namespace TN_CSDLPT_HK3
{
    partial class frmThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time_Thi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_TENLOP = new System.Windows.Forms.Label();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_MALOP = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_TENSV = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_MASV = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BatDau = new System.Windows.Forms.Button();
            this.lb_SoCauThi = new System.Windows.Forms.Label();
            this.lb_TrinhDo = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.lb_So = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spin_LanThi = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.date_NgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmb_MonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN_CSDLPT_HK3.DS();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.MONHOCTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.baithiTableAdapter1 = new TN_CSDLPT_HK3.DSTableAdapters.BAITHITableAdapter();
            this.panel_thi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            mAMHLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_LanThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(6, 57);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(83, 19);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Môn Học:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.time_Thi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lb_TENLOP);
            this.groupBox1.Controls.Add(this.lb_4);
            this.groupBox1.Controls.Add(this.lb_MALOP);
            this.groupBox1.Controls.Add(this.lb_3);
            this.groupBox1.Controls.Add(this.lb_TENSV);
            this.groupBox1.Controls.Add(this.lb_2);
            this.groupBox1.Controls.Add(this.lb_MASV);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // time_Thi
            // 
            this.time_Thi.AutoSize = true;
            this.time_Thi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Thi.Location = new System.Drawing.Point(1020, 46);
            this.time_Thi.Name = "time_Thi";
            this.time_Thi.Size = new System.Drawing.Size(107, 39);
            this.time_Thi.TabIndex = 9;
            this.time_Thi.Text = "00:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(859, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "THỜI GIAN:";
            // 
            // lb_TENLOP
            // 
            this.lb_TENLOP.AutoSize = true;
            this.lb_TENLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TENLOP.Location = new System.Drawing.Point(651, 95);
            this.lb_TENLOP.Name = "lb_TENLOP";
            this.lb_TENLOP.Size = new System.Drawing.Size(60, 23);
            this.lb_TENLOP.TabIndex = 7;
            this.lb_TENLOP.Text = "label7";
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.Location = new System.Drawing.Point(541, 95);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(103, 23);
            this.lb_4.TabIndex = 6;
            this.lb_4.Text = "TÊN LỚP:";
            // 
            // lb_MALOP
            // 
            this.lb_MALOP.AutoSize = true;
            this.lb_MALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MALOP.Location = new System.Drawing.Point(651, 39);
            this.lb_MALOP.Name = "lb_MALOP";
            this.lb_MALOP.Size = new System.Drawing.Size(60, 23);
            this.lb_MALOP.TabIndex = 5;
            this.lb_MALOP.Text = "label5";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(541, 39);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(104, 23);
            this.lb_3.TabIndex = 4;
            this.lb_3.Text = "MÃ LỚP : ";
            // 
            // lb_TENSV
            // 
            this.lb_TENSV.AutoSize = true;
            this.lb_TENSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TENSV.Location = new System.Drawing.Point(246, 95);
            this.lb_TENSV.Name = "lb_TENSV";
            this.lb_TENSV.Size = new System.Drawing.Size(60, 23);
            this.lb_TENSV.TabIndex = 3;
            this.lb_TENSV.Text = "label3";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(159, 95);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(85, 23);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "TÊN SV:";
            // 
            // lb_MASV
            // 
            this.lb_MASV.AutoSize = true;
            this.lb_MASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MASV.Location = new System.Drawing.Point(245, 39);
            this.lb_MASV.Name = "lb_MASV";
            this.lb_MASV.Size = new System.Drawing.Size(60, 23);
            this.lb_MASV.TabIndex = 1;
            this.lb_MASV.Text = "label2";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(159, 39);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(77, 23);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "MÃ SV:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btn_BatDau);
            this.groupBox2.Controls.Add(this.lb_SoCauThi);
            this.groupBox2.Controls.Add(this.lb_TrinhDo);
            this.groupBox2.Controls.Add(this.btn_Tim);
            this.groupBox2.Controls.Add(this.lb_So);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.spin_LanThi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.date_NgayThi);
            this.groupBox2.Controls.Add(mAMHLabel);
            this.groupBox2.Controls.Add(this.cmb_MonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1353, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thi";
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.AutoSize = true;
            this.btn_BatDau.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatDau.Location = new System.Drawing.Point(1240, 40);
            this.btn_BatDau.Name = "btn_BatDau";
            this.btn_BatDau.Size = new System.Drawing.Size(110, 48);
            this.btn_BatDau.TabIndex = 13;
            this.btn_BatDau.Text = "Bắt Đầu";
            this.btn_BatDau.UseVisualStyleBackColor = true;
            this.btn_BatDau.Click += new System.EventHandler(this.btn_BatDau_Click);
            // 
            // lb_SoCauThi
            // 
            this.lb_SoCauThi.AutoSize = true;
            this.lb_SoCauThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoCauThi.Location = new System.Drawing.Point(1034, 57);
            this.lb_SoCauThi.Name = "lb_SoCauThi";
            this.lb_SoCauThi.Size = new System.Drawing.Size(61, 23);
            this.lb_SoCauThi.TabIndex = 12;
            this.lb_SoCauThi.Text = "< 100 ";
            // 
            // lb_TrinhDo
            // 
            this.lb_TrinhDo.AutoSize = true;
            this.lb_TrinhDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrinhDo.Location = new System.Drawing.Point(833, 56);
            this.lb_TrinhDo.Name = "lb_TrinhDo";
            this.lb_TrinhDo.Size = new System.Drawing.Size(71, 23);
            this.lb_TrinhDo.TabIndex = 11;
            this.lb_TrinhDo.Text = "A, B, C";
            // 
            // btn_Tim
            // 
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(1128, 40);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(88, 48);
            this.btn_Tim.TabIndex = 10;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_So
            // 
            this.lb_So.AutoSize = true;
            this.lb_So.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_So.Location = new System.Drawing.Point(916, 56);
            this.lb_So.Name = "lb_So";
            this.lb_So.Size = new System.Drawing.Size(115, 23);
            this.lb_So.TabIndex = 9;
            this.lb_So.Text = "Số Câu Thi :";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(729, 54);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(98, 23);
            this.lb.TabIndex = 7;
            this.lb.Text = "Trình độ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lần";
            // 
            // spin_LanThi
            // 
            this.spin_LanThi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_LanThi.Location = new System.Drawing.Point(633, 51);
            this.spin_LanThi.Margin = new System.Windows.Forms.Padding(4);
            this.spin_LanThi.Name = "spin_LanThi";
            this.spin_LanThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spin_LanThi.Properties.Appearance.Options.UseFont = true;
            this.spin_LanThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_LanThi.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spin_LanThi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_LanThi.Size = new System.Drawing.Size(78, 28);
            this.spin_LanThi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Thi";
            // 
            // date_NgayThi
            // 
            this.date_NgayThi.EditValue = null;
            this.date_NgayThi.Location = new System.Drawing.Point(414, 52);
            this.date_NgayThi.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgayThi.Name = "date_NgayThi";
            this.date_NgayThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date_NgayThi.Properties.Appearance.Options.UseFont = true;
            this.date_NgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Size = new System.Drawing.Size(148, 28);
            this.date_NgayThi.TabIndex = 2;
            // 
            // cmb_MonHoc
            // 
            this.cmb_MonHoc.DataSource = this.mONHOCBindingSource;
            this.cmb_MonHoc.DisplayMember = "TENMH";
            this.cmb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MonHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MonHoc.FormattingEnabled = true;
            this.cmb_MonHoc.Location = new System.Drawing.Point(95, 54);
            this.cmb_MonHoc.Name = "cmb_MonHoc";
            this.cmb_MonHoc.Size = new System.Drawing.Size(210, 27);
            this.cmb_MonHoc.TabIndex = 1;
            this.cmb_MonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // baithiTableAdapter1
            // 
            this.baithiTableAdapter1.ClearBeforeFill = true;
            // 
            // panel_thi
            // 
            this.panel_thi.AutoScroll = true;
            this.panel_thi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_thi.Location = new System.Drawing.Point(0, 264);
            this.panel_thi.Name = "panel_thi";
            this.panel_thi.Size = new System.Drawing.Size(1353, 324);
            this.panel_thi.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1193, 46);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 39);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1353, 588);
            this.Controls.Add(this.panel_thi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_LanThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label time_Thi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_TENLOP;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_MALOP;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_TENSV;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_MASV;
        private System.Windows.Forms.Label lb_1;
        private DS dS;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cmb_MonHoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_So;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit spin_LanThi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit date_NgayThi;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label lb_SoCauThi;
        private System.Windows.Forms.Label lb_TrinhDo;
        private System.Windows.Forms.Button btn_BatDau;
        private DSTableAdapters.BAITHITableAdapter baithiTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel panel_thi;
        private System.Windows.Forms.Button btnThoat;
    }
}