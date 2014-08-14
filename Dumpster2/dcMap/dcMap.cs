using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using dumplib.Layout;
using System.IO;

namespace Dumpster2
{
    public partial class dcMap : DockContent
    {
        #region     CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR
        public dcMap()
        {
            InitializeComponent();
            this._settings = new MapSettings();

            this.Maps = new BindingList<ImageMap>();
            this.Entries = new List<IChunkInfo>();

            this.lbxMaps.DisplayMember = "Description";
            this.lbxMaps.DataSource = this.Maps;
            this.lbxEntries.DisplayMember = "Description";
            this.lbxEntries.DataSource = this.Entries;
        }

        #endregion  CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR

        #region     PRIVATE MEMBERS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- PRIVATE MEMBERS

        /// <summary>
        /// Settings object
        /// </summary>
        private MapSettings _settings;
        
        /// <summary>
        /// List of loaded Image Maps
        /// </summary>
        private BindingList<ImageMap> Maps;
        
        /// <summary>
        /// List of Chunk Entries derived from an Image Map
        /// </summary>
        private List<IChunkInfo> Entries;

        /// <summary>
        /// Raises the MapSettingsUpdated event
        /// This alerts frmMain that a change has been made and the active form should update
        /// </summary>
        private void RaiseUpdate()
        {
            if (this.MapSettingsUpdated != null)
                this.MapSettingsUpdated(this, new EventArgs());
        }

        private void SyncUI()
        {
            if (this._settings.SelectedMap != null) this.lbxMaps.SelectedItem = this._settings.SelectedMap;
            if (this._settings.SelectedEntry != null) this.lbxEntries.SelectedItem = this._settings.SelectedEntry;
        }

        #region     FORM EVENTS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS

        private void lbxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Entries = (this._settings.SelectedMap == null ? null : this._settings.SelectedMap.Entries);
            this._settings.SelectedMap = this.lbxMaps.SelectedValue as ImageMap;
            this.Entries = this._settings.SelectedMap.Entries;
            this.lbxEntries.DataSource = this.Entries;
            
            //this.RaiseUpdate();
        }

        private void lbxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._settings.SelectedEntry = this.lbxEntries.SelectedValue as IChunkInfo;
            this.RaiseUpdate();
        }

        #endregion  FORM EVENTS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS

        #endregion



        #region     PUBLIC MEMBERS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- PUBLIC MEMBERS
        public event EventHandler MapSettingsUpdated;

        public MapSettings Settings
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

        public void AddMap(Stream Datastream)
        {
            var newmap = new ImageMap(Datastream);
            this.Maps.Add(newmap);
            this.lbxMaps.SelectedItem = newmap;
        }

        public void AddMap(string Filepath)
        {
            if (Filepath == null) throw new ArgumentNullException();
            var fs = new FileStream(Filepath, FileMode.Open);
            using (fs)
            {
                this.AddMap(fs);
            }
        }

        public void AddMap(ImageMap Map)
        {
            if (Map == null) throw new ArgumentNullException();
            this.Maps.Add(Map);
            this.lbxMaps.SelectedItem = Map;
        }

        public void CloseMap()
        {
            if (this.lbxMaps.SelectedItem != null) this.Maps.Remove(this.lbxMaps.SelectedItem as ImageMap);
        }

        public void CloseMap(ImageMap map)
        {
            this.Maps.Remove(map);
        }

        #endregion  PUBLIC MEMBERS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- PUBLIC MEMBERS

        private void chkChunkMeta_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
