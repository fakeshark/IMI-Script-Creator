using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptBuilder
{
    public partial class setTopLevelTag : Form
    {
        public setTopLevelTag(string setTag)
        {
            InitializeComponent();
            txtTag.Text = setTag;
        }

        private void btnTopLevelSave_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.topLevelTag = txtTag.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
