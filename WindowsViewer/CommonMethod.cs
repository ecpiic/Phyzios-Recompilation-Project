using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace WindowsViewer
{
    public class CommonMethod
    {
        public static string GetValue(string line)
        {
            int num = line.IndexOf("=");
            if (num >= 0)
            {
                return line.Substring(num + 1);
            }
            return string.Empty;
        }
        public static int GetValueInt(string line)
        {
            string value = CommonMethod.GetValue(line);
            int num;
            if (!string.IsNullOrEmpty(value) && int.TryParse(value, out num))
            {
                return num;
            }
            return 0;
        }
        public static string GetVersion()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            return string.Format("{0}.{1}.{2}", executingAssembly.GetName().Version.Major, executingAssembly.GetName().Version.Minor, executingAssembly.GetName().Version.Build);
        }
        public static void CutEdge(Form form, int r, Color backcol, Color edgecol)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.FillMode = FillMode.Winding;
            graphicsPath.AddRectangle(new Rectangle(r, 0, form.Width - r * 2, form.Height));
            graphicsPath.AddRectangle(new Rectangle(0, r, form.Width, form.Height - r * 2));
            graphicsPath.AddEllipse(new Rectangle(0, 0, r * 2, r * 2));
            graphicsPath.AddEllipse(new Rectangle(form.Width - r * 2, 0, r * 2, r * 2));
            graphicsPath.AddEllipse(new Rectangle(form.Width - r * 2, form.Height - r * 2, r * 2, r * 2));
            graphicsPath.AddEllipse(new Rectangle(0, form.Height - r * 2, r * 2, r * 2));
            form.Region = new Region(graphicsPath);
            Bitmap bitmap = new Bitmap(form.Width, form.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidBrush = new SolidBrush(backcol);
            graphics.Clear(edgecol);
            graphics.FillRectangle(solidBrush, new Rectangle(r + 1, 1, form.Width - r * 2 - 2, form.Height - 2));
            graphics.FillRectangle(solidBrush, new Rectangle(1, r + 1, form.Width - 2, form.Height - r * 2 - 2));
            graphics.FillEllipse(solidBrush, new Rectangle(1, 1, r * 2, r * 2));
            graphics.FillEllipse(solidBrush, new Rectangle(form.Width - r * 2 - 1, 1, r * 2, r * 2));
            graphics.FillEllipse(solidBrush, new Rectangle(form.Width - r * 2 - 1, form.Height - r * 2 - 1, r * 2, r * 2));
            graphics.FillEllipse(solidBrush, new Rectangle(1, form.Height - r * 2 - 1, r * 2, r * 2));
            graphics.Dispose();
            form.BackgroundImage = bitmap;
        }
        public static Bitmap GetSquareBitmap(Bitmap src, int newsize)
        {
            int num = Math.Max(src.Height, src.Width);
            Bitmap bitmap = new Bitmap(num, num);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.FromArgb(0, 0, 0, 0));
            graphics.DrawImage(src, (num - src.Width) / 2, (num - src.Height) / 2, src.Width, src.Height);
            graphics.Dispose();
            return new Bitmap(bitmap, new Size(newsize, newsize));
        }
        public static byte[] LimitedImageData(Bitmap src, int xlim, int ylim)
        {
            ImageFormat rawFormat = src.RawFormat;
            MemoryStream memoryStream = new MemoryStream();
            src.Save(memoryStream, rawFormat);
            return memoryStream.ToArray();
        }
        public static Bitmap CreateBitmap(int width, int height, Color col)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(col);
            graphics.Dispose();
            return bitmap;
        }
        public static float Clamp(float val, float min, float max)
        {
            return Math.Min(Math.Max(val, min), max);
        }
    }
}
