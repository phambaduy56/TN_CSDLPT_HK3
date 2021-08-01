using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT_HK3
{
    public partial class InKetQuaThi : Form
    {
        public InKetQuaThi()
        {
            InitializeComponent();
        }

        private void InKetQuaThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            //lb_MASV.Text = Program.MASV;
            //lb_TENSV.Text = Program.username;
            //lb_MALOP.Text = Program.mHoten;
            //lb_TENLOP.Text = Program.mGroup;

            lbHoTen.Text = Program.username;
            lbLop.Text = Program.mGroup;
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_MonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_MonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            String msv = Program.MASV;
            String mmh = cmbMonHoc.SelectedValue.ToString();
            short lan = (short) spin_Lanthi.Value;

            InBaiThi rp = new InBaiThi(msv, mmh, lan);

            rp.lbHoTen.Text = Program.username;
            rp.lbLop.Text = Program.mGroup;
            rp.lbMonThi.Text = cmbMonHoc.Text;
            rp.lbNgayThi.Text = date_NgayThi.DateTime.ToString("yyyy-MM-dd");

            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
