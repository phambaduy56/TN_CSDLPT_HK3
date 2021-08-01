using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class InDanhSachDangKyThi : DevExpress.XtraReports.UI.XtraReport
    {
        public InDanhSachDangKyThi(DateTime date1, DateTime date2)
        {
            InitializeComponent();

            ds1.EnforceConstraints = false;

            this.sP_DanhSach_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DanhSach_DK_ThiTableAdapter.Fill(ds1.SP_DanhSach_DK_Thi, date1, date2);
        }

    }
}
