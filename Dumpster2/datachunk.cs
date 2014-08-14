using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dumplib.Image;
using dumplib.Layout;
using System.IO;

namespace Dumpster2
{
    public class DataChunk
    {
        private byte[] data;
        public byte[] Data
        {
            get
            {
                return this.data;
            }
        }

        private IChunkInfo info;
        public IChunkInfo Info
        {
            get
            {
                return this.info;
            }
        }

        
        #region  CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR

        /// <summary>
        /// Constructs a data chunk
        /// </summary>
        /// <param name="Info">Information describing the data chunk, including the address range</param>
        /// <param name="Image">The source media image</param>
        public DataChunk(IChunkInfo Info, MediaImage Image)
        {
            if (Info == null || Image == null) throw new ArgumentNullException();
            this.info = Info;
            this.data = Image.GetBytes(Info.Addr);
        }

        #endregion  CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR
    }
}
