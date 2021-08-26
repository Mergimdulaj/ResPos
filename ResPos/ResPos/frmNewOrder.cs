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
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

                
        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            BindCombobox();
            UI();
        }


        private void UI()
        {
            btnClose.Enabled = false;
            if(Order_id > 0 && gvOrderDetail.RowCount > 0)
            {
                btnClose.Enabled = true;
            }
        }
       
        private void BindCombobox()
        {
            BindCategories();
            BindTables();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategories.SelectedItem != null)
            {
                DataRowView dr = (DataRowView)cbCategories.SelectedItem;
                int iCategoryId = int.Parse(dr["Category_id"].ToString());
                GetItemDataByCategoryid(iCategoryId);
            }
        }

        private void GetItemDataByCategoryid(int Category_id)
        {
            DataTable dt = ItemsBLL.Get_ItemsCategory_id(Category_id);
            dgItems.DataSource = dt;
        }


        private void BindCategories()
        {
            DataTable dt = new DataTable();
            dt = CategoriesBLL.GetCategories();
            cbCategories.DataSource = dt;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "Category_id";

            if (cbCategories.SelectedIndex > 0)
            {
                DataRowView dr = (DataRowView)cbCategories.SelectedItem;
                int iCategoryId = int.Parse(dr["Category_id"].ToString());
                GetItemDataByCategoryid(iCategoryId);
            }
        }

        private void BindTables()
        {
            DataTable dt = new DataTable();
            dt = PosTablesBLL.GetPosTables();
            cbTables.DataSource = dt;
            cbTables.DisplayMember = "TableNo";
            cbTables.ValueMember = "Table_Id";    
        }


        private void BindItems(int Order_Id)
        {
            lblRezTotal.Text =
                lblTotalTax.Text =
                lblTotalWithTax.Text = "...";

            decimal dTotalTax = 0;
            decimal dTotalPrice = 0;
            decimal dTotalWithTax = 0;

            DataTable dt = new DataTable();
            dt = OrderDetailsBLL.Get_OrderDetailsByOrder_id(Order_Id);
            foreach (DataRow dr in dt.Rows)
            {
                dTotalTax = dTotalTax + Convert.ToDecimal(dr["TotalTax"]);
                dTotalPrice = dTotalPrice + Convert.ToDecimal(dr["TotalPrice"]);
            }
            dTotalWithTax = dTotalTax + dTotalPrice;

            lblRezTotal.Text = string.Format("{0:0.00}", dTotalPrice);
            lblTotalTax.Text = string.Format("{0:0.00}", dTotalTax);
            lblTotalWithTax.Text = string.Format("{0:0.00}", dTotalWithTax);

            gvOrderDetail.AutoGenerateColumns = false;
            gvOrderDetail.DataSource = dt;
            UI();
        }


        int Order_id = 0;
        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRezTotal.Text =
               lblTotalTax.Text =
               lblTotalWithTax.Text = "...";

            gvOrderDetail.DataSource = null;
            Order_id = 0;
            if (cbTables.SelectedItem != null)
            {
                DataRowView dr = (DataRowView)cbTables.SelectedItem;
                int iTable_Id = int.Parse(dr["Table_Id"].ToString());
                DataTable dt = OrderBLL.GetOrderOpenByTableId(iTable_Id);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow drx = dt.Rows[0];
                        Order_id = int.Parse(drx["Order_id"].ToString());
                        BindItems(Order_id);
                    }
                }
            }
            UI();
        }


        private int? TableID
        {
            get
            {
                int? tid = null;
                if (cbTables.SelectedItem != null)
                {
                    DataRowView dr = (DataRowView)cbTables.SelectedItem;
                    tid = int.Parse(dr["Table_Id"].ToString());                    
                }
                return tid;
            }
        }

        private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgItems.Columns["btnAdd"].Index && e.RowIndex >= 0)
            {
                if (Order_id == 0)
                {
                    if (TableID.HasValue)
                    {
                        Orders o = new Orders();
                        o.User_id = GlobalClass.User_id;
                        o.Table_Id = TableID.Value;
                        int iret = OrderBLL.Add(o);
                        if (iret > 0)
                        {
                            Order_id = o.Order_id;
                            int iid = int.Parse(dgItems.Rows[e.RowIndex].Cells["Item_id"].Value.ToString());
                            AddOrderDetail(iid);
                            cbTables_SelectedIndexChanged(null, null);
                        }
                    }                    
                }
                else
                {
                    if (Order_id > 0)
                    {
                       int iid=  int.Parse(dgItems.Rows[e.RowIndex].Cells["Item_id"].Value.ToString());
                       AddOrderDetail(iid);
                    }
                }
            }
        }

        private void AddOrderDetail(int Item_id)
        {
            frmOQ f = new frmOQ();
            if (f.ShowDialog() == DialogResult.OK)
            {
                OrderDetails od = new OrderDetails();
                od.Order_id = Order_id;
                od.Item_id = Item_id;
                od.Quantity = f.Quantrity;
                int iodrez = 0;
                iodrez = OrderDetailsBLL.Add(od);
                if (iodrez > 0)
                {
                    BindItems(Order_id);
                    cbTables_SelectedIndexChanged(null, null);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to print bill?", "ResPos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Order_id > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    Orders o = new Orders();
                    o.Order_id = Order_id;
                    int iodrez = 0;
                    iodrez = OrderBLL.Close(o);
                    if (iodrez > 0)
                    {
                        BindItems(Order_id);
                        cbTables_SelectedIndexChanged(null, null);                        
                        frmReport f = new frmReport(iodrez);
                        f.ShowDialog();
                    }
                    Cursor = Cursors.Default;
                }

                Cursor = Cursors.Default;
            }
        }     


      
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            deleteod();            
        }

        private void deleteod()
        {
            if (MessageBox.Show("Are you sure you want to delete?", "ResPos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gvOrderDetail.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow dr in gvOrderDetail.SelectedRows)
                    {
                        int iodid = int.Parse(dr.Cells["DGOrderDetails_id"].Value.ToString());
                        OrderDetails od = new OrderDetails();
                        od.OrderDetails_id = iodid;
                        OrderDetailsBLL.Delete(od);
                    }
                    BindItems(Order_id);
                }
            }
        }

        private void frmNewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //PinValidate();
        }

        private void PinValidate()
        {
            frmPin f = new frmPin();
            this.Visible = false;
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                f.Close();
            }

        }

        private void gvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
