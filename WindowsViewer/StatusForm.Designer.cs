namespace WindowsViewer
{
    public partial class StatusForm : global::System.Windows.Forms.Form
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
            this.components = new global::System.ComponentModel.Container();
            this.label1 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.labelFPS = new global::System.Windows.Forms.Label();
            this.labelParticle = new global::System.Windows.Forms.Label();
            this.timer1 = new global::System.Windows.Forms.Timer(this.components);
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(28, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FPS:";
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(46, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Particle:";
            this.labelFPS.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
            this.labelFPS.Location = new global::System.Drawing.Point(140, 19);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new global::System.Drawing.Size(40, 12);
            this.labelFPS.TabIndex = 2;
            this.labelFPS.Text = "label3";
            this.labelFPS.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
            this.labelParticle.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
            this.labelParticle.Location = new global::System.Drawing.Point(140, 46);
            this.labelParticle.Name = "labelParticle";
            this.labelParticle.Size = new global::System.Drawing.Size(40, 12);
            this.labelParticle.TabIndex = 3;
            this.labelParticle.Text = "label4";
            this.labelParticle.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(201, 78);
            base.Controls.Add(this.labelParticle);
            base.Controls.Add(this.labelFPS);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StatusForm";
            base.ShowIcon = false;
            this.Text = "Status";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label labelFPS;
        private global::System.Windows.Forms.Label labelParticle;
        private global::System.Windows.Forms.Timer timer1;
    }
}
