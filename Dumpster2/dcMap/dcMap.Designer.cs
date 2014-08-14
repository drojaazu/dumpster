namespace Dumpster2
{
    partial class dcMap
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
            this.grpMaps = new System.Windows.Forms.GroupBox();
            this.lbxMaps = new System.Windows.Forms.ListBox();
            this.grpEntries = new System.Windows.Forms.GroupBox();
            this.lbxEntries = new System.Windows.Forms.ListBox();
            this.grpMaps.SuspendLayout();
            this.grpEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaps
            // 
            this.grpMaps.Controls.Add(this.lbxMaps);
            this.grpMaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMaps.Location = new System.Drawing.Point(6, 8);
            this.grpMaps.Name = "grpMaps";
            this.grpMaps.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpMaps.Size = new System.Drawing.Size(248, 122);
            this.grpMaps.TabIndex = 10;
            this.grpMaps.TabStop = false;
            this.grpMaps.Text = "Map Sources";
            // 
            // lbxMaps
            // 
            this.lbxMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMaps.FormattingEnabled = true;
            this.lbxMaps.Location = new System.Drawing.Point(6, 17);
            this.lbxMaps.Name = "lbxMaps";
            this.lbxMaps.Size = new System.Drawing.Size(236, 101);
            this.lbxMaps.TabIndex = 3;
            this.lbxMaps.SelectedIndexChanged += new System.EventHandler(this.lbxMaps_SelectedIndexChanged);
            // 
            // grpEntries
            // 
            this.grpEntries.Controls.Add(this.lbxEntries);
            this.grpEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEntries.Location = new System.Drawing.Point(6, 130);
            this.grpEntries.Name = "grpEntries";
            this.grpEntries.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpEntries.Size = new System.Drawing.Size(248, 168);
            this.grpEntries.TabIndex = 11;
            this.grpEntries.TabStop = false;
            this.grpEntries.Text = "Map Entries";
            // 
            // lbxEntries
            // 
            this.lbxEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxEntries.FormattingEnabled = true;
            this.lbxEntries.Location = new System.Drawing.Point(6, 17);
            this.lbxEntries.Name = "lbxEntries";
            this.lbxEntries.Size = new System.Drawing.Size(236, 147);
            this.lbxEntries.TabIndex = 5;
            this.lbxEntries.SelectedIndexChanged += new System.EventHandler(this.lbxEntries_SelectedIndexChanged);
            // 
            // dcMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 306);
            this.Controls.Add(this.grpEntries);
            this.Controls.Add(this.grpMaps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(260, 285);
            this.Name = "dcMap";
            this.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Text = "Map";
            this.grpMaps.ResumeLayout(false);
            this.grpEntries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaps;
        private System.Windows.Forms.ListBox lbxMaps;
        private System.Windows.Forms.GroupBox grpEntries;
        private System.Windows.Forms.ListBox lbxEntries;


    }
}