using System;

namespace Dumpster2
{
    class ColorsSettingsUpdateArgs : EventArgs
    {
        public ColorsSettings Settings { get; set; }
        public ColorsSettingsUpdateArgs(ColorsSettings Settings)
        {
            if (Settings == null) throw new ArgumentNullException();
            this.Settings = Settings;
        }
    }
}
