using UnityEngine;

namespace ProceduralPlanet.Generators.ExternalData
{
    public static class RenderTextureProcessor
    {
        public static void SetRenderTextureToCompute(ComputeShader compute, int kernelId, string name, RenderTexture renderTexture)
        {
            compute.SetTexture(kernelId, name, renderTexture);
        }
    }
}
