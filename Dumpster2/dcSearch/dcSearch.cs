using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Dumpster2
{
    public partial class dcSearch : DockContent
    {
        public dcSearch()
        {
            InitializeComponent();
        }

        private void btnASCII_Click(object sender, EventArgs e)
        {
            byte[] seq = Encoding.ASCII.GetBytes(this.txtASCII.Text);
            //dumplib.Search.Sequence()
        }

        private void btnByte_Click(object sender, EventArgs e)
        {

        }
    }
}
