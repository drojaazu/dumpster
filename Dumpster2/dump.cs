using System;
using System.Drawing;
using dumplib.Layout;
using dumplib;

namespace Dumpster2
{
    public class Dump
    {
        public Dump(DataChunk Chunk, Image Image = null, string Text = null)
        {
            if (Chunk == null) throw new ArgumentNullException();
            this.chunk = Chunk;
            this.image = Image;
            this.text = Text;
        }

        private string text;
        public string Text
        {
            get
            {
                return this.text;
            }
        }

        private Image image;
        public Image Image
        {
            get
            {
                return this.image;
            }
        }

        private DataChunk chunk;

        public byte[] Data
        {
            get
            {
                return this.chunk.Data;
            }
        }

        public Range Addr
        {
            get
            {
                return this.chunk.Info.Addr;
            }
        }

        public string Description
        {
            get
            {
                return this.chunk.Info.Description;
            }
        }
    }
}
