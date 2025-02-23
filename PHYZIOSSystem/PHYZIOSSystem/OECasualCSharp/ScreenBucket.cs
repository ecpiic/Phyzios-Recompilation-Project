using System;
using System.Collections.Generic;
namespace OECasualCSharp
{
    public class ScreenBucket
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IList<Particle> Positions
        {
            get
            {
                return this.positions.AsReadOnly();
            }
        }
        public int CountParticles
        {
            get
            {
                return this.positions.Count;
            }
        }
        public Particle this[int index]
        {
            get
            {
                return this.positions[index];
            }
        }
        public ScreenBucket()
        {
            this.positions = new List<Particle>();
            this.pair = new List<ParticlePair>();
        }
        public void Clear()
        {
            this.positions.Clear();
        }
        internal void Add(Particle particle)
        {
            foreach (Particle particle2 in this.positions)
            {
                this.pair.Add(new ParticlePair(particle2, particle));
            }
            this.positions.Add(particle);
        }
        internal List<ParticlePair> GetPairs()
        {
            return this.pair;
        }
        private List<Particle> positions;
        private List<ParticlePair> pair;
    }
}
