namespace Dumpster2
{
    partial class frmConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFormPadding = new System.Windows.Forms.Panel();
            this.txtConsoleOut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsoleIn = new System.Windows.Forms.TextBox();
            this.pnlFormPadding.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormPadding
            // 
            this.pnlFormPadding.Controls.Add(this.txtConsoleOut);
            this.pnlFormPadding.Controls.Add(this.panel1);
            this.pnlFormPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormPadding.Location = new System.Drawing.Point(0, 0);
            this.pnlFormPadding.Name = "pnlFormPadding";
            this.pnlFormPadding.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlFormPadding.Size = new System.Drawing.Size(881, 266);
            this.pnlFormPadding.TabIndex = 0;
            this.pnlFormPadding.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormPadding_Paint);
            // 
            // txtConsoleOut
            // 
            this.txtConsoleOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsoleOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleOut.Location = new System.Drawing.Point(12, 8);
            this.txtConsoleOut.Multiline = true;
            this.txtConsoleOut.Name = "txtConsoleOut";
            this.txtConsoleOut.ReadOnly = true;
            this.txtConsoleOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsoleOut.Size = new System.Drawing.Size(857, 220);
            this.txtConsoleOut.TabIndex = 8;
            this.txtConsoleOut.TextChanged += new System.EventHandler(this.txtConsoleOut_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConsoleIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 228);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.panel1.Size = new System.Drawing.Size(857, 30);
            this.panel1.TabIndex = 7;
            // 
            // txtConsoleIn
            // 
            this.txtConsoleIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsoleIn.Location = new System.Drawing.Point(4, 4);
            this.txtConsoleIn.Name = "txtConsoleIn";
            this.txtConsoleIn.Size = new System.Drawing.Size(849, 20);
            this.txtConsoleIn.TabIndex = 6;
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 266);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFormPadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmConsole";
            this.Text = "Console";
            this.pnlFormPadding.ResumeLayout(false);
            this.pnlFormPadding.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormPadding;
        private System.Windows.Forms.TextBox txtConsoleOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConsoleIn;
    }
}