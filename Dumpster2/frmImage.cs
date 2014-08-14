using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using dumplib.Image;
using dumplib.Text;
using dumplib.Layout;
using dumplib.Gfx;
using dumplib;

namespace Dumpster2
{
    
    public partial class frmImage : Form
    {
        //handle to the MDI main
        //private frmMain _main;

        //output object, holds and displays the output from the Process function
        private Dump _out;

        //the actual image data
        public MediaImage Image
        {
            get;
            private set;
        }

        //the currently loaded chunk of raw data - this is passed to Process to obtain Output
        private DataChunk CurrentChunk = null;

        //each frmImage has its own set of Settings objects
        //these are passed to each respective dock on MDI child activate
        //the docks update the properties on the Settings and raise events for updates
        //frmMain listens for dock updates and invokes UpdateOutput method from the active MDI child

        // Don't forget! The settings are passed BY REFERENCE, so the properties are modified by the dock itself!

        public TextSettings TextSettings
        {
            get;
            private set;
        }

        public GfxSettings GfxSettings
        {
            get;
            private set;
        }

        public ColorsSettings ColorsSettings
        {
            get;
            private set;
        }

        public MapSettings MapSettings
        {
            get;
            private set;
        }

        //property that puts the frmImage UI in "Working" mode
        //Disables process button, address changes, etc
        private bool isworking=false;
        public bool IsWorking
        {
            get
            {
                return this.isworking;
            }
            private set
            {
                if (this.isworking == value) return;
                this.isworking = value;
                if (this.isworking)
                {
                    this.strip_btnLoad.Enabled = false;
                    this.strip_btnRaw.Enabled = false;
                    this.strip_btnText.Enabled = false;
                    this.strip_btnGfx.Enabled = false;
                    this.UseWaitCursor = true;
                    this.strip_btnLoad.Text = "WORKING...";
                }
                else
                {
                    this.strip_btnLoad.Enabled = true;
                    this.strip_btnRaw.Enabled = true;
                    this.strip_btnText.Enabled = true;
                    this.strip_btnGfx.Enabled = true;
                    this.UseWaitCursor = false;
                    this.strip_btnLoad.Text = "Load";
                }
            }
        }
        
        //property that sets the output mode and updates the UI
        private DumpTypes outmode = DumpTypes.Raw;
        public DumpTypes OutMode
        {
            get
            {
                return this.outmode;
            }
            set
            {
                this.outmode = value;
                switch (this.outmode)
                {
                    case DumpTypes.Raw:
                        this.strip_btnRaw.Checked = true;
                        this.strip_btnText.Checked = false;
                        this.strip_btnGfx.Checked = false;
                        break;
                    case DumpTypes.Gfx:
                        this.strip_btnRaw.Checked = false;
                        this.strip_btnText.Checked = false;
                        this.strip_btnGfx.Checked = true;
                        break;
                    case DumpTypes.Text:
                        this.strip_btnRaw.Checked = false;
                        this.strip_btnText.Checked = true;
                        this.strip_btnGfx.Checked = false;
                        break;
                }
                this.UpdateOutput();
            }
        }
        
        public bool UseHex
        {
            get;
            set;
        }

        //sets whether the second offset is an absolute address or length and updates the UI
        private bool uselength;
        public bool UseLength
        {
            get
            {
                return this.uselength;
            }
            set
            {
                this.uselength = value;
                if (this.uselength)
                {
                    this.mnuLength.Checked = true;
                    this.mnuEndOffset.Checked = false;
                    this.strip_btnEnd.Text = "Length";
                }
                else
                {
                    this.mnuEndOffset.Checked = true;
                    this.mnuLength.Checked = false;
                    this.strip_btnEnd.Text = "End Offset";
                }
            }
        }
        #region -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- CONSTRUCTOR
        //frmImage can be initialized with a file path
        public frmImage(frmMain frmMain, string Filepath)
        {
            if (Filepath == null)
                throw new ArgumentNullException("Filepath is null");
            if (!File.Exists(Filepath))
                throw new FileNotFoundException();
            this.Image = OpenImage(Filepath);
            //this._main = frmMain;
            this.Init();
        }

