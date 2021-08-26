using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ResPosBLL;
namespace ResPos
{
    public partial class frmDailyReport : Form
    {
        public frmDailyReport()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDailyReport_Load(object sender, EventArgs e)
        {
            BindCombobox();
            GetData();
        }


        private void GetData()
        {
            int? iuserid = null;
            DateTime? dOrderDateFrom = null;
            DateTime? dOrderDateTo = null;
            if ((cbUsers.SelectedItem !=null))
            {
                iuserid = int.Parse(cbUsers.SelectedValue.ToString());
            }
            if (dtpOrderDateFrom.Value!=DateTime.MinValue)
            {
                dOrderDateFrom = dtpOrderDateFrom.Value.Date;
            }

            if (dtpOrderDateTo.Value != DateTime.MinValue)
            {
                dOrderDateTo = dtpOrderDateTo.Value.Date;
            }

            if(dOrderDateFrom.HasValue && dOrderDateTo.HasValue)
            {
                if (dOrderDateFrom.Value > dOrderDateTo.Value)
                {
                    MessageBox.Show("Data prej duhet te jete me e vogel ose baraz me deri.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataTable dt = OrderBLL.GetOrdersReport(iuserid, dOrderDateFrom,dOrderDateTo);
            dgvReport.AutoGenerateColumns = false;

            dgvReport.Columns["TotalPrice"].DefaultCellStyle.Format = "0.00";
            dgvReport.Columns["OrderDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvReport.DataSource = dt;
            
            if (dt != null && dt.Rows.Count > 0)
            {
                object sumObject;
                sumObject = dt.Compute("Sum(TotalPrice)", string.Empty);
                lblTotalAmount.Text = string.Format("{0:0.00}",sumObject);
            }
        }


        private void BindCombobox()
        {
            DataTable dt = new DataTable();
            dt = UsersBLL.GetUsers();
            cbUsers.DataSource = dt;
            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "User_id";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
