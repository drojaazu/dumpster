namespace Dumpster2
{
    partial class DispOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.pnlScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.picOut);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 0);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(421, 350);
            this.pnlScroll.TabIndex = 2;
            this.pnlScroll.Visible = false;
            // 
            // picOut
            // 
            this.picOut.Location = new System.Drawing.Point(0, 0);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(421, 350);
            this.picOut.TabIndex = 5;
            this.picOut.TabStop = false;
            // 
            // txtOut
            // 
            this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.HideSelection = false;
            this.txtOut.Location = new System.Drawing.Point(0, 0);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(421, 350);
            this.txtOut.TabIndex = 3;
            this.txtOut.Visible = false;
            this.txtOut.WordWrap = false;
            // 
            // DispOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.pnlScroll);
            this.Name = "DispOut";
            this.Size = new System.Drawing.Size(421, 350);
            this.Load += new System.EventHandler(this.Output_Load);
            this.pnlScroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.TextBox txtOut;

    }
}
