namespace Dumpster2
{
    partial class frmImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImage));
            this.stripMain = new System.Windows.Forms.ToolStrip();
            this.strip_lblStartAddr = new System.Windows.Forms.ToolStripLabel();
            this.strip_txtStart = new System.Windows.Forms.ToolStripTextBox();
            this.strip_btnEnd = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuEndOffset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLength = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_txtEnd = new System.Windows.Forms.ToolStripTextBox();
            this.strip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.strip_btnRaw = new System.Windows.Forms.ToolStripButton();
            this.strip_btnText = new System.Windows.Forms.ToolStripButton();
            this.strip_btnGfx = new System.Windows.Forms.ToolStripButton();
            this.strip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.strip_btnLoad = new System.Windows.Forms.ToolStripButton();
            this.strip_btnExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuExportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.dispOut = new Dumpster2.DispOut();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.status_lblChunkAddr = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lblFileInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lblImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripMain.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripMain
            // 
            this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_lblStartAddr,
            this.strip_txtStart,
            this.strip_btnEnd,
            this.strip_txtEnd,
            this.strip_Separator1,
            this.strip_btnRaw,
            this.strip_btnText,
            this.strip_btnGfx,
            this.strip_Separator2,
            this.strip_btnLoad,
            this.strip_btnExport});
            this.stripMain.Location = new System.Drawing.Point(0, 0);
            this.stripMain.Name = "stripMain";
            this.stripMain.Padding = new System.Windows.Forms.Padding(0);
            this.stripMain.Size = new System.Drawing.Size(734, 25);
            this.stripMain.TabIndex = 0;
            this.stripMain.Text = "toolStrip1";
            // 
            // strip_lblStartAddr
            // 
            this.strip_lblStartAddr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_lblStartAddr.Name = "strip_lblStartAddr";
            this.strip_lblStartAddr.Size = new System.Drawing.Size(54, 22);
            this.strip_lblStartAddr.Text = "Address:";
            // 
            // strip_txtStart
            // 
            this.strip_txtStart.Name = "strip_txtStart";
            this.strip_txtStart.Size = new System.Drawing.Size(100, 25);
            // 
            // strip_btnEnd
            // 
            this.strip_btnEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strip_btnEnd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEndOffset,
            this.mnuLength});
            this.strip_btnEnd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("strip_btnEnd.Image")));
            this.strip_btnEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnEnd.Name = "strip_btnEnd";
            this.strip_btnEnd.Size = new System.Drawing.Size(56, 22);
            this.strip_btnEnd.Text = "Length";
            // 
            // mnuEndOffset
            // 
            this.mnuEndOffset.Name = "mnuEndOffset";
            this.mnuEndOffset.Size = new System.Drawing.Size(129, 22);
            this.mnuEndOffset.Text = "End Offset";
            this.mnuEndOffset.Click += new System.EventHandler(this.mnuEndOffset_Click);
            // 
            // mnuLength
            // 
            this.mnuLength.Name = "mnuLength";
            this.mnuLength.Size = new System.Drawing.Size(129, 22);
            this.mnuLength.Text = "Length";
            this.mnuLength.Click += new System.EventHandler(this.mnuLength_Click);
            // 
            // strip_txtEnd
            // 
            this.strip_txtEnd.Name = "strip_txtEnd";
            this.strip_txtEnd.Size = new System.Drawing.Size(100, 25);
            // 
            // strip_Separator1
            // 
            this.strip_Separator1.Name = "strip_Separator1";
            this.strip_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // strip_btnRaw
            // 
            this.strip_btnRaw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strip_btnRaw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnRaw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnRaw.Name = "strip_btnRaw";
            this.strip_btnRaw.Size = new System.Drawing.Size(34, 22);
            this.strip_btnRaw.Text = "Raw";
            this.strip_btnRaw.Click += new System.EventHandler(this.strip_btnRaw_Click);
            // 
            // strip_btnText
            // 
            this.strip_btnText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strip_btnText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnText.Name = "strip_btnText";
            this.strip_btnText.Size = new System.Drawing.Size(32, 22);
            this.strip_btnText.Text = "Text";
            this.strip_btnText.Click += new System.EventHandler(this.strip_btnText_Click);
            // 
            // strip_btnGfx
            // 
            this.strip_btnGfx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strip_btnGfx.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnGfx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnGfx.Name = "strip_btnGfx";
            this.strip_btnGfx.Size = new System.Drawing.Size(59, 22);
            this.strip_btnGfx.Text = "Graphics";
            this.strip_btnGfx.Click += new System.EventHandler(this.strip_btnGfx_Click);
            // 
            // strip_Separator2
            // 
            this.strip_Separator2.Name = "strip_Separator2";
            this.strip_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // strip_btnLoad
            // 
            this.strip_btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnLoad.Name = "strip_btnLoad";
            this.strip_btnLoad.Size = new System.Drawing.Size(37, 22);
            this.strip_btnLoad.Text = "Load";
            this.strip_btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.strip_btnLoad.Click += new System.EventHandler(this.strip_btnLoad_Click);
            // 
            // strip_btnExport
            // 
            this.strip_btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strip_btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportRaw,
            this.mnuExport});
            this.strip_btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strip_btnExport.Image = ((System.Drawing.Image)(resources.GetObject("strip_btnExport.Image")));
            this.strip_btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btnExport.Name = "strip_btnExport";
            this.strip_btnExport.Size = new System.Drawing.Size(57, 22);
            this.strip_btnExport.Text = "Export";
            // 
            // mnuExportRaw
            // 
            this.mnuExportRaw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuExportRaw.Name = "mnuExportRaw";
            this.mnuExportRaw.Size = new System.Drawing.Size(177, 22);
            this.mnuExportRaw.Text = "Export raw data...";
            this.mnuExportRaw.Click += new System.EventHandler(this.mnuExportRaw_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(177, 22);
            this.mnuExport.Text = "Export conversion...";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // dispOut
            // 
            this.dispOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dispOut.Location = new System.Drawing.Point(8, 8);
            this.dispOut.Mode = Dumpster2.DispOut.Modes.Text;
            this.dispOut.Name = "dispOut";
            this.dispOut.OutPic = null;
            this.dispOut.OutText = "";
            this.dispOut.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.dispOut.Size = new System.Drawing.Size(718, 447);
            this.dispOut.TabIndex = 3;
            // 
            // pnlOut
            // 
            this.pnlOut.AutoScroll = true;
            this.pnlOut.Controls.Add(this.dispOut);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOut.Location = new System.Drawing.Point(0, 25);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Padding = new System.Windows.Forms.Padding(8);
            this.pnlOut.Size = new System.Drawing.Size(734, 463);
            this.pnlOut.TabIndex = 1;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lblChunkAddr,
            this.status_lblSpacer,
            this.status_lblFileInfo,
            this.status_lblImageInfo});
            this.statusMain.Location = new System.Drawing.Point(0, 488);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(734, 24);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 8;
            this.statusMain.Text = "statusStrip1";
            // 
            // status_lblChunkAddr
            // 
            this.status_lblChunkAddr.Name = "status_lblChunkAddr";
            this.status_lblChunkAddr.Size = new System.Drawing.Size(0, 19);
            // 
            // status_lblSpacer
            // 
            this.status_lblSpacer.Name = "status_lblSpacer";
            this.status_lblSpacer.Size = new System.Drawing.Size(604, 19);
            this.status_lblSpacer.Spring = true;
            // 
            // status_lblFileInfo
            // 
            this.status_lblFileInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.status_lblFileInfo.Name = "status_lblFileInfo";
            this.status_lblFileInfo.Size = new System.Drawing.Size(50, 19);
            this.status_lblFileInfo.Text = "FileInfo";
            // 
            // status_lblImageInfo
            // 
            this.status_lblImageInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.status_lblImageInfo.Name = "status_lblImageInfo";
            this.status_lblImageInfo.Size = new System.Drawing.Size(65, 19);
            this.status_lblImageInfo.Text = "ImageInfo";
            this.status_lblImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.stripMain);
            this.Controls.Add(this.statusMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmImage";
            this.Text = "Media Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImage_FormClosing);
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ToolStripButton strip_btnRaw;
        private System.Windows.Forms.ToolStripButton strip_btnText;
        private System.Windows.Forms.ToolStripButton strip_btnGfx;
        private System.Windows.Forms.ToolStripLabel strip_lblStartAddr;
        private System.Windows.Forms.ToolStripTextBox strip_txtStart;
        private System.Windows.Forms.ToolStripTextBox strip_txtEnd;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.ToolStrip stripMain;
        private System.Windows.Forms.ToolStripButton strip_btnLoad;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel status_lblImageInfo;
        private System.Windows.Forms.ToolStripSeparator strip_Separator1;
        private System.Windows.Forms.ToolStripSeparator strip_Separator2;
        private DispOut dispOut;
        private System.Windows.Forms.ToolStripStatusLabel status_lblChunkAddr;
        private System.Windows.Forms.ToolStripDropDownButton strip_btnEnd;
        private System.Windows.Forms.ToolStripMenuItem mnuEndOffset;
        private System.Windows.Forms.ToolStripMenuItem mnuLength;
        private System.Windows.Forms.ToolStripStatusLabel status_lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel status_lblFileInfo;
        private System.Windows.Forms.ToolStripDropDownButton strip_btnExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportRaw;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
    }
}

