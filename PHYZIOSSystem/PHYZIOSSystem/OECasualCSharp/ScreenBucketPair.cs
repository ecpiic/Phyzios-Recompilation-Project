using System;
namespace OECasualCSharp
{
    public class ScreenBucketPair
    {
        public ScreenBucket B0 { get; private set; }
        public ScreenBucket B1 { get; private set; }
        public ScreenBucketPair(ScreenBucket b0, ScreenBucket b1)
        {
            this.B0 = b0;
            this.B1 = b1;
        }
    }
}
