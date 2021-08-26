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
    public partial class frmAddEditPosTables : Form
    {
        public frmAddEditPosTables()
        {
            InitializeComponent();
        }

        private int _iTable_Id = 0;
        public frmAddEditPosTables(int iTable_Id)
        {
            InitializeComponent();
            _iTable_Id = iTable_Id;            
        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if (_iTable_Id > 0)
            {
                PosTables PosTablesedit = PosTablesBLL.Get_PosTableById(_iTable_Id);
                postables = PosTablesedit;
            }
        }

        private PosTables _postables = new PosTables();
        public PosTables postables
        {
            get
            {
                _postables.TableNo = txtCategoryName.Text.Trim();
                _postables.TableDesc = txtCategoryDesc.Text.Trim();
                return _postables;
            }
            set
            {
                _postables = value;
                txtCategoryName.Text = _postables.TableNo;
                txtCategoryDesc.Text = _postables.TableDesc;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PosTables ieadd = postables;
            if (string.IsNullOrEmpty(ieadd.TableNo))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Table No can not be empty!.", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
            int irez = 0;
            if (_iTable_Id > 0)
            {
                ieadd.Table_Id = _iTable_Id;
                irez = PosTablesBLL.Update(ieadd);
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
                irez = PosTablesBLL.Add(ieadd);
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
