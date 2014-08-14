namespace Dumpster2
{
    partial class dcGfx
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
            this.grpBitmapMode = new System.Windows.Forms.GroupBox();
            this.txtHorizontal = new System.Windows.Forms.TextBox();
            this.lblHorizontal = new System.Windows.Forms.Label();
            this.rdoLinear = new System.Windows.Forms.RadioButton();
            this.rdoTiled = new System.Windows.Forms.RadioButton();
            this.grpPixelFormats = new System.Windows.Forms.GroupBox();
            this.cmbPixelFormats = new System.Windows.Forms.ComboBox();
            this.grpZoom = new System.Windows.Forms.GroupBox();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.grpBitmapMode.SuspendLayout();
            this.grpPixelFormats.SuspendLayout();
            this.grpZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBitmapMode
            // 
            this.grpBitmapMode.Controls.Add(this.txtHorizontal);
            this.grpBitmapMode.Controls.Add(this.lblHorizontal);
            this.grpBitmapMode.Controls.Add(this.rdoLinear);
            this.grpBitmapMode.Controls.Add(this.rdoTiled);
            this.grpBitmapMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBitmapMode.Location = new System.Drawing.Point(6, 4);
            this.grpBitmapMode.Name = "grpBitmapMode";
            this.grpBitmapMode.Size = new System.Drawing.Size(248, 47);
            this.grpBitmapMode.TabIndex = 3;
            this.grpBitmapMode.TabStop = false;
            this.grpBitmapMode.Text = "Bitmap Mode";
            // 
            // txtHorizontal
            // 
            this.txtHorizontal.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtHorizontal.Location = new System.Drawing.Point(201, 16);
            this.txtHorizontal.Name = "txtHorizontal";
            this.txtHorizontal.Size = new System.Drawing.Size(43, 20);
            this.txtHorizontal.TabIndex = 4;
            this.txtHorizontal.Text = "6";
            this.txtHorizontal.Leave += new System.EventHandler(this.txtHorizontal_Leave);
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.AutoSize = true;
            this.lblHorizontal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHorizontal.Location = new System.Drawing.Point(129, 16);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblHorizontal.Size = new System.Drawing.Size(72, 25);
            this.lblHorizontal.TabIndex = 3;
            this.lblHorizontal.Text = "Tiles per Row";
            // 
            // rdoLinear
            // 
            this.rdoLinear.AutoSize = true;
            this.rdoLinear.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoLinear.Enabled = false;
            this.rdoLinear.Location = new System.Drawing.Point(63, 16);
            this.rdoLinear.Name = "rdoLinear";
            this.rdoLinear.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rdoLinear.Size = new System.Drawing.Size(66, 28);
            this.rdoLinear.TabIndex = 1;
            this.rdoLinear.TabStop = true;
            this.rdoLinear.Text = "Linear";
            this.rdoLinear.UseVisualStyleBackColor = true;
            // 
            // rdoTiled
            // 
            this.rdoTiled.AutoSize = true;
            this.rdoTiled.Checked = true;
            this.rdoTiled.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoTiled.Location = new System.Drawing.Point(3, 16);
            this.rdoTiled.Name = "rdoTiled";
            this.rdoTiled.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rdoTiled.Size = new System.Drawing.Size(60, 28);
            this.rdoTiled.TabIndex = 0;
            this.rdoTiled.TabStop = true;
            this.rdoTiled.Text = "Tiled";
            this.rdoTiled.UseVisualStyleBackColor = true;
            this.rdoTiled.CheckedChanged += new System.EventHandler(this.rdoTiled_CheckedChanged);
            // 
            // grpPixelFormats
            // 
            this.grpPixelFormats.Controls.Add(this.cmbPixelFormats);
            this.grpPixelFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPixelFormats.Location = new System.Drawing.Point(6, 51);
            this.grpPixelFormats.Name = "grpPixelFormats";
            this.grpPixelFormats.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpPixelFormats.Size = new System.Drawing.Size(248, 49);
            this.grpPixelFormats.TabIndex = 4;
            this.grpPixelFormats.TabStop = false;
            this.grpPixelFormats.Text = "Tile Format";
            // 
            // cmbPixelFormats
            // 
            this.cmbPixelFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPixelFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPixelFormats.FormattingEnabled = true;
            this.cmbPixelFormats.Location = new System.Drawing.Point(6, 17);
            this.cmbPixelFormats.Name = "cmbPixelFormats";
            this.cmbPixelFormats.Size = new System.Drawing.Size(236, 21);
            this.cmbPixelFormats.TabIndex = 0;
            this.cmbPixelFormats.SelectedIndexChanged += new System.EventHandler(this.cmbPixelFormats_SelectedIndexChanged);
            // 
            // grpZoom
            // 
            this.grpZoom.Controls.Add(this.trackZoom);
            this.grpZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpZoom.Location = new System.Drawing.Point(6, 100);
            this.grpZoom.Name = "grpZoom";
            this.grpZoom.Size = new System.Drawing.Size(248, 65);
            this.grpZoom.TabIndex = 5;
            this.grpZoom.TabStop = false;
            this.grpZoom.Text = "Zoom";
            // 
            // trackZoom
            // 
            this.trackZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackZoom.LargeChange = 1;
            this.trackZoom.Location = new System.Drawing.Point(3, 16);
            this.trackZoom.Maximum = 3;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(242, 45);
            this.trackZoom.TabIndex = 1;
            this.trackZoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackZoom.Scroll += new System.EventHandler(this.trackZoom_Scroll);
            // 
            // dcGfx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 331);
            this.Controls.Add(this.grpZoom);
            this.Controls.Add(this.grpPixelFormats);
            this.Controls.Add(this.grpBitmapMode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(260, 208);
            this.Name = "dcGfx";
            this.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Text = "Graphics";
            this.Deactivate += new System.EventHandler(this.dcGfx_Deactivate);
            this.grpBitmapMode.ResumeLayout(false);
            this.grpBitmapMode.PerformLayout();
            this.grpPixelFormats.ResumeLayout(false);
            this.grpZoom.ResumeLayout(false);
            this.grpZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBitmapMode;
        private System.Windows.Forms.RadioButton rdoLinear;
        private System.Windows.Forms.RadioButton rdoTiled;
        private System.Windows.Forms.GroupBox grpPixelFormats;
        private System.Windows.Forms.ComboBox cmbPixelFormats;
        private System.Windows.Forms.GroupBox grpZoom;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.TextBox txtHorizontal;
        private System.Windows.Forms.Label lblHorizontal;

    }
}