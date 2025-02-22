using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public class OECPanel : UserControl
    {
        public Timer TimerMain
        {
            get
            {
                return this.timerMain;
            }
        }
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
            this.components = new Container();
            this.timerMain = new Timer(this.components);
            base.SuspendLayout();
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 30;
            this.AllowDrop = true;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Name = "OECPanel";
            base.ResumeLayout(false);
        }
        public OECPanel()
        {
            this.InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.backgroundInvaliated)
            {
                base.OnPaintBackground(e);
                this.backgroundInvaliated = false;
            }
        }
        private IContainer components;
        private Timer timerMain;
        private bool backgroundInvaliated = true;
    }
}
