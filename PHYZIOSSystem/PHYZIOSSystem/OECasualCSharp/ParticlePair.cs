using System;
namespace OECasualCSharp
{
    public class ParticlePair
    {
        public Particle P0 { get; private set; }
        public Particle P1 { get; private set; }
        public ParticlePair(Particle p0, Particle p1)
        {
            this.P0 = p0;
            this.P1 = p1;
        }
    }
}
