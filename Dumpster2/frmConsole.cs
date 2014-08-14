using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dumpster2
{
    partial class frmConsole : Form
    {
        public frmConsole()
        {
            InitializeComponent();
        }

        private void pnlFormPadding_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ToConsole(string Text)
        {
            if (Text == null) return;
            this.txtConsoleOut.AppendText(Text+Environment.NewLine);
        }

        private void txtConsoleOut_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
