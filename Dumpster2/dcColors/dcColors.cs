using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using dumplib.Gfx;

namespace Dumpster2
{
    public partial class dcColors : DockContent
    {
        private class PaletteInfo
        {
            public string Desc
            {
                get;
                private set;
            }

            public ColorPalette Palette
            {
                get;
                private set;
            }

            public bool Closeable
            {
                get;
                private set;
            }

            public PaletteInfo(string Description, ColorPalette Palette, bool Closeable = true)
            {
                this.Desc = Description;
                this.Palette = Palette;
                this.Closeable = Closeable;
            }
        }

        public event EventHandler ColorsSettingsUpdated;

        // you're gonna need a more specific colorpalette class, or something
        // you need a string for DisplayMember, filename for files, something else for other sources
        //private BindingList<ColorPalette> Palettes;
        private BindingList<PaletteInfo> Palettes;

        private void RaiseUpdate()
        {
            if (this.ColorsSettingsUpdated != null)
                this.ColorsSettingsUpdated(this, new EventArgs());
        }

        public dcColors()
        {
            InitializeComponent();

            this._settings = new ColorsSettings();

            this.Palettes = new BindingList<PaletteInfo>();
            this.lbxPalettes.DisplayMember = "Desc";
            this.lbxPalettes.ValueMember = "Palette";
            this.lbxPalettes.DataSource = this.Palettes;

            var defaultpalette = dumplib.Gfx.CreatePalette.New_8bit();
            this.Palettes.Add(new PaletteInfo("System Palette", defaultpalette, false));
            this.lbxPalettes.SelectedItem = defaultpalette;
        }

        private System.Drawing.Color entry0color = System.Drawing.Color.FromArgb(0);

        private ColorsSettings _settings;
        public ColorsSettings Settings
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

        private void SyncUI()
        {
            this.lbxPalettes.SelectedItem = this._settings.SelectedPalette;
            //if (this._settings.SelectedPalette != null) this.lbxPalettes.SelectedItem = this._settings.SelectedPalette;
            this.palView.Line = this._settings.SubpaletteIndex;
            this.palView.SelectedColor = this._settings.SelectedColorIndex;
            this.chkTransparency.Checked = this._settings.PaletteEntry0Trans;
        }

        private void palView_SelectedColorChanged(object sender, EventArgs e)
        {
            this.lblColor.BackColor = this.palView.FullPalette.Entries[this.palView.SelectedColor];
            this.txtColorHex.Text = "#" + this.lblColor.BackColor.R.ToString("X2") + this.lblColor.BackColor.G.ToString("X2") + this.lblColor.BackColor.B.ToString("X2");
            this._settings.SelectedColorIndex = this.palView.SelectedColor;
        }

        private void lbxPalettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._settings.SelectedPalette = this.lbxPalettes.SelectedValue as ColorPalette;
            this.palView.FullPalette = this._settings.SelectedPalette;
            this.RaiseUpdate();
        }

        public void AddPalette(string Filepath)
        {
            if (Filepath == null) throw new ArgumentNullException();
            var extension = new System.IO.FileInfo(Filepath).Extension.ToLower();
            switch (extension)
            {
                case ".tpl":
                    this.Palettes.Add(new PaletteInfo(System.IO.Path.GetFileName(Filepath), LoadPalette.From_TilelayerPalette(Filepath)));
                    break;
                case ".zst":
                case ".zs0":
                case ".zs1":
                case ".zs2":
                case ".zs3":
                case ".zs4":
                case ".zs5":
                case ".zs6":
                case ".zs7":
                case ".zs8":
                case ".zs9":
                    this.Palettes.Add(new PaletteInfo(System.IO.Path.GetFileName(Filepath), LoadPalette.From_Savestate_ZST(Filepath)));
                    break;
                case ".gs0":
                case ".gs1":
                case ".gs2":
                case ".gs3":
                case ".gs4":
                case ".gs5":
                case ".gs6":
                case ".gs7":
                case ".gs8":
                case ".gs9":
                    this.Palettes.Add(new PaletteInfo(System.IO.Path.GetFileName(Filepath), dumplib.Gfx.LoadPalette.From_Savestate_GSX(Filepath)));
                    break;
                default:
                    throw new Exception("Unrecognize palette file");
            }
        }

        public void CloseCurrentPalette()
        {
            if (this.lbxPalettes.SelectedItem != null && (this.lbxPalettes.SelectedItem as PaletteInfo).Closeable) this.Palettes.Remove(this.lbxPalettes.SelectedItem as PaletteInfo);
        }

        private void chkTransparency_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTransparency.Checked) this._settings.PaletteEntry0Trans = true;
            else this._settings.PaletteEntry0Trans = false;
            this._settings.DrawPalette = this._settings.PaletteEntry0Trans ? makeTrans(this.palView.SubPalette) : restoreTrans(this.palView.SubPalette);
            this.RaiseUpdate();
        }

        private void palView_SubpaletteChanged(object sender, EventArgs e)
        {
            this._settings.SubpaletteIndex = this.palView.Line;
            this.entry0color = this.palView.SubPalette.Entries[0];
            this._settings.DrawPalette = this._settings.PaletteEntry0Trans ? makeTrans(this.palView.SubPalette) : restoreTrans(this.palView.SubPalette);
            //this.palView.FullPalette = this._settings.SelectedPalette;
            this.RaiseUpdate();
        }

        private ColorPalette makeTrans(ColorPalette subpalette)
        {
            //this.entry0color = subpalette.Entries[0];
            subpalette.Entries[0] = System.Drawing.Color.FromArgb(0);
            return subpalette;
        }

        private ColorPalette restoreTrans(ColorPalette subpalette)
        {
            subpalette.Entries[0] = this.entry0color;
            return subpalette;
        }
    }
}
