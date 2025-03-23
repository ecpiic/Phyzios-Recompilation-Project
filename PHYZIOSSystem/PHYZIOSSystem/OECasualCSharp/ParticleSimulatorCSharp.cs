using System;
using oec;
namespace OECasualCSharp
{
    public class ParticleSimulatorCSharp
    {
        public ParticleSimulatorManaged ParticleSimulator { get; private set; }
        public ParticleDataCSharp Data { get; private set; }
        private bool NeedsGC
        {
            get
            {
                return this.ParticleSimulator.NeedsGC;
            }
            set
            {
                this.ParticleSimulator.NeedsGC = value;
            }
        }
        public bool HasUsers
        {
            get
            {
                return this.ParticleSimulator.HasUsers;
            }
        }
        public ParticleSimulatorCSharp(ParticleSimulatorManaged simulator)
        {
            this.ParticleSimulator = simulator;
            this.config = simulator.Config;
            this.Data = new ParticleDataCSharp(simulator.Data);
            this.modules = simulator.Modules;
        }
        internal void Simulate()
        {
            if (!this.config.PauseFlag)
            {
                this.Data.UpdateExistingInfo();
                this.MoveParticles();
                this.SearchBoundParticles();
                this.Data.SearchParticleNeighbors();
                this.JoinParticles();
                this.GravitateParticles();
                this.UpdateParticleDensity();
                this.ApplyStaticPressure();
                this.ApplyPressure();
                this.SearchBoundParticles();
                this.CollideParticles();
                this.ExpressMochi();
                this.ExpressTensile();
                this.ExpressYuki();
                this.ExpressViscous();
                this.ExpressPowder();
                this.ExpressKome();
                this.ExpressLight();
                this.ExpressDense();
                this.ExpressElastic();
                this.ExpressSpring();
                this.ExpressBrittle();
                this.ExpressUsers();
                this.ExpressAxis();
                this.ExpressJet();
                this.ExpressLinked();
                this.ExpressWall();
                this.Data.UpdateBodyTransforms();
                this.ExpressRigid();
                this.Data.ActivateModules();
                this.ExpressAqua();
                this.ExpressFuel();
                this.ExpressHot();
                this.ExpressCold();
                this.ExpressNatual();
                this.ExpressInflow();
                this.ExpressOutflow();
                this.ExpressTextured();
                this.ResistParticles();
                this.FixStorableParticles();
                this.PourParticles();
                this.DrainParticles();
                if (this.NeedsGC)
                {
                    this.Data.Gc();
                    this.NeedsGC = false;
                }
            }
        }
        private void MoveParticles()
        {
            this.ParticleSimulator.MoveParticles();
        }
        private void SearchBoundParticles()
        {
            this.ParticleSimulator.SearchBoundParticles();
        }
        private void JoinParticles()
        {
            this.ParticleSimulator.JoinParticles();
        }
        private void GravitateParticles()
        {
            this.ParticleSimulator.GravitateParticles();
        }
        private void UpdateParticleDensity()
        {
            this.ParticleSimulator.UpdateParticleDensity();
        }
        private void ApplyStaticPressure()
        {
            this.ParticleSimulator.ApplyStaticPressure();
        }
        private void ApplyPressure()
        {
            this.ParticleSimulator.ApplyPressure();
        }
        private void CollideParticles()
        {
            this.ParticleSimulator.CollideParticles();
        }
        private void ExpressTextured()
        {
            this.ParticleSimulator.ExpressTextured();
        }
        private void ExpressOutflow()
        {
            this.ParticleSimulator.ExpressOutflow();
        }
        private void ExpressInflow()
        {
            this.ParticleSimulator.ExpressInflow();
        }
        private void ExpressNatual()
        {
            this.ParticleSimulator.ExpressNatual();
        }
        private void ExpressCold()
        {
            this.ParticleSimulator.ExpressCold();
        }
        private void ExpressHot()
        {
            this.ParticleSimulator.ExpressHot();
        }
        private void ExpressFuel()
        {
            this.ParticleSimulator.ExpressFuel();
        }
        private void ExpressAqua()
        {
            this.ParticleSimulator.ExpressAqua();
        }
        private void ExpressRigid()
        {
            this.ParticleSimulator.ExpressRigid();
        }
        private void ExpressWall()
        {
            this.ParticleSimulator.ExpressWall();
        }
        private void ExpressLinked()
        {
            this.ParticleSimulator.ExpressLinked();
        }
        private void ExpressJet()
        {
            if ((this.Data.ExistingInfo & ParticleInfoManaged.Jet) != ParticleInfoManaged.Jet)
            {
                return;
            }
            for (int i = 0; i < this.Data.BodiesSize; i++)
            {
                ParticleBodyManaged body = this.Data.GetBody(i);
                body.Transform.Mass = 0f;
                body.Transform.Moment = 0f;
                body.Transform.Center = default(Float2Managed);
                body.Transform.Velocity = default(Float2Managed);
                body.Transform.Spin = 0f;
            }
            for (int j = 0; j < this.Data.Count; j++)
            {
                ParticleBodyManaged body2 = this.Data.GetBody(this.Data.GetBodyID(j));
                body2.Transform.Mass += 1f;
                body2.Transform.Moment += Float2Managed.Dot(this.Data.GetCenter(j), this.Data.GetCenter(j)) + 1f;
                body2.Transform.Center += this.Data.GetCenter(j);
            }
            for (int k = 0; k < this.Data.BodiesSize; k++)
            {
                ParticleBodyManaged body3 = this.Data.GetBody(k);
                Float2Managed center = body3.Transform.Center;
                float mass = body3.Transform.Mass;
                body3.Transform.Center = center / mass;
                body3.Transform.Moment -= Float2Managed.Dot(center, center) / mass;
            }
            foreach (ParticleNeighborManaged particleNeighborManaged in this.Data.Neighbors)
            {
                int index = particleNeighborManaged.Index0;
                int index2 = particleNeighborManaged.Index1;
                Float2Managed float2Managed = new Float2Managed(0f, -0.025f * particleNeighborManaged.Weight);
                if ((this.Data.GetInfo(index) & ParticleInfoManaged.Jet) == ParticleInfoManaged.Jet)
                {
                    ParticleBodyManaged body4 = this.Data.GetBody(this.Data.GetBodyID(index));
                    body4.Transform.Velocity -= float2Managed;
                }
            }
            this.Data.ExpressJet(this.modules);
            for (int l = 0; l < this.Data.Count; l++)
            {
                this.Data.SetInfo(l, this.Data.GetInfo(l) & ~ParticleInfoManaged.Jet);
            }
        }
        private void ExpressAxis()
        {
            if ((this.Data.ExistingInfo & ParticleInfoManaged.Axis) != ParticleInfoManaged.Axis)
            {
                return;
            }
            float axisInitialSpin = this.config.AxisInitialSpin;
            for (int i = 0; i < this.Data.BodiesArray.Size; i++)
            {
                this.Data.GetBody(i).Transform.Mass = 0f;
                this.Data.GetBody(i).Transform.Center = new Float2Managed(0f, 0f);
                this.Data.GetBody(i).Transform.Origin = new Float2Managed(0f, 0f);
            }
            for (int j = 0; j < this.Data.Count; j++)
            {
                if ((this.Data.GetInfo(j) & ParticleInfoManaged.Axis) == ParticleInfoManaged.Axis)
                {
                    ParticleBodyManaged body = this.Data.GetBody(this.Data.GetBodyID(j));
                    body.Transform.Mass += 1f;
                    body.Transform.Center += this.Data.GetCenter(j);
                    body.Transform.Origin += this.Data.GetOrigin(j);
                    this.Data.SetInfo(j, this.Data.GetInfo(j) & ~ParticleInfoManaged.Axis);
                    this.Data.SetSpin(j, this.Data.GetSpin(j) + axisInitialSpin);
                }
            }
            this.Data.ExpressAxis(this.modules);
        }
        private void ExpressUsers()
        {
            this.ParticleSimulator.ExpressUsers();
        }
        private void ExpressBrittle()
        {
            this.ParticleSimulator.ExpressBrittle();
        }
        private void ExpressSpring()
        {
            this.ParticleSimulator.ExpressSpring();
        }
        private void ExpressElastic()
        {
            this.ParticleSimulator.ExpressElastic();
        }
        private void ExpressDense()
        {
            this.ParticleSimulator.ExpressDense();
        }
        private void ExpressLight()
        {
            this.ParticleSimulator.ExpressLight();
        }
        private void ExpressKome()
        {
            this.ParticleSimulator.ExpressKome();
        }
        private void ExpressPowder()
        {
            this.ParticleSimulator.ExpressPowder();
        }
        private void ExpressViscous()
        {
            this.ParticleSimulator.ExpressViscous();
        }
        private void ExpressYuki()
        {
            this.ParticleSimulator.ExpressYuki();
        }
        private void ExpressTensile()
        {
            this.ParticleSimulator.ExpressTensile();
        }
        private void ExpressMochi()
        {
            this.ParticleSimulator.ExpressMochi();
        }
        private void ResistParticles()
        {
            this.ParticleSimulator.ResistParticles();
        }
        private void FixStorableParticles()
        {
            this.ParticleSimulator.FixStorableParticles();
        }
        private void PourParticles()
        {
            this.ParticleSimulator.PourParticles();
        }
        private void DrainParticles()
        {
            this.ParticleSimulator.DrainParticles();
        }
        private ConfigurationManaged config;
        private ModuleDataManaged modules;
    }
}
