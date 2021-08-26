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
    public partial class frmAddEditTax : Form
    {
        public frmAddEditTax()
        {
            InitializeComponent();
        }

        private int _iTax_id = 0;
        public frmAddEditTax(int iTax_id)
        {
            InitializeComponent();
            _iTax_id = iTax_id;            
        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if (_iTax_id > 0)
            {
                Tax Taxedit = TaxBLL.GetTaxById(_iTax_id);
                tax = Taxedit;
            }
        }

        private Tax _Tax = new Tax();
        public Tax tax
        {
            get
            {
                decimal dout;
                _Tax.TaxName = txtTaxName.Text.Trim();
                if (decimal.TryParse(txtTaxValue.Text.Trim(), out dout))
                {
                    _Tax.TaxValue = dout;
                }
                
                return _Tax;
            }
            set
            {
                _Tax = value;
                txtTaxName.Text = _Tax.TaxName;
                txtTaxValue.Text = string.Format("{0:0.00}",_Tax.TaxValue);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tax ieadd = tax;
            if (string.IsNullOrEmpty(ieadd.TaxName))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Tax name can not be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ieadd.TaxValue < 0)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Tax must be greater than equal zero!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
        
            int irez = 0;
            if (_iTax_id > 0)
            {
                ieadd.Tax_id = _iTax_id;
                irez = TaxBLL.Update(ieadd);
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
                irez = TaxBLL.Add(ieadd);
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
