namespace ResPos
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripUser = new System.Windows.Forms.MenuStrip();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripUser = new System.Windows.Forms.StatusStrip();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newUserCms = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserCms = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserCms = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripUser.SuspendLayout();
            this.cmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripUser
            // 
            this.menuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit,
            this.toolStripMenuItem1});
            this.menuStripUser.Location = new System.Drawing.Point(0, 0);
            this.menuStripUser.Name = "menuStripUser";
            this.menuStripUser.Size = new System.Drawing.Size(476, 24);
            this.menuStripUser.TabIndex = 0;
            this.menuStripUser.Text = "UserMenuStrip";
            // 
            // FileExit
            // 
            this.FileExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(37, 20);
            this.FileExit.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // statusStripUser
            // 
            this.statusStripUser.Location = new System.Drawing.Point(0, 351);
            this.statusStripUser.Name = "statusStripUser";
            this.statusStripUser.Size = new System.Drawing.Size(476, 22);
            this.statusStripUser.TabIndex = 1;
            this.statusStripUser.Text = "statusStrip";
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserCms,
            this.editUserCms,
            this.deleteUserCms});
            this.cmsUser.Name = "contextMenuStrip1";
            this.cmsUser.Size = new System.Drawing.Size(108, 70);
            this.cmsUser.Text = "cmsUser";
            // 
            // newUserCms
            // 
            this.newUserCms.Name = "newUserCms";
            this.newUserCms.Size = new System.Drawing.Size(107, 22);
            this.newUserCms.Text = "New ";
            this.newUserCms.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // editUserCms
            // 
            this.editUserCms.Name = "editUserCms";
            this.editUserCms.Size = new System.Drawing.Size(107, 22);
            this.editUserCms.Text = "Edit";
            this.editUserCms.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteUserCms
            // 
            this.deleteUserCms.Name = "deleteUserCms";
            this.deleteUserCms.Size = new System.Drawing.Size(107, 22);
            this.deleteUserCms.Text = "Delete";
            this.deleteUserCms.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_id,
            this.Username,
            this.RoleName});
            this.dgvUsers.ContextMenuStrip = this.cmsUser;
            this.dgvUsers.Location = new System.Drawing.Point(0, 27);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(479, 330);
            this.dgvUsers.TabIndex = 3;
            // 
            // User_id
            // 
            this.User_id.DataPropertyName = "User_id";
            this.User_id.HeaderText = "Id";
            this.User_id.Name = "User_id";
            this.User_id.ReadOnly = true;
            this.User_id.Width = 80;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Emri i Përdoruesit";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 140;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Roli";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 373);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.statusStripUser);
            this.Controls.Add(this.menuStripUser);
            this.MainMenuStrip = this.menuStripUser;
            this.Name = "frmUsers";
            this.Text = "Përdoresit";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.menuStripUser.ResumeLayout(false);
            this.menuStripUser.PerformLayout();
            this.cmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUser;
        private System.Windows.Forms.StatusStrip statusStripUser;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserCms;
        private System.Windows.Forms.ToolStripMenuItem editUserCms;
        private System.Windows.Forms.ToolStripMenuItem deleteUserCms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}