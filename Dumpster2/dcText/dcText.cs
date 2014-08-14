using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using dumplib.Text;
using dumplib.Layout;

namespace Dumpster2
{
    public partial class dcText : DockContent
    {
        private BindingList<Table> Tables;

        public event EventHandler TextSettingsUpdated;

        private void RaiseUpdate()
        {
            if (this.TextSettingsUpdated != null)
                this.TextSettingsUpdated(this, new EventArgs());
        }
        
        public TextSettings _settings;
        public TextSettings Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                if (value == null) throw new ArgumentNullException();
                this._settings = value;
                this.SyncUI();
            }
        }

        public Table CurrentTable
        {
            get
            {
                if (this.Tables.Count == 0) return null;
                return (Table)this.lbxTables.SelectedValue;
            }

        }

        public dcText()
        {
            InitializeComponent();
            //-----------------------------
            // some custom stuff in the designer code
            // Re-add these lines to the designer in case VS removes them!
            //this.cmbEncoding.DisplayMember = "DisplayName";
            //this.cmbEncoding.DataSource = Encoding.GetEncodings();

            //this.lbxTables.DisplayMember = "Description";
            //-----------------------------
            
            this.Settings = new TextSettings();

            this.Tables = new BindingList<Table>();
            this.lbxTables.DataSource = this.Tables;

        }



        private void SyncUI()
        {
            if (this._settings.UseTable) this.rdoTable.Select();
            else this.rdoSysEncoding.Select();
            if (this._settings.Encoding == Encoding.ASCII) this.rdoASCII.Select();
            else if (this._settings.Encoding.CodePage == 932) this.rdoSJIS.Select();
            else
            {
                this.rdoOtherEncoding.Select();
                this.cmbEncoding.SelectedValue = this._settings.Encoding;
            }
        }

        internal void AddTable(string Filepath)
        {
            if (Filepath == null) throw new ArgumentNullException();
            
            using (var tempstream = new System.IO.FileStream(Filepath, System.IO.FileMode.Open))
            {
                this.Tables.Add(new Table(tempstream));
            }
            
            //this.lbxTables.SelectedIndex = 0;
            //MessageBox.Show(this.lbxTables.Text);
        }

        internal void CloseCurrentTable()
        {
            if (this.rdoTable.Checked && this.lbxTables.SelectedValue != null) this.Tables.Remove(this.lbxTables.SelectedValue as Table);
        }

        private void rdoSysEncoding_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoSysEncoding.Checked)
            {
                this.grpEncoding.Enabled = true;
                this.Settings.UseTable = false;
                this.RaiseUpdate();
            }

            else this.grpEncoding.Enabled = false;
            
        }

        private void rdoTable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoTable.Checked)
            {
                this.grpTable.Enabled = true;
                this.Settings.UseTable = true;
                this.RaiseUpdate();
            }
            else this.grpTable.Enabled = false;
            
        }

        private void rdoOtherEncoding_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoOtherEncoding.Checked)
            {
                this.cmbEncoding.Enabled = true;
                this.SetEncoding(cmbEncoding.SelectedItem as EncodingInfo);
            }
            else this.cmbEncoding.Enabled = false;
            
        }

        private void rdoASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoASCII.Checked) this.SetEncoding(Encoding.ASCII);
        }

        internal void SetEncoding(Encoding Encoding)
        {
            this._settings.Encoding = Encoding;
            this.RaiseUpdate();
        }

        internal void SetEncoding(int CodePage)
        {
            this.SetEncoding(Encoding.GetEncoding(CodePage));
        }

        internal void SetEncoding(EncodingInfo EncodingInfo)
        {
            this.SetEncoding(EncodingInfo.GetEncoding());
        }

        private void rdoSJIS_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoSJIS.Checked) this.SetEncoding(932);
        }

        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetEncoding(cmbEncoding.SelectedItem as EncodingInfo);
        }

        private void lbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._settings.CurrentTable = (Table)this.lbxTables.SelectedValue;
            this.RaiseUpdate();
        }

        public void UpdateFromChunkInfo(TextChunkInfo ChunkInfo)
        {
            if (ChunkInfo.Encoding != null) this.SetEncoding(ChunkInfo.Encoding);
        }
    }
}
