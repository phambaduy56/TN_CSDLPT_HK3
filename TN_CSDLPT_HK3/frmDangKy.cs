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
    public partial class frmDangKy : Form
    {
        private BindingSource bds = new BindingSource();

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            
            
            dS.EnforceConstraints = false;

            this.gIAOVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter1.Fill(this.dS.GIAOVIEN);

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
                cmbROLE.Items.Add("TRUONG");
            }
            if (Program.mGroup == "COSO")
            {

                cmbROLE.Items.Add("COSO");
                cmbROLE.Items.Add("GIAOVIEN");

                cmbCoSo.Enabled = false;
                cmbROLE.SelectedIndex = 1;
                cmbROLE.SelectedIndex = 0;  
            }
            txtTEN.Text = "";
            txtMA.Text = "";
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

            if (Program.servername == "LAPTOP-8TOCFL5N\\SERVER3")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào phòng ban này! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

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

                this.gIAOVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter1.Fill(this.dS.GIAOVIEN);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "EXEC SP_TAO_TAI_KHOAN'" + txtTEN.Text + "'," + txtPASS.Text + ",'" + txtMA.Text + "'," + cmbROLE.Text;
            Program.ExecSqlNonQuery(sql);

            MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo !", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
