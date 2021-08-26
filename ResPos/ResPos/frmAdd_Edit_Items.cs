using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResPosBO;
using ResPosBLL;
namespace ResPos
{
    public partial class frmAdd_Edit_Items : Form
    {
        public frmAdd_Edit_Items()
        {
            InitializeComponent();
        }

        private int _iItem_Id = 0;
        public frmAdd_Edit_Items(int iItem_Id)
        {
            InitializeComponent();
            _iItem_Id = iItem_Id;            
        }

        private void frmAdd_Edit_Items_Load(object sender, EventArgs e)
        {
            BindCombobox();
            if (_iItem_Id > 0)
            {
                Items itemedit = ItemsBLL.Get_ItemsById(_iItem_Id);
                item = itemedit;
            }
        }

        private Items _item = new Items();
        public Items item
        {
            get
            {
                decimal dout;
                if (cbCategories.SelectedItem != null)
                {
                    _item.Category_id = (int)cbCategories.SelectedValue;
                }

                if (cbTax.SelectedItem != null)
                {
                    _item.Tax_id = (int)cbTax.SelectedValue;
                }

                _item.ItemName = txtItemName.Text.Trim();
                if (decimal.TryParse(txtPrice.Text.Trim(), out dout))
                {
                    _item.Price = dout;
                }
                return _item;
            }
            set
            {
                _item = value;
               cbCategories.SelectedValue = _item.Category_id.ToString();
               cbTax.SelectedValue = _item.Tax_id.ToString();
               txtItemName.Text = _item.ItemName;
               txtPrice.Text = string.Format("{0:0.00}", _item.Price); 
            }
        }

        private void BindCombobox()
        {
            DataTable dt = new DataTable();
            dt = CategoriesBLL.GetCategories();
            cbCategories.DataSource = dt;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "Category_id";

            DataTable dtTax = new DataTable();
            dtTax = TaxBLL.GetTax();
            cbTax.DataSource = dtTax;
            cbTax.DisplayMember = "TaxName";
            cbTax.ValueMember = "Tax_id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Items ieadd = item;
            if (string.IsNullOrEmpty(ieadd.ItemName))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Item name can not be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ieadd.Category_id <= 0)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Category can not be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ieadd.Price <= 0)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Price can not be empty or less then zero!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int irez = 0;
            if (_iItem_Id > 0)
            {
                ieadd.Item_id = _iItem_Id;
                irez = ItemsBLL.Update(ieadd);
                if (irez > 0)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("An error has occured!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                irez = ItemsBLL.Add(ieadd);
                if (irez > 0)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("An error has occured!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        


    }
}
