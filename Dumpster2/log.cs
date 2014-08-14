using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Dumpster2
{
    public class Logger
    {
        public delegate void OutputMethod(string Message);
        private class LogOut
        {
            protected OutputMethod Output = null;

            public LogOut()
            {
                this.Output = (string Message) => Console.WriteLine(Message);
            }

            public void Write(string Message)
            {
                if (this.Output != null) this.Output(Message);
            }

            public void Write(string Message, TextFormat Format)
            {
                if (this.Output != null) this.Output(MsgFmt(Message, Format));
            }

        }
        private class LogOut_Method : LogOut
        {
            public LogOut_Method(OutputMethod OutMethod)
            {
                if (OutMethod == null) throw new ArgumentNullException();
                base.Output = OutMethod;
            }
        }
        private class LogOut_File : LogOut, IDisposable
        {
            private StreamWriter _fs;

            public LogOut_File(string Filepath)
            {
                if (Filepath == null) throw new ArgumentNullException();
                this._fs = new StreamWriter(Filepath);
                base.Output = (string Message) =>
                {
                    _fs.WriteLine(Message);
                    _fs.Flush();
                };
            }

            private bool disposed = false;
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            private void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        // managed
                    }
                    // unmanaged
                    if (_fs != null) _fs.Close();
                }
                disposed = true;
            }
        }

        public bool UseTimestamps
        {
            get;
            set;
        }
        protected string timestampformat;
        public string TimestampFormat
        {
            get
            {
                return this.timestampformat;
            }
            set
            {
                if (value == null) value = string.Empty;
                this.timestampformat = value;
            }
        }
       
        public enum TextFormat
        {
            Normal, Box
        }
        private static string MsgFmt(string Message, TextFormat Format)
        {
            if (Message == null) throw new ArgumentNullException();
            switch (Format)
            {
                case TextFormat.Box:
                    char border = '*';
                    string[] lines = Message.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    int longestlength = 0;
                    for (int k = 0; k < lines.Length; k++)
                        if (lines[k].Length > longestlength) longestlength = lines[k].Length;
                    int width = longestlength + 4;
                    string bar = new string(border, width);
                    StringBuilder _out = new StringBuilder(Environment.NewLine + bar + Environment.NewLine);
                    for (int f = 0; f < lines.Length; f++)
                        _out.AppendLine(""+border + ' ' + lines[f] + new string(' ',(longestlength-lines[f].Length)+1) + border);
                    _out.AppendLine(bar);
                    return _out.ToString();
                default:
                    return Message;
            }
        }

        private Dictionary<uint,LogOut> _outputs;
        private uint hndlptr = 0;
        public Logger()
        {
            this.UseTimestamps = false;
            this.timestampformat = "yyyy.MM.dd HH:mm:ss";
            this._outputs = new Dictionary<uint,LogOut>();
        }

        public void Out(string Message)
        {
            if (this._outputs.Count == 0) return;
            if (this.UseTimestamps) Message = DateTime.Now.ToString(this.timestampformat, System.Globalization.CultureInfo.InvariantCulture) + ' ' + Message;
            foreach (LogOut log in this._outputs.Values)
                log.Write(Message);
        }

        public void Out(string Message, TextFormat Format)
        {
            if (this._outputs.Count == 0) return;
            if (this.UseTimestamps) Message = DateTime.Now.ToString(this.timestampformat, System.Globalization.CultureInfo.InvariantCulture) + Environment.NewLine + Message;
            foreach (LogOut log in this._outputs.Values)
                log.Write(Message, Format);
        }

        public uint Open()
        {
            var newlog = new LogOut();
            return this.add(newlog);
        }

        public uint Open(string Filepath)
        {
            var newlog = new LogOut_File(Filepath);
            return this.add(newlog);
        }

        public uint Open(OutputMethod OutMethd)
        {
            var newlog = new LogOut_Method(OutMethd);
            return this.add(newlog);
        }

        private uint add(LogOut newlog)
        {
            this.hndlptr++;
            this._outputs.Add(this.hndlptr, newlog);
            return hndlptr;
        }

        public void Close(uint Handle)
        {
            if (this._outputs == null) return;
            if (!this._outputs.ContainsKey(Handle)) throw new ArgumentException("Handle not found");

            this._outputs.Remove(Handle);
        }
    }
}
