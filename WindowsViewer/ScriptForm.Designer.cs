namespace WindowsViewer
{
    public partial class ScriptForm : global::System.Windows.Forms.Form
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textScript = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.textScript.AcceptsTab = true;
            this.textScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textScript.Location = new System.Drawing.Point(0, 25);
            this.textScript.Name = "textScript";
            this.textScript.Size = new System.Drawing.Size(718, 392);
            this.textScript.TabIndex = 1;
            this.textScript.Text = "Eggs Benedict.";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.textScript);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ScriptForm";
            this.Text = "Script";
            this.Resize += new System.EventHandler(this.ScriptForm_Resize);
            this.ResumeLayout(false);
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.Button btnUpdate;
        private global::System.Windows.Forms.RichTextBox textScript;
    }
}
