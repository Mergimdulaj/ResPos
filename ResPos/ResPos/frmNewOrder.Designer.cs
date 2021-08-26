namespace ResPos
{
    partial class frmNewOrder
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
            this.gvOrderDetail = new System.Windows.Forms.DataGridView();
            this.cmsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRax = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblRezTotal = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotalWithTax = new System.Windows.Forms.Label();
            this.DGOrderDetails_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            this.cmsItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.AllowUserToAddRows = false;
            this.gvOrderDetail.AllowUserToDeleteRows = false;
            this.gvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGOrderDetails_id,
            this.DGItemName,
            this.DGQuantity,
            this.DGPrice,
            this.DGTotalTax,
            this.DGTotalPrice});
            this.gvOrderDetail.ContextMenuStrip = this.cmsItem;
            this.gvOrderDetail.Location = new System.Drawing.Point(15, 48);
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.Size = new System.Drawing.Size(520, 323);
            this.gvOrderDetail.TabIndex = 0;
            this.gvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrderDetail_CellContentClick);
            // 
            // cmsItem
            // 
            this.cmsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cmsItem.Name = "cmsItem";
            this.cmsItem.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(107, 22);
            this.tsmiDelete.Tag = "DD";
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTable.Location = new System.Drawing.Point(12, 21);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(64, 17);
            this.lblTable.TabIndex = 3;
            this.lblTable.Text = "Tavolina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura";
            // 
            // lblRax
            // 
            this.lblRax.AutoSize = true;
            this.lblRax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRax.Location = new System.Drawing.Point(37, 453);
            this.lblRax.Name = "lblRax";
            this.lblRax.Size = new System.Drawing.Size(42, 17);
            this.lblRax.TabIndex = 3;
            this.lblRax.Text = "Taksa";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(1050, 568);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 51);
            this.button13.TabIndex = 4;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(969, 568);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 51);
            this.button14.TabIndex = 4;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(1131, 568);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 51);
            this.button15.TabIndex = 4;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(760, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 126);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Shtyp Faturën";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totali i Faturës";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_id,
            this.ItemName,
            this.Price,
            this.btnAdd});
            this.dgItems.Location = new System.Drawing.Point(580, 48);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(423, 323);
            this.dgItems.TabIndex = 0;
            this.dgItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellClick);
            // 
            // cbTables
            // 
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(84, 21);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(448, 21);
            this.cbTables.TabIndex = 5;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(661, 21);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(342, 21);
            this.cbCategories.TabIndex = 5;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategories.Location = new System.Drawing.Point(577, 21);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(72, 17);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Kategoritë";
            // 
            // lblRezTotal
            // 
            this.lblRezTotal.AutoSize = true;
            this.lblRezTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezTotal.Location = new System.Drawing.Point(144, 407);
            this.lblRezTotal.Name = "lblRezTotal";
            this.lblRezTotal.Size = new System.Drawing.Size(41, 22);
            this.lblRezTotal.TabIndex = 6;
            this.lblRezTotal.Text = "... €";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.Location = new System.Drawing.Point(144, 449);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(41, 22);
            this.lblTotalTax.TabIndex = 7;
            this.lblTotalTax.Text = "... €";
            // 
            // lblTotalWithTax
            // 
            this.lblTotalWithTax.AutoSize = true;
            this.lblTotalWithTax.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWithTax.Location = new System.Drawing.Point(144, 495);
            this.lblTotalWithTax.Name = "lblTotalWithTax";
            this.lblTotalWithTax.Size = new System.Drawing.Size(46, 22);
            this.lblTotalWithTax.TabIndex = 8;
            this.lblTotalWithTax.Text = "...  €";
            // 
            // DGOrderDetails_id
            // 
            this.DGOrderDetails_id.DataPropertyName = "OrderDetails_id";
            this.DGOrderDetails_id.HeaderText = "Id";
            this.DGOrderDetails_id.Name = "DGOrderDetails_id";
            this.DGOrderDetails_id.ReadOnly = true;
            this.DGOrderDetails_id.Visible = false;
            // 
            // DGItemName
            // 
            this.DGItemName.DataPropertyName = "ItemName";
            this.DGItemName.HeaderText = "Artikulli";
            this.DGItemName.Name = "DGItemName";
            this.DGItemName.ReadOnly = true;
            this.DGItemName.Width = 150;
            // 
            // DGQuantity
            // 
            this.DGQuantity.DataPropertyName = "Quantity";
            this.DGQuantity.HeaderText = "Sasia";
            this.DGQuantity.Name = "DGQuantity";
            this.DGQuantity.ReadOnly = true;
            this.DGQuantity.Width = 80;
            // 
            // DGPrice
            // 
            this.DGPrice.DataPropertyName = "Price";
            this.DGPrice.HeaderText = "Çmimi ";
            this.DGPrice.Name = "DGPrice";
            this.DGPrice.ReadOnly = true;
            this.DGPrice.Width = 80;
            // 
            // DGTotalTax
            // 
            this.DGTotalTax.DataPropertyName = "TotalTax";
            this.DGTotalTax.HeaderText = "Taksa";
            this.DGTotalTax.Name = "DGTotalTax";
            this.DGTotalTax.ReadOnly = true;
            this.DGTotalTax.Width = 80;
            // 
            // DGTotalPrice
            // 
            this.DGTotalPrice.DataPropertyName = "TotalPrice";
            this.DGTotalPrice.HeaderText = " totali";
            this.DGTotalPrice.Name = "DGTotalPrice";
            this.DGTotalPrice.ReadOnly = true;
            this.DGTotalPrice.Width = 80;
            // 
            // Item_id
            // 
            this.Item_id.DataPropertyName = "Item_id";
            this.Item_id.HeaderText = "Id";
            this.Item_id.Name = "Item_id";
            this.Item_id.ReadOnly = true;
            this.Item_id.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Artikulli";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Çmimi ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.HeaderText = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ReadOnly = true;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseColumnTextForButtonValue = true;
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 559);
            this.Controls.Add(this.lblTotalWithTax);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.lblRezTotal);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.gvOrderDetail);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porosi e Re";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            this.cmsItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrderDetail;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRax;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblRezTotal;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotalWithTax;
        private System.Windows.Forms.ContextMenuStrip cmsItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGOrderDetails_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGTotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
    }
}