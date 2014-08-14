using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using dumplib.Gfx;
using System.Collections.Generic;
using dumplib.Layout;

namespace Dumpster2
{
    public partial class dcGfx : DockContent
    {
        public dcGfx()
        {
            InitializeComponent();
            // init our list of tile converters and bring them in from the static dictionary
            this.TileConvs = new List<TileConvInfo>();
            foreach (ITileConverter thisconv in Program.TileConverters.Values)
                this.TileConvs.Add(new TileConvInfo(thisconv.ID, thisconv.Description));
            
            this._settings = new GfxSettings();
            
            this.cmbPixelFormats.DisplayMember = "Desc";
            this.cmbPixelFormats.ValueMember = "ID";
            this.cmbPixelFormats.DataSource = this.TileConvs;
        }

        #region TileConvInfo

        /// <summary>
        /// TileConvInfo contains the ID and user-friendly descriptions of all the Tile Converters in the static dictionary
        /// </summary>
        private class TileConvInfo
        {
            public string ID
            {
                private set;
                get;
            }

            public string Desc
            {
                private set;
                get;
            }

            public TileConvInfo(string ID, string Desc)
            {
                this.ID = ID;
                this.Desc = Desc;
            }
        }

        private List<TileConvInfo> TileConvs;
        #endregion


        /// <summary>
        /// Raised whenever an option is changed on the dock
        /// </summary>
        public event EventHandler GfxSettingsUpdated;

        /// <summary>
        /// Called by dock methods when changes are made
        /// </summary>
        private void RaiseUpdate()
        {
            if (this.GfxSettingsUpdated != null)
                this.GfxSettingsUpdated(this, new EventArgs());
        }

        private GfxSettings _settings;
        public GfxSettings Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                if (value == null) throw new ArgumentNullException();
                this._settings = value;
                SyncUI();
            }
        }

        /// <summary>
        /// Updates the UI to match the GfxSettings after it has been set
        /// </summary>
        private void SyncUI()
        {
            if (this._settings.Mode == GfxSettings.GfxMode.Tiled) this.rdoTiled.Select();
            else this.rdoLinear.Select();
            //this.cmbPixelFormats.SelectedItem = this._settings.TileConverter;
            this.SetTileFormat(this._settings.TileConverter);
            this.txtHorizontal.Text = this._settings.TilesPerRow.ToString();
            this.trackZoom.Value = this._settings.Zoom;
        }

        /// <summary>
        /// Ensures that the value in the Tiles Per Row field is valid
        /// </summary>
        private void ValidateTilePerRow()
        {
            int newtilesperrow;
            if (!int.TryParse(txtHorizontal.Text, out newtilesperrow)) newtilesperrow = 1;
            if (newtilesperrow != this._settings.TilesPerRow)
            {
                this._settings.TilesPerRow = newtilesperrow;
                this.RaiseUpdate();
            }
        }

        #region Private form events
        private void cmbPixelFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this._settings.Converter = (ITileConverter)this.cmbPixelFormats.SelectedValue;
            this._settings.TileConverter = this.cmbPixelFormats.SelectedValue as string;
            this.RaiseUpdate();
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            this._settings.Zoom = this.trackZoom.Value;
            this.RaiseUpdate();
        }

        private void txtHorizontal_Leave(object sender, EventArgs e)
        {
            ValidateTilePerRow();
        }

        private void dcGfx_Deactivate(object sender, EventArgs e)
        {
            ValidateTilePerRow();
        }
        #endregion

        #region Public methods
        public void SetTilesPerRow(int TilesPerRow)
        {
            this.txtHorizontal.Text = TilesPerRow.ToString();
            this.ValidateTilePerRow();
        }

        public void SetTileFormat(string FormatID)
        {
            this.cmbPixelFormats.SelectedValue = FormatID;
            this.RaiseUpdate();
        }

        public void UpdateFromChunkInfo(GfxChunkInfo ChunkInfo)
        {
            if (ChunkInfo.TileConverter != null) this.SetTileFormat(ChunkInfo.TileConverter);
                //this.cmbPixelFormats.SelectedValue = ChunkInfo.TileConverter;
            if (ChunkInfo.TilesPerRow != null) this.SetTilesPerRow((int)ChunkInfo.TilesPerRow);
        }

        #endregion

        private void rdoTiled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
