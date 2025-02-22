using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public partial class BeforeClose : Form
    {
        public BeforeClose(string str0, string str1)
        {
            this.InitializeComponent();
            this.label1.Text = str0;
            this.label2.Text = str1;
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
