using Planet.Configuration;
using UnityEngine;

namespace Planet.Core
{
    public class GenerationManager
    {
        private General _general;
        private Geometry _geometry;
        private Compute _geometryCompute;


        public void SetMesh(Mesh mesh)
        {
            
        }

        public void GenrateMesh()
        {
            MeshGenerator meshGenerator = new MeshGenerator(_general, _geometry, _geometryCompute, this);
            meshGenerator.Generate();
        }
    }
}