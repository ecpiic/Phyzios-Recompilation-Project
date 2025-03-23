namespace WindowsViewer
{
    public partial class PropertyForm : global::System.Windows.Forms.Form
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
            this.groupScene = new System.Windows.Forms.GroupBox();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxSceneDescription = new System.Windows.Forms.TextBox();
            this.textBoxSceneTitle = new System.Windows.Forms.TextBox();
            this.checkBoxPublish = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.btnSizeApply = new System.Windows.Forms.Button();
            this.textBoxParticleSize = new System.Windows.Forms.TextBox();
            this.textBoxSceneHeight = new System.Windows.Forms.TextBox();
            this.textBoxSceneWidth = new System.Windows.Forms.TextBox();
            this.btnSizeDefault = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPixelsH = new System.Windows.Forms.ComboBox();
            this.comboBoxPixelsW = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBubbleEffect = new System.Windows.Forms.CheckBox();
            this.checkSplashEffect = new System.Windows.Forms.CheckBox();
            this.checkFireEffect = new System.Windows.Forms.CheckBox();
            this.checkToolLimit = new System.Windows.Forms.CheckBox();
            this.checkSound = new System.Windows.Forms.CheckBox();
            this.checkBoundsWall = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGravityAngle = new System.Windows.Forms.TextBox();
            this.trackBarGravityAngle = new System.Windows.Forms.TrackBar();
            this.textBoxGravityAcc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackGravityAcc = new System.Windows.Forms.TrackBar();
            this.checkGravity = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxBScrollY = new System.Windows.Forms.TextBox();
            this.textBoxBScrollX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFScrollY = new System.Windows.Forms.TextBox();
            this.textBoxFScrollX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAScrollY = new System.Windows.Forms.TextBox();
            this.textBoxAScrollX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkSleepOOV = new System.Windows.Forms.CheckBox();
            this.checkWorldBounds = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWorldY1 = new System.Windows.Forms.TextBox();
            this.textBoxWorldX1 = new System.Windows.Forms.TextBox();
            this.textBoxWorldY0 = new System.Windows.Forms.TextBox();
            this.textBoxWorldX0 = new System.Windows.Forms.TextBox();
            this.textBoxViewY1 = new System.Windows.Forms.TextBox();
            this.textBoxViewX1 = new System.Windows.Forms.TextBox();
            this.textBoxViewY0 = new System.Windows.Forms.TextBox();
            this.textBoxViewX0 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBGColor = new System.Windows.Forms.Button();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxBubbleTexture = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxSplashTexture = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxFireTexture = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxWaterTexture = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxBackTexture = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxForeTexture = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.colorDialogBGColor = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxTargetFPS = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonUpdateMisc = new System.Windows.Forms.Button();
            this.groupScene.SuspendLayout();
            this.groupSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGravityAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGravityAcc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupScene
            // 
            this.groupScene.Controls.Add(this.textBoxTags);
            this.groupScene.Controls.Add(this.label22);
            this.groupScene.Controls.Add(this.textBoxSceneDescription);
            this.groupScene.Controls.Add(this.textBoxSceneTitle);
            this.groupScene.Controls.Add(this.checkBoxPublish);
            this.groupScene.Controls.Add(this.label2);
            this.groupScene.Controls.Add(this.label1);
            this.groupScene.Location = new System.Drawing.Point(12, 13);
            this.groupScene.Name = "groupScene";
            this.groupScene.Size = new System.Drawing.Size(352, 218);
            this.groupScene.TabIndex = 0;
            this.groupScene.TabStop = false;
            this.groupScene.Text = "Scene";
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(92, 72);
            this.textBoxTags.MaxLength = 310;
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(245, 20);
            this.textBoxTags.TabIndex = 6;
            this.textBoxTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxTags.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Tags:";
            // 
            // textBoxSceneDescription
            // 
            this.textBoxSceneDescription.Location = new System.Drawing.Point(91, 109);
            this.textBoxSceneDescription.MaxLength = 500;
            this.textBoxSceneDescription.Multiline = true;
            this.textBoxSceneDescription.Name = "textBoxSceneDescription";
            this.textBoxSceneDescription.Size = new System.Drawing.Size(245, 54);
            this.textBoxSceneDescription.TabIndex = 4;
            this.textBoxSceneDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxSceneDescription.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxSceneTitle
            // 
            this.textBoxSceneTitle.Location = new System.Drawing.Point(91, 35);
            this.textBoxSceneTitle.MaxLength = 24;
            this.textBoxSceneTitle.Name = "textBoxSceneTitle";
            this.textBoxSceneTitle.Size = new System.Drawing.Size(245, 20);
            this.textBoxSceneTitle.TabIndex = 3;
            this.textBoxSceneTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxSceneTitle.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // checkBoxPublish
            // 
            this.checkBoxPublish.AutoSize = true;
            this.checkBoxPublish.Location = new System.Drawing.Point(25, 183);
            this.checkBoxPublish.Name = "checkBoxPublish";
            this.checkBoxPublish.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPublish.TabIndex = 2;
            this.checkBoxPublish.Text = "Publish";
            this.checkBoxPublish.UseVisualStyleBackColor = true;
            this.checkBoxPublish.CheckedChanged += new System.EventHandler(this.checkBoxPublish_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.btnSizeApply);
            this.groupSize.Controls.Add(this.textBoxParticleSize);
            this.groupSize.Controls.Add(this.textBoxSceneHeight);
            this.groupSize.Controls.Add(this.textBoxSceneWidth);
            this.groupSize.Controls.Add(this.btnSizeDefault);
            this.groupSize.Controls.Add(this.label6);
            this.groupSize.Controls.Add(this.comboBoxPixelsH);
            this.groupSize.Controls.Add(this.comboBoxPixelsW);
            this.groupSize.Controls.Add(this.label5);
            this.groupSize.Controls.Add(this.label4);
            this.groupSize.Controls.Add(this.label3);
            this.groupSize.Location = new System.Drawing.Point(12, 237);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(352, 180);
            this.groupSize.TabIndex = 1;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Size";
            // 
            // btnSizeApply
            // 
            this.btnSizeApply.Location = new System.Drawing.Point(180, 148);
            this.btnSizeApply.Name = "btnSizeApply";
            this.btnSizeApply.Size = new System.Drawing.Size(75, 25);
            this.btnSizeApply.TabIndex = 13;
            this.btnSizeApply.Text = "Apply";
            this.btnSizeApply.UseVisualStyleBackColor = true;
            this.btnSizeApply.Click += new System.EventHandler(this.btnSizeApply_Click);
            // 
            // textBoxParticleSize
            // 
            this.textBoxParticleSize.Location = new System.Drawing.Point(144, 103);
            this.textBoxParticleSize.Name = "textBoxParticleSize";
            this.textBoxParticleSize.Size = new System.Drawing.Size(107, 20);
            this.textBoxParticleSize.TabIndex = 12;
            this.textBoxParticleSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxParticleSize.DragLeave += new System.EventHandler(this.textBoxSceneWidth_DragLeave);
            this.textBoxParticleSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneWidth_KeyDown);
            // 
            // textBoxSceneHeight
            // 
            this.textBoxSceneHeight.Location = new System.Drawing.Point(144, 66);
            this.textBoxSceneHeight.Name = "textBoxSceneHeight";
            this.textBoxSceneHeight.Size = new System.Drawing.Size(107, 20);
            this.textBoxSceneHeight.TabIndex = 11;
            this.textBoxSceneHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSceneHeight.DragLeave += new System.EventHandler(this.textBoxSceneWidth_DragLeave);
            this.textBoxSceneHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneWidth_KeyDown);
            // 
            // textBoxSceneWidth
            // 
            this.textBoxSceneWidth.Location = new System.Drawing.Point(144, 29);
            this.textBoxSceneWidth.Name = "textBoxSceneWidth";
            this.textBoxSceneWidth.Size = new System.Drawing.Size(107, 20);
            this.textBoxSceneWidth.TabIndex = 10;
            this.textBoxSceneWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSceneWidth.DragLeave += new System.EventHandler(this.textBoxSceneWidth_DragLeave);
            this.textBoxSceneWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneWidth_KeyDown);
            // 
            // btnSizeDefault
            // 
            this.btnSizeDefault.Location = new System.Drawing.Point(261, 148);
            this.btnSizeDefault.Name = "btnSizeDefault";
            this.btnSizeDefault.Size = new System.Drawing.Size(75, 25);
            this.btnSizeDefault.TabIndex = 9;
            this.btnSizeDefault.Text = "Default";
            this.btnSizeDefault.UseVisualStyleBackColor = true;
            this.btnSizeDefault.Click += new System.EventHandler(this.btnSizeDefault_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pixels";
            // 
            // comboBoxPixelsH
            // 
            this.comboBoxPixelsH.FormattingEnabled = true;
            this.comboBoxPixelsH.Items.AddRange(new object[] {
            "Pixels",
            "Particles"});
            this.comboBoxPixelsH.Location = new System.Drawing.Point(263, 66);
            this.comboBoxPixelsH.Name = "comboBoxPixelsH";
            this.comboBoxPixelsH.Size = new System.Drawing.Size(73, 21);
            this.comboBoxPixelsH.TabIndex = 7;
            this.comboBoxPixelsH.Text = "Pixels";
            this.comboBoxPixelsH.SelectedIndexChanged += new System.EventHandler(this.comboBoxPixelsW_SelectedIndexChanged);
            // 
            // comboBoxPixelsW
            // 
            this.comboBoxPixelsW.FormattingEnabled = true;
            this.comboBoxPixelsW.Items.AddRange(new object[] {
            "Pixels",
            "Particles"});
            this.comboBoxPixelsW.Location = new System.Drawing.Point(263, 29);
            this.comboBoxPixelsW.Name = "comboBoxPixelsW";
            this.comboBoxPixelsW.Size = new System.Drawing.Size(73, 21);
            this.comboBoxPixelsW.TabIndex = 6;
            this.comboBoxPixelsW.Text = "Pixels";
            this.comboBoxPixelsW.SelectedIndexChanged += new System.EventHandler(this.comboBoxPixelsW_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Particle Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBubbleEffect);
            this.groupBox1.Controls.Add(this.checkSplashEffect);
            this.groupBox1.Controls.Add(this.checkFireEffect);
            this.groupBox1.Controls.Add(this.checkToolLimit);
            this.groupBox1.Controls.Add(this.checkSound);
            this.groupBox1.Controls.Add(this.checkBoundsWall);
            this.groupBox1.Location = new System.Drawing.Point(12, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Models";
            // 
            // checkBubbleEffect
            // 
            this.checkBubbleEffect.AutoSize = true;
            this.checkBubbleEffect.Location = new System.Drawing.Point(197, 105);
            this.checkBubbleEffect.Name = "checkBubbleEffect";
            this.checkBubbleEffect.Size = new System.Drawing.Size(90, 17);
            this.checkBubbleEffect.TabIndex = 5;
            this.checkBubbleEffect.Text = "Bubble Effect";
            this.checkBubbleEffect.UseVisualStyleBackColor = true;
            this.checkBubbleEffect.CheckedChanged += new System.EventHandler(this.checkBubbleEffect_CheckedChanged);
            // 
            // checkSplashEffect
            // 
            this.checkSplashEffect.AutoSize = true;
            this.checkSplashEffect.Location = new System.Drawing.Point(197, 69);
            this.checkSplashEffect.Name = "checkSplashEffect";
            this.checkSplashEffect.Size = new System.Drawing.Size(89, 17);
            this.checkSplashEffect.TabIndex = 4;
            this.checkSplashEffect.Text = "Splash Effect";
            this.checkSplashEffect.UseVisualStyleBackColor = true;
            this.checkSplashEffect.CheckedChanged += new System.EventHandler(this.checkSplashEffect_CheckedChanged);
            // 
            // checkFireEffect
            // 
            this.checkFireEffect.AutoSize = true;
            this.checkFireEffect.Location = new System.Drawing.Point(197, 32);
            this.checkFireEffect.Name = "checkFireEffect";
            this.checkFireEffect.Size = new System.Drawing.Size(74, 17);
            this.checkFireEffect.TabIndex = 3;
            this.checkFireEffect.Text = "Fire Effect";
            this.checkFireEffect.UseVisualStyleBackColor = true;
            this.checkFireEffect.CheckedChanged += new System.EventHandler(this.checkFireEffect_CheckedChanged);
            // 
            // checkToolLimit
            // 
            this.checkToolLimit.AutoSize = true;
            this.checkToolLimit.Location = new System.Drawing.Point(25, 105);
            this.checkToolLimit.Name = "checkToolLimit";
            this.checkToolLimit.Size = new System.Drawing.Size(71, 17);
            this.checkToolLimit.TabIndex = 2;
            this.checkToolLimit.Text = "Tool Limit";
            this.checkToolLimit.UseVisualStyleBackColor = true;
            this.checkToolLimit.CheckedChanged += new System.EventHandler(this.checkToolLimit_CheckedChanged);
            // 
            // checkSound
            // 
            this.checkSound.AutoSize = true;
            this.checkSound.Location = new System.Drawing.Point(25, 69);
            this.checkSound.Name = "checkSound";
            this.checkSound.Size = new System.Drawing.Size(57, 17);
            this.checkSound.TabIndex = 1;
            this.checkSound.Text = "Sound";
            this.checkSound.UseVisualStyleBackColor = true;
            this.checkSound.CheckedChanged += new System.EventHandler(this.checkSound_CheckedChanged);
            // 
            // checkBoundsWall
            // 
            this.checkBoundsWall.AutoSize = true;
            this.checkBoundsWall.Location = new System.Drawing.Point(25, 32);
            this.checkBoundsWall.Name = "checkBoundsWall";
            this.checkBoundsWall.Size = new System.Drawing.Size(83, 17);
            this.checkBoundsWall.TabIndex = 0;
            this.checkBoundsWall.Text = "BoundsWall";
            this.checkBoundsWall.UseVisualStyleBackColor = true;
            this.checkBoundsWall.CheckedChanged += new System.EventHandler(this.checkBoundsWall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxGravityAngle);
            this.groupBox2.Controls.Add(this.trackBarGravityAngle);
            this.groupBox2.Controls.Add(this.textBoxGravityAcc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.trackGravityAcc);
            this.groupBox2.Controls.Add(this.checkGravity);
            this.groupBox2.Location = new System.Drawing.Point(12, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gravity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Angle:";
            // 
            // textBoxGravityAngle
            // 
            this.textBoxGravityAngle.Location = new System.Drawing.Point(280, 101);
            this.textBoxGravityAngle.Name = "textBoxGravityAngle";
            this.textBoxGravityAngle.Size = new System.Drawing.Size(56, 20);
            this.textBoxGravityAngle.TabIndex = 5;
            this.textBoxGravityAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGravityAngle_KeyDown);
            this.textBoxGravityAngle.Leave += new System.EventHandler(this.textBoxGravityAngle_Leave);
            // 
            // trackBarGravityAngle
            // 
            this.trackBarGravityAngle.Location = new System.Drawing.Point(114, 91);
            this.trackBarGravityAngle.Maximum = 180;
            this.trackBarGravityAngle.Minimum = -180;
            this.trackBarGravityAngle.Name = "trackBarGravityAngle";
            this.trackBarGravityAngle.Size = new System.Drawing.Size(160, 45);
            this.trackBarGravityAngle.TabIndex = 4;
            this.trackBarGravityAngle.TickFrequency = 10;
            this.trackBarGravityAngle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGravityAngle.Scroll += new System.EventHandler(this.trackBarGravityAngle_Scroll);
            // 
            // textBoxGravityAcc
            // 
            this.textBoxGravityAcc.Location = new System.Drawing.Point(280, 52);
            this.textBoxGravityAcc.Name = "textBoxGravityAcc";
            this.textBoxGravityAcc.Size = new System.Drawing.Size(56, 20);
            this.textBoxGravityAcc.TabIndex = 3;
            this.textBoxGravityAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGravityAcc_KeyDown);
            this.textBoxGravityAcc.Leave += new System.EventHandler(this.textBoxGravityAcc_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Acceleration:";
            // 
            // trackGravityAcc
            // 
            this.trackGravityAcc.Location = new System.Drawing.Point(114, 39);
            this.trackGravityAcc.Maximum = 100;
            this.trackGravityAcc.Name = "trackGravityAcc";
            this.trackGravityAcc.Size = new System.Drawing.Size(160, 45);
            this.trackGravityAcc.TabIndex = 1;
            this.trackGravityAcc.TickFrequency = 10;
            this.trackGravityAcc.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackGravityAcc.Scroll += new System.EventHandler(this.trackGravityAcc_Scroll);
            // 
            // checkGravity
            // 
            this.checkGravity.AutoSize = true;
            this.checkGravity.Location = new System.Drawing.Point(25, 20);
            this.checkGravity.Name = "checkGravity";
            this.checkGravity.Size = new System.Drawing.Size(59, 17);
            this.checkGravity.TabIndex = 0;
            this.checkGravity.Text = "Gravity";
            this.checkGravity.UseVisualStyleBackColor = true;
            this.checkGravity.CheckedChanged += new System.EventHandler(this.checkGravity_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxBScrollY);
            this.groupBox3.Controls.Add(this.textBoxBScrollX);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxFScrollY);
            this.groupBox3.Controls.Add(this.textBoxFScrollX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxAScrollY);
            this.groupBox3.Controls.Add(this.textBoxAScrollX);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.checkSleepOOV);
            this.groupBox3.Controls.Add(this.checkWorldBounds);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxWorldY1);
            this.groupBox3.Controls.Add(this.textBoxWorldX1);
            this.groupBox3.Controls.Add(this.textBoxWorldY0);
            this.groupBox3.Controls.Add(this.textBoxWorldX0);
            this.groupBox3.Controls.Add(this.textBoxViewY1);
            this.groupBox3.Controls.Add(this.textBoxViewX1);
            this.groupBox3.Controls.Add(this.textBoxViewY0);
            this.groupBox3.Controls.Add(this.textBoxViewX0);
            this.groupBox3.Location = new System.Drawing.Point(13, 744);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 233);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scroll";
            // 
            // textBoxBScrollY
            // 
            this.textBoxBScrollY.Location = new System.Drawing.Point(244, 193);
            this.textBoxBScrollY.Name = "textBoxBScrollY";
            this.textBoxBScrollY.Size = new System.Drawing.Size(92, 20);
            this.textBoxBScrollY.TabIndex = 20;
            this.textBoxBScrollY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxBScrollY.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxBScrollX
            // 
            this.textBoxBScrollX.Location = new System.Drawing.Point(144, 193);
            this.textBoxBScrollX.Name = "textBoxBScrollX";
            this.textBoxBScrollX.Size = new System.Drawing.Size(92, 20);
            this.textBoxBScrollX.TabIndex = 19;
            this.textBoxBScrollX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxBScrollX.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Background:";
            // 
            // textBoxFScrollY
            // 
            this.textBoxFScrollY.Location = new System.Drawing.Point(244, 166);
            this.textBoxFScrollY.Name = "textBoxFScrollY";
            this.textBoxFScrollY.Size = new System.Drawing.Size(92, 20);
            this.textBoxFScrollY.TabIndex = 17;
            this.textBoxFScrollY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxFScrollY.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxFScrollX
            // 
            this.textBoxFScrollX.Location = new System.Drawing.Point(144, 166);
            this.textBoxFScrollX.Name = "textBoxFScrollX";
            this.textBoxFScrollX.Size = new System.Drawing.Size(92, 20);
            this.textBoxFScrollX.TabIndex = 16;
            this.textBoxFScrollX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxFScrollX.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Foreground:";
            // 
            // textBoxAScrollY
            // 
            this.textBoxAScrollY.Location = new System.Drawing.Point(244, 139);
            this.textBoxAScrollY.Name = "textBoxAScrollY";
            this.textBoxAScrollY.Size = new System.Drawing.Size(92, 20);
            this.textBoxAScrollY.TabIndex = 14;
            this.textBoxAScrollY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxAScrollY.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxAScrollX
            // 
            this.textBoxAScrollX.Location = new System.Drawing.Point(144, 139);
            this.textBoxAScrollX.Name = "textBoxAScrollX";
            this.textBoxAScrollX.Size = new System.Drawing.Size(92, 20);
            this.textBoxAScrollX.TabIndex = 13;
            this.textBoxAScrollX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxAScrollX.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Autoscroll:";
            // 
            // checkSleepOOV
            // 
            this.checkSleepOOV.AutoSize = true;
            this.checkSleepOOV.Location = new System.Drawing.Point(150, 62);
            this.checkSleepOOV.Name = "checkSleepOOV";
            this.checkSleepOOV.Size = new System.Drawing.Size(130, 17);
            this.checkSleepOOV.TabIndex = 11;
            this.checkSleepOOV.Text = "Sleep Outside of View";
            this.checkSleepOOV.UseVisualStyleBackColor = true;
            this.checkSleepOOV.CheckedChanged += new System.EventHandler(this.checkSleepOOV_CheckedChanged);
            // 
            // checkWorldBounds
            // 
            this.checkWorldBounds.AutoSize = true;
            this.checkWorldBounds.Location = new System.Drawing.Point(25, 62);
            this.checkWorldBounds.Name = "checkWorldBounds";
            this.checkWorldBounds.Size = new System.Drawing.Size(93, 17);
            this.checkWorldBounds.TabIndex = 10;
            this.checkWorldBounds.Text = "World Bounds";
            this.checkWorldBounds.UseVisualStyleBackColor = true;
            this.checkWorldBounds.CheckedChanged += new System.EventHandler(this.checkWorldBounds_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "World:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "View:";
            // 
            // textBoxWorldY1
            // 
            this.textBoxWorldY1.Location = new System.Drawing.Point(278, 86);
            this.textBoxWorldY1.Name = "textBoxWorldY1";
            this.textBoxWorldY1.Size = new System.Drawing.Size(58, 20);
            this.textBoxWorldY1.TabIndex = 7;
            this.textBoxWorldY1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxWorldY1.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxWorldX1
            // 
            this.textBoxWorldX1.Location = new System.Drawing.Point(214, 86);
            this.textBoxWorldX1.Name = "textBoxWorldX1";
            this.textBoxWorldX1.Size = new System.Drawing.Size(58, 20);
            this.textBoxWorldX1.TabIndex = 6;
            this.textBoxWorldX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxWorldX1.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxWorldY0
            // 
            this.textBoxWorldY0.Location = new System.Drawing.Point(150, 86);
            this.textBoxWorldY0.Name = "textBoxWorldY0";
            this.textBoxWorldY0.Size = new System.Drawing.Size(58, 20);
            this.textBoxWorldY0.TabIndex = 5;
            this.textBoxWorldY0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxWorldY0.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxWorldX0
            // 
            this.textBoxWorldX0.Location = new System.Drawing.Point(86, 86);
            this.textBoxWorldX0.Name = "textBoxWorldX0";
            this.textBoxWorldX0.Size = new System.Drawing.Size(58, 20);
            this.textBoxWorldX0.TabIndex = 4;
            this.textBoxWorldX0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxWorldX0.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxViewY1
            // 
            this.textBoxViewY1.Location = new System.Drawing.Point(278, 20);
            this.textBoxViewY1.Name = "textBoxViewY1";
            this.textBoxViewY1.Size = new System.Drawing.Size(58, 20);
            this.textBoxViewY1.TabIndex = 3;
            this.textBoxViewY1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxViewY1.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxViewX1
            // 
            this.textBoxViewX1.Location = new System.Drawing.Point(214, 20);
            this.textBoxViewX1.Name = "textBoxViewX1";
            this.textBoxViewX1.Size = new System.Drawing.Size(58, 20);
            this.textBoxViewX1.TabIndex = 2;
            this.textBoxViewX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxViewX1.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxViewY0
            // 
            this.textBoxViewY0.Location = new System.Drawing.Point(150, 20);
            this.textBoxViewY0.Name = "textBoxViewY0";
            this.textBoxViewY0.Size = new System.Drawing.Size(58, 20);
            this.textBoxViewY0.TabIndex = 1;
            this.textBoxViewY0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxViewY0.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // textBoxViewX0
            // 
            this.textBoxViewX0.Location = new System.Drawing.Point(86, 20);
            this.textBoxViewX0.Name = "textBoxViewX0";
            this.textBoxViewX0.Size = new System.Drawing.Size(58, 20);
            this.textBoxViewX0.TabIndex = 0;
            this.textBoxViewX0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSceneTitle_KeyDown);
            this.textBoxViewX0.Leave += new System.EventHandler(this.textBoxSceneTitle_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnBGColor);
            this.groupBox4.Controls.Add(this.comboBoxStyle);
            this.groupBox4.Location = new System.Drawing.Point(14, 984);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 108);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rendering";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Background Color";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Style:";
            // 
            // btnBGColor
            // 
            this.btnBGColor.Location = new System.Drawing.Point(143, 67);
            this.btnBGColor.Name = "btnBGColor";
            this.btnBGColor.Size = new System.Drawing.Size(75, 25);
            this.btnBGColor.TabIndex = 1;
            this.btnBGColor.UseVisualStyleBackColor = true;
            this.btnBGColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBGColor_MouseClick);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Points",
            "Crosses",
            "Circles",
            "Blured",
            "Contour",
            "Textured"});
            this.comboBoxStyle.Location = new System.Drawing.Point(143, 20);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(192, 21);
            this.comboBoxStyle.TabIndex = 0;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxBubbleTexture);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.comboBoxSplashTexture);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.comboBoxFireTexture);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.comboBoxWaterTexture);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.comboBoxBackTexture);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.comboBoxForeTexture);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(14, 1098);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 229);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Images";
            // 
            // comboBoxBubbleTexture
            // 
            this.comboBoxBubbleTexture.FormattingEnabled = true;
            this.comboBoxBubbleTexture.Location = new System.Drawing.Point(112, 174);
            this.comboBoxBubbleTexture.Name = "comboBoxBubbleTexture";
            this.comboBoxBubbleTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxBubbleTexture.TabIndex = 11;
            this.comboBoxBubbleTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxBubbleTexture_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Bubble:";
            // 
            // comboBoxSplashTexture
            // 
            this.comboBoxSplashTexture.FormattingEnabled = true;
            this.comboBoxSplashTexture.Location = new System.Drawing.Point(112, 146);
            this.comboBoxSplashTexture.Name = "comboBoxSplashTexture";
            this.comboBoxSplashTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxSplashTexture.TabIndex = 9;
            this.comboBoxSplashTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxSplashTexture_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Splash:";
            // 
            // comboBoxFireTexture
            // 
            this.comboBoxFireTexture.FormattingEnabled = true;
            this.comboBoxFireTexture.Location = new System.Drawing.Point(112, 118);
            this.comboBoxFireTexture.Name = "comboBoxFireTexture";
            this.comboBoxFireTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxFireTexture.TabIndex = 7;
            this.comboBoxFireTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxFireTexture_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Fire:";
            // 
            // comboBoxWaterTexture
            // 
            this.comboBoxWaterTexture.FormattingEnabled = true;
            this.comboBoxWaterTexture.Location = new System.Drawing.Point(112, 90);
            this.comboBoxWaterTexture.Name = "comboBoxWaterTexture";
            this.comboBoxWaterTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxWaterTexture.TabIndex = 5;
            this.comboBoxWaterTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaterTexture_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Watermark:";
            // 
            // comboBoxBackTexture
            // 
            this.comboBoxBackTexture.FormattingEnabled = true;
            this.comboBoxBackTexture.Location = new System.Drawing.Point(112, 62);
            this.comboBoxBackTexture.Name = "comboBoxBackTexture";
            this.comboBoxBackTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxBackTexture.TabIndex = 3;
            this.comboBoxBackTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackTexture_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Background:";
            // 
            // comboBoxForeTexture
            // 
            this.comboBoxForeTexture.FormattingEnabled = true;
            this.comboBoxForeTexture.Location = new System.Drawing.Point(112, 34);
            this.comboBoxForeTexture.Name = "comboBoxForeTexture";
            this.comboBoxForeTexture.Size = new System.Drawing.Size(222, 21);
            this.comboBoxForeTexture.TabIndex = 1;
            this.comboBoxForeTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxForeTexture_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Foreground:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonUpdateMisc);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.textBoxTargetFPS);
            this.groupBox6.Location = new System.Drawing.Point(14, 1333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 100);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Miscellaneous";
            // 
            // textBoxTargetFPS
            // 
            this.textBoxTargetFPS.Location = new System.Drawing.Point(204, 23);
            this.textBoxTargetFPS.Name = "textBoxTargetFPS";
            this.textBoxTargetFPS.Size = new System.Drawing.Size(100, 20);
            this.textBoxTargetFPS.TabIndex = 0;
            this.textBoxTargetFPS.Text = "30";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(177, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "panelOECMain.TimerMain.Interval =";
            // 
            // buttonUpdateMisc
            // 
            this.buttonUpdateMisc.Location = new System.Drawing.Point(269, 71);
            this.buttonUpdateMisc.Name = "buttonUpdateMisc";
            this.buttonUpdateMisc.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMisc.TabIndex = 2;
            this.buttonUpdateMisc.Text = "Update";
            this.buttonUpdateMisc.UseVisualStyleBackColor = true;
            this.buttonUpdateMisc.Click += new System.EventHandler(this.buttonUpdateMisc_Click);
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(407, 565);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.groupScene);
            this.Name = "PropertyForm";
            this.Text = "Property";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropertyForm_FormClosing);
            this.groupScene.ResumeLayout(false);
            this.groupScene.PerformLayout();
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGravityAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGravityAcc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.GroupBox groupScene;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox textBoxSceneDescription;
        private global::System.Windows.Forms.TextBox textBoxSceneTitle;
        private global::System.Windows.Forms.CheckBox checkBoxPublish;
        private global::System.Windows.Forms.GroupBox groupSize;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Button btnSizeDefault;
        private global::System.Windows.Forms.Label label6;
        private global::System.Windows.Forms.ComboBox comboBoxPixelsH;
        private global::System.Windows.Forms.ComboBox comboBoxPixelsW;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.CheckBox checkBubbleEffect;
        private global::System.Windows.Forms.CheckBox checkSplashEffect;
        private global::System.Windows.Forms.CheckBox checkFireEffect;
        private global::System.Windows.Forms.CheckBox checkToolLimit;
        private global::System.Windows.Forms.CheckBox checkSound;
        private global::System.Windows.Forms.CheckBox checkBoundsWall;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.TrackBar trackGravityAcc;
        private global::System.Windows.Forms.CheckBox checkGravity;
        private global::System.Windows.Forms.Label label8;
        private global::System.Windows.Forms.TextBox textBoxGravityAngle;
        private global::System.Windows.Forms.TrackBar trackBarGravityAngle;
        private global::System.Windows.Forms.TextBox textBoxGravityAcc;
        private global::System.Windows.Forms.Label label7;
        private global::System.Windows.Forms.GroupBox groupBox3;
        private global::System.Windows.Forms.GroupBox groupBox4;
        private global::System.Windows.Forms.GroupBox groupBox5;
        private global::System.Windows.Forms.TextBox textBoxWorldY1;
        private global::System.Windows.Forms.TextBox textBoxWorldX1;
        private global::System.Windows.Forms.TextBox textBoxWorldY0;
        private global::System.Windows.Forms.TextBox textBoxWorldX0;
        private global::System.Windows.Forms.TextBox textBoxViewY1;
        private global::System.Windows.Forms.TextBox textBoxViewX1;
        private global::System.Windows.Forms.TextBox textBoxViewY0;
        private global::System.Windows.Forms.TextBox textBoxViewX0;
        private global::System.Windows.Forms.TextBox textBoxBScrollY;
        private global::System.Windows.Forms.TextBox textBoxBScrollX;
        private global::System.Windows.Forms.Label label13;
        private global::System.Windows.Forms.TextBox textBoxFScrollY;
        private global::System.Windows.Forms.TextBox textBoxFScrollX;
        private global::System.Windows.Forms.Label label12;
        private global::System.Windows.Forms.TextBox textBoxAScrollY;
        private global::System.Windows.Forms.TextBox textBoxAScrollX;
        private global::System.Windows.Forms.Label label11;
        private global::System.Windows.Forms.CheckBox checkSleepOOV;
        private global::System.Windows.Forms.CheckBox checkWorldBounds;
        private global::System.Windows.Forms.Label label10;
        private global::System.Windows.Forms.Label label9;
        private global::System.Windows.Forms.Label label15;
        private global::System.Windows.Forms.Label label14;
        private global::System.Windows.Forms.Button btnBGColor;
        private global::System.Windows.Forms.ComboBox comboBoxStyle;
        private global::System.Windows.Forms.ComboBox comboBoxForeTexture;
        private global::System.Windows.Forms.Label label16;
        private global::System.Windows.Forms.ComboBox comboBoxBubbleTexture;
        private global::System.Windows.Forms.Label label21;
        private global::System.Windows.Forms.ComboBox comboBoxSplashTexture;
        private global::System.Windows.Forms.Label label20;
        private global::System.Windows.Forms.ComboBox comboBoxFireTexture;
        private global::System.Windows.Forms.Label label19;
        private global::System.Windows.Forms.ComboBox comboBoxWaterTexture;
        private global::System.Windows.Forms.Label label18;
        private global::System.Windows.Forms.ComboBox comboBoxBackTexture;
        private global::System.Windows.Forms.Label label17;
        private global::System.Windows.Forms.TextBox textBoxSceneWidth;
        private global::System.Windows.Forms.TextBox textBoxParticleSize;
        private global::System.Windows.Forms.TextBox textBoxSceneHeight;
        private global::System.Windows.Forms.ColorDialog colorDialogBGColor;
        private global::System.Windows.Forms.OpenFileDialog openFileDialog1;
        private global::System.Windows.Forms.TextBox textBoxTags;
        private global::System.Windows.Forms.Label label22;
        private global::System.Windows.Forms.Button btnSizeApply;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxTargetFPS;
        private System.Windows.Forms.Button buttonUpdateMisc;
    }
}
