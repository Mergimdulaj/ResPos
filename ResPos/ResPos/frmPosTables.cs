using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResPosBO;
using ResPosBLL;
namespace ResPos
{
    public partial class frmPosTables : Form
    {
        public frmPosTables()
        {
            InitializeComponent();
        }

        private void frmPosTables_Load(object sender, EventArgs e)
        {
            Get_Data();
        }
        private void Get_Data()
        {
            dgvPosTables.AutoGenerateColumns = false;
            DataTable dt = PosTablesBLL.GetPosTables();
            dgvPosTables.DataSource = dt;
        }

        
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvPosTables.SelectedRows.Count > 0 && dgvPosTables.SelectedRows[0] != null)
            {
                int ix = int.Parse(dgvPosTables.SelectedRows[0].Cells[0].Value.ToString());
                frmAddEditPosTables f = new frmAddEditPosTables(ix);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Get_Data();
                }
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPosTables.SelectedRows.Count > 0 && dgvPosTables.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ix = int.Parse(dgvPosTables.SelectedRows[0].Cells[0].Value.ToString());
                        PosTables id = new PosTables();
                        id.Table_Id = ix;
                        PosTablesBLL.Delete(id);
                        Get_Data();
                    }
                }
            }
            catch
            {
                //MessageBox.Show("An error has occured!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Data can not be deleted!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPosTables f = new frmAddEditPosTables();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Get_Data();
            }
        }

       
    }
}
