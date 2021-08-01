namespace TN_CSDLPT_HK3
{
    partial class frmDanhSachDangKyThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_2 = new DevExpress.XtraEditors.DateEdit();
            this.date_1 = new DevExpress.XtraEditors.DateEdit();
            this.tN_CSDLPTDataSet3 = new TN_CSDLPT_HK3.TN_CSDLPTDataSet3();
            this.sP_DanhSach_DK_ThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DanhSach_DK_ThiTableAdapter = new TN_CSDLPT_HK3.TN_CSDLPTDataSet3TableAdapters.SP_DanhSach_DK_ThiTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.TN_CSDLPTDataSet3TableAdapters.TableAdapterManager();
            this.dS = new TN_CSDLPT_HK3.DS();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOTableAdapter = new TN_CSDLPT_HK3.DSTableAdapters.COSOTableAdapter();
            this.tableAdapterManager1 = new TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSach_DK_ThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 100);
            this.panel1.TabIndex = 1;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(285, 36);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(383, 24);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.date_2);
            this.panel2.Controls.Add(this.date_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 110);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(893, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "In Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến Ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày :";
            // 
            // date_2
            // 
            this.date_2.EditValue = new System.DateTime(2021, 8, 1, 14, 19, 15, 348);
            this.date_2.Location = new System.Drawing.Point(468, 49);
            this.date_2.Name = "date_2";
            this.date_2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_2.Size = new System.Drawing.Size(136, 22);
            this.date_2.TabIndex = 1;
            // 
            // date_1
            // 
            this.date_1.EditValue = new System.DateTime(2021, 8, 1, 14, 18, 17, 0);
            this.date_1.Location = new System.Drawing.Point(155, 49);
            this.date_1.Name = "date_1";
            this.date_1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_1.Size = new System.Drawing.Size(150, 22);
            this.date_1.TabIndex = 0;
            // 
            // tN_CSDLPTDataSet3
            // 
            this.tN_CSDLPTDataSet3.DataSetName = "TN_CSDLPTDataSet3";
            this.tN_CSDLPTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DanhSach_DK_ThiBindingSource
            // 
            this.sP_DanhSach_DK_ThiBindingSource.DataMember = "SP_DanhSach_DK_Thi";
            this.sP_DanhSach_DK_ThiBindingSource.DataSource = this.tN_CSDLPTDataSet3;
            // 
            // sP_DanhSach_DK_ThiTableAdapter
            // 
            this.sP_DanhSach_DK_ThiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.TN_CSDLPTDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.dS;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAITHITableAdapter = null;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = this.cOSOTableAdapter;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TN_CSDLPT_HK3.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDanhSachDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhSachDangKyThi";
            this.Text = "frmDanhSachDangKyThi";
            this.Load += new System.EventHandler(this.frmDanhSachDangKyThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSach_DK_ThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit date_2;
        private DevExpress.XtraEditors.DateEdit date_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TN_CSDLPTDataSet3 tN_CSDLPTDataSet3;
        private System.Windows.Forms.BindingSource sP_DanhSach_DK_ThiBindingSource;
        private TN_CSDLPTDataSet3TableAdapters.SP_DanhSach_DK_ThiTableAdapter sP_DanhSach_DK_ThiTableAdapter;
        private TN_CSDLPTDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private DS dS;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}