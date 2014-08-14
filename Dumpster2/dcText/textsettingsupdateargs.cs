using System;
using System.Text;
using dumplib.Text;

namespace Dumpster2
{
    public class TextSettingsUpdateArgs : EventArgs
    {
        public TextSettings Settings { get; set; }

        public TextSettingsUpdateArgs(TextSettings Settings)
        {
            if (Settings == null) throw new ArgumentNullException();
            this.Settings = Settings;
        }
    }
}
