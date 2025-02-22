namespace WindowsViewer
{
    public partial class ParametersForm : global::System.Windows.Forms.Form
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
            this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
            this.ColumnName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            ((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.ColumnName, this.ColumnValue });
            this.dataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new global::System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new global::System.Drawing.Size(284, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 160;
            this.ColumnValue.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(284, 361);
            base.Controls.Add(this.dataGridView1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ParametersForm";
            base.ShowIcon = false;
            this.Text = "Parameters";
            ((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }
        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.DataGridView dataGridView1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
    }
}
