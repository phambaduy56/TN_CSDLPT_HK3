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
    public partial class frmNhap_Bo_De : Form
    {
        private BindingSource bds = new BindingSource();
        private int vitri = 0;

        private String cauhoi = "";
        private String maGV = "";

        public frmNhap_Bo_De()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_bode.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhap_Bo_De_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            dS.EnforceConstraints = false;

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            maGV = ((DataRowView)bds_bode[0])["MAGV"].ToString();
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
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gb_BoDe.Enabled = false;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                Btn_ban_dau();
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

                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.dS.BODE);
                maGV = ((DataRowView)bds_bode[0])["MAGV"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them";
            vitri = bds_bode.Position;
            bds_bode.AddNew();

            txtMAGV.Text = Program.username.ToString();
            txtMAGV.Enabled = false;

            Hien_thi_khi_them();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_bode.Position;
            Hien_thi_khi_them();
        }

        private bool kiemTraTruocKhiGhi()
        {
            if (txtCauHoi.Text == "")
            {
                MessageBox.Show("Câu hỏi không được để rỗng!");
                txtCauHoi.Focus();
                return false;
            }
            if (txt_A.Text == "")
            {
                MessageBox.Show("Đáp án không được để rỗng!");
                txt_A.Focus();
                return false;
            }
            if (txt_B.Text == "")
            {
                MessageBox.Show("Đáp án không được để rỗng!");
                txt_B.Focus();
                return false;
            }
            if (txt_C.Text == "")
            {
                MessageBox.Show("Đáp án không được để rỗng!");
                txt_C.Focus();
                return false;
            }
            if (txt_D.Text == "")
            {
                MessageBox.Show("Đáp án không được để rỗng!");
                txt_D.Focus();
                return false;
            }
            if(txt_A.Text == txt_B.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }
            if (txt_A.Text == txt_C.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }
            if (txt_A.Text == txt_D.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }
            if (txt_B.Text == txt_C.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }
            if (txt_B.Text == txt_D.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }
            if (txt_C.Text == txt_D.Text)
            {
                MessageBox.Show("Đáp án không được trùng!");
                return false;
            }

            return true;
        }

        private bool kiem_tra_cau_hoi()
        {
            int cauhoi = int.Parse(txtCauHoi.Text);

            string str = "exec SP_KIEM_CAU_HOI N'" + cauhoi + "'";

            Program.myReader = Program.ExecSqlDataReader(str);
            Program.myReader.Read();

            String kq = Program.myReader.GetString(0);
            Program.myReader.Close();
            if (kq == "1")
            {
                return true;
            }
            return false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.control == "Them")
                {
                    if(kiem_tra_cau_hoi() == true)
                    {
                        MessageBox.Show("Câu hỏi không được trùng!");
                        txtCauHoi.Focus();
                        return;
                    }    

                    if (kiemTraTruocKhiGhi())
                    {
                        bds_bode.EndEdit();
                        bds_bode.ResetCurrentItem();
                        this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                        this.bODETableAdapter.Update(this.dS.BODE);
                        bds_bode.MoveLast();

                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                    }
                }
                if (Program.control == "Sua")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        bds_bode.EndEdit();
                        bds_bode.ResetCurrentItem();
                        this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                        this.bODETableAdapter.Update(this.dS.BODE);

                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên!" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa câu hỏi "  + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Program.username != maGV)
                {
                    MessageBox.Show("Bạn không có quyền xóa câu hỏi" , "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    bds_bode.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    return;
                }

            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_bode.CancelEdit();
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            if (Program.mGroup == "PGV")
            {
                //bat tat theo phan quyen
                cmbCoSo.Enabled = true;
            }
            else
            {
                //bat tat theo phan quyen
                cmbCoSo.Enabled = false;
            }
            Btn_ban_dau();
        }

        private void Btn_ban_dau()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gb_BoDe.Enabled = false;
            gc_bode.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gb_BoDe.Enabled = true;
            gc_bode.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
