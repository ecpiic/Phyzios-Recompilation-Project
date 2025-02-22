using System;
using System.Collections.Generic;
using oec;
namespace WindowsViewer
{
    internal class MaterialNames
    {
        public MaterialNames()
        {
            this.Materials = new List<MaterialNames.Material>();
        }
        public void Add(Materials idx, string name)
        {
            this.Materials.Add(new MaterialNames.Material(idx, name));
        }
        public string GetName(Materials idx)
        {
            foreach (MaterialNames.Material material in this.Materials)
            {
                if (material.GetIndex() == idx)
                {
                    return material.GetName();
                }
            }
            return string.Empty;
        }
        public Materials GetIndex(string name)
        {
            foreach (MaterialNames.Material material in this.Materials)
            {
                if (material.GetName() == name)
                {
                    return material.GetIndex();
                }
            }
            return global::oec.Materials.NoMaterial;
        }
        private List<MaterialNames.Material> Materials;
        private class Material
        {
            public Material(Materials idx, string name)
            {
                this.Name = name;
                this.Index = idx;
            }
            public string GetName()
            {
                return this.Name;
            }
            public Materials GetIndex()
            {
                return this.Index;
            }
            private string Name;
            private Materials Index;
        }
    }
}
