using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ResPosBO;
using ResPosBLL;
namespace ResPos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Users u = UsersBLL.UserValidate(txt_username.Text.Trim(), GlobalClass.Encrypt(txt_password.Text.Trim()));
            if ((u != null) && (u.User_id > 0))
            {
                DataTable dt = UsersBLL.GetUserRole(u.User_id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    GlobalClass.Role_id = Convert.ToInt32(dt.Rows[0]["Role_id"]);
                }
                GlobalClass.User_id = u.User_id;
                GlobalClass.Username = u.Username;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Username or password is incorrect");
            }
        }

        
    }
}
