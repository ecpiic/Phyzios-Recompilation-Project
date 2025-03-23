using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using oec;
using OECakeCurrentManaged;
using OECasualCSharp;
using PHYZIOSSystem;
using WindowsViewer.Properties;
namespace WindowsViewer
{
    public class PanelController
    {
        public bool IsSimulating
        {
            get
            {
                return this.Scene.IsSimulating;
            }
            set
            {
                this.Scene.IsSimulating = value;
            }
        }
        public bool IsDrawing { get; set; }
        public SceneCSharp Scene { get; set; }
        public bool IsTimerEnabled
        {
            get
            {
                return this.panelOECMain.TimerMain.Enabled;
            }
        }
        public ConfigurationManaged Config { get; private set; }
        public ModuleDataManaged Modules { get; private set; }
        public bool Pause
        {
            get
            {
                return this.Config.PauseFlag;
            }
            set
            {
                this.IsSimulating = !value;
                this.Config.PauseFlag = value;
            }
        }
        public Tools LeftButtonTool
        {
            get
            {
                return this.Scene.LeftButtonTool;
            }
            set
            {
                this.Scene.LeftButtonTool = value;
                if (this.ToolChanged != null)
                {
                    this.ToolChanged(this, EventArgs.Empty);
                }
            }
        }
        public Materials NextMaterial
        {
            get
            {
                return this.Scene.NextMaterial;
            }
            set
            {
                if (this.Scene.NextMaterial != value)
                {
                    this.Scene.NextMaterial = value;
                    if (this.Scene.CustomColorMode)
                    {
                        this.NextColor = ParticleBeatCSharp.GetColor(value);
                    }
                    if (this.MaterialChange != null)
                    {
                        this.MaterialChange(this, EventArgs.Empty);
                    }
                }
            }
        }
        public ParticleInfoManaged NextParticleInfo
        {
            get
            {
                return this.Scene.Scene.EventManager.NextParticleInfo;
            }
            set
            {
                this.Scene.Scene.EventManager.NextParticleInfo = value;
            }
        }
        public global::System.Windows.Media.Color NextColor
        {
            get
            {
                return this.Scene.NextColor;
            }
            set
            {
                if (this.Scene.NextColor != value)
                {
                    this.Scene.NextColor = value;
                    if (this.ColorChange != null)
                    {
                        this.ColorChange(this, EventArgs.Empty);
                    }
                }
            }
        }
        public bool CustomColorMode
        {
            get
            {
                return this.Scene.CustomColorMode;
            }
            set
            {
                this.Scene.CustomColorMode = value;
            }
        }
        public bool GravityFlag
        {
            get
            {
                return this.Scene.GravityFlag;
            }
            set
            {
                this.Scene.GravityFlag = value;
            }
        }
        public global::System.Windows.Media.Color ClearColor
        {
            set
            {
                this.Scene.Scene.Config.ClearColorRed = (float)value.R / 255f;
                this.Scene.Scene.Config.ClearColorGreen = (float)value.G / 255f;
                this.Scene.Scene.Config.ClearColorBlue = (float)value.B / 255f;
                this.Scene.Scene.Config.ClearColorAlpha = (float)value.A / 255f;
            }
        }
        public event PanelController.AfterMouseUp OnAfterMouseUp;
        public event EventHandler ColorChange;
        public event EventHandler MaterialChange;
        public event EventHandler ToolChanged;
        public float GetFPS()
        {
            return this.FPS;
        }
        public void ResizePanel(int x, int y)
        {
            this.panelOECMain.Width = (int)(this.Config.BoundsWidth * this.Config.Scale);
            this.panelOECMain.Height = (int)(this.Config.BoundsHeight * this.Config.Scale);
            this.panelOECMain.Left = x;
            this.panelOECMain.Top = y;
            this.originalWidth = (float)this.panelOECMain.Width;
            this.originalHeight = (float)this.panelOECMain.Height;
            this.Scene.SceneRenderer.SetViewport(this.panelOECMain.Width, this.panelOECMain.Height);
        }
        public void SetUpPanel1()
        {

        }
        public void RenderPanel()
        {
            this.Draw();
            this.DrawRequest.Clear();
        }
        private void Draw()
        {
            float scale = this.GetScale();
            this.Scene.BeginDraw(scale, 0f - this.Config.BoundsLeft, 0f - this.Config.BoundsBottom);
            this.Scene.Render();
            foreach (DrawReqSt drawReqSt in this.DrawRequest)
            {
                this.Scene.Scene.DrawTexture(drawReqSt.TextureName, drawReqSt.MinX, drawReqSt.MinY, drawReqSt.MaxX, drawReqSt.MaxY, drawReqSt.Alpha);
            }
            this.Scene.SceneRenderer.EndDraw();
        }
        private float GetScale()
        {
            if (this.IsZoomed)
            {
                return Math.Min((float)this.panelOECMain.Height / this.Config.BoundsHeight, (float)this.panelOECMain.Width / this.Config.BoundsWidth);
            }
            return this.Config.Scale;
        }
        private void DrawWithoutSwap()
        {
            this.Scene.BeginDraw(this.Config.Scale, 0f - this.Config.BoundsLeft, 0f - this.Config.BoundsBottom);
            this.Scene.Render();
            foreach (DrawReqSt drawReqSt in this.DrawRequest)
            {
                this.Scene.Scene.DrawTexture(drawReqSt.TextureName, drawReqSt.MinX, drawReqSt.MinY, drawReqSt.MaxX, drawReqSt.MaxY, drawReqSt.Alpha);
            }
        }
        public void UpdatePanel()
        {
            this.FPSFrameCount++;

            if (this.FPSStopWatch.ElapsedMilliseconds >= 1000)
            {
                if (this.FPSStopWatch.Elapsed.TotalMilliseconds > 0.0)
                {
                    this.FPS = (float)((double)this.FPSFrameCount / (this.FPSStopWatch.Elapsed.TotalMilliseconds / 1000.0));
                }

                this.FPSFrameCount = 0;
                this.FPSStopWatch.Restart();
            }

            int timeStep = this.Config.TimeStep;
            this.panelOECMain.Tag = timeStep;

            if (this.IsDroppedAP)
            {
                this.IsDroppedAP = false;
                this.panelOECMain.Focus();
            }

            if (!this.panelOECMain.Visible)
            {
                return;
            }

            if (this.IsSimulating)
            {
                this.Scene.Update(this.panelOECMain.Width, this.panelOECMain.Height);

                if (this.Scene.IsRecording)
                {
                    float originalScale = this.Config.Scale;
                    this.Config.Scale = 4f / (this.originalHeight * (8f / originalScale) * 0.5f / (float)this.recordingHeight);

                    this.DrawWithoutSwap();
                    this.Scene.Record(this.recordingWidth, this.recordingHeight);

                    this.Config.Scale = originalScale;
                }
            }

            this.RenderPanel();
        }

