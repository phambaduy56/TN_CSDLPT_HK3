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
    public partial class frmChuan_Bi_Thi : Form
    {
        private BindingSource bds = new BindingSource();
        private int vitri = 0;
        public frmChuan_Bi_Thi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_GVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmChuan_Bi_Thi_Load(object sender, EventArgs e)
        {
           
           
            dS.EnforceConstraints = false;

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

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
                gb_DangKy.Enabled = false;
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

                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them";
            vitri = bds_GVDK.Position;
            bds_GVDK.AddNew();
            txt_MAGV.Text = Program.username;

            Hien_thi_khi_them();
            cmbMonHoc.SelectedIndex = 1;
            cmbMonHoc.SelectedIndex = 0;
            cmbMaLop.SelectedIndex = 1;
            cmbMaLop.SelectedIndex = 0;
            cmbTrinhDo.SelectedIndex = 1;
            cmbTrinhDo.SelectedIndex = 0;
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_GVDK.Position;

            Hien_thi_khi_them();
        }

        private bool kiemTraTruocKhiGhi()
        {
            if (date_NgayThi.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            DateTime date1 = DateTime.Now;
            DateTime date2 = date_NgayThi.DateTime.Date;
            int compare = DateTime.Compare(date1, date2);
            if (compare > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể nhỏ hơn ngày hiện tại!");
                return false;
            }

            if (spin_lan.EditValue == null)
            {
                MessageBox.Show("Lần thi không được để trống!");
                return false;
            }

            if (spin_CauThi.EditValue == null)
            {
                MessageBox.Show("Câu thi không được để trống!");
                return false;
            }

            if (spin_TimeThi.EditValue == null)
            {
                MessageBox.Show("Thời gian không được để trống!");
                return false;
            }

            if(spin_CauThi.Value > 100)
            {
                MessageBox.Show("Số câu thi không được > 100!");
                return false;
            }

            if (spin_CauThi.Value < 10)
            {
                MessageBox.Show("Số câu thi không được < 10!");
                return false;
            }

            if(spin_TimeThi.Value < 15)
            {
                MessageBox.Show("Thời gian thi tối thiếu là 15 phút!");
                return false;
            }

            if (spin_TimeThi.Value > 60)
            {
                MessageBox.Show("Thời gian thi không được lớn hơn 60 phút!");
                return false;
            }

            if(spin_lan.Value > 2)
            {
                MessageBox.Show("Lần thi không được > 2!");
                return false;
            }

            if (spin_lan.Value < 1)
            {
                MessageBox.Show("Lần thi tối thiểu là 1!");
                return false;
            }

            return true;
        }

        private bool kiem_tra__gv_dk()
        {
            //String strLenh = "EXEC SP_THONG_THI N'" + cmb_MonHoc.SelectedValue.ToString()
            //                   + "', N'" + date_NgayThi.DateTime.ToString("yyyy-MM-dd HH:mm:ss")
            //                   + "', " + spin_LanThi.Value;

            string str = "exec SP_KT_GV_DANGKY N'" +
                            cmbMonHoc.SelectedValue.ToString()
                            + "', N'" + cmbMaLop.SelectedValue.ToString()
                            + "', " + spin_lan.Value;

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

                    //if(kiem_tra__gv_dk() == true)
                    //{
                    //    MessageBox.Show("Lớp đã đăng ký thi rồi không được thi lại");
                    //    return;
                    //}

                    if (kiemTraTruocKhiGhi())
                    {
                        bds_GVDK.EndEdit();
                        bds_GVDK.ResetCurrentItem();
                        this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                        bds_GVDK.Position = vitri;
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                    }
                }
                if (Program.control == "Sua")
                {
                   
                        bds_GVDK.EndEdit();
                        bds_GVDK.ResetCurrentItem();
                        this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                        bds_GVDK.Position = vitri;
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi !" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa giáo viên đăng ký"  + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    bds_GVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    return;
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_GVDK.CancelEdit();
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            gb_DangKy.Enabled = false;
            gc_giaoviendk.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gb_DangKy.Enabled = true;
            gc_giaoviendk.Enabled = false;
        }

    }
}
