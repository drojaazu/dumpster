using System;
using System.Text;
using dumplib.Gfx;

namespace Dumpster2
{
    public class GfxSettings
    {
        public enum GfxMode
        {
            Tiled = 0,
            Linear
        }

        public GfxMode Mode
        {
            get;
            set;
        }

        private int tilesperrow;
        public int TilesPerRow
        {
            get
            {
                return this.tilesperrow;
            }
            set
            {
                if (value < 1) value = 1;
                this.tilesperrow = value;
            }
        }

        public string TileConverter
        {
            get;
            set;
        }

        private int bitmapwidth;
        public int BitmapWidth
        {
            get
            {
                return this.bitmapwidth;
            }
            set
            {
                //if (value < 1) throw new ArgumentOutOfRangeException("BitmapWidth", "Value cannot be negative");
                if (value < 1) value = 1;
                this.bitmapwidth = value;

            }
        }

        private int zoom;
        public int Zoom
        {
            get
            {
                return this.zoom;
            }
            set
            {
                if (value < 0) value = 0;
                this.zoom = value;
            }
        }

        public GfxSettings()
        {
            this.Mode = GfxMode.Tiled;
            this.zoom = 0;
            this.TileConverter = "mono";
            this.bitmapwidth = 1;
            this.tilesperrow = 6;
        }
    }
}
