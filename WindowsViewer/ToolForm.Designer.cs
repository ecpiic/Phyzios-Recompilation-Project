namespace WindowsViewer
{
    public partial class ToolForm : global::System.Windows.Forms.Form
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
            this.btnNowMaterial = new System.Windows.Forms.Button();
            this.btnMaterialColor = new System.Windows.Forms.Button();
            this.colorDialogMaterial = new System.Windows.Forms.ColorDialog();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.radioGoal = new System.Windows.Forms.RadioButton();
            this.radioArrow = new System.Windows.Forms.RadioButton();
            this.radioSpoit = new System.Windows.Forms.RadioButton();
            this.radioSelect = new System.Windows.Forms.RadioButton();
            this.radioAxis = new System.Windows.Forms.RadioButton();
            this.radioPen = new System.Windows.Forms.RadioButton();
            this.radioPicker = new System.Windows.Forms.RadioButton();
            this.radioMarker = new System.Windows.Forms.RadioButton();
            this.radioSlice = new System.Windows.Forms.RadioButton();
            this.radioEraser = new System.Windows.Forms.RadioButton();
            this.radioChgColor = new System.Windows.Forms.RadioButton();
            this.radioChgMaterial = new System.Windows.Forms.RadioButton();
            this.radioBucket = new System.Windows.Forms.RadioButton();
            this.radioLink = new System.Windows.Forms.RadioButton();
            this.radioShape = new System.Windows.Forms.RadioButton();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.radioBrush = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnNowMaterial
            // 
            this.btnNowMaterial.Location = new System.Drawing.Point(12, 577);
            this.btnNowMaterial.Name = "btnNowMaterial";
            this.btnNowMaterial.Size = new System.Drawing.Size(110, 39);
            this.btnNowMaterial.TabIndex = 32;
            this.btnNowMaterial.Text = "button1";
            this.btnNowMaterial.UseVisualStyleBackColor = true;
            this.btnNowMaterial.Click += new System.EventHandler(this.btnNowMaterial_Click);
            // 
            // btnMaterialColor
            // 
            this.btnMaterialColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaterialColor.Location = new System.Drawing.Point(12, 628);
            this.btnMaterialColor.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnMaterialColor.Name = "btnMaterialColor";
            this.btnMaterialColor.Size = new System.Drawing.Size(110, 39);
            this.btnMaterialColor.TabIndex = 33;
            this.btnMaterialColor.UseVisualStyleBackColor = false;
            this.btnMaterialColor.Click += new System.EventHandler(this.btnMaterialColor_Click);
            // 
            // radioStart
            // 
            this.radioStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioStart.Location = new System.Drawing.Point(70, 514);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(52, 56);
            this.radioStart.TabIndex = 31;
            this.radioStart.Text = "Start";
            this.toolTip1.SetToolTip(this.radioStart, "Start");
            this.radioStart.UseVisualStyleBackColor = true;
            this.radioStart.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioGoal
            // 
            this.radioGoal.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioGoal.Location = new System.Drawing.Point(12, 514);
            this.radioGoal.Name = "radioGoal";
            this.radioGoal.Size = new System.Drawing.Size(52, 56);
            this.radioGoal.TabIndex = 30;
            this.radioGoal.Text = "Goal";
            this.toolTip1.SetToolTip(this.radioGoal, "Goal");
            this.radioGoal.UseVisualStyleBackColor = true;
            this.radioGoal.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioArrow
            // 
            this.radioArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioArrow.Image = global::WindowsViewer.Properties.Resources.radioArrow;
            this.radioArrow.Location = new System.Drawing.Point(12, 12);
            this.radioArrow.Name = "radioArrow";
            this.radioArrow.Size = new System.Drawing.Size(52, 56);
            this.radioArrow.TabIndex = 14;
            this.toolTip1.SetToolTip(this.radioArrow, "Arrow");
            this.radioArrow.UseVisualStyleBackColor = true;
            this.radioArrow.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioSpoit
            // 
            this.radioSpoit.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSpoit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSpoit.Image = global::WindowsViewer.Properties.Resources.radioSpoit;
            this.radioSpoit.Location = new System.Drawing.Point(70, 452);
            this.radioSpoit.Name = "radioSpoit";
            this.radioSpoit.Size = new System.Drawing.Size(52, 56);
            this.radioSpoit.TabIndex = 29;
            this.toolTip1.SetToolTip(this.radioSpoit, "Spoit");
            this.radioSpoit.UseVisualStyleBackColor = true;
            this.radioSpoit.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioSelect
            // 
            this.radioSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSelect.Image = global::WindowsViewer.Properties.Resources.radioSelect;
            this.radioSelect.Location = new System.Drawing.Point(12, 75);
            this.radioSelect.Name = "radioSelect";
            this.radioSelect.Size = new System.Drawing.Size(52, 56);
            this.radioSelect.TabIndex = 16;
            this.toolTip1.SetToolTip(this.radioSelect, "Select");
            this.radioSelect.UseVisualStyleBackColor = true;
            this.radioSelect.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioAxis
            // 
            this.radioAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioAxis.Image = global::WindowsViewer.Properties.Resources.radioAxis;
            this.radioAxis.Location = new System.Drawing.Point(12, 452);
            this.radioAxis.Name = "radioAxis";
            this.radioAxis.Size = new System.Drawing.Size(52, 56);
            this.radioAxis.TabIndex = 28;
            this.toolTip1.SetToolTip(this.radioAxis, "Axis");
            this.radioAxis.UseVisualStyleBackColor = true;
            this.radioAxis.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioPen
            // 
            this.radioPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioPen.Checked = true;
            this.radioPen.Image = global::WindowsViewer.Properties.Resources.radioPen;
            this.radioPen.Location = new System.Drawing.Point(12, 138);
            this.radioPen.Name = "radioPen";
            this.radioPen.Size = new System.Drawing.Size(52, 56);
            this.radioPen.TabIndex = 18;
            this.radioPen.TabStop = true;
            this.toolTip1.SetToolTip(this.radioPen, "Pen");
            this.radioPen.UseVisualStyleBackColor = true;
            this.radioPen.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioPicker
            // 
            this.radioPicker.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioPicker.Image = global::WindowsViewer.Properties.Resources.ControlTool;
            this.radioPicker.Location = new System.Drawing.Point(70, 12);
            this.radioPicker.Name = "radioPicker";
            this.radioPicker.Size = new System.Drawing.Size(52, 56);
            this.radioPicker.TabIndex = 15;
            this.toolTip1.SetToolTip(this.radioPicker, "Control");
            this.radioPicker.UseVisualStyleBackColor = true;
            this.radioPicker.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioMarker
            // 
            this.radioMarker.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMarker.Image = global::WindowsViewer.Properties.Resources.radioMarker;
            this.radioMarker.Location = new System.Drawing.Point(12, 201);
            this.radioMarker.Name = "radioMarker";
            this.radioMarker.Size = new System.Drawing.Size(52, 56);
            this.radioMarker.TabIndex = 20;
            this.toolTip1.SetToolTip(this.radioMarker, "Marker");
            this.radioMarker.UseVisualStyleBackColor = true;
            this.radioMarker.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioSlice
            // 
            this.radioSlice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSlice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSlice.Image = global::WindowsViewer.Properties.Resources.radioSlice;
            this.radioSlice.Location = new System.Drawing.Point(70, 389);
            this.radioSlice.Name = "radioSlice";
            this.radioSlice.Size = new System.Drawing.Size(52, 56);
            this.radioSlice.TabIndex = 27;
            this.toolTip1.SetToolTip(this.radioSlice, "Slice");
            this.radioSlice.UseVisualStyleBackColor = true;
            this.radioSlice.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioEraser
            // 
            this.radioEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioEraser.Image = global::WindowsViewer.Properties.Resources.radioEraser;
            this.radioEraser.Location = new System.Drawing.Point(12, 263);
            this.radioEraser.Name = "radioEraser";
            this.radioEraser.Size = new System.Drawing.Size(52, 56);
            this.radioEraser.TabIndex = 22;
            this.toolTip1.SetToolTip(this.radioEraser, "Eraser");
            this.radioEraser.UseVisualStyleBackColor = true;
            this.radioEraser.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioChgColor
            // 
            this.radioChgColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioChgColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioChgColor.Image = global::WindowsViewer.Properties.Resources.radioChgColor;
            this.radioChgColor.Location = new System.Drawing.Point(70, 326);
            this.radioChgColor.Name = "radioChgColor";
            this.radioChgColor.Size = new System.Drawing.Size(52, 56);
            this.radioChgColor.TabIndex = 25;
            this.toolTip1.SetToolTip(this.radioChgColor, "Change Color");
            this.radioChgColor.UseVisualStyleBackColor = true;
            this.radioChgColor.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioChgMaterial
            // 
            this.radioChgMaterial.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioChgMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioChgMaterial.Image = global::WindowsViewer.Properties.Resources.radioChgMaterial;
            this.radioChgMaterial.Location = new System.Drawing.Point(12, 326);
            this.radioChgMaterial.Name = "radioChgMaterial";
            this.radioChgMaterial.Size = new System.Drawing.Size(52, 56);
            this.radioChgMaterial.TabIndex = 24;
            this.toolTip1.SetToolTip(this.radioChgMaterial, "Change Material");
            this.radioChgMaterial.UseVisualStyleBackColor = true;
            this.radioChgMaterial.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioBucket
            // 
            this.radioBucket.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBucket.Image = global::WindowsViewer.Properties.Resources.radioBucket;
            this.radioBucket.Location = new System.Drawing.Point(70, 263);
            this.radioBucket.Name = "radioBucket";
            this.radioBucket.Size = new System.Drawing.Size(52, 56);
            this.radioBucket.TabIndex = 23;
            this.toolTip1.SetToolTip(this.radioBucket, "Bucket");
            this.radioBucket.UseVisualStyleBackColor = true;
            this.radioBucket.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioLink
            // 
            this.radioLink.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioLink.Image = global::WindowsViewer.Properties.Resources.radioLink;
            this.radioLink.Location = new System.Drawing.Point(12, 389);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(52, 56);
            this.radioLink.TabIndex = 26;
            this.toolTip1.SetToolTip(this.radioLink, "Link");
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioShape
            // 
            this.radioShape.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioShape.Image = global::WindowsViewer.Properties.Resources.radioShape;
            this.radioShape.Location = new System.Drawing.Point(70, 201);
            this.radioShape.Name = "radioShape";
            this.radioShape.Size = new System.Drawing.Size(52, 56);
            this.radioShape.TabIndex = 21;
            this.toolTip1.SetToolTip(this.radioShape, "Shape");
            this.radioShape.UseVisualStyleBackColor = true;
            this.radioShape.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioMove
            // 
            this.radioMove.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMove.Image = global::WindowsViewer.Properties.Resources.radioMove;
            this.radioMove.Location = new System.Drawing.Point(70, 75);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(52, 56);
            this.radioMove.TabIndex = 17;
            this.toolTip1.SetToolTip(this.radioMove, "Move");
            this.radioMove.UseVisualStyleBackColor = true;
            this.radioMove.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // radioBrush
            // 
            this.radioBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBrush.Image = global::WindowsViewer.Properties.Resources.radioBrush;
            this.radioBrush.Location = new System.Drawing.Point(70, 138);
            this.radioBrush.Name = "radioBrush";
            this.radioBrush.Size = new System.Drawing.Size(52, 56);
            this.radioBrush.TabIndex = 19;
            this.toolTip1.SetToolTip(this.radioBrush, "Brush");
            this.radioBrush.UseVisualStyleBackColor = true;
            this.radioBrush.CheckedChanged += new System.EventHandler(this.Tool_CheckedChanged);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 673);
            this.Controls.Add(this.radioArrow);
            this.Controls.Add(this.radioStart);
            this.Controls.Add(this.btnNowMaterial);
            this.Controls.Add(this.btnMaterialColor);
            this.Controls.Add(this.radioBrush);
            this.Controls.Add(this.radioGoal);
            this.Controls.Add(this.radioMove);
            this.Controls.Add(this.radioShape);
            this.Controls.Add(this.radioSpoit);
            this.Controls.Add(this.radioLink);
            this.Controls.Add(this.radioSelect);
            this.Controls.Add(this.radioBucket);
            this.Controls.Add(this.radioAxis);
            this.Controls.Add(this.radioChgMaterial);
            this.Controls.Add(this.radioPen);
            this.Controls.Add(this.radioChgColor);
            this.Controls.Add(this.radioPicker);
            this.Controls.Add(this.radioEraser);
            this.Controls.Add(this.radioMarker);
            this.Controls.Add(this.radioSlice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.RadioButton radioSlice;
        private global::System.Windows.Forms.RadioButton radioChgColor;
        private global::System.Windows.Forms.RadioButton radioBucket;
        private global::System.Windows.Forms.RadioButton radioShape;
        private global::System.Windows.Forms.RadioButton radioBrush;
        private global::System.Windows.Forms.RadioButton radioMove;
        private global::System.Windows.Forms.RadioButton radioLink;
        private global::System.Windows.Forms.RadioButton radioChgMaterial;
        private global::System.Windows.Forms.RadioButton radioEraser;
        private global::System.Windows.Forms.RadioButton radioMarker;
        private global::System.Windows.Forms.RadioButton radioPen;
        private global::System.Windows.Forms.RadioButton radioSelect;
        private global::System.Windows.Forms.RadioButton radioArrow;
        private global::System.Windows.Forms.RadioButton radioPicker;
        private global::System.Windows.Forms.Button btnNowMaterial;
        private global::System.Windows.Forms.Button btnMaterialColor;
        private global::System.Windows.Forms.RadioButton radioAxis;
        private global::System.Windows.Forms.RadioButton radioSpoit;
        private global::System.Windows.Forms.ColorDialog colorDialogMaterial;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.RadioButton radioGoal;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
