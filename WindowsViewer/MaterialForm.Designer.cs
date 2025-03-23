namespace WindowsViewer
{
    public partial class MaterialForm : global::System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.tabShapes = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.radioZombie = new System.Windows.Forms.RadioButton();
            this.radioBrittle = new System.Windows.Forms.RadioButton();
            this.radioUsers = new System.Windows.Forms.RadioButton();
            this.radioJet = new System.Windows.Forms.RadioButton();
            this.radioOil = new System.Windows.Forms.RadioButton();
            this.radioBlank0 = new System.Windows.Forms.RadioButton();
            this.radioAxis = new System.Windows.Forms.RadioButton();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioFlow = new System.Windows.Forms.RadioButton();
            this.radioCold = new System.Windows.Forms.RadioButton();
            this.radioHot = new System.Windows.Forms.RadioButton();
            this.radioGas = new System.Windows.Forms.RadioButton();
            this.radioRice = new System.Windows.Forms.RadioButton();
            this.radioVisco = new System.Windows.Forms.RadioButton();
            this.radioMochi = new System.Windows.Forms.RadioButton();
            this.radioTensil = new System.Windows.Forms.RadioButton();
            this.radioPowder = new System.Windows.Forms.RadioButton();
            this.radioFire = new System.Windows.Forms.RadioButton();
            this.radioFuel = new System.Windows.Forms.RadioButton();
            this.radioString = new System.Windows.Forms.RadioButton();
            this.radioErastic = new System.Windows.Forms.RadioButton();
            this.radioRigid = new System.Windows.Forms.RadioButton();
            this.radioWall = new System.Windows.Forms.RadioButton();
            this.radioAqua = new System.Windows.Forms.RadioButton();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.NoneButton = new System.Windows.Forms.CheckBox();
            this.ReservedButton = new System.Windows.Forms.CheckBox();
            this.AirButton = new System.Windows.Forms.CheckBox();
            this.JetButton = new System.Windows.Forms.CheckBox();
            this.NaturalButton = new System.Windows.Forms.CheckBox();
            this.JoinableButton = new System.Windows.Forms.CheckBox();
            this.SelectedButton = new System.Windows.Forms.CheckBox();
            this.TexturedButton = new System.Windows.Forms.CheckBox();
            this.StorableButton = new System.Windows.Forms.CheckBox();
            this.checkZombie = new System.Windows.Forms.CheckBox();
            this.checkBrittle = new System.Windows.Forms.CheckBox();
            this.checkUsers = new System.Windows.Forms.CheckBox();
            this.checkHeavy = new System.Windows.Forms.CheckBox();
            this.checkLight = new System.Windows.Forms.CheckBox();
            this.checkLink = new System.Windows.Forms.CheckBox();
            this.checkAxis = new System.Windows.Forms.CheckBox();
            this.checkOut = new System.Windows.Forms.CheckBox();
            this.checkFlow = new System.Windows.Forms.CheckBox();
            this.checkCold = new System.Windows.Forms.CheckBox();
            this.checkHot = new System.Windows.Forms.CheckBox();
            this.checkGas = new System.Windows.Forms.CheckBox();
            this.checkRice = new System.Windows.Forms.CheckBox();
            this.checkVisco = new System.Windows.Forms.CheckBox();
            this.checkTensil = new System.Windows.Forms.CheckBox();
            this.checkFuel = new System.Windows.Forms.CheckBox();
            this.checkPowder = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkMochi = new System.Windows.Forms.CheckBox();
            this.checkString = new System.Windows.Forms.CheckBox();
            this.checkElastic = new System.Windows.Forms.CheckBox();
            this.checkSolid = new System.Windows.Forms.CheckBox();
            this.checkWall = new System.Windows.Forms.CheckBox();
            this.checkWater = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxCentralAxle = new System.Windows.Forms.CheckBox();
            this.radioTextureShape = new System.Windows.Forms.RadioButton();
            this.radioTriangle = new System.Windows.Forms.RadioButton();
            this.radioStar = new System.Windows.Forms.RadioButton();
            this.radioSquare = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioOval = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioHeart = new System.Windows.Forms.RadioButton();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabShapes.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            this.tabPageCustom.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShapes
            // 
            this.tabShapes.Controls.Add(this.tabPageBasic);
            this.tabShapes.Controls.Add(this.tabPageCustom);
            this.tabShapes.Controls.Add(this.tabPage1);
            this.tabShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabShapes.Location = new System.Drawing.Point(0, 0);
            this.tabShapes.Name = "tabShapes";
            this.tabShapes.SelectedIndex = 0;
            this.tabShapes.Size = new System.Drawing.Size(308, 238);
            this.tabShapes.TabIndex = 2;
            this.tabShapes.Click += new System.EventHandler(this.Tab_CheckChanged);
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.Controls.Add(this.radioZombie);
            this.tabPageBasic.Controls.Add(this.radioBrittle);
            this.tabPageBasic.Controls.Add(this.radioUsers);
            this.tabPageBasic.Controls.Add(this.radioJet);
            this.tabPageBasic.Controls.Add(this.radioOil);
            this.tabPageBasic.Controls.Add(this.radioBlank0);
            this.tabPageBasic.Controls.Add(this.radioAxis);
            this.tabPageBasic.Controls.Add(this.radioOut);
            this.tabPageBasic.Controls.Add(this.radioFlow);
            this.tabPageBasic.Controls.Add(this.radioCold);
            this.tabPageBasic.Controls.Add(this.radioHot);
            this.tabPageBasic.Controls.Add(this.radioGas);
            this.tabPageBasic.Controls.Add(this.radioRice);
            this.tabPageBasic.Controls.Add(this.radioVisco);
            this.tabPageBasic.Controls.Add(this.radioMochi);
            this.tabPageBasic.Controls.Add(this.radioTensil);
            this.tabPageBasic.Controls.Add(this.radioPowder);
            this.tabPageBasic.Controls.Add(this.radioFire);
            this.tabPageBasic.Controls.Add(this.radioFuel);
            this.tabPageBasic.Controls.Add(this.radioString);
            this.tabPageBasic.Controls.Add(this.radioErastic);
            this.tabPageBasic.Controls.Add(this.radioRigid);
            this.tabPageBasic.Controls.Add(this.radioWall);
            this.tabPageBasic.Controls.Add(this.radioAqua);
            this.tabPageBasic.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasic.Size = new System.Drawing.Size(300, 212);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Basic";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // radioZombie
            // 
            this.radioZombie.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioZombie.Image = global::WindowsViewer.Properties.Resources.radioZombie;
            this.radioZombie.Location = new System.Drawing.Point(253, 168);
            this.radioZombie.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioZombie.Name = "radioZombie";
            this.radioZombie.Size = new System.Drawing.Size(32, 35);
            this.radioZombie.TabIndex = 24;
            this.toolTip1.SetToolTip(this.radioZombie, "Zombie");
            this.radioZombie.UseVisualStyleBackColor = true;
            this.radioZombie.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioBrittle
            // 
            this.radioBrittle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBrittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBrittle.Image = global::WindowsViewer.Properties.Resources.checkBrittle;
            this.radioBrittle.Location = new System.Drawing.Point(205, 168);
            this.radioBrittle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBrittle.Name = "radioBrittle";
            this.radioBrittle.Size = new System.Drawing.Size(32, 35);
            this.radioBrittle.TabIndex = 23;
            this.toolTip1.SetToolTip(this.radioBrittle, "Brittle");
            this.radioBrittle.UseVisualStyleBackColor = true;
            this.radioBrittle.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioUsers
            // 
            this.radioUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioUsers.Image = global::WindowsViewer.Properties.Resources.checkUsers;
            this.radioUsers.Location = new System.Drawing.Point(157, 168);
            this.radioUsers.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioUsers.Name = "radioUsers";
            this.radioUsers.Size = new System.Drawing.Size(32, 35);
            this.radioUsers.TabIndex = 22;
            this.toolTip1.SetToolTip(this.radioUsers, "User");
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioJet
            // 
            this.radioJet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioJet.Image = global::WindowsViewer.Properties.Resources.JetButton;
            this.radioJet.Location = new System.Drawing.Point(109, 168);
            this.radioJet.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioJet.Name = "radioJet";
            this.radioJet.Size = new System.Drawing.Size(32, 35);
            this.radioJet.TabIndex = 21;
            this.toolTip1.SetToolTip(this.radioJet, "Jet");
            this.radioJet.UseVisualStyleBackColor = true;
            // 
            // radioOil
            // 
            this.radioOil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOil.Image = global::WindowsViewer.Properties.Resources.checkFuel;
            this.radioOil.Location = new System.Drawing.Point(61, 168);
            this.radioOil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioOil.Name = "radioOil";
            this.radioOil.Size = new System.Drawing.Size(32, 35);
            this.radioOil.TabIndex = 20;
            this.toolTip1.SetToolTip(this.radioOil, "Oil");
            this.radioOil.UseVisualStyleBackColor = true;
            this.radioOil.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioBlank0
            // 
            this.radioBlank0.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBlank0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBlank0.Image = global::WindowsViewer.Properties.Resources.YukiMaterial;
            this.radioBlank0.Location = new System.Drawing.Point(13, 168);
            this.radioBlank0.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBlank0.Name = "radioBlank0";
            this.radioBlank0.Size = new System.Drawing.Size(32, 35);
            this.radioBlank0.TabIndex = 19;
            this.toolTip1.SetToolTip(this.radioBlank0, "Yuki");
            this.radioBlank0.UseVisualStyleBackColor = true;
            this.radioBlank0.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioAxis
            // 
            this.radioAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioAxis.Image = global::WindowsViewer.Properties.Resources.checkAxis;
            this.radioAxis.Location = new System.Drawing.Point(253, 116);
            this.radioAxis.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioAxis.Name = "radioAxis";
            this.radioAxis.Size = new System.Drawing.Size(32, 35);
            this.radioAxis.TabIndex = 18;
            this.toolTip1.SetToolTip(this.radioAxis, "Axis/Fulcrum");
            this.radioAxis.UseVisualStyleBackColor = true;
            this.radioAxis.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioOut
            // 
            this.radioOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOut.Image = global::WindowsViewer.Properties.Resources.checkOut;
            this.radioOut.Location = new System.Drawing.Point(205, 116);
            this.radioOut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(32, 35);
            this.radioOut.TabIndex = 17;
            this.toolTip1.SetToolTip(this.radioOut, "Outflow");
            this.radioOut.UseVisualStyleBackColor = true;
            this.radioOut.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFlow
            // 
            this.radioFlow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFlow.Image = global::WindowsViewer.Properties.Resources.radioFlow;
            this.radioFlow.Location = new System.Drawing.Point(157, 116);
            this.radioFlow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFlow.Name = "radioFlow";
            this.radioFlow.Size = new System.Drawing.Size(32, 35);
            this.radioFlow.TabIndex = 16;
            this.toolTip1.SetToolTip(this.radioFlow, "Faucet");
            this.radioFlow.UseVisualStyleBackColor = true;
            this.radioFlow.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioCold
            // 
            this.radioCold.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioCold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioCold.Image = global::WindowsViewer.Properties.Resources.checkCold;
            this.radioCold.Location = new System.Drawing.Point(109, 116);
            this.radioCold.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioCold.Name = "radioCold";
            this.radioCold.Size = new System.Drawing.Size(32, 35);
            this.radioCold.TabIndex = 15;
            this.toolTip1.SetToolTip(this.radioCold, "Cold Wall");
            this.radioCold.UseVisualStyleBackColor = true;
            this.radioCold.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioHot
            // 
            this.radioHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioHot.Image = global::WindowsViewer.Properties.Resources.checkHot;
            this.radioHot.Location = new System.Drawing.Point(61, 116);
            this.radioHot.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioHot.Name = "radioHot";
            this.radioHot.Size = new System.Drawing.Size(32, 35);
            this.radioHot.TabIndex = 14;
            this.toolTip1.SetToolTip(this.radioHot, "Hot Wall");
            this.radioHot.UseVisualStyleBackColor = true;
            this.radioHot.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioGas
            // 
            this.radioGas.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioGas.Image = global::WindowsViewer.Properties.Resources.checkGas;
            this.radioGas.Location = new System.Drawing.Point(13, 116);
            this.radioGas.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioGas.Name = "radioGas";
            this.radioGas.Size = new System.Drawing.Size(32, 35);
            this.radioGas.TabIndex = 13;
            this.toolTip1.SetToolTip(this.radioGas, "Gas");
            this.radioGas.UseVisualStyleBackColor = true;
            this.radioGas.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioRice
            // 
            this.radioRice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRice.Image = global::WindowsViewer.Properties.Resources.radioRice;
            this.radioRice.Location = new System.Drawing.Point(253, 64);
            this.radioRice.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioRice.Name = "radioRice";
            this.radioRice.Size = new System.Drawing.Size(32, 35);
            this.radioRice.TabIndex = 12;
            this.toolTip1.SetToolTip(this.radioRice, "Rice");
            this.radioRice.UseVisualStyleBackColor = true;
            this.radioRice.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioVisco
            // 
            this.radioVisco.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioVisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioVisco.Image = global::WindowsViewer.Properties.Resources.checkVisco;
            this.radioVisco.Location = new System.Drawing.Point(205, 64);
            this.radioVisco.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioVisco.Name = "radioVisco";
            this.radioVisco.Size = new System.Drawing.Size(32, 35);
            this.radioVisco.TabIndex = 11;
            this.toolTip1.SetToolTip(this.radioVisco, "Viscous");
            this.radioVisco.UseVisualStyleBackColor = true;
            this.radioVisco.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioMochi
            // 
            this.radioMochi.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMochi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMochi.Image = global::WindowsViewer.Properties.Resources.checkMochi;
            this.radioMochi.Location = new System.Drawing.Point(253, 12);
            this.radioMochi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioMochi.Name = "radioMochi";
            this.radioMochi.Size = new System.Drawing.Size(32, 35);
            this.radioMochi.TabIndex = 6;
            this.toolTip1.SetToolTip(this.radioMochi, "Mochi");
            this.radioMochi.UseVisualStyleBackColor = true;
            this.radioMochi.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioTensil
            // 
            this.radioTensil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTensil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioTensil.Image = global::WindowsViewer.Properties.Resources.checkTensil;
            this.radioTensil.Location = new System.Drawing.Point(157, 64);
            this.radioTensil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioTensil.Name = "radioTensil";
            this.radioTensil.Size = new System.Drawing.Size(32, 35);
            this.radioTensil.TabIndex = 10;
            this.toolTip1.SetToolTip(this.radioTensil, "Tensile");
            this.radioTensil.UseVisualStyleBackColor = true;
            this.radioTensil.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioPowder
            // 
            this.radioPowder.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPowder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioPowder.Image = global::WindowsViewer.Properties.Resources.checkPowder;
            this.radioPowder.Location = new System.Drawing.Point(61, 64);
            this.radioPowder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioPowder.Name = "radioPowder";
            this.radioPowder.Size = new System.Drawing.Size(32, 35);
            this.radioPowder.TabIndex = 8;
            this.toolTip1.SetToolTip(this.radioPowder, "Powder");
            this.radioPowder.UseVisualStyleBackColor = true;
            this.radioPowder.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFire
            // 
            this.radioFire.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFire.Image = global::WindowsViewer.Properties.Resources.radioFire;
            this.radioFire.Location = new System.Drawing.Point(13, 64);
            this.radioFire.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFire.Name = "radioFire";
            this.radioFire.Size = new System.Drawing.Size(32, 35);
            this.radioFire.TabIndex = 7;
            this.toolTip1.SetToolTip(this.radioFire, "Fire");
            this.radioFire.UseVisualStyleBackColor = true;
            this.radioFire.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFuel
            // 
            this.radioFuel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFuel.Image = global::WindowsViewer.Properties.Resources.radioFuel;
            this.radioFuel.Location = new System.Drawing.Point(109, 64);
            this.radioFuel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFuel.Name = "radioFuel";
            this.radioFuel.Size = new System.Drawing.Size(32, 35);
            this.radioFuel.TabIndex = 9;
            this.toolTip1.SetToolTip(this.radioFuel, "Wood");
            this.radioFuel.UseVisualStyleBackColor = true;
            this.radioFuel.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioString
            // 
            this.radioString.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioString.Image = global::WindowsViewer.Properties.Resources.checkString;
            this.radioString.Location = new System.Drawing.Point(205, 12);
            this.radioString.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioString.Name = "radioString";
            this.radioString.Size = new System.Drawing.Size(32, 35);
            this.radioString.TabIndex = 5;
            this.toolTip1.SetToolTip(this.radioString, "Spring");
            this.radioString.UseVisualStyleBackColor = true;
            this.radioString.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioErastic
            // 
            this.radioErastic.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioErastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioErastic.Image = global::WindowsViewer.Properties.Resources.checkElastic;
            this.radioErastic.Location = new System.Drawing.Point(157, 12);
            this.radioErastic.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioErastic.Name = "radioErastic";
            this.radioErastic.Size = new System.Drawing.Size(32, 35);
            this.radioErastic.TabIndex = 4;
            this.toolTip1.SetToolTip(this.radioErastic, "Elastic");
            this.radioErastic.UseVisualStyleBackColor = true;
            this.radioErastic.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioRigid
            // 
            this.radioRigid.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRigid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRigid.Image = global::WindowsViewer.Properties.Resources.checkSolid;
            this.radioRigid.Location = new System.Drawing.Point(109, 12);
            this.radioRigid.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioRigid.Name = "radioRigid";
            this.radioRigid.Size = new System.Drawing.Size(32, 35);
            this.radioRigid.TabIndex = 3;
            this.toolTip1.SetToolTip(this.radioRigid, "Rigid");
            this.radioRigid.UseVisualStyleBackColor = true;
            this.radioRigid.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioWall
            // 
            this.radioWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioWall.Checked = true;
            this.radioWall.Image = global::WindowsViewer.Properties.Resources.checkWall;
            this.radioWall.Location = new System.Drawing.Point(61, 12);
            this.radioWall.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioWall.Name = "radioWall";
            this.radioWall.Size = new System.Drawing.Size(32, 35);
            this.radioWall.TabIndex = 2;
            this.radioWall.TabStop = true;
            this.toolTip1.SetToolTip(this.radioWall, "Wall");
            this.radioWall.UseVisualStyleBackColor = true;
            this.radioWall.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioAqua
            // 
            this.radioAqua.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioAqua.Image = global::WindowsViewer.Properties.Resources.checkWater;
            this.radioAqua.Location = new System.Drawing.Point(13, 12);
            this.radioAqua.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioAqua.Name = "radioAqua";
            this.radioAqua.Size = new System.Drawing.Size(32, 35);
            this.radioAqua.TabIndex = 1;
            this.toolTip1.SetToolTip(this.radioAqua, "Water");
            this.radioAqua.UseVisualStyleBackColor = true;
            this.radioAqua.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.Controls.Add(this.NoneButton);
            this.tabPageCustom.Controls.Add(this.ReservedButton);
            this.tabPageCustom.Controls.Add(this.AirButton);
            this.tabPageCustom.Controls.Add(this.JetButton);
            this.tabPageCustom.Controls.Add(this.NaturalButton);
            this.tabPageCustom.Controls.Add(this.JoinableButton);
            this.tabPageCustom.Controls.Add(this.SelectedButton);
            this.tabPageCustom.Controls.Add(this.TexturedButton);
            this.tabPageCustom.Controls.Add(this.StorableButton);
            this.tabPageCustom.Controls.Add(this.checkZombie);
            this.tabPageCustom.Controls.Add(this.checkBrittle);
            this.tabPageCustom.Controls.Add(this.checkUsers);
            this.tabPageCustom.Controls.Add(this.checkHeavy);
            this.tabPageCustom.Controls.Add(this.checkLight);
            this.tabPageCustom.Controls.Add(this.checkLink);
            this.tabPageCustom.Controls.Add(this.checkAxis);
            this.tabPageCustom.Controls.Add(this.checkOut);
            this.tabPageCustom.Controls.Add(this.checkFlow);
            this.tabPageCustom.Controls.Add(this.checkCold);
            this.tabPageCustom.Controls.Add(this.checkHot);
            this.tabPageCustom.Controls.Add(this.checkGas);
            this.tabPageCustom.Controls.Add(this.checkRice);
            this.tabPageCustom.Controls.Add(this.checkVisco);
            this.tabPageCustom.Controls.Add(this.checkTensil);
            this.tabPageCustom.Controls.Add(this.checkFuel);
            this.tabPageCustom.Controls.Add(this.checkPowder);
            this.tabPageCustom.Controls.Add(this.checkBox12);
            this.tabPageCustom.Controls.Add(this.checkMochi);
            this.tabPageCustom.Controls.Add(this.checkString);
            this.tabPageCustom.Controls.Add(this.checkElastic);
            this.tabPageCustom.Controls.Add(this.checkSolid);
            this.tabPageCustom.Controls.Add(this.checkWall);
            this.tabPageCustom.Controls.Add(this.checkWater);
            this.tabPageCustom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustom.Size = new System.Drawing.Size(300, 212);
            this.tabPageCustom.TabIndex = 1;
            this.tabPageCustom.Text = "Custom";
            this.tabPageCustom.UseVisualStyleBackColor = true;
            // 
            // NoneButton
            // 
            this.NoneButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoneButton.BackColor = System.Drawing.Color.White;
            this.NoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoneButton.Location = new System.Drawing.Point(109, 283);
            this.NoneButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(32, 35);
            this.NoneButton.TabIndex = 32;
            this.toolTip1.SetToolTip(this.NoneButton, "None");
            this.NoneButton.UseVisualStyleBackColor = false;
            this.NoneButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // ReservedButton
            // 
            this.ReservedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ReservedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReservedButton.Image = global::WindowsViewer.Properties.Resources.Reserved;
            this.ReservedButton.Location = new System.Drawing.Point(61, 283);
            this.ReservedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ReservedButton.Name = "ReservedButton";
            this.ReservedButton.Size = new System.Drawing.Size(32, 35);
            this.ReservedButton.TabIndex = 31;
            this.toolTip1.SetToolTip(this.ReservedButton, "Reserved");
            this.ReservedButton.UseVisualStyleBackColor = true;
            this.ReservedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // AirButton
            // 
            this.AirButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AirButton.Image = global::WindowsViewer.Properties.Resources.Air;
            this.AirButton.Location = new System.Drawing.Point(13, 283);
            this.AirButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.AirButton.Name = "AirButton";
            this.AirButton.Size = new System.Drawing.Size(32, 35);
            this.AirButton.TabIndex = 30;
            this.toolTip1.SetToolTip(this.AirButton, "Air");
            this.AirButton.UseVisualStyleBackColor = true;
            this.AirButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // JetButton
            // 
            this.JetButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.JetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JetButton.Image = global::WindowsViewer.Properties.Resources.Jet;
            this.JetButton.Location = new System.Drawing.Point(253, 230);
            this.JetButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.JetButton.Name = "JetButton";
            this.JetButton.Size = new System.Drawing.Size(32, 35);
            this.JetButton.TabIndex = 29;
            this.toolTip1.SetToolTip(this.JetButton, "Jet");
            this.JetButton.UseVisualStyleBackColor = true;
            this.JetButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // NaturalButton
            // 
            this.NaturalButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NaturalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NaturalButton.Image = global::WindowsViewer.Properties.Resources.Naturaldarkened;
            this.NaturalButton.Location = new System.Drawing.Point(205, 230);
            this.NaturalButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NaturalButton.Name = "NaturalButton";
            this.NaturalButton.Size = new System.Drawing.Size(32, 35);
            this.NaturalButton.TabIndex = 28;
            this.toolTip1.SetToolTip(this.NaturalButton, "Natural");
            this.NaturalButton.UseVisualStyleBackColor = true;
            this.NaturalButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // JoinableButton
            // 
            this.JoinableButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.JoinableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JoinableButton.Image = global::WindowsViewer.Properties.Resources.Joinable;
            this.JoinableButton.Location = new System.Drawing.Point(157, 230);
            this.JoinableButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.JoinableButton.Name = "JoinableButton";
            this.JoinableButton.Size = new System.Drawing.Size(32, 35);
            this.JoinableButton.TabIndex = 27;
            this.toolTip1.SetToolTip(this.JoinableButton, "Joinable");
            this.JoinableButton.UseVisualStyleBackColor = true;
            this.JoinableButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // SelectedButton
            // 
            this.SelectedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SelectedButton.Image = global::WindowsViewer.Properties.Resources.Selected;
            this.SelectedButton.Location = new System.Drawing.Point(109, 230);
            this.SelectedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(32, 35);
            this.SelectedButton.TabIndex = 26;
            this.toolTip1.SetToolTip(this.SelectedButton, "Selected");
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // TexturedButton
            // 
            this.TexturedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TexturedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TexturedButton.Image = global::WindowsViewer.Properties.Resources.Textured;
            this.TexturedButton.Location = new System.Drawing.Point(61, 230);
            this.TexturedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TexturedButton.Name = "TexturedButton";
            this.TexturedButton.Size = new System.Drawing.Size(32, 35);
            this.TexturedButton.TabIndex = 25;
            this.toolTip1.SetToolTip(this.TexturedButton, "Textured");
            this.TexturedButton.UseVisualStyleBackColor = true;
            this.TexturedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // StorableButton
            // 
            this.StorableButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.StorableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StorableButton.Image = global::WindowsViewer.Properties.Resources.Storable;
            this.StorableButton.Location = new System.Drawing.Point(13, 230);
            this.StorableButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.StorableButton.Name = "StorableButton";
            this.StorableButton.Size = new System.Drawing.Size(32, 35);
            this.StorableButton.TabIndex = 24;
            this.toolTip1.SetToolTip(this.StorableButton, "Storable");
            this.StorableButton.UseVisualStyleBackColor = true;
            this.StorableButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkZombie
            // 
            this.checkZombie.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkZombie.Image = global::WindowsViewer.Properties.Resources.radioZombie;
            this.checkZombie.Location = new System.Drawing.Point(253, 168);
            this.checkZombie.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkZombie.Name = "checkZombie";
            this.checkZombie.Size = new System.Drawing.Size(32, 35);
            this.checkZombie.TabIndex = 23;
            this.toolTip1.SetToolTip(this.checkZombie, "Zombie");
            this.checkZombie.UseVisualStyleBackColor = true;
            this.checkZombie.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkBrittle
            // 
            this.checkBrittle.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBrittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBrittle.Image = global::WindowsViewer.Properties.Resources.checkBrittle;
            this.checkBrittle.Location = new System.Drawing.Point(205, 168);
            this.checkBrittle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkBrittle.Name = "checkBrittle";
            this.checkBrittle.Size = new System.Drawing.Size(32, 35);
            this.checkBrittle.TabIndex = 22;
            this.toolTip1.SetToolTip(this.checkBrittle, "Brittle");
            this.checkBrittle.UseVisualStyleBackColor = true;
            this.checkBrittle.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkUsers
            // 
            this.checkUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkUsers.Image = global::WindowsViewer.Properties.Resources.checkUsers;
            this.checkUsers.Location = new System.Drawing.Point(157, 168);
            this.checkUsers.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkUsers.Name = "checkUsers";
            this.checkUsers.Size = new System.Drawing.Size(32, 35);
            this.checkUsers.TabIndex = 21;
            this.toolTip1.SetToolTip(this.checkUsers, "User");
            this.checkUsers.UseVisualStyleBackColor = true;
            this.checkUsers.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkHeavy
            // 
            this.checkHeavy.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHeavy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkHeavy.Image = global::WindowsViewer.Properties.Resources.checkHeavy;
            this.checkHeavy.Location = new System.Drawing.Point(109, 168);
            this.checkHeavy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkHeavy.Name = "checkHeavy";
            this.checkHeavy.Size = new System.Drawing.Size(32, 35);
            this.checkHeavy.TabIndex = 20;
            this.toolTip1.SetToolTip(this.checkHeavy, "Dense");
            this.checkHeavy.UseVisualStyleBackColor = true;
            this.checkHeavy.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkLight
            // 
            this.checkLight.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkLight.Image = global::WindowsViewer.Properties.Resources.checkLight;
            this.checkLight.Location = new System.Drawing.Point(61, 168);
            this.checkLight.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkLight.Name = "checkLight";
            this.checkLight.Size = new System.Drawing.Size(32, 35);
            this.checkLight.TabIndex = 19;
            this.toolTip1.SetToolTip(this.checkLight, "Light");
            this.checkLight.UseVisualStyleBackColor = true;
            this.checkLight.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkLink
            // 
            this.checkLink.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkLink.Image = global::WindowsViewer.Properties.Resources.checkLink;
            this.checkLink.Location = new System.Drawing.Point(13, 168);
            this.checkLink.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkLink.Name = "checkLink";
            this.checkLink.Size = new System.Drawing.Size(32, 35);
            this.checkLink.TabIndex = 18;
            this.toolTip1.SetToolTip(this.checkLink, "Linked");
            this.checkLink.UseVisualStyleBackColor = true;
            this.checkLink.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkAxis
            // 
            this.checkAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkAxis.Image = global::WindowsViewer.Properties.Resources.radioAxis1;
            this.checkAxis.Location = new System.Drawing.Point(253, 116);
            this.checkAxis.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkAxis.Name = "checkAxis";
            this.checkAxis.Size = new System.Drawing.Size(32, 35);
            this.checkAxis.TabIndex = 17;
            this.toolTip1.SetToolTip(this.checkAxis, "Axis/Fulcrum");
            this.checkAxis.UseVisualStyleBackColor = true;
            this.checkAxis.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkOut
            // 
            this.checkOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkOut.Image = global::WindowsViewer.Properties.Resources.checkOut;
            this.checkOut.Location = new System.Drawing.Point(205, 116);
            this.checkOut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(32, 35);
            this.checkOut.TabIndex = 16;
            this.toolTip1.SetToolTip(this.checkOut, "Outflow");
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkFlow
            // 
            this.checkFlow.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkFlow.Image = global::WindowsViewer.Properties.Resources.radioFlow;
            this.checkFlow.Location = new System.Drawing.Point(157, 116);
            this.checkFlow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkFlow.Name = "checkFlow";
            this.checkFlow.Size = new System.Drawing.Size(32, 35);
            this.checkFlow.TabIndex = 15;
            this.toolTip1.SetToolTip(this.checkFlow, "Faucet");
            this.checkFlow.UseVisualStyleBackColor = true;
            this.checkFlow.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkCold
            // 
            this.checkCold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkCold.Image = global::WindowsViewer.Properties.Resources.checkCold;
            this.checkCold.Location = new System.Drawing.Point(109, 116);
            this.checkCold.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkCold.Name = "checkCold";
            this.checkCold.Size = new System.Drawing.Size(32, 35);
            this.checkCold.TabIndex = 14;
            this.toolTip1.SetToolTip(this.checkCold, "Cold");
            this.checkCold.UseVisualStyleBackColor = true;
            this.checkCold.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkHot
            // 
            this.checkHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkHot.Image = global::WindowsViewer.Properties.Resources.checkHot;
            this.checkHot.Location = new System.Drawing.Point(61, 116);
            this.checkHot.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkHot.Name = "checkHot";
            this.checkHot.Size = new System.Drawing.Size(32, 35);
            this.checkHot.TabIndex = 13;
            this.toolTip1.SetToolTip(this.checkHot, "Hot");
            this.checkHot.UseVisualStyleBackColor = true;
            this.checkHot.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkGas
            // 
            this.checkGas.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkGas.Image = global::WindowsViewer.Properties.Resources.checkGas;
            this.checkGas.Location = new System.Drawing.Point(13, 116);
            this.checkGas.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkGas.Name = "checkGas";
            this.checkGas.Size = new System.Drawing.Size(32, 35);
            this.checkGas.TabIndex = 12;
            this.toolTip1.SetToolTip(this.checkGas, "Gas");
            this.checkGas.UseVisualStyleBackColor = true;
            this.checkGas.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkRice
            // 
            this.checkRice.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkRice.Image = global::WindowsViewer.Properties.Resources.radioRice;
            this.checkRice.Location = new System.Drawing.Point(253, 64);
            this.checkRice.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkRice.Name = "checkRice";
            this.checkRice.Size = new System.Drawing.Size(32, 35);
            this.checkRice.TabIndex = 11;
            this.toolTip1.SetToolTip(this.checkRice, "Rice");
            this.checkRice.UseVisualStyleBackColor = true;
            this.checkRice.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkVisco
            // 
            this.checkVisco.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkVisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkVisco.Image = global::WindowsViewer.Properties.Resources.checkVisco;
            this.checkVisco.Location = new System.Drawing.Point(205, 64);
            this.checkVisco.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkVisco.Name = "checkVisco";
            this.checkVisco.Size = new System.Drawing.Size(32, 35);
            this.checkVisco.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkVisco, "Viscous");
            this.checkVisco.UseVisualStyleBackColor = true;
            this.checkVisco.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkTensil
            // 
            this.checkTensil.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTensil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkTensil.Image = global::WindowsViewer.Properties.Resources.checkTensil;
            this.checkTensil.Location = new System.Drawing.Point(157, 64);
            this.checkTensil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkTensil.Name = "checkTensil";
            this.checkTensil.Size = new System.Drawing.Size(32, 35);
            this.checkTensil.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkTensil, "Tensile");
            this.checkTensil.UseVisualStyleBackColor = true;
            this.checkTensil.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkFuel
            // 
            this.checkFuel.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkFuel.Image = global::WindowsViewer.Properties.Resources.checkFuel;
            this.checkFuel.Location = new System.Drawing.Point(109, 64);
            this.checkFuel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkFuel.Name = "checkFuel";
            this.checkFuel.Size = new System.Drawing.Size(32, 35);
            this.checkFuel.TabIndex = 8;
            this.toolTip1.SetToolTip(this.checkFuel, "Fuel");
            this.checkFuel.UseVisualStyleBackColor = true;
            this.checkFuel.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkPowder
            // 
            this.checkPowder.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkPowder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkPowder.Image = global::WindowsViewer.Properties.Resources.checkPowder;
            this.checkPowder.Location = new System.Drawing.Point(61, 64);
            this.checkPowder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkPowder.Name = "checkPowder";
            this.checkPowder.Size = new System.Drawing.Size(32, 35);
            this.checkPowder.TabIndex = 7;
            this.toolTip1.SetToolTip(this.checkPowder, "Powder");
            this.checkPowder.UseVisualStyleBackColor = true;
            this.checkPowder.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox12.Image = global::WindowsViewer.Properties.Resources.YukiMaterial;
            this.checkBox12.Location = new System.Drawing.Point(13, 64);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(32, 35);
            this.checkBox12.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox12, "Yuki");
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkMochi
            // 
            this.checkMochi.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkMochi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkMochi.Image = global::WindowsViewer.Properties.Resources.checkMochi;
            this.checkMochi.Location = new System.Drawing.Point(253, 12);
            this.checkMochi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkMochi.Name = "checkMochi";
            this.checkMochi.Size = new System.Drawing.Size(32, 35);
            this.checkMochi.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkMochi, "Mochi");
            this.checkMochi.UseVisualStyleBackColor = true;
            this.checkMochi.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkString
            // 
            this.checkString.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkString.Image = global::WindowsViewer.Properties.Resources.checkString;
            this.checkString.Location = new System.Drawing.Point(205, 12);
            this.checkString.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkString.Name = "checkString";
            this.checkString.Size = new System.Drawing.Size(32, 35);
            this.checkString.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkString, "String");
            this.checkString.UseVisualStyleBackColor = true;
            this.checkString.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkElastic
            // 
            this.checkElastic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkElastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkElastic.Image = global::WindowsViewer.Properties.Resources.checkElastic;
            this.checkElastic.Location = new System.Drawing.Point(157, 12);
            this.checkElastic.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkElastic.Name = "checkElastic";
            this.checkElastic.Size = new System.Drawing.Size(32, 35);
            this.checkElastic.TabIndex = 3;
            this.toolTip1.SetToolTip(this.checkElastic, "Elastic");
            this.checkElastic.UseVisualStyleBackColor = true;
            this.checkElastic.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkSolid
            // 
            this.checkSolid.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkSolid.Image = global::WindowsViewer.Properties.Resources.checkSolid;
            this.checkSolid.Location = new System.Drawing.Point(109, 12);
            this.checkSolid.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkSolid.Name = "checkSolid";
            this.checkSolid.Size = new System.Drawing.Size(32, 35);
            this.checkSolid.TabIndex = 2;
            this.toolTip1.SetToolTip(this.checkSolid, "Rigid");
            this.checkSolid.UseVisualStyleBackColor = true;
            this.checkSolid.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkWall
            // 
            this.checkWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkWall.Image = global::WindowsViewer.Properties.Resources.checkWall;
            this.checkWall.Location = new System.Drawing.Point(61, 12);
            this.checkWall.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkWall.Name = "checkWall";
            this.checkWall.Size = new System.Drawing.Size(32, 35);
            this.checkWall.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkWall, "Wall");
            this.checkWall.UseVisualStyleBackColor = true;
            this.checkWall.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkWater
            // 
            this.checkWater.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkWater.Image = global::WindowsViewer.Properties.Resources.checkWater;
            this.checkWater.Location = new System.Drawing.Point(13, 12);
            this.checkWater.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkWater.Name = "checkWater";
            this.checkWater.Size = new System.Drawing.Size(32, 35);
            this.checkWater.TabIndex = 0;
            this.toolTip1.SetToolTip(this.checkWater, "Water");
            this.checkWater.UseVisualStyleBackColor = true;
            this.checkWater.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxCentralAxle);
            this.tabPage1.Controls.Add(this.radioTextureShape);
            this.tabPage1.Controls.Add(this.radioTriangle);
            this.tabPage1.Controls.Add(this.radioStar);
            this.tabPage1.Controls.Add(this.radioSquare);
            this.tabPage1.Controls.Add(this.radioRectangle);
            this.tabPage1.Controls.Add(this.radioOval);
            this.tabPage1.Controls.Add(this.radioLine);
            this.tabPage1.Controls.Add(this.radioHeart);
            this.tabPage1.Controls.Add(this.radioCircle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 212);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Shapes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCentralAxle
            // 
            this.checkBoxCentralAxle.AutoSize = true;
            this.checkBoxCentralAxle.Location = new System.Drawing.Point(13, 112);
            this.checkBoxCentralAxle.Name = "checkBoxCentralAxle";
            this.checkBoxCentralAxle.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCentralAxle.TabIndex = 31;
            this.checkBoxCentralAxle.Text = "Central Axle";
            this.checkBoxCentralAxle.UseVisualStyleBackColor = true;
            this.checkBoxCentralAxle.CheckedChanged += new System.EventHandler(this.centralAxleCheckBox_Cjamged);
            // 
            // radioTextureShape
            // 
            this.radioTextureShape.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTextureShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioTextureShape.Image = global::WindowsViewer.Properties.Resources.Textured;
            this.radioTextureShape.Location = new System.Drawing.Point(109, 65);
            this.radioTextureShape.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioTextureShape.Name = "radioTextureShape";
            this.radioTextureShape.Size = new System.Drawing.Size(32, 35);
            this.radioTextureShape.TabIndex = 30;
            this.toolTip1.SetToolTip(this.radioTextureShape, "Textured Shape");
            this.radioTextureShape.UseVisualStyleBackColor = true;
            this.radioTextureShape.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioTriangle
            // 
            this.radioTriangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioTriangle.Image = global::WindowsViewer.Properties.Resources.TriangleTool;
            this.radioTriangle.Location = new System.Drawing.Point(61, 65);
            this.radioTriangle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(32, 35);
            this.radioTriangle.TabIndex = 29;
            this.toolTip1.SetToolTip(this.radioTriangle, "Triangle");
            this.radioTriangle.UseVisualStyleBackColor = true;
            this.radioTriangle.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioStar
            // 
            this.radioStar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioStar.Image = global::WindowsViewer.Properties.Resources.StarTool;
            this.radioStar.Location = new System.Drawing.Point(13, 65);
            this.radioStar.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioStar.Name = "radioStar";
            this.radioStar.Size = new System.Drawing.Size(32, 35);
            this.radioStar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.radioStar, "Star");
            this.radioStar.UseVisualStyleBackColor = true;
            this.radioStar.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioSquare
            // 
            this.radioSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSquare.Image = global::WindowsViewer.Properties.Resources.SquareTool;
            this.radioSquare.Location = new System.Drawing.Point(253, 12);
            this.radioSquare.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(32, 35);
            this.radioSquare.TabIndex = 27;
            this.toolTip1.SetToolTip(this.radioSquare, "Square");
            this.radioSquare.UseVisualStyleBackColor = true;
            this.radioSquare.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioRectangle
            // 
            this.radioRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRectangle.Image = global::WindowsViewer.Properties.Resources.RectangleTool;
            this.radioRectangle.Location = new System.Drawing.Point(205, 12);
            this.radioRectangle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(32, 35);
            this.radioRectangle.TabIndex = 26;
            this.toolTip1.SetToolTip(this.radioRectangle, "Rectangle");
            this.radioRectangle.UseVisualStyleBackColor = true;
            this.radioRectangle.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioOval
            // 
            this.radioOval.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOval.Image = global::WindowsViewer.Properties.Resources.OvalTool;
            this.radioOval.Location = new System.Drawing.Point(157, 12);
            this.radioOval.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioOval.Name = "radioOval";
            this.radioOval.Size = new System.Drawing.Size(32, 35);
            this.radioOval.TabIndex = 25;
            this.toolTip1.SetToolTip(this.radioOval, "Oval");
            this.radioOval.UseVisualStyleBackColor = true;
            this.radioOval.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioLine
            // 
            this.radioLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioLine.Image = global::WindowsViewer.Properties.Resources.LineTool;
            this.radioLine.Location = new System.Drawing.Point(109, 12);
            this.radioLine.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(32, 35);
            this.radioLine.TabIndex = 24;
            this.toolTip1.SetToolTip(this.radioLine, "Line");
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioHeart
            // 
            this.radioHeart.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioHeart.Image = global::WindowsViewer.Properties.Resources.HeartTool;
            this.radioHeart.Location = new System.Drawing.Point(61, 12);
            this.radioHeart.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioHeart.Name = "radioHeart";
            this.radioHeart.Size = new System.Drawing.Size(32, 35);
            this.radioHeart.TabIndex = 23;
            this.toolTip1.SetToolTip(this.radioHeart, "Heart");
            this.radioHeart.UseVisualStyleBackColor = true;
            this.radioHeart.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // radioCircle
            // 
            this.radioCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioCircle.Image = global::WindowsViewer.Properties.Resources.CircleTool;
            this.radioCircle.Location = new System.Drawing.Point(13, 12);
            this.radioCircle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(32, 35);
            this.radioCircle.TabIndex = 22;
            this.toolTip1.SetToolTip(this.radioCircle, "Circle");
            this.radioCircle.UseVisualStyleBackColor = true;
            this.radioCircle.CheckedChanged += new System.EventHandler(this.ShapeButton_Changed);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 238);
            this.Controls.Add(this.tabShapes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialForm";
            this.ShowIcon = false;
            this.Text = "Materials & Shapes";
            this.tabShapes.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageCustom.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.TabControl tabShapes;
        private global::System.Windows.Forms.TabPage tabPageBasic;
        private global::System.Windows.Forms.TabPage tabPageCustom;
        private global::System.Windows.Forms.RadioButton radioAqua;
        private global::System.Windows.Forms.RadioButton radioMochi;
        private global::System.Windows.Forms.RadioButton radioTensil;
        private global::System.Windows.Forms.RadioButton radioPowder;
        private global::System.Windows.Forms.RadioButton radioFire;
        private global::System.Windows.Forms.RadioButton radioFuel;
        private global::System.Windows.Forms.RadioButton radioString;
        private global::System.Windows.Forms.RadioButton radioErastic;
        private global::System.Windows.Forms.RadioButton radioRigid;
        private global::System.Windows.Forms.RadioButton radioWall;
        private global::System.Windows.Forms.RadioButton radioZombie;
        private global::System.Windows.Forms.RadioButton radioBrittle;
        private global::System.Windows.Forms.RadioButton radioUsers;
        private global::System.Windows.Forms.RadioButton radioJet;
        private global::System.Windows.Forms.RadioButton radioOil;
        private global::System.Windows.Forms.RadioButton radioBlank0;
        private global::System.Windows.Forms.RadioButton radioAxis;
        private global::System.Windows.Forms.RadioButton radioOut;
        private global::System.Windows.Forms.RadioButton radioFlow;
        private global::System.Windows.Forms.RadioButton radioCold;
        private global::System.Windows.Forms.RadioButton radioHot;
        private global::System.Windows.Forms.RadioButton radioGas;
        private global::System.Windows.Forms.RadioButton radioRice;
        private global::System.Windows.Forms.RadioButton radioVisco;
        private global::System.Windows.Forms.CheckBox checkWater;
        private global::System.Windows.Forms.CheckBox checkMochi;
        private global::System.Windows.Forms.CheckBox checkString;
        private global::System.Windows.Forms.CheckBox checkElastic;
        private global::System.Windows.Forms.CheckBox checkSolid;
        private global::System.Windows.Forms.CheckBox checkWall;
        private global::System.Windows.Forms.CheckBox checkZombie;
        private global::System.Windows.Forms.CheckBox checkBrittle;
        private global::System.Windows.Forms.CheckBox checkUsers;
        private global::System.Windows.Forms.CheckBox checkHeavy;
        private global::System.Windows.Forms.CheckBox checkLight;
        private global::System.Windows.Forms.CheckBox checkLink;
        private global::System.Windows.Forms.CheckBox checkAxis;
        private global::System.Windows.Forms.CheckBox checkOut;
        private global::System.Windows.Forms.CheckBox checkFlow;
        private global::System.Windows.Forms.CheckBox checkCold;
        private global::System.Windows.Forms.CheckBox checkHot;
        private global::System.Windows.Forms.CheckBox checkGas;
        private global::System.Windows.Forms.CheckBox checkRice;
        private global::System.Windows.Forms.CheckBox checkVisco;
        private global::System.Windows.Forms.CheckBox checkTensil;
        private global::System.Windows.Forms.CheckBox checkFuel;
        private global::System.Windows.Forms.CheckBox checkPowder;
        private global::System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox StorableButton;
        private System.Windows.Forms.CheckBox NoneButton;
        private System.Windows.Forms.CheckBox ReservedButton;
        private System.Windows.Forms.CheckBox AirButton;
        private System.Windows.Forms.CheckBox JetButton;
        private System.Windows.Forms.CheckBox NaturalButton;
        private System.Windows.Forms.CheckBox JoinableButton;
        private System.Windows.Forms.CheckBox SelectedButton;
        private System.Windows.Forms.CheckBox TexturedButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioSquare;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioOval;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioHeart;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioTriangle;
        private System.Windows.Forms.RadioButton radioStar;
        private System.Windows.Forms.RadioButton radioTextureShape;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxCentralAxle;
    }
}
