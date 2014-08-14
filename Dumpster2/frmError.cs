using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExHandle
{

    partial class frmError : Form
    {
        public frmError(string Titlebar, string Description)
        {
            InitializeComponent();   
            if (string.IsNullOrEmpty(Titlebar)) Titlebar = "Error";
            if (string.IsNullOrEmpty(Description)) Description = "(something went wrong somewhere and an error was dispatched without a description! oh no!)";
            this.Text = Titlebar;
            this.txtErr.Text = Description;
            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmError_Load(object sender, EventArgs e)
        {

        }
    }
}
