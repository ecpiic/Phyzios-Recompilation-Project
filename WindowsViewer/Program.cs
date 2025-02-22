using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace WindowsViewer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            for (; ; )
            {
                List<string> list = new List<string>();
                foreach (string text in Program.requiredFiles)
                {
                    if (!File.Exists(text))
                    {
                        list.Add(text);
                    }
                }
                if (list.Count <= 0)
                {
                    goto IL_7A;
                }
                DialogResult dialogResult = MessageBox.Show("The following files are missing:\n    " + string.Join("\n    ", list.ToArray()) + "\n\nPlease fully extract PHYZIOS Studio Pro", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
                if (dialogResult == DialogResult.Abort)
                {
                    break;
                }
                if (dialogResult != DialogResult.Retry)
                {
                    goto IL_7A;
                }
            }
            return;
        IL_7A:
            Application.Run(new Form1());
        }
        private static string[] requiredFiles = new string[] { "GLCapture.dll", "OpenAL32.dll", "PHYZIOSSystem.dll", "PHYZIOSSystemManaged.dll", "alut.dll", "glew32.dll", "wrap_oal.dll" };
    }
}
