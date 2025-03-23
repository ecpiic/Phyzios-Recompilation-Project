using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class PropertyForm : Form
    {
        public PropertyForm(Form1 form, PanelController panelController)
        {
            this.InitializeComponent();
            this.MainForm = form;
            this.panelController = panelController;
        }
        private void SetTextureList2(ComboBox box, TextureManaged tex)
        {
            box.Items.Clear();
            box.Items.Add("No Texture");
            if (tex != null)
            {
                box.Items.Add(tex.Source);
            }
            box.Items.Add("Choose...");
        }
        public void UpdateParam()
        {
            this.textBoxSceneTitle.Text = this.MainForm.SceneTitle;
            this.textBoxTags.Text = this.MainForm.SceneTags;
            if (this.MainForm.EnableTag)
            {
                this.textBoxTags.Enabled = true;
            }
            else
            {
                this.textBoxTags.Enabled = false;
            }
            this.textBoxSceneDescription.Text = this.MainForm.SceneDescription;
            this.checkBoxPublish.Checked = this.MainForm.PublishFlag;
            if (this.comboBoxPixelsW.SelectedIndex == 0)
            {
                this.textBoxSceneWidth.Text = (this.MainForm.GetPanelController().Config.BoundsWidth * this.MainForm.GetPanelController().Config.Scale).ToString();
            }
            else
            {
                this.textBoxSceneWidth.Text = this.MainForm.GetPanelController().Config.BoundsWidth.ToString();
            }
            if (this.comboBoxPixelsH.SelectedIndex == 0)
            {
                this.textBoxSceneHeight.Text = (this.MainForm.GetPanelController().Config.BoundsHeight * this.MainForm.GetPanelController().Config.Scale).ToString();
            }
            else
            {
                this.textBoxSceneHeight.Text = this.MainForm.GetPanelController().Config.BoundsHeight.ToString();
            }
            this.textBoxParticleSize.Text = this.MainForm.GetPanelController().Config.Scale.ToString();
            this.checkBoundsWall.Checked = this.MainForm.GetPanelController().Config.BoundsFlag;
            this.checkSound.Checked = this.MainForm.GetPanelController().Config.SoundFlag;
            this.checkToolLimit.Checked = this.MainForm.ToolLimit;
            this.checkFireEffect.Checked = this.MainForm.GetPanelController().Config.FireFlag;
            this.checkSplashEffect.Checked = this.MainForm.GetPanelController().Config.SplashFlag;
            this.checkBubbleEffect.Checked = this.MainForm.GetPanelController().Config.BubbleFlag;
            this.checkGravity.Checked = this.MainForm.GetPanelController().Config.GravityFlag;
            this.textBoxGravityAcc.Text = this.MainForm.GetPanelController().Config.GravityAcceleration.ToString();
            this.SetGravityTrackbar();
            this.textBoxGravityAngle.Text = this.trackBarGravityAngle.Value.ToString();
            this.textBoxViewX0.Text = this.MainForm.GetPanelController().Config.BoundsLeft.ToString();
            this.textBoxViewY0.Text = this.MainForm.GetPanelController().Config.BoundsBottom.ToString();
            this.textBoxViewX1.Text = this.MainForm.GetPanelController().Config.BoundsRight.ToString();
            this.textBoxViewY1.Text = this.MainForm.GetPanelController().Config.BoundsTop.ToString();
            this.checkWorldBounds.Checked = this.MainForm.GetPanelController().Config.ScrollFlag;
            this.checkSleepOOV.Checked = this.MainForm.GetPanelController().Config.StoringFlag;
            this.textBoxWorldX0.Text = this.MainForm.GetPanelController().Config.ScrollLeft.ToString();
            this.textBoxWorldY0.Text = this.MainForm.GetPanelController().Config.ScrollBottom.ToString();
            this.textBoxWorldX1.Text = this.MainForm.GetPanelController().Config.ScrollRight.ToString();
            this.textBoxWorldY1.Text = this.MainForm.GetPanelController().Config.ScrollTop.ToString();
            this.textBoxAScrollX.Text = this.MainForm.GetPanelController().Config.UsersScrollX.ToString();
            this.textBoxAScrollY.Text = this.MainForm.GetPanelController().Config.UsersScrollY.ToString();
            this.textBoxFScrollX.Text = this.MainForm.GetPanelController().Config.ForegroundScrollX.ToString();
            this.textBoxFScrollY.Text = this.MainForm.GetPanelController().Config.ForegroundScrollY.ToString();
            this.textBoxBScrollX.Text = this.MainForm.GetPanelController().Config.BackgroundScrollX.ToString();
            this.textBoxBScrollY.Text = this.MainForm.GetPanelController().Config.BackgroundScrollY.ToString();
            this.comboBoxStyle.SelectedIndex = this.MainForm.GetPanelController().Config.RenderMode - 1;
            this.btnBGColor.BackColor = Color.FromArgb((int)Math.Min(this.MainForm.GetPanelController().Config.ClearColorAlpha * 255f, 255f), (int)Math.Min(this.MainForm.GetPanelController().Config.ClearColorRed * 255f, 255f), (int)Math.Min(this.MainForm.GetPanelController().Config.ClearColorGreen * 255f, 255f), (int)Math.Min(this.MainForm.GetPanelController().Config.ClearColorBlue * 255f, 255f));
            this.SetTextureList2(this.comboBoxForeTexture, this.MainForm.GetPanelController().Config.ForegroundTexture);
            this.SetTextureList2(this.comboBoxBackTexture, this.MainForm.GetPanelController().Config.BackgroundTexture);
            this.SetTextureList2(this.comboBoxWaterTexture, this.MainForm.GetPanelController().Config.WatermarkTexture);
            this.SetTextureList2(this.comboBoxFireTexture, this.MainForm.GetPanelController().Config.FireTexture);
            this.SetTextureList2(this.comboBoxSplashTexture, this.MainForm.GetPanelController().Config.SplashTexture);
            this.SetTextureList2(this.comboBoxBubbleTexture, this.MainForm.GetPanelController().Config.BubbleTexture);
            if (this.MainForm.GetPanelController().Config.ForegroundTexture != null)
            {
                this.comboBoxForeTexture.Text = this.MainForm.GetPanelController().Config.ForegroundTexture.Source;
            }
            else
            {
                this.comboBoxForeTexture.Text = "No Texture";
            }
            if (this.MainForm.GetPanelController().Config.BackgroundTexture != null)
            {
                this.comboBoxBackTexture.Text = this.MainForm.GetPanelController().Config.BackgroundTexture.Source;
            }
            else
            {
                this.comboBoxBackTexture.Text = "No Texture";
            }
            if (this.MainForm.GetPanelController().Config.WatermarkTexture != null)
            {
                this.comboBoxWaterTexture.Text = this.MainForm.GetPanelController().Config.WatermarkTexture.Source;
            }
            else
            {
                this.comboBoxWaterTexture.Text = "No Texture";
            }
            if (this.MainForm.GetPanelController().Config.FireTexture != null)
            {
                this.comboBoxFireTexture.Text = this.MainForm.GetPanelController().Config.FireTexture.Source;
            }
            else
            {
                this.comboBoxFireTexture.Text = "No Texture";
            }
            if (this.MainForm.GetPanelController().Config.SplashTexture != null)
            {
                this.comboBoxSplashTexture.Text = this.MainForm.GetPanelController().Config.SplashTexture.Source;
            }
            else
            {
                this.comboBoxSplashTexture.Text = "No Texture";
            }
            if (this.MainForm.GetPanelController().Config.BubbleTexture != null)
            {
                this.comboBoxBubbleTexture.Text = this.MainForm.GetPanelController().Config.BubbleTexture.Source;
                return;
            }
            this.comboBoxBubbleTexture.Text = "No Texture";
        }
        private float SetTexBoxToFloat(TextBox box, float old)
        {
            float num;
            if (float.TryParse(box.Text, out num))
            {
                return num;
            }
            MessageBox.Show("The value \"" + box.Text + "\" is invalid.\nPlease provide a valid value.");
            box.Text = old.ToString();
            return old;
        }
        private float SetTexBoxToFloatClamp(TextBox box, float old, float min, float max)
        {
            float num;
            if (float.TryParse(box.Text, out num))
            {
                if (num < min || num > max)
                {
                    num = CommonMethod.Clamp(num, min, max);
                    box.Text = num.ToString();
                }
                return num;
            }
            MessageBox.Show("The value \"" + box.Text + "\" is invalid.\nPlease provide a valid value.");
            box.Text = old.ToString();
            return old;
        }
        private void FeedbackSize()
        {
            this.MainForm.GetPanelController().Config.Scale = this.SetTexBoxToFloatClamp(
                this.textBoxParticleSize, this.MainForm.GetPanelController().Config.Scale, 1f, float.MaxValue);

            float num = 128f / this.MainForm.GetPanelController().Config.Scale;
            float num2 = float.MaxValue;

            if (this.comboBoxPixelsW.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.BoundsWidth = this.SetTexBoxToFloatClamp(
                    this.textBoxSceneWidth, this.MainForm.GetPanelController().Config.BoundsWidth * this.MainForm.GetPanelController().Config.Scale,
                    128f, float.MaxValue) / this.MainForm.GetPanelController().Config.Scale;
            }
            else
            {
                this.MainForm.GetPanelController().Config.BoundsWidth = this.SetTexBoxToFloatClamp(
                    this.textBoxSceneWidth, this.MainForm.GetPanelController().Config.BoundsWidth, num, float.MaxValue);
            }

            if (this.comboBoxPixelsH.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.BoundsHeight = this.SetTexBoxToFloatClamp(
                    this.textBoxSceneHeight, this.MainForm.GetPanelController().Config.BoundsHeight * this.MainForm.GetPanelController().Config.Scale,
                    128f, float.MaxValue) / this.MainForm.GetPanelController().Config.Scale;
            }
            else
            {
                this.MainForm.GetPanelController().Config.BoundsHeight = this.SetTexBoxToFloatClamp(
                    this.textBoxSceneHeight, this.MainForm.GetPanelController().Config.BoundsHeight, num, float.MaxValue);
            }

            this.MainForm.SetFormSize();
        }
        private void FeedbackParam()
        {
            this.MainForm.SetSceneTitle(this.textBoxSceneTitle.Text);
            this.MainForm.SceneTags = this.textBoxTags.Text;
            this.MainForm.SceneDescription = this.textBoxSceneDescription.Text;
            this.MainForm.PublishFlag = this.checkBoxPublish.Checked;
            this.MainForm.GetPanelController().Config.BoundsLeft = this.SetTexBoxToFloat(this.textBoxViewX0, this.MainForm.GetPanelController().Config.BoundsLeft);
            this.MainForm.GetPanelController().Config.BoundsBottom = this.SetTexBoxToFloat(this.textBoxViewY0, this.MainForm.GetPanelController().Config.BoundsBottom);
            this.MainForm.GetPanelController().Config.BoundsRight = this.SetTexBoxToFloat(this.textBoxViewX1, this.MainForm.GetPanelController().Config.BoundsRight);
            this.MainForm.GetPanelController().Config.BoundsTop = this.SetTexBoxToFloat(this.textBoxViewY1, this.MainForm.GetPanelController().Config.BoundsTop);
            this.MainForm.SetFormSize();
            if (this.comboBoxPixelsW.SelectedIndex == 0)
            {
                this.textBoxSceneWidth.Text = (this.MainForm.GetPanelController().Config.BoundsWidth * this.MainForm.GetPanelController().Config.Scale).ToString();
            }
            else
            {
                this.textBoxSceneWidth.Text = this.MainForm.GetPanelController().Config.BoundsWidth.ToString();
            }
            if (this.comboBoxPixelsH.SelectedIndex == 0)
            {
                this.textBoxSceneHeight.Text = (this.MainForm.GetPanelController().Config.BoundsHeight * this.MainForm.GetPanelController().Config.Scale).ToString();
            }
            else
            {
                this.textBoxSceneHeight.Text = this.MainForm.GetPanelController().Config.BoundsHeight.ToString();
            }
            this.MainForm.GetPanelController().Config.BoundsTop = this.SetTexBoxToFloat(this.textBoxViewY1, this.MainForm.GetPanelController().Config.BoundsTop);
            this.MainForm.GetPanelController().Config.BoundsTop = this.SetTexBoxToFloat(this.textBoxViewY1, this.MainForm.GetPanelController().Config.BoundsTop);
            this.MainForm.GetPanelController().Config.BoundsTop = this.SetTexBoxToFloat(this.textBoxViewY1, this.MainForm.GetPanelController().Config.BoundsTop);
            this.MainForm.GetPanelController().Config.BoundsTop = this.SetTexBoxToFloat(this.textBoxViewY1, this.MainForm.GetPanelController().Config.BoundsTop);
            this.MainForm.GetPanelController().Config.ScrollLeft = this.SetTexBoxToFloat(this.textBoxWorldX0, this.MainForm.GetPanelController().Config.ScrollLeft);
            this.MainForm.GetPanelController().Config.ScrollBottom = this.SetTexBoxToFloat(this.textBoxWorldY0, this.MainForm.GetPanelController().Config.ScrollBottom);
            this.MainForm.GetPanelController().Config.ScrollRight = this.SetTexBoxToFloat(this.textBoxWorldX1, this.MainForm.GetPanelController().Config.ScrollRight);
            this.MainForm.GetPanelController().Config.ScrollTop = this.SetTexBoxToFloat(this.textBoxWorldY1, this.MainForm.GetPanelController().Config.ScrollTop);
            this.MainForm.GetPanelController().Config.UsersScrollX = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxAScrollX, this.MainForm.GetPanelController().Config.UsersScrollX), 0f, 1f);
            this.MainForm.GetPanelController().Config.UsersScrollY = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxAScrollY, this.MainForm.GetPanelController().Config.UsersScrollY), 0f, 1f);
            this.textBoxAScrollX.Text = this.MainForm.GetPanelController().Config.UsersScrollX.ToString();
            this.textBoxAScrollY.Text = this.MainForm.GetPanelController().Config.UsersScrollY.ToString();
            this.MainForm.GetPanelController().Config.ForegroundScrollX = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxFScrollX, this.MainForm.GetPanelController().Config.ForegroundScrollX), 0f, 1f);
            this.MainForm.GetPanelController().Config.ForegroundScrollY = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxFScrollY, this.MainForm.GetPanelController().Config.ForegroundScrollY), 0f, 1f);
            this.MainForm.GetPanelController().Config.BackgroundScrollX = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxBScrollX, this.MainForm.GetPanelController().Config.BackgroundScrollX), 0f, 1f);
            this.MainForm.GetPanelController().Config.BackgroundScrollY = CommonMethod.Clamp(this.SetTexBoxToFloat(this.textBoxBScrollY, this.MainForm.GetPanelController().Config.BackgroundScrollY), 0f, 1f);
            this.textBoxFScrollX.Text = this.MainForm.GetPanelController().Config.ForegroundScrollX.ToString();
            this.textBoxFScrollY.Text = this.MainForm.GetPanelController().Config.ForegroundScrollY.ToString();
            this.textBoxBScrollX.Text = this.MainForm.GetPanelController().Config.BackgroundScrollX.ToString();
            this.textBoxBScrollY.Text = this.MainForm.GetPanelController().Config.BackgroundScrollY.ToString();
        }
        private void checkBoxPublish_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.PublishFlag = this.checkBoxPublish.Checked;
        }
        private void checkBoundsWall_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.BoundsFlag = this.checkBoundsWall.Checked;
        }
        private void checkSound_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.SoundFlag = this.checkSound.Checked;
        }
        private void checkToolLimit_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.ToolLimit = this.checkToolLimit.Checked;
        }
        private void checkFireEffect_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.FireFlag = this.checkFireEffect.Checked;
        }
        private void checkSplashEffect_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.SplashFlag = this.checkSplashEffect.Checked;
        }
        private void checkBubbleEffect_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.BubbleFlag = this.checkBubbleEffect.Checked;
        }
        private void checkGravity_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().GravityFlag = this.checkGravity.Checked;
        }
        private void checkWorldBounds_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.ScrollFlag = this.checkWorldBounds.Checked;
        }
        private void checkSleepOOV_CheckedChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.StoringFlag = this.checkSleepOOV.Checked;
        }
        private void btnBGColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.colorDialogBGColor.ShowDialog() == DialogResult.OK)
            {
                this.MainForm.GetPanelController().ClearColor = Form1.ToMColor(this.colorDialogBGColor.Color);
                this.btnBGColor.BackColor = this.colorDialogBGColor.Color;
            }
        }
        private void trackGravityAcc_Scroll(object sender, EventArgs e)
        {
            float num = (float)Math.Pow(10.0, (double)this.trackGravityAcc.Value / 25.0 - 5.0);
            this.textBoxGravityAcc.Text = num.ToString("N6");
            this.MainForm.GetPanelController().Config.GravityAcceleration = num;
        }
        private void trackBarGravityAngle_Scroll(object sender, EventArgs e)
        {
            this.textBoxGravityAngle.Text = this.trackBarGravityAngle.Value.ToString();
            this.MainForm.GetPanelController().Config.GravityAngle = (float)this.trackBarGravityAngle.Value * 3.1415927f / 180f;
        }
        private void SetGravityTrackbar()
        {
            int num = Math.Max(Math.Min((int)((Math.Log10((double)this.MainForm.GetPanelController().Config.GravityAcceleration) + 5.0) * 25.0), 100), 0);
            this.trackGravityAcc.Value = num;
            num = Math.Max(Math.Min((int)(this.MainForm.GetPanelController().Config.GravityAngle * 180f / 3.1415927f), 180), -180);
            this.trackBarGravityAngle.Value = num;
        }
        private void textBoxGravityAcc_Leave(object sender, EventArgs e)
        {
            float num;
            if (float.TryParse(this.textBoxGravityAcc.Text, out num))
            {
                num = Math.Max(Math.Min(num, 0.1f), 1E-05f);
                this.MainForm.GetPanelController().Config.GravityAcceleration = num;
                this.SetGravityTrackbar();
                return;
            }
            this.textBoxGravityAcc.Text = this.MainForm.GetPanelController().Config.GravityAcceleration.ToString();
        }
        private void textBoxGravityAcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                float num;
                if (float.TryParse(this.textBoxGravityAcc.Text, out num))
                {
                    num = Math.Max(Math.Min(num, 0.1f), 1E-05f);
                    this.MainForm.GetPanelController().Config.GravityAcceleration = num;
                    this.SetGravityTrackbar();
                    return;
                }
                this.textBoxGravityAcc.Text = this.MainForm.GetPanelController().Config.GravityAcceleration.ToString();
            }
        }
        private void textBoxGravityAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int num;
                if (int.TryParse(this.textBoxGravityAngle.Text, out num))
                {
                    this.MainForm.GetPanelController().Config.GravityAngle = (float)num * 3.1415927f / 180f;
                    this.SetGravityTrackbar();
                    return;
                }
                this.textBoxGravityAngle.Text = this.trackBarGravityAngle.Value.ToString();
            }
        }
        private void textBoxGravityAngle_Leave(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(this.textBoxGravityAngle.Text, out num))
            {
                this.MainForm.GetPanelController().Config.GravityAngle = (float)num * 3.1415927f / 180f;
                this.SetGravityTrackbar();
                return;
            }
            this.textBoxGravityAngle.Text = this.trackBarGravityAngle.Value.ToString();
        }
        private void textBoxSceneTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.FeedbackParam();
            }
        }
        private void textBoxSceneTitle_Leave(object sender, EventArgs e)
        {
            this.FeedbackParam();
        }
        private TextureManaged LoadTexture()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = this.openFileDialog1.FileName;
                    Bitmap bitmap = new Bitmap(fileName);
                    byte[] array = CommonMethod.LimitedImageData(bitmap, 640, 480);
                    if (array.Length != 0)
                    {
                        this.MainForm.GetPanelController().beat.SetFileResource(fileName.Replace('\\', '/'), array);
                        return this.MainForm.GetPanelController().Scene.Scene.FileManager.GetTextureFromFileSystem(Path.GetFileName(fileName.Replace('\\', '/')));
                    }
                }
                catch (Exception)
                {
                }
            }
            return null;
        }
        private void comboBoxForeTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxForeTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.ForegroundTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxForeTexture.SelectedIndex == this.comboBoxForeTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.ForegroundTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxForeTexture, textureManaged);
                    this.comboBoxForeTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxForeTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.ForegroundTexture = textureManaged2;
            }
        }
        private void comboBoxBackTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxBackTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.BackgroundTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxBackTexture.SelectedIndex == this.comboBoxBackTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.BackgroundTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxBackTexture, textureManaged);
                    this.comboBoxBackTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxBackTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.BackgroundTexture = textureManaged2;
            }
        }
        private void comboBoxWaterTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxWaterTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.WatermarkTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxWaterTexture.SelectedIndex == this.comboBoxWaterTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.WatermarkTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxWaterTexture, textureManaged);
                    this.comboBoxWaterTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxWaterTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.WatermarkTexture = textureManaged2;
            }
        }
        private void comboBoxFireTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxFireTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.FireTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxFireTexture.SelectedIndex == this.comboBoxFireTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.FireTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxFireTexture, textureManaged);
                    this.comboBoxFireTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxFireTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.FireTexture = textureManaged2;
            }
        }
        private void comboBoxSplashTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxSplashTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.SplashTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxSplashTexture.SelectedIndex == this.comboBoxSplashTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.SplashTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxSplashTexture, textureManaged);
                    this.comboBoxSplashTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxSplashTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.SplashTexture = textureManaged2;
            }
        }
        private void comboBoxBubbleTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxBubbleTexture.SelectedIndex == 0)
            {
                this.MainForm.GetPanelController().Config.BubbleTexture = null;
                return;
            }
            TextureManaged textureManaged2;
            if (this.comboBoxBubbleTexture.SelectedIndex == this.comboBoxBubbleTexture.Items.Count - 1)
            {
                TextureManaged textureManaged = this.LoadTexture();
                if (textureManaged != null)
                {
                    this.MainForm.GetPanelController().Config.BubbleTexture = textureManaged;
                    this.SetTextureList2(this.comboBoxBubbleTexture, textureManaged);
                    this.comboBoxBubbleTexture.Text = textureManaged.Source;
                    return;
                }
            }
            else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxBubbleTexture.Text, out textureManaged2))
            {
                this.MainForm.GetPanelController().Config.BubbleTexture = textureManaged2;
            }
        }
        private void comboBoxPixelsW_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateParam();
        }
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MainForm.GetPanelController().Config.RenderMode = this.comboBoxStyle.SelectedIndex + 1;
        }
        private void textBoxSceneWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.Feedback();
            }
        }
        private void textBoxSceneWidth_DragLeave(object sender, EventArgs e)
        {
            this.Feedback();
        }
        private void btnSizeDefault_Click(object sender, EventArgs e)
        {
            this.textBoxSceneWidth.Text = "640";
            this.comboBoxPixelsW.SelectedIndex = 0;
            this.textBoxSceneHeight.Text = "480";
            this.comboBoxPixelsH.SelectedIndex = 0;
            this.textBoxParticleSize.Text = "8";
            this.FeedbackSize();
            this.UpdateParam();
        }
        private void PropertyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FeedbackParam();
        }
        private void btnSizeApply_Click(object sender, EventArgs e)
        {
            this.Feedback();
        }
        private void Feedback()
        {
            this.FeedbackSize();
            this.UpdateParam();
        }
        private Form1 MainForm;
        private readonly PanelController panelController;

        private void buttonUpdateMisc_Click(object sender, EventArgs e)
        {
            int interval;

            if (!int.TryParse(this.textBoxTargetFPS.Text, out interval))
            {
                interval = 1;
            }

            interval = Math.Max(1, Math.Min(interval, 1000));
            this.textBoxTargetFPS.Text = interval.ToString();
            this.panelController.ChangeFPSTimer(interval);
        }
    }
}
