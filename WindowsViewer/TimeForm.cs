using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public partial class TimeForm : Form
    {
        public TimeForm(Form1 form)
        {
            this.InitializeComponent();
            this.MainForm = form;
        }
        public void UpdateParam()
        {
            int num = (int)this.MainForm.GetPanelController().Config.Time;
            int num2 = num / 3600 % 24;
            int num3 = num / 60 % 60;
            int num4 = num % 60;
            this.labelTime.Text = string.Format("{0,2:D2}:{1,2:D2}:{2,2:D2}", num2, num3, num4);
            num = this.MainForm.GetPanelController().Scene.SceneRenderer.GetRecordCountFrames() / 30;
            num2 = num / 3600 % 24;
            num3 = num / 60 % 60;
            num4 = num % 60;
            this.labelMovieTime.Text = string.Format("{0,2:D2}:{1,2:D2}:{2,2:D2}", num2, num3, num4);
            if (this.MainForm.GetPanelController().Config.PauseFlag)
            {
                this.checkPause.Checked = true;
                return;
            }
            this.checkPause.Checked = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.UpdateParam();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.Time = 0.0;
        }
        private void checkMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkMovie.Checked)
            {
                this.MainForm.Record();
                if (!this.MainForm.IsRecording())
                {
                    this.checkMovie.Enabled = false;
                    this.checkMovie.Checked = false;
                    this.checkMovie.Enabled = true;
                    return;
                }
            }
            else
            {
                this.MainForm.StopRecording();
            }
        }
        private void checkPause_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkPause.Checked)
            {
                this.MainForm.GetPanelController().Config.PauseFlag = true;
                return;
            }
            this.MainForm.GetPanelController().Config.PauseFlag = false;
        }
        private Form1 MainForm;
    }
}
