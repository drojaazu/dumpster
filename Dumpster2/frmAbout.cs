using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dumpster2
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.lblTitle.Text += Program.Version.ToString(2);
            this.lblDate.Text += Program.Date.ToShortDateString();
            this.lblDumplibVersion.Text += Program.DumplibVersion.ToString(2);
        }
    }
}
