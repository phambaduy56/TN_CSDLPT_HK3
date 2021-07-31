using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class inBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public inBangDiem(String maLop, String maMon, int lan)
        {
            InitializeComponent();

            tN_CSDLPTDataSet3.EnforceConstraints = false;

            this.sP_IN_DS_BANG_DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_IN_DS_BANG_DIEMTableAdapter.Fill(tN_CSDLPTDataSet3.SP_IN_DS_BANG_DIEM, maLop, maMon, lan);
        }

    }
}
