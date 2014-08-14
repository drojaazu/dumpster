/*
 * DUMPSTER
 * (C) 2010-2014 Damian Rogers - All Rights Reserved
 * Any and all hardware, software or company names referenced herein are copyright to their respective owners
 * 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Dumpster2
{
    static class Program
    {
        private static Assembly dumpass = Assembly.GetEntryAssembly();

        public static frmMain MainForm;
        //private static frmMain MainForm;
        internal readonly static Logger AppLog = new Logger();
        internal readonly static ExHandle.ExHandle ExH = new ExHandle.ExHandle(AppLog);
        internal readonly static Random Rand = new Random();
        internal readonly static Version Version = dumpass.GetName().Version;
        internal readonly static DateTime Date = new DateTime(2013, 11, 27, 15, 17, 0);
        internal readonly static Version DumplibVersion = initDumplib();
        internal readonly static string WorkDir = Path.GetDirectoryName(dumpass.Location);

        //lists of interfaces and classes in dumplib and other DLLs
        internal static Dictionary<string, dumplib.Gfx.IColorConverter> ColorConverters = new Dictionary<string, dumplib.Gfx.IColorConverter>();
        internal static Dictionary<string, dumplib.Gfx.ITileConverter> TileConverters = new Dictionary<string, dumplib.Gfx.ITileConverter>();
        internal static Dictionary<string, dumplib.Gfx.IPaletteConverter> PaletteConverters = new Dictionary<string, dumplib.Gfx.IPaletteConverter>();
        internal static List<dumplib.Image.MediaImage> MediaImages = new List<dumplib.Image.MediaImage>();

        [STAThread]
        static void Main()
        {
            if (DumplibVersion == null) return;
            try
            {
                LibLoad.InitLibs();
                AppLog.UseTimestamps = true;
                AppLog.Open(("dumpsterdebug_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".log"));
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm = new frmMain();
                Application.Run(MainForm);
            }
            
            catch (Exception ex)
            {
                ExH.Extended(ex, "Fatal error!");
            }

            
        }

        public static void Log(string Message)
        {
            if (string.IsNullOrEmpty(Message)) return;
            AppLog.Out(Message);
        }

        public static void Alert(string Message, string Caption = "Error")
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static Version initDumplib()
        {
            System.Diagnostics.FileVersionInfo ver = null;
            try
            {
                ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(@"DumpLib.dll");
                
            }
            catch (System.IO.FileNotFoundException)
            {
                Alert("Fatal error: DumpLib DLL not found!");
                return null;
            }
            return new Version(ver.FileVersion);
        }
    }
}
