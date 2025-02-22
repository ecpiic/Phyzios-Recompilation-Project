using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            this.InitializeComponent();
            this.labelVersion.Text = "Version " + CommonMethod.GetVersion();
        }
    }
}
