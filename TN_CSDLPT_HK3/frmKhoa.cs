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
    public partial class frmKhoa : Form
    {
        private BindingSource bds = new BindingSource();
        private int vitri = 0;
        String maCOSO = "";
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Khoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {



            dS.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }

            maCOSO = ((DataRowView)bds_Khoa[0])["MACS"].ToString();

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
                gbKhoa.Enabled = false;
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

                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

                maCOSO = ((DataRowView)bds_Khoa[0])["MACS"].ToString();

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them";
            vitri = bds_Khoa.Position;
            bds_Khoa.AddNew();
            txtMACS.Text = maCOSO.ToString();
            txtMACS.Enabled = false;
            Hien_thi_khi_them();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_Khoa.Position;
            Hien_thi_khi_them();
            txtMACS.Enabled = false;
            txtMAKH.Enabled = false;

        }

        private bool kiem_tra_ma_khoa()
        {
            string str = "exec SP_KIEM_MA_KHOA N'" + txtMAKH.Text + "'";

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

        private bool kiemTraTruocKhiGhi()
        {
            
           
            if (txtMAKH.Text == "")
            {
                MessageBox.Show("Mã khoa không được để rỗng!");
                txtMAKH.Focus();
                return false;
            }
            if(txtMAKH.Text.Length > 8)
            {
                MessageBox.Show("Mã khoa không được lớn hơn 8 ký tự!");
                txtMAKH.Focus();
                return false;
            }
            if (txtTENKH.Text == "")
            {
                MessageBox.Show("Tên khoa không được để rỗng!");
                txtTENKH.Focus();
                return false;
            }
            if (txtTENKH.Text.Length > 50)
            {
                MessageBox.Show("Tên khoa không được lớn hơn 50 ký tự!");
                txtTENKH.Focus();
                return false;
            }


            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.control == "Them")
                {

                    if (kiem_tra_ma_khoa() == true)
                    {
                        MessageBox.Show("Mã khoa không được trùng!");
                        txtMAKH.Focus();
                        return;
                    }

                    bds_Khoa.EndEdit();
                        bds_Khoa.ResetCurrentItem();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.dS.KHOA);
                        bds_Khoa.MoveFirst();

                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                         Btn_ban_dau();
                }
                if (Program.control == "Sua")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        bds_Khoa.EndEdit();
                        bds_Khoa.ResetCurrentItem();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.dS.KHOA);

                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        txtMACS.Enabled = true;
                        txtMAKH.Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn xóa khoa: " + txtTENKH.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                    if (bds_Lop.Count > 0)
                    {
                        MessageBox.Show("Khoa đang có lớp không thể xóa!", "", MessageBoxButtons.OK);
                        return;
                    }

                    if (bds_giaovien.Count > 0)
                    {
                        MessageBox.Show("Khoa đang có giáo viên không thể xóa!", "", MessageBoxButtons.OK);
                        return;
                    }

                try
                    {
                        bds_Khoa.RemoveCurrent();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.dS.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Fill(this.dS.KHOA);
                        return;
                    }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_Khoa.CancelEdit();
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
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

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Btn_ban_dau()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbKhoa.Enabled = false;
            gc_khoa.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gbKhoa.Enabled = true;
            gc_khoa.Enabled = false;
        }

    }
}
