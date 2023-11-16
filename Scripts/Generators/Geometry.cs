using ProceduralPlanet.Generators.ExternalData;
using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public abstract class Geometry
    {
        protected Compute _compute;
        protected GeometryBuffer _bufffers;

        public Geometry(ComputeShader computeShader, string kernelName) 
        {
            _compute = new Compute(computeShader, kernelName);
        }
        public abstract void GenerateMesh(out Mesh mesh);
    }
}
