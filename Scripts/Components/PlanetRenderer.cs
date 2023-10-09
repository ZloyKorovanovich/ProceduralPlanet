
using System.Collections;
using System.Collections.Generic;
using ProceduralPlanet.Components.Handlers;
using Unity.VisualScripting;
using UnityEngine;

namespace ProceduralPlanet.Components
{
    public class PlanetRenderer : MonoBehaviour
    {
        [SerializeField]
        private Planet _planet;
        [SerializeField]
        private string _meshTransformName = "Mesh";

        private Transform _meshTransform;
        private MeshFilter _meshFilter;
        private MeshRenderer _meshRenderer;

        private GeometryHandler _geometryHandler;
        private HeightMapHandler _heightMapHandler;
        private MeshTransformHandler _meshTransformHandler;

        private Material _material;

        private void Awake()
        {
            CreateMeshTransfrom();
            InitPlanetMeshComponents();
            InitMaterial();
            _geometryHandler.GenerateMesh();
            _meshFilter.mesh = _geometryHandler.Geometry;
        }

        private void FixedUpdate()
        {
            GenerateHeightMap();
            SetMaterialData();
        }

        private void CreateMeshTransfrom()
        {
            _meshTransform = new GameObject().transform;
            _meshTransform.name = _meshTransformName;
            _meshTransform.position = transform.position;
            _meshTransform.parent = transform;
        }

        private void InitPlanetMeshComponents()
        {
            _meshTransformHandler = new MeshTransformHandler(_meshTransform, transform);
            _geometryHandler = new GeometryHandler(_planet.Configuration.GeometryCompute, _planet.Configuration.Geometry);
            _heightMapHandler = new HeightMapHandler(_planet.Configuration.HeightMapCompute, _planet.Configuration.Biom,
                _planet.Configuration.Landscape, _planet.Configuration.HeightMap);

            _meshRenderer = _meshTransform.gameObject.AddComponent<MeshRenderer>();
            _meshFilter = _meshTransform.gameObject.AddComponent<MeshFilter>();
        }

        private void InitMaterial()
        {
            _material = new Material(_planet.Configuration.Material.ShaderReference);
            _meshRenderer.material = _material;
        }

        private void SetMaterialData()
        {
            _material.SetTexture(_planet.Configuration.Material.NameHeightMap, _heightMapHandler.HeightMap);
        }

        private void GenerateHeightMap()
        {
            _meshTransformHandler.GetPeakBounds(out Vector3 start, out Vector3 endX, out Vector3 endY, out Vector3 peak);
            _heightMapHandler.SetDynamicParametres(start, endX, endY, peak);
            _heightMapHandler.GenerateHeightMap();
        }
    }
}
