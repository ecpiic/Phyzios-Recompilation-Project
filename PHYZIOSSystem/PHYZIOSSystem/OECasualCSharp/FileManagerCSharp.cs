using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Media;
using oec;
using PHYZIOSSystem;
namespace OECasualCSharp
{
    public class FileManagerCSharp
    {
        public bool Store
        {
            get
            {
                return this.fileManager.Store;
            }
        }
        public FileManagerCSharp(FileManagerManaged fileManager)
        {
            this.fileManager = fileManager;
        }
        internal void Clear()
        {
            this.fileManager.Clear();
        }
        internal ModuleManaged ImportTest(SceneWrap scene, float x, float y, bool pool, string path)
        {
            return this.ImportTest(scene, x, y, pool, path, "");
        }
        internal ModuleManaged ImportTest(SceneWrap scene, float x, float y, bool pool, string path, string ap_id)
        {
            Float2Managed float2Managed = new Float2Managed(x, y);
            ConfigurationManaged configurationManaged = new ConfigurationManaged();
            ModuleDataManaged moduleDataManaged = new ModuleDataManaged();
            ParticleDataManaged particleDataManaged = new ParticleDataManaged();
            MeshDataManaged meshDataManaged = new MeshDataManaged();
            LatticeDataManaged latticeDataManaged = new LatticeDataManaged();
            EffectDataManaged effectDataManaged = new EffectDataManaged();
            ParticleBuilderManaged particleBuilderManaged = new ParticleBuilderManaged(configurationManaged, particleDataManaged, moduleDataManaged);
            LatticeBuilderManaged latticeBuilderManaged = new LatticeBuilderManaged(configurationManaged, latticeDataManaged);
            MeshBuilderManaged meshBuilderManaged = new MeshBuilderManaged(configurationManaged, meshDataManaged, moduleDataManaged);
            ModuleSimulatorManaged moduleSimulatorManaged = new ModuleSimulatorManaged(configurationManaged, moduleDataManaged);
            MeshSimulatorManaged meshSimulatorManaged = new MeshSimulatorManaged(configurationManaged, meshDataManaged, particleDataManaged);
            LatticeSimulatorManaged latticeSimulatorManaged = new LatticeSimulatorManaged(configurationManaged, latticeDataManaged, particleDataManaged);
            EffectSimulatorManaged effectSimulatorManaged = new EffectSimulatorManaged(configurationManaged, effectDataManaged, particleDataManaged);
            EventManagerManaged eventManagerManaged = new EventManagerManaged(configurationManaged);
            FileLoadManager fileLoadManager = new FileLoadManager();
            SceneWrap sceneWrap = new SceneWrap(configurationManaged, moduleDataManaged, particleDataManaged, meshDataManaged, latticeDataManaged, effectDataManaged, particleBuilderManaged, latticeBuilderManaged, meshBuilderManaged, moduleSimulatorManaged, meshSimulatorManaged, latticeSimulatorManaged, effectSimulatorManaged, eventManagerManaged, fileLoadManager);
            fileLoadManager.SetFilePath(sceneWrap.FileManager, path);
            fileLoadManager.Execute(sceneWrap.FileManager, sceneWrap, path);
            fileLoadManager.SetFilePath(sceneWrap.FileManager, "");
            float boundsMidX = sceneWrap.Config.BoundsMidX;
            float boundsMidY = sceneWrap.Config.BoundsMidY;
            sceneWrap.ParticleBuilder.MoveParticles(float2Managed - new Float2Managed(boundsMidX, boundsMidY));
            sceneWrap.MoveBoxes(float2Managed - new Float2Managed(boundsMidX, boundsMidY));
            ClipboardManaged clipboardManaged = new ClipboardManaged();
            clipboardManaged.CopyAll(sceneWrap);
            return clipboardManaged.Paste(scene);
        }
        private static string GetRelativePath(string fromPath, string toPath)
        {
            if (!fromPath.EndsWith("\\") && !fromPath.EndsWith("/"))
            {
                fromPath += "/";
            }
            Uri uri = new Uri("file:///" + Uri.EscapeDataString(fromPath));
            Uri uri2 = new Uri("file:///" + Uri.EscapeDataString(toPath));
            Uri uri3 = uri.MakeRelativeUri(uri2);
            return Uri.UnescapeDataString(uri3.ToString());
        }
        private string DecodeBase64Res(string source)
        {
            if (source.StartsWith("b64res/"))
            {
                source = Encoding.UTF8.GetString(Convert.FromBase64String(Path.GetFileNameWithoutExtension(source).Replace("-", "+").Replace("_", "/")));
                if (Path.IsPathRooted(source))
                {
                    return FileManagerCSharp.GetRelativePath(Directory.GetCurrentDirectory(), source);
                }
            }
            return source;
        }
        public string CreateSaveString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.HeaderString());
            stringBuilder.Append(this.CreateConfig());
            stringBuilder.Append(this.MaxParticles());
            stringBuilder.Append(this.CreateParticles());
            stringBuilder.Append(this.CreateStorage());
            stringBuilder.Append(this.CreateParticleJoints());
            stringBuilder.Append(this.CreateParticleBodies());
            stringBuilder.Append(this.CreateMeshBodies());
            stringBuilder.Append(this.CreateBoxes());
            stringBuilder.Append(this.CreateSharedTexture());
            stringBuilder.Append(this.CreateTexture());
            stringBuilder.Append(this.CreateModule());
            stringBuilder.Append(this.CreateScripts());
            stringBuilder.Append(this.CreateMasks());
            return stringBuilder.ToString();
        }
        private string CreateModule()
        {
            StringBuilder stringBuilder = new StringBuilder();
            uint num = 0U;
            while ((ulong)num < (ulong)((long)this.fileManager.Modules.Count))
            {
                ModuleManaged moduleManaged = this.fileManager.Modules.RequestModule(num);
                if (moduleManaged != null)
                {
                    stringBuilder.Append(this.CreateAModule(moduleManaged));
                }
                num += 1U;
            }
            return stringBuilder.ToString();
        }
        private string HeaderString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("# OctaveEngine Casual ({0})\n", DateTime.Now.ToString("MMM dd yyyy", DateTimeFormatInfo.InvariantInfo));
            stringBuilder.Append("version 10\n");
            return stringBuilder.ToString();
        }
        private string MaxParticles()
        {
            if (this.fileManager.Particles.MaxCount != 2147483647)
            {
                return this.MaxString();
            }
            return "";
        }
        private string MaxString()
        {
            int maxCount = this.fileManager.Particles.MaxCount;
            return string.Format("max {0}\n", maxCount);
        }
        private string CreateParticles()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.fileManager.Particles.Count; i++)
            {
                stringBuilder.Append(this.CreateParticleStrings(i));
            }
            return stringBuilder.ToString();
        }
        private string CreateParticleStrings(int a)
        {
            return string.Format(CultureInfo.InvariantCulture, "p {0:X} {1:X} 0 {2:X} {3} {4} {5} {6} {7} {8} {9} {10} {11}\n", new object[]
{
    (int)this.fileManager.Particles.get_Info(a),
    this.fileManager.Particles.get_BodyID(a),
    this.ToIntegerFromColor(this.fileManager.Particles.get_Color(a)),
    this.fileManager.Particles.get_Center(a).X.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Center(a).Y.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Velocity(a).X.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Velocity(a).Y.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Origin(a).X.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Origin(a).Y.ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Angle(a).ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Spin(a).ToString(CultureInfo.InvariantCulture),
    this.fileManager.Particles.get_Pressure(a).ToString(CultureInfo.InvariantCulture)
});
        }
        private int ToIntegerFromColor(Color color)
        {
            return ((int)color.R << 24) | ((int)color.G << 16) | ((int)color.B << 8) | (int)color.A;
        }
        private string CreateStorage()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.fileManager.Storage.CountParticles; i++)
            {
                stringBuilder.Append(this.CreateStorageParticle(i));
            }
            for (int j = 0; j < this.fileManager.Storage.CountJoints; j++)
            {
                stringBuilder.Append(this.CreateStorageJoint(j));
            }
            return stringBuilder.ToString();
        }
        private string CreateStorageParticle(int i)
        {
            ParticleStorageManaged particleStorageManaged = new ParticleStorageManaged();
            this.fileManager.Storage.GetParticle(ref particleStorageManaged, i);
            return string.Format(CultureInfo.InvariantCulture, "s {0:X} {1:X} 0 {2:X} {3} {4} {5} {6} {7}\n", new object[]
{
    particleStorageManaged.Info,
    particleStorageManaged.BodyID,
    particleStorageManaged.Color,
    particleStorageManaged.CenterX.ToString(CultureInfo.InvariantCulture),
    particleStorageManaged.CenterY.ToString(CultureInfo.InvariantCulture),
    particleStorageManaged.OriginX.ToString(CultureInfo.InvariantCulture),
    particleStorageManaged.OriginY.ToString(CultureInfo.InvariantCulture),
    particleStorageManaged.Angle.ToString(CultureInfo.InvariantCulture)
});
        }
        private string CreateStorageJoint(int i)
        {
            JointStorageManaged jointStorageManaged = new JointStorageManaged();
            this.fileManager.Storage.GetJoint(ref jointStorageManaged, i);
            return string.Format(CultureInfo.InvariantCulture, "sj {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}\n", new object[]
{
    jointStorageManaged.Length.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.Weight.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.DirectionX.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.DirectionY.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.CenterX0.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.CenterY0.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.CenterX1.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.CenterY1.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.Angle0.ToString(CultureInfo.InvariantCulture),
    jointStorageManaged.Angle1.ToString(CultureInfo.InvariantCulture)
});
        }
        private string CreateParticleJoints()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<pair<int, int>, ParticleJointManaged> keyValuePair in this.fileManager.Particles.Joints)
            {
                string text = string.Format(CultureInfo.InvariantCulture, "j {0} {1} {2} {3} {4} {5} {6} {7} {8}\n", new object[]
{
    (int)keyValuePair.Value.Info,
    keyValuePair.Key.first,
    keyValuePair.Key.second,
    keyValuePair.Value.Length.ToString(CultureInfo.InvariantCulture),
    keyValuePair.Value.Weight.ToString(CultureInfo.InvariantCulture),
    keyValuePair.Value.Direction.X.ToString(CultureInfo.InvariantCulture),
    keyValuePair.Value.Direction.Y.ToString(CultureInfo.InvariantCulture),
    keyValuePair.Value.Angle0.ToString(CultureInfo.InvariantCulture),
    keyValuePair.Value.Angle1.ToString(CultureInfo.InvariantCulture)
});
                stringBuilder.Append(text);
            }
            return stringBuilder.ToString();
        }
        private string CreateConfig()
        {
            return this.fileManager.Config.Save();
        }
        private string CreateTexture()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.fileManager.Config.ForegroundTexture != null)
            {
                stringBuilder.AppendFormat("foreground {0}\n", this.DecodeBase64Res(this.fileManager.Config.ForegroundTexture.Source));
            }
            if (this.fileManager.Config.BackgroundTexture != null)
            {
                stringBuilder.AppendFormat("background {0}\n", this.DecodeBase64Res(this.fileManager.Config.BackgroundTexture.Source));
            }
            if (this.fileManager.Config.WatermarkTexture != null)
            {
                stringBuilder.AppendFormat("watermark {0}\n", this.DecodeBase64Res(this.fileManager.Config.WatermarkTexture.Source));
            }
            if (this.fileManager.Config.FireTexture != null)
            {
                stringBuilder.AppendFormat("fireTexture {0}\n", this.DecodeBase64Res(this.fileManager.Config.FireTexture.Source));
            }
            if (this.fileManager.Config.BubbleTexture != null)
            {
                stringBuilder.AppendFormat("bubbleTexture {0}\n", this.DecodeBase64Res(this.fileManager.Config.BubbleTexture.Source));
            }
            if (this.fileManager.Config.SplashTexture != null)
            {
                stringBuilder.AppendFormat("splashTexture {0}\n", this.DecodeBase64Res(this.fileManager.Config.SplashTexture.Source));
            }
            if (this.fileManager.Config.SmokeTexture != null)
            {
                stringBuilder.AppendFormat("smokeTexture {0}\n", this.DecodeBase64Res(this.fileManager.Config.SmokeTexture.Source));
            }
            return stringBuilder.ToString();
        }
        private string CreateParticleBodies()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.fileManager.Particles.BodiesSize; i++)
            {
                stringBuilder.Append(this.CreateBody(i));
            }
            return stringBuilder.ToString();
        }
        private string CreateBody(int id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            ParticleBodyManaged particleBodyManaged = this.fileManager.Particles.get_Bodies(id);
            if (particleBodyManaged.Permanent)
            {
                stringBuilder.AppendFormat("protect {0}\n", id);
            }
            if (particleBodyManaged.Damaged)
            {
                stringBuilder.AppendFormat("split {0}\n", id);
            }
            ModuleManaged module = particleBodyManaged.Module;
            if (module != null)
            {
                stringBuilder.AppendFormat("bind {0} {1}\n", id, module.Id);
            }
            return stringBuilder.ToString();
        }
        private string CreateAModule(ModuleManaged module)
        {
            StringBuilder stringBuilder = new StringBuilder();
            ModuleManaged parent = module.Parent;
            if (parent != null && parent.Id != 0U)
            {
                stringBuilder.AppendFormat("parent {0} {1}\n", module.Id, parent.Id);
            }
            if (module.Texture != null)
            {
                stringBuilder.AppendFormat("texture {0} {1} {2} {3} {4} {5} {6}\n", new object[]
                {
                    module.Id,
                    module.Mapping,
                    module.MinOrigin.X,
                    module.MinOrigin.Y,
                    module.MaxOrigin.X,
                    module.MaxOrigin.Y,
                    this.DecodeBase64Res(module.Texture.Source)
                });
            }
            if (!string.IsNullOrEmpty(module.Uid))
            {
                string uid = module.Uid;
                stringBuilder.AppendFormat("uid {0} {1}\n", module.Id, uid);
                this.fileManager.AddUid(uid);
            }
            if (!string.IsNullOrEmpty(module.Name))
            {
                stringBuilder.AppendFormat("name {0} {1}\n", module.Id, module.Name);
            }
            TagIterator tagIterator = module.Tags.Begin();
            while (!tagIterator.Equals(module.Tags.End()))
            {
                string text = tagIterator.ToString();
                stringBuilder.AppendFormat("tag {0} {1}\n", module.Id, text);
                tagIterator.Next();
            }
            if (module.DisplacementXConstraint != null || module.DisplacementYConstraint != null || module.AngleConstraint != null || module.VelocityXConstraint != null || module.VelocityYConstraint != null || module.SpinConstraint != null || module.ForceXConstraint != null || module.ForceYConstraint != null || module.TorqueConstraint != null)
            {
                stringBuilder.AppendFormat("constraint {0} {1} {2} {3} {4}\n", new object[]
                {
                    module.Id,
                    module.AxisCenter.X,
                    module.AxisCenter.Y,
                    module.AxisOrigin.X,
                    module.AxisOrigin.Y
                });
                stringBuilder.Append("<< END\n");
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.DisplacementXConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.DisplacementYConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.AngleConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.VelocityXConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.VelocityYConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.SpinConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.ForceXConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.ForceYConstraint));
                stringBuilder.AppendFormat("{0}\n", this.GetSource(module.TorqueConstraint));
                stringBuilder.Append("END\n");
            }
            if (module.Script != null)
            {
                stringBuilder.AppendFormat("script {0}\n", module.Id);
                stringBuilder.Append("<< END\n");
                stringBuilder.AppendFormat("{0}\n", module.Script.Source);
                stringBuilder.Append("END\n");
            }
            return stringBuilder.ToString();
        }
        private string GetSource(float? value)
        {
            if (value == null)
            {
                return "";
            }
            return value.Value.ToString();
        }
        private string GetSource(AbstractScriptManaged script)
        {
            if (script == null)
            {
                return "";
            }
            return script.Source;
        }
        private string CreateMeshBodies()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.fileManager.Meshes.BodiesCount; i++)
            {
                MeshBodyManaged meshBodyManaged = this.fileManager.Meshes.get_Bodies(i);
                ModuleManaged module = meshBodyManaged.Module;
                if (module != null)
                {
                    stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "mesh {0} {1} {2} {3} {4} {5} {6}\n",
                        i,
                        module.Mapping,
                        module.MinOrigin.X.ToString(CultureInfo.InvariantCulture),
                        module.MinOrigin.Y.ToString(CultureInfo.InvariantCulture),
                        module.MaxOrigin.X.ToString(CultureInfo.InvariantCulture),
                        module.MaxOrigin.Y.ToString(CultureInfo.InvariantCulture),
                        module.Texture.Source
                    );
                }
                for (int j = 0; j < meshBodyManaged.NodeCount; j++)
                {
                    stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "n {0} {1} {2} {3} {4} {5} {6} {7}\n",
                        i,
                        meshBodyManaged.get_Mass(j).ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Node(j).X.ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Node(j).Y.ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Velocity(j).X.ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Velocity(j).Y.ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Origin(j).X.ToString(CultureInfo.InvariantCulture),
                        meshBodyManaged.get_Origin(j).Y.ToString(CultureInfo.InvariantCulture)
                    );
                }
                foreach (MeshElementManaged meshElementManaged in meshBodyManaged.Elements)
                {
                    stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "e {0} {1} {2} {3}\n",
                        i, meshElementManaged.A, meshElementManaged.B, meshElementManaged.C
                    );
                }
            }
            return stringBuilder.ToString();
        }
        private string CreateBoxes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            BoxDataManaged boxes = this.fileManager.Boxes;
            for (int i = 0; i < boxes.NumBodies; i++)
            {
                BoxBodyManaged body = boxes.GetBody(i);
                if (!body.IsGround)
                {
                    ModuleManaged module = body.Module;
                    uint num = ((module != null) ? module.Id : 0U);
                    stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "box {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}\n",
                        i, num, body.Flags,
                        body.Mass.ToString(CultureInfo.InvariantCulture),
                        body.Moment.ToString(CultureInfo.InvariantCulture),
                        body.LocalCenter.X.ToString(CultureInfo.InvariantCulture),
                        body.LocalCenter.Y.ToString(CultureInfo.InvariantCulture),
                        body.Position.X.ToString(CultureInfo.InvariantCulture),
                        body.Position.Y.ToString(CultureInfo.InvariantCulture),
                        body.Angle.ToString(CultureInfo.InvariantCulture),
                        body.Velocity.X.ToString(CultureInfo.InvariantCulture),
                        body.Velocity.Y.ToString(CultureInfo.InvariantCulture),
                        body.Spin.ToString(CultureInfo.InvariantCulture)
                    );
                    for (int j = 0; j < body.NumShapes; j++)
                    {
                        BoxShapeManaged shape = body.GetShape(j);
                        stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "shape {0} {1} {2} {3} {4} {5} ",
                            i, shape.Filter, shape.Density, shape.Friction, shape.Restitution, shape.Color
                        );
                        if (shape is BoxPolygonShapeManaged boxPolygonShapeManaged)
                        {
                            stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "polygon {0}", boxPolygonShapeManaged.NumVertices);
                            for (int k = 0; k < boxPolygonShapeManaged.NumVertices; k++)
                            {
                                stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " {0} {1}",
                                    boxPolygonShapeManaged.GetVertex(k).X.ToString(CultureInfo.InvariantCulture),
                                    boxPolygonShapeManaged.GetVertex(k).Y.ToString(CultureInfo.InvariantCulture)
                                );
                            }
                            stringBuilder.Append("\n");
                        }
                        else if (shape is BoxCircleShapeManaged boxCircleShapeManaged)
                        {
                            stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "circle {0} {1} {2}\n",
                                boxCircleShapeManaged.LocalCenter.X.ToString(CultureInfo.InvariantCulture),
                                boxCircleShapeManaged.LocalCenter.Y.ToString(CultureInfo.InvariantCulture),
                                boxCircleShapeManaged.Radius.ToString(CultureInfo.InvariantCulture)
                            );
                        }
                    }
                }
            }
            return stringBuilder.ToString();
        }
        private string CreateScripts()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.fileManager.Config.OnLoad != null)
            {
                stringBuilder.Append("onLoad\n");
                stringBuilder.Append("<< END\n");
                stringBuilder.AppendFormat("{0}\n", this.fileManager.Config.OnLoad.Source);
                stringBuilder.Append("END\n");
            }
            if (this.fileManager.Config.OnSimulate != null)
            {
                stringBuilder.Append("onSimulate\n");
                stringBuilder.Append("<< END\n");
                stringBuilder.AppendFormat("{0}\n", this.fileManager.Config.OnSimulate.Source);
                stringBuilder.Append("END\n");
            }
            if (this.fileManager.Config.OnRender != null)
            {
                stringBuilder.Append("onRender\n");
                stringBuilder.Append("<< END\n");
                stringBuilder.AppendFormat("{0}\n", this.fileManager.Config.OnRender.Source);
                stringBuilder.Append("END\n");
            }
            return stringBuilder.ToString();
        }
        private string CreateMasks()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.fileManager.Config.ToolMask != -1)
            {
                stringBuilder.AppendFormat("tools {0}\n", this.fileManager.SaveFlags(this.fileManager.Config.ToolMask));
            }
            if (this.fileManager.Config.MaterialMask != -1)
            {
                stringBuilder.AppendFormat("materials {0}\n", this.fileManager.SaveFlags(this.fileManager.Config.MaterialMask));
            }
            return stringBuilder.ToString();
        }
        private string CreateCanvas()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.fileManager.Config.Canvas != null)
            {
                stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "canvas {0} {1} 0 {2}\n",
                    this.fileManager.Config.Canvas.Width.ToString(CultureInfo.InvariantCulture),
                    this.fileManager.Config.Canvas.Height.ToString(CultureInfo.InvariantCulture),
                    this.fileManager.SaveData()
                );
            }
            return stringBuilder.ToString();
        }
        private string CreateSharedTexture()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (TextureManaged textureManaged in this.fileManager.TextureMap.Values)
            {
                if (textureManaged.IsShared && !string.IsNullOrEmpty(textureManaged.Source))
                {
                    stringBuilder.AppendFormat("sharedTexture {0}\n", this.DecodeBase64Res(textureManaged.Source));
                }
            }
            foreach (SoundManaged soundManaged in this.fileManager.SoundMap.Values)
            {
                if (soundManaged.IsShared && !string.IsNullOrEmpty(soundManaged.Source))
                {
                    stringBuilder.AppendFormat("sharedSound {0}\n", this.DecodeBase64Res(soundManaged.Source));
                }
            }
            foreach (ResourceManaged resourceManaged in this.fileManager.ResourceMap.Values)
            {
                if (resourceManaged.IsShared && !string.IsNullOrEmpty(resourceManaged.Source))
                {
                    stringBuilder.AppendFormat("sharedModule {0}\n", resourceManaged.Source);
                }
            }
            return stringBuilder.ToString();
        }
        public void Save(string pathOriginal)
        {
            if (!string.IsNullOrEmpty(pathOriginal))
            {
                string text = pathOriginal.Replace("\\", "/");
                string extension = Path.GetExtension(text);
                if (this.fileManager.HasSystem() && extension == ".oecd")
                {
                    this.SaveOecd(text, false);
                    return;
                }
                this.SaveOec(text, false);
            }
        }
        private void SaveOecd(string name, bool asCopy)
        {
            if (FileManagerManaged.System.CreateDirectory(name))
            {
                string text = name + "/";
                this.fileManager.SaveResources(text);
                string text2 = text + "main.oec";
                this.SaveOec(text2, asCopy);
            }
        }
        private void SaveOec(string name, bool asCopy)
        {
            if (this.fileManager.HasSystem())
            {
                this.SaveXbap(name);
                return;
            }
            throw new Exception("Cannot save to local file");
        }
        private void SaveXbap(string name)
        {
            string text = this.CreateSaveString();
            text = FileManagerCSharp.TrimComments(text);
            this.fileManager.SaveData(name, text);
        }
        private static string TrimComments(string data)
        {
            TextReader textReader = new StringReader(data);
            TextWriter textWriter = new StringWriter();
            for (; ; )
            {
                string text = textReader.ReadLine();
                if (text == null)
                {
                    break;
                }
                if (!text.TrimStart(new char[0]).StartsWith("//"))
                {
                    if (text.IndexOf("//") != -1)
                    {
                        int num = text.IndexOf("//");
                        string text2 = text.Substring(0, num).TrimEnd(new char[0]);
                        textWriter.Write("{0}\n", text2);
                    }
                    else
                    {
                        textWriter.Write("{0}\n", text);
                    }
                }
            }
            textReader.Close();
            textWriter.Close();
            data = textWriter.ToString();
            return data;
        }
        private FileManagerManaged fileManager;
    }
}
