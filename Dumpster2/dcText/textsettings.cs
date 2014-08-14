using System;
using System.Text;
using dumplib.Text;

namespace Dumpster2
{
    public class TextSettings
    {
        public bool UseTable
        {
            get;
            set;
        }

        public Encoding Encoding
        {
            get;
            set;
        }

        public Table CurrentTable
        {
            get;
            set;
        }

        public TextSettings()
        {
            this.UseTable = false;
            this.Encoding = Encoding.ASCII;
            this.CurrentTable = null;
        }

        public TextSettings(TextSettings Settings)
        {
            if (Settings == null) throw new ArgumentNullException();
            this.UseTable = Settings.UseTable;
            this.Encoding = Settings.Encoding;
            this.CurrentTable = Settings.CurrentTable;
        }
        
    }
}