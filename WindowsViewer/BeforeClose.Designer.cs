namespace WindowsViewer
{
    public partial class BeforeClose : global::System.Windows.Forms.Form
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
            this.btnDontSave = new global::System.Windows.Forms.Button();
            this.btnCancel = new global::System.Windows.Forms.Button();
            this.btnSave = new global::System.Windows.Forms.Button();
            this.label1 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            base.SuspendLayout();
            this.btnDontSave.DialogResult = global::System.Windows.Forms.DialogResult.Ignore;
            this.btnDontSave.Location = new global::System.Drawing.Point(309, 65);
            this.btnDontSave.Name = "btnDontSave";
            this.btnDontSave.Size = new global::System.Drawing.Size(75, 23);
            this.btnDontSave.TabIndex = 0;
            this.btnDontSave.Text = "Don't Save";
            this.btnDontSave.UseVisualStyleBackColor = true;
            this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new global::System.Drawing.Point(390, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnSave.DialogResult = global::System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new global::System.Drawing.Point(471, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new global::System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font(global::System.Windows.Forms.Control.DefaultFont.FontFamily, 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
            this.label1.Location = new global::System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(429, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to save the changes you made in the document \"Untitled\"?";
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font(global::System.Windows.Forms.Control.DefaultFont.FontFamily, 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
            this.label2.Location = new global::System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(286, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your changes will be lost if you don't save them.";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(558, 100);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.btnSave);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnDontSave);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BeforeClose";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.Button btnDontSave;
        private global::System.Windows.Forms.Button btnCancel;
        private global::System.Windows.Forms.Button btnSave;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
    }
}
