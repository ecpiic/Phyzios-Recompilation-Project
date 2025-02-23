using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;
using oec;
using OECakeCurrentManaged;
namespace OECasualCSharp
{
    public class ParticleBeatCSharp
    {
        public Tools DefaultTool { get; set; }
        public ParticleBeatCSharp()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            this.DefaultTool = Tools.PencilTool;
        }
        public void SetGDILoader()
        {
            this.loader = new GDILoaderManaged(GDILoaderManaged.MODE.FROM_FILE);
            this.loader.SetPointer();
        }
        public void SetALLoader()
        {
            this.alLoader = new ALLoaderManaged(ALLoaderManaged.MODE.FROM_FILE);
            this.alLoader.LoadDll();
            this.alLoader.SetPointer();
        }
        public void ClearFileSystem()
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.Clear();
        }
        public void SetFileResource(string name, IntPtr ptr, int size)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.AddFile(name.Replace('\\', '/'), ptr, size);
        }
        public void SetCurrentDir(string path)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.SetCurrentDir(path);
        }
        public void ResetCurrentDir()
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.ResetCurrentDir();
        }
        public void OpenDirectory(string path)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.OpenDirectory(path);
        }
        public string ReadDirectory()
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            return system.ReadDirectory();
        }
        public void CloseDirectory()
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.CloseDirectory();
        }
        public void DeleteDirectory(string path)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.DeleteDirectory(path);
        }
        public void DeleteFile(string path)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            system.DeleteFile(path);
        }
        public byte[] GetFileResource(string name)
        {
            MFileSystemWrap system = MFileSystemWrap.GetSystem();
            return system.GetFileData(name);
        }
        public static byte[] GetDataFromFileName(string file)
        {
            StreamReader streamReader = new StreamReader(file);
            BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream);
            MemoryStream memoryStream = new MemoryStream();
            for (; ; )
            {
                byte[] array = binaryReader.ReadBytes(1024);
                if (array.Length == 0)
                {
                    break;
                }
                memoryStream.Write(array, 0, array.Length);
            }
            memoryStream.Close();
            binaryReader.Close();
            streamReader.Close();
            return memoryStream.ToArray();
        }
        public void SetFileResource(string file, byte[] data)
        {
            IntPtr intPtr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, intPtr, data.Length);
            this.SetFileResource(Path.GetFileName(file), intPtr, data.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void SetFileResource_SysTmpGameData(string file, byte[] data)
        {
            IntPtr intPtr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, intPtr, data.Length);
            this.SetFileResource("SysTmpGameData.oecd/" + Path.GetFileName(file), intPtr, data.Length);
            Marshal.FreeHGlobal(intPtr);
        }
        public void SetFileResource(string file)
        {
            byte[] dataFromFileName = ParticleBeatCSharp.GetDataFromFileName(file);
            this.SetFileResource(file, dataFromFileName);
        }
        public static Color GetColor(Materials material)
        {
            if (material != Materials.Fire)
            {
                switch (material)
                {
                    case Materials.Brittle:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 127,
                            G = 127,
                            R = 204
                        };
                    case Materials.Cold:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = byte.MaxValue,
                            G = 229,
                            R = 204
                        };
                    case Materials.Dense:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 153,
                            G = 76,
                            R = 76
                        };
                    case Materials.Elastic:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 127,
                            G = 204,
                            R = 204
                        };
                    case Materials.Fuel:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 102,
                            G = 153,
                            R = 204
                        };
                    case Materials.Gas:
                        return new Color
                        {
                            A = 178,
                            B = 229,
                            G = 178,
                            R = 153
                        };
                    case Materials.Hot:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 25,
                            G = 51,
                            R = byte.MaxValue
                        };
                    case Materials.Inflow:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = byte.MaxValue,
                            G = 127,
                            R = 127
                        };
                    case Materials.Kome:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 229,
                            G = 229,
                            R = byte.MaxValue
                        };
                    case Materials.Light:
                        return Colors.Orange;
                    case Materials.Mochi:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 204,
                            G = byte.MaxValue,
                            R = byte.MaxValue
                        };
                    case Materials.Outflow:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 25,
                            G = 25,
                            R = 25
                        };
                    case Materials.Powder:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 178,
                            G = 204,
                            R = 204
                        };
                    case Materials.Aqua:
                        return (Color)ColorConverter.ConvertFromString("#FF7F7FFF");
                    case Materials.Rigid:
                        return new Color
                        {
                            A = byte.MaxValue,
                            R = 153,
                            G = 153,
                            B = 153
                        };
                    case Materials.String:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 178,
                            G = 127,
                            R = 153
                        };
                    case Materials.Tensile:
                        return Colors.Silver;
                    case Materials.Users:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 102,
                            G = 238,
                            R = 51
                        };
                    case Materials.Viscous:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 102,
                            G = 127,
                            R = 51
                        };
                    case Materials.Wall:
                        return new Color
                        {
                            A = byte.MaxValue,
                            R = 153,
                            G = 102,
                            B = 76
                        };
                    case Materials.Axis:
                        return new Color
                        {
                            A = byte.MaxValue,
                            B = 102,
                            G = 102,
                            R = 102
                        };
                    case Materials.Yuki:
                        return new Color
                        {
                            A = 178,
                            B = byte.MaxValue,
                            G = byte.MaxValue,
                            R = 229
                        };
                }
                return Colors.Black;
            }
            return new Color
            {
                A = byte.MaxValue,
                B = 25,
                G = 51,
                R = byte.MaxValue
            };
        }
        public static bool IsDrawableTool(Tools tool)
        {
            return tool == Tools.BrushTool || tool == Tools.PencilTool || tool == Tools.BucketTool || tool == Tools.ShapeTool || tool == Tools.MarkerTool || tool == Tools.MaterialTool;
        }
        private static string GetAviFileName()
        {
            string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\phyzios_studio";
            string text2 = text;
            int num = 2;
            while (File.Exists(text2 + ".avi"))
            {
                text2 = text + "(" + num.ToString() + ")";
                num++;
            }
            return text2 + ".avi";
        }
        public void SetGDILoaderMFileSystem()
        {
            MFileSystemWrap mfileSystemWrap = new MFileSystemWrap();
            GDILoaderManaged gdiloaderManaged = new GDILoaderManaged(GDILoaderManaged.MODE.FROM_FILESYSTEM);
            gdiloaderManaged.FileSystem = mfileSystemWrap;
            FileManagerManaged.System = mfileSystemWrap;
            TextureManaged.Loader = gdiloaderManaged;
        }
        public void SetALLoaderMFileSystem()
        {
            this.ParticleBeat.SetALLoaderMFileSystem();
        }
        public int NumBody()
        {
            return this.ParticleBeat.NumBody();
        }
        public string GetBodyName(int bodyid)
        {
            return this.ParticleBeat.GetBodyName(bodyid);
        }
        public void LoadExTexture(string path)
        {
            this.ParticleBeat.LoadExTexture(path);
        }
        public Materials GetMaterialFromInfo(ParticleInfoManaged particleInfoManaged)
        {
            foreach (object obj in Enum.GetValues(typeof(Materials)))
            {
                Materials materials = (Materials)obj;
                if (particleInfoManaged == (ParticleDataManaged.MaterialToInfo((int)materials) | ParticleInfoManaged.Joinable))
                {
                    return materials;
                }
            }
            return Materials.NoMaterial;
        }
        private GDILoaderManaged loader;
        private ALLoaderManaged alLoader;
        public ParticleBeatManaged ParticleBeat;
    }
}
