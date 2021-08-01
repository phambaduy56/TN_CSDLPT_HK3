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
    public partial class frmDanhSachDangKyThi : Form
    {
        private BindingSource bds = new BindingSource();
        public frmDanhSachDangKyThi()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
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
        }

        private void frmDanhSachDangKyThi_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = date_1.DateTime.Date;
            DateTime date2 = date_2.DateTime.Date;

            if (date_1.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (date_2.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int compare = DateTime.Compare(date1, date2);
            if (compare > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }


            InDanhSachDangKyThi rp = new InDanhSachDangKyThi(date1, date2);

            rp.lb_Date1.Text = date1.ToString("dd/MM/yyyy");
            rp.lb_Date2.Text = date2.ToString("dd/MM/yyyy");

            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
