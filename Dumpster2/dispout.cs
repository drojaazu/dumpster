using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dumpster2
{
    public partial class DispOut : UserControl
    {
        public DispOut()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.txtOut.Visible = false;
            this.pnlScroll.Visible = false;
        }

        public enum Modes
        {
            Text, Gfx
        }

        private Modes mode;
        public Modes Mode
        {
            get
            {
                return this.mode;
            }
            set
            {

                this.mode = value;
                if (this.mode == Modes.Gfx)
                {
                    if (this.picOut.Image != null)
                    {
                        this.pnlScroll.Visible = true;
                        this.txtOut.Visible = false;
                    }
                }
                else
                {
                    if (this.txtOut.Text != null)
                    {
                        this.txtOut.Visible = true;
                        this.pnlScroll.Visible = false;
                    }
                }
            }

        }

        public string OutText
        {
            get
            {
                return this.txtOut.Text;
            }
            set
            {
                if (value != null)
                {
                    this.txtOut.SuspendLayout();
                    //this.txtOut.Visible = false;
                    this.txtOut.Text = value;
                    this.txtOut.ResumeLayout();
                    this.Mode = Modes.Text;
                    //this.txtOut.Visible = true;
                }
            }
        }

        public void SetText(string In)
        {
            this.txtOut.Text = In;
        }

        public Image OutPic
        {
            get
            {
                return this.picOut.Image;
            }
            set
            {
                if (value != null)
                {
                    this.picOut.Image = value;
                    this.picOut.Height = this.picOut.Image.Height;
                    this.picOut.Width = this.picOut.Image.Width;
                    this.Mode = Modes.Gfx;
                }
            }
        }

        

        private void Output_Load(object sender, EventArgs e)
        {

        }
    }
}
