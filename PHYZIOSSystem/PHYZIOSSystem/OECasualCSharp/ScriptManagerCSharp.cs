using System;
using oec;
using PHYZIOSSystem;
namespace OECasualCSharp
{
    public class ScriptManagerCSharp
    {
        public ScriptManagerManaged ScriptManager { get; private set; }
        public ScriptManagerCSharp(ConfigurationManaged config, ModuleDataManaged modules)
        {
            this.ScriptManager = new ScriptManagerManaged(config, modules, new FileLoadManager());
        }
        public ScriptManagerCSharp(ScriptManagerManaged scriptManager)
        {
            this.ScriptManager = scriptManager;
        }
        internal void OnSimulate(SceneCSharp sceneCSharp)
        {
            this.ScriptManager.SetScene(sceneCSharp.Scene);
            this.ScriptManager.OnSimulate();
        }
        internal bool OnKeyDown(int key)
        {
            return this.ScriptManager.OnKeyDown(key);
        }
        internal bool OnKeyUp(int key)
        {
            return this.ScriptManager.OnKeyUp(key);
        }
        internal void Clear()
        {
            this.ScriptManager.Clear();
        }
        internal void SetScene(SceneCSharp sceneCSharp)
        {
            this.ScriptManager.SetScene(sceneCSharp.Scene);
        }
        internal void OnLoad(SceneCSharp sceneCSharp)
        {
            this.ScriptManager.OnLoad(sceneCSharp.Scene);
        }
        public int TryGetValue(string name)
        {
            int num = 0;
            if (this.ScriptManager.HasValue(name))
            {
                num = this.ScriptManager.GetValue(name);
            }
            return num;
        }
        public string GetStringValue(string name)
        {
            if (this.ScriptManager.HasValue(name))
            {
                return this.ScriptManager.GetValueManaged(name).ToString();
            }
            return "0";
        }
    }
}
