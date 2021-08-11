using System;
using System.Collections;
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
    public partial class frmMonHoc : Form
    {
        private BindingSource bds = new BindingSource();
        int vitri = 0;

        Stack undolist = new Stack();

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_MonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;

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
                gbMonHoc.Enabled = false;
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

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Them";
            bds_MonHoc.AddNew();
            vitri = bds_MonHoc.Position;
            Hien_thi_khi_them();
            txtMAMH.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.control = "Sua";
            vitri = bds_MonHoc.Position;

            txtMAMH.Enabled = false;

            undolist.Push(txtMAMH.Text + "#" + txtTENMH.Text);
            undolist.Push("EDIT");

            Hien_thi_khi_them();
        }

        private bool kiemTraTruocKhiGhi()
        {
            if (txtMAMH.Text == "")
            {
                MessageBox.Show("Mã môn không được rỗng");
                txtMAMH.Focus();
                return false;
            }
            if(txtMAMH.Text.Length > 5 )
            {
                MessageBox.Show("Mã môn tối đa 5 ký tự ");
                txtMAMH.Focus();
                return false;
            }
            if(txtTENMH.Text == "")
            {
                MessageBox.Show("Tên môn học không được trống!");
                txtTENMH.Focus();
                return false;
            }
            if(txtTENMH.Text.Length > 40 )
            {

                MessageBox.Show("Tên môn học tối đa 40 ký tự!s");
                txtTENMH.Focus();
                return false;
            }
           

            
            return true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (Program.control == "Them")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        if (kiem_tra_mon_hoc())
                        {
                            MessageBox.Show("Tên môn học và mã môn không được trùng");
                            txtTENMH.Focus();
                            return ;
                        }
                        bds_MonHoc.EndEdit();
                        bds_MonHoc.ResetCurrentItem();
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                        undolist.Push(txtMAMH.Text);
                        undolist.Push("INSERT");
                        bds_MonHoc.Position = vitri;
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);         
                        Btn_ban_dau();
                        btnPhucHoi.Enabled = true;
                    }
                }
                if (Program.control == "Sua")
                {
                    if (kiemTraTruocKhiGhi())
                    {
                        bds_MonHoc.EndEdit();
                        bds_MonHoc.ResetCurrentItem();
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        Btn_ban_dau();
                        btnPhucHoi.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên!" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void Btn_ban_dau()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled  = btnHuy.Enabled = false;
            gbMonHoc.Enabled = false;
            gc_monhoc.Enabled = true;
        }

        private void Hien_thi_khi_them()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gbMonHoc.Enabled = true;
            gc_monhoc.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_MonHoc.CancelEdit();
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            Btn_ban_dau();
            if(undolist.Count > 0)
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
                cmbCoSo.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa môn học " + txtTENMH.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              
                try
                {
                    undolist.Push(txtMAMH.Text + "#" + txtTENMH.Text);
                    undolist.Push("DELETE");
                    bds_MonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học\n" + ex.Message, "", MessageBoxButtons.OK);
                    undolist.Pop();
                    undolist.Pop();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                }
            }
        }

        private bool kiem_tra_mon_hoc()
        {
            SqlConnection con = new SqlConnection(Program.connstr);
            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter returnValue = new SqlParameter();
            SqlParameter input = new SqlParameter();

            returnValue.ParameterName = "@returnValue";
            returnValue.SqlDbType = SqlDbType.Int;
            returnValue.Direction = ParameterDirection.ReturnValue;

            input.ParameterName = "@MAMH";
            input.SqlDbType = SqlDbType.NChar;
            input.Direction = ParameterDirection.Input;
            input.Value = txtMAMH.Text;

            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SP_KT_MON_HOC_TON_TAI";
            sqlCommand.Parameters.Add(returnValue);
            sqlCommand.Parameters.Add(input);
            sqlCommand.ExecuteNonQuery();
            if ((int)returnValue.Value == 1)
            {
                return true;
            }
            return false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    
                    this.bds_MonHoc.AddNew();
                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    txtMAMH.Text = TT_Kho[0];
                    txtTENMH.Text = TT_Kho[1];
                    this.bds_MonHoc.EndEdit();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                else if (statement.Equals("INSERT"))
                {
                    String MAMH = undolist.Pop().ToString();
                    int vitrixoa = bds_MonHoc.Find("MAMH", MAMH);
                    bds_MonHoc.Position = vitrixoa;
                    bds_MonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                else if (statement.Equals("EDIT"))
                {


                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    bds_MonHoc.Position = bds_MonHoc.Find("MAMH", TT_Kho[0]);

                    txtTENMH.Text = TT_Kho[0];

                    this.bds_MonHoc.EndEdit();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
            }
            if (undolist.Count == 0) btnPhucHoi.Enabled = false;
        }
    }
}
