using System;
using oec;
namespace OECasualCSharp
{
    public class SoundManagerCSharp
    {
        public SoundManagerCSharp(ConfigurationManaged config, ParticleDataCSharp particles, EffectDataManaged effects)
        {
            this.m_particles = particles.Data;
            this.m_config = config;
            this.m_effects = effects;
            this.playing = false;
        }
        ~SoundManagerCSharp()
        {
            if (this.playing)
            {
                this.Stop();
            }
        }
        internal void Play()
        {
            this.m_particles.UpdateExistingInfo();
            if ((this.m_config.FlowSound != null && (this.m_particles.ExistingInfo & ParticleInfoManaged.Aqua) == ParticleInfoManaged.Aqua) || (this.m_config.StoneSound != null && (this.m_particles.ExistingInfo & ParticleInfoManaged.Rigid) == ParticleInfoManaged.Rigid) || (this.m_config.MeatSound != null && (this.m_particles.ExistingInfo & (ParticleInfoManaged.Mochi | ParticleInfoManaged.Elastic)) != ParticleInfoManaged.None))
            {
                this.m_particles.SearchParticleNeighbors();
            }
            float num = 1f / (this.m_config.BoundsWidth * this.m_config.BoundsHeight);
            if (this.m_config.WaveSound != null && this.m_config.WaveSoundCoefficient > 0f)
            {
                float num2 = 0f;
                if ((this.m_particles.ExistingInfo & ParticleInfoManaged.Aqua) == ParticleInfoManaged.Aqua)
                {
                    for (int i = 0; i < this.m_particles.Count; i++)
                    {
                        ParticleInfoManaged particleInfoManaged = this.m_particles.get_Info(i);
                        if ((particleInfoManaged & (ParticleInfoManaged.Aqua | ParticleInfoManaged.Gas)) != ParticleInfoManaged.None)
                        {
                            Float2Managed float2Managed = this.m_particles.get_Velocity(i);
                            num2 += Float2Managed.Dot(float2Managed, float2Managed);
                        }
                    }
                }
                float num3 = this.m_config.WaveSoundCoefficient * num * num2;
                if (num3 > this.m_config.MinVolume)
                {
                    this.m_config.WaveSound.Loops = true;
                    this.m_config.WaveSound.Volume = num3;
                    this.m_config.WaveSound.Play();
                }
                else
                {
                    this.m_config.WaveSound.Loops = false;
                    this.m_config.WaveSound.Volume = 0f;
                }
            }
            if (this.m_config.FlowSound != null && this.m_config.FlowSoundCoefficient > 0f)
            {
                float num4 = 0f;
                if ((this.m_particles.ExistingInfo & ParticleInfoManaged.Aqua) == ParticleInfoManaged.Aqua)
                {
                    foreach (ParticleNeighborManaged particleNeighborManaged in this.m_particles.Neighbors)
                    {
                        int index = particleNeighborManaged.Index0;
                        int index2 = particleNeighborManaged.Index1;
                        if ((this.m_particles.get_Info(index) & this.m_particles.get_Info(index2) & ParticleInfoManaged.Aqua) == ParticleInfoManaged.Aqua && ((this.m_particles.get_Info(index) | this.m_particles.get_Info(index2)) & ParticleInfoManaged.Gas) != ParticleInfoManaged.Gas)
                        {
                            Float2Managed float2Managed2 = this.m_particles.get_Velocity(index2) - this.m_particles.get_Velocity(index);
                            num4 += Float2Managed.Dot(float2Managed2, float2Managed2);
                        }
                    }
                }
                float num5 = this.m_config.FlowSoundCoefficient * num * num4;
                if (num5 > this.m_config.MinVolume)
                {
                    this.m_config.FlowSound.Loops = true;
                    this.m_config.FlowSound.Volume = num5;
                    this.m_config.FlowSound.Play();
                }
                else
                {
                    this.m_config.FlowSound.Loops = false;
                    this.m_config.FlowSound.Volume = 0f;
                }
            }
            if (this.m_config.FireSound != null && this.m_config.FireSoundCoefficient > 0f)
            {
                if (this.m_effects.GetCount(EffectTypeManaged.Fire) > 0)
                {
                    this.m_config.FireSound.Volume = this.m_config.FireSoundCoefficient * num * (float)this.m_effects.GetCount(EffectTypeManaged.Fire);
                    this.m_config.FireSound.Play();
                }
                else if (this.m_config.FireSound.IsPlaying)
                {
                    this.m_config.FireSound.Stop();
                }
            }
            if (this.m_config.StoneSound != null && this.m_config.StoneSoundCoefficient > 0f)
            {
                float num6 = 0f;
                if ((this.m_particles.ExistingInfo & ParticleInfoManaged.Rigid) == ParticleInfoManaged.Rigid)
                {
                    foreach (ParticleNeighborManaged particleNeighborManaged2 in this.m_particles.Neighbors)
                    {
                        int index3 = particleNeighborManaged2.Index0;
                        int index4 = particleNeighborManaged2.Index1;
                        if (this.m_particles.get_BodyID(index3) != this.m_particles.get_BodyID(index4) && (this.m_particles.get_Info(index3) & (ParticleInfoManaged.Wall | ParticleInfoManaged.Rigid)) != ParticleInfoManaged.None && (this.m_particles.get_Info(index4) & (ParticleInfoManaged.Wall | ParticleInfoManaged.Rigid)) != ParticleInfoManaged.None)
                        {
                            Float2Managed normal = particleNeighborManaged2.Normal;
                            Float2Managed float2Managed3 = this.m_particles.get_Velocity(index4) - this.m_particles.get_Velocity(index3);
                            float num7 = Float2Managed.Dot(float2Managed3, normal);
                            num6 += num7 * num7;
                        }
                    }
                }
                float num8 = this.m_config.StoneSoundCoefficient * num * num6;
                if (num8 > this.m_config.MinVolume)
                {
                    this.m_config.StoneSound.Volume = num8;
                    this.m_config.StoneSound.Play();
                }
                else
                {
                    this.m_config.StoneSound.Volume = 0f;
                }
            }
            if (this.m_config.MeatSound != null && this.m_config.MeatSoundCoefficient > 0f)
            {
                float num9 = 0f;
                if ((this.m_particles.ExistingInfo & (ParticleInfoManaged.Mochi | ParticleInfoManaged.Elastic)) != ParticleInfoManaged.None)
                {
                    foreach (ParticleNeighborManaged particleNeighborManaged3 in this.m_particles.Neighbors)
                    {
                        int index5 = particleNeighborManaged3.Index0;
                        int index6 = particleNeighborManaged3.Index1;
                        if (((this.m_particles.get_Info(index5) | this.m_particles.get_Info(index6)) & (ParticleInfoManaged.Mochi | ParticleInfoManaged.Elastic)) != ParticleInfoManaged.None)
                        {
                            Float2Managed float2Managed4 = this.m_particles.get_Velocity(index6) - this.m_particles.get_Velocity(index5);
                            num9 += Float2Managed.Dot(float2Managed4, float2Managed4);
                        }
                    }
                }
                float num10 = this.m_config.MeatSoundCoefficient * num * num9;
                if (num10 > this.m_config.MinVolume)
                {
                    this.m_config.MeatSound.Volume = num10;
                    this.m_config.MeatSound.Play();
                }
                else
                {
                    this.m_config.MeatSound.Volume = 0f;
                }
            }
            if (this.m_config.ExplodeSound != null && (this.m_particles.ExistingInfo & ParticleInfoManaged.Powder) == ParticleInfoManaged.Powder && (this.m_particles.ExistingInfo & ParticleInfoManaged.Hot) == ParticleInfoManaged.Hot)
            {
                for (int j = 0; j < this.m_particles.Count; j++)
                {
                    ParticleInfoManaged particleInfoManaged2 = this.m_particles.get_Info(j);
                    if ((particleInfoManaged2 & ParticleInfoManaged.Powder) == ParticleInfoManaged.Powder && (particleInfoManaged2 & ParticleInfoManaged.Hot) == ParticleInfoManaged.Hot)
                    {
                        this.m_config.ExplodeSound.Volume = 0.5f;
                        this.m_config.ExplodeSound.Play();
                        break;
                    }
                }
            }
            this.playing = true;
        }
        internal void Stop()
        {
            if (this.playing)
            {
                if (this.m_config.FlowSound != null)
                {
                    this.m_config.FlowSound.Stop();
                }
                if (this.m_config.WaveSound != null)
                {
                    this.m_config.WaveSound.Stop();
                }
                if (this.m_config.FireSound != null)
                {
                    this.m_config.FireSound.Stop();
                }
                if (this.m_config.StoneSound != null)
                {
                    this.m_config.StoneSound.Stop();
                }
                if (this.m_config.WoodSound != null)
                {
                    this.m_config.WoodSound.Stop();
                }
                if (this.m_config.MeatSound != null)
                {
                    this.m_config.MeatSound.Stop();
                }
                if (this.m_config.ExplodeSound != null)
                {
                    this.m_config.ExplodeSound.Stop();
                }
                this.playing = false;
            }
        }
        internal void SetFlowSound(IntPtr ptr, int size)
        {
            this.m_config.FlowSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetWaveSound(IntPtr ptr, int size)
        {
            this.m_config.WaveSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetFireSound(IntPtr ptr, int size)
        {
            this.m_config.FireSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetStoneSound(IntPtr ptr, int size)
        {
            this.m_config.StoneSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetWoodSound(IntPtr ptr, int size)
        {
            this.m_config.WoodSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetMeatSound(IntPtr ptr, int size)
        {
            this.m_config.MeatSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        internal void SetExplodeSound(IntPtr ptr, int size)
        {
            this.m_config.ExplodeSound = SoundManaged.WithContentsOfMemory(ptr, size);
        }
        private ParticleDataManaged m_particles;
        private ConfigurationManaged m_config;
        private EffectDataManaged m_effects;
        private bool playing;
    }
}
