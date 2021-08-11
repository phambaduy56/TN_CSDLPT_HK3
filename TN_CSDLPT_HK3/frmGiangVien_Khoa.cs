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
    public partial class frmGiangVien_Khoa : Form
    {
        // bds gia
        private BindingSource bds = new BindingSource();
        private int vitri = 0;
        String maKhoa = "";
        Stack undolist = new Stack();
        public frmGiangVien_Khoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Khoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmGiangVien_Khoa_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }

            //maKhoa = ((DataRowView)bds_Khoa[0])["MAKH"].ToString();

            cmbCoSo.DataSource = this.bds;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "TRUONG")
            {
                //bat tat theo phan quyen
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gbGiaoVien.Enabled = false;
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

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);           

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them";          
            bds_GiaoVien.AddNew();
            vitri = bds_GiaoVien.Position;
            Hien_thi_khi_them();
            txtMAGV.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            
            Hien_thi_khi_them();
            vitri = bds_GiaoVien.Position;
            undolist.Push(txtMAGV.Text + "#" + txtHO.Text + "#" + txtTEN.Text + "#" + txtDiaChi.Text);
            undolist.Push("EDIT");
            txtMAGV.Enabled = false;
        }

        private bool kiemTraTruocKhiGhi()
        {

            if (txtMAGV.Text == "")
            {
                MessageBox.Show("Mã giáo viên không được để rỗng!");
                txtMAGV.Focus();
                return false;
            }
            if(txtMAGV.Text.Length > 8)
            {
                MessageBox.Show("Mã giáo viên không được > 8");
                txtMAGV.Focus();
                return false;
            }
            if (txtHO.Text == "")
            {
                MessageBox.Show("Ho viên không được để rỗng!");
                txtHO.Focus();
                return false;
            }
            if (txtHO.Text.Length > 40)
            {
                MessageBox.Show("Mã giáo viên không được > 40!");
                txtHO.Focus();
                return false;
            }
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Ten viên không được để rỗng!");
                txtTEN.Focus();
                return false;
            }
            if (txtTEN.Text.Length > 40)
            {
                MessageBox.Show("Ten giáo viên không được > 40!");
                txtTEN.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ viên không được để rỗng!");
                txtTEN.Focus();
                return false;
            }
            if (txtDiaChi.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ viên không được > 50!");
                txtTEN.Focus();
                return false;
            }


            return true;
        }

        private bool kiem_tra_ma_GV()
        {
            string str = "exec SP_KIEM_TRA_MA_GV N'" + txtMAGV.Text + "'";

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
                    if(kiem_tra_ma_GV() == true)
                    {
                        MessageBox.Show("Mã giáo viên không được để trùng!");
                        return;
                    }    
                    if (kiemTraTruocKhiGhi())
                    {
                        bds_GiaoVien.EndEdit();
                        bds_GiaoVien.ResetCurrentItem();
                        this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                        undolist.Push(txtMAGV.Text);
                        undolist.Push("INSERT");
                        bds_GiaoVien.Position = vitri;
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        btnPhucHoi.Enabled = true;
                    }
                }
                if (Program.control == "Sua")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        bds_GiaoVien.EndEdit();
                        bds_GiaoVien.ResetCurrentItem();
                        this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                        bds_GiaoVien.Position = vitri;
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        txtMAGV.Enabled = true;
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

            if (MessageBox.Show("Bạn có muốn xóa giáo viên: " + txtHO.Text + " " + txtTEN.Text +" ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    undolist.Push(txtMAGV.Text + "#" + txtHO.Text + "#" + txtTEN.Text + "#" + txtDiaChi.Text);
                    undolist.Push("DELETE");
                    bds_GiaoVien.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    undolist.Pop();
                    undolist.Pop();
                    MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                    return;
                }

            }

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undolist.Pop();
            undolist.Pop();
            bds_GiaoVien.CancelEdit();
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
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
            gbGiaoVien.Enabled = false;
            gc_khoa.Enabled = gc_giaovien.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gbGiaoVien.Enabled = true;
            gc_khoa.Enabled = gc_giaovien.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                //lay cai key 
                //kiem tra xem no thuoc cai nao
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {

                    this.bds_GiaoVien.AddNew();
                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    txtMAGV.Text = TT_Kho[0];
                    txtHO.Text = TT_Kho[1];
                    txtTEN.Text = TT_Kho[2];
                    txtDiaChi.Text = TT_Kho[3];
                    this.bds_GiaoVien.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
                else if (statement.Equals("INSERT"))
                {
                    String MAGV = undolist.Pop().ToString();
                    int vitrixoa = bds_gv.Find("MAGV", MAGV);
                    bds_GiaoVien.Position = vitrixoa;
                    bds_GiaoVien.RemoveCurrent();


                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
                else if (statement.Equals("EDIT"))
                {


                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    bds_GiaoVien.Position = bds_gv.Find("MAGV", TT_Kho[0]);

                    txtHO.Text = TT_Kho[1];
                    txtTEN.Text = TT_Kho[2];
                    txtDiaChi.Text = TT_Kho[3];

                    this.bds_Khoa.EndEdit();
                    
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
            }
            if (undolist.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
        }
    }
}
