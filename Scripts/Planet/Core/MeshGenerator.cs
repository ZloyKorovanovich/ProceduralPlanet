using ComputeWorkflow.Report;
using GeometryWorkflow;
using Planet.Configuration;
using Planet.ComputeTool;
using UnityEngine;

namespace Planet.Core
{
    public class MeshGenerator : IConvoyReport
    {
        private GeometryData _geometry;
        private GenerationManager _visualizator;
        private GeometryConvoy _convoy;
        private GeometryParametres _parametres;

        public MeshGenerator(General general, Geometry geometry, Compute compute, GenerationManager visualiztor)
        {
            _visualizator = visualiztor;
            InitGeometry(geometry);
            InitGeometryParametres(general, geometry);
            InitConvoy(compute);
        }

        public void Generate()
        {
            _convoy.ProcessImmediately();
        }

        private void InitGeometryParametres(General general, Geometry geometry)
        {
            _parametres = new GeometryParametres(geometry, general);
        }

        private void InitConvoy(Compute compute)
        {
            _convoy = new GeometryConvoy(compute.Shader, compute.KernelName, _geometry, _parametres, this);
        }

        private void InitGeometry(Geometry geometry)
        {
            Vector3[] vertices = new Vector3[geometry.Resolution * geometry.Resolution];
            int[] triangles = new int[(geometry.Resolution - 1) * (geometry.Resolution - 1) * 6];
            Vector2[] uVs = new Vector2[geometry.Resolution * geometry.Resolution];

            _geometry = new GeometryData(vertices, triangles, uVs);
        }

        public void ReportConvoyEnd()
        {
            _convoy.ReadData();
            GeometryProcessor.CreateMesh(_geometry, out Mesh mesh);
            _visualizator.SetMesh(mesh);
        }
    }
}