namespace Dumpster2
{
    partial class frmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDumplibVersion = new System.Windows.Forms.Label();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dumpster version ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Location = new System.Drawing.Point(12, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date: ";
            // 
            // lblDumplibVersion
            // 
            this.lblDumplibVersion.AutoSize = true;
            this.lblDumplibVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDumplibVersion.Location = new System.Drawing.Point(12, 45);
            this.lblDumplibVersion.Name = "lblDumplibVersion";
            this.lblDumplibVersion.Size = new System.Drawing.Size(92, 13);
            this.lblDumplibVersion.TabIndex = 5;
            this.lblDumplibVersion.Text = "DumpLib version: ";
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.lblInfo);
            this.grpAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAbout.Location = new System.Drawing.Point(12, 58);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(262, 78);
            this.grpAbout.TabIndex = 6;
            this.grpAbout.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(256, 59);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Written by Damian Rogers (RyogaMasaki)\r\nryogamasaki@gmail.com\r\nhttp://sudden-desu" +
    ".net";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 160);
            this.Controls.Add(this.grpAbout);
            this.Controls.Add(this.lblDumplibVersion);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Dumpster";
            this.grpAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDumplibVersion;
        private System.Windows.Forms.GroupBox grpAbout;
        private System.Windows.Forms.Label lblInfo;
    }
}