using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT_HK3
{
    public partial class frmDang_Nhap : Form
    {


        public frmDang_Nhap()
        {
            InitializeComponent();
        }

        private void frmDang_Nhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;

            cmbCoSo.Enabled = txtLogin.Enabled = txtPass.Enabled = false;
            btnDangNhap.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedIndex != -1) Program.servername = cmbCoSo.SelectedValue.ToString();

            if(Program.DANG_NHAP == 1)
            {
                if(cmbCoSo.SelectedIndex == 2)
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào đây", "báo lỗi đăng nhập", MessageBoxButtons.OK);
                    cmbCoSo.SelectedIndex = 0;
                }    
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            if(Program.DANG_NHAP == 0)
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;
                if (Program.KetNoi() == 0) return;
                Program.strlenh = " exec SP_LAY_THONG_TIN_DANG_NHAP '" + Program.mlogin + "'";

            }

            if(Program.DANG_NHAP == 1)
            {
                Program.mlogin = "HTKN";
                Program.password = "123456";
                if (Program.KetNoi() == 0) return;
                Program.strlenh = " exec SP_LAY_THONG_TIN_DANG_NHAP_SINHVIEN '" + txtLogin.Text + "'";

                Program.MASV = txtLogin.Text;
            }

            //Program.mlogin = txtLogin.Text;
            //Program.password = txtPass.Text;
            //if (Program.KetNoi() == 0) return;

            Program.mCoSo = cmbCoSo.SelectedIndex;
            SqlDataReader myReader;
            // Program.bds_dspm = bdsDSPM;

            //String strlenh = " exec SP_LAY_THONG_TIN_DANG_NHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(Program.strlenh);
            Program.bds_dspm = bds_DSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0); // lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu \n Bạn xem lại", " ", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);


            myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Đăng nhập thành công", " ", MessageBoxButtons.OK);
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.DANG_NHAP = 0;
            lb_username.Text = "USERNAME: ";
            txtPass.Enabled = txtLogin.Enabled = cmbCoSo.Enabled = true;
            btnDangNhap.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.DANG_NHAP = 1;
            lb_username.Text = "Mã SV: ";
            btnDangNhap.Enabled = txtLogin.Enabled = cmbCoSo.Enabled = true;
            txtPass.Enabled = false;
        }
    }
}
