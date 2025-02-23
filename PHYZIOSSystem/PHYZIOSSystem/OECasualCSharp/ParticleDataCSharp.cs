using System;
using System.Collections.Generic;
using System.Windows.Media;
using oec;
namespace OECasualCSharp
{
    public class ParticleDataCSharp
    {
        public ParticleDataManaged Data { get; private set; }
        internal int Count
        {
            get
            {
                return this.Data.Count;
            }
        }
        public ParticleInfoManaged ExistingInfo
        {
            get
            {
                return this.Data.ExistingInfo;
            }
        }
        internal int SelectedBody
        {
            get
            {
                return this.Data.SelectedBody;
            }
        }
        internal StlVectorManaged BodiesArray
        {
            get
            {
                return this.Data.BodiesArray;
            }
        }
        internal int BodiesSize
        {
            get
            {
                return this.Data.BodiesSize;
            }
        }
        internal List<ParticleNeighborManaged> Neighbors
        {
            get
            {
                return this.Data.Neighbors;
            }
        }
        public ParticleDataCSharp(ParticleDataManaged data)
        {
            this.Data = data;
        }
        internal void UpdateExistingInfo()
        {
            this.Data.UpdateExistingInfo();
        }
        internal void SearchParticleNeighbors()
        {
            this.Data.TagBuckets();
            this.SortBuckets();
            this.Data.CreateNeighbors();
        }
        private void SortBuckets()
        {
            this.Data.SortBuckets();
        }
        internal void Gc()
        {
            this.Data.Gc();
        }
        private bool IsNear(Particle p0, Particle p1)
        {
            return this.Distance2(p0, p1) < 1f;
        }
        private float Distance2(Particle p0, Particle p1)
        {
            float num = p0.X - p1.X;
            float num2 = p0.Y - p1.Y;
            return num * num + num2 * num2;
        }
        public static Color ColorForInfo(ParticleInfoManaged info, int palette)
        {
            return ParticleDataManaged.ColorForInfo(info, palette);
        }
        internal void Clear()
        {
            this.Data.Clear();
        }
        internal ParticleInfoManaged GetInfo(int a)
        {
            return this.Data.GetInfo(a);
        }
        internal Float2Managed GetCenter(int a)
        {
            return this.Data.GetCenter(a);
        }
        internal Color GetColor(int i)
        {
            return this.Data.GetColor(i);
        }
        internal void UpdateBodyTransforms()
        {
            this.Data.UpdateBodyTransforms();
        }
        internal ParticleBodyManaged GetBody(int i)
        {
            return this.Data.get_Bodies(i);
        }
        internal int GetBodyID(int a)
        {
            return this.Data.get_BodyID(a);
        }
        internal Float2Managed GetOrigin(int a)
        {
            return this.Data.get_Origin(a);
        }
        internal void SetInfo(int a, ParticleInfoManaged particleInfoManaged)
        {
            this.Data.set_Info(a, particleInfoManaged);
        }
        internal float GetSpin(int a)
        {
            return this.Data.get_Spin(a);
        }
        internal void SetSpin(int a, float p)
        {
            this.Data.set_Spin(a, p);
        }
        internal void ExpressAxis(ModuleDataManaged modules)
        {
            for (int i = 0; i < this.BodiesSize; i++)
            {
                ParticleBodyManaged bodies = this.GetBodies(i);
                if (bodies.Transform.Mass > 0f)
                {
                    ModuleManaged moduleManaged = modules.RequestModule(bodies.Module);
                    if (moduleManaged != null && moduleManaged.DisplacementXConstraint == null && moduleManaged.DisplacementYConstraint == null)
                    {
                        moduleManaged.AxisCenter = bodies.Transform.Center / bodies.Transform.Mass;
                        moduleManaged.AxisOrigin = bodies.Transform.Origin / bodies.Transform.Mass;
                        moduleManaged.DisplacementXConstraint = AbstractScriptManaged.ExpressionWithString("0");
                        moduleManaged.DisplacementYConstraint = AbstractScriptManaged.ExpressionWithString("0");
                        bodies.Module = moduleManaged;
                    }
                }
            }
        }
        private ParticleBodyManaged GetBodies(int i)
        {
            return this.Data.get_Bodies(i);
        }
        internal void ExpressJet(ModuleDataManaged modules)
        {
            if (this.BodiesSize < 1)
            {
                return;
            }
            for (int i = 1; i < this.BodiesSize; i++)
            {
                ParticleBodyManaged bodies = this.GetBodies(i);
                Float2Managed float2Managed = bodies.Transform.Velocity / bodies.Transform.Mass;
                float num = bodies.Transform.Spin / bodies.Transform.Moment;
                if (float2Managed.X != 0f)
                {
                    bodies.Module = modules.RequestModule(bodies.Module);
                    bodies.Module.ForceXConstraint = AbstractScriptManaged.ExpressionWithString(float2Managed.X.ToString());
                }
                if (float2Managed.Y != 0f)
                {
                    bodies.Module = modules.RequestModule(bodies.Module);
                    bodies.Module.ForceYConstraint = AbstractScriptManaged.ExpressionWithString(float2Managed.Y.ToString());
                }
                if (num != 0f)
                {
                    bodies.Module = modules.RequestModule(bodies.Module);
                    bodies.Module.TorqueConstraint = AbstractScriptManaged.ExpressionWithString(num.ToString());
                }
            }
        }
        internal void ActivateModules()
        {
            this.Data.ActivateModules();
        }
        private const int all_bits = 32;
        private const int x_frac_bits = 4;
        private const int x_int_bits = 14;
        private const int x_bits = 18;
        private const int y_bits = 14;
        private const int x_unit = 16;
        private const int y_unit = 262144;
        private const int x_mask = 262143;
        private const int x_sign_bit = 131072;
        private ScreenBucketArray sba = new ScreenBucketArray();
        private List<ParticlePair> pairs = new List<ParticlePair>();
        private List<ParticlePair> pairs0 = new List<ParticlePair>();
        private List<ParticlePair> pairs1 = new List<ParticlePair>();
    }
}
