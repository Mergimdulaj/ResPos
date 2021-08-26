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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        private void Get_Data()
        {
            dgvUsers.AutoGenerateColumns = false;
            DataTable dt = UsersBLL.GetUsers();
            dgvUsers.DataSource = dt;

 
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            Get_Data();
        }

      

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdd_Edit_Users f = new frmAdd_Edit_Users();
                if(f.ShowDialog()==DialogResult.OK)
                {
                    Get_Data();
                }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count > 0 && dgvUsers.SelectedRows[0] != null)
                {
                    int ix=int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
                    frmAdd_Edit_Users f = new frmAdd_Edit_Users(ix);
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        Get_Data();
                    }

                }
          
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvUsers.SelectedRows.Count > 0 && dgvUsers.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ix = int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
                        Users id = new Users();
                        id.User_id = ix;
                        UsersBLL.Delete(id);
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
    }
}
