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
    public partial class frmAddEditCategory : Form
    {
        public frmAddEditCategory()
        {
            InitializeComponent();
        }

        private int _iCategory_id = 0;
        public frmAddEditCategory(int iCategory_id)
        {
            InitializeComponent();
            _iCategory_id = iCategory_id;            
        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if (_iCategory_id > 0)
            {
                Categories Categoriesedit = CategoriesBLL.GetCategoryById(_iCategory_id);
                category = Categoriesedit;
            }
        }

        private Categories _categories = new Categories();
        public Categories category
        {
            get
            {
                _categories.CategoryName = txtCategoryName.Text.Trim();
                _categories.Description = txtCategoryDesc.Text.Trim();
                return _categories;
            }
            set
            {
                _categories = value;
                txtCategoryName.Text = _categories.CategoryName;
                txtCategoryDesc.Text = _categories.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories ieadd = category;
            if (string.IsNullOrEmpty(ieadd.CategoryName))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Category name can not be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
            int irez = 0;
            if (_iCategory_id > 0)
            {
                ieadd.Category_id = _iCategory_id;
                irez = CategoriesBLL.Update(ieadd);
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
                irez = CategoriesBLL.Add(ieadd);
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
