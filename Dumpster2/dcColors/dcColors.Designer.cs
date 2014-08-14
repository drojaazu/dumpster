namespace Dumpster2
{
    partial class dcColors
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
            this.lbxPalettes = new System.Windows.Forms.ListBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColorHex = new System.Windows.Forms.TextBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.grpPalette = new System.Windows.Forms.GroupBox();
            this.palView = new dumplib.Gfx.PaletteViewer();
            this.chkTransparency = new System.Windows.Forms.CheckBox();
            this.grpColor.SuspendLayout();
            this.grpPalette.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPalettes
            // 
            this.lbxPalettes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxPalettes.FormattingEnabled = true;
            this.lbxPalettes.Location = new System.Drawing.Point(6, 4);
            this.lbxPalettes.Name = "lbxPalettes";
            this.lbxPalettes.Size = new System.Drawing.Size(248, 95);
            this.lbxPalettes.TabIndex = 9;
            this.lbxPalettes.SelectedIndexChanged += new System.EventHandler(this.lbxPalettes_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(7, 16);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 32);
            this.lblColor.TabIndex = 3;
            // 
            // txtColorHex
            // 
            this.txtColorHex.Location = new System.Drawing.Point(45, 28);
            this.txtColorHex.Name = "txtColorHex";
            this.txtColorHex.ReadOnly = true;
            this.txtColorHex.Size = new System.Drawing.Size(69, 20);
            this.txtColorHex.TabIndex = 4;
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.txtColorHex);
            this.grpColor.Controls.Add(this.lblColor);
            this.grpColor.Location = new System.Drawing.Point(6, 375);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(120, 59);
            this.grpColor.TabIndex = 8;
            this.grpColor.TabStop = false;
            // 
            // grpPalette
            // 
            this.grpPalette.Controls.Add(this.palView);
            this.grpPalette.Controls.Add(this.chkTransparency);
            this.grpPalette.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPalette.Location = new System.Drawing.Point(6, 99);
            this.grpPalette.Name = "grpPalette";
            this.grpPalette.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpPalette.Size = new System.Drawing.Size(248, 270);
            this.grpPalette.TabIndex = 10;
            this.grpPalette.TabStop = false;
            this.grpPalette.Text = "Color Palette";
            // 
            // palView
            // 
            this.palView.ColorSelectBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.palView.Line = 0;
            this.palView.Location = new System.Drawing.Point(9, 20);
            this.palView.Name = "palView";
            this.palView.SelectedColor = 0;
            this.palView.Size = new System.Drawing.Size(224, 224);
            this.palView.SubpaletteSelectBorder = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.palView.SubpaletteSize = 16;
            this.palView.TabIndex = 7;
            this.palView.SubpaletteChanged += new System.EventHandler(this.palView_SubpaletteChanged);
            this.palView.SelectedColorChanged += new System.EventHandler(this.palView_SelectedColorChanged);
            // 
            // chkTransparency
            // 
            this.chkTransparency.AutoSize = true;
            this.chkTransparency.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkTransparency.Location = new System.Drawing.Point(6, 249);
            this.chkTransparency.Name = "chkTransparency";
            this.chkTransparency.Size = new System.Drawing.Size(236, 17);
            this.chkTransparency.TabIndex = 6;
            this.chkTransparency.Text = "Make subpalette entry 0 transparent";
            this.chkTransparency.UseVisualStyleBackColor = true;
            this.chkTransparency.CheckedChanged += new System.EventHandler(this.chkTransparency_CheckedChanged);
            // 
            // dcColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 453);
            this.Controls.Add(this.grpPalette);
            this.Controls.Add(this.lbxPalettes);
            this.Controls.Add(this.grpColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(260, 453);
            this.Name = "dcColors";
            this.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpPalette.ResumeLayout(false);
            this.grpPalette.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPalettes;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColorHex;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.GroupBox grpPalette;
        private System.Windows.Forms.CheckBox chkTransparency;
        private dumplib.Gfx.PaletteViewer palView;

    }
}