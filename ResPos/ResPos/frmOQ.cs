using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResPos
{
    public partial class frmOQ : Form
    {
        public frmOQ()
        {
            InitializeComponent();
        }

        public int Quantrity
        {
            get
            {
                int iout;

                if(int.TryParse(txtOQ.Text.Trim(),out iout))
                {
                    return iout;
                }

                return 1;
            }
        }

        private void frmOQ_Load(object sender, EventArgs e)
        {
            txtOQ.Focus();
        }

        private void txtOQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }

    }
}
