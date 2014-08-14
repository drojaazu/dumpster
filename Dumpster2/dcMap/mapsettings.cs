using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dumplib;
using dumplib.Layout;

namespace Dumpster2
{
    public class MapSettings
    {
        private ImageMap selectedmap;
        public ImageMap SelectedMap
        {
            get
            {
                return this.selectedmap;
            }
            set
            {
                //if (value != null) 
                    this.selectedmap = value;
            }
        }

        private IChunkInfo selectedentry;
        public IChunkInfo SelectedEntry
        {
            get
            {
                return this.selectedentry;
            }
            set
            {
                //if (value != null) 
                    this.selectedentry = value;
            }
        }
    }
}
