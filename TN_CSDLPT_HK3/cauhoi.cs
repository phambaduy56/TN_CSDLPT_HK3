using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT_HK3
{
    public partial class cauhoi : UserControl
    {
        public cauhoi()
        {
            InitializeComponent();
        }

        #region Properties
        private int stt;
        private int cauHoi;
        private string noiDung;
        private string a;
        private string b;
        private string c;
        private string d;
        private string dapAn;
        private String sv_Chon;

        //dung luon radioButton da keo tha vi co da co group
        //khong can xet them dk
        [Category("Custom props")]
        public int STT
        {
            get { return stt; }
            set { stt = value; lb_STT.Text = "Câu " + value + ": "; }
        }


        [Category("Custom props")]
        public String Sv_Chon
        {
            get { return sv_Chon; }
            set { sv_Chon = value; }
        }



        [Category("Custom props")]
        public int CauHoi
        {
            get { return cauHoi; }
            set { cauHoi = value; }
        }

        [Category("Custom props")]
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; lb_NoiDung.Text = value; }
        }

        [Category("Custom props")]
        public string DapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        [Category("Custom props")]
        public string A
        {
            get { return a; }
            set { a = value; lb_textA.Text = value; }
        }

        [Category("Custom props")]
        public string B
        {
            get { return b; }
            set { b = value; lb_textB.Text = value; }
        }

        [Category("Custom props")]
        public string C
        {
            get { return c; }
            set { c = value; lb_textC.Text = value; }
        }

        [Category("Custom props")]
        public string D
        {
            get { return d; }
            set { d = value; lb_textD.Text = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_A
        {
            get { return radio_A; }
            set { radio_A = value;  }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_B
        {
            get { return radio_B; }
            set { radio_B = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_C
        {
            get { return radio_C; }
            set { radio_C = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_D
        {
            get { return radio_D; }
            set { radio_D = value; }
        }
        #endregion

        private void radio_A_CheckedChanged(object sender, EventArgs e)
        {
           // radio_A.Checked = true;
        }

        private void lb_textB_Click(object sender, EventArgs e)
        {
            radio_B.Checked = true;
           
        }

        private void lb_textC_Click(object sender, EventArgs e)
        {
            radio_C.Checked = true;
        }

        private void lb_textD_Click(object sender, EventArgs e)
        {
            radio_D.Checked = true;

        }

        private void lb_textA_Click(object sender, EventArgs e)
        {
            radio_A.Checked = true;

        }

        private void cauhoi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
