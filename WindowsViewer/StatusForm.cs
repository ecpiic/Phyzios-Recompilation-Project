using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public partial class StatusForm : Form
    {
        public StatusForm(Form1 form)
        {
            this.InitializeComponent();
            this.MainForm = form;
        }
        public void UpdateParam()
        {
            this.labelFPS.Text = string.Format("{0:F}", this.MainForm.GetPanelController().GetFPS());
            this.labelParticle.Text = this.MainForm.GetPanelController().Scene.Scene.CountParticles.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.UpdateParam();
        }
        private Form1 MainForm;
    }
}
