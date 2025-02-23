using System;
namespace OECasualCSharp
{
    public struct DrawReqSt
    {
        public DrawReqSt(string name, float minx, float miny, float maxx, float maxy, float alpha)
        {
            this.TextureName = name;
            this.MinX = minx;
            this.MinY = miny;
            this.MaxX = maxx;
            this.MaxY = maxy;
            this.Alpha = alpha;
        }
        public string TextureName;
        public float MinX;
        public float MinY;
        public float MaxX;
        public float MaxY;
        public float Alpha;
    }
}
