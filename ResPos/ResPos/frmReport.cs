using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ResPosBLL;
namespace ResPos
{
    public partial class frmReport : Form
    {
        int iOrder_id = 0;
        public frmReport(int Order_id)
        {
            iOrder_id = Order_id;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DataTable dt = OrderDetailsBLL.Get_OrderDetailsByOrder_id(iOrder_id);
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

    }
}