        /*public frmImage(frmMain frmMain, MediaImage Image)
        {
            if (Image == null)
                throw new ArgumentNullException("Image is null");
            this._image = Image;
            this._main = frmMain;

            this.Init();
        }*/
        #endregion

        #region -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- PUBLIC MEMBERS
        /// <summary>
        /// Initialization / Setup
        /// </summary>
        public void Init()
        {           
            this.InitializeComponent();
            this.isworking = false;
            this.TextSettings = new TextSettings();
            this.GfxSettings = new GfxSettings();
            this.ColorsSettings = new ColorsSettings();
            this.MapSettings = new MapSettings();
            
            this.Text = Image.SoftwareTitle;
            this.UseLength = true;
            
            this.OutMode = DumpTypes.Raw;
            this.UseHex = true;
            this.status_lblImageInfo.Text = this.Image.HardwareName;
        }

        

        /// <summary>
        /// Loads a chunk of data, applies any extra settings, calls UpdateOutput
        /// </summary>
        /// <param name="Entry"></param>
        public async Task LoadChunk(IChunkInfo Entry)
        {
            if (Entry == null) return;
            this.CurrentChunk = this.Image.GetChunk(Entry);

            this.strip_txtStart.Text = this.CurrentChunk.Info.Addr.StartOffset.ToString("X");
            if (this.UseLength) this.strip_txtEnd.Text = this.CurrentChunk.Info.Addr.Length.ToString("X");
            else this.strip_txtEnd.Text = this.CurrentChunk.Info.Addr.EndOffset.ToString("X");

            if (Entry is TextChunkInfo) this.OutMode = DumpTypes.Text;
            else if (Entry is GfxChunkInfo) this.OutMode = DumpTypes.Gfx;
            //else this.OutMode = DumpTypes.Raw;
            
            await this.UpdateOutput();
        }

        public async Task UpdateOutput()
        {
            if (this.CurrentChunk == null) return;
            this.IsWorking = true;
            
            var optimer = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                switch (this.OutMode)
                {
                    case DumpTypes.Raw:
                        _out = new Dump(CurrentChunk, null,
                            await Task.Run(() => dumplib.Text.ByteDump.ToHex(this.CurrentChunk)));

                        this.dispOut.OutText = this._out.Text;
                        this.dispOut.Mode = DispOut.Modes.Text;
                        break;
                    case DumpTypes.Gfx:
                        if (this.GfxSettings.Mode == GfxSettings.GfxMode.Linear) return;

                    
                        _out = new Dump(CurrentChunk,
                            await Task.Run(() => TileGfx.GetTiles(CurrentChunk.Data,
                                Program.TileConverters[this.GfxSettings.TileConverter],
                                this.ColorsSettings.DrawPalette, this.GfxSettings.TilesPerRow)));

                        if (this.GfxSettings.Zoom > 0) this.dispOut.OutPic = dumplib.Gfx.Misc.ZoomImage(this._out.Image as System.Drawing.Bitmap, (int)Math.Pow(2, this.GfxSettings.Zoom));
                        else this.dispOut.OutPic = this._out.Image;
                        this.dispOut.Mode = DispOut.Modes.Gfx;
                        break;
                    case DumpTypes.Text:
                        if (this.TextSettings.UseTable)
                        {
                            if (this.TextSettings.CurrentTable == null)
                            {
                                _out = new Dump(CurrentChunk, null, "(No table loaded.)");
                            }
                            else
                            {
                                _out = new Dump(CurrentChunk, null,
                                    await Task.Run(() => dumplib.Text.Transcode.UsingTable(CurrentChunk.Data, this.TextSettings.CurrentTable)));
                            }
                        }
                        else
                        {
                            //_out = await Task.Run(() => dumplib.Text.GetText.UsingEncoding(Data, this._textdock.Settings.CodePage));
                            
                            //Program.Log(Chunk.File.Name + " : " + Chunk.Info.Addr.ToString() + " : Process text data using encoding " + codepage.ToString());
                            //_out = await Task.Run(() => Image.GetText_Encoding(Addr, System.Text.Encoding.GetEncoding(codepage)));
                            _out = new Dump(CurrentChunk, null,
                                await Task.Run(() => dumplib.Text.Transcode.UsingEncoding(CurrentChunk.Data, this.TextSettings.Encoding)));
                        }
                        this.dispOut.OutText = this._out.Text;
                        this.dispOut.Mode = DispOut.Modes.Text;
                        break;
                }
                this.status_lblChunkAddr.Text = this.CurrentChunk.Info.Addr.ToString();
            }
            catch (Exception ex)
            {
                Program.ExH.Extended(ex, "Error while processing");
                this.dispOut.OutText = "Error while processing!";
                this.dispOut.Mode = DispOut.Modes.Text;
                return;
            }
            finally
            {
                optimer.Stop();
                this.IsWorking = false;
                Program.Log("Processing time: " + optimer.ElapsedMilliseconds.ToString() + " ms");
                //Callback(_out);
            }
        }
        #endregion

