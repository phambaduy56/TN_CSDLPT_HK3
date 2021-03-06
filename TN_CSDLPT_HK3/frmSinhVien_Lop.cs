using System;
using System.Collections;
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
    public partial class frmSinhVien_Lop : Form
    {
        int vitri = 0;
        String maLop = "";
        Stack undolist = new Stack();
        private BindingSource bds = new BindingSource();
        public frmSinhVien_Lop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Lop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSinhVien_Lop_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);


            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }

           // maLop = ((DataRowView)bds_Lop[0])["MALOP"].ToString();

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
                gb_SinhVien.Enabled = false;
            }
            if(Program.mGroup == "COSO")
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


                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

                maLop = ((DataRowView)bds_Lop[0])["MALOP"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Program.control = "Them";
            vitri = bds_SinhVien.Position;
            bds_SinhVien.AddNew();

            Hien_thi_khi_them();
            gc_lop.Enabled = false;
            txtMaSv.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_Lop.Position;
            undolist.Push(txtMaSv.Text + "#" + txtHo.Text + "#" + txtTen.Text + "#" + date_NgaySinh.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "#" + txtDiaChi.Text);
            undolist.Push("EDIT");
            Hien_thi_khi_them();
            gc_lop.Enabled = false;
            txtMaSv.Enabled = false;
        }

        private bool kiem_tra_ma_sv()
        {
            string str = "exec SP_KIEM_TRA_MA_SV N'" + txtMaSv.Text + "'";

            Program.myReader = Program.ExecSqlDataReader(str);
            Program.myReader.Read();

            String kq = Program.myReader.GetString(0);
            Program.myReader.Close();
            if(kq == "1")
            {
                return true;
            }
            return false;
        }

        private bool kiemTraTruocKhiGhi()
        {

            if (txtMaSv.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được để rỗng!");
                txtMaSv.Focus();
                return false;
            }
            if(txtMaSv.Text.Length > 8)
            {
                MessageBox.Show("Mã sinh viên không được lớn hơn 8 ký tự!");
                txtMaSv.Focus();
                return false;
            }
          
            if(txtHo.Text == "")
            {
                MessageBox.Show("Họ không được để trống!");
                txtHo.Focus();
                return false;
            }
            if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ không được lớn hơn 40 ký tự!");
                txtHo.Focus();
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Họ không được để trống!");
                txtTen.Focus();
                return false;
            }
            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên không được lớn hơn 40 ký tự!");
                txtTen.Focus();
                return false;
            }
            if (date_NgaySinh.Text == "")
            {
                MessageBox.Show("Ngày sinh không được để trống!");
                date_NgaySinh.Focus();
                return false;
            }
            if (txtDiaChi.Text.Length > 40)
            {
                MessageBox.Show("Tên không được lớn hơn 40 ký tự!");
                txtTen.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                date_NgaySinh.Focus();
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
                    if (kiemTraTruocKhiGhi())
                    {
                        if (kiem_tra_ma_sv() == true)
                        {
                            MessageBox.Show("Mã sinh viên đã có vui lòng nhập mã khác!");
                            return;
                        }

                        bds_SinhVien.EndEdit();
                        bds_SinhVien.ResetCurrentItem();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        undolist.Push(txtMaSv.Text.Trim());
                        undolist.Push("INSERT");                                      
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                        bds_SinhVien.Position = vitri;
                        Btn_ban_dau();
                        gc_lop.Enabled = true;
                        btnPhucHoi.Enabled = true;
                    }
                }
                if (Program.control == "Sua")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        

                        bds_SinhVien.EndEdit();
                        bds_SinhVien.ResetCurrentItem();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        bds_SinhVien.Position = vitri;
                        Btn_ban_dau();
                        gc_lop.Enabled = true;
                        btnPhucHoi.Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn xóa khoa: " + txtHo.Text + " " + txtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (bds_BangDiem.Count > 0)
                {
                    MessageBox.Show("Sinh viên đang có điểm không thể xóa!", "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    undolist.Push(txtMaSv.Text + "#" +  txtHo.Text + "#" + txtTen.Text + "#" + date_NgaySinh.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "#" + txtDiaChi.Text);
                    undolist.Push("DELETE");
                    bds_SinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    undolist.Pop();
                    undolist.Pop();
                    MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    return;
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_SinhVien.CancelEdit();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            if (undolist.Count > 0)
            {
                undolist.Pop();
                undolist.Pop();
            }

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
            gc_lop.Enabled = true;
        }

        private void Btn_ban_dau()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gb_SinhVien.Enabled = false;
            gc_sinhvien.Enabled = gc_lop.Enabled = true;
            btnReload.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gb_SinhVien.Enabled = true;
            gc_sinhvien.Enabled = gc_lop.Enabled = false;
            btnReload.Enabled = false;

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Lop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {

                    this.bds_SinhVien.AddNew();
                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    txtMaSv.Text = TT_Kho[0];
                    txtHo.Text = TT_Kho[1];
                    txtTen.Text = TT_Kho[2];
                   // date_NgaySinh.DateTime.ToString("yyyy-MM-dd") = TT_Kho[3];
                    txtDiaChi.Text = TT_Kho[4];
                    this.bds_SinhVien.EndEdit();
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                else if (statement.Equals("INSERT"))
                {
                    String MASV = undolist.Pop().ToString();

                    int vitrixoa = bds_sv.Find("MASV", MASV);
                    bds_SinhVien.Position = vitrixoa;
                    bds_SinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                else if (statement.Equals("EDIT"))
                {


                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    bds_SinhVien.Position = bds_sv.Find("MASV", TT_Kho[0]);

                    txtHo.Text = TT_Kho[1];
                    txtTen.Text = TT_Kho[2];
                    txtDiaChi.Text = TT_Kho[4];

                    this.bds_SinhVien.EndEdit();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
            }
            if (undolist.Count == 0) btnPhucHoi.Enabled = false;
        }

       
    }
}
