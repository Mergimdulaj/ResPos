namespace ResPos
{
    partial class frmOQ
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
            this.SuspendLayout();
            // 
            // lblOQ
            // 
            this.lblOQ.AutoSize = true;
            this.lblOQ.Location = new System.Drawing.Point(12, 35);
            this.lblOQ.Name = "lblOQ";
            this.lblOQ.Size = new System.Drawing.Size(33, 13);
            this.lblOQ.TabIndex = 0;
            this.lblOQ.Text = "Sasia";
            // 
            // txtOQ
            // 
            this.txtOQ.Location = new System.Drawing.Point(76, 32);
            this.txtOQ.Name = "txtOQ";
            this.txtOQ.Size = new System.Drawing.Size(119, 20);
            this.txtOQ.TabIndex = 1;
            this.txtOQ.Text = "1";
            this.txtOQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // 
            // frmOQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtOQ);
            this.Controls.Add(this.lblOQ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sasia";
            this.Load += new System.EventHandler(this.frmOQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOQ;
        private System.Windows.Forms.TextBox txtOQ;
        private System.Windows.Forms.Button btnOk;
    }
}