namespace Dumpster2
{
    partial class dcSearch
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
            this.lstboxResults = new System.Windows.Forms.ListBox();
            this.tabsSearch = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.btnASCIIClear = new System.Windows.Forms.Button();
            this.lblASCII = new System.Windows.Forms.Label();
            this.btnASCII = new System.Windows.Forms.Button();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.tabByte = new System.Windows.Forms.TabPage();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnByteClear = new System.Windows.Forms.Button();
            this.btnByte = new System.Windows.Forms.Button();
            this.tabPattern = new System.Windows.Forms.TabPage();
            this.btnPatternClear = new System.Windows.Forms.Button();
            this.btnPattern = new System.Windows.Forms.Button();
            this.lblPattern = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.tabsSearch.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabByte.SuspendLayout();
            this.tabPattern.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxResults
            // 
            this.lstboxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstboxResults.FormattingEnabled = true;
            this.lstboxResults.Location = new System.Drawing.Point(6, 120);
            this.lstboxResults.Name = "lstboxResults";
            this.lstboxResults.Size = new System.Drawing.Size(268, 205);
            this.lstboxResults.TabIndex = 3;
            // 
            // tabsSearch
            // 
            this.tabsSearch.Controls.Add(this.tabText);
            this.tabsSearch.Controls.Add(this.tabByte);
            this.tabsSearch.Controls.Add(this.tabPattern);
            this.tabsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsSearch.Location = new System.Drawing.Point(6, 4);
            this.tabsSearch.Name = "tabsSearch";
            this.tabsSearch.SelectedIndex = 0;
            this.tabsSearch.Size = new System.Drawing.Size(268, 116);
            this.tabsSearch.TabIndex = 2;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.btnASCIIClear);
            this.tabText.Controls.Add(this.lblASCII);
            this.tabText.Controls.Add(this.btnASCII);
            this.tabText.Controls.Add(this.txtASCII);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(260, 90);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "ASCII Search";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // btnASCIIClear
            // 
            this.btnASCIIClear.Location = new System.Drawing.Point(49, 52);
            this.btnASCIIClear.Name = "btnASCIIClear";
            this.btnASCIIClear.Size = new System.Drawing.Size(75, 23);
            this.btnASCIIClear.TabIndex = 3;
            this.btnASCIIClear.Text = "Clear";
            this.btnASCIIClear.UseVisualStyleBackColor = true;
            // 
            // lblASCII
            // 
            this.lblASCII.AutoSize = true;
            this.lblASCII.Location = new System.Drawing.Point(7, 7);
            this.lblASCII.Name = "lblASCII";
            this.lblASCII.Size = new System.Drawing.Size(194, 13);
            this.lblASCII.TabIndex = 2;
            this.lblASCII.Text = "Search the data for an ASCII text string:";
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(130, 52);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(75, 23);
            this.btnASCII.TabIndex = 1;
            this.btnASCII.Text = "Search";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(10, 26);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(239, 20);
            this.txtASCII.TabIndex = 0;
            // 
            // tabByte
            // 
            this.tabByte.Controls.Add(this.txtSequence);
            this.tabByte.Controls.Add(this.label2);
            this.tabByte.Controls.Add(this.btnByteClear);
            this.tabByte.Controls.Add(this.btnByte);
            this.tabByte.Location = new System.Drawing.Point(4, 22);
            this.tabByte.Name = "tabByte";
            this.tabByte.Padding = new System.Windows.Forms.Padding(3);
            this.tabByte.Size = new System.Drawing.Size(260, 90);
            this.tabByte.TabIndex = 1;
            this.tabByte.Text = "Byte Search";
            this.tabByte.UseVisualStyleBackColor = true;
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(8, 26);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(241, 20);
            this.txtSequence.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search the data for a sequence of bytes:";
            // 
            // btnByteClear
            // 
            this.btnByteClear.Location = new System.Drawing.Point(45, 56);
            this.btnByteClear.Name = "btnByteClear";
            this.btnByteClear.Size = new System.Drawing.Size(75, 23);
            this.btnByteClear.TabIndex = 2;
            this.btnByteClear.Text = "Clear";
            this.btnByteClear.UseVisualStyleBackColor = true;
            // 
            // btnByte
            // 
            this.btnByte.Location = new System.Drawing.Point(126, 56);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(75, 23);
            this.btnByte.TabIndex = 2;
            this.btnByte.Text = "Search";
            this.btnByte.UseVisualStyleBackColor = true;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // tabPattern
            // 
            this.tabPattern.Controls.Add(this.btnPatternClear);
            this.tabPattern.Controls.Add(this.btnPattern);
            this.tabPattern.Controls.Add(this.lblPattern);
            this.tabPattern.Controls.Add(this.txtPattern);
            this.tabPattern.Location = new System.Drawing.Point(4, 22);
            this.tabPattern.Name = "tabPattern";
            this.tabPattern.Size = new System.Drawing.Size(260, 90);
            this.tabPattern.TabIndex = 2;
            this.tabPattern.Text = "Pattern Search";
            this.tabPattern.UseVisualStyleBackColor = true;
            // 
            // btnPatternClear
            // 
            this.btnPatternClear.Location = new System.Drawing.Point(52, 62);
            this.btnPatternClear.Name = "btnPatternClear";
            this.btnPatternClear.Size = new System.Drawing.Size(75, 23);
            this.btnPatternClear.TabIndex = 6;
            this.btnPatternClear.Text = "Clear";
            this.btnPatternClear.UseVisualStyleBackColor = true;
            // 
            // btnPattern
            // 
            this.btnPattern.Location = new System.Drawing.Point(133, 62);
            this.btnPattern.Name = "btnPattern";
            this.btnPattern.Size = new System.Drawing.Size(75, 23);
            this.btnPattern.TabIndex = 5;
            this.btnPattern.Text = "Search";
            this.btnPattern.UseVisualStyleBackColor = true;
            // 
            // lblPattern
            // 
            this.lblPattern.Location = new System.Drawing.Point(7, 7);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(241, 28);
            this.lblPattern.TabIndex = 4;
            this.lblPattern.Text = "Search the data for a pattern of byte value variance:";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(10, 36);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(238, 20);
            this.txtPattern.TabIndex = 3;
            // 
            // dcSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 329);
            this.Controls.Add(this.lstboxResults);
            this.Controls.Add(this.tabsSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(280, 329);
            this.Name = "dcSearch";
            this.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Text = "dcSearch";
            this.tabsSearch.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabByte.ResumeLayout(false);
            this.tabByte.PerformLayout();
            this.tabPattern.ResumeLayout(false);
            this.tabPattern.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxResults;
        private System.Windows.Forms.TabControl tabsSearch;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.Button btnASCIIClear;
        private System.Windows.Forms.Label lblASCII;
        private System.Windows.Forms.Button btnASCII;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.TabPage tabByte;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnByteClear;
        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.TabPage tabPattern;
        private System.Windows.Forms.Button btnPatternClear;
        private System.Windows.Forms.Button btnPattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.TextBox txtPattern;
    }
}