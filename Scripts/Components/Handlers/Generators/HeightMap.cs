using ProceduralPlanet.Generators.ExternalData;
using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public abstract class HeightMap
    {
        protected Compute _compute;

        public HeightMap(ComputeShader computeShader, string kernelName)
        {
            _compute = new Compute(computeShader, kernelName);
        }
        public abstract void GenerateHeightMap();

        public abstract void ReleaseHeightMap();
    }
}

