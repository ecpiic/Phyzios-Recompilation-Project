using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;
using oec;
using PHYZIOSSystem;
namespace OECasualCSharp
{
    public class SceneCSharp
    {
        public SceneWrap Scene { get; set; }
        public ParticleDataCSharp Particles { get; private set; }
        public ParticleSimulatorCSharp ParticleSimulator { get; private set; }
        private FileManagerCSharp fileManager
        {
            get
            {
                return new FileManagerCSharp(this.Scene.FileManager);
            }
        }
        public SceneRendererManaged SceneRenderer { get; private set; }
        public bool IsSimulating { get; set; }
        public bool IsRecording { get; set; }
        internal bool IsMaterialEnabled
        {
            get
            {
                return this.config.IsMaterialEnabled(this.eventManager.NextMaterial);
            }
        }
        internal bool IsToolEnabled
        {
            get
            {
                return this.config.IsToolEnabled(this.eventManager.LeftButtonTool);
            }
        }
        public float BoundsWidth
        {
            get
            {
                return this.config.BoundsWidth;
            }
        }
        public float BoundsHeight
        {
            get
            {
                return this.config.BoundsHeight;
            }
        }
        public bool PauseFlag
        {
            get
            {
                return this.config.PauseFlag;
            }
            set
            {
                this.config.PauseFlag = value;
            }
        }
        public int TimeStep
        {
            get
            {
                return this.config.TimeStep;
            }
        }
        public int TimeStepsPerFrame
        {
            get
            {
                return this.config.TimeStepsPerFrame;
            }
            set
            {
                this.config.TimeStepsPerFrame = value;
            }
        }
        public float Scale
        {
            get
            {
                return this.config.Scale;
            }
            set
            {
                this.config.Scale = value;
            }
        }
        public float BoundsLeft
        {
            get
            {
                return this.config.BoundsLeft;
            }
            set
            {
                this.config.BoundsLeft = value;
            }
        }
        public float BoundsBottom
        {
            get
            {
                return this.config.BoundsBottom;
            }
            set
            {
                this.config.BoundsBottom = value;
            }
        }
        public float BoundsRight
        {
            get
            {
                return this.config.BoundsRight;
            }
            set
            {
                this.config.BoundsRight = value;
            }
        }
        public float BoundsTop
        {
            get
            {
                return this.config.BoundsTop;
            }
            set
            {
                this.config.BoundsTop = value;
            }
        }
        public bool ScrollFlag
        {
            get
            {
                return this.config.ScrollFlag;
            }
            set
            {
                this.config.ScrollFlag = value;
            }
        }
        public float ScrollLeft
        {
            get
            {
                return this.config.ScrollLeft;
            }
            set
            {
                this.config.ScrollLeft = value;
            }
        }
        public float ScrollRight
        {
            get
            {
                return this.config.ScrollRight;
            }
            set
            {
                this.config.ScrollRight = value;
            }
        }
        public float ScrollBottom
        {
            get
            {
                return this.config.ScrollBottom;
            }
            set
            {
                this.config.ScrollBottom = value;
            }
        }
        public float ScrollTop
        {
            get
            {
                return this.config.ScrollTop;
            }
            set
            {
                this.config.ScrollTop = value;
            }
        }
        public float BackgroundScrollX
        {
            get
            {
                return this.config.BackgroundScrollX;
            }
            set
            {
                this.config.BackgroundScrollX = value;
            }
        }
        public float BackgroundScrollY
        {
            get
            {
                return this.config.BackgroundScrollY;
            }
            set
            {
                this.config.BackgroundScrollY = value;
            }
        }
        public float ForegroundScrollX
        {
            get
            {
                return this.config.ForegroundScrollX;
            }
            set
            {
                this.config.ForegroundScrollX = value;
            }
        }
        public float ForegroundScrollY
        {
            get
            {
                return this.config.ForegroundScrollY;
            }
            set
            {
                this.config.ForegroundScrollY = value;
            }
        }
        public bool StartFlag
        {
            get
            {
                return this.config.StartFlag;
            }
            set
            {
                this.config.StartFlag = value;
            }
        }
        public bool GoalFlag
        {
            get
            {
                return this.config.GoalFlag;
            }
            set
            {
                this.config.GoalFlag = value;
            }
        }
        public float StartTop
        {
            get
            {
                return this.config.StartTop;
            }
            set
            {
                this.config.StartTop = value;
            }
        }
        public float StartBottom
        {
            get
            {
                return this.config.StartBottom;
            }
            set
            {
                this.config.StartBottom = value;
            }
        }
        public float StartLeft
        {
            get
            {
                return this.config.StartLeft;
            }
            set
            {
                this.config.StartLeft = value;
            }
        }
        public float StartRight
        {
            get
            {
                return this.config.StartRight;
            }
            set
            {
                this.config.StartRight = value;
            }
        }
        public float GoalTop
        {
            get
            {
                return this.config.GoalTop;
            }
            set
            {
                this.config.GoalTop = value;
            }
        }
        public float GoalBottom
        {
            get
            {
                return this.config.GoalBottom;
            }
            set
            {
                this.config.GoalBottom = value;
            }
        }
        public float GoalLeft
        {
            get
            {
                return this.config.GoalLeft;
            }
            set
            {
                this.config.GoalLeft = value;
            }
        }
        public float GoalRight
        {
            get
            {
                return this.config.GoalRight;
            }
            set
            {
                this.config.GoalRight = value;
            }
        }
        public int ToolMask
        {
            get
            {
                return this.config.ToolMask;
            }
            set
            {
                this.config.ToolMask = value;
            }
        }
        public int MaterialMask
        {
            get
            {
                return this.config.MaterialMask;
            }
            set
            {
                this.config.MaterialMask = value;
            }
        }
        public bool GravityFlag
        {
            get
            {
                return this.config.GravityFlag;
            }
            set
            {
                this.config.GravityFlag = value;
            }
        }
        public Tools LeftButtonTool
        {
            get
            {
                return this.eventManager.LeftButtonTool;
            }
            set
            {
                this.eventManager.LeftButtonTool = value;
            }
        }
        public Materials NextMaterial
        {
            get
            {
                return this.eventManager.NextMaterial;
            }
            set
            {
                this.eventManager.NextMaterial = value;
            }
        }
        public Color NextColor
        {
            get
            {
                return this.eventManager.NextColor;
            }
            set
            {
                this.eventManager.NextColor = value;
            }
        }
        public bool CustomColorMode
        {
            get
            {
                return this.eventManager.CustomColorMode;
            }
            set
            {
                this.eventManager.CustomColorMode = value;
            }
        }
        private SpriteDataManaged Sprites
        {
            get
            {
                return this.Scene.Sprites;
            }
        }
        public int LevelsOfUndo
        {
            get
            {
                return this.undoManager.LevelsOfUndo;
            }
            set
            {
                this.undoManager.LevelsOfUndo = value;
            }
        }
        public bool Store
        {
            get
            {
                return this.fileManager.Store;
            }
        }
        public List<ModuleManaged> SelectedModuleList
        {
            get
            {
                List<ModuleManaged> list = new List<ModuleManaged>();
                foreach (ParticleBodyManaged particleBodyManaged in this.Scene.Particles.SelectedBodyList)
                {
                    if (particleBodyManaged.Module != null)
                    {
                        list.Add(particleBodyManaged.Module);
                    }
                }
                return list;
            }
        }
        public event EventHandler OnSampleParticle;
        public event EventHandler OnRecordTimeOver;
        public SceneCSharp(ConfigurationManaged config, ModuleDataManaged modules, MeshDataManaged meshes, LatticeDataManaged lattice, EffectDataManaged effects, MeshBuilderManaged meshBuilder, LatticeBuilderManaged latticeBuilder, ModuleSimulatorManaged moduleSimulator, EventManagerManaged eventManager)
        {
            this.config = config;
            this.modules = modules;
            this.Particles = new ParticleDataCSharp(new ParticleDataManaged());
            this.meshes = meshes;
            this.lattice = lattice;
            this.effects = effects;
            this.particleBuilder = new ParticleBuilderCSharp(config, this.Particles.Data, modules);
            this.latticeBuilder = latticeBuilder;
            this.meshBuilder = meshBuilder;
            this.moduleSimulator = moduleSimulator;
            this.meshSimulator = new MeshSimulatorManaged(config, meshes, this.Particles.Data);
            this.gridSimulator = new LatticeSimulatorManaged(config, lattice, this.Particles.Data);
            this.effectSimulator = new EffectSimulatorManaged(config, effects, this.Particles.Data);
            this.eventManager = eventManager;
            this.soundManager = new SoundManagerCSharp(config, this.Particles, effects);
            this.Scene = new SceneWrap(config, modules, this.Particles.Data, meshes, lattice, effects, this.particleBuilder.particleBuilder, latticeBuilder, meshBuilder, moduleSimulator, this.meshSimulator, this.gridSimulator, this.effectSimulator, eventManager, new FileLoadManager());
            this.scriptManager = new ScriptManagerCSharp(this.Scene.ScriptManager);
            this.SceneRenderer = this.Scene.SceneRenderer;
            this.boxSimulator = this.Scene.BoxSimulator;
            this.ParticleSimulator = new ParticleSimulatorCSharp(this.Scene.ParticleSimulator);
            this.spriteSimulator = new SpriteSimulatorManaged(config, this.Scene.Sprites);
        }
        public bool IsDestructiveMouseOperation(MouseButtonManaged button)
        {
            return this.eventManager.IsDestructiveMouseOperation((int)button);
        }
        internal bool IsDestructiveKeyOperation(int key)
        {
            return this.eventManager.IsDestructiveKey(key);
        }
        internal void Simulate()
        {
            if (!this.eventManager.ShouldPause)
            {
                this.OnSimulateEvent();
                this.ApplyModuleCommands();
                this.modules.Inactivate();
                this.ParticleSimulator.Simulate();
                this.boxSimulator.Simulate();
                this.effectSimulator.Simulate();
                this.modules.Gc();
                this.scriptManager.OnSimulate(this);
                this.ApplyModuleCommands();
                ConfigurationManaged configurationManaged = this.config;
                int timeStep = configurationManaged.TimeStep;
                configurationManaged.TimeStep = timeStep + 1;
                this.config.Time += (double)this.config.DeltaT;
            }
        }
        private void ApplyModuleCommands()
        {
            if (this.modules.HasCommands())
            {
                this.Scene.ParticleSimulator.ApplyModuleCommands();
                this.boxSimulator.ApplyModuleCommands();
                this.modules.ClearCommands();
            }
        }
        private void OnSimulateEvent()
        {
            for (int i = 0; i < this.eventManager.CountMouses; i++)
            {
                MouseContextManaged mouseContext = this.eventManager.GetMouseContext(i);
                mouseContext.CursorVelocity += 2f * ((mouseContext.LastLocation - mouseContext.CursorLocation) / this.config.MouseDelay - mouseContext.CursorVelocity) / this.config.MouseDelay;
                mouseContext.CursorLocation += mouseContext.CursorVelocity;
                Tools currentTool = mouseContext.CurrentTool;
                if (currentTool != Tools.ArrowTool)
                {
                    if (currentTool == Tools.ControlTool)
                    {
                        Float2Managed float2Managed = mouseContext.CursorLocation - this.particleBuilder.CenterOfParticles(ParticleInfoManaged.Users);
                        Float2Managed float2Managed2 = Float2Managed.Normalize(float2Managed);
                        this.config.UsersX = float2Managed2.X;
                        this.config.UsersY = float2Managed2.Y;
                    }
                }
                else
                {
                    this.particleBuilder.DragParticles(mouseContext.CursorLocation, mouseContext.CursorVelocity);
                    this.latticeBuilder.DragLattice(mouseContext.CursorLocation, mouseContext.CursorVelocity);
                    this.meshBuilder.DragMeshes(mouseContext.CursorLocation, mouseContext.CursorVelocity);
                }
            }
        }
        public bool OnKeyDownScript(int key)
        {
            return this.scriptManager.OnKeyDown(key);
        }
        public bool OnKeyUpScript(int key)
        {
            return this.scriptManager.OnKeyUp(key);
        }
        public void OnKeyUpEvent(int key)
        {
            this.eventManager.OnKeyUp(key);
        }
        private void SampleParticle(Float2Managed center)
        {
            int num = this.particleBuilder.NearestParticle(center);
            if (num >= 0)
            {
                this.eventManager.NextParticleInfo = this.Particles.GetInfo(num) & ~ParticleInfoManaged.Textured;
                this.eventManager.NextColor = this.Particles.GetColor(num);
            }
        }
        public void SelectAllParticles()
        {
            this.particleBuilder.SelectAllParticles();
        }
        public void UnselectAllParticles()
        {
            this.particleBuilder.UnselectAllParticles();
        }
        private IntPtr GetIntPtr(UnmanagedMemoryStream strm)
        {
            strm.Seek(0L, SeekOrigin.Begin);
            byte[] array = new byte[strm.Length];
            strm.Read(array, 0, array.Length);
            IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
            Marshal.Copy(array, 0, intPtr, array.Length);
            return intPtr;
        }
        public void LoadFlowSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetFlowSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadWaveSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetWaveSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadFireSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetFireSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadStoneSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetStoneSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadWoodSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetWoodSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadMeatSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetMeatSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void LoadExplodeSound(UnmanagedMemoryStream strm)
        {
            IntPtr intPtr = this.GetIntPtr(strm);
            this.soundManager.SetExplodeSound(intPtr, (int)strm.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void OnKeyDownEvent(int key)
        {
            if ((key >= 97 && key <= 122) || key == 64)
            {
                this.eventManager.OnAlphaKeyUp((AlphaKeyOperations)key, false);
                return;
            }
            if (key < 65 || key > 90)
            {
                if (key - 48 <= 9)
                {
                    this.eventManager.OnNumberKeyUp(key);
                    return;
                }
                if (key != 96)
                {
                    this.OnSpecialKeyDown((SpecialKeys)key);
                    return;
                }
            }
            this.eventManager.OnAlphaKeyUp((AlphaKeyOperations)(key ^ 32), true);
        }
        private void OnSpecialKeyDown(SpecialKeys key)
        {
            if (key <= SpecialKeys.GravityKey)
            {
                if (key <= SpecialKeys.EscKey)
                {
                    if (key == SpecialKeys.PressureKey)
                    {
                        EventManagerManaged eventManagerManaged = this.eventManager;
                        eventManagerManaged.RepulsionFlag = !eventManagerManaged.RepulsionFlag;
                        return;
                    }
                    if (key != SpecialKeys.EscKey)
                    {
                        return;
                    }
                    if (this.eventManager.LowerCaseKeyOperation == AlphaKeyOperations.MaterialAlphaKeyOperation)
                    {
                        this.eventManager.LowerCaseKeyOperation = AlphaKeyOperations.AttributeAlphaKeyOperation;
                        this.eventManager.NextMaterial = Materials.NoMaterial;
                    }
                    else if (this.eventManager.LowerCaseKeyOperation == AlphaKeyOperations.AttributeAlphaKeyOperation)
                    {
                        this.eventManager.LowerCaseKeyOperation = AlphaKeyOperations.MaterialAlphaKeyOperation;
                        this.eventManager.NextColor = ParticleDataCSharp.ColorForInfo(this.eventManager.NextParticleInfo, this.eventManager.ColorPalette);
                    }
                    if (this.eventManager.UpperCaseKeyOperation == AlphaKeyOperations.MaterialAlphaKeyOperation)
                    {
                        this.eventManager.UpperCaseKeyOperation = AlphaKeyOperations.AttributeAlphaKeyOperation;
                        this.eventManager.NextMaterial = Materials.NoMaterial;
                        return;
                    }
                    if (this.eventManager.UpperCaseKeyOperation == AlphaKeyOperations.AttributeAlphaKeyOperation)
                    {
                        this.eventManager.UpperCaseKeyOperation = AlphaKeyOperations.MaterialAlphaKeyOperation;
                        this.eventManager.NextColor = ParticleDataCSharp.ColorForInfo(this.eventManager.NextParticleInfo, this.eventManager.ColorPalette);
                        return;
                    }
                }
                else
                {
                    switch (key)
                    {
                        case SpecialKeys.BoundsKey:
                            {
                                EventManagerManaged eventManagerManaged2 = this.eventManager;
                                eventManagerManaged2.BoundsFlag = !eventManagerManaged2.BoundsFlag;
                                return;
                            }
                        case (SpecialKeys)45:
                            break;
                        case SpecialKeys.PouringKey:
                            if (!this.eventManager.PouringFlag || this.eventManager.PouringRainFlag)
                            {
                                this.eventManager.PouringFlag = true;
                                this.eventManager.PouringRainFlag = false;
                                return;
                            }
                            this.eventManager.PouringFlag = false;
                            return;
                        case SpecialKeys.RainKey:
                            if (!this.eventManager.PouringFlag || !this.eventManager.PouringRainFlag)
                            {
                                this.eventManager.PouringFlag = true;
                                this.eventManager.PouringRainFlag = true;
                                return;
                            }
                            this.eventManager.PouringFlag = false;
                            return;
                        default:
                            {
                                if (key == SpecialKeys.FreezeKey)
                                {
                                    this.particleBuilder.FreezeParticles();
                                    this.latticeBuilder.FreezeLattice();
                                    return;
                                }
                                if (key != SpecialKeys.GravityKey)
                                {
                                    return;
                                }
                                EventManagerManaged eventManagerManaged3 = this.eventManager;
                                eventManagerManaged3.GravityFlag = !eventManagerManaged3.GravityFlag;
                                return;
                            }
                    }
                }
            }
            else if (key <= SpecialKeys.GravityDecrementKey)
            {
                if (key == SpecialKeys.PauseKey)
                {
                    EventManagerManaged eventManagerManaged4 = this.eventManager;
                    eventManagerManaged4.PauseFlag = !eventManagerManaged4.PauseFlag;
                    return;
                }
                if (key != SpecialKeys.GravityDecrementKey)
                {
                    return;
                }
                this.eventManager.GravityAmplification -= 0.5f;
                return;
            }
            else
            {
                if (key == SpecialKeys.GravityIncrementKey)
                {
                    this.eventManager.GravityAmplification += 0.5f;
                    return;
                }
                if (key != SpecialKeys.DeleteKey)
                {
                    if (key - SpecialKeys.LeftKey > 3)
                    {
                        return;
                    }
                    this.OnArrowKeyDown(key);
                }
                else
                {
                    if (this.particleBuilder.CountParticles(ParticleInfoManaged.Selected) > 0)
                    {
                        this.particleBuilder.EraseParticles(ParticleInfoManaged.Selected);
                        return;
                    }
                    this.Clear();
                    return;
                }
            }
        }
        public void Clear()
        {
            this.config.Clear();
            this.modules.Clear();
            this.meshes.Clear();
            this.meshes.Dispose();
            this.meshes = new MeshDataManaged();
            this.meshBuilder.Dispose();
            this.meshBuilder = new MeshBuilderManaged(new ConfigurationManaged(), this.meshes, new ModuleDataManaged());
            this.lattice.Clear();
            this.effects.Clear();
            this.latticeBuilder.Dispose();
            this.latticeBuilder = new LatticeBuilderManaged(new ConfigurationManaged(), this.lattice);
            this.scriptManager = new ScriptManagerCSharp(this.Scene.ScriptManager);
            this.SceneRenderer = this.Scene.SceneRenderer;
            this.boxSimulator = this.Scene.BoxSimulator;
            this.ParticleSimulator = new ParticleSimulatorCSharp(this.Scene.ParticleSimulator);
            this.spriteSimulator = new SpriteSimulatorManaged(this.config, this.Scene.Sprites);
            this.fileManager.Clear();
            this.modules.Clear();
            this.Particles.Clear();
            this.effects.Clear();
            this.Scene.ClearBoxes();
            this.Sprites.Clear();
            this.Scene.Storage.Clear();
        }
        private void OnLoad()
        {
            this.scriptManager.SetScene(this);
            this.scriptManager.OnLoad(this);
        }
        private void OnArrowKeyDown(SpecialKeys key)
        {
            ArrowKeyOperations arrowKeyOperations = this.eventManager.ArrowKeyOperation;
            if (arrowKeyOperations == ArrowKeyOperations.AutomaticArrowKeyOperation)
            {
                this.Particles.UpdateExistingInfo();
                if (this.config.ScrollFlag)
                {
                    arrowKeyOperations = ArrowKeyOperations.ScrollArrowKeyOperation;
                }
                if (this.config.PouringFlag)
                {
                    arrowKeyOperations = ArrowKeyOperations.PouringArrowKeyOperation;
                }
                if ((this.Particles.ExistingInfo & ParticleInfoManaged.Users) == ParticleInfoManaged.Users)
                {
                    arrowKeyOperations = ArrowKeyOperations.UsersArrowKeyOperation;
                }
                if ((this.Particles.ExistingInfo & ParticleInfoManaged.Selected) == ParticleInfoManaged.Selected)
                {
                    arrowKeyOperations = ArrowKeyOperations.SelectionArrowKeyOperation;
                }
                if (this.Scene.IsBoxesUsersExist)
                {
                    arrowKeyOperations = ArrowKeyOperations.UsersArrowKeyOperation;
                }
            }
            switch (arrowKeyOperations)
            {
                case ArrowKeyOperations.PouringArrowKeyOperation:
                    switch (key)
                    {
                        case SpecialKeys.LeftKey:
                            this.config.PouringLocation -= 1f;
                            if (this.config.PouringLocation < this.config.BoundsLeft)
                            {
                                this.config.PouringLocation = this.config.BoundsLeft;
                                return;
                            }
                            break;
                        case SpecialKeys.DownKey:
                            this.config.PouringVelocity += 0.01f;
                            return;
                        case SpecialKeys.RightKey:
                            this.config.PouringLocation += 1f;
                            if (this.config.PouringLocation > this.config.BoundsRight)
                            {
                                this.config.PouringLocation = this.config.BoundsRight;
                                return;
                            }
                            break;
                        case SpecialKeys.UpKey:
                            this.config.PouringVelocity -= 0.01f;
                            if (this.config.PouringVelocity < 0f)
                            {
                                this.config.PouringVelocity = 0f;
                                return;
                            }
                            break;
                        default:
                            return;
                    }
                    break;
                case ArrowKeyOperations.UsersArrowKeyOperation:
                    switch (key)
                    {
                        case SpecialKeys.LeftKey:
                            this.config.UsersX = -1f;
                            return;
                        case SpecialKeys.DownKey:
                            this.config.UsersY = -1f;
                            return;
                        case SpecialKeys.RightKey:
                            this.config.UsersX = 1f;
                            return;
                        case SpecialKeys.UpKey:
                            this.config.UsersY = 1f;
                            return;
                        default:
                            return;
                    }
                    break;
                case ArrowKeyOperations.ScrollArrowKeyOperation:
                    switch (key)
                    {
                        case SpecialKeys.LeftKey:
                            this.particleBuilder.Scroll(-0.5f, 0f);
                            return;
                        case SpecialKeys.DownKey:
                            this.particleBuilder.Scroll(0f, -0.5f);
                            return;
                        case SpecialKeys.RightKey:
                            this.particleBuilder.Scroll(0.5f, 0f);
                            return;
                        case SpecialKeys.UpKey:
                            this.particleBuilder.Scroll(0f, 0.5f);
                            return;
                        default:
                            return;
                    }
                    break;
                case ArrowKeyOperations.SelectionArrowKeyOperation:
                    switch (key)
                    {
                        case SpecialKeys.LeftKey:
                            this.particleBuilder.MoveParticles(-0.5f, 0f, ParticleInfoManaged.Selected);
                            return;
                        case SpecialKeys.DownKey:
                            this.particleBuilder.MoveParticles(0f, -0.5f, ParticleInfoManaged.Selected);
                            break;
                        case SpecialKeys.RightKey:
                            this.particleBuilder.MoveParticles(0.5f, 0f, ParticleInfoManaged.Selected);
                            return;
                        case SpecialKeys.UpKey:
                            this.particleBuilder.MoveParticles(0f, 0.5f, ParticleInfoManaged.Selected);
                            return;
                        default:
                            return;
                    }
                    break;
                default:
                    return;
            }
        }
        public void OnMouseDown(MouseButtonManaged button, float x, float y)
        {
            this.eventManager.SetMouseParameters(button, x, y);
            this.Particles.UpdateExistingInfo();
            if (!this.config.EditorFlag && this.config.StartFlag && !this.eventManager.IsEditorTool(this.eventManager.CurrentMouseTool) && x >= this.config.StartLeft && x <= this.config.StartRight && y >= this.config.StartBottom && y <= this.config.StartTop)
            {
                this.eventManager.CurrentMouseTool = Tools.NoTool;
            }
            Float2Managed float2Managed = new Float2Managed(x, y);
            if ((this.Particles.ExistingInfo & ParticleInfoManaged.Selected) == ParticleInfoManaged.Selected)
            {
                this.OnMouseDownIfSelected(button, float2Managed);
            }
            if (this.config.HasShapeTexture)
            {
                this.OnMouseDownIfHasShapeTexture(float2Managed);
            }
            if (this.eventManager.IsDrawingTool(this.eventManager.CurrentMouseTool) && !this.config.IsMaterialEnabled(this.eventManager.NextMaterial))
            {
                this.eventManager.CurrentMouseTool = Tools.NoTool;
            }
            if (!this.config.IsToolEnabled(this.eventManager.CurrentMouseTool))
            {
                this.eventManager.CurrentMouseTool = Tools.NoTool;
            }
            this.OnMouseDownByCurrentTool(button, float2Managed);
            if (this.eventManager.CurrentMouseTool == Tools.BrushTool)
            {
                this.particleBuilder.DrawPencilDot(float2Managed);
                return;
            }
            if (this.eventManager.CurrentMouseTool == Tools.PencilTool)
            {
                this.particleBuilder.DrawPencilDot(float2Managed);
            }
        }
        public void OnMouseMove(float x, float y)
        {
            this.eventManager.CurrentMouseDragged = true;
            this.MouseUpIfEditorTool(x, y);
            Float2Managed float2Managed = new Float2Managed(x, y);
            Tools currentMouseTool = this.eventManager.CurrentMouseTool;
            if (currentMouseTool > Tools.DragShapeTool)
            {
                if (currentMouseTool != Tools.StartTool && currentMouseTool != Tools.GoalTool)
                {
                    switch (currentMouseTool)
                    {
                        case Tools.ArrowTool:
                        case Tools.ControlTool:
                            this.eventManager.CurrentMouseLastLocation = float2Managed;
                            return;
                        case Tools.BrushTool:
                            this.DrawByBrush(float2Managed);
                            return;
                        case Tools.CropTool:
                        case (Tools)100:
                        case (Tools)102:
                        case Tools.BucketTool:
                        case Tools.HandTool:
                        case Tools.LassoTool:
                        case Tools.SpongeTool:
                        case Tools.BlurTool:
                        case (Tools)116:
                        case Tools.MagicWandTool:
                            return;
                        case Tools.EraserTool:
                            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.EraseLine(this.eventManager.CurrentMouseLastLocation, float2Managed);
                            return;
                        case Tools.SamplerTool:
                            this.SampleParticle(float2Managed);
                            return;
                        case Tools.MaterialTool:
                            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.MaterialLine(this.eventManager.CurrentMouseLastLocation, float2Managed);
                            return;
                        case Tools.SliceTool:
                            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.SliceLine(this.eventManager.CurrentMouseLastLocation, float2Managed);
                            return;
                        case Tools.MarqueeTool:
                            break;
                        case Tools.LinkTool:
                            this.config.ShapeEnd = this.SnapToParticle(float2Managed);
                            return;
                        case Tools.PencilTool:
                            this.DrawByPencil(float2Managed);
                            return;
                        case Tools.ColorTool:
                            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.ColorLine(this.eventManager.CurrentMouseLastLocation, float2Managed, this.eventManager.NextColor);
                            return;
                        case Tools.ShapeTool:
                            this.config.ShapeEnd = this.eventManager.SnapToGrid(float2Managed);
                            return;
                        case Tools.MoveTool:
                            this.particleBuilder.DragAllParticles(float2Managed - this.eventManager.CurrentMouseLastLocation);
                            this.eventManager.CurrentMouseLastLocation = float2Managed;
                            return;
                        case Tools.AxisTool:
                            this.particleBuilder.AxisOfSelectedBody = float2Managed;
                            return;
                        case Tools.MarkerTool:
                            this.DrawByMarker(float2Managed);
                            return;
                        default:
                            return;
                    }
                }
                this.config.ShapeEnd = float2Managed;
                return;
            }
            if (currentMouseTool == Tools.DragAndDropTool)
            {
                if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.ControlModifiedButton) == MouseButtonManaged.ControlModifiedButton)
                {
                    this.particleBuilder.RotateParticles(this.eventManager.CurrentMouseLastLocation, float2Managed, 536870912);
                }
                else
                {
                    this.particleBuilder.MoveParticles(float2Managed - this.eventManager.CurrentMouseLastLocation, 536870912);
                }
                this.eventManager.CurrentMouseLastLocation = float2Managed;
                return;
            }
            if (currentMouseTool != Tools.DragShapeTool)
            {
                return;
            }
            if ((this.eventManager.CurrentMouseInfo & 1) == 1)
            {
                this.config.ShapeStartX += float2Managed.X - this.eventManager.CurrentMouseLastLocation.X;
            }
            if ((this.eventManager.CurrentMouseInfo & 2) == 2)
            {
                this.config.ShapeEndX += float2Managed.X - this.eventManager.CurrentMouseLastLocation.X;
            }
            if ((this.eventManager.CurrentMouseInfo & 4) == 4)
            {
                this.config.ShapeStartY += float2Managed.Y - this.eventManager.CurrentMouseLastLocation.Y;
            }
            if ((this.eventManager.CurrentMouseInfo & 8) == 8)
            {
                this.config.ShapeEndY += float2Managed.Y - this.eventManager.CurrentMouseLastLocation.Y;
            }
            if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.ShiftModifiedButton) == MouseButtonManaged.ShiftModifiedButton && this.config.HasShapeTexture)
            {
                float num = this.config.ShapeEndX - this.config.ShapeStartX;
                float num2 = this.config.ShapeEndY - this.config.ShapeStartY;
                float num3 = num / (float)this.config.ShapeTextureWidth;
                float num4 = num2 / (float)this.config.ShapeTextureHeight;
                float num5 = num * (num4 / num3 - 1f) / 2f;
                float num6 = num2 * (num3 / num4 - 1f) / 2f;
                if (this.eventManager.CurrentMouseInfo == 1 || this.eventManager.CurrentMouseInfo == 2)
                {
                    this.config.ShapeStartY -= num6;
                    this.config.ShapeEndY += num6;
                }
                else if (this.eventManager.CurrentMouseInfo == 4 || this.eventManager.CurrentMouseInfo == 8)
                {
                    this.config.ShapeStartX -= num5;
                    this.config.ShapeEndX += num5;
                }
                else
                {
                    if ((this.eventManager.CurrentMouseInfo & 1) == 1)
                    {
                        this.config.ShapeStartX -= num5;
                    }
                    else if ((this.eventManager.CurrentMouseInfo & 2) == 2)
                    {
                        this.config.ShapeEndX += num5;
                    }
                    if ((this.eventManager.CurrentMouseInfo & 4) == 4)
                    {
                        this.config.ShapeStartY -= num6;
                    }
                    else if ((this.eventManager.CurrentMouseInfo & 8) == 8)
                    {
                        this.config.ShapeEndY += num6;
                    }
                }
            }
            this.eventManager.CurrentMouseLastLocation = float2Managed;
        }
        public void OnMouseUp()
        {
            Tools currentMouseTool = this.eventManager.CurrentMouseTool;
            if (currentMouseTool <= Tools.StartTool)
            {
                if (currentMouseTool != Tools.DragShapeTool)
                {
                    if (currentMouseTool == Tools.StartTool)
                    {
                        this.config.StartFlag = !(this.config.ShapeStart == this.config.ShapeEnd);
                        this.config.StartLeft = Math.Min(this.config.ShapeStart.X, this.config.ShapeEnd.X);
                        this.config.StartBottom = Math.Min(this.config.ShapeStart.Y, this.config.ShapeEnd.Y);
                        this.config.StartRight = Math.Max(this.config.ShapeStart.X, this.config.ShapeEnd.X);
                        this.config.StartTop = Math.Max(this.config.ShapeStart.Y, this.config.ShapeEnd.Y);
                        this.config.CurrentShape = GeometricShapes.NoShape;
                    }
                }
                else if (!this.eventManager.CurrentMouseDragged)
                {
                    if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.ControlModifiedButton) == MouseButtonManaged.ControlModifiedButton)
                    {
                        this.meshBuilder.FillTexture(this.config.ShapeTexture, this.config.ShapeStart, this.config.ShapeEnd, this.eventManager.NextMeshInfo);
                    }
                    else
                    {
                        this.particleBuilder.FillTexture(this.config.ShapeTexture, this.config.ShapeStart, this.config.ShapeEnd, this.eventManager.NextParticleInfo);
                    }
                    this.config.CurrentShape = GeometricShapes.NoShape;
                    this.config.ResetShapeTexture();
                }
            }
            else if (currentMouseTool != Tools.GoalTool)
            {
                switch (currentMouseTool)
                {
                    case Tools.MarqueeTool:
                        if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.AlternateModifiedButton) == MouseButtonManaged.AlternateModifiedButton)
                        {
                            if (!this.particleBuilder.UnselectRect(this.config.ShapeStart, this.config.ShapeEnd))
                            {
                                this.particleBuilder.UnselectBody(this.config.ShapeEnd);
                            }
                        }
                        else if (!this.particleBuilder.SelectRect(this.config.ShapeStart, this.config.ShapeEnd))
                        {
                            this.particleBuilder.SelectBody(this.config.ShapeEnd);
                        }
                        this.config.CurrentShape = GeometricShapes.NoShape;
                        break;
                    case Tools.LinkTool:
                        this.particleBuilder.LinkLine(this.config.ShapeStart, this.config.ShapeEnd, this.eventManager.NextColor);
                        this.config.CurrentShape = GeometricShapes.NoShape;
                        break;
                    case Tools.PencilTool:
                        this.Particles.Gc();
                        break;
                    case Tools.ControlTool:
                        this.config.UsersX = 0f;
                        this.config.UsersY = 0f;
                        break;
                    case Tools.ShapeTool:
                        {
                            GeometricShapes currentShape = this.config.CurrentShape;
                            if (currentShape != GeometricShapes.CircleShape)
                            {
                                switch (currentShape)
                                {
                                    case GeometricShapes.HeartShape:
                                        this.particleBuilder.FillShapeHeart(this.config.ShapeStart, Float2Managed.Distance(this.config.ShapeStart, this.config.ShapeEnd), this.config.ShapeEnd - this.config.ShapeStart, this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                    case GeometricShapes.LineShape:
                                        this.particleBuilder.PrepareForDrawing(this.config.ShapeStart, this.eventManager, MouseButtonManaged.NoButton);
                                        this.particleBuilder.DrawPencilLine(this.config.ShapeStart, this.config.ShapeEnd);
                                        this.Particles.Gc();
                                        break;
                                    case GeometricShapes.OvalShape:
                                        this.particleBuilder.FillShapeOval(0.5f * (this.config.ShapeStart + this.config.ShapeEnd), 0.5f * (this.config.ShapeEnd - this.config.ShapeStart), this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                    case GeometricShapes.SquareShape:
                                        this.particleBuilder.FillShapeSquare(this.config.ShapeStart, Float2Managed.Distance(this.config.ShapeStart, this.config.ShapeEnd), this.config.ShapeEnd - this.config.ShapeStart, this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                    case GeometricShapes.RectangleShape:
                                        this.particleBuilder.FillShapeRectangle(new Float2Managed(Math.Min(this.config.ShapeStart.X, this.config.ShapeEnd.X), Math.Min(this.config.ShapeStart.Y, this.config.ShapeEnd.Y)), new Float2Managed(Math.Max(this.config.ShapeStart.X, this.config.ShapeEnd.X), Math.Max(this.config.ShapeStart.Y, this.config.ShapeEnd.Y)), this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                    case GeometricShapes.StarShape:
                                        this.particleBuilder.FillShapeStar(this.config.ShapeStart, Float2Managed.Distance(this.config.ShapeStart, this.config.ShapeEnd), this.config.ShapeEnd - this.config.ShapeStart, this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                    case GeometricShapes.TriangleShape:
                                        this.particleBuilder.FillShapeTriangle(this.config.ShapeEnd, this.config.ShapeStart + new Matrix22(-0.5f, -0.866f, 0.866f, -0.5f) * (this.config.ShapeEnd - this.config.ShapeStart), this.config.ShapeStart + new Matrix22(-0.5f, 0.866f, -0.866f, -0.5f) * (this.config.ShapeEnd - this.config.ShapeStart), this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                                        break;
                                }
                            }
                            else
                            {
                                this.particleBuilder.FillShapeCircle(this.config.ShapeStart, Float2Managed.Distance(this.config.ShapeStart, this.config.ShapeEnd), this.eventManager.NextParticleInfo, this.eventManager.NextColor);
                            }
                            this.config.CurrentShape = GeometricShapes.NoShape;
                            break;
                        }
                }
            }
            else
            {
                this.config.GoalFlag = !(this.config.ShapeStart == this.config.ShapeEnd);
                this.config.GoalLeft = Math.Min(this.config.ShapeStart.X, this.config.ShapeEnd.X);
                this.config.GoalBottom = Math.Min(this.config.ShapeStart.Y, this.config.ShapeEnd.Y);
                this.config.GoalRight = Math.Max(this.config.ShapeStart.X, this.config.ShapeEnd.X);
                this.config.GoalTop = Math.Max(this.config.ShapeStart.Y, this.config.ShapeEnd.Y);
                this.config.CurrentShape = GeometricShapes.NoShape;
            }
            this.eventManager.CurrentMouseTool = Tools.NoTool;
            this.eventManager.CurrentMouseButton = MouseButtonManaged.NoButton;
            this.eventManager.EraseCurrentMouse();
        }
        private Float2Managed SnapToParticle(Float2Managed center)
        {
            int num = this.particleBuilder.NearestParticle(center);
            if (num >= 0)
            {
                return this.Particles.GetCenter(num);
            }
            return center;
        }
        private void DrawByPencil(Float2Managed mouseLocation)
        {
            if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.ControlModifiedButton) == MouseButtonManaged.ControlModifiedButton)
            {
                this.eventManager.CurrentMouseLastLocation = this.particleBuilder.DrawMarkerLine(this.eventManager.CurrentMouseLastLocation, mouseLocation);
                return;
            }
            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.DrawPencilLine(this.eventManager.CurrentMouseLastLocation, mouseLocation);
        }
        private void DrawByBrush(Float2Managed mouseLocation)
        {
            if ((this.eventManager.CurrentMouseButton & MouseButtonManaged.ControlModifiedButton) == MouseButtonManaged.ControlModifiedButton)
            {
                this.eventManager.CurrentMouseLastLocation = this.particleBuilder.DrawMarkerLine(this.eventManager.CurrentMouseLastLocation, mouseLocation);
                return;
            }
            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.DrawBrushLine(this.eventManager.CurrentMouseLastLocation, mouseLocation);
        }
        private void DrawByMarker(Float2Managed mouseLocation)
        {
            this.eventManager.CurrentMouseLastLocation = this.particleBuilder.DrawMarkerLine(this.eventManager.CurrentMouseLastLocation, mouseLocation);
        }
        private void MouseUpIfEditorTool(float x, float y)
        {
            if (!this.config.EditorFlag && this.config.StartFlag && !this.eventManager.IsEditorTool(this.eventManager.CurrentMouseTool) && x >= this.config.StartLeft && x <= this.config.StartRight && y >= this.config.StartBottom && y <= this.config.StartTop)
            {
                this.OnMouseUp();
            }
        }
        private void OnMouseDownByCurrentTool(MouseButtonManaged button, Float2Managed mouseLocation)
        {
            Tools currentMouseTool = this.eventManager.CurrentMouseTool;
            if (currentMouseTool > Tools.ArrowTool)
            {
                if (currentMouseTool != Tools.BrushTool)
                {
                    switch (currentMouseTool)
                    {
                        case Tools.BucketTool:
                            this.particleBuilder.FillRegion(mouseLocation, this.eventManager);
                            return;
                        case Tools.HandTool:
                        case Tools.SliceTool:
                        case Tools.LassoTool:
                        case Tools.SpongeTool:
                            break;
                        case Tools.SamplerTool:
                            this.SampleParticle(mouseLocation);
                            if (this.OnSampleParticle != null)
                            {
                                this.OnSampleParticle(this, EventArgs.Empty);
                                return;
                            }
                            break;
                        case Tools.MaterialTool:
                        case Tools.PencilTool:
                            goto IL_007E;
                        case Tools.MarqueeTool:
                            goto IL_011D;
                        case Tools.LinkTool:
                            this.config.CurrentShape = GeometricShapes.LineShape;
                            this.config.ShapeStart = this.SnapToParticle(mouseLocation);
                            this.config.ShapeEnd = this.SnapToParticle(mouseLocation);
                            break;
                        default:
                            switch (currentMouseTool)
                            {
                                case Tools.ShapeTool:
                                    this.config.CurrentShape = this.config.TemplateShape;
                                    this.config.ShapeStart = this.eventManager.SnapToGrid(mouseLocation);
                                    this.config.ShapeEnd = this.eventManager.SnapToGrid(mouseLocation);
                                    return;
                                case Tools.MoveTool:
                                case Tools.MagicWandTool:
                                    break;
                                case Tools.AxisTool:
                                    if (this.Particles.SelectedBody == this.particleBuilder.NearestBody(mouseLocation))
                                    {
                                        this.particleBuilder.AxisOfSelectedBody = mouseLocation;
                                        return;
                                    }
                                    this.particleBuilder.UnselectAllParticles();
                                    this.particleBuilder.SelectBody(mouseLocation);
                                    this.eventManager.CurrentMouseTool = Tools.NoTool;
                                    return;
                                case Tools.MarkerTool:
                                    goto IL_007E;
                                default:
                                    return;
                            }
                            break;
                    }
                    return;
                }
            IL_007E:
                this.particleBuilder.PrepareForDrawing(mouseLocation, this.eventManager, button & MouseButtonManaged.ShiftModifiedButton);
                return;
            }
            if (currentMouseTool != Tools.StartTool && currentMouseTool != Tools.GoalTool)
            {
                if (currentMouseTool != Tools.ArrowTool)
                {
                    return;
                }
                this.particleBuilder.SplitNearestTexturedBody(mouseLocation);
                return;
            }
        IL_011D:
            this.config.CurrentShape = GeometricShapes.RectangleShape;
            this.config.ShapeStart = mouseLocation;
            this.config.ShapeEnd = mouseLocation;
        }
        private void OnMouseDownIfHasShapeTexture(Float2Managed mouseLocation)
        {
            float num = this.config.ShapeStart.X - mouseLocation.X;
            float num2 = mouseLocation.X - this.config.ShapeEnd.X;
            float num3 = this.config.ShapeStart.Y - mouseLocation.Y;
            float num4 = mouseLocation.Y - this.config.ShapeEnd.Y;
            if (num < 1f && num2 < 1f && num3 < 1f && num4 < 1f)
            {
                this.eventManager.CurrentMouseTool = Tools.DragShapeTool;
                this.eventManager.CurrentMouseInfo = ((num < -1f && num2 < -1f && num3 < -1f && num4 < -1f) ? 15 : (((num > -1f) ? 1 : 0) | (((num2 > -1f) ? 1 : 0) * 2) | (((num3 > -1f) ? 1 : 0) * 4) | (((num4 > -1f) ? 1 : 0) * 8)));
                return;
            }
            this.eventManager.CurrentMouseTool = Tools.NoTool;
        }
        private void OnMouseDownIfSelected(MouseButtonManaged button, Float2Managed mouseLocation)
        {
            bool flag = false;
            for (int i = 0; i < this.Particles.Count; i++)
            {
                if ((this.Particles.GetInfo(i) & ParticleInfoManaged.Selected) == ParticleInfoManaged.Selected && Float2Managed.Distance(this.Particles.GetCenter(i), mouseLocation) < this.config.MouseRadius)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Tools currentMouseTool = this.eventManager.CurrentMouseTool;
                if (currentMouseTool != Tools.MarqueeTool)
                {
                    if (currentMouseTool == Tools.AxisTool)
                    {
                        return;
                    }
                }
                else if ((button & MouseButtonManaged.AlternateModifiedButton) == MouseButtonManaged.AlternateModifiedButton)
                {
                    return;
                }
                this.eventManager.CurrentMouseTool = Tools.DragAndDropTool;
                return;
            }
            Tools currentMouseTool2 = this.eventManager.CurrentMouseTool;
            if (currentMouseTool2 != Tools.MarqueeTool)
            {
                if (currentMouseTool2 == Tools.MoveTool)
                {
                    return;
                }
            }
            else if ((button & (MouseButtonManaged)20) != MouseButtonManaged.NoButton)
            {
                return;
            }
            this.particleBuilder.UnselectAllParticles();
        }
        public ModuleManaged Import(float x, float y, string path)
        {
            return this.fileManager.ImportTest(this.Scene, x, y, true, path);
        }
        public ModuleManaged Import(float x, float y, string path, string ap_id)
        {
            return this.fileManager.ImportTest(this.Scene, x, y, true, path, ap_id);
        }
        public void RegisterUndo()
        {
            this.undoManager.RegisterUndo(this.Scene);
        }
        public void Undo()
        {
            this.undoManager.Undo(this.Scene);
        }
        public void CopyAll()
        {
            this.undoManager.CopyAll(this.Scene);
        }
        public void CopySelection()
        {
            this.undoManager.CopySelection(this.Scene);
        }
        public void Paste()
        {
            this.particleBuilder.UnselectAllParticles();
            this.undoManager.Paste(this.Scene);
        }
        public int GetUndoCount()
        {
            return this.undoManager.GetUndoCount();
        }
        public int GetRedoCount()
        {
            return this.undoManager.GetRedoCount();
        }
        public bool IsCopyExist()
        {
            return this.undoManager.IsCopyExist();
        }
        public void Redo()
        {
            this.undoManager.Redo(this.Scene);
        }
        public ModuleDataManaged GetModules()
        {
            return this.modules;
        }
        public void ClearAll()
        {
            this.Clear();
            this.config.Clear();
            this.undoManager.Clear();
            this.scriptManager.Clear();
            this.undoManager.Clear();
            this.Scene.Renderer.Clear();
        }
        public void ClearAllButConfig()
        {
            this.Clear();
            this.undoManager.Clear();
            this.scriptManager.Clear();
            this.undoManager.Clear();
            this.Scene.Renderer.Clear();
        }
        public bool HasModule(List<string> list)
        {
            foreach (ModuleManaged moduleManaged in this.Scene.Modules.ModuleList)
            {
                string ap_ID = moduleManaged.AP_ID;
                if (!string.IsNullOrEmpty(ap_ID) && !list.Contains(moduleManaged.AP_ID))
                {
                    return false;
                }
            }
            return true;
        }
        public void InitOpenGL(uint p)
        {
            this.Scene.InitOpenGL(p);
        }
        public void BeginDraw(float scale, float boundsLeft, float boundsBottom)
        {
            this.Scene.BeginDraw(scale, boundsLeft, boundsBottom);
        }
        public void Render()
        {
            this.Scene.Render();
        }
        public void QuitOpenGL()
        {
            this.Scene.QuitOpenGL();
        }
        public float GetScale(int panelWidth, int panelHeight)
        {
            if (this.OriginalHeight > 480f)
            {
                return this.config.Scale * (float)panelHeight / this.OriginalHeight;
            }
            if (this.OriginalWidth > 640f)
            {
                return this.config.Scale * (float)panelWidth / this.OriginalWidth;
            }
            return this.config.Scale;
        }
        public void DrawWithoutSwap()
        {
            this.BeginDraw(this.config.Scale, 0f - this.config.BoundsLeft, 0f - this.config.BoundsBottom);
            this.Render();
            foreach (DrawReqSt drawReqSt in this.DrawRequest)
            {
                this.Scene.DrawTexture(drawReqSt.TextureName, drawReqSt.MinX, drawReqSt.MinY, drawReqSt.MaxX, drawReqSt.MaxY, drawReqSt.Alpha);
            }
        }
        public void RenderPanel(int panelWidth, int panelHeight)
        {
            float scale = this.GetScale(panelWidth, panelHeight);
            this.BeginDraw(scale, 0f - this.config.BoundsLeft, 0f - this.config.BoundsBottom);
            this.Render();
            foreach (DrawReqSt drawReqSt in this.DrawRequest)
            {
                this.Scene.DrawTexture(drawReqSt.TextureName, drawReqSt.MinX, drawReqSt.MinY, drawReqSt.MaxX, drawReqSt.MaxY, drawReqSt.Alpha);
            }
            this.DrawRequest.Clear();
            this.Scene.Renderer.EndDraw();
        }
        public void Record(int width, int height)
        {
            this.SceneRenderer.AddFrame(width, height);
            if (this.SceneRenderer.IsTimeOver())
            {
                this.SceneRenderer.StopRecording();
                this.IsRecording = false;
                this.config.Scale = 8f;
                if (this.OnRecordTimeOver != null)
                {
                    this.OnRecordTimeOver(this, EventArgs.Empty);
                }
            }
        }
        public void Update(int panelWidth, int panelHeight)
        {
            if (this.config.SoundFlag && this.IsSimulating)
            {
                this.soundManager.Play();
            }
            else
            {
                this.soundManager.Stop();
            }
            if (this.IsSimulating)
            {
                for (int i = 0; i < this.TimeStepsPerFrame; i++)
                {
                    this.Simulate();
                    if (this.Store)
                    {
                        this.RegisterUndo();
                    }
                }
                if (this.IsRecording)
                {
                    float scale = this.config.Scale;
                    this.config.Scale = 4f / (this.OriginalHeight * (8f / scale) * 0.5f / (float)this.RecordingHeight);
                    this.DrawWithoutSwap();
                    this.Record(this.RecordingWidth, this.RecordingHeight);
                    this.config.Scale = scale;
                }
            }
            if (!this.Scene.EventManager.ShouldPause)
            {
                this.Scene.ScriptManager.SetScene(this.Scene);
                this.Scene.ScriptManager.OnRender();
            }
            ConfigurationManaged configurationManaged = this.Scene.Config;
            int frame = configurationManaged.Frame;
            configurationManaged.Frame = frame + 1;
        }
        private ConfigurationManaged config;
        private ModuleDataManaged modules;
        public MeshDataManaged meshes;
        private LatticeDataManaged lattice;
        private EffectDataManaged effects;
        public ParticleBuilderCSharp particleBuilder;
        private LatticeBuilderManaged latticeBuilder;
        public MeshBuilderManaged meshBuilder;
        private ModuleSimulatorManaged moduleSimulator;
        private BoxSimulatorManaged boxSimulator;
        public MeshSimulatorManaged meshSimulator;
        public LatticeSimulatorManaged gridSimulator;
        public EffectSimulatorManaged effectSimulator;
        private SpriteSimulatorManaged spriteSimulator;
        private ScriptManagerCSharp scriptManager;
        private EventManagerManaged eventManager;
        public SoundManagerCSharp soundManager;
        private UndoManagerCSharp undoManager = new UndoManagerCSharp();
        public float OriginalWidth = 640f;
        public float OriginalHeight = 480f;
        public int RecordingWidth = 320;
        public int RecordingHeight = 240;
        public List<DrawReqSt> DrawRequest = new List<DrawReqSt>();
        private enum Masks
        {
            LeftMask = 1,
            RightMask,
            BottomMask = 4,
            TopMask = 8
        }
    }
}
