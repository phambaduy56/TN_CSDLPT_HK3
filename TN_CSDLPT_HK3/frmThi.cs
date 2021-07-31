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
    public partial class frmThi : Form
    {
        List<cauhoi> list = new List<cauhoi>();
        int giay = 0;
        int so_cau_thi = 0;
        String trinhdo = "";
        bool timeOut = false;
        int maBD = 0;
        public frmThi()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmThi_Load(object sender, EventArgs e)
        {


            dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                lb_1.Text = "MÃ GV:";
                lb_3.Text = "TÊN GV: ";
                lb_MASV.Text = Program.username;
                lb_MALOP.Text = Program.mHoten;
                lb_2.Visible = lb_TENSV.Visible 
                    = lb_4.Visible = lb_TENLOP.Visible = false;
                giay = 60 * 60;
                time_Thi.Text = "60:00";
              //  btn_Tim.Enabled = false;
                btn_BatDau.Enabled = true;
            }
            else
            {
                lb_MASV.Text = Program.MASV;
                lb_TENSV.Text = Program.username;
                lb_MALOP.Text = Program.mHoten;
                lb_TENLOP.Text = Program.mGroup;
                btn_BatDau.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(date_NgayThi.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày thi!", "", MessageBoxButtons.OK);
                date_NgayThi.Focus();
                return;
            }

            //if (date_NgayThi.DateTime.Date != DateTime.Now.Date)
            //{
            //    MessageBox.Show("Ngày thi phải là hôm nay!", "", MessageBoxButtons.OK);
            //    date_NgayThi.Focus();
            //    return;
            //}

            if(Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                String strLenh = "EXEC SP_THONG_THI N'" + cmb_MonHoc.SelectedValue.ToString()
                          + "', N'" + date_NgayThi.DateTime.ToString("yyyy-MM-dd HH:mm:ss")
                          + "', " + spin_LanThi.Value;
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                if (Program.myReader.Read() == false)
                {
                    MessageBox.Show("Thông tin đăng ký thi không tồn tại!", "", MessageBoxButtons.OK);
                }
                else
                {

                    trinhdo = Program.myReader.GetString(0);
                    lb_TrinhDo.Text = trinhdo.ToString();

                    so_cau_thi = Program.myReader.GetInt16(1);
                    lb_SoCauThi.Text = so_cau_thi.ToString();

                    //Int16 time = Program.myReader.GetInt16(2);
                    //giay = time * 60;
                    //time_Thi.Text = time.ToString() + ":00";

                    cmb_MonHoc.Enabled = false;
                    date_NgayThi.Enabled = false;
                    spin_LanThi.Enabled = false;

                }
                Program.myReader.Close();
            } 
            else
            {
                string strLenh1 = "EXEC SP_KIEM_TRA_SV N'" + Program.MASV
                + "', N'" + cmb_MonHoc.SelectedValue.ToString() +
                "', " + spin_LanThi.Value;
                Program.myReader = Program.ExecSqlDataReader(strLenh1);

                Program.myReader.Read();

                String kq = Program.myReader.GetString(0);
                //int kq = Program.ExecSqlNonQuery(strLenh1);
                // Program.myReader.Close();

                if (kq == "1")
                {
                    MessageBox.Show("Sinh viên đã thi rồi! \n Không được thi lại!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();


                String strLenh = "EXEC SP_THONG_THI N'" + cmb_MonHoc.SelectedValue.ToString()
                                + "', N'" + date_NgayThi.DateTime.ToString("yyyy-MM-dd HH:mm:ss")
                                + "', " + spin_LanThi.Value;
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                if (Program.myReader.Read() == false)
                {
                    MessageBox.Show("Thông tin đăng ký thi không tồn tại!", "", MessageBoxButtons.OK);
                }
                else
                {

                    trinhdo = Program.myReader.GetString(0);
                    lb_TrinhDo.Text = trinhdo.ToString();

                    so_cau_thi = Program.myReader.GetInt16(1);
                    lb_SoCauThi.Text = so_cau_thi.ToString();

                    Int16 time = Program.myReader.GetInt16(2);
                    giay = time * 60;
                    time_Thi.Text = time.ToString() + ":00";

                    cmb_MonHoc.Enabled = false;
                    date_NgayThi.Enabled = false;
                    spin_LanThi.Enabled = false;

                }
                Program.myReader.Close();

                
            }
            cmb_MonHoc.Enabled = false;
            date_NgayThi.Enabled = false;
            spin_LanThi.Enabled = false;
            btn_BatDau.Enabled = true;
            btn_Tim.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            int seconds = giay % 60;
            int minutes = giay / 60;
            string se = "" + seconds;
            string mi = "" + minutes;
            if (seconds < 10)
            {
                se = "0" + se;
            }
            if (minutes < 10)
            {
                mi = "0" + mi;
            }
            time_Thi.Text = mi + ":" + se;
            if (giay == 0)
            {
               timeOut = true;
               btn_BatDau.PerformClick();

                cmb_MonHoc.Enabled = true;
                date_NgayThi.Enabled = true;
                spin_LanThi.Enabled = true;
                btn_BatDau.Enabled = false;
                btn_Tim.Enabled = true;
            }
        }

        private void loadCauHoiThi()
        {
            string strLenh = "EXEC SP_lAY_CAU_HOI N'"
                    + cmb_MonHoc.SelectedValue.ToString() + "', N'"
                    + trinhdo + "', "
                    + so_cau_thi;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            list.Clear();
            panel_thi.Controls.Clear();
            int i = 0;
            while (Program.myReader.Read())
            {
                cauhoi ch = new cauhoi();
                ch.CauHoi = Program.myReader.GetInt32(0);
                ch.NoiDung = Program.myReader.GetString(1);
                ch.A = Program.myReader.GetString(2);
                ch.B = Program.myReader.GetString(3);
                ch.C = Program.myReader.GetString(4);
                ch.D = Program.myReader.GetString(5);
                ch.DapAn = Program.myReader.GetString(6);
                ch.STT = i+1;
                i++;
                list.Add(ch);
                panel_thi.Controls.Add(ch);
            }
            Program.myReader.Close();
        }

        private void setColorDapAn(cauhoi x, Color c)
        {
            if (x.DapAn == "A")
            {
                x.Rbtn_A.ForeColor = c;

            }
            else if (x.DapAn == "B")
            {
                x.Rbtn_B.ForeColor = c;
            }
            else if (x.DapAn == "C")
            {
                x.Rbtn_C.ForeColor = c;
            }
            else if (x.DapAn == "D")
            {
                x.Rbtn_D.ForeColor = c;
            }
        }

        private string getDapAn(cauhoi x)
        {
            string da = "";
            if (x.Rbtn_A.Checked == true)
            {
                da = "A";
            }
            else if (x.Rbtn_B.Checked == true)
            {
                da = "B";
            }
            else if (x.Rbtn_C.Checked == true)
            {
                da = "C";
            }
            else if (x.Rbtn_D.Checked == true)
            {
                da = "D";
            }
            return da;
        }

        private double tinhDiem()
        {
            int soCauDung = 0;
            foreach (cauhoi ch in list)
            {
                string da = getDapAn(ch);
                if (da == ch.DapAn)
                {
                    soCauDung++;
                    setColorDapAn(ch, Color.Blue);
                }
                else
                {
                    setColorDapAn(ch, Color.Red);
                }
            }

            return Math.Round((soCauDung * 10) * 1.0 / so_cau_thi, 1);
        }

        private int insertBangDiem(double diem)
        {
            //ghi vao bang diem
            string strLenh = "EXEC SP_INSERT_BANG_DIEM N'"
             + Program.MASV + "', N'"
             + cmb_MonHoc.SelectedValue.ToString() + "', "
             + spin_LanThi.Value + ", N'"
             + date_NgayThi.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', "
             + diem;

            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0)
            {
                MessageBox.Show("Lỗi ghi bảng điểm!", "", MessageBoxButtons.OK);
            }
            return kq;
        }

        private void insertBaiThi()
        {

            string strLenh1 = "EXEC SP_LAY_MA_BANG_DIEM N'"
                     + Program.MASV + "', N'"
                     + cmb_MonHoc.SelectedValue.ToString() + "', "
                     + spin_LanThi.Value;
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            maBD = Program.myReader.GetInt32(0);
            Program.myReader.Close();

            foreach (cauhoi x in list)
            {
                string da = getDapAn(x);               

                string strLenh = "EXEC SP_INSERT_BAI_THI_NEW "
                    + x.STT + ", N'"
                    + x.NoiDung.Trim() + "', N'"        
                    + x.A.Trim() + "', N'"
                    + x.B.Trim() + "', N'"
                    + x.C.Trim() + "', N'"
                    + x.D.Trim() + "', N'"
                    + x.DapAn.Trim() + "', N'"
                    + da + "', "
                    + maBD;

                Program.ExecSqlNonQuery(strLenh);
               
            }
        }

        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            
            if(timer1.Enabled == false)
            {
                btn_BatDau.Text = "NỘP BÀI";
                timer1.Start();

                loadCauHoiThi();
            }
            else
            {
                if(timeOut == true || MessageBox.Show("Bạn có thật sự muốn nộp bài ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btn_BatDau.Text = "BẮT ĐẦU";
                    timer1.Stop();
                    double diem = tinhDiem();

                    if(Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
                    {
                        MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;

                        cmb_MonHoc.Enabled = true;
                        date_NgayThi.Enabled = true;
                        spin_LanThi.Enabled = true;
                    }    
                    else
                    {
                        if (insertBangDiem(diem) == 0)
                        {
                            //ghi chi tiet bai thi
                            insertBaiThi();

                        }

                        MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;

                        cmb_MonHoc.Enabled = true;
                        date_NgayThi.Enabled = true;
                        spin_LanThi.Enabled = true;
                        btn_BatDau.Enabled = false;
                        btn_Tim.Enabled = true;
                    }
        
                }    
            }    
        }

       

    }
}
