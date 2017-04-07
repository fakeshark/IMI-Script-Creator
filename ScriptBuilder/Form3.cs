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
    public partial class Form3 : Form
    {
        public Form3(string sourceText)
        {
            InitializeComponent();
            rtbSourceView.Text = sourceText;
        }

        private void btnViewClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
