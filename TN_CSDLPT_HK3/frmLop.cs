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
    public partial class frmLop : Form
    {
        Stack undolist = new Stack();
        int vitri = 0;
        String maKhoa = "";
        private BindingSource bds = new BindingSource();

        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Lop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            
            
            dS.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }

            // maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
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
                gbLop.Enabled = false;
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

                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them"; 
            bds_Lop.AddNew();
            vitri = bds_Lop.Position;
            Hien_thi_khi_them();
            txtTENLOP.Enabled = true;
            cmbMAKH.SelectedIndex = 1;
            cmbMAKH.SelectedIndex = 0;
            txtMLOP.Enabled = true;
            cmbMAKH.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_Lop.Position;
            Hien_thi_khi_them();

            undolist.Push(txtMLOP.Text + "#" + txtTENLOP.Text + "#" + cmbMAKH.SelectedIndex);
            undolist.Push("EDIT");

            cmbMAKH.Enabled = false;
            txtMLOP.Enabled = false;
        }

        private bool kiem_tra_ma_LOP()
        {
            string str = "exec SP_KIEM_MA_LOP N'" + txtMLOP.Text + "'";

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
           
            if (txtMLOP.Text == "")
            {
                MessageBox.Show("Mã lớp không được để rỗng!");
                txtMLOP.Focus();
                return false;
            }
            if(txtMLOP.Text.Length > 8)
            {
                MessageBox.Show("Mã Lớp không được lớn hơn 8 ký tự");
            }
            if (txtTENLOP.Text == "")
            {
                MessageBox.Show("Tên lớp không được để rỗng!");
                txtTENLOP.Focus();
                return false;
            }
            if (txtTENLOP.Text.Length > 40)
            {
                MessageBox.Show("Tên lớp không được lớn hơn  ký tự");
                txtTENLOP.Focus();
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
                        if (kiem_tra_ma_LOP() == true)
                        {
                            MessageBox.Show("Mã lớp bị trùng!");
                            txtMLOP.Focus();
                            return ;
                        }

                        bds_Lop.EndEdit();
                        bds_Lop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);
                        undolist.Push(txtMLOP.Text);
                        undolist.Push("INSERT");
                        bds_Lop.Position = vitri;
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        btnPhucHoi.Enabled = true;
                    }
                }
                if (Program.control == "Sua")
                {

                        bds_Lop.EndEdit();
                        bds_Lop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);
                        bds_Lop.Position = vitri;
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        cmbMAKH.Enabled = true;
                        btnPhucHoi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên!" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khoa: " + txtTENLOP.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (bds_SinhVien.Count > 0)
                {
                    MessageBox.Show("Lớp đang có sinh viên không thể xóa!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bds_gvdk.Count > 0)
                {
                    MessageBox.Show("Lớp đang có giáo viên đăng ký không thể xóa!", "", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    undolist.Push(txtMLOP.Text + "#" + txtTENLOP.Text + "#" + cmbMAKH.SelectedIndex);
                    undolist.Push("DELETE");
                    bds_Lop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    undolist.Pop();
                    undolist.Pop();
                    MessageBox.Show("Lỗi xóa Lớp\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    return;
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                undolist.Pop();
                undolist.Pop();
            }
            bds_Lop.CancelEdit();
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
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
            gbLop.Enabled = false;
            gc_Lop.Enabled = true;
            btnReload.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gbLop.Enabled = true;
            gc_Lop.Enabled = false;
            btnReload.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {

                    this.bds_Lop.AddNew();
                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    txtMLOP.Text = TT_Kho[0];
                    txtTENLOP.Text = TT_Kho[1];
                    cmbMAKH.SelectedIndex = int.Parse(TT_Kho[2]);
                    this.bds_Lop.EndEdit();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                else if (statement.Equals("INSERT"))
                {
                    String MALOP = undolist.Pop().ToString();
                    int vitrixoa = bds_Lop.Find("MALOP", MALOP);
                    bds_Lop.Position = vitrixoa;
                    bds_Lop.RemoveCurrent();

                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                else if (statement.Equals("EDIT"))
                {


                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    bds_Lop.Position = bds_Lop.Find("MALOP", TT_Kho[0]);

                    txtTENLOP.Text = TT_Kho[1];
                    cmbMAKH.SelectedIndex = int.Parse(TT_Kho[2]);

                    this.bds_Lop.EndEdit();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
            }
            if (undolist.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }
    }
}
