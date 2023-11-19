using UnityEngine;

namespace Planet.Handler
{
    public class Surface
    {
        private Transform _meshTransform;
        private Transform _spectator;

        private MeshRenderer _meshRenderer;
        private MeshFilter _meshFilter;

        private Material _material;
        private Mesh _mesh;

        public Surface(Transform planet, Transform spectator, Mesh surfaceMesh, Shader shaderReference)
        {
            InitMeshTransform(planet);
            InitMesh(surfaceMesh);
            InitMaterial(planet.name, shaderReference);

            UpdateMaterial();
            UpdateMesh();

            _spectator = spectator;
        }

        #region Init

        private void InitMeshTransform(Transform planet)
        {
            _meshTransform = new GameObject().transform;
            _meshTransform.position = planet.position;
            _meshTransform.rotation = Quaternion.Euler(Vector3.zero);
            _meshTransform.name = planet.name + "_surfaceMesh";

            _meshRenderer = _meshTransform.gameObject.AddComponent<MeshRenderer>();
            _meshFilter = _meshTransform.gameObject.AddComponent<MeshFilter>();
        }

        private void InitMesh(Mesh mesh)
        {
            _mesh = mesh;
        }

        private void InitMaterial(string name, Shader shader)
        {
            _material = new Material(shader);
            _material.name = name;
        }

        #endregion

        #region Update

        private void UpdateMaterial()
        {
            _meshRenderer.material = _material;
        }

        private void UpdateMesh()
        {
            _meshFilter.mesh = _mesh;
        }

        #endregion

        public void Visualize()
        {
            _meshTransform.LookAt(_spectator.position);

        }
    }
}