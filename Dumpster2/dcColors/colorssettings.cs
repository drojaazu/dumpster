using System;
using System.Text;
using System.Drawing.Imaging;

namespace Dumpster2
{
    public class ColorsSettings
    {
        private bool paletteentry0trans;
        public bool PaletteEntry0Trans
        {
            get
            {
                return this.paletteentry0trans;
            }
            set
            {
                this.paletteentry0trans = value;
            }
        }

        private int subpaletteindex;
        public int SubpaletteIndex
        {
            get
            {
                return this.subpaletteindex;
            }
            set
            {
                if (value < 0) value = 0;
                this.subpaletteindex = value;
            }
        }

        private int selectedcolorindex;
        public int SelectedColorIndex
        {
            get
            {
                return this.selectedcolorindex;
            }
            set
            {
                if (value < 0) value = 0;
                this.selectedcolorindex = value;
            }
        }

        private ColorPalette drawpalette;
        public ColorPalette DrawPalette
        {
            get
            {
                return this.drawpalette;
            }

            set
            {
                if (value == null) value = dumplib.Gfx.CreatePalette.New_8bit();
                this.drawpalette = value;
            }
        }

        private ColorPalette selectedpalette;
        public ColorPalette SelectedPalette
        {
            get
            {
                return this.selectedpalette;
            }

            set
            {
                if (value == null) value = dumplib.Gfx.CreatePalette.New_8bit();
                this.selectedpalette = value;
            }
        }

        public ColorsSettings()
        {
            this.selectedcolorindex = 0;
            this.subpaletteindex = 0;
            this.paletteentry0trans = false;
        }
    }
}
