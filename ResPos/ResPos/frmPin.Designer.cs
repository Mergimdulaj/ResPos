namespace ResPos
{
    partial class frmPin
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
            this.lblOQ = new System.Windows.Forms.Label();
            this.txtOQ = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOQ
            // 
            this.lblOQ.AutoSize = true;
            this.lblOQ.Location = new System.Drawing.Point(12, 35);
            this.lblOQ.Name = "lblOQ";
            this.lblOQ.Size = new System.Drawing.Size(22, 13);
            this.lblOQ.TabIndex = 0;
            this.lblOQ.Text = "Pin";
            // 
            // txtOQ
            // 
            this.txtOQ.Location = new System.Drawing.Point(76, 32);
            this.txtOQ.Name = "txtOQ";
            this.txtOQ.PasswordChar = '*';
            this.txtOQ.Size = new System.Drawing.Size(119, 20);
            this.txtOQ.TabIndex = 1;
            this.txtOQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOQ_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(76, 71);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 39);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 126);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // frmPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtOQ);
            this.Controls.Add(this.lblOQ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin";
            this.Load += new System.EventHandler(this.frmOQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOQ;
        private System.Windows.Forms.TextBox txtOQ;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblError;
    }
}