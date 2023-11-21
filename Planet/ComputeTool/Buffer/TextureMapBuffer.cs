using ComputeWorkflow;
using ComputeWorkflow.Handler;
using UnityEngine;

namespace Planet.ComputeTool
{
    public class TextureMapBuffer : RWTexture
    {
        public TextureMapBuffer(ComputeConvoy convoy, string name, RenderTexture texture) 
            : base(convoy, name, texture)
        {

        }
    }
}