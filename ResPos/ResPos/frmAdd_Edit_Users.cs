using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResPosBLL;
using ResPosBO;

namespace ResPos
{
    public partial class frmAdd_Edit_Users : Form
    {
        public frmAdd_Edit_Users()
        {
            InitializeComponent();
        }

        private int _iUser_id = 0;
        public frmAdd_Edit_Users(int iUser_id)
        {
            _iUser_id = iUser_id;
            InitializeComponent();
        }

        private void frmAdd_Edit_Users_Load(object sender, EventArgs e)
        {
            BindCombobox();
            if (_iUser_id > 0)
            {
                txrUsername.Enabled = false;
                Users Usersdit = UsersBLL.Get_UsersById(_iUser_id);
                user = Usersdit;
            }
        }
        public Users _Users = new Users();
        public Users user
        {
            get
            {
                _Users.Username = txrUsername.Text.Trim();
                if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    _Users.Password = GlobalClass.Encrypt(txtPassword.Text.Trim());
                }
                if (cbRoles.SelectedItem != null)
                {
                    _Users.Role_id = (int)cbRoles.SelectedValue;
                }
                return _Users;
            }
            set
            {
                _Users = value;
                txrUsername.Text = _Users.Username;
                txtPassword.Text = _Users.Password;
                cbRoles.SelectedValue = _Users.Role_id.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim() != txtConfirmPwd.Text.Trim())
            {
                MessageBox.Show("password and confirm password must match!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txrUsername.Text.Trim()))
            {
                MessageBox.Show("username cannot be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Users u = new Users();
            u = user;
            int irez = 0;
            if (_iUser_id > 0)
            {
                irez = UsersBLL.Update(u);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("password and confirm password cannot be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                irez = UsersBLL.Add(u);
                DialogResult = DialogResult.OK;
            }
               
        }



        private void BindCombobox()
        {
            DataTable dt = new DataTable();
            dt = UsersBLL.GetRoles();
            cbRoles.DataSource = dt;
            cbRoles.DisplayMember = "RoleName";
            cbRoles.ValueMember = "Role_id";           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
