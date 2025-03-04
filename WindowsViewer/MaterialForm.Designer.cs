﻿namespace WindowsViewer
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
            this.tabMaterials = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.radioBlank1 = new System.Windows.Forms.RadioButton();
            this.radioBlank0 = new System.Windows.Forms.RadioButton();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.radioZombie = new System.Windows.Forms.RadioButton();
            this.radioBrittle = new System.Windows.Forms.RadioButton();
            this.radioUsers = new System.Windows.Forms.RadioButton();
            this.radioOil = new System.Windows.Forms.RadioButton();
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
            this.checkMochi = new System.Windows.Forms.CheckBox();
            this.checkString = new System.Windows.Forms.CheckBox();
            this.checkElastic = new System.Windows.Forms.CheckBox();
            this.checkSolid = new System.Windows.Forms.CheckBox();
            this.checkWall = new System.Windows.Forms.CheckBox();
            this.checkWater = new System.Windows.Forms.CheckBox();
            this.tabMaterials.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            this.tabPageCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMaterials
            // 
            this.tabMaterials.Controls.Add(this.tabPageBasic);
            this.tabMaterials.Controls.Add(this.tabPageCustom);
            this.tabMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMaterials.Location = new System.Drawing.Point(0, 0);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.SelectedIndex = 0;
            this.tabMaterials.Size = new System.Drawing.Size(308, 248);
            this.tabMaterials.TabIndex = 0;
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.Controls.Add(this.radioZombie);
            this.tabPageBasic.Controls.Add(this.radioBrittle);
            this.tabPageBasic.Controls.Add(this.radioUsers);
            this.tabPageBasic.Controls.Add(this.radioBlank1);
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
            this.tabPageBasic.Size = new System.Drawing.Size(300, 222);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Basic";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // radioBlank1
            // 
            this.radioBlank1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBlank1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBlank1.Enabled = false;
            this.radioBlank1.Location = new System.Drawing.Point(109, 168);
            this.radioBlank1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBlank1.Name = "radioBlank1";
            this.radioBlank1.Size = new System.Drawing.Size(32, 35);
            this.radioBlank1.TabIndex = 21;
            this.radioBlank1.UseVisualStyleBackColor = true;
            this.radioBlank1.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
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
            this.radioBlank0.UseVisualStyleBackColor = true;
            this.radioBlank0.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // tabPageCustom
            // 
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
            this.tabPageCustom.Size = new System.Drawing.Size(300, 222);
            this.tabPageCustom.TabIndex = 1;
            this.tabPageCustom.Text = "Custom";
            this.tabPageCustom.UseVisualStyleBackColor = true;
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
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
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
            this.radioOil.UseVisualStyleBackColor = true;
            this.radioOil.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
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
            this.radioMochi.TabIndex = 10;
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
            this.radioTensil.TabIndex = 9;
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
            this.radioFuel.TabIndex = 6;
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
            this.radioAqua.UseVisualStyleBackColor = true;
            this.radioAqua.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
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
            this.checkPowder.UseVisualStyleBackColor = true;
            this.checkPowder.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            this.checkWater.UseVisualStyleBackColor = true;
            this.checkWater.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 248);
            this.Controls.Add(this.tabMaterials);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialForm";
            this.ShowIcon = false;
            this.Text = "Materials";
            this.tabMaterials.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.TabControl tabMaterials;
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
        private global::System.Windows.Forms.RadioButton radioBlank1;
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
    }
}
