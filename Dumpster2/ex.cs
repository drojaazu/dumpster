using System;
using System.Windows.Forms;

namespace ExHandle
{
    public static class ExExt
    {
        public static string Description(this Exception ex)
        {
            return ex.GetType().Name + ": " + ex.Message;
        }

        public static string InnerExList(this Exception ex)
        {
            string _out = string.Empty;
            int lv = 1;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                _out += new string('-', lv) + Description(ex) + Environment.NewLine;
                lv++;
            }
            return _out;
        }
    }

    public class ExHandle
    {
        public Dumpster2.Logger Log {
            get; set;
        }

        public ExHandle()
        {
            this.Log = null;
        }

        public ExHandle(Dumpster2.Logger Log) {
            if(Log == null) throw new ArgumentNullException("Log");
            this.Log = Log;
        }

        public void Summary(Exception ex, string ExtraInfo = null)
        {
            System.Text.StringBuilder message = new System.Text.StringBuilder();
            if (ExtraInfo != null) message.AppendLine(ExtraInfo + Environment.NewLine);
            message.AppendLine(ex.Description() + Environment.NewLine);
            if (this.Log != null) this.Log.Out(message.ToString(), Dumpster2.Logger.TextFormat.Box);
            var df = new frmError(ex.GetType().Name, message.ToString());
        }

        public void Trace(Exception ex, string ExtraInfo = null)
        {
            System.Text.StringBuilder message = new System.Text.StringBuilder();
            if (ExtraInfo != null) message.AppendLine(ExtraInfo + Environment.NewLine);
            message.AppendLine(ex.Description() + Environment.NewLine);
            message.AppendLine("--Stack Trace--" + Environment.NewLine + ex.StackTrace + Environment.NewLine);
            if (this.Log != null) this.Log.Out(message.ToString(), Dumpster2.Logger.TextFormat.Box);
            var df = new frmError(ex.GetType().Name, message.ToString());
        }

        public void Extended(Exception ex, string ExtraInfo = null)
        {
            System.Text.StringBuilder message = new System.Text.StringBuilder();
            if (ExtraInfo != null) message.AppendLine(ExtraInfo + Environment.NewLine);
            message.AppendLine(ex.Description() + Environment.NewLine);
            message.AppendLine("--Stack Trace--" + Environment.NewLine + ex.StackTrace + Environment.NewLine);
            if (ex.InnerException != null) message.AppendLine("Inner Exceptions:" + Environment.NewLine + ex.InnerExList() + Environment.NewLine);
            if (this.Log != null) this.Log.Out(message.ToString(), Dumpster2.Logger.TextFormat.Box);
            var df = new frmError(ex.GetType().Name, message.ToString());
        }
    }
}
