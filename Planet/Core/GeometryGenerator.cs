using GeometryWorkflow;
using ComputeWorkflow;
using Planet.Configuration;
using Planet.ComputeTool;
using UnityEngine;

namespace Planet.Core
{
    public class MeshGenerator : IConvoyReport
    {
        private GeometryData _geometryData;

        private GenerationManager _manager;
        private GeometryConvoy _convoy;
        private GeometryParametres _parametres;

        private General _general;
        private Geometry _geometry;
        private Compute _compute;

        public MeshGenerator(General general, Geometry geometry, Compute compute, GenerationManager manager)
        {
            _manager = manager;
            _general = general;
            _geometry = geometry;
            _compute = compute;
        }

        public void Generate()
        {
            InitGeometry(_geometry);
            InitConvoy(_general, _geometry, _compute);
            _convoy.ProcessImmediately();
        }

        private void InitConvoy(General general, Geometry geometry, Compute compute)
        {
            _parametres = new GeometryParametres(geometry, general);
            _convoy = new GeometryConvoy(compute.Shader, compute.KernelName, _geometryData, _parametres, this);
        }

        private void InitGeometry(Geometry geometry)
        {
            Vector3[] vertices = new Vector3[geometry.Resolution * geometry.Resolution];
            int[] triangles = new int[(geometry.Resolution - 1) * (geometry.Resolution - 1) * 6];
            Vector2[] uVs = new Vector2[geometry.Resolution * geometry.Resolution];

            _geometryData = new GeometryData(vertices, triangles, uVs);
        }

        public void ReportConvoyEnd()
        {
            _convoy.ReadData();
            GeometryProcessor.CreateMesh(_geometryData, out Mesh mesh);
            _manager.SetMesh(mesh);
        }
    }
}