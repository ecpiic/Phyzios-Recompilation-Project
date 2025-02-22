using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class ToolForm : Form
    {
        public ToolForm(Form1 form, Tools tool)
        {
            this.MainForm = form;
            this.InitializeComponent();
            this.SetButtons(tool);
        }
        public void SetButtons(Tools tool)
        {
            switch (tool)
            {
                case Tools.ArrowTool:
                    this.radioArrow.Checked = true;
                    return;
                case Tools.BrushTool:
                    this.radioBrush.Checked = true;
                    return;
                case Tools.CropTool:
                case (Tools)100:
                case (Tools)102:
                case Tools.HandTool:
                case Tools.LassoTool:
                case Tools.SpongeTool:
                case Tools.BlurTool:
                case (Tools)116:
                    break;
                case Tools.EraserTool:
                    this.radioEraser.Checked = true;
                    return;
                case Tools.BucketTool:
                    this.radioBucket.Checked = true;
                    return;
                case Tools.SamplerTool:
                    this.radioSpoit.Checked = true;
                    break;
                case Tools.MaterialTool:
                    this.radioChgMaterial.Checked = true;
                    return;
                case Tools.SliceTool:
                    this.radioSlice.Checked = true;
                    return;
                case Tools.MarqueeTool:
                    this.radioSelect.Checked = true;
                    return;
                case Tools.LinkTool:
                    this.radioLink.Checked = true;
                    return;
                case Tools.PencilTool:
                    this.radioPen.Checked = true;
                    return;
                case Tools.ControlTool:
                    this.radioPicker.Checked = true;
                    return;
                case Tools.ColorTool:
                    this.radioChgColor.Checked = true;
                    return;
                case Tools.ShapeTool:
                    this.radioShape.Checked = true;
                    return;
                case Tools.MoveTool:
                    this.radioMove.Checked = true;
                    return;
                case Tools.MagicWandTool:
                    this.radioMarker.Checked = true;
                    return;
                case Tools.AxisTool:
                    this.radioAxis.Checked = true;
                    return;
                default:
                    return;
            }
        }
        public void SetColor(Color col)
        {
            this.btnMaterialColor.BackColor = col;
        }
        public void SetMaterialName(string name)
        {
            this.btnNowMaterial.Text = name;
        }
        private void SetTool()
        {
            this.MainForm.GetOECPanel();
            if (this.radioArrow.Checked)
            {
                this.MainForm.SetTool(Tools.ArrowTool);
            }
            bool @checked = this.radioPicker.Checked;
            if (this.radioSelect.Checked)
            {
                this.MainForm.SetTool(Tools.MarqueeTool);
            }
            if (this.radioMove.Checked)
            {
                this.MainForm.SetTool(Tools.MoveTool);
            }
            if (this.radioPen.Checked)
            {
                this.MainForm.SetTool(Tools.PencilTool);
            }
            if (this.radioBrush.Checked)
            {
                this.MainForm.SetTool(Tools.BrushTool);
            }
            if (this.radioMarker.Checked)
            {
                this.MainForm.SetTool(Tools.MarkerTool);
            }
            if (this.radioShape.Checked)
            {
                this.MainForm.SetTool(Tools.ShapeTool);
            }
            if (this.radioEraser.Checked)
            {
                this.MainForm.SetTool(Tools.EraserTool);
            }
            if (this.radioBucket.Checked)
            {
                this.MainForm.SetTool(Tools.BucketTool);
            }
            if (this.radioChgMaterial.Checked)
            {
                this.MainForm.SetTool(Tools.MaterialTool);
            }
            if (this.radioChgColor.Checked)
            {
                this.MainForm.SetTool(Tools.ColorTool);
            }
            if (this.radioLink.Checked)
            {
                this.MainForm.SetTool(Tools.LinkTool);
            }
            if (this.radioSlice.Checked)
            {
                this.MainForm.SetTool(Tools.SliceTool);
            }
            if (this.radioAxis.Checked)
            {
                this.MainForm.SetTool(Tools.AxisTool);
            }
            if (this.radioSpoit.Checked)
            {
                this.MainForm.SetTool(Tools.SamplerTool);
            }
        }
        private void Tool_CheckedChanged(object sender, EventArgs e)
        {
            this.SetTool();
        }
        private void btnMaterialColor_Click(object sender, EventArgs e)
        {
            this.colorDialogMaterial.Color = this.btnMaterialColor.BackColor;
            if (this.colorDialogMaterial.ShowDialog() == DialogResult.OK)
            {
                this.MainForm.SetColor(this.colorDialogMaterial.Color);
                this.btnMaterialColor.BackColor = this.colorDialogMaterial.Color;
            }
        }
        private void btnNowMaterial_Click(object sender, EventArgs e)
        {
            this.MainForm.OpenMaterialWindow();
        }
        public void SetButtonColor(Color col)
        {
            this.btnMaterialColor.BackColor = col;
        }
        private Form1 MainForm;
    }
}
