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
    public partial class frmInBangDiem : Form
    {
        private BindingSource bds = new BindingSource();
        public frmInBangDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmInBangDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }

          

            cmbCoSo.DataSource = this.bds;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "TRUONG")
            {
                //bat tat theo phan quyen
                cmbCoSo.Enabled = true;
              
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
               
            }


        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về phòng ban mới!");
            }
            else
            {

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

            }
        }

        //private void btnRivew_Click(object sender, EventArgs e)
        //{

        //}

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            String maLop = cmbLOP.SelectedValue.ToString();
            String maMon = cmbMonHoc.SelectedValue.ToString();
            int lan = (int)spin_Lan.Value;

            inBangDiem rp = new inBangDiem(maLop, maMon, lan);

            rp.lb_LOP.Text = cmbLOP.Text;
            rp.lb_MonHoc.Text = cmbMonHoc.Text;

            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
