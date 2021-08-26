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
    public partial class frmPin : Form
    {
        public frmPin()
        {
            InitializeComponent();
        }

        public string Pin
        {
            get
            {
                return txtOQ.Text.Trim();
            }
        }

        private void frmOQ_Load(object sender, EventArgs e)
        {
            txtOQ.Focus();
        }

        private void txtOQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            Users u = UsersBLL.UserValidate(GlobalClass.Username, txtOQ.Text.Trim());
            if ((u != null) && (u.User_id > 0))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.None;
                lblError.Text = "Invalid pin, please try again!";
            }
        }

    }
}
