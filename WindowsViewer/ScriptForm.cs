using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class ScriptForm : Form
    {
        public ScriptForm(Form1 form)
        {
            this.InitializeComponent();
            this.MainForm = form;
            this.ModuleID = -1;
        }
        public void SetModule(int moduleid)
        {
            this.ModuleID = moduleid;
            this.ScriptToTextBox();
        }
        private void ScriptToTextBox()
        {
            this.textScript.Text = "";
            if (this.ModuleID != -1)
            {
                ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                ModuleManaged moduleById = modules.GetModuleById(this.ModuleID);
                if (moduleById != null && moduleById.Script != null)
                {
                    this.textScript.Text = moduleById.Script.Source;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ModuleID != -1)
            {
                ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                ModuleManaged moduleById = modules.GetModuleById(this.ModuleID);
                if (moduleById != null)
                {
                    moduleById.Script = StatementScriptManaged.StatementWithString(this.textScript.Text);
                    this.MainForm.SetUseScript();
                }
            }
        }
        private void ScriptForm_Resize(object sender, EventArgs e)
        {
            int num = base.ClientSize.Height - 40;
            this.textScript.Height = num;
        }
        private Form1 MainForm;
        private int ModuleID;
    }
}
