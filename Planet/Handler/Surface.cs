using UnityEngine;

namespace Planet.Handler
{
    public class Surface : ISurfaceMesh
    {
        private MeshFilter _meshFilter;
        private MeshRenderer _meshRenderer;

        public Surface(Transform surfaceTransform)
        {
            _meshFilter = surfaceTransform.gameObject.AddComponent<MeshFilter>();
            _meshRenderer = surfaceTransform.gameObject.AddComponent<MeshRenderer>();
        }

        public void SetMaterial(Material material)
        {
            _meshRenderer.material = material;
        }

        public void SetMesh(Mesh mesh)
        {
            _meshFilter.mesh = mesh;
        }
    }
}