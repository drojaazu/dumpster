using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading.Tasks;
using dumplib;
using dumplib.Layout;
using dumplib.Text;
using dumplib.Gfx;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace Dumpster2
{
    public partial class frmMain : Form
    {
        // Dock instances
        private dcText TextDock;
        private dcGfx GfxDock;
        private dcColors ColorsDock;
        private dcMap MapDock;
        private dcSearch SearchDock;

        #region     CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR

        public frmMain()
        {
            InitializeComponent();

            // init docks
            this.TextDock = new dcText();
            this.TextDock.HideOnClose = true;
            this.TextDock.DockPanel = this.dockMain;
            this.TextDock.VisibleState = DockState.Float;

            this.GfxDock = new dcGfx();
            this.GfxDock.HideOnClose = true;
            this.GfxDock.DockPanel = this.dockMain;
            this.GfxDock.VisibleState = DockState.Float;

            this.ColorsDock = new dcColors();
            this.ColorsDock.HideOnClose = true;
            this.ColorsDock.DockPanel = this.dockMain;
            this.ColorsDock.VisibleState = DockState.Float;

            this.MapDock = new dcMap();
            this.MapDock.HideOnClose = true;
            this.MapDock.DockPanel = this.dockMain;
            this.MapDock.VisibleState = DockState.Float;

            this.SearchDock = new dcSearch();
            this.SearchDock.HideOnClose = true;
            this.SearchDock.DockPanel = this.dockMain;
            this.SearchDock.VisibleState = DockState.Float;

            // subscribe to dock settings updates
            this.TextDock.TextSettingsUpdated += Settings_TextSettingsUpdated;
            this.GfxDock.GfxSettingsUpdated += Settings_GfxSettingsUpdated;
            this.MapDock.MapSettingsUpdated += Settings_MapSettingsUpdated;
            this.ColorsDock.ColorsSettingsUpdated += Settings_ColorsSettingsUpdated;
        }


        #endregion  CONSTRUCTOR -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR

        #region EVENT WIRING -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- EVENT WIRING

        void Settings_ColorsSettingsUpdated(object sender, EventArgs e)
        {
            var awin = this.ActiveMdiChild as frmImage;
            if (awin != null && awin.OutMode == DumpTypes.Gfx) awin.UpdateOutput();
        }

        void Settings_MapSettingsUpdated(object sender, EventArgs e)
        {
            // check the type of entry, update the docks to match the args
            if (this.MapDock.Settings.SelectedEntry is GfxChunkInfo)
            {
                this.GfxDock.UpdateFromChunkInfo(this.MapDock.Settings.SelectedEntry as GfxChunkInfo);
            }
            else if (this.MapDock.Settings.SelectedEntry is TextChunkInfo)
            {
                this.TextDock.UpdateFromChunkInfo(this.MapDock.Settings.SelectedEntry as TextChunkInfo);
            }
            var awin = this.ActiveMdiChild as frmImage;
            if (awin != null) awin.LoadChunk(this.MapDock.Settings.SelectedEntry);
        }

        void Settings_GfxSettingsUpdated(object sender, EventArgs e)
        {
            var awin = this.ActiveMdiChild as frmImage;
            if (awin != null && awin.OutMode == DumpTypes.Gfx) awin.UpdateOutput();
        }

        void Settings_TextSettingsUpdated(object sender, EventArgs e)
        {
            //MessageBox.Show("Text settings updated!");
            var awin = this.ActiveMdiChild as frmImage;
            if (awin != null && awin.OutMode == DumpTypes.Text) awin.UpdateOutput();
        }

        #endregion

        private void OpenImage(string Filepath)
        {
            try
            {
                if (Filepath == null) return;
                frmImage _newImage = new frmImage(this, Filepath);
                var automap = _newImage.Image.AutoMap();
                automap.Description = Path.GetFileName(Filepath) + " (Auto-generated)";
                this.MapDock.AddMap(automap);
                _newImage.MdiParent = this;
                _newImage.Show();
                Program.Log("Opened image: " + Filepath);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Program.Alert("File Not Found!" + Environment.NewLine + ex.FileName);
            }
        }

        #region     FORM EVENTS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS

        private void mnuImageOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var _temp = ChooseFile.Open("Select a media image", null, null, "All files|*.*|Super Famicom/SNES|*.smc;*.sfc|Megadrive/Genesis|*.smd;*.gen|GameGear|*.gg|Master System|*.sms|Super 32X|*.32x|Gameboy/GB Color|*.gb;*.gbc|Gameboy Advance|*.gba");
                if (_temp == null) return;
                this.OpenImage(_temp);
            }
            catch (Exception err)
            {
                
                Program.ExH.Summary(err);
            }

        }

        private void mnuTableOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var _temp = ChooseFile.Open("Select a text table", null, null, "Text table (Nightcrawler spec)|*.tbl|All files|*.*");
                if (_temp == null) return;

                this.TextDock.AddTable(_temp);
            }
            catch (Exception err)
            {
                Program.ExH.Summary(err);
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is frmImage)
            {
                var image = (this.ActiveMdiChild as frmImage);
                this.TextDock.Settings = image.TextSettings;
                this.GfxDock.Settings = image.GfxSettings;
                this.MapDock.Settings = image.MapSettings;
                this.ColorsDock.Settings = image.ColorsSettings;
            }
        }

        private void mnuTextWin_Click(object sender, EventArgs e)
        {
            if (this.TextDock.Visible)
            {
                this.TextDock.Hide();
                this.mnuTextWin.Checked = false;
            }
            else
            {
                this.TextDock.Show();
                this.mnuTextWin.Checked = true;
            }
        }

        private void mnuGfxWin_Click(object sender, EventArgs e)
        {
            if (this.GfxDock.Visible)
            {
                this.GfxDock.Hide();
                this.mnuGfxWin.Checked = false;
            }
            else
            {
                this.GfxDock.Show();
                this.mnuGfxWin.Checked = true;
            }
        }

        private void mnuColorsWin_Click(object sender, EventArgs e)
        {
            if (this.ColorsDock.Visible)
            {
                this.ColorsDock.Hide();
                this.mnuColorsWin.Checked = false;
            }
            else
            {
                this.ColorsDock.Show();
                this.mnuColorsWin.Checked = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void mnuMapWin_Click(object sender, EventArgs e)
        {
            if (this.MapDock.Visible)
            {
                this.MapDock.Hide();
                this.mnuMapWin.Checked = false;
            }
            else
            {
                this.MapDock.Show();
                this.mnuMapWin.Checked = true;
            }
        }

        private void mnuSearchWin_Click(object sender, EventArgs e)
        {
            if (this.SearchDock.Visible)
            {
                this.SearchDock.Hide();
                this.mnuSearchWin.Checked = false;
            }
            else
            {
                this.SearchDock.Show();
                this.mnuSearchWin.Checked = true;
            }
        }

        private void mnuMapOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var _temp = ChooseFile.Open("Select an image map", null, null, "Image Map|*.imp|All files|*.*");
                if (_temp == null) return;

                this.MapDock.AddMap(_temp);
            }
            catch(Exception err)
            {
                Program.ExH.Summary(err);
            }
        }

        private void mnuImageClose_Click(object sender, EventArgs e)
        {
            var awin = this.ActiveMdiChild;
            if (awin != null) awin.Dispose();
        }

        private void mnuPaletteOpen_Click(object sender, EventArgs e)
        {
            var _temp = ChooseFile.Open("Select a palette file", null, null, "ZSNES Savestate|*.zs?|Gens savestate|*.gs?|TileLayer Palette|*.tpl|All files|*.*");
            if (_temp == null) return;

            this.ColorsDock.AddPalette(_temp);
        }

        private void mnuDebugTesting_Click(object sender, EventArgs e)
        {
            new frmTesting().Show();
        }

        private void mnuMapClose_Click(object sender, EventArgs e)
        {
            this.MapDock.CloseMap();
        }
        #endregion  FORM EVENTS -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS

        /// <summary>
        /// Delegate to be called after Processing has completed
        /// </summary>
        /// <param name="Processed"></param>
        public delegate void ProcCallback(Dump Processed);



        private void mnuTableClose_Click(object sender, EventArgs e)
        {
            this.TextDock.CloseCurrentTable();
        }

        private void mnuPaletteClose_Click(object sender, EventArgs e)
        {
            this.ColorsDock.CloseCurrentPalette();
        }
        /*
        public async Task DumpText(Stream Datastream, Range Addr, ProcCallback Callback)
        {
            if (Stream == null || Addr == null || Callback == null) throw new ArgumentNullException();
            Dump _out;
            if (this._textdock.Settings.UseTable)
            {
                if (this._textdock.CurrentTable == null)
                {
                    //Program.Alert("No tables opened");
                    _out = new Dump(Chunk, null, "(No table loaded.)");

                }
                else
                {
                    var table = this._textdock.CurrentTable;
                    //Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process text data using table");
                    //_out = await Task.Run(() => Image.GetText_Table(Chunk.Addr, table));
                    //_out = await Task.Run(() => GetText.UsingTable(Chunk.Data,table));
                    _out = new Dump(Chunk, null,
                        await Task.Run(() => dumplib.Text.Transcode.UsingTable(Chunk.Data, table)));
                }
            }
            else
            {
                //_out = await Task.Run(() => dumplib.Text.GetText.UsingEncoding(Data, this._textdock.Settings.CodePage));
                int codepage = this._textdock.Settings.CodePage;
                Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process text data using encoding " + codepage.ToString());
                //_out = await Task.Run(() => Image.GetText_Encoding(Addr, System.Text.Encoding.GetEncoding(codepage)));
                _out = new Dump(Chunk, null,
                    await Task.Run(() => dumplib.Text.Transcode.UsingEncoding(Chunk.Data, System.Text.Encoding.GetEncoding(codepage))));
            }
        }

        public async Task DumpGfx(DataChunk Chunk, ProcCallback Callback)
        {
            if (Chunk == null || Callback == null) throw new ArgumentNullException();
            Dump _out;

            if (this._gfxdock.Settings.Mode == GfxSettings.GfxMode.Linear) return;
            else
            {
                Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process gfx data using " + this._gfxdock.Settings.Converter.ToString());
                _out = new Dump(Chunk,
                    await Task.Run(() => dumplib.Gfx.TileGfx.GetTiles(Chunk.Data, this._gfxdock.Settings.Converter,
                    dumplib.Gfx.CreatePalette.New_8bit(), this._gfxdock.Settings.TilesPerRow)));
            }
        }

        public async Task DumpRaw(DataChunk Chunk, ProcCallback Callback)
        {
            if (Chunk == null || Callback == null) throw new ArgumentNullException();
            Dump _out;

            Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Human-readable raw byte dump");
            //_out = await Task.Run(() => Image.GetBytesReadable(Addr));
            _out = new Dump(Chunk, null,
                await Task.Run(() => dumplib.Text.ByteDump.ToHex(Chunk)));
        }
        */
        
        

        /// <summary>
        /// Calls the appropriate functions from dumplib with the passed chunk of byte data
        /// </summary>
        /// <param name="Chunk"></param>
        /// <param name="Mode"></param>
        /// <param name="Callback"></param>
        /// <returns></returns>
        /*
        public async Task Process(DataChunk Chunk, OutModes Mode, ProcCallback Callback)
        {
            if (Chunk == null || Callback == null) throw new ArgumentNullException();   
            //object _out = null;
            Dump _out;
            var optimer = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                switch (Mode)
                {
                    case OutModes.Gfx:
                        if (this._gfxdock.Settings.Mode == GfxSettings.GfxMode.Linear) return;
                        else
                        {
                            Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process gfx data using " + this._gfxdock.Settings.TileFormat.ToString());
                            _out = new Dump(Chunk, 
                                await Task.Run(() => dumplib.Gfx.TileGfx.GetTiles(Chunk.Data, this._gfxdock.Settings.TileFormat,
                                dumplib.Gfx.GetPalette.New_8bit(), this._gfxdock.Settings.TilesPerRow)));
                        }
                        break;
                    case OutModes.Text:
                        if (this._textdock.Settings.UseTable)
                        {
                            if (this._textdock.CurrentTable == null)
                            {
                                //Program.Alert("No tables opened");
                                _out.Out_Text = "(No table loaded.)";
                                break;
                            }
                            var table = this._textdock.CurrentTable;
                            Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process text data using table");
                            //_out = await Task.Run(() => Image.GetText_Table(Chunk.Addr, table));
                            //_out = await Task.Run(() => GetText.UsingTable(Chunk.Data,table));
                            _out.Out_Text = await Task.Run(() => dumplib.Text.Transcode.UsingTable(Chunk.Data, table));
                        }
                        else
                        {
                            //_out = await Task.Run(() => dumplib.Text.GetText.UsingEncoding(Data, this._textdock.Settings.CodePage));
                            int codepage = this._textdock.Settings.CodePage;
                            Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process text data using encoding " + codepage.ToString());
                            //_out = await Task.Run(() => Image.GetText_Encoding(Addr, System.Text.Encoding.GetEncoding(codepage)));
                            _out.Out_Text = await Task.Run(() => dumplib.Text.Transcode.UsingEncoding(Chunk.Data, System.Text.Encoding.GetEncoding(codepage)));
                        }
                        break;
                    default:
                        Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Human-readable raw byte dump");
                        //_out = await Task.Run(() => Image.GetBytesReadable(Addr));
                        _out.Out_Text = await Task.Run(() => dumplib.Text.ByteDump.ToHex(Chunk));
                        break;
                }
            }
            catch (Exception ex)
            {
                Program.ExH.Extended(ex, "Error while processing");
                _out = null;
            }
            finally
            {
                optimer.Stop();
                Program.Log("Processing time: " + optimer.ElapsedMilliseconds.ToString() + " ms");
                Callback(_out);
            }
        }*/
       
    }
}