        #region -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- PRIVATE MEMBERS
        
        /// <summary>
        /// Creates a media image from the specified filename.
        /// It will use the file extension to choose which type of media image derived type to use.
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        private MediaImage OpenImage(string Filepath)
        {
            FileStream ImageFile = null;
            try
            {
                ImageFile = new FileStream(Filepath, FileMode.Open);
                switch (System.IO.Path.GetExtension(Filepath).ToLower())
                {
                    case ".sfc":
                        return new NintendoSuperFamicom_ROM(ImageFile);
                    case ".smc":
                    case ".fig":
                    case ".swc":
                        return new NintendoSuperFamicom_ROM(ImageFile, new SuperFamicom_Dumpers());
                    case ".smd":
                        return new SegaMegadrive_ROM(ImageFile, new SegaMegadrive_SuperMagicdrive());
                    case ".md":
                    case ".gen":
                        return new SegaMegadrive_ROM(ImageFile);
                    case ".gb":
                    case ".gbc":
                        return new NintendoGameboy_ROM(ImageFile);
                    case ".z64":
                        return new Nintendo64_ROM(ImageFile);
                    case ".v64":
                        return new Nintendo64_ROM(ImageFile, new Nintendo64_DoctorV64());
                    case ".n64":
                        return new Nintendo64_ROM(ImageFile, new Nintendo64_CD64());
                    case ".gba":
                        return new NintendoGameboyAdv_ROM(ImageFile);
                    case ".gg":
                        return new SegaGameGear_ROM(ImageFile);
                    case ".vb":
                        return new NintendoVirtualBoy_ROM(ImageFile);
                    case ".32x":
                        return new SegaSuper32X_ROM(ImageFile);
                    case ".fds":
                        return new NintendoFamicomDiskSys_disk(ImageFile, new NintendoFDS_FDS());
                    case ".fam":
                        return new NintendoFamicomDiskSys_disk(ImageFile, new NintendoFDS_FAM());
                    case ".ngp":
                        return new SNKNeoGeoPocket_ROM(ImageFile);
                    case ".nes":
                    case ".fc":
                        return new NintendoFamicom_ROM(ImageFile);
                    default:
                        return new UNK_ROM(ImageFile);
                }
            }
            
            catch
            {
                if (ImageFile != null) ImageFile.Close();
                return null;
            }
        }

