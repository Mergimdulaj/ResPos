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
namespace ResPos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();           
        }

        private void LoginValidate()
        {            
            frmLogin f = new frmLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
           
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories f = new frmCategories();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoginValidate();
            UI();
        }

        private void UI()
        {
            msMenu.Items["dataManagementToolStripMenuItem"].Visible = false;
            msMenu.Items["usersToolStripMenuItem"].Visible = false;
            if (GlobalClass.Role_id == (int)EnumUserRole.Roles.Admin)
            {
                msMenu.Items["dataManagementToolStripMenuItem"].Visible = true;
                msMenu.Items["usersToolStripMenuItem"].Visible = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItems f = new frmItems();
            f.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewOrder f = new frmNewOrder();
            f.ShowDialog();
            
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAdd_Edit_Users frmUser = new frmAdd_Edit_Users();
            //frmUser.ShowDialog();
            frmUsers fu = new frmUsers();
            fu.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosTables f = new frmPosTables();
            f.ShowDialog();
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTax f = new frmTax();
            f.ShowDialog();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyReport f = new frmDailyReport();
            f.ShowDialog();
        }
    }
}
