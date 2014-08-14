using System;
using System.Text;
using dumplib.Gfx;

namespace Dumpster2
{
    public class GfxSettingsUpdateArgs : EventArgs
    {
        public GfxSettings Settings { get; private set; }
        public GfxSettingsUpdateArgs(GfxSettings Settings)
        {
            if (Settings == null) throw new ArgumentNullException();
            this.Settings = Settings;
        }
    }
}