        public void Record(string path)
        {
            this.Record(path, this.recordingWidth, this.recordingHeight);
        }
        public void Record(string path, int width, int height)
        {
            this.recordingWidth = width;
            this.recordingHeight = height;
            this.Scene.IsRecording = true;
            this.Scene.SceneRenderer.Record(path, width, height);
        }
        public void KeyDownEvent(KeyEventArgs e)
        {
            if (this.GetCountParticles(ParticleInfoManaged.Users) != 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        this.OnKeyDown(32);
                        break;
                    case Keys.Prior:
                    case Keys.Next:
                    case Keys.End:
                    case Keys.Home:
                        break;
                    case Keys.Left:
                        this.OnKeyDown(37);
                        return;
                    case Keys.Up:
                        this.OnKeyDown(38);
                        return;
                    case Keys.Right:
                        this.OnKeyDown(39);
                        return;
                    case Keys.Down:
                        this.OnKeyDown(40);
                        return;
                    default:
                        return;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.OemPeriod:
                        this.OnKeyDown(190);
                        return;
                    default:
                        return;
                }
            }
        }
        public void KeyUpEvent(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    this.OnKeyUp(32);
                    break;
                case Keys.Left:
                    this.OnKeyUp(37);
                    break;
                case Keys.Up:
                    this.OnKeyUp(38);
                    break;
                case Keys.Right:
                    this.OnKeyUp(39);
                    break;
                case Keys.Down:
                    this.OnKeyUp(40);
                    break;
            }
            this.OnKeyUp(e.KeyValue);
        }
        public void SetTimerEnable(bool flag)
        {
            this.panelOECMain.TimerMain.Enabled = flag;
        }
        public void ChangeFPSTimer(int ms)
        {
            this.panelOECMain.TimerMain.Interval = ms;
        }
        public void GetOECPos(Size size, int ix, int iy, out float ox, out float oy)
        {
            float num;
            float num2;
            this.UnProject(ix, iy, out num, out num2, this.panelOECMain.ClientSize.Height);
            ox = num;
            oy = num2;
        }
        public void LoadLocalData(string dir)
        {
            this.Clear();
            this.beat.ClearFileSystem();
            this.beat.SetFileResource_SysTmpGameData("main.oec", File.ReadAllBytes(dir));
            Directory.SetCurrentDirectory(Path.GetDirectoryName(dir));
            this.Load("SysTmpGameData.oecd/main.oec");
            this.ResizePanel(this.panelOECMain.Left, this.panelOECMain.Top);
        }
        public bool LoadData(byte[] data)
        {
            this.enterFromClear = false;
            return false;
        }
        public PanelController()
        {
            this.FixWidth = -1;
            this.MouseEnable = true;
            if (this.panelOECMain == null)
            {
                this.panelOECMain = new OECPanel();
                this.panelOECMain.TimerMain.Tick += this.timerMain_Tick;
                this.panelOECMain.MouseMove += this.OECPanel_MouseMove;
                this.panelOECMain.DragDrop += this.OECPanel_DragDrop;
                this.panelOECMain.MouseDown += this.OECPanel_MouseDown;
                this.panelOECMain.DragLeave += this.OECPanel_DragLeave;
                this.panelOECMain.MouseUp += this.OECPanel_MouseUp;
                this.panelOECMain.DragEnter += this.OECPanel_DragEnter;
            }
            if (this.beat == null)
            {
                string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
                string soundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
                this.Config = new ConfigurationManaged();
                this.Modules = new ModuleDataManaged();
                this.meshes = new MeshDataManaged();
                this.lattice = new LatticeDataManaged();
                this.effects = new EffectDataManaged();
                this.latticeBuilder = new LatticeBuilderManaged(this.Config, this.lattice);
                this.meshBuilder = new MeshBuilderManaged(this.Config, this.meshes, this.Modules);
                this.moduleSimulator = new ModuleSimulatorManaged(this.Config, this.Modules);
                this.eventManager = new EventManagerManaged(this.Config);
                this.Scene = new SceneCSharp(this.Config, this.Modules, this.meshes, this.lattice, this.effects, this.meshBuilder, this.latticeBuilder, this.moduleSimulator, this.eventManager);
                this.Scene.IsRecording = false;
                this.particles = this.Scene.Particles.Data;
                this.particleSimulator = this.Scene.Scene.ParticleSimulator;
                this.particleBuilder = this.Scene.particleBuilder.particleBuilder;
                this.meshSimulator = this.Scene.meshSimulator;
                this.gridSimulator = this.Scene.gridSimulator;
                this.effectSimulator = this.Scene.effectSimulator;
                this.beat = new ParticleBeatCSharp();
                this.beat.ParticleBeat = new ParticleBeatManaged(this.Config, this.Modules, this.particles, this.meshes, this.lattice, this.effects, this.particleBuilder, this.latticeBuilder, this.meshBuilder, this.moduleSimulator, this.particleSimulator, this.meshSimulator, this.gridSimulator, this.effectSimulator, this.eventManager, this.Scene.Scene);
                this.Scene.Scene.InitOpenGL((uint)(int)this.panelOECMain.Handle);
                this.NextMaterial = Materials.Users;
                this.LeftButtonTool = Tools.BrushTool;
                this.beat.SetGDILoaderMFileSystem();
                this.beat.SetALLoaderMFileSystem();
                this.Config.TimeStepsPerFrame = 9;
                this.CustomColorMode = true;
                this.LoadFlowSound(Resources.FlowSound);
                this.LoadFireSound(Resources.FireSound);
                this.LoadExplodeSound(Resources.ExplodeSound);
                this.SetMaterialTexture(111, Resources.Blackhall);
                this.SetMaterialTexture(101, Resources.ゴム);
                this.SetMaterialTexture(115, Resources.ひも);
                this.SetMaterialTexture(113, Resources.水);
                this.SetMaterialTexture(114, Resources.石);
                this.SetMaterialTexture(104, Resources.熱い壁);
                this.SetMaterialTexture(112, Resources.粉);
                this.SetMaterialTexture(119, Resources.壁);
                this.SetMaterialTexture(102, Resources.木);
                this.SetMaterialTexture(99, Resources.冷たい壁);
            }
            this.ResizePanel(this.panelOECMain.Left, this.panelOECMain.Top);
            this.DrawRequest = new List<DrawReqSt>();
            this.APUseCounter = new PanelController.APUseCount[0];
            this.SetPath("SysTmpGameData.oecd/");
            this.FPSStopWatch = new Stopwatch();
            this.FPSStopWatch.Start();
            this.FPS = 0f;
            this.FPSFrameCount = 0;
            this.IsZoomed = false;
            this.OldUndoCount = 0;
            this.IsModified = false;
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (this.Scene.GetUndoCount() != this.OldUndoCount)
            {
                this.OldUndoCount = this.Scene.GetUndoCount();
                this.IsModified = true;
            }
            this.UpdatePanel();
        }
        private void OECPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MouseEnable)
            {
                float num;
                float num2;
                this.GetOECPos(this.panelOECMain.ClientSize, e.X, e.Y, out num, out num2);
                this.OnLButtonDown(num, num2);
            }
        }
        private void OECPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.MouseEnable && e.Button != MouseButtons.None)
            {
                float num;
                float num2;
                this.GetOECPos(this.panelOECMain.ClientSize, e.X, e.Y, out num, out num2);
                this.OnMouseMove(num, num2);
            }
        }
        private void OECPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MouseEnable)
            {
                this.OnLButtonUp();
                if (this.OnAfterMouseUp != null)
                {
                    this.OnAfterMouseUp();
                }
            }
        }
        private void OECPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)) || e.Data.GetDataPresent(typeof(int)))
            {
                e.Effect = DragDropEffects.Move;
                this.panelOECMain.TimerMain.Enabled = false;
                return;
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                return;
            }
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
                this.panelOECMain.TimerMain.Enabled = false;
                return;
            }
            e.Effect = DragDropEffects.None;
        }
        private void OECPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
                string[] array2 = array;
                foreach (string text in array2)
                {
                    Point point = this.panelOECMain.PointToClient(new Point(e.X, e.Y));
                    float num;
                    float num2;
                    this.GetOECPos(this.panelOECMain.ClientSize, point.X, point.Y, out num, out num2);
                    Bitmap bitmap = new Bitmap(text);
                    byte[] array4 = CommonMethod.LimitedImageData(bitmap, 640, 480);
                    if (array4.Length != 0)
                    {
                        string text2 = "b64res/" + Convert.ToBase64String(Encoding.UTF8.GetBytes(text)).Replace("+", "-").Replace("/", "_") + Path.GetExtension(text);
                        IntPtr intPtr = Marshal.AllocHGlobal(array4.Length);
                        Marshal.Copy(array4, 0, intPtr, array4.Length);
                        this.beat.SetFileResource(this.Scene.Scene.FileManager.Directory + text2, intPtr, array4.Length);
                        Marshal.FreeHGlobal(intPtr);
                        this.Scene.RegisterUndo();
                        this.Scene.Scene.EventManager.OnFileDropFromFile(this.Scene.Scene, text2, num, num2);
                    }
                }
            }
            else if (e.Data.GetDataPresent(typeof(string)))
            {
                this.IsDroppedAP = true;
            }
            this.panelOECMain.TimerMain.Enabled = true;
        }
        private void OECPanel_DragLeave(object sender, EventArgs e)
        {
            this.panelOECMain.TimerMain.Enabled = true;
        }
        public void SetMouseEnable(bool enable)
        {
            this.MouseEnable = enable;
            this.OnLButtonUp();
        }
        public void OnLButtonDown(float x, float y)
        {
            MouseButtonManaged mouseButtonManaged = MouseButtonManaged.LeftButton;
            if (this.Scene.IsDestructiveMouseOperation(mouseButtonManaged))
            {
                this.Scene.RegisterUndo();
            }
            this.Scene.OnMouseDown(mouseButtonManaged, x, y);
        }
        public void OnMouseMove(float objX, float objY)
        {
            this.Scene.OnMouseMove(objX, objY);
        }
        public void OnLButtonUp()
        {
            this.Scene.OnMouseUp();
        }
        public void OnKeyDown(int keyManaged)
        {
            if (!Util.IsSpecialKey(keyManaged))
            {
                int num = Util.ConvertKey(keyManaged);
                if (!this.Scene.OnKeyDownScript(num))
                {
                    this.Scene.OnKeyDownEvent(num);
                }
            }
        }
        public void OnKeyUp(int keyManaged)
        {
            if (!Util.IsSpecialKey(keyManaged))
            {
                int num = Util.ConvertKey(keyManaged);
                if (!this.Scene.OnKeyUpScript(num))
                {
                    this.Scene.OnKeyUpEvent(num);
                }
            }
        }
        public void Clear()
        {
            this.Scene.RegisterUndo();
            this.Scene.ClearAll();
            bool flag = this.enterFromClear;
            this.enterFromClear = false;
        }
        public void Undo()
        {
            this.Scene.Undo();
        }
        public void SetPath(string pathOriginal)
        {
            pathOriginal.Replace("\\", "/");
        }
        public void Load(string pathOriginal)
        {
            string text = pathOriginal.Replace("\\", "/");
            this.Scene.ClearAllButConfig();
            new FileLoadManager().Execute(this.Scene.Scene.FileManager, this.Scene.Scene, text);
            this.PostLoad();
        }
        private void PostLoad()
        {
            this.Scene.Scene.ScriptManager.SetScene(this.Scene.Scene);
            this.Scene.Scene.ScriptManager.OnLoad(this.Scene.Scene);
            if (!this.Scene.Scene.Config.IsMaterialEnabled(this.Scene.Scene.EventManager.NextMaterial))
            {
                this.Scene.Scene.EventManager.EnableAllMaterials();
            }
            if (!this.Scene.Scene.Config.IsToolEnabled(this.Scene.Scene.EventManager.LeftButtonTool))
            {
                this.Scene.Scene.EventManager.EnableAllTools();
            }
        }
        public int GetCountParticles(ParticleInfoManaged particleInfoManaged)
        {
            return this.Scene.Scene.ParticleBuilder.CountParticles(particleInfoManaged);
        }
        public void UnProject(int ix, int iy, out float ox, out float oy, int clientHeight)
        {
            Float2Managed float2Managed = this.Scene.Scene.UnProject(ix, iy, clientHeight);
            ox = float2Managed.X;
            oy = float2Managed.Y;
        }
        public void StopRecording()
        {
            this.Scene.SceneRenderer.StopRecording();
            this.Scene.IsRecording = false;
        }
        public void SetMaterialTexture(int material, Bitmap bmp)
        {
            if (this.Scene.Scene.Config.MaterialTexture == null)
            {
                this.Scene.Scene.Config.MaterialTexture = TextureManaged.InitWithSize(32, 1024);
                for (int i = 0; i < 1024; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        this.Scene.Scene.Config.MaterialTexture.SetPixel(j, i, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
                    }
                }
            }
            if (bmp.Size.Height != 32 || bmp.Size.Width != 32)
            {
                return;
            }
            this.Scene.Scene.Config.MaterialTexture.DisposeTexture();
            int num = (material & 31) * 32;
            for (int k = 0; k < 32; k++)
            {
                for (int l = 0; l < 32; l++)
                {
                    global::System.Drawing.Color pixel = bmp.GetPixel(l, k);
                    this.Scene.Scene.Config.MaterialTexture.SetPixel(l, k + num, pixel.R, pixel.G, pixel.B, pixel.A);
                }
            }
        }
        public void LoadFlowSound(UnmanagedMemoryStream strm)
        {
            this.Scene.LoadFlowSound(strm);
        }
        public void LoadFireSound(UnmanagedMemoryStream strm)
        {
            this.Scene.LoadFireSound(strm);
        }
        public void LoadExplodeSound(UnmanagedMemoryStream strm)
        {
            this.Scene.LoadExplodeSound(strm);
        }
        public void SetTemplateShape(GeometricShapes shapes)
        {
            this.Config.TemplateShape = shapes;
        }
        public OECPanel panelOECMain;
        private Stopwatch fpsStopwatch = new Stopwatch();
        private int fpsFrameCount = 0;
        private double lastFpsUpdate = 0.0;
        public ParticleBeatCSharp beat;
        public int FixWidth;
        public bool enterFromClear;
        private bool MouseEnable;
        private bool IsDroppedAP;
        private string backgroundPath;
        private float originalWidth = 640f;
        private float originalHeight = 480f;
        private Stopwatch FPSStopWatch;
        private int FPSFrameCount;
        private float FPS;
        public bool IsZoomed;
        public int OldUndoCount;
        public bool IsModified;
        private List<DrawReqSt> DrawRequest;
        private PanelController.APUseCount[] APUseCounter;
        private int recordingWidth = 320;
        private int recordingHeight = 240;
        private ParticleDataManaged particles;
        private MeshDataManaged meshes;
        private LatticeDataManaged lattice;
        private EffectDataManaged effects;
        private ParticleBuilderManaged particleBuilder;
        private LatticeBuilderManaged latticeBuilder;
        private MeshBuilderManaged meshBuilder;
        private ModuleSimulatorManaged moduleSimulator;
        private ParticleSimulatorManaged particleSimulator;
        private MeshSimulatorManaged meshSimulator;
        private LatticeSimulatorManaged gridSimulator;
        private EffectSimulatorManaged effectSimulator;
        private EventManagerManaged eventManager;
        private bool UpKey;
        private bool DownKey;
        private bool RightKey;
        private bool LeftKey;
        private bool SpaceKey;
        public delegate void AfterMouseUp();
        private struct APUseCount
        {
            public APUseCount(string apid)
            {
                this.APID = apid;
                this.UseCount = 1;
            }
            public void AddCount()
            {
                this.UseCount++;
            }
            public string APID;
            public int UseCount;
        }
    }
}
