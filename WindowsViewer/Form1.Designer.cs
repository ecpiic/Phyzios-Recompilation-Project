namespace WindowsViewer
{
    public partial class Form1 : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToLocalAndWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitPhyziosStudioProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundsWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brigAllToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHYZIOSStudioProHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPhyziosStudioProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatePrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMovieFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.engineToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.hToolStripMenuItem,
            this.advancedToolsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuMain.Size = new System.Drawing.Size(665, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.revertToSavedToolStripMenuItem,
            this.saveToLocalAndWebToolStripMenuItem,
            this.quitPhyziosStudioProToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem1_DropDownOpened);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // revertToSavedToolStripMenuItem
            // 
            this.revertToSavedToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.revertToSavedToolStripMenuItem.Name = "revertToSavedToolStripMenuItem";
            this.revertToSavedToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.revertToSavedToolStripMenuItem.Text = "Revert to Saved";
            this.revertToSavedToolStripMenuItem.Click += new System.EventHandler(this.revertToSavedToolStripMenuItem_Click);
            // 
            // saveToLocalAndWebToolStripMenuItem
            // 
            this.saveToLocalAndWebToolStripMenuItem.Name = "saveToLocalAndWebToolStripMenuItem";
            this.saveToLocalAndWebToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToLocalAndWebToolStripMenuItem.Text = "Save to Local and Web";
            this.saveToLocalAndWebToolStripMenuItem.Visible = false;
            this.saveToLocalAndWebToolStripMenuItem.Click += new System.EventHandler(this.saveToLocalAndWebToolStripMenuItem_Click);
            // 
            // quitPhyziosStudioProToolStripMenuItem
            // 
            this.quitPhyziosStudioProToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quitPhyziosStudioProToolStripMenuItem.Name = "quitPhyziosStudioProToolStripMenuItem";
            this.quitPhyziosStudioProToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.quitPhyziosStudioProToolStripMenuItem.Text = "Quit";
            this.quitPhyziosStudioProToolStripMenuItem.Click += new System.EventHandler(this.quitPhyziosStudioProToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.editToolStripMenuItem_DropDownOpened);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // engineToolStripMenuItem
            // 
            this.engineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausedToolStripMenuItem,
            this.movieCapturingToolStripMenuItem,
            this.stToolStripMenuItem,
            this.boundsWallToolStripMenuItem,
            this.gravityToolStripMenuItem,
            this.playSoundToolStripMenuItem,
            this.toolLimitToolStripMenuItem});
            this.engineToolStripMenuItem.Name = "engineToolStripMenuItem";
            this.engineToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.engineToolStripMenuItem.Text = "Engine";
            this.engineToolStripMenuItem.DropDownOpened += new System.EventHandler(this.engineToolStripMenuItem_DropDownOpened);
            // 
            // pausedToolStripMenuItem
            // 
            this.pausedToolStripMenuItem.Checked = true;
            this.pausedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pausedToolStripMenuItem.Name = "pausedToolStripMenuItem";
            this.pausedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pausedToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pausedToolStripMenuItem.Text = "Paused";
            this.pausedToolStripMenuItem.Click += new System.EventHandler(this.pausedToolStripMenuItem_Click);
            // 
            // movieCapturingToolStripMenuItem
            // 
            this.movieCapturingToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.movieCapturingToolStripMenuItem.Name = "movieCapturingToolStripMenuItem";
            this.movieCapturingToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.movieCapturingToolStripMenuItem.Text = "Movie Capturing";
            this.movieCapturingToolStripMenuItem.Click += new System.EventHandler(this.movieCapturingToolStripMenuItem_Click);
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.crossesToolStripMenuItem,
            this.circlesToolStripMenuItem,
            this.bluredToolStripMenuItem,
            this.contourToolStripMenuItem,
            this.textureToolStripMenuItem});
            this.stToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.stToolStripMenuItem.Text = "Style";
            this.stToolStripMenuItem.Click += new System.EventHandler(this.stToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // crossesToolStripMenuItem
            // 
            this.crossesToolStripMenuItem.Name = "crossesToolStripMenuItem";
            this.crossesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.crossesToolStripMenuItem.Text = "Crosses";
            this.crossesToolStripMenuItem.Click += new System.EventHandler(this.crossesToolStripMenuItem_Click);
            // 
            // circlesToolStripMenuItem
            // 
            this.circlesToolStripMenuItem.Name = "circlesToolStripMenuItem";
            this.circlesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.circlesToolStripMenuItem.Text = "Circles";
            this.circlesToolStripMenuItem.Click += new System.EventHandler(this.circlesToolStripMenuItem_Click);
            // 
            // bluredToolStripMenuItem
            // 
            this.bluredToolStripMenuItem.Name = "bluredToolStripMenuItem";
            this.bluredToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bluredToolStripMenuItem.Text = "Blurred";
            this.bluredToolStripMenuItem.Click += new System.EventHandler(this.bluredToolStripMenuItem_Click);
            // 
            // contourToolStripMenuItem
            // 
            this.contourToolStripMenuItem.Name = "contourToolStripMenuItem";
            this.contourToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.contourToolStripMenuItem.Text = "Contour";
            this.contourToolStripMenuItem.Click += new System.EventHandler(this.contourToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.textureToolStripMenuItem.Text = "Texture";
            this.textureToolStripMenuItem.Click += new System.EventHandler(this.textureToolStripMenuItem_Click);
            // 
            // boundsWallToolStripMenuItem
            // 
            this.boundsWallToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.boundsWallToolStripMenuItem.Name = "boundsWallToolStripMenuItem";
            this.boundsWallToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.boundsWallToolStripMenuItem.Text = "Bounds Wall";
            this.boundsWallToolStripMenuItem.Click += new System.EventHandler(this.boundsWallToolStripMenuItem_Click);
            // 
            // gravityToolStripMenuItem
            // 
            this.gravityToolStripMenuItem.Name = "gravityToolStripMenuItem";
            this.gravityToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gravityToolStripMenuItem.Text = "Gravity";
            this.gravityToolStripMenuItem.Click += new System.EventHandler(this.gravityToolStripMenuItem_Click);
            // 
            // playSoundToolStripMenuItem
            // 
            this.playSoundToolStripMenuItem.Name = "playSoundToolStripMenuItem";
            this.playSoundToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playSoundToolStripMenuItem.Text = "Play Sound";
            this.playSoundToolStripMenuItem.Click += new System.EventHandler(this.playSoundToolStripMenuItem_Click);
            // 
            // toolLimitToolStripMenuItem
            // 
            this.toolLimitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.toolLimitToolStripMenuItem.Name = "toolLimitToolStripMenuItem";
            this.toolLimitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.toolLimitToolStripMenuItem.Text = "Tool Limit";
            this.toolLimitToolStripMenuItem.Click += new System.EventHandler(this.toolLimitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolboxToolStripMenuItem,
            this.materialsToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.brigAllToFrontToolStripMenuItem,
            this.topmostToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // toolboxToolStripMenuItem
            // 
            this.toolboxToolStripMenuItem.Name = "toolboxToolStripMenuItem";
            this.toolboxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.toolboxToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.toolboxToolStripMenuItem.Text = "Toolbox";
            this.toolboxToolStripMenuItem.Click += new System.EventHandler(this.toolboxToolStripMenuItem_Click);
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.materialsToolStripMenuItem.Text = "Materials";
            this.materialsToolStripMenuItem.Click += new System.EventHandler(this.materialsToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.browserToolStripMenuItem.Text = "Browser";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // brigAllToFrontToolStripMenuItem
            // 
            this.brigAllToFrontToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.brigAllToFrontToolStripMenuItem.Name = "brigAllToFrontToolStripMenuItem";
            this.brigAllToFrontToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.brigAllToFrontToolStripMenuItem.Text = "Bring All to Front";
            this.brigAllToFrontToolStripMenuItem.Click += new System.EventHandler(this.brigAllToFrontToolStripMenuItem_Click);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Topmost_CheckChanged);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHYZIOSStudioProHelpToolStripMenuItem,
            this.aboutPhyziosStudioProToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.hToolStripMenuItem.Text = "Help";
            // 
            // pHYZIOSStudioProHelpToolStripMenuItem
            // 
            this.pHYZIOSStudioProHelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pHYZIOSStudioProHelpToolStripMenuItem.Name = "pHYZIOSStudioProHelpToolStripMenuItem";
            this.pHYZIOSStudioProHelpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pHYZIOSStudioProHelpToolStripMenuItem.Text = "PHYZIOS Studio Pro Help";
            this.pHYZIOSStudioProHelpToolStripMenuItem.Click += new System.EventHandler(this.pHYZIOSStudioProHelpToolStripMenuItem_Click);
            // 
            // aboutPhyziosStudioProToolStripMenuItem
            // 
            this.aboutPhyziosStudioProToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutPhyziosStudioProToolStripMenuItem.Name = "aboutPhyziosStudioProToolStripMenuItem";
            this.aboutPhyziosStudioProToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutPhyziosStudioProToolStripMenuItem.Text = "About PhyziosStudioPro";
            this.aboutPhyziosStudioProToolStripMenuItem.Click += new System.EventHandler(this.aboutPhyziosStudioProToolStripMenuItem_Click);
            // 
            // advancedToolsToolStripMenuItem
            // 
            this.advancedToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templatePrinterToolStripMenuItem});
            this.advancedToolsToolStripMenuItem.Name = "advancedToolsToolStripMenuItem";
            this.advancedToolsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.advancedToolsToolStripMenuItem.Text = "Advanced Tools";
            this.advancedToolsToolStripMenuItem.Visible = false;
            // 
            // templatePrinterToolStripMenuItem
            // 
            this.templatePrinterToolStripMenuItem.Name = "templatePrinterToolStripMenuItem";
            this.templatePrinterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.templatePrinterToolStripMenuItem.Text = "Template Printer";
            this.templatePrinterToolStripMenuItem.Click += new System.EventHandler(this.TemplatePrinterToolStripMenu_Click);
            // 
            // saveMovieFile
            // 
            this.saveMovieFile.DefaultExt = "avi";
            this.saveMovieFile.Filter = "AVI file|*.avi";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(665, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Panel_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Panel_PreviewKeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.MenuStrip menuMain;
        private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private global::System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem engineToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem aboutPhyziosStudioProToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem quitPhyziosStudioProToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem revertToSavedToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pausedToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem movieCapturingToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem stToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem boundsWallToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem gravityToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem playSoundToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem toolLimitToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem toolboxToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem brigAllToFrontToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pHYZIOSStudioProHelpToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem crossesToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem circlesToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem bluredToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem contourToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem textureToolStripMenuItem;
        private global::System.Windows.Forms.SaveFileDialog saveMovieFile;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.ToolStripMenuItem saveToLocalAndWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatePrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
    }
}
