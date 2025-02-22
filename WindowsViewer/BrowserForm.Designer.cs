﻿namespace WindowsViewer
{
    public partial class BrowserForm : global::System.Windows.Forms.Form
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("root");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeModules = new System.Windows.Forms.TreeView();
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCoords03 = new System.Windows.Forms.TextBox();
            this.textBoxCoords02 = new System.Windows.Forms.TextBox();
            this.textBoxCoords01 = new System.Windows.Forms.TextBox();
            this.textBoxCoords00 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMapping = new System.Windows.Forms.ComboBox();
            this.comboBoxTexture = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConstraint = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxForceY = new System.Windows.Forms.TextBox();
            this.textBoxForceX = new System.Windows.Forms.TextBox();
            this.textBoxTorque = new System.Windows.Forms.TextBox();
            this.textBoxVelocityY = new System.Windows.Forms.TextBox();
            this.textBoxVelocityX = new System.Windows.Forms.TextBox();
            this.textBoxSpin = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.tabPageParticke = new System.Windows.Forms.TabPage();
            this.checkBoxSplitable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConstraint.SuspendLayout();
            this.tabPageParticke.SuspendLayout();
            this.SuspendLayout();
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.treeModules);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateModule);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditScript);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCoords03);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCoords02);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCoords01);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCoords00);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxMapping);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTexture);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTags);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Size = new System.Drawing.Size(504, 491);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            this.treeModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeModules.HideSelection = false;
            this.treeModules.Location = new System.Drawing.Point(0, 0);
            this.treeModules.Name = "treeModules";
            treeNode2.Name = "root";
            treeNode2.Text = "root";
            this.treeModules.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeModules.Size = new System.Drawing.Size(168, 491);
            this.treeModules.TabIndex = 0;
            this.treeModules.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeModules_BeforeSelect);
            this.treeModules.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeModules_AfterSelect);
            this.btnCreateModule.Location = new System.Drawing.Point(16, 131);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(153, 25);
            this.btnCreateModule.TabIndex = 8;
            this.btnCreateModule.Text = "Create Module";
            this.btnCreateModule.UseVisualStyleBackColor = true;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            this.btnEditScript.Location = new System.Drawing.Point(175, 131);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(145, 25);
            this.btnEditScript.TabIndex = 9;
            this.btnEditScript.Text = "Edit Script";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Coords:";
            this.textBoxCoords03.Location = new System.Drawing.Point(268, 105);
            this.textBoxCoords03.Name = "textBoxCoords03";
            this.textBoxCoords03.Size = new System.Drawing.Size(52, 20);
            this.textBoxCoords03.TabIndex = 7;
            this.textBoxCoords03.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCoords03.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxCoords02.Location = new System.Drawing.Point(210, 105);
            this.textBoxCoords02.Name = "textBoxCoords02";
            this.textBoxCoords02.Size = new System.Drawing.Size(52, 20);
            this.textBoxCoords02.TabIndex = 6;
            this.textBoxCoords02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCoords02.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxCoords01.Location = new System.Drawing.Point(152, 105);
            this.textBoxCoords01.Name = "textBoxCoords01";
            this.textBoxCoords01.Size = new System.Drawing.Size(52, 20);
            this.textBoxCoords01.TabIndex = 5;
            this.textBoxCoords01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCoords01.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxCoords00.Location = new System.Drawing.Point(94, 105);
            this.textBoxCoords00.Name = "textBoxCoords00";
            this.textBoxCoords00.Size = new System.Drawing.Size(52, 20);
            this.textBoxCoords00.TabIndex = 4;
            this.textBoxCoords00.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCoords00.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Texture:";
            this.comboBoxMapping.FormattingEnabled = true;
            this.comboBoxMapping.Items.AddRange(new object[] {
            "NoMapping",
            "Default",
            "Grain",
            "Rubber",
            "Tile",
            "Decal",
            "Rigid",
            "Slice"});
            this.comboBoxMapping.Location = new System.Drawing.Point(235, 77);
            this.comboBoxMapping.Name = "comboBoxMapping";
            this.comboBoxMapping.Size = new System.Drawing.Size(85, 21);
            this.comboBoxMapping.TabIndex = 3;
            this.comboBoxMapping.Text = "NoMapping";
            this.comboBoxMapping.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapping_SelectedIndexChanged);
            this.comboBoxTexture.FormattingEnabled = true;
            this.comboBoxTexture.Location = new System.Drawing.Point(66, 77);
            this.comboBoxTexture.Name = "comboBoxTexture";
            this.comboBoxTexture.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTexture.TabIndex = 2;
            this.comboBoxTexture.SelectedIndexChanged += new System.EventHandler(this.comboBoxTexture_SelectedIndexChanged);
            this.tabControl1.Controls.Add(this.tabPageConstraint);
            this.tabControl1.Controls.Add(this.tabPageParticke);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(332, 299);
            this.tabControl1.TabIndex = 10;
            this.tabPageConstraint.Controls.Add(this.label11);
            this.tabPageConstraint.Controls.Add(this.label10);
            this.tabPageConstraint.Controls.Add(this.label9);
            this.tabPageConstraint.Controls.Add(this.label8);
            this.tabPageConstraint.Controls.Add(this.label7);
            this.tabPageConstraint.Controls.Add(this.label6);
            this.tabPageConstraint.Controls.Add(this.textBoxForceY);
            this.tabPageConstraint.Controls.Add(this.textBoxForceX);
            this.tabPageConstraint.Controls.Add(this.textBoxTorque);
            this.tabPageConstraint.Controls.Add(this.textBoxVelocityY);
            this.tabPageConstraint.Controls.Add(this.textBoxVelocityX);
            this.tabPageConstraint.Controls.Add(this.textBoxSpin);
            this.tabPageConstraint.Controls.Add(this.textBoxCenterY);
            this.tabPageConstraint.Controls.Add(this.textBoxCenterX);
            this.tabPageConstraint.Controls.Add(this.textBoxAngle);
            this.tabPageConstraint.Location = new System.Drawing.Point(4, 22);
            this.tabPageConstraint.Name = "tabPageConstraint";
            this.tabPageConstraint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConstraint.Size = new System.Drawing.Size(324, 273);
            this.tabPageConstraint.TabIndex = 0;
            this.tabPageConstraint.Text = "Constraint";
            this.tabPageConstraint.UseVisualStyleBackColor = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Torque:";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Force:";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Spin:";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Velocity:";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Angle:";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Center:";
            this.textBoxForceY.Location = new System.Drawing.Point(196, 115);
            this.textBoxForceY.Name = "textBoxForceY";
            this.textBoxForceY.Size = new System.Drawing.Size(120, 20);
            this.textBoxForceY.TabIndex = 7;
            this.textBoxForceY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxForceY.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxForceX.Location = new System.Drawing.Point(62, 115);
            this.textBoxForceX.Name = "textBoxForceX";
            this.textBoxForceX.Size = new System.Drawing.Size(120, 20);
            this.textBoxForceX.TabIndex = 6;
            this.textBoxForceX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxForceX.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxTorque.Location = new System.Drawing.Point(62, 142);
            this.textBoxTorque.Name = "textBoxTorque";
            this.textBoxTorque.Size = new System.Drawing.Size(254, 20);
            this.textBoxTorque.TabIndex = 8;
            this.textBoxTorque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxTorque.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxVelocityY.Location = new System.Drawing.Point(196, 61);
            this.textBoxVelocityY.Name = "textBoxVelocityY";
            this.textBoxVelocityY.Size = new System.Drawing.Size(120, 20);
            this.textBoxVelocityY.TabIndex = 4;
            this.textBoxVelocityY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxVelocityY.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxVelocityX.Location = new System.Drawing.Point(62, 61);
            this.textBoxVelocityX.Name = "textBoxVelocityX";
            this.textBoxVelocityX.Size = new System.Drawing.Size(120, 20);
            this.textBoxVelocityX.TabIndex = 3;
            this.textBoxVelocityX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxVelocityX.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxSpin.Location = new System.Drawing.Point(62, 88);
            this.textBoxSpin.Name = "textBoxSpin";
            this.textBoxSpin.Size = new System.Drawing.Size(254, 20);
            this.textBoxSpin.TabIndex = 5;
            this.textBoxSpin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxSpin.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxCenterY.Location = new System.Drawing.Point(196, 6);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(120, 20);
            this.textBoxCenterY.TabIndex = 1;
            this.textBoxCenterY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCenterY.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxCenterX.Location = new System.Drawing.Point(62, 6);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(120, 20);
            this.textBoxCenterX.TabIndex = 0;
            this.textBoxCenterX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxCenterX.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.textBoxAngle.Location = new System.Drawing.Point(62, 34);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(254, 20);
            this.textBoxAngle.TabIndex = 2;
            this.textBoxAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxAngle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.tabPageParticke.Controls.Add(this.checkBoxSplitable);
            this.tabPageParticke.Location = new System.Drawing.Point(4, 22);
            this.tabPageParticke.Name = "tabPageParticke";
            this.tabPageParticke.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParticke.Size = new System.Drawing.Size(324, 273);
            this.tabPageParticke.TabIndex = 1;
            this.tabPageParticke.Text = "Particle";
            this.tabPageParticke.UseVisualStyleBackColor = true;
            this.checkBoxSplitable.AutoSize = true;
            this.checkBoxSplitable.Location = new System.Drawing.Point(11, 6);
            this.checkBoxSplitable.Name = "checkBoxSplitable";
            this.checkBoxSplitable.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSplitable.TabIndex = 0;
            this.checkBoxSplitable.Text = "Splitable";
            this.checkBoxSplitable.UseVisualStyleBackColor = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tags:";
            this.textBoxTags.Location = new System.Drawing.Point(66, 50);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(254, 20);
            this.textBoxTags.TabIndex = 1;
            this.textBoxTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxTags.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.textBoxTitle.Location = new System.Drawing.Point(66, 23);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(254, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BrowserForm";
            this.Text = "Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConstraint.ResumeLayout(false);
            this.tabPageConstraint.PerformLayout();
            this.tabPageParticke.ResumeLayout(false);
            this.tabPageParticke.PerformLayout();
            this.ResumeLayout(false);
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.SplitContainer splitContainer1;
        private global::System.Windows.Forms.TreeView treeModules;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.TextBox textBoxTags;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox textBoxTitle;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.TextBox textBoxCoords03;
        private global::System.Windows.Forms.TextBox textBoxCoords02;
        private global::System.Windows.Forms.TextBox textBoxCoords01;
        private global::System.Windows.Forms.TextBox textBoxCoords00;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.ComboBox comboBoxMapping;
        private global::System.Windows.Forms.ComboBox comboBoxTexture;
        private global::System.Windows.Forms.TabControl tabControl1;
        private global::System.Windows.Forms.TabPage tabPageConstraint;
        private global::System.Windows.Forms.TextBox textBoxCenterY;
        private global::System.Windows.Forms.TextBox textBoxCenterX;
        private global::System.Windows.Forms.TextBox textBoxAngle;
        private global::System.Windows.Forms.TabPage tabPageParticke;
        private global::System.Windows.Forms.TextBox textBoxForceY;
        private global::System.Windows.Forms.TextBox textBoxForceX;
        private global::System.Windows.Forms.TextBox textBoxTorque;
        private global::System.Windows.Forms.TextBox textBoxVelocityY;
        private global::System.Windows.Forms.TextBox textBoxVelocityX;
        private global::System.Windows.Forms.TextBox textBoxSpin;
        private global::System.Windows.Forms.CheckBox checkBoxSplitable;
        private global::System.Windows.Forms.Label label11;
        private global::System.Windows.Forms.Label label10;
        private global::System.Windows.Forms.Label label9;
        private global::System.Windows.Forms.Label label8;
        private global::System.Windows.Forms.Label label7;
        private global::System.Windows.Forms.Label label6;
        private global::System.Windows.Forms.Button btnCreateModule;
        private global::System.Windows.Forms.Button btnEditScript;
        private global::System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
