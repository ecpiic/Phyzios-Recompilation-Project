using System;
using System.Windows.Media;
using oec;
namespace OECasualCSharp
{
    public class ParticleBuilderCSharp
    {
        internal Float2Managed AxisOfSelectedBody
        {
            set
            {
                this.particleBuilder.AxisOfSelectedBody = value;
            }
        }
        public ParticleBuilderCSharp(ConfigurationManaged config, ParticleDataManaged particles, ModuleDataManaged modules)
        {
            this.particleBuilder = new ParticleBuilderManaged(config, particles, modules);
            this.config = config;
            this.particles = particles;
            this.modules = modules;
        }
        internal void DragParticles(Float2Managed start, Float2Managed end)
        {
            this.particleBuilder.DragParticles(start, end);
        }
        internal Float2Managed CenterOfParticles(ParticleInfoManaged mask)
        {
            return this.particleBuilder.CenterOfParticles(mask);
        }
        internal void SelectAllParticles()
        {
            this.particleBuilder.SelectAllParticles();
        }
        internal void UnselectAllParticles()
        {
            this.particleBuilder.UnselectAllParticles();
        }
        internal void FreezeParticles()
        {
            this.particleBuilder.FreezeParticles();
        }
        public int CountParticles(ParticleInfoManaged mask)
        {
            return this.particleBuilder.CountParticles(mask);
        }
        public void EraseParticles(ParticleInfoManaged mask)
        {
            this.particleBuilder.EraseParticles(mask);
        }
        internal void Scroll(float x, float y)
        {
            this.particleBuilder.Scroll(x, y);
        }
        internal void MoveParticles(float x, float y, ParticleInfoManaged mask)
        {
            this.particleBuilder.MoveParticles(x, y, mask);
        }
        internal Float2Managed MaterialLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.MaterialLine(start, end);
        }
        internal Float2Managed ColorLine(Float2Managed start, Float2Managed end, Color color)
        {
            return this.particleBuilder.ColorLine(start, end, color);
        }
        internal Float2Managed SliceLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.SliceLine(start, end);
        }
        internal Float2Managed EraseLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.EraseLine(start, end);
        }
        internal void DragAllParticles(Float2Managed line)
        {
            this.particleBuilder.DragAllParticles(line);
        }
        internal void RotateParticles(Float2Managed start, Float2Managed end, int mask)
        {
            this.particleBuilder.RotateParticles(start, end, mask);
        }
        internal void MoveParticles(Float2Managed line, int mask)
        {
            this.particleBuilder.MoveParticles(line, mask);
        }
        internal Float2Managed DrawMarkerLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.DrawMarkerLine(start, end);
        }
        internal Float2Managed DrawPencilLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.DrawPencilLine(start, end);
        }
        internal void DrawPencilDot(Float2Managed start)
        {
            float standardDistance = this.config.StandardDistance;
            float num;
            float num2;
            float num3;
            float num4;
            this.GetDrawableBounds(out num, out num2, out num3, out num4);
            Float2Managed float2Managed = new Float2Managed(Math.Max(num, Math.Min(start.X, num3)), Math.Max(num2, Math.Min(start.Y, num4)));
            Float2Managed float2Managed2 = float2Managed;
            int num5 = this.particles.CreateParticle(this.particleBuilder.CurrentBody);
            this.particles.set_Info(num5, this.particleBuilder.CurrentInfo);
            this.particles.set_Color(num5, this.particleBuilder.CurrentColor);
            this.particles.set_Center(num5, float2Managed2);
            if (this.particleBuilder.AppendingToBody)
            {
                TransformManaged transform = this.particles.get_Bodies(this.particleBuilder.CurrentBody).Transform;
                this.particles.set_Origin(num5, Matrix22.Inverse(transform.Rotation) * float2Managed2 - transform.Center + transform.Origin);
                return;
            }
            this.particles.set_Origin(num5, float2Managed2);
        }
        private void GetDrawableBounds(out float xmin, out float ymin, out float xmax, out float ymax)
        {
            xmin = this.config.BoundsLeft;
            xmax = this.config.BoundsRight;
            ymin = this.config.BoundsBottom;
            ymax = this.config.BoundsTop;
            if ((this.particleBuilder.CurrentInfo & ParticleInfoManaged.Wall) == ParticleInfoManaged.Wall)
            {
                xmin -= 2f;
                xmax += 2f;
                ymin -= 2f;
                ymax += 2f;
                return;
            }
            xmin += 1f;
            xmax -= 1f;
            ymin += 1f;
            ymax -= 1f;
        }
        internal Float2Managed DrawBrushLine(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.DrawBrushLine(start, end);
        }
        internal void PrepareForDrawing(Float2Managed mouseLocation, EventManagerManaged eventManager, MouseButtonManaged mask)
        {
            this.particleBuilder.PrepareForDrawing(mouseLocation, eventManager, mask);
        }
        internal void FillRegion(Float2Managed mouseLocation, EventManagerManaged eventManager)
        {
            this.particleBuilder.FillRegion(mouseLocation, eventManager);
        }
        internal void SplitNearestTexturedBody(Float2Managed mouseLocation)
        {
            this.particleBuilder.SplitNearestTexturedBody(mouseLocation);
        }
        internal int NearestBody(Float2Managed mouseLocation)
        {
            return this.particleBuilder.NearestBody(mouseLocation);
        }
        internal void SelectBody(Float2Managed mouseLocation)
        {
            this.particleBuilder.SelectBody(mouseLocation);
        }
        internal int NearestParticle(Float2Managed center)
        {
            return this.particleBuilder.NearestParticle(center);
        }
        internal bool UnselectRect(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.UnselectRect(start, end);
        }
        internal void UnselectBody(Float2Managed position)
        {
            this.particleBuilder.UnselectBody(position);
        }
        internal bool SelectRect(Float2Managed start, Float2Managed end)
        {
            return this.particleBuilder.SelectRect(start, end);
        }
        internal void FillShapeRectangle(Float2Managed start, Float2Managed end, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeRectangle(start, end, info, color);
        }
        internal void FillShapeOval(Float2Managed start, Float2Managed end, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeOval(start, end, info, color);
        }
        internal void FillShapeCircle(Float2Managed origin, float radius, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeCircle(origin, radius, info, color);
        }
        internal void FillShapeTriangle(Float2Managed a, Float2Managed b, Float2Managed c, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeTriangle(a, b, c, info, color);
        }
        internal void FillShapeSquare(Float2Managed a, float b, Float2Managed c, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeSquare(a, b, c, info, color);
        }
        internal void FillShapeStar(Float2Managed a, float b, Float2Managed c, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeStar(a, b, c, info, color);
        }
        internal void FillShapeHeart(Float2Managed a, float b, Float2Managed c, ParticleInfoManaged info, Color color)
        {
            this.particleBuilder.FillShapeHeart(a, b, c, info, color);
        }
        internal void LinkLine(Float2Managed a, Float2Managed b, Color color)
        {
            this.particleBuilder.LinkLine(a, b, color);
        }
        internal void FillTexture(TextureManaged texture, Float2Managed a, Float2Managed b, ParticleInfoManaged info)
        {
            this.particleBuilder.FillTexture(texture, a, b, info);
        }
        public void SelectBody(int bodyid)
        {
            this.particleBuilder.SelectBody(bodyid);
        }
        public ParticleBuilderManaged particleBuilder;
        private ConfigurationManaged config;
        private ParticleDataManaged particles;
        private ModuleDataManaged modules;
    }
}
