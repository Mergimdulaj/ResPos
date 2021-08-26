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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            Get_Data();
        }
        private void Get_Data()
        {
            DataTable dt = CategoriesBLL.GetCategories();
            dgvCategories.DataSource = dt;
        }

        
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0 && dgvCategories.SelectedRows[0] != null)
            {
                int ix = int.Parse(dgvCategories.SelectedRows[0].Cells[0].Value.ToString());
                frmAddEditCategory f = new frmAddEditCategory(ix);
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
                if (dgvCategories.SelectedRows.Count > 0 && dgvCategories.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ix = int.Parse(dgvCategories.SelectedRows[0].Cells[0].Value.ToString());
                        Categories id = new Categories();
                        id.Category_id = ix;
                        CategoriesBLL.Delete(id);
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
            frmAddEditCategory f = new frmAddEditCategory();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Get_Data();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
    }
}
