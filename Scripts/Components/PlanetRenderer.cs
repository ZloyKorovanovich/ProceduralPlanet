
using System.Collections;
using System.Collections.Generic;
using ProceduralPlanet.Components.Handlers;
using UnityEngine;

namespace ProceduralPlanet.Components
{
    public class PlanetRenderer : MonoBehaviour
    {
        [SerializeField]
        private Planet _planet;

        private MeshFilter _meshFilter;
        private MeshRenderer _meshRenderer;

        private GeometryHandler _geometryHandler;
        private HeightMapHandler _heightMapHandler;
        private MeshTransformHandler _meshTransformHandler;
        private MaterialHandler _materialHandler;
        private DetalisationHandler _detalisationHandler;

        private Transform _spectator;

        [SerializeField]
        private RenderTexture _heightMap;

        private void Awake()
        { 
            _spectator = Camera.main.transform;
            InitHandlers();
            _geometryHandler.GenerateMesh();
            _geometryHandler.ApplyMesh(ref _meshFilter);
            _materialHandler.ApplyMaterial(ref _meshRenderer);
        }

        private void FixedUpdate()
        {
            SetMeshRotation();
            CalculateDensity();
            GenerateHeightMap();
            SetMaterialDynamicParametres();
            _heightMap = _heightMapHandler.HeightMap;
        }

        private void InitHandlers()
        {
            _meshTransformHandler = new MeshTransformHandler(transform, _planet.Configuration.General, out _meshFilter, out _meshRenderer);
            _geometryHandler = new GeometryHandler(_planet.Configuration.GeometryCompute, _planet.Configuration.Geometry);
            _heightMapHandler = new HeightMapHandler(_planet.Configuration.HeightMapCompute, _planet.Configuration.Biom,
                _planet.Configuration.Landscape, _planet.Configuration.HeightMap);
            _materialHandler = new MaterialHandler(_planet.Configuration.Material, _planet.Configuration.General);
            _detalisationHandler = new DetalisationHandler(_planet.Configuration.Detalisation, _planet.Configuration.General);
        }

        private void SetMaterialDynamicParametres()
        {
            _materialHandler.SetDynamicShaderParametres(_heightMapHandler.HeightMap, _detalisationHandler.Density);
        }

        private void GenerateHeightMap()
        {
            _meshTransformHandler.GetRotationMatrix(out Matrix4x4 rotationMatrix);
            _heightMapHandler.SetDynamicParametres(_detalisationHandler.Density, rotationMatrix);
            _heightMapHandler.GenerateHeightMap();
        }

        private void CalculateDensity()
        {
            _detalisationHandler.CalculateDensity(transform.position, _spectator.position);
        }

        private void SetMeshRotation()
        {
            _meshTransformHandler.SetLookAtSpectator(_spectator.position);
        }
    }
}
