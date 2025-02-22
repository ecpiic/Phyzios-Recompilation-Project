using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class BrowserForm : Form
    {
        public BrowserForm(Form1 form)
        {
            this.InitializeComponent();
            this.MainForm = form;
            this.ScriptWindow = null;
        }
        private void UpdateTextureList()
        {
            this.comboBoxTexture.Items.Clear();
            this.comboBoxTexture.Items.Add("No Texture");
            foreach (string text in this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.Keys)
            {
                this.comboBoxTexture.Items.Add(text);
            }
            this.comboBoxTexture.Items.Add("Choose...");
        }
        public void UpdateParam()
        {
            string text = null;
            if (this.treeModules.SelectedNode != null)
            {
                text = this.treeModules.SelectedNode.FullPath;
            }
            this.treeModules.Nodes.Clear();
            this.UpdateTextureList();
            ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
            ModuleManaged moduleById = modules.GetModuleById(0);
            TreeNode treeNode = new TreeNode("root");
            treeNode.Tag = moduleById.Id;
            this.treeModules.Nodes.Add(treeNode);
            this.AddChildNode(treeNode, 0U);
            TreeNode treeNode2 = new TreeNode("particles");
            treeNode.Nodes.Add(treeNode2);
            for (int i = 1; i < this.MainForm.GetPanelController().Scene.Particles.Data.BodiesSize; i++)
            {
                ParticleBodyManaged particleBodyManaged = this.MainForm.GetPanelController().Scene.Particles.Data.get_Bodies(i);
                ModuleManaged module = particleBodyManaged.Module;
                TreeNode treeNode3 = new TreeNode("#" + i.ToString());
                treeNode3.Tag = particleBodyManaged;
                treeNode2.Nodes.Add(treeNode3);
            }
            if (text != null)
            {
                this.SelectNodeWithPath(treeNode, text);
            }
            treeNode.ExpandAll();
        }
        private void SelectNodeWithPath(TreeNode parent, string Path)
        {
            if (parent.FullPath == Path)
            {
                this.treeModules.SelectedNode = parent;
                return;
            }
            foreach (object obj in parent.Nodes)
            {
                TreeNode treeNode = (TreeNode)obj;
                this.SelectNodeWithPath(treeNode, Path);
            }
        }
        public void SelectNodeWithBodyID(int bodyid)
        {
            if (bodyid > 0)
            {
                this.treeModules.SelectedNode = this.treeModules.Nodes[0].LastNode.Nodes[bodyid - 1];
                return;
            }
            if (bodyid == 0)
            {
                this.treeModules.SelectedNode = null;
                this.SetBlankData();
            }
        }
        private void UpdateNodeName(TreeNode node)
        {
            if (node.Tag != null && node.Tag.GetType() == typeof(int))
            {
                int num = (int)node.Tag;
                ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                ModuleManaged moduleById = modules.GetModuleById(num);
                if (string.IsNullOrEmpty(moduleById.Name))
                {
                    if (num == 0)
                    {
                        node.Text = "root";
                    }
                    else
                    {
                        node.Text = "No Name";
                    }
                }
                else
                {
                    node.Text = moduleById.Name;
                }
            }
            foreach (object obj in node.Nodes)
            {
                TreeNode treeNode = (TreeNode)obj;
                this.UpdateNodeName(treeNode);
            }
        }
        private void AddChildNode(TreeNode parent, uint parent_id)
        {
            ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
            for (int i = 0; i < modules.Count; i++)
            {
                ModuleManaged moduleManaged = modules.get_ModuleArray(i);
                if (moduleManaged != null && moduleManaged.Id != 0U)
                {
                    ModuleManaged parent2 = moduleManaged.Parent;
                    if (parent2 != null && parent_id == parent2.Id)
                    {
                        TreeNode treeNode = ((!string.IsNullOrEmpty(moduleManaged.Name)) ? new TreeNode(moduleManaged.Name) : new TreeNode("No Name"));
                        treeNode.Tag = moduleManaged.Id;
                        parent.Nodes.Add(treeNode);
                        this.AddChildNode(treeNode, moduleManaged.Id);
                    }
                }
            }
        }
        private string GetStringFromScript(AbstractScriptManaged script)
        {
            if (script != null)
            {
                return script.Source;
            }
            return string.Empty;
        }
        private string GetStringFromScript(float? nullable)
        {
            return nullable.ToString();
        }
        private void SetBlankData()
        {
            this.textBoxTitle.Enabled = false;
            this.textBoxTags.Enabled = false;
            this.comboBoxTexture.Enabled = false;
            this.comboBoxMapping.Enabled = false;
            this.textBoxCoords00.Enabled = false;
            this.textBoxCoords01.Enabled = false;
            this.textBoxCoords02.Enabled = false;
            this.textBoxCoords03.Enabled = false;
            this.textBoxTitle.Text = "";
            this.comboBoxMapping.SelectedIndex = 0;
            this.textBoxCoords00.Text = "";
            this.textBoxCoords01.Text = "";
            this.textBoxCoords02.Text = "";
            this.textBoxCoords03.Text = "";
            this.tabControl1.Enabled = false;
            this.textBoxCenterX.Text = "";
            this.textBoxCenterY.Text = "";
            this.textBoxAngle.Text = "";
            this.textBoxVelocityX.Text = "";
            this.textBoxVelocityY.Text = "";
            this.textBoxSpin.Text = "";
            this.textBoxForceX.Text = "";
            this.textBoxForceY.Text = "";
            this.textBoxTorque.Text = "";
            this.btnCreateModule.Enabled = false;
            this.btnEditScript.Enabled = false;
        }
        private void treeModules_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.btnCreateModule.Enabled = false;
            ModuleManaged moduleManaged;
            if (e.Node.Tag != null && e.Node.Tag.GetType() == typeof(int))
            {
                int num = (int)e.Node.Tag;
                ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                moduleManaged = modules.GetModuleById(num);
            }
            else
            {
                if (e.Node.Tag == null || !(e.Node.Tag.GetType() == typeof(ParticleBodyManaged)))
                {
                    this.SetBlankData();
                    return;
                }
                ParticleBodyManaged particleBodyManaged = (ParticleBodyManaged)e.Node.Tag;
                string text = e.Node.Text.Substring(1);
                int num2;
                if (int.TryParse(text, out num2) && this.MainForm.GetPanelController().LeftButtonTool != Tools.MarqueeTool)
                {
                    this.MainForm.SelectBody(num2);
                }
                if (particleBodyManaged.Module == null)
                {
                    this.SetBlankData();
                    this.btnCreateModule.Enabled = true;
                    return;
                }
                moduleManaged = particleBodyManaged.Module;
            }
            this.textBoxTitle.Enabled = true;
            this.textBoxTags.Enabled = true;
            this.comboBoxTexture.Enabled = true;
            this.comboBoxMapping.Enabled = true;
            this.textBoxCoords00.Enabled = true;
            this.textBoxCoords01.Enabled = true;
            this.textBoxCoords02.Enabled = true;
            this.textBoxCoords03.Enabled = true;
            this.textBoxTitle.Text = moduleManaged.Name;
            if (moduleManaged.Texture != null)
            {
                this.comboBoxTexture.Text = moduleManaged.Texture.Source;
            }
            else
            {
                this.comboBoxTexture.SelectedIndex = 0;
            }
            Control control = this.textBoxCoords00;
            Float2Managed float2Managed = moduleManaged.MinOrigin;
            control.Text = float2Managed.X.ToString();
            Control control2 = this.textBoxCoords01;
            float2Managed = moduleManaged.MinOrigin;
            control2.Text = float2Managed.Y.ToString();
            Control control3 = this.textBoxCoords02;
            float2Managed = moduleManaged.MaxOrigin;
            control3.Text = float2Managed.X.ToString();
            Control control4 = this.textBoxCoords03;
            float2Managed = moduleManaged.MaxOrigin;
            control4.Text = float2Managed.Y.ToString();
            this.tabControl1.Enabled = true;
            this.textBoxCenterX.Text = this.GetStringFromScript(moduleManaged.DisplacementXConstraint);
            this.textBoxCenterY.Text = this.GetStringFromScript(moduleManaged.DisplacementYConstraint);
            this.textBoxAngle.Text = this.GetStringFromScript(moduleManaged.AngleConstraint);
            this.textBoxVelocityX.Text = this.GetStringFromScript(moduleManaged.VelocityXConstraint);
            this.textBoxVelocityY.Text = this.GetStringFromScript(moduleManaged.VelocityYConstraint);
            this.textBoxSpin.Text = this.GetStringFromScript(moduleManaged.SpinConstraint);
            this.textBoxForceX.Text = this.GetStringFromScript(moduleManaged.ForceXConstraint);
            this.textBoxForceY.Text = this.GetStringFromScript(moduleManaged.ForceYConstraint);
            this.textBoxTorque.Text = this.GetStringFromScript(moduleManaged.TorqueConstraint);
            this.comboBoxMapping.SelectedIndex = moduleManaged.Mapping;
            this.btnEditScript.Enabled = true;
        }
        private AbstractScriptManaged ToAbstractScript(string str)
        {
            AbstractScriptManaged abstractScriptManaged2;
            try
            {
                AbstractScriptManaged abstractScriptManaged = AbstractScriptManaged.ExpressionWithString(str);
                if (!abstractScriptManaged.HasError())
                {
                    abstractScriptManaged2 = abstractScriptManaged;
                }
                else
                {
                    abstractScriptManaged2 = null;
                }
            }
            catch (Exception)
            {
                abstractScriptManaged2 = null;
            }
            return abstractScriptManaged2;
        }
        private ModuleManaged GetNowModule(TreeNode node, out bool module_node)
        {
            ModuleManaged moduleManaged = null;
            module_node = false;
            if (node.Tag != null && node.Tag.GetType() == typeof(int))
            {
                int num = (int)node.Tag;
                ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                moduleManaged = modules.GetModuleById(num);
                module_node = true;
            }
            else if (node.Tag != null && node.Tag.GetType() == typeof(ParticleBodyManaged))
            {
                ParticleBodyManaged particleBodyManaged = (ParticleBodyManaged)node.Tag;
                if (particleBodyManaged.Module != null)
                {
                    moduleManaged = particleBodyManaged.Module;
                }
            }
            return moduleManaged;
        }
        private void FeedbackParam(TreeNode node)
        {
            bool flag;
            ModuleManaged nowModule = this.GetNowModule(node, out flag);
            if (nowModule != null)
            {
                nowModule.Name = this.textBoxTitle.Text;
                if (flag)
                {
                    node.Text = this.textBoxTitle.Text;
                }
                nowModule.Mapping = this.comboBoxMapping.SelectedIndex;
                try
                {
                    nowModule.MinOrigin = new Float2Managed(Convert.ToSingle(this.textBoxCoords00.Text), Convert.ToSingle(this.textBoxCoords01.Text));
                    nowModule.MaxOrigin = new Float2Managed(Convert.ToSingle(this.textBoxCoords02.Text), Convert.ToSingle(this.textBoxCoords03.Text));
                }
                catch (Exception)
                {
                }
                AbstractScriptManaged abstractScriptManaged = this.ToAbstractScript(this.textBoxCenterX.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.DisplacementXConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.DisplacementXConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxCenterY.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.DisplacementYConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.DisplacementYConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxAngle.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.AngleConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.AngleConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxVelocityX.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.VelocityXConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.VelocityXConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxVelocityY.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.VelocityYConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.VelocityYConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxSpin.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.SpinConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.SpinConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxForceX.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.ForceXConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.ForceXConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxForceY.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.ForceYConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.ForceYConstraint = null;
                }
                abstractScriptManaged = this.ToAbstractScript(this.textBoxTorque.Text);
                if (abstractScriptManaged != null)
                {
                    nowModule.TorqueConstraint = abstractScriptManaged;
                }
                else
                {
                    nowModule.TorqueConstraint = null;
                }
                this.UpdateNodeName(this.treeModules.Nodes[0]);
            }
        }
        private void treeModules_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNode = this.treeModules.SelectedNode;
        }
        private void comboBoxTexture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.listchanged && this.treeModules.SelectedNode != null && this.comboBoxTexture.SelectedIndex >= 0)
            {
                TreeNode selectedNode = this.treeModules.SelectedNode;
                ModuleManaged moduleManaged;
                if (selectedNode.Tag.GetType() == typeof(int))
                {
                    int num = (int)selectedNode.Tag;
                    ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                    moduleManaged = modules.GetModuleById(num);
                }
                else
                {
                    if (!(selectedNode.Tag.GetType() == typeof(ParticleBodyManaged)))
                    {
                        return;
                    }
                    ParticleBodyManaged particleBodyManaged = (ParticleBodyManaged)selectedNode.Tag;
                    if (particleBodyManaged.Module == null)
                    {
                        return;
                    }
                    moduleManaged = particleBodyManaged.Module;
                }
                TextureManaged textureManaged2;
                if (this.comboBoxTexture.SelectedIndex == 0)
                {
                    moduleManaged.Texture = null;
                    this.UpdateCoords(moduleManaged);
                }
                else if (this.comboBoxTexture.SelectedIndex == this.comboBoxTexture.Items.Count - 1)
                {
                    TextureManaged textureManaged = this.LoadTexture();
                    if (textureManaged != null)
                    {
                        this.MainForm.GetPanelController().Scene.Scene.ParticleBuilder.setBodyTexture((uint)(selectedNode.Index + 1), textureManaged);
                        this.UpdateTextureList();
                        this.listchanged = true;
                        this.comboBoxTexture.Text = textureManaged.Source;
                        this.UpdateCoords(moduleManaged);
                    }
                }
                else if (this.MainForm.GetPanelController().Scene.Scene.FileManager.TextureMap.TryGetValue(this.comboBoxTexture.Text, out textureManaged2))
                {
                    this.MainForm.GetPanelController().Scene.Scene.ParticleBuilder.setBodyTexture((uint)(selectedNode.Index + 1), textureManaged2);
                    this.UpdateCoords(moduleManaged);
                }
            }
            this.listchanged = false;
        }
        private void UpdateCoords(ModuleManaged module)
        {
            Control control = this.textBoxCoords00;
            Float2Managed float2Managed = module.MinOrigin;
            control.Text = float2Managed.X.ToString();
            Control control2 = this.textBoxCoords01;
            float2Managed = module.MinOrigin;
            control2.Text = float2Managed.Y.ToString();
            Control control3 = this.textBoxCoords02;
            float2Managed = module.MaxOrigin;
            control3.Text = float2Managed.X.ToString();
            Control control4 = this.textBoxCoords03;
            float2Managed = module.MaxOrigin;
            control4.Text = float2Managed.Y.ToString();
        }
        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (this.treeModules.SelectedNode != null)
            {
                this.FeedbackParam(this.treeModules.SelectedNode);
            }
        }
        private void textBoxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.treeModules.SelectedNode != null)
            {
                this.FeedbackParam(this.treeModules.SelectedNode);
            }
        }
        private void btnEditScript_Click(object sender, EventArgs e)
        {
            if (this.treeModules.SelectedNode == null)
            {
                return;
            }
            bool flag;
            ModuleManaged nowModule = this.GetNowModule(this.treeModules.SelectedNode, out flag);
            if (nowModule != null)
            {
                if (this.ScriptWindow == null || this.ScriptWindow.IsDisposed)
                {
                    this.ScriptWindow = new ScriptForm(this.MainForm);
                }
                this.ScriptWindow.SetModule((int)nowModule.Id);
                this.ScriptWindow.Show();
            }
        }
        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            if (this.treeModules.SelectedNode != null)
            {
                TreeNode selectedNode = this.treeModules.SelectedNode;
                if (selectedNode.Tag != null && selectedNode.Tag.GetType() == typeof(ParticleBodyManaged))
                {
                    ModuleDataManaged modules = this.MainForm.GetPanelController().Scene.GetModules();
                    ParticleBodyManaged particleBodyManaged = (ParticleBodyManaged)selectedNode.Tag;
                    particleBodyManaged.Module = modules.CreateModule();
                }
                this.UpdateParam();
                this.btnCreateModule.Enabled = false;
            }
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
        private void comboBoxMapping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.treeModules.SelectedNode != null)
            {
                this.FeedbackParam(this.treeModules.SelectedNode);
            }
        }
        private Form1 MainForm;
        private ScriptForm ScriptWindow;
        private bool listchanged;
    }
}
