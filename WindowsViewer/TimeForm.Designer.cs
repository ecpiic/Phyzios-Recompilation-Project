namespace WindowsViewer
{
    public partial class TimeForm : global::System.Windows.Forms.Form
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
            this.labelTime = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.labelMovieTime = new global::System.Windows.Forms.Label();
            this.btnReset = new global::System.Windows.Forms.Button();
            this.timer1 = new global::System.Windows.Forms.Timer(this.components);
            this.checkMovie = new global::System.Windows.Forms.CheckBox();
            this.checkPause = new global::System.Windows.Forms.CheckBox();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(60, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulation:";
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new global::System.Drawing.Point(127, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new global::System.Drawing.Size(35, 12);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label2";
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(30, 49);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie:";
            this.labelMovieTime.AutoSize = true;
            this.labelMovieTime.Location = new global::System.Drawing.Point(127, 49);
            this.labelMovieTime.Name = "labelMovieTime";
            this.labelMovieTime.Size = new global::System.Drawing.Size(35, 12);
            this.labelMovieTime.TabIndex = 3;
            this.labelMovieTime.Text = "label4";
            this.btnReset.Location = new global::System.Drawing.Point(314, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new global::System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new global::System.EventHandler(this.btnReset_Click);
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
            this.checkMovie.Appearance = global::System.Windows.Forms.Appearance.Button;
            this.checkMovie.Location = new global::System.Drawing.Point(221, 44);
            this.checkMovie.Name = "checkMovie";
            this.checkMovie.Size = new global::System.Drawing.Size(75, 23);
            this.checkMovie.TabIndex = 6;
            this.checkMovie.Text = "Capture";
            this.checkMovie.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMovie.UseVisualStyleBackColor = true;
            this.checkMovie.CheckedChanged += new global::System.EventHandler(this.checkMovie_CheckedChanged);
            this.checkPause.Appearance = global::System.Windows.Forms.Appearance.Button;
            this.checkPause.Location = new global::System.Drawing.Point(221, 15);
            this.checkPause.Name = "checkPause";
            this.checkPause.Size = new global::System.Drawing.Size(75, 23);
            this.checkPause.TabIndex = 7;
            this.checkPause.Text = "Pause";
            this.checkPause.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPause.UseVisualStyleBackColor = true;
            this.checkPause.CheckedChanged += new global::System.EventHandler(this.checkPause_CheckedChanged);
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(414, 84);
            base.Controls.Add(this.checkPause);
            base.Controls.Add(this.checkMovie);
            base.Controls.Add(this.btnReset);
            base.Controls.Add(this.labelMovieTime);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.labelTime);
            base.Controls.Add(this.label1);
            base.Name = "TimeForm";
            this.Text = "Time";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label labelTime;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label labelMovieTime;
        private global::System.Windows.Forms.Button btnReset;
        private global::System.Windows.Forms.Timer timer1;
        private global::System.Windows.Forms.CheckBox checkMovie;
        private global::System.Windows.Forms.CheckBox checkPause;
    }
}
