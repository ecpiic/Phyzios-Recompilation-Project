namespace WindowsViewer
{
    partial class TemplatePrinterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplatePrinterForm));
            this.currentTemplateLabel = new System.Windows.Forms.Label();
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.buttonRemoveTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTemplateLabel
            // 
            this.currentTemplateLabel.AutoSize = true;
            this.currentTemplateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemplateLabel.Location = new System.Drawing.Point(8, 110);
            this.currentTemplateLabel.Name = "currentTemplateLabel";
            this.currentTemplateLabel.Size = new System.Drawing.Size(150, 16);
            this.currentTemplateLabel.TabIndex = 0;
            this.currentTemplateLabel.Text = "Current template is none";
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.Items.AddRange(new object[] {
            "hello"});
            this.listBoxTemplates.Location = new System.Drawing.Point(12, 12);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(392, 95);
            this.listBoxTemplates.TabIndex = 1;
            this.listBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.listBoxTemplates_SelectedIndexChanged);
            // 
            // buttonRemoveTemplate
            // 
            this.buttonRemoveTemplate.Location = new System.Drawing.Point(12, 133);
            this.buttonRemoveTemplate.Name = "buttonRemoveTemplate";
            this.buttonRemoveTemplate.Size = new System.Drawing.Size(102, 23);
            this.buttonRemoveTemplate.TabIndex = 2;
            this.buttonRemoveTemplate.Text = "Remove Selected";
            this.buttonRemoveTemplate.UseVisualStyleBackColor = true;
            this.buttonRemoveTemplate.Click += new System.EventHandler(this.buttonRemoveSelected_Clicked);
            // 
            // TemplatePrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 171);
            this.Controls.Add(this.buttonRemoveTemplate);
            this.Controls.Add(this.listBoxTemplates);
            this.Controls.Add(this.currentTemplateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplatePrinterForm";
            this.Text = "Template Printer (not finished)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTemplateLabel;
        private System.Windows.Forms.ListBox listBoxTemplates;
        private System.Windows.Forms.Button buttonRemoveTemplate;
    }
}