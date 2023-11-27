using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeWorkflow
{
    public struct TextureData
    {
        public RenderTexture RenderTexture;
        public string Name;

        public TextureData(RenderTexture texture, string name)
        {
            RenderTexture = texture;
            Name = name;
        }
    }
}