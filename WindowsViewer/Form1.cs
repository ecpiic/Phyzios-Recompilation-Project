using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Win32;
using oec;
using OECasualCSharp;
namespace WindowsViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.SceneTitle = "Untitled";
            this.SceneDescription = "";
            this.PublishFlag = false;
            this.EnableTag = true;
            this.ToolLimit = true;
            this.OldState = base.WindowState;
        }
        public PanelController GetPanelController()
        {
            return this.panelController;
        }
        public OECPanel GetOECPanel()
        {
            return this.panelController.panelOECMain;
        }
        public void SetTool(Tools tool)
        {
            this.panelController.Scene.LeftButtonTool = tool;
        }
        public void SetMaterial(Materials mate, string name)
        {
            this.panelController.NextMaterial = mate;
            if (this.ToolWindow != null && !this.ToolWindow.IsDisposed)
            {
                this.ToolWindow.SetColor(this.FromMColor(this.panelController.NextColor));
                this.ToolWindow.SetMaterialName(name);
            }
        }
        public void SetParticleInfo(ParticleInfoManaged info)
        {
            this.panelController.NextParticleInfo = info;
        }
        public void SetColor(global::System.Drawing.Color col)
        {
            this.panelController.NextColor = Form1.ToMColor(col);
        }
        public void NewScene()
        {
            this.SetSceneTitle("Untitled");
            this.SceneDescription = "";
            this.SceneTags = "";
            this.SceneID = string.Empty;
            this.SceneUserID = string.Empty;
            this.SceneParentID = string.Empty;
            this.SceneAPGID = string.Empty;
            this.PublishFlag = false;
            this.UseScript = false;
            this.EnableTag = true;
            this.LastLoadData = null;
            this.panelController.Scene.ClearAll();
            this.panelController.Config.SoundFlag = false;
            this.SetFormSize();
            this.UpdatePropertyWindow();
            this.panelController.OldUndoCount = this.panelController.Scene.GetUndoCount();
            this.panelController.IsModified = false;
            this.panelController.SetPath("SysTmpGameData.oecd/");
        }
        public void SetUseScript()
        {
            this.UseScript = true;
        }
        public void SetSceneTitle(string title)
        {
            this.SceneTitle = title;
            this.Text = title;
        }
        private global::System.Drawing.Color FromMColor(global::System.Windows.Media.Color col)
        {
            return global::System.Drawing.Color.FromArgb((int)col.A, (int)col.R, (int)col.G, (int)col.B);
        }
        public static global::System.Windows.Media.Color ToMColor(global::System.Drawing.Color col)
        {
            return global::System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaterialNameList = new MaterialNames();
            this.MaterialNameList.Add(Materials.Aqua, "Water");
            this.MaterialNameList.Add(Materials.Wall, "Wall");
            this.MaterialNameList.Add(Materials.Rigid, "Solid");
            this.MaterialNameList.Add(Materials.Elastic, "Elastic");
            this.MaterialNameList.Add(Materials.String, "String");
            this.MaterialNameList.Add(Materials.Mochi, "Rice Cake");
            this.MaterialNameList.Add(Materials.Fire, "Fire");
            this.MaterialNameList.Add(Materials.Powder, "Powder");
            this.MaterialNameList.Add(Materials.Fuel, "Wood");
            this.MaterialNameList.Add(Materials.Tensile, "Surface Tension");
            this.MaterialNameList.Add(Materials.Viscous, "Viscous");
            this.MaterialNameList.Add(Materials.Kome, "Rice");
            this.MaterialNameList.Add(Materials.Gas, "Steam");
            this.MaterialNameList.Add(Materials.Hot, "Hot Wall");
            this.MaterialNameList.Add(Materials.Cold, "Cold Wall");
            this.MaterialNameList.Add(Materials.Inflow, "Faucet");
            this.MaterialNameList.Add(Materials.Outflow, "Outflow");
            this.MaterialNameList.Add(Materials.Axis, "Fulcrum");
            this.MaterialNameList.Add(Materials.Light, "Oil");
            this.MaterialNameList.Add(Materials.Users, "Character");
            this.MaterialNameList.Add(Materials.Brittle, "Brittle");
            this.panelController = new PanelController();
            this.panelController.ResizePanel(0, 0);
            this.panelController.SetTimerEnable(true);
            this.panelController.Config.PauseFlag = true;
            this.panelController.SetMouseEnable(true);
            this.panelController.IsSimulating = true;
            this.panelController.Config.ScrollFlag = false;
            this.panelController.Config.SoundFlag = false;
            this.panelController.panelOECMain.PreviewKeyDown += this.Panel_PreviewKeyDown;
            this.panelController.panelOECMain.KeyUp += this.Panel_KeyUp;
            this.panelController.Scene.LevelsOfUndo = 20;
            this.panelController.OnAfterMouseUp += this.panelOEC_OnAfterMouseUp;
            this.panelController.panelOECMain.Margin = new Padding(0);
            this.panel1.Controls.Add(this.panelController.panelOECMain);
            this.panelController.NextMaterial = Materials.Wall;
            this.panelController.Scene.LeftButtonTool = Tools.PencilTool;
            this.NewScene();
            this.ToolWindow = new ToolForm(this, this.panelController.Scene.LeftButtonTool);
            this.ToolWindow.SetColor(this.FromMColor(this.panelController.NextColor));
            this.ToolWindow.SetMaterialName(this.MaterialNameList.GetName(this.panelController.NextMaterial));
            this.ToolWindow.Show();
            this.ToolWindow.SetDesktopLocation(1020, 80);
            this.MaterialWindow = new MaterialForm(this, this.panelController.NextMaterial, this.panelController.NextParticleInfo);
            this.MaterialWindow.Show();
            this.MaterialWindow.SetDesktopLocation(20, 80);
            base.SetDesktopLocation(350, 80);
            this.panelController.Config.PauseFlag = true;
            this.pausedToolStripMenuItem.Checked = true;
        }
        private void SetToolAndMaterial()
        {
            Materials materials = (Materials)ParticleDataManaged.MaterialForInfo(this.panelController.NextParticleInfo);
            if (this.MaterialWindow != null && !this.MaterialWindow.IsDisposed)
            {
                this.MaterialWindow.SetButtons(materials, this.panelController.NextParticleInfo);
            }
            if (this.ToolWindow != null && !this.ToolWindow.IsDisposed)
            {
                this.ToolWindow.SetButtonColor(this.FromMColor(this.panelController.NextColor));
                string text = "";
                if (materials != Materials.Fire)
                {
                    switch (materials)
                    {
                        case Materials.Brittle:
                            text = "Brittle";
                            break;
                        case Materials.Cold:
                            text = "Cold Wall";
                            break;
                        case Materials.Elastic:
                            text = "Elastic";
                            break;
                        case Materials.Fuel:
                            text = "Wood";
                            break;
                        case Materials.Gas:
                            text = "Steam";
                            break;
                        case Materials.Hot:
                            text = "Hot Wall";
                            break;
                        case Materials.Inflow:
                            text = "Faucet";
                            break;
                        case Materials.Kome:
                            text = "Rice";
                            break;
                        case Materials.Light:
                            text = "Oil";
                            break;
                        case Materials.Mochi:
                            text = "Rice Cake";
                            break;
                        case Materials.Outflow:
                            text = "Outflow";
                            break;
                        case Materials.Powder:
                            text = "Powder";
                            break;
                        case Materials.Aqua:
                            text = "Water";
                            break;
                        case Materials.Rigid:
                            text = "Solid";
                            break;
                        case Materials.String:
                            text = "String";
                            break;
                        case Materials.Tensile:
                            text = "Surface Tension";
                            break;
                        case Materials.Users:
                            text = "Character";
                            break;
                        case Materials.Viscous:
                            text = "Viscous";
                            break;
                        case Materials.Wall:
                            text = "Wall";
                            break;
                        case Materials.Axis:
                            text = "Fulcrum";
                            break;
                        case Materials.Yuki:
                            text = "Yuki";
                            break;
                    }
                }
                else
                {
                    text = "Fire";
                }
                this.ToolWindow.SetMaterialName(text);
            }
        }
        private void panelOEC_OnAfterMouseUp()
        {
            if (this.panelController.LeftButtonTool == Tools.SamplerTool)
            {
                this.SetToolAndMaterial();
            }
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
                if (this.panelController.LeftButtonTool == Tools.MarqueeTool)
                {
                    this.BrowserWindow.SelectNodeWithBodyID(this.GetMinSelectedBodyID());
                }
            }
        }
        public int GetMinSelectedBodyID()
        {
            ParticleDataManaged data = this.panelController.Scene.Particles.Data;
            for (int i = 0; i < data.Count; i++)
            {
                if ((data.GetInfo(i) & ParticleInfoManaged.Selected) == ParticleInfoManaged.Selected)
                {
                    return data.get_BodyID(i);
                }
            }
            return 0;
        }
        private void Panel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyEventArgs keyEventArgs = new KeyEventArgs(e.KeyData);
            this.panelController.KeyDownEvent(keyEventArgs);
        }
        private void Panel_KeyUp(object sender, KeyEventArgs e)
        {
            this.panelController.KeyUpEvent(e);
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string[] array2 = array;
                foreach (string text in array2)
                {
                    this.panelController.LoadLocalData(text);
                    this.panelController.panelOECMain.Focus();
                }
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
                return;
            }
            e.Effect = DragDropEffects.None;
        }
        private void UpdatePropertyWindow()
        {
            if (this.PropertyWindow != null && !this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow.UpdateParam();
            }
        }
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ToolWindow == null || this.ToolWindow.IsDisposed)
            {
                this.ToolWindow = new ToolForm(this, this.panelController.LeftButtonTool);
                this.ToolWindow.SetColor(this.FromMColor(this.panelController.NextColor));
                this.ToolWindow.SetMaterialName(this.MaterialNameList.GetName(this.panelController.NextMaterial));
                this.ToolWindow.Show();
                this.ToolWindow.Activate();
                return;
            }
            this.ToolWindow.Close();
            this.ToolWindow = null;
        }
        public void OpenMaterialWindow()
        {
            if (this.MaterialWindow == null || this.MaterialWindow.IsDisposed)
            {
                this.MaterialWindow = new MaterialForm(this, this.panelController.NextMaterial, this.panelController.NextParticleInfo);
                this.MaterialWindow.Show();
                this.MaterialWindow.Activate();
                return;
            }
            this.MaterialWindow.Close();
            this.MaterialWindow = null;
        }
        private void materialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MaterialWindow == null || this.MaterialWindow.IsDisposed)
            {
                this.MaterialWindow = new MaterialForm(this, this.panelController.NextMaterial, this.panelController.NextParticleInfo);
                this.MaterialWindow.Show();
                this.MaterialWindow.Activate();
                return;
            }
            this.MaterialWindow.Close();
            this.MaterialWindow = null;
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = this.FromMColor(this.panelController.NextColor);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.SetColor(colorDialog.Color);
                if (this.ToolWindow != null && !this.ToolWindow.IsDisposed)
                {
                    this.ToolWindow.SetButtonColor(colorDialog.Color);
                }
            }
        }
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TimeWindow == null || this.TimeWindow.IsDisposed)
            {
                this.TimeWindow = new TimeForm(this);
                this.TimeWindow.UpdateParam();
                this.TimeWindow.Show();
                this.TimeWindow.Activate();
                return;
            }
            this.TimeWindow.Close();
            this.TimeWindow = null;
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PropertyWindow == null || this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow = new PropertyForm(this);
                this.PropertyWindow.UpdateParam();
                this.PropertyWindow.Show();
                this.PropertyWindow.Activate();
                return;
            }
            this.PropertyWindow.Close();
            this.PropertyWindow = null;
        }
        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BrowserWindow == null || this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow = new BrowserForm(this);
                this.BrowserWindow.UpdateParam();
                this.BrowserWindow.Show();
                this.BrowserWindow.Activate();
                return;
            }
            this.BrowserWindow.Close();
            this.BrowserWindow = null;
        }
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.StatusWindow == null || this.StatusWindow.IsDisposed)
            {
                this.StatusWindow = new StatusForm(this);
                this.StatusWindow.UpdateParam();
                this.StatusWindow.Show();
                this.StatusWindow.Activate();
                return;
            }
            this.StatusWindow.Close();
            this.StatusWindow = null;
        }
        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ParametersWindow == null || this.ParametersWindow.IsDisposed)
            {
                this.ParametersWindow = new ParametersForm(this.panelController.Config);
                this.ParametersWindow.Show();
                this.ParametersWindow.Activate();
                return;
            }
            this.ParametersWindow.Close();
            this.ParametersWindow = null;
        }
        private void brigAllToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ToolWindow != null && !this.ToolWindow.IsDisposed)
            {
                this.ToolWindow.Activate();
            }
            if (this.MaterialWindow != null && !this.MaterialWindow.IsDisposed)
            {
                this.MaterialWindow.Activate();
            }
            if (this.TimeWindow != null && !this.TimeWindow.IsDisposed)
            {
                this.TimeWindow.Activate();
            }
            if (this.PropertyWindow != null && !this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow.Activate();
            }
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.Activate();
            }
            if (this.StatusWindow != null && !this.StatusWindow.IsDisposed)
            {
                this.StatusWindow.Activate();
            }
            if (this.ParametersWindow != null && !this.ParametersWindow.IsDisposed)
            {
                this.ParametersWindow.Activate();
            }
        }
        private void editToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (this.panelController.Scene.GetUndoCount() > 0)
            {
                this.undoToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.undoToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.GetRedoCount() > 0)
            {
                this.redoToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.redoToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.particleBuilder.CountParticles(ParticleInfoManaged.Selected) > 0)
            {
                this.copyToolStripMenuItem.Enabled = true;
                this.cutToolStripMenuItem.Enabled = true;
                this.deselectAllToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.copyToolStripMenuItem.Enabled = false;
                this.cutToolStripMenuItem.Enabled = false;
                this.deselectAllToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.IsCopyExist())
            {
                this.pasteToolStripMenuItem.Enabled = true;
                return;
            }
            this.pasteToolStripMenuItem.Enabled = false;
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Undo();
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.Redo();
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsCopyable())
            {
                this.panelController.Scene.RegisterUndo();
                this.panelController.Scene.CopySelection();
                this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.Selected);
                return;
            }
            MessageBox.Show("The Art Piece could not be copied.");
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsCopyable())
            {
                this.panelController.Scene.CopySelection();
                return;
            }
            MessageBox.Show("The Art Piece could not be copied.");
        }
        private bool IsCopyable()
        {
            return true;
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.RegisterUndo();
            this.panelController.Scene.Paste();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.Selected);
        }
        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.RegisterUndo();
            this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.None);
            this.panelController.Scene.Clear();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.SelectAllParticles();
        }
        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.UnselectAllParticles();
        }
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void engineToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (this.panelController.Config.PauseFlag)
            {
                this.pausedToolStripMenuItem.Checked = true;
            }
            else
            {
                this.pausedToolStripMenuItem.Checked = false;
            }
            if (this.panelController.Config.BoundsFlag)
            {
                this.boundsWallToolStripMenuItem.Checked = true;
            }
            else
            {
                this.boundsWallToolStripMenuItem.Checked = false;
            }
            if (this.panelController.GravityFlag)
            {
                this.gravityToolStripMenuItem.Checked = true;
            }
            else
            {
                this.gravityToolStripMenuItem.Checked = false;
            }
            if (this.panelController.Config.SoundFlag)
            {
                this.playSoundToolStripMenuItem.Checked = true;
            }
            else
            {
                this.playSoundToolStripMenuItem.Checked = false;
            }
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = false;
            switch (this.panelController.Config.RenderMode)
            {
                case 1:
                    this.pointsToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    this.crossesToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    this.circlesToolStripMenuItem.Checked = true;
                    break;
                case 4:
                    this.bluredToolStripMenuItem.Checked = true;
                    break;
                case 5:
                    this.contourToolStripMenuItem.Checked = true;
                    break;
                case 6:
                    this.textureToolStripMenuItem.Checked = true;
                    break;
            }
            if (this.ToolLimit)
            {
                this.toolLimitToolStripMenuItem.Checked = true;
                return;
            }
            this.toolLimitToolStripMenuItem.Checked = false;
        }
        private void pausedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pausedToolStripMenuItem.Checked)
            {
                this.panelController.Config.PauseFlag = false;
                this.pausedToolStripMenuItem.Checked = false;
            }
            else
            {
                this.panelController.Config.PauseFlag = true;
                this.pausedToolStripMenuItem.Checked = true;
            }
            this.UpdatePropertyWindow();
        }
        private void movieCapturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsRecording())
            {
                this.StopRecording();
                return;
            }
            this.Record();
        }
        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void boundsWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.boundsWallToolStripMenuItem.Checked)
            {
                this.panelController.Config.BoundsFlag = false;
                this.boundsWallToolStripMenuItem.Checked = false;
            }
            else
            {
                this.panelController.Config.BoundsFlag = true;
                this.boundsWallToolStripMenuItem.Checked = true;
            }
            this.UpdatePropertyWindow();
        }
        private void gravityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gravityToolStripMenuItem.Checked)
            {
                this.panelController.GravityFlag = false;
                this.gravityToolStripMenuItem.Checked = false;
            }
            else
            {
                this.panelController.GravityFlag = true;
                this.gravityToolStripMenuItem.Checked = true;
            }
            this.UpdatePropertyWindow();
        }
        private void playSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.playSoundToolStripMenuItem.Checked)
            {
                this.panelController.Config.SoundFlag = false;
                this.playSoundToolStripMenuItem.Checked = false;
            }
            else
            {
                this.panelController.Config.SoundFlag = true;
                this.playSoundToolStripMenuItem.Checked = true;
            }
            this.UpdatePropertyWindow();
        }
        private void toolLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.toolLimitToolStripMenuItem.Checked)
            {
                this.toolLimitToolStripMenuItem.Checked = false;
                this.ToolLimit = false;
                return;
            }
            this.toolLimitToolStripMenuItem.Checked = true;
            this.ToolLimit = true;
        }
        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 1;
            this.pointsToolStripMenuItem.Checked = true;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = false;
            this.UpdatePropertyWindow();
        }
        private void crossesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 2;
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = true;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = false;
            this.UpdatePropertyWindow();
        }
        private void circlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 3;
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = true;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = false;
            this.UpdatePropertyWindow();
        }
        private void bluredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 4;
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = true;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = false;
            this.UpdatePropertyWindow();
        }
        private void contourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 5;
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = true;
            this.textureToolStripMenuItem.Checked = false;
            this.UpdatePropertyWindow();
        }
        private void textureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Config.RenderMode = 6;
            this.pointsToolStripMenuItem.Checked = false;
            this.crossesToolStripMenuItem.Checked = false;
            this.circlesToolStripMenuItem.Checked = false;
            this.bluredToolStripMenuItem.Checked = false;
            this.contourToolStripMenuItem.Checked = false;
            this.textureToolStripMenuItem.Checked = true;
            this.UpdatePropertyWindow();
        }
        public void Record()
        {
            this.StopRecording();
            if (this.saveMovieFile.ShowDialog() == DialogResult.OK)
            {
                this.panelController.Record(this.saveMovieFile.FileName);
            }
            if (this.IsRecording())
            {
                this.movieCapturingToolStripMenuItem.Checked = true;
                return;
            }
            this.movieCapturingToolStripMenuItem.Checked = false;
        }
        public void StopRecording()
        {
            if (this.panelController.Scene.IsRecording)
            {
                this.panelController.StopRecording();
            }
            if (this.IsRecording())
            {
                this.movieCapturingToolStripMenuItem.Checked = true;
                return;
            }
            this.movieCapturingToolStripMenuItem.Checked = false;
        }
        public bool IsRecording()
        {
            return this.panelController.Scene.IsRecording;
        }
        private void aboutPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void quitPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void logoutPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
            if (base.IsDisposed)
            {
                Registry.CurrentUser.DeleteSubKey("PHYZIOS Studio Pro");
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelController.IsModified)
            {
                BeforeClose beforeClose = new BeforeClose("Do you want to save the changes you made in the document \"" + this.SceneTitle + "\"?", "Your changes will be lost if you don't save them.");
                DialogResult dialogResult = beforeClose.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    this.CheckSave(false);
                }
            }
            this.panelController.Config.PauseFlag = true;
            this.panelController.enterFromClear = true;
            this.panelController.Clear();
            this.panelController.beat.ClearFileSystem();
            this.panelController.Config.ForegroundTexture = null;
            this.panelController.Config.BackgroundTexture = null;
            this.panelController.Config.WatermarkTexture = null;
            this.panelController.Config.FireTexture = null;
            this.panelController.Config.SplashTexture = null;
            this.panelController.Config.BubbleTexture = null;
            this.NewScene();
            this.ToolWindow.SetButtons(Tools.PencilTool);
            this.panelController.Config.PauseFlag = true;
            this.pausedToolStripMenuItem.Checked = true;
            if (this.BrowserWindow != null)
            {
                this.BrowserWindow.UpdateParam();
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "OEC Files|*.oec";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.panelController.LoadLocalData(openFileDialog.FileName);
                this.panelController.panelOECMain.Focus();
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private string GetPostString(string boundary, string name, string str)
        {
            return string.Concat(new string[] { "--", boundary, "\r\nContent-Disposition: form-data; name=\"", name, "\"\r\n\r\n", str, "\r\n" });
        }
        private string GetOriginalAP_ID(string ap_id)
        {
            if (!string.IsNullOrEmpty(ap_id))
            {
                int num = ap_id.LastIndexOf("-");
                if (num > 0)
                {
                    return ap_id.Substring(0, num);
                }
            }
            return string.Empty;
        }
        private void CheckSave(bool Local)
        {
            this.SaveScene(true);
        }
        private string GetArtPieceList()
        {
            List<string> list = new List<string>(this.panelController.Scene.Scene.FileManager.GetIncludeAPIDs());
            string text = string.Empty;
            foreach (string text2 in list)
            {
                text = ((!string.IsNullOrEmpty(text)) ? (text + "," + text2) : text2);
            }
            return text;
        }
        private void SaveScene(bool Local)
        {
            this.panelController.Scene.UnselectAllParticles();
            FileManagerCSharp fileManagerCSharp = new FileManagerCSharp(this.panelController.Scene.Scene.FileManager);
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "OEC Files|*.oec"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(saveFileDialog.FileName));
                string text = fileManagerCSharp.CreateSaveString();
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.Write(text);
                    }
                }
                this.panelController.IsModified = false;
                MessageBox.Show("Save Complete.", "PHYZIOS Studio Pro");
            }
            this.EnableTag = false;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckSave(false);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void revertToSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.LoadData(this.LastLoadData);
        }
        private void fileToolStripMenuItem1_DropDownOpened(object sender, EventArgs e)
        {
            if (this.LastLoadData == null)
            {
                this.revertToSavedToolStripMenuItem.Enabled = false;
                return;
            }
            this.revertToSavedToolStripMenuItem.Enabled = true;
        }
        public void SetFormSize()
        {
            this.panelController.ResizePanel(0, 0);
        }
        private void pHYZIOSStudioProHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Documentation/Phyzios_Studio_Pro_Manual_Ver1.0.pdf";
            if (!File.Exists(text))
            {
                text = "Phyzios_Studio_Pro_Manual_Ver1.0.pdf";
            }
            if (File.Exists(text))
            {
                Process.Start("Phyzios_Studio_Pro_Manual_Ver1.0.pdf");
                return;
            }
            MessageBox.Show("Help isn't available for PHYZIOS Studio Pro.");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.panelController != null && (base.WindowState == FormWindowState.Maximized || this.OldState == FormWindowState.Maximized))
            {
                if (base.WindowState == FormWindowState.Maximized)
                {
                    this.panelController.IsZoomed = true;
                    this.ResizePanelByContainer();
                    this.panelController.Scene.SceneRenderer.SetViewport(this.panelController.panelOECMain.Width, this.panelController.panelOECMain.Height);
                }
                else
                {
                    this.panelController.IsZoomed = false;
                    this.SetFormSize();
                }
                this.OldState = base.WindowState;
            }
        }
        private void ResizePanelByContainer()
        {
            SizeChanger sizeChanger = new SizeChanger(this.panel1.Width, this.panel1.Height);
            sizeChanger.Execute(this.panelController.panelOECMain.Width, this.panelController.panelOECMain.Height);
            this.panelController.panelOECMain.Top = sizeChanger.Top;
            this.panelController.panelOECMain.Left = sizeChanger.Left;
            this.panelController.panelOECMain.Width = sizeChanger.Width;
            this.panelController.panelOECMain.Height = sizeChanger.Height;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.panelController != null && this.panelController.IsModified)
            {
                BeforeClose beforeClose = new BeforeClose("Do you want to save the changes you made in the document \"" + this.SceneTitle + "\"?", "Your changes will be lost if you don't save them.");
                DialogResult dialogResult = beforeClose.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    this.CheckSave(false);
                }
            }
        }
        public void SelectBody(int bodyid)
        {
            this.panelController.Scene.UnselectAllParticles();
            this.panelController.Scene.particleBuilder.SelectBody(bodyid);
        }
        private void saveToLocalAndWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckSave(true);
        }
        private PanelController panelController;
        private ToolForm ToolWindow;
        private MaterialForm MaterialWindow;
        private BrowserForm BrowserWindow;
        private PropertyForm PropertyWindow;
        private TimeForm TimeWindow;
        private StatusForm StatusWindow;
        private ParametersForm ParametersWindow;
        private MaterialNames MaterialNameList;
        public string SceneTitle;
        public string SceneDescription;
        public string SceneTags;
        public string SceneID;
        public string SceneUserID;
        public string SceneParentID;
        public string SceneAPGID;
        public bool PublishFlag;
        public bool UseScript;
        public bool EnableTag;
        private byte[] LastLoadData;
        public bool ToolLimit;
        private FormWindowState OldState;
    }
}
