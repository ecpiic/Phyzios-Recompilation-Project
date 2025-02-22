using System;
namespace WindowsViewer
{
    internal class SizeChanger
    {
        public int Left { get; private set; }
        public int Top { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public SizeChanger(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        internal void Execute(int clientWidth, int clientHeight)
        {
            int num = this.Height * clientWidth / clientHeight;
            if (num > this.Width)
            {
                int num2 = this.Width * clientHeight / clientWidth;
                this.Top = (this.Height - num2) / 2;
                this.Height = num2;
                return;
            }
            this.Left = (this.Width - num) / 2;
            this.Width = num;
        }
    }
}
