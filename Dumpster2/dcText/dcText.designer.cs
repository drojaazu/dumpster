namespace Dumpster2
{
    partial class dcText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dcText));
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.grpLogTables = new System.Windows.Forms.GroupBox();
            this.cmbLogTables = new System.Windows.Forms.ComboBox();
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.grpEncoding = new System.Windows.Forms.GroupBox();
            this.pnlEnc = new System.Windows.Forms.Panel();
            this.rdoOtherEncoding = new System.Windows.Forms.RadioButton();
            this.rdoSJIS = new System.Windows.Forms.RadioButton();
            this.rdoASCII = new System.Windows.Forms.RadioButton();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.rdoSysEncoding = new System.Windows.Forms.RadioButton();
            this.rdoTable = new System.Windows.Forms.RadioButton();
            this.grpTable.SuspendLayout();
            this.grpLogTables.SuspendLayout();
            this.grpEncoding.SuspendLayout();
            this.pnlEnc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.grpLogTables);
            this.grpTable.Controls.Add(this.lbxTables);
            this.grpTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTable.Enabled = false;
            this.grpTable.Location = new System.Drawing.Point(6, 72);
            this.grpTable.Name = "grpTable";
            this.grpTable.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpTable.Size = new System.Drawing.Size(248, 166);
            this.grpTable.TabIndex = 23;
            this.grpTable.TabStop = false;
            // 
            // grpLogTables
            // 
            this.grpLogTables.Controls.Add(this.cmbLogTables);
            this.grpLogTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLogTables.Location = new System.Drawing.Point(6, 112);
            this.grpLogTables.Name = "grpLogTables";
            this.grpLogTables.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpLogTables.Size = new System.Drawing.Size(236, 45);
            this.grpLogTables.TabIndex = 5;
            this.grpLogTables.TabStop = false;
            this.grpLogTables.Text = "Logical Tables";
            // 
            // cmbLogTables
            // 
            this.cmbLogTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLogTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogTables.FormattingEnabled = true;
            this.cmbLogTables.Location = new System.Drawing.Point(6, 17);
            this.cmbLogTables.Name = "cmbLogTables";
            this.cmbLogTables.Size = new System.Drawing.Size(224, 21);
            this.cmbLogTables.TabIndex = 4;
            // 
            // lbxTables
            // 
            this.lbxTables.DisplayMember = "Description";
            this.lbxTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.Location = new System.Drawing.Point(6, 17);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(236, 95);
            this.lbxTables.TabIndex = 6;
            this.lbxTables.SelectedIndexChanged += new System.EventHandler(this.lbxTables_SelectedIndexChanged);
            // 
            // grpEncoding
            // 
            this.grpEncoding.Controls.Add(this.pnlEnc);
            this.grpEncoding.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEncoding.Location = new System.Drawing.Point(6, 4);
            this.grpEncoding.Name = "grpEncoding";
            this.grpEncoding.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpEncoding.Size = new System.Drawing.Size(248, 68);
            this.grpEncoding.TabIndex = 24;
            this.grpEncoding.TabStop = false;
            // 
            // pnlEnc
            // 
            this.pnlEnc.Controls.Add(this.rdoOtherEncoding);
            this.pnlEnc.Controls.Add(this.rdoSJIS);
            this.pnlEnc.Controls.Add(this.rdoASCII);
            this.pnlEnc.Controls.Add(this.cmbEncoding);
            this.pnlEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnc.Location = new System.Drawing.Point(6, 17);
            this.pnlEnc.Name = "pnlEnc";
            this.pnlEnc.Padding = new System.Windows.Forms.Padding(24, 4, 6, 4);
            this.pnlEnc.Size = new System.Drawing.Size(236, 47);
            this.pnlEnc.TabIndex = 12;
            // 
            // rdoOtherEncoding
            // 
            this.rdoOtherEncoding.AutoSize = true;
            this.rdoOtherEncoding.Location = new System.Drawing.Point(6, 26);
            this.rdoOtherEncoding.Name = "rdoOtherEncoding";
            this.rdoOtherEncoding.Size = new System.Drawing.Size(14, 13);
            this.rdoOtherEncoding.TabIndex = 14;
            this.rdoOtherEncoding.TabStop = true;
            this.rdoOtherEncoding.UseVisualStyleBackColor = true;
            this.rdoOtherEncoding.CheckedChanged += new System.EventHandler(this.rdoOtherEncoding_CheckedChanged);
            // 
            // rdoSJIS
            // 
            this.rdoSJIS.AutoSize = true;
            this.rdoSJIS.Location = new System.Drawing.Point(64, 3);
            this.rdoSJIS.Name = "rdoSJIS";
            this.rdoSJIS.Size = new System.Drawing.Size(47, 17);
            this.rdoSJIS.TabIndex = 13;
            this.rdoSJIS.TabStop = true;
            this.rdoSJIS.Text = "SJIS";
            this.rdoSJIS.UseVisualStyleBackColor = true;
            this.rdoSJIS.CheckedChanged += new System.EventHandler(this.rdoSJIS_CheckedChanged);
            // 
            // rdoASCII
            // 
            this.rdoASCII.AutoSize = true;
            this.rdoASCII.Checked = true;
            this.rdoASCII.Location = new System.Drawing.Point(6, 4);
            this.rdoASCII.Name = "rdoASCII";
            this.rdoASCII.Size = new System.Drawing.Size(52, 17);
            this.rdoASCII.TabIndex = 12;
            this.rdoASCII.TabStop = true;
            this.rdoASCII.Text = "ASCII";
            this.rdoASCII.UseVisualStyleBackColor = true;
            this.rdoASCII.CheckedChanged += new System.EventHandler(this.rdoASCII_CheckedChanged);
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DataSource = System.Text.Encoding.GetEncodings();
            this.cmbEncoding.DisplayMember = "DisplayName";
            this.cmbEncoding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.Enabled = false;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(24, 22);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(206, 21);
            this.cmbEncoding.TabIndex = 11;
            this.cmbEncoding.SelectedIndexChanged += new System.EventHandler(this.cmbEncoding_SelectedIndexChanged);
            // 
            // rdoSysEncoding
            // 
            this.rdoSysEncoding.AutoSize = true;
            this.rdoSysEncoding.BackColor = System.Drawing.Color.Transparent;
            this.rdoSysEncoding.Location = new System.Drawing.Point(10, 2);
            this.rdoSysEncoding.Name = "rdoSysEncoding";
            this.rdoSysEncoding.Size = new System.Drawing.Size(107, 17);
            this.rdoSysEncoding.TabIndex = 30;
            this.rdoSysEncoding.TabStop = true;
            this.rdoSysEncoding.Text = "System Encoding";
            this.rdoSysEncoding.UseVisualStyleBackColor = false;
            this.rdoSysEncoding.CheckedChanged += new System.EventHandler(this.rdoSysEncoding_CheckedChanged);
            // 
            // rdoTable
            // 
            this.rdoTable.AutoSize = true;
            this.rdoTable.BackColor = System.Drawing.Color.Transparent;
            this.rdoTable.Location = new System.Drawing.Point(10, 69);
            this.rdoTable.Name = "rdoTable";
            this.rdoTable.Size = new System.Drawing.Size(52, 17);
            this.rdoTable.TabIndex = 29;
            this.rdoTable.TabStop = true;
            this.rdoTable.Text = "Table";
            this.rdoTable.UseVisualStyleBackColor = false;
            this.rdoTable.CheckedChanged += new System.EventHandler(this.rdoTable_CheckedChanged);
            // 
            // dcText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 255);
            this.Controls.Add(this.rdoSysEncoding);
            this.Controls.Add(this.rdoTable);
            this.Controls.Add(this.grpTable);
            this.Controls.Add(this.grpEncoding);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HideOnClose = true;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(260, 255);
            this.Name = "dcText";
            this.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Text = "Text Transcoding";
            this.grpTable.ResumeLayout(false);
            this.grpLogTables.ResumeLayout(false);
            this.grpEncoding.ResumeLayout(false);
            this.pnlEnc.ResumeLayout(false);
            this.pnlEnc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.GroupBox grpLogTables;
        public System.Windows.Forms.ComboBox cmbLogTables;
        private System.Windows.Forms.GroupBox grpEncoding;
        private System.Windows.Forms.Panel pnlEnc;
        private System.Windows.Forms.RadioButton rdoOtherEncoding;
        private System.Windows.Forms.RadioButton rdoSJIS;
        private System.Windows.Forms.RadioButton rdoASCII;
        public System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.RadioButton rdoSysEncoding;
        private System.Windows.Forms.RadioButton rdoTable;
        private System.Windows.Forms.ListBox lbxTables;
    }
}