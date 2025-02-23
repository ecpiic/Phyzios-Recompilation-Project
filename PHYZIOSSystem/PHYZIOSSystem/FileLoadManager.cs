using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using oec;
namespace PHYZIOSSystem
{
    public class FileLoadManager : IListener
    {
        public override void Execute(FileManagerManaged fileManager, SceneWrap scene, string path)
        {
            this.fileManager = fileManager;
            string extension = Path.GetExtension(path);
            if (extension == ".oecd")
            {
                this.LoadOecd(scene, path);
                return;
            }
            if (extension == ".oec")
            {
                this.LoadOec(scene, path);
            }
        }
        public override ValueManaged ScriptExec(ScriptManagerManaged scriptManager, string name, ValuesManaged argv, int argc)
        {
            return scriptManager.Exec(name, argv, argc);
        }
        private void LoadOecd(SceneWrap scene, string oecd)
        {
            string text = oecd + "/";
            string text2 = text + "main.oec";
            if (FileManagerManaged.System == null)
            {
                return;
            }
            if (FileManagerManaged.System.FileExists(text2))
            {
                this.Execute(this.fileManager, scene, text2);
                return;
            }
            FileManagerManaged.System.OpenDirectory(oecd);
            string text3;
            do
            {
                text3 = FileManagerManaged.System.ReadDirectory();
                if (string.IsNullOrEmpty(text3))
                {
                    goto IL_008D;
                }
            }
            while (text3[0] == '.' || !(Path.GetExtension(text3) == ".oec"));
            text3 = text + text3;
            this.Execute(this.fileManager, scene, text3);
        IL_008D:
            FileManagerManaged.System.CloseDirectory();
        }
        private void LoadOec(SceneWrap scene, string path)
        {
            this.SetFilePath(this.fileManager, path);
            if (!string.IsNullOrEmpty(path) && FileManagerManaged.System != null)
            {
                this.LoadForXbap(scene, path);
            }
        }
        public void SetFilePath(FileManagerManaged fileManager, string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                fileManager.Directory = Path.GetDirectoryName(path).Replace("\\", "/") + "/";
                return;
            }
            fileManager.Directory = "";
        }
        private void LoadForXbap(SceneWrap scene, string path)
        {
            FileManagerManaged.System.GetFileSize(path);
            byte[] fileData = FileManagerManaged.System.GetFileData(path);
            string @string = Encoding.UTF8.GetString(fileData);
            this.sr = new StringReader(@string);
            this.Load(scene);
        }
        private void Load(SceneWrap scene)
        {
            this.fileManager.Clear();
            this.fileManager.Particles.Clear();
            int num = 0;
            ConfigurationManaged config = this.fileManager.Config;
            ModuleDataManaged modules = this.fileManager.Modules;
            string text;
            while ((text = this.sr.ReadLine()) != null)
            {
                string[] array = text.Split(new char[0]);
                string text2 = array[0];
                if (text2 != null)
                {
                    switch (text2.Length)
                    {
                        case 1:
                            {
                                char c = text2[0];
                                if (c <= 'j')
                                {
                                    if (c != '@')
                                    {
                                        if (c != 'e')
                                        {
                                            if (c == 'j')
                                            {
                                                this.LoadJoint(array);
                                            }
                                        }
                                        else
                                        {
                                            MeshElementManaged meshElementManaged = new MeshElementManaged();
                                            uint num2 = uint.Parse(array[1]);
                                            meshElementManaged.A = int.Parse(array[2]);
                                            meshElementManaged.B = int.Parse(array[3]);
                                            meshElementManaged.C = int.Parse(array[4]);
                                            MeshBodyManaged meshBodyManaged = this.fileManager.RequestMeshBody(num2);
                                            meshBodyManaged.Elements.Add(meshElementManaged);
                                        }
                                    }
                                    else
                                    {
                                        this.LoadName(array);
                                    }
                                }
                                else if (c != 'n')
                                {
                                    if (c != 'p')
                                    {
                                        if (c == 's')
                                        {
                                            this.LoadStorage(array);
                                        }
                                    }
                                    else
                                    {
                                        this.LoadParticles(array, num);
                                    }
                                }
                                else
                                {
                                    uint num3 = Convert.ToUInt32(array[1], 16);
                                    float num4 = float.Parse(array[2]);
                                    Float2Managed float2Managed = new Float2Managed(float.Parse(array[3]), float.Parse(array[4]));
                                    Float2Managed float2Managed2 = new Float2Managed(float.Parse(array[5]), float.Parse(array[6]));
                                    Float2Managed float2Managed3 = new Float2Managed(float.Parse(array[7]), float.Parse(array[8]));
                                    MeshBodyManaged meshBodyManaged2 = this.fileManager.RequestMeshBody(num3);
                                    int num5 = meshBodyManaged2.CreateNode();
                                    meshBodyManaged2.set_Mass(num5, num4);
                                    meshBodyManaged2.set_Node(num5, float2Managed);
                                    meshBodyManaged2.set_Velocity(num5, float2Managed2);
                                    meshBodyManaged2.set_Origin(num5, float2Managed3);
                                }
                                break;
                            }
                        case 2:
                            {
                                char c = text2[0];
                                if (c != '<')
                                {
                                    if (c == 's')
                                    {
                                        if (text2 == "sj")
                                        {
                                            this.LoadJointStorage(array);
                                        }
                                    }
                                }
                                else if (text2 == "<<")
                                {
                                    this.LoadMultilineString(array);
                                }
                                break;
                            }
                        case 3:
                            {
                                char c = text2[0];
                                if (c <= 'm')
                                {
                                    if (c != 'b')
                                    {
                                        if (c == 'm')
                                        {
                                            if (text2 == "max")
                                            {
                                                int num6 = int.Parse(array[1]);
                                                this.fileManager.Particles.ParticleMaxCount = num6;
                                            }
                                        }
                                    }
                                    else if (text2 == "box")
                                    {
                                        uint num7 = uint.Parse(array[1]);
                                        uint num8 = uint.Parse(array[2]);
                                        BoxBodyManaged boxBodyManaged = scene.Boxes.RequestBody(num7);
                                        ModuleManaged moduleManaged = null;
                                        if (num8 != 0U)
                                        {
                                            moduleManaged = scene.Modules.RequestModule(num8);
                                        }
                                        boxBodyManaged.Module = moduleManaged;
                                        int num9 = int.Parse(array[3]);
                                        float num10 = float.Parse(array[4]);
                                        float num11 = float.Parse(array[5]);
                                        Float2Managed float2Managed4 = new Float2Managed(float.Parse(array[6]), float.Parse(array[7]));
                                        Float2Managed float2Managed5 = new Float2Managed(float.Parse(array[8]), float.Parse(array[9]));
                                        float num12 = float.Parse(array[10]);
                                        Float2Managed float2Managed6 = new Float2Managed(float.Parse(array[11]), float.Parse(array[12]));
                                        float num13 = float.Parse(array[13]);
                                        boxBodyManaged.Flags = num9;
                                        boxBodyManaged.Velocity = float2Managed6;
                                        boxBodyManaged.Spin = num13;
                                        scene.Boxes.SetBodyMass(boxBodyManaged, num10, num11, float2Managed4);
                                        scene.Boxes.SetBodyTransform(boxBodyManaged, float2Managed5, num12);
                                    }
                                }
                                else if (c != 't')
                                {
                                    if (c == 'u')
                                    {
                                        if (text2 == "uid")
                                        {
                                            uint num14 = uint.Parse(array[1]);
                                            string text3 = array[2];
                                            ModuleManaged moduleManaged2;
                                            if (num < 10)
                                            {
                                                ParticleBodyManaged particleBodyManaged = this.fileManager.Particles.RequestBody(num14);
                                                moduleManaged2 = (particleBodyManaged.Module = modules.RequestModule(particleBodyManaged.Module));
                                            }
                                            else
                                            {
                                                moduleManaged2 = modules.RequestModule(num14);
                                            }
                                            moduleManaged2.Uid = text3;
                                        }
                                    }
                                }
                                else if (text2 == "tag")
                                {
                                    uint num15 = uint.Parse(array[1]);
                                    ModuleManaged moduleManaged3;
                                    if (num < 10)
                                    {
                                        ParticleBodyManaged particleBodyManaged2 = this.fileManager.Particles.RequestBody(num15);
                                        moduleManaged3 = (particleBodyManaged2.Module = modules.RequestModule(particleBodyManaged2.Module));
                                    }
                                    else
                                    {
                                        moduleManaged3 = modules.RequestModule(num15);
                                    }
                                    string text4 = array[2];
                                    moduleManaged3.Tags.Insert(text4);
                                }
                                break;
                            }
                        case 4:
                            {
                                char c = text2[0];
                                if (c != 'b')
                                {
                                    if (c != 'm')
                                    {
                                        if (c == 'n')
                                        {
                                            if (text2 == "name")
                                            {
                                                uint num16 = uint.Parse(array[1]);
                                                ModuleManaged moduleManaged4;
                                                if (num < 10)
                                                {
                                                    ParticleBodyManaged particleBodyManaged3 = this.fileManager.Particles.RequestBody(num16);
                                                    moduleManaged4 = (particleBodyManaged3.Module = modules.RequestModule(particleBodyManaged3.Module));
                                                }
                                                else
                                                {
                                                    moduleManaged4 = modules.RequestModule(num16);
                                                }
                                                moduleManaged4.Name = array[2];
                                            }
                                        }
                                    }
                                    else if (text2 == "mesh")
                                    {
                                        uint num17 = 0U;
                                        MeshBodyManaged meshBodyManaged3 = this.LoadMeshBody(array, num17);
                                        ModuleManaged moduleManaged5 = this.fileManager.Modules.RequestModule(meshBodyManaged3.Module);
                                        moduleManaged5.Mapping = int.Parse(array[1]);
                                        Float2Managed float2Managed7 = new Float2Managed(float.Parse(array[2]), float.Parse(array[3]));
                                        Float2Managed float2Managed8 = new Float2Managed(float.Parse(array[4]), float.Parse(array[5]));
                                        moduleManaged5.MinOrigin = float2Managed7;
                                        moduleManaged5.MaxOrigin = float2Managed8;
                                        string text5 = array[6];
                                        moduleManaged5.Texture = this.fileManager.GetTexture(text5);
                                    }
                                }
                                else if (text2 == "bind")
                                {
                                    uint num18 = uint.Parse(array[1]);
                                    uint num19 = uint.Parse(array[2]);
                                    if (num19 != 0U)
                                    {
                                        ParticleBodyManaged particleBodyManaged4 = this.fileManager.Particles.RequestBody(num18);
                                        ModuleManaged moduleManaged6 = modules.RequestModule(num19);
                                        particleBodyManaged4.Module = moduleManaged6;
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                char c = text2[1];
                                if (c != 'h')
                                {
                                    if (c != 'o')
                                    {
                                        if (c == 'p')
                                        {
                                            if (text2 == "split")
                                            {
                                                uint num20 = uint.Parse(array[1]);
                                                ParticleBodyManaged particleBodyManaged5 = this.LoadParticleBody(ref num20);
                                                particleBodyManaged5.Damaged = true;
                                            }
                                        }
                                    }
                                    else if (text2 == "tools")
                                    {
                                        config.ToolMask = this.LoadFlags(array);
                                    }
                                }
                                else if (text2 == "shape")
                                {
                                    BoxDataManaged boxes = scene.Boxes;
                                    uint num21 = uint.Parse(array[1]);
                                    int num22 = int.Parse(array[2]);
                                    float num23 = float.Parse(array[3]);
                                    float num24 = float.Parse(array[4]);
                                    float num25 = float.Parse(array[5]);
                                    int num26 = int.Parse(array[6]);
                                    string text6 = array[7];
                                    BoxShapeManaged boxShapeManaged;
                                    if (text6 == "polygon")
                                    {
                                        int num27 = int.Parse(array[8]);
                                        Float2Managed[] array2 = new Float2Managed[8];
                                        int num28 = 0;
                                        while (num28 < num27 && num28 < 8)
                                        {
                                            ref Float2Managed ptr = ref array2[num28];
                                            ptr = new Float2Managed(float.Parse(array[9 + num28 * 2]), float.Parse(array[10 + num28 * 2]));
                                            num28++;
                                        }
                                        boxShapeManaged = new BoxPolygonShapeManaged(array2, num27);
                                    }
                                    else
                                    {
                                        Float2Managed float2Managed9 = new Float2Managed(float.Parse(array[8]), float.Parse(array[9]));
                                        float num29 = float.Parse(array[10]);
                                        boxShapeManaged = new BoxCircleShapeManaged(float2Managed9, num29);
                                    }
                                    BoxBodyManaged boxBodyManaged2 = new BoxBodyManaged(boxes.RequestBody(num21));
                                    boxShapeManaged.Filter = num22;
                                    boxShapeManaged.Density = num23;
                                    boxShapeManaged.Friction = num24;
                                    boxShapeManaged.Restitution = num25;
                                    boxShapeManaged.Color = num26;
                                    boxes.AddShape(boxBodyManaged2, boxShapeManaged);
                                }
                                break;
                            }
                        case 6:
                            {
                                char c = text2[0];
                                if (c != 'c')
                                {
                                    switch (c)
                                    {
                                        case 'o':
                                            if (text2 == "onLoad")
                                            {
                                                string[] array3 = this.Read_and_Split();
                                                this.fileManager.Config.OnLoad = this.LoadScriptStatement(array3);
                                            }
                                            break;
                                        case 'p':
                                            if (text2 == "parent")
                                            {
                                                uint num30 = uint.Parse(array[1]);
                                                uint num31 = uint.Parse(array[2]);
                                                ModuleManaged moduleManaged7 = modules.RequestModule(num30);
                                                ModuleManaged moduleManaged8 = modules.RequestModule(num31);
                                                moduleManaged7.Parent = moduleManaged8;
                                            }
                                            break;
                                        case 's':
                                            if (text2 == "script")
                                            {
                                                uint num32 = uint.Parse(array[1]);
                                                ModuleManaged moduleManaged9;
                                                if (num < 10)
                                                {
                                                    ParticleBodyManaged particleBodyManaged6 = this.fileManager.Particles.RequestBody(num32);
                                                    moduleManaged9 = (particleBodyManaged6.Module = modules.RequestModule(particleBodyManaged6.Module));
                                                }
                                                else
                                                {
                                                    moduleManaged9 = modules.RequestModule(num32);
                                                }
                                                string text7 = this.sr.ReadLine();
                                                moduleManaged9.Script = this.LoadScriptStatement(text7.Split(new char[0]));
                                            }
                                            break;
                                    }
                                }
                                else if (text2 == "canvas")
                                {
                                    int num33 = int.Parse(array[1]);
                                    int num34 = int.Parse(array[2]);
                                    int.Parse(array[3]);
                                    config.Canvas = TextureManaged.InitWithSize(num33, num34);
                                    this.LoadData(array[4], config.Canvas);
                                }
                                break;
                            }
                        case 7:
                            {
                                char c = text2[0];
                                if (c != 'p')
                                {
                                    if (c != 't')
                                    {
                                        if (c == 'v')
                                        {
                                            if (text2 == "version")
                                            {
                                                num = (config.Version = int.Parse(array[1]));
                                            }
                                        }
                                    }
                                    else if (text2 == "texture")
                                    {
                                        uint num35 = uint.Parse(array[1]);
                                        this.LoadParticleBody(ref num35);
                                        uint num36 = num35;
                                        ModuleManaged moduleManaged10;
                                        if (num < 10)
                                        {
                                            ParticleBodyManaged particleBodyManaged7 = this.fileManager.Particles.RequestBody(num35);
                                            moduleManaged10 = (particleBodyManaged7.Module = modules.RequestModule(particleBodyManaged7.Module));
                                        }
                                        else
                                        {
                                            moduleManaged10 = modules.RequestModule(num35);
                                        }
                                        moduleManaged10.Mapping = int.Parse(array[2]);
                                        Float2Managed float2Managed10 = new Float2Managed(float.Parse(array[3]), float.Parse(array[4]));
                                        Float2Managed float2Managed11 = new Float2Managed(float.Parse(array[5]), float.Parse(array[6]));
                                        moduleManaged10.MinOrigin = float2Managed10;
                                        moduleManaged10.MaxOrigin = float2Managed11;
                                        string[] array4 = new string[array.Length - 6];
                                        Array.Copy(array, 6, array4, 0, array.Length - 6);
                                        moduleManaged10.Texture = this.LoadTexture(array4);
                                        if (moduleManaged10.Texture == null)
                                        {
                                            for (int i = 0; i < this.fileManager.Particles.Count; i++)
                                            {
                                                if ((long)this.fileManager.Particles.get_BodyID(i) == (long)((ulong)num36))
                                                {
                                                    this.fileManager.Particles.set_Info(i, this.fileManager.Particles.get_Info(i) | ParticleInfoManaged.Textured);
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (text2 == "protect")
                                {
                                    uint num37 = uint.Parse(array[1]);
                                    ParticleBodyManaged particleBodyManaged8 = this.LoadParticleBody(ref num37);
                                    particleBodyManaged8.Permanent = true;
                                }
                                break;
                            }
                        case 8:
                            {
                                char c = text2[0];
                                if (c != 'o')
                                {
                                    if (c == 'r')
                                    {
                                        if (text2 == "resource")
                                        {
                                            uint num38 = uint.Parse(array[1]);
                                            string text8 = array[2];
                                            ModuleManaged moduleManaged11;
                                            if (num < 10)
                                            {
                                                ParticleBodyManaged particleBodyManaged9 = this.fileManager.Particles.RequestBody(num38);
                                                moduleManaged11 = (particleBodyManaged9.Module = modules.RequestModule(particleBodyManaged9.Module));
                                            }
                                            else
                                            {
                                                moduleManaged11 = modules.RequestModule(num38);
                                            }
                                            ResourceManaged resource = this.fileManager.GetResource(text8);
                                            if (resource != null)
                                            {
                                                moduleManaged11.Resources.Add(resource);
                                            }
                                        }
                                    }
                                }
                                else if (text2 == "onRender")
                                {
                                    string[] array5 = this.Read_and_Split();
                                    this.fileManager.Config.OnRender = this.LoadScriptStatement(array5);
                                }
                                break;
                            }
                        case 9:
                            {
                                char c = text2[0];
                                if (c != 'm')
                                {
                                    if (c == 'w')
                                    {
                                        if (text2 == "watermark")
                                        {
                                            this.fileManager.Config.WatermarkTexture = this.LoadTexture(array);
                                        }
                                    }
                                }
                                else if (text2 == "materials")
                                {
                                    config.MaterialMask = this.LoadFlags(array);
                                }
                                break;
                            }
                        case 10:
                            {
                                char c = text2[0];
                                switch (c)
                                {
                                    case 'b':
                                        if (text2 == "background")
                                        {
                                            this.fileManager.Config.BackgroundTexture = this.LoadTexture(array);
                                        }
                                        break;
                                    case 'c':
                                        if (text2 == "constraint")
                                        {
                                            uint num39 = uint.Parse(array[1]);
                                            ModuleManaged moduleManaged12;
                                            if (num < 10)
                                            {
                                                ParticleBodyManaged particleBodyManaged10 = this.fileManager.Particles.RequestBody(num39);
                                                moduleManaged12 = (particleBodyManaged10.Module = modules.RequestModule(particleBodyManaged10.Module));
                                            }
                                            else
                                            {
                                                moduleManaged12 = modules.RequestModule(num39);
                                            }
                                            Float2Managed float2Managed12 = new Float2Managed(float.Parse(array[2]), float.Parse(array[3]));
                                            moduleManaged12.AxisCenter = float2Managed12;
                                            Float2Managed float2Managed13 = new Float2Managed(float.Parse(array[4]), float.Parse(array[5]));
                                            moduleManaged12.AxisOrigin = float2Managed13;
                                            this.SetConstraints(moduleManaged12);
                                        }
                                        break;
                                    case 'd':
                                    case 'e':
                                        break;
                                    case 'f':
                                        if (text2 == "foreground")
                                        {
                                            this.fileManager.Config.ForegroundTexture = this.LoadTexture(array);
                                        }
                                        break;
                                    default:
                                        if (c == 'o')
                                        {
                                            if (text2 == "onSimulate")
                                            {
                                                string[] array6 = this.Read_and_Split();
                                                this.fileManager.Config.OnSimulate = this.LoadScriptStatement(array6);
                                            }
                                        }
                                        break;
                                }
                                break;
                            }
                        case 11:
                            {
                                char c = text2[0];
                                if (c != 'f')
                                {
                                    if (c == 's')
                                    {
                                        if (text2 == "sharedSound")
                                        {
                                            SoundManaged soundManaged = this.LoadSound(array);
                                            if (soundManaged != null)
                                            {
                                                soundManaged.IsShared = true;
                                            }
                                        }
                                    }
                                }
                                else if (text2 == "fireTexture")
                                {
                                    this.fileManager.Config.FireTexture = this.LoadTexture(array);
                                }
                                break;
                            }
                        case 12:
                            {
                                char c = text2[1];
                                if (c != 'h')
                                {
                                    if (c == 'm')
                                    {
                                        if (text2 == "smokeTexture")
                                        {
                                            this.fileManager.Config.SmokeTexture = this.LoadTexture(array);
                                        }
                                    }
                                }
                                else if (text2 == "sharedModule")
                                {
                                    ResourceManaged resourceManaged = this.LoadResource(array[1]);
                                    if (resourceManaged != null)
                                    {
                                        resourceManaged.IsShared = true;
                                    }
                                }
                                break;
                            }
                        case 13:
                            {
                                char c = text2[1];
                                if (c != 'h')
                                {
                                    if (c != 'p')
                                    {
                                        if (c == 'u')
                                        {
                                            if (text2 == "bubbleTexture")
                                            {
                                                this.fileManager.Config.BubbleTexture = this.LoadTexture(array);
                                            }
                                        }
                                    }
                                    else if (text2 == "splashTexture")
                                    {
                                        this.fileManager.Config.SplashTexture = this.LoadTexture(array);
                                    }
                                }
                                else if (text2 == "sharedTexture")
                                {
                                    TextureManaged textureManaged = this.LoadTexture(array);
                                    if (textureManaged != null)
                                    {
                                        textureManaged.IsShared = true;
                                    }
                                }
                                break;
                            }
                    }
                }
            }
            this.fileManager.VerifyParticles();
            this.fileManager.InitializeMeshes();
            this.fileManager.Particles.Gc();
        }
        private void SetConstraints(ModuleManaged module)
        {
            string text = this.sr.ReadLine();
            string text2 = this.LoadMultilineString(text.Split(new char[0]));
            StringReader stringReader = new StringReader(text2);
            module.DisplacementXConstraint = this.LoadScriptExpression(ref stringReader);
            module.DisplacementYConstraint = this.LoadScriptExpression(ref stringReader);
            module.AngleConstraint = this.LoadScriptExpression(ref stringReader);
            module.VelocityXConstraint = this.LoadScriptExpression(ref stringReader);
            module.VelocityYConstraint = this.LoadScriptExpression(ref stringReader);
            module.SpinConstraint = this.LoadScriptExpression(ref stringReader);
            module.ForceXConstraint = this.LoadScriptExpression(ref stringReader);
            module.ForceYConstraint = this.LoadScriptExpression(ref stringReader);
            module.TorqueConstraint = this.LoadScriptExpression(ref stringReader);
        }
        private string[] Read_and_Split()
        {
            string text = this.sr.ReadLine();
            string[] array = text.Split(new char[0]);
            while (array.Length == 1)
            {
                array = this.sr.ReadLine().Split(new char[0]);
            }
            return array;
        }
        private void LoadParticles(string[] words, int version)
        {
            ParticleDataManaged particles = this.fileManager.Particles;
            int num = particles.CreateParticle();
            if (version >= 2)
            {
                particles.set_Info(num, (ParticleInfoManaged)Convert.ToUInt32(words[1], 16));
                particles.set_BodyID(num, (int)Convert.ToUInt32(words[2], 16));
                Convert.ToUInt32(words[3], 16);
                particles.SetColor(num, Convert.ToUInt32(words[4], 16));
                particles.set_Center(num, new Float2Managed(float.Parse(words[5]), float.Parse(words[6])));
                particles.set_Velocity(num, new Float2Managed(float.Parse(words[7]), float.Parse(words[8])));
                particles.set_Origin(num, new Float2Managed(float.Parse(words[9]), float.Parse(words[10])));
                particles.set_Angle(num, float.Parse(words[11]));
                particles.set_Spin(num, float.Parse(words[12]));
                particles.set_Pressure(num, float.Parse(words[13]));
            }
            this.fileManager.RequestParticleBody((uint)particles.get_BodyID(num));
        }
        private void LoadStorage(string[] words)
        {
            ParticleStorageManaged particleStorageManaged = new ParticleStorageManaged();
            particleStorageManaged.Info = (ParticleInfoManaged)Convert.ToUInt32(words[1], 16);
            particleStorageManaged.BodyID = Convert.ToUInt32(words[2], 16);
            Convert.ToUInt32(words[3], 16);
            particleStorageManaged.Color = Convert.ToUInt32(words[4], 16);
            particleStorageManaged.CenterX = float.Parse(words[5]);
            particleStorageManaged.CenterY = float.Parse(words[6]);
            particleStorageManaged.OriginX = float.Parse(words[7]);
            particleStorageManaged.OriginY = float.Parse(words[8]);
            particleStorageManaged.Angle = float.Parse(words[9]);
            ParticleBodyManaged particleBodyManaged = this.fileManager.RequestParticleBody(particleStorageManaged.BodyID);
            int stored = particleBodyManaged.Stored;
            particleBodyManaged.Stored = stored + 1;
            this.fileManager.Storage.AddParticle(particleStorageManaged);
        }
        private void LoadJointStorage(string[] words)
        {
            JointStorageManaged jointStorageManaged = new JointStorageManaged();
            jointStorageManaged.Length = float.Parse(words[1]);
            jointStorageManaged.Weight = float.Parse(words[2]);
            jointStorageManaged.DirectionX = float.Parse(words[3]);
            jointStorageManaged.DirectionY = float.Parse(words[4]);
            jointStorageManaged.CenterX0 = float.Parse(words[5]);
            jointStorageManaged.CenterY0 = float.Parse(words[6]);
            jointStorageManaged.CenterX1 = float.Parse(words[7]);
            jointStorageManaged.CenterY1 = float.Parse(words[8]);
            jointStorageManaged.Angle0 = float.Parse(words[9]);
            jointStorageManaged.Angle1 = float.Parse(words[10]);
            this.fileManager.Storage.AddJoint(jointStorageManaged);
        }
        private void LoadJoint(string[] words)
        {
            ParticleJointManaged particleJointManaged = new ParticleJointManaged();
            particleJointManaged.Info = (ParticleInfoManaged)uint.Parse(words[1]);
            int num = int.Parse(words[2]);
            int num2 = int.Parse(words[3]);
            particleJointManaged.Length = float.Parse(words[4]);
            particleJointManaged.Weight = float.Parse(words[5]);
            particleJointManaged.Direction = new Float2Managed(float.Parse(words[6]), float.Parse(words[7]));
            particleJointManaged.Angle0 = float.Parse(words[8]);
            particleJointManaged.Angle1 = float.Parse(words[9]);
            this.fileManager.Particles.AddJoint(num, num2, particleJointManaged);
        }
        private void LoadName(string[] words)
        {
            string text = words[1];
            double num = double.Parse(words[2]);
            if (!(text == "usersX"))
            {
                this.fileManager.Config.ReadValue(text, num);
            }
        }
        private string Base64Load(string filename)
        {
            if (!File.Exists(filename))
            {
                return null;
            }
            byte[] array = File.ReadAllBytes(filename);
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            string text = "b64res/" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Path.GetFullPath(filename))).Replace("+", "-").Replace("/", "_") + Path.GetExtension(filename);
            IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
            Marshal.Copy(array, 0, intPtr, array.Length);
            system.AddFile(this.fileManager.Directory + text, intPtr, array.Length);
            Marshal.FreeHGlobal(intPtr);
            return text;
        }
        private TextureManaged LoadTexture(string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder(words[1]);
            for (int i = 2; i < words.Length; i++)
            {
                stringBuilder.Append(' ').Append(words[i]);
            }
            string text = stringBuilder.ToString();
            if (!File.Exists(text))
            {
                return null;
            }
            return this.fileManager.GetTexture(this.Base64Load(text));
        }
        private StatementScriptManaged LoadScriptStatement(string[] words)
        {
            string text = this.LoadMultilineString(words);
            return StatementScriptManaged.StatementWithString(text);
        }
        private string LoadMultilineString(string[] words)
        {
            string text = "";
            string text2 = words[0];
            if (text2 == "<<")
            {
                text2 = words[1];
            }
            int num = 0;
            for (; ; )
            {
                string text3 = this.sr.ReadLine();
                if (text3 == text2)
                {
                    break;
                }
                if (num > 0)
                {
                    text += "\n";
                }
                text += text3;
                num++;
            }
            return text;
        }
        private ParticleBodyManaged LoadParticleBody()
        {
            uint num = 0U;
            return this.LoadParticleBody(ref num);
        }
        private ParticleBodyManaged LoadParticleBody(ref uint bodyId)
        {
            return this.fileManager.RequestParticleBody(bodyId);
        }
        private AbstractScriptManaged LoadScriptExpression(ref StringReader reader)
        {
            string text = reader.ReadLine();
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }
            return AbstractScriptManaged.ExpressionWithString(text);
        }
        private ResourceManaged LoadResource(string filename)
        {
            return this.fileManager.GetResource(filename);
        }
        private MeshBodyManaged LoadMeshBody(string[] words, uint bodyid)
        {
            bodyid = uint.Parse(words[1]);
            return this.fileManager.RequestMeshBody(bodyid);
        }
        private int LoadFlags(string[] words)
        {
            string text = words[1];
            if (text == "*")
            {
                return 0;
            }
            int num = 0;
            uint num2 = 0U;
            while ((ulong)num2 < (ulong)((long)text.Length))
            {
                char c = text.ToCharArray()[(int)num2];
                if (c >= '@')
                {
                    num |= 1 << (int)c;
                }
                num2 += 1U;
            }
            return num;
        }
        private void LoadData(string canvasData, TextureManaged texture)
        {
            int size = texture.Size;
            int[] array = new int[]
            {
                -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                -1, -1, -1, 62, -1, -1, -1, 63, 52, 53,
                54, 55, 56, 57, 58, 59, 60, 61, -1, -1,
                -1, -1, -1, -1, -1, 0, 1, 2, 3, 4,
                5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
                25, -1, -1, -1, -1, -1, -1, 26, 27, 28,
                29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
                39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
                49, 50, 51, -1, -1, -1, -1, -1
            };
            char[] array2 = canvasData.ToCharArray();
            int num = 0;
            for (int i = 0; i < size; i += 3)
            {
                char c = array2[num++];
                char c2 = array2[num++];
                char c3 = array2[num++];
                char c4 = array2[num++];
                Base64CodonManaged base64CodonManaged = new Base64CodonManaged();
                base64CodonManaged._1st_6bits = (uint)array[(int)(c & '\u007f')];
                base64CodonManaged._2nd_6bits = (uint)array[(int)(c2 & '\u007f')];
                base64CodonManaged._3rd_6bits = (uint)array[(int)(c3 & '\u007f')];
                base64CodonManaged._4th_6bits = (uint)array[(int)(c4 & '\u007f')];
                texture.SetData(i, base64CodonManaged._1st_8bits);
                if (i + 1 >= size)
                {
                    break;
                }
                texture.SetData(i + 1, base64CodonManaged._2nd_8bits);
                if (i + 2 >= size)
                {
                    break;
                }
                texture.SetData(i + 2, base64CodonManaged._3rd_8bits);
            }
        }
        private SoundManaged LoadSound(string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder(words[1]);
            for (int i = 2; i < words.Length; i++)
            {
                stringBuilder.Append(" " + words[i]);
            }
            return this.fileManager.GetSound(stringBuilder.ToString());
        }
        private const int OE_BOX_POLYGON_CAPACITY = 8;
        private FileManagerManaged fileManager;
        private StringReader sr;
    }
}
