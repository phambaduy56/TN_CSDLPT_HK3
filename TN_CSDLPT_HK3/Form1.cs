using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT_HK3
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            if(Program.DANG_NHAP == 0)
            {

                MAGV.Text = "Mã GV: " + Program.username;
                TENGV.Text = "Họ Tên: " + Program.mHoten;
                NHOM.Text = "Chức vụ: " + Program.mGroup;

                //if (Program.mGroup == "TRUONG" || Program.mGroup == "COSO")
                //{               
                //    btn_ban_dau();
                //}

                if(Program.mGroup == "GIANGVIEN")
                {
                    btn_ban_dau();
                    btn_BoDe.Enabled = true;
                    btnThi.Enabled = true;
                    
                }
                if(Program.mGroup == "TRUONG")
                {
                    btnThi.Enabled = false;
                }
                
            }
            if(Program.DANG_NHAP == 1)
            {
                MAGV.Text = "Họ Tên: " + Program.username;
                TENGV.Text = "Mã LỚP: " + Program.mHoten;
                NHOM.Text = "Lớp: " + Program.mGroup;
                btn_ban_dau();
                btnThi.Enabled = true;
                btnInBaiThi.Enabled = true;
            }
 
        }

        private void btn_ban_dau()
        {
            btnMonHoc.Enabled = btn_Khoa.Enabled = btn_Lop.Enabled = btn_GiangVien.Enabled
                = btn_SinhVien.Enabled = btn_BoDe.Enabled = btn_ChuanBiThi.Enabled =
                btnThi.Enabled = false;
            btnInBangDiem.Enabled = false;
            btnInBaiThi.Enabled = false;
            btnInDanhSachThi.Enabled = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien_Lop));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien_Lop f = new frmSinhVien_Lop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiangVien_Khoa));
            if (frm != null) frm.Activate();
            else
            {
                frmGiangVien_Khoa f = new frmGiangVien_Khoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhap_Bo_De));
            if (frm != null) frm.Activate();
            else
            {
                frmNhap_Bo_De f = new frmNhap_Bo_De();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChuan_Bi_Thi));
            if (frm != null) frm.Activate();
            else
            {
                frmChuan_Bi_Thi f = new frmChuan_Bi_Thi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThi));
            if (frm != null) frm.Activate();
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(InKetQuaThi));
            if (frm != null) frm.Activate();
            else
            {
                InKetQuaThi f = new InKetQuaThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmInBangDiem f = new frmInBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDanhSachDangKyThi));
            if (frm != null) frm.Activate();
            else
            {
                frmDanhSachDangKyThi f = new frmDanhSachDangKyThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
