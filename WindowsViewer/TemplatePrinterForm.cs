using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsViewer
{
    public partial class TemplatePrinterForm : Form
    {
        public TemplatePrinterForm()
        {
            InitializeComponent();
            LoadTemplates(this.listBoxTemplates);
        }

        private void LoadTemplates(ListBox listBoxTemplates)
        {
            string folderPath = Path.Combine(Application.StartupPath, "templates");

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                listBoxTemplates.Items.Clear();

                foreach (string file in files)
                {
                    listBoxTemplates.Items.Add(Path.GetFileName(file));
                }
            }
            else
            {
                MessageBox.Show("Templates folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedItem != null)
            {
                currentTemplateLabel.Text = $"Current template is: {listBoxTemplates.SelectedItem}";
            }
        }

        private void buttonRemoveSelected_Clicked(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedItem != null)
            {
                string selectedFile = listBoxTemplates.SelectedItem.ToString();
                string folderPath = Path.Combine(Application.StartupPath, "templates");
                string filePath = Path.Combine(folderPath, selectedFile);

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedFile}?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }

                        listBoxTemplates.Items.Remove(selectedFile);
                        currentTemplateLabel.Text = "Current template is: None";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a template to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}

