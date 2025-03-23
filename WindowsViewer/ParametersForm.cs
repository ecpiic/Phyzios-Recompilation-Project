using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class ParametersForm : Form
    {
        public ParametersForm(ConfigurationManaged config)
        {
            this.Config = config;
            this.Timer = new Timer();
            this.InitializeComponent();
            foreach (var key in this.Config.ParameterList.ParameterDictionary.Keys)
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    TextWriter textWriter = stringWriter;
                    this.Config.ParameterList.ParameterDictionary[key].Save(ref textWriter);
                    this.dataGridView1.Rows.Add(new object[]
                    {
            key,
            stringWriter.ToString().Substring(key.Length + 2).Trim()
                    });
                }
            }
            this.Timer.Tick += this.Timer_Tick;
            this.Timer.Interval = 10000;
            this.Timer.Enabled = true;
        }

        public void RefreshValues()
        {
            foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                using (StringWriter stringWriter = new StringWriter())
                {
                    string text = dataGridViewRow.Cells["ColumnName"].Value.ToString();
                    TextWriter textWriter = stringWriter;
                    this.Config.ParameterList.ParameterDictionary[text].Save(ref textWriter);
                    dataGridViewRow.Cells["ColumnValue"].Value = stringWriter.ToString().Substring(text.Length + 2).Trim();
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.RefreshValues();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = this.dataGridView1.Rows[e.RowIndex];
            object value = dataGridViewRow.Cells["ColumnValue"].Value;
            double num;
            if (double.TryParse((value != null) ? value.ToString() : null, out num))
            {
                this.Config.ReadValue(dataGridViewRow.Cells["ColumnName"].Value.ToString(), num);
            }
            this.RefreshValues();
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            this.RefreshValues();
        }
        public string _Author = "Added by BlueAmulet";
        private readonly ConfigurationManaged Config;
        private readonly Timer Timer;
    }
}
