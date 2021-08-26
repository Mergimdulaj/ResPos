using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResPosBO;
using ResPosBLL;

namespace ResPos
{
    public partial class frmTax : Form
    {
        public frmTax()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditTax f = new frmAddEditTax();
            if (f.ShowDialog() == DialogResult.OK)
                {
                    Get_Data();
                }
        }

        private void frmTax_Load(object sender, EventArgs e)
        {
            Get_Data();
        }
        private void Get_Data()
        {
            DataTable dt = TaxBLL.GetTax();
            DgvTax.DataSource = dt;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvTax.SelectedRows.Count > 0 && DgvTax.SelectedRows[0] != null)
            {
                int ix = int.Parse(DgvTax.SelectedRows[0].Cells[0].Value.ToString());
                frmAddEditTax f = new frmAddEditTax(ix);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Get_Data();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(DgvTax.SelectedRows.Count > 0 && DgvTax.SelectedRows[0] !=null)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ix = int.Parse(DgvTax.SelectedRows[0].Cells[0].Value.ToString());
                        Tax id = new Tax();
                        id.Tax_id = ix;
                        TaxBLL.Delete(id);
                        Get_Data();
                    }
                }
            }
            catch
            {
                
                MessageBox.Show("Data can not be deleted!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
