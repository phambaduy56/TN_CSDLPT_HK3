using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class InBaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public InBaiThi(String masv, String mamh, short lan)
        {
            InitializeComponent();

            tN_CSDLPTDataSet1.EnforceConstraints = false;

            this.sP_IN_BAI_THITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_IN_BAI_THITableAdapter.Fill(tN_CSDLPTDataSet1.SP_IN_BAI_THI, masv, mamh, lan); 
        }

    }
}
