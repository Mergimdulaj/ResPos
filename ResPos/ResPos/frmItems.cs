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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            Get_Data();
        }
        private void Get_Data()
        {
            DataTable dt = ItemsBLL.GetItems();
            dgvItems.DataSource = dt;
        }

        //private void brnNewItem_Click(object sender, EventArgs e)
        //{
        //    frmAdd_Edit_Items f = new frmAdd_Edit_Items(0);
        //    if (f.ShowDialog() == DialogResult.OK)
        //    {
        //        Get_Data();
        //    }
        //    //this.Close();
        //}

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0 && dgvItems.SelectedRows[0] != null)
            {
                int ix = int.Parse(dgvItems.SelectedRows[0].Cells[0].Value.ToString());
                frmAdd_Edit_Items f = new frmAdd_Edit_Items(ix);
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
                if (dgvItems.SelectedRows.Count > 0 && dgvItems.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ix = int.Parse(dgvItems.SelectedRows[0].Cells[0].Value.ToString());
                        Items id = new Items();
                        id.Item_id = ix;
                        ItemsBLL.Delete(id);
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


        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            frmAdd_Edit_Items f = new frmAdd_Edit_Items(0);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Get_Data();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}