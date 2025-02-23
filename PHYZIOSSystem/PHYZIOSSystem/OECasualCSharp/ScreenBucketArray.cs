using System;
using System.Collections.Generic;
using oec;
namespace OECasualCSharp
{
    internal class ScreenBucketArray
    {
        public Dictionary<int, ScreenBucket> Buckets
        {
            get
            {
                return this.buckets;
            }
        }
        public int NumHorizontalBuckets
        {
            get
            {
                return 74;
            }
        }
        public int MemoryWidth
        {
            get
            {
                return this.NumHorizontalBuckets + this.buffer * 2;
            }
        }
        public int MemoryHeight
        {
            get
            {
                return this.NumVerticalBuckets + this.buffer * 2;
            }
        }
        public int NumVerticalBuckets
        {
            get
            {
                return 50;
            }
        }
        public ScreenBucketArray()
        {
            this.buckets = new Dictionary<int, ScreenBucket>();
            this.bucketPairs = new List<ScreenBucketPair>();
        }
        internal int IndexX(Float2Managed f)
        {
            return (int)f.X;
        }
        internal int IndexY(Float2Managed f)
        {
            return (int)f.Y;
        }
        internal void AddParticle(Particle p)
        {
            int num = (int)p.X;
            int num2 = (int)p.Y;
            int num3 = this.Index(num, num2);
            if (!this.buckets.ContainsKey(num3))
            {
                ScreenBucket screenBucket = new ScreenBucket();
                screenBucket.X = num;
                screenBucket.Y = num2;
                this.buckets[num3] = screenBucket;
                this.SetAround(screenBucket);
            }
            this.buckets[num3].Add(p);
        }
        private void SetAround(ScreenBucket bucket)
        {
            this.AddPairsIfExists(bucket, this.Index(bucket.X - 1, bucket.Y - 1));
            this.AddPairsIfExists(bucket, this.Index(bucket.X - 1, bucket.Y));
            this.AddPairsIfExists(bucket, this.Index(bucket.X - 1, bucket.Y + 1));
            this.AddPairsIfExists(bucket, this.Index(bucket.X, bucket.Y - 1));
            this.AddPairsIfExists(bucket, this.Index(bucket.X, bucket.Y + 1));
            this.AddPairsIfExists(bucket, this.Index(bucket.X + 1, bucket.Y - 1));
            this.AddPairsIfExists(bucket, this.Index(bucket.X + 1, bucket.Y));
            this.AddPairsIfExists(bucket, this.Index(bucket.X + 1, bucket.Y + 1));
        }
        private void AddPairsIfExists(ScreenBucket bucket, int sw)
        {
            if (this.buckets.ContainsKey(sw))
            {
                this.bucketPairs.Add(new ScreenBucketPair(bucket, this.buckets[sw]));
            }
        }
        internal void Clear()
        {
            this.buckets.Clear();
            this.bucketPairs.Clear();
        }
        private int Index(int i, int j)
        {
            return i + this.buffer + this.MemoryWidth * (j + this.buffer);
        }
        private List<ParticlePair> MakePairs(ScreenBucket bucket0, ScreenBucket bucket1)
        {
            List<ParticlePair> list = new List<ParticlePair>();
            foreach (Particle particle in bucket0.Positions)
            {
                foreach (Particle particle2 in bucket1.Positions)
                {
                    list.Add(new ParticlePair(particle, particle2));
                }
            }
            return list;
        }
        internal IEnumerable<ParticlePair> GetPairsByBuckets()
        {
            List<ParticlePair> list = new List<ParticlePair>();
            foreach (ScreenBucketPair screenBucketPair in this.bucketPairs)
            {
                list.AddRange(this.MakePairs(screenBucketPair.B0, screenBucketPair.B1));
            }
            return list;
        }
        private Dictionary<int, ScreenBucket> buckets;
        private int buffer = 5;
        private List<ScreenBucketPair> bucketPairs;
    }
}