        /// <summary>
        /// Validates the address range text boxes and creates a Range object
        /// </summary>
        /// <param name="Addr"></param>
        /// <returns></returns>
        private bool TryValidateInput(out Range Addr)
        {
            try
            {
                Addr = null;
                if (this.strip_txtStart.Text == string.Empty || this.strip_txtEnd.Text == string.Empty)
                {
                    Program.Alert("Start/End value is blank");
                    return false;
                }

                long start; int end;
                start = long.Parse(this.strip_txtStart.Text, System.Globalization.NumberStyles.HexNumber);
                end = int.Parse(this.strip_txtEnd.Text, System.Globalization.NumberStyles.HexNumber);

                // well duh start and end can be the same, happens when length = 1
                /*if (start == end)
                {
                    Program.Alert("Start and End are the same");
                    return false;
                }*/

                if (start > this.Image.Datastream.Length)
                {
                    Program.Alert("Start offset goes past end of image");
                    return false;
                }

                if (end > this.Image.Datastream.Length)
                {
                    Program.Alert((this.UseLength ? "Length" : "End offset") + " goes past end of image");
                    return false;
                }

                if (this.UseLength)
                {
                    if (end < 1)
                    {
                        Program.Alert("Length must be at least 1");
                        return false;
                    }
                    Addr = new Range(start, end);
                }
                else
                {
                    if (end < start)
                    {
                        Program.Alert("End offset cannot be before start offset");
                        return false;
                    }
                    Addr = new Range(start, (end - (int)start) + 1);
                }
                return true;
            }
            catch (FormatException)
            {
                Addr = null;
                Program.Alert("Invalid character(s) in address");
                return false;
            }
            catch (ArgumentException ex)
            {
                Addr = null;
                Program.Alert(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Addr = null;
                Program.ExH.Extended(ex);
                return false;
            }
        }

        #region -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS
        
        //UI event, user clicks Load
        //validates the input and loads the chunk, then calls UpdateOutput
        private async void strip_btnLoad_Click(object sender, EventArgs e)
        {
            Range addr;
            if (!TryValidateInput(out addr)) return;
            IChunkInfo g;
            if (this.outmode == DumpTypes.Gfx)
            {
                g = new GfxChunkInfo(addr, addr.Length.ToString() + " bytes of data");
                //(g as GfxChunkInfo).FormatID = _gfxsettings.Converter;
            }
            else if (this.outmode == DumpTypes.Raw) g = new ChunkInfo(addr, addr.Length.ToString() + " bytes of data");
            else g = new TextChunkInfo(addr, addr.Length.ToString() + " bytes of data");
            await this.LoadChunk(g);
            //this.CurrentChunk = new DataChunk(g, this.Image);
            //await this.UpdateOutput();
        }

        private void mnuEndOffset_Click(object sender, EventArgs e)
        {
            this.UseLength = false;
        }

        private void mnuLength_Click(object sender, EventArgs e)
        {
            this.UseLength = true;
        }

        private void strip_btnRaw_Click(object sender, EventArgs e)
        {
            this.OutMode = DumpTypes.Raw;
        }

        private void strip_btnText_Click(object sender, EventArgs e)
        {
            this.OutMode = DumpTypes.Text;
        }

        private void strip_btnGfx_Click(object sender, EventArgs e)
        {
            this.OutMode = DumpTypes.Gfx;
        }


        #endregion -=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=-=:=-=:=--=:=- FORM EVENTS

        private void mnuExportRaw_Click(object sender, EventArgs e)
        {
            var savefile = ChooseFile.Save("Save data chunk as...", this.Image.SoftwareTitle + " - " + this.CurrentChunk.Info.Addr.StartOffset + "-" + this.CurrentChunk.Info.Addr.EndOffset, null, "All files|*.*");
            if (savefile == null) return;
            File.WriteAllBytes(savefile, this.CurrentChunk.Data);
        }

        #endregion

        private void mnuExport_Click(object sender, EventArgs e)
        {
            string filter=null, title=null;
            switch (this.OutMode)
            {
                case DumpTypes.Gfx:
                    title = "Save image as...";
                    filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg";
                    break;
                case DumpTypes.Raw:
                case DumpTypes.Text:
                    title = "Save text as...";
                    filter = "Text file|*.txt";
                    break;
                default:
                    Program.Alert("current unsupported");
                    break;
            }

            var savefile = ChooseFile.Save(title, this.Image.SoftwareTitle + " - " + this.CurrentChunk.Info.Addr.StartOffset + "-" + this.CurrentChunk.Info.Addr.EndOffset, null, filter);
            if (savefile == null) return;
            if (this.OutMode == DumpTypes.Gfx)
            {
                switch (Path.GetExtension(savefile).ToLower())
                {
                    case ".png":
                        this.dispOut.OutPic.Save(savefile, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".gif":
                        this.dispOut.OutPic.Save(savefile, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case ".bmp":
                        this.dispOut.OutPic.Save(savefile, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".jpg":
                    case ".jpeg":
                        this.dispOut.OutPic.Save(savefile, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    default:
                        Program.Alert("current unsupported");
                        break;
                }
            }
            else
            {
                File.WriteAllText(savefile, this.dispOut.OutText);
            }
        }

        private void frmImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Image != null) this.Image.Datastream.Close();
        }

    }
}
