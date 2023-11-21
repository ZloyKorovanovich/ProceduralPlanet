using Planet.Handler;
using UnityEngine;

namespace Planet.Core
{
    public class GenerationManager
    {
        private PlanetData _data;

        private ISurfaceMesh _surfaceMesh;

        public GenerationManager(PlanetData data, ISurfaceMesh surfaceMesh)
        {
            _surfaceMesh = surfaceMesh;
        }

        public void SetMesh(Mesh mesh)
        {
            _surfaceMesh.SetMesh(mesh);
        }

        public void GenrateMesh()
        {
            MeshGenerator meshGenerator = new MeshGenerator(_data.General, _data.Geometry, _data.GeometryCompute, this);
            meshGenerator.Generate();
        }
    }
}