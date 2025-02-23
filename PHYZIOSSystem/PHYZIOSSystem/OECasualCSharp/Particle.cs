using System;
using oec;
namespace OECasualCSharp
{
    public class Particle
    {
        public int Index { get; private set; }
        public float X
        {
            get
            {
                return this.f.X;
            }
        }
        public float Y
        {
            get
            {
                return this.f.Y;
            }
        }
        public Particle(int index, Float2Managed f)
        {
            this.Index = index;
            this.f = f;
        }
        private Float2Managed f;
    }
}
